Public Class clsScript

    Private m_sMacroName(200) As String
    Private m_sMacroScript(200) As String
    Private m_iMacroCount As Integer

    Public Sub Clear()
        m_iMacroCount = 0
    End Sub

    Public Sub AddMacro(sName As String, sScript As String)
        If Trim(sName) = "" Then
            If Trim(sScript) = "" Then
                Exit Sub
            End If
        End If
        m_iMacroCount = m_iMacroCount + 1
        m_sMacroName(m_iMacroCount) = sName
        m_sMacroScript(m_iMacroCount) = sScript
    End Sub

    Public Function GetMacroByIndex(i As String) As String
        If i < 0 Or i > m_iMacroCount Then
            GetMacroByIndex = ""
        End If
        GetMacroByIndex = m_sMacroScript(i)
    End Function

    Public Function GetMacroByName(sName As String) As String
        Dim i As Integer
        For i = 0 To m_iMacroCount
            If m_sMacroName(i) = sName Then
                GetMacroByName = m_sMacroScript(i)
                Exit Function
            End If
        Next
        GetMacroByName = ""
    End Function
End Class
