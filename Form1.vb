Public Class Form1
    Dim isModified = False
    Dim isKeep = False
    Dim iHistory As Integer = 0
    Private sHistory As New List(Of String)


    Dim sMacroName(100) As String
    Dim sMacroType(100) As String
    Dim sMacroScript(100) As String
    Dim iMacroCount As Integer
    Dim iMacroMain As Integer

    Dim scpMacro As New clsScript
    Dim fscript As New clsFormatScript

    Private Function GetText() As String
        If txtSrc.SelectedText <> "" Then
            GetText = txtSrc.SelectedText
        Else
            GetText = txtSrc.Text
        End If
    End Function

    Private Sub SetText(s As String)
        If txtSrc.SelectedText <> "" Then
            txtSrc.SelectedText = s
        Else
            txtSrc.Text = s
        End If
    End Sub


    Private Sub cmdRun_TextChanged(sender As Object, e As EventArgs) Handles txtSrc.TextChanged
        'isModified = True
        'If isKeep = False Then
        'sHistory.Append(txtSrc.Text)
        'If (sHistory.Count > 100) Then
        'sHistory.RemoveAt(0)
        'End If
        'End If
    End Sub

    Private Sub txtSrc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSrc.KeyDown
        If e.KeyCode = 115 And e.Shift = 0 Then 'F4
            txtSrc.SelectedText = vbCrLf & vbCrLf & "　　"
        End If
        If e.KeyCode = 116 And e.Shift = 0 Then 'F5
            txtSrc.SelectedText = vbCrLf & "　　　　"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdReload_Click(sender As Object, e As EventArgs) Handles cmdReload.Click
        Dim f As New clsFile
        Dim s As String
        Dim sa() As String
        Dim sScript As String
        Dim sName As String

        scpMacro.Clear()
        f.FileOpen(Application.StartupPath & "\Format.txt")
        s = f.ReadLine()
        iMacroCount = 0
        sScript = ""
        sName = ""
        iMacroMain = 0
        While Not f.FileEnd
            sa = Split(s, "|")
            If sa(0) = "MACRO" Then
                If sScript <> "" Then
                    scpMacro.AddMacro(sMacroName(iMacroCount), sScript)
                    sName = sa(1)
                    sMacroScript(iMacroCount) = sScript
                    iMacroCount = iMacroCount + 1
                End If
                sMacroName(iMacroCount) = sa(1)
                sMacroType(iMacroCount) = sa(2)
                sScript = ""
            Else
                If sScript = "" Then
                    sScript = s
                Else
                    sScript = sScript & vbCrLf & s
                End If
            End If
            s = f.ReadLine()
        End While
        'sScript = s
        'sMacroName(iMacroCount) = sName
        If sScript = "" Then
            sScript = s
        Else
            sScript = sScript & vbCrLf & s
        End If
        sMacroScript(iMacroCount) = sScript
        scpMacro.AddMacro(sMacroName(iMacroCount), sScript)
        iMacroCount = iMacroCount + 1
        fscript.SetMacro(scpMacro)
        f.FileClose()

        lstMicro.Items.Clear()
        For i = 0 To iMacroCount - 1
            Select Case sMacroType(i)
                Case "MAIN"
                    lstMicro.Items.Add(sMacroName(i))
                Case "COMP"
                    lstMicro.Items.Add(sMacroName(i))
            End Select
        Next
    End Sub

    Private Sub lstMicro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMicro.SelectedIndexChanged
        txtScript.Text = sMacroScript(lstMicro.SelectedIndex)
    End Sub

    Private Sub cmdRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click
        RunScript()
    End Sub

    Private Sub RunScript()
        Dim s As String

        If txtScript.Text <> "" Then
            s = txtScript.Text
            fscript.SetInput(GetText())
            s = fscript.Run(s)
            SetToText(fscript.GetOutput())
        End If
    End Sub

    Private Sub SetToText(s As String)
        If txtSrc.SelectedText <> "" Then
            txtSrc.SelectedText = s
        Else
            txtSrc.Text = s
        End If
    End Sub

    Private Sub lstMicro_DoubleClick(sender As Object, e As EventArgs) Handles lstMicro.DoubleClick
        txtScript.Text = sMacroScript(lstMicro.SelectedIndex)
        RunScript()
    End Sub
End Class
