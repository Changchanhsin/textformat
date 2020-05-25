Public Class clsFormatScript
    Private m_sCURRENT As String   ' 当前结果，所有工作最后都放到这里，否则外部得不到数据

    Private m_sTITLE As String     ' 缓冲区，存标题用
    Private m_sCONTENT As String   ' 缓冲区，存内容用
    Private m_sTEMP As String      ' 缓冲区，临时使用
    Private m_sALL As String       ' 缓冲区，存最终合并标题和内容的结果

    ' 宏的集合
    Private m_scpMacro As clsScript


    ' 当前进度指针
    Public iProcess As Integer

    Public Sub SetMacro(scpMacro As clsScript)
        m_scpMacro = scpMacro
    End Sub

    Public Sub SetInput(sInput As String)
        m_sCURRENT = sInput
    End Sub

    Public Function GetOutput() As String
        GetOutput = m_sCURRENT
    End Function

    ' 输入是一个宏，输出是结果寄存器的值
    Public Function Run(sInput As String) As String
        Dim s() As String
        Dim i As Integer

        If Trim(sInput) = "" Then
            Run = ""
            Exit Function
        End If
        s = Split(sInput, vbCrLf)
        For i = 0 To UBound(s)
            Run = ScriptStep(s(i))
        Next
        Run = ""
    End Function

    Public Function ScriptStep(sInput As String) As String
        Dim s() As String
        Dim str As String

        If Trim(sInput) = "" Then
            ScriptStep = ""
            Exit Function
        End If
        s = Split(sInput, "|")
        Select Case Trim(UCase(s(0)))
            Case "SET"
                Select Case UCase(s(1))
                    Case "TITLE"
                        m_sTITLE = s(2)
                    Case "CONTENT"
                        m_sCONTENT = s(2)
                    Case "ALL"
                        m_sALL = s(2)
                    Case "TEMP"
                        m_sTEMP = s(2)
                    Case Else
                        m_sCURRENT = s(2)
                End Select
            Case "GET"
                Select Case UCase(s(1))
                    Case "TITLE"
                        ScriptStep = m_sTITLE
                    Case "CONTENT"
                        ScriptStep = m_sCONTENT
                    Case "ALL"
                        ScriptStep = m_sALL
                    Case "TEMP"
                        ScriptStep = m_sTEMP
                    Case Else
                        ScriptStep = m_sCURRENT
                End Select

            Case "USE"
                Select Case UCase(s(1))
                    Case "TITLE"
                        m_sCURRENT = m_sTITLE
                    Case "CONTENT"
                        m_sCURRENT = m_sCONTENT
                    Case "ALL"
                        m_sCURRENT = m_sALL
                    Case "TEMP"
                        m_sCURRENT = m_sTEMP
                End Select
            Case "PUT"
                Select Case UCase(s(1))
                    Case "TITLE"
                        m_sTITLE = m_sCURRENT
                    Case "CONTENT"
                        m_sCONTENT = m_sCURRENT
                    Case "ALL"
                        m_sALL = m_sCURRENT
                    Case "TEMP"
                        m_sTEMP = m_sCURRENT
                End Select
            Case "MAKEALL"
                m_sALL = m_sTITLE & vbCrLf & vbCrLf & vbCrLf & m_sCONTENT

            Case "REPLACE"
                m_sCURRENT = Replace(m_sCURRENT, REP(s(1)), REP(s(2)))
            Case "REMOVE"
                m_sCURRENT = Remove(m_sCURRENT, s(1), s(2))
            Case "ADDSTRING"
                m_sCURRENT = s(1) & m_sCURRENT & s(2)
            Case "PICK_TITLE", "PICKTITLE"
                m_sTITLE = GetAndCut(m_sCURRENT, s(1), s(2))
            Case "PICK_CONTENT", "PICKCONTENT"
                m_sCONTENT = GetAndCut(m_sCURRENT, s(1), s(2))
            Case "PICK"
                str = GetAndCut(m_sCURRENT, s(1), s(2))
                m_sTEMP = m_sCURRENT
                m_sCURRENT = str
            Case "TRIM"
                m_sCURRENT = TrimCrLf(m_sCURRENT)

            Case "CLEARTAG"
                m_sCURRENT = TrimCrLf(m_sCURRENT)
            Case "REMOVEWATERMARK"
                m_sCURRENT = RemoveWatermark(m_sCURRENT, s(1), s(2))
            Case "TOTRADITIONAL"
        'm_sCURRENT = tran(m_sCURRENT)
            Case "TOSIMPLIFIED"
        'm_sCURRENT = tran(m_sCURRNET)
            Case "FROMBIG5"
        'm_sCURRENT = tran(m_sCURRENT)
            Case "MATCHINGQUOTATION"
        'm_sCURRENT = MatchingQuotation(m_sCURRENT)

            Case "CLEAR"
                m_sCURRENT = ""
                m_sALL = ""
                m_sTITLE = ""
                m_sCONTENT = ""
                m_sTEMP = ""
            Case "CALL"
                Run(m_scpMacro.GetMacroByName(s(1)))
        End Select
        ScriptStep = ""
    End Function

    Private Function GetAndCut(ByRef s As String, s1 As String, s2 As String) As String
        On Error Resume Next
        Dim i, j As Integer

        Dim sLeft As String
        Dim sRight As String

        If s1 <> "" Then
            i = InStr(s, s1)
        Else
            i = 1
        End If
        If i > 0 Then
            If s2 <> "" Then
                j = InStr(i + Len(s1), s, s2)
            Else
                j = Len(s) + 1
            End If
            If j > i Then
                GetAndCut = Mid(s, i + Len(s1), j - i - Len(s1))
                If i > 1 Then
                    sLeft = Left(s, i - 1)
                Else
                    sLeft = ""
                End If
                If j < Len(s) Then
                    sRight = Right(s, Len(s) - j - Len(s2) + 1)
                Else
                    sRight = ""
                End If
                s = sLeft + sRight
            End If
        End If
    End Function

    Private Function Remove(s As String, s1 As String, s2 As String) As String
        On Error Resume Next
        Dim i, j As Integer

        Dim sLeft As String
        Dim sRight As String

        If s1 <> "" Then
            i = InStr(s, s1)
        Else
            i = 1
        End If
        If i > 0 Then
            If s2 <> "" Then
                j = InStr(i + Len(s1), s, s2)
            Else
                j = Len(s) + 1
            End If
            If j > i Then
                'Remove = Mid(s, i + Len(s1), j - i - Len(s1))
                If i > 1 Then
                    sLeft = Left(s, i - 1)
                Else
                    sLeft = ""
                End If
                If j < Len(s) Then
                    sRight = Right(s, Len(s) - j - Len(s2) + 1)
                Else
                    sRight = ""
                End If
                s = sLeft + sRight
            End If
        End If
        Remove = s
    End Function

    Private Function REP(sInput As String) As String
        REP = sInput
        REP = Replace(REP, "^p", vbCrLf)
        REP = Replace(REP, "^t", vbTab)
        REP = Replace(REP, "^d", Chr(13))
        REP = Replace(REP, "^a", Chr(10))
        REP = Replace(REP, "^^", "^")
    End Function

    Private Function TrimCrLf(sSrc As String) As String
        TrimCrLf = sSrc
        If TrimCrLf = "" Then
            Exit Function
        End If
        While Right(TrimCrLf, 1) = vbCr Or Right(TrimCrLf, 1) = vbLf Or Right(TrimCrLf, 1) = "　" Or Right(TrimCrLf, 1) = vbTab Or Right(TrimCrLf, 1) = " "
            TrimCrLf = Left(TrimCrLf, Len(TrimCrLf) - 1)
        End While
        While Left(TrimCrLf, 1) = vbCr Or Left(TrimCrLf, 1) = "　" Or Left(TrimCrLf, 1) = vbLf Or Left(TrimCrLf, 1) = vbTab Or Left(TrimCrLf, 1) = " "
            TrimCrLf = Right(TrimCrLf, Len(TrimCrLf) - 1)
        End While
    End Function

    Private Function RemoveWatermark(sText As String, sStart As String, sEnd As String) As String
        Dim s As String

        Dim s1 As String
        Dim s2 As String
        Dim i1 As Integer
        Dim i2 As Integer

        s1 = sStart
        s2 = sEnd

        s = sText
        i1 = InStr(s, s1)
        While i1 > 0
            i2 = InStr(i1, s, s2)
            If i2 > 0 Then
                s = Left(s, i1) & Right(s, Len(s) - i2 - Len(s2))
                i1 = InStr(s, s1)
            Else
                i1 = 0
            End If
        End While
        RemoveWatermark = s
    End Function

    Private Function MatchingQuotation(sText As String)
        Dim s As String
        Dim sBuffer As String
        Dim c As String
        Dim l As Long
        Dim iStatus As Integer

        Dim isCompl As Boolean

        s = Replace(sText, "&quot;", """")
        s = Replace(s, "&quot；", """")
        iStatus = 0
        isCompl = True
        sBuffer = ""
        For l = 1 To Len(s)
            c = Mid(s, l, 1)
            If InStr("“”""'", c) > 0 Then
                If isCompl = True Then
                    c = "“"
                isCompl = False
            Else
                c = "”"
                    isCompl = True
                End If
            End If
            If c = vbCr Or c = vbLf Then
                isCompl = True
            End If
            sBuffer = sBuffer & c
            iProcess = l * 100 / Len(s)
            My.Application.DoEvents()
        Next
        MatchingQuotation = sBuffer
    End Function

    Private Function ClearHtmlTag(sText As String)
        Dim s As String
        Dim sBuffer As String
        Dim c As String
        Dim l As Long
        Dim iStatus As Integer

        Dim isCompl As Boolean
        Dim isInner As Boolean

        s = Replace(sText, "&quot;", """")
        s = Replace(s, "&quot；", """")
        iStatus = 0
        isCompl = True
        isInner = False
        sBuffer = ""
        For l = 1 To Len(s)
            c = Mid(s, l, 1)
            If c = "<" Then
                isCompl = False
                c = ""
            End If
            If c = ">" And isInner = False Then
                isCompl = True
                c = ""
            End If
            If c = """" And isCompl = False And isInner = False Then
                isInner = True
                c = ""
            End If
            If c = """" And isCompl = False And isInner = True Then
                isInner = False
                c = ""
            End If
            If isCompl = False Then
                c = ""
            End If
            If isInner = True Then
                c = ""
            End If
            sBuffer = sBuffer & c
            iProcess = l * 100 / Len(s)
            My.Application.DoEvents()
        Next
        ClearHtmlTag = sBuffer
    End Function

    Private Function ResetQuotation(sText As String) As String
        Dim s As String
        Dim sBuffer As String
        Dim c As String
        Dim l As Long
        Dim iStatus As Integer

        Dim isCompl As Boolean

        s = Replace(sText, "&quot;", """")
        s = Replace(s, "&quot；", """")
        iStatus = 0
        isCompl = True
        sBuffer = ""
        For l = 1 To Len(s)
            c = Mid(s, l, 1)
            If InStr("“”""'", c) > 0 Then
                iProcess = l * 100 / Len(s)
                My.Application.DoEvents()
                If isCompl = True Then
                    c = "“"
                isCompl = False
            Else
                c = "”"
                    isCompl = True
                End If
            End If
            If c = vbCr Or c = vbLf Then
                isCompl = True
            End If
            sBuffer = sBuffer & c
            iProcess = l * 100 / Len(s)
            My.Application.DoEvents()
        Next
        ResetQuotation = sBuffer
    End Function

    Private Function KillLineByChineseBracket(sText As String) As String
        Dim s As String
        Dim sBuffer As String
        Dim c As String
        Dim l As Long
        Dim iStatus As Integer
        Dim iCrLf As Integer

        iStatus = 0
        iCrLf = 0
        sBuffer = ""
        s = sText
        For l = 1 To Len(s)
            c = Mid(s, l, 1)
            If InStr("「『 ", c) > 0 Then
                iProcess = l * 100 / Len(s)
                My.Application.DoEvents()
                iStatus = iStatus + 1
            End If
            If iStatus >= 1 Then
                If InStr("」』", c) > 0 Then
                    iProcess = l * 100 / Len(s)
                    My.Application.DoEvents()
                    iStatus = iStatus - 1
                    sBuffer = sBuffer & c
                Else
                    If c = vbCr Or c = vbLf Then
                        iCrLf = 1
                        c = ""
                    Else
                        If c = "　" And iCrLf = 1 Then
                            c = ""
                        Else
                            iCrLf = 0
                        End If
                    End If
                    sBuffer = sBuffer & c
                End If
            Else
                sBuffer = sBuffer & c
            End If
            iProcess = l * 100 / Len(s)
            My.Application.DoEvents()
        Next
        KillLineByChineseBracket = sBuffer
    End Function

End Class
