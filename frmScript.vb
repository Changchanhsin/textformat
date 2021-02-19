Public Class frmScript
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
    Private Sub frmScript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadScript()
    End Sub

    Private Sub cmdReload_Click(sender As Object, e As EventArgs) Handles cmdReload.Click
        LoadScript()
    End Sub

    Private Sub LoadScript()
        Dim f As New clsFile
        Dim s As String
        Dim sa() As String
        Dim sScript As String
        Dim sName As String

        scpMacro.Clear()
        f.Open(Application.StartupPath & "\Format.txt")
        s = f.ReadLine()
        iMacroCount = 0
        sScript = ""
        sName = ""
        iMacroMain = 0
        While Not f.isEnd
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
        f.Close()

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

    Private Sub lstMicro_DoubleClick(sender As Object, e As EventArgs) Handles lstMicro.DoubleClick
        txtScript.Text = sMacroScript(lstMicro.SelectedIndex)
        RunScript()
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
        If frmMain.txtMain.SelectedText <> "" Then
            frmMain.txtMain.SelectedText = s
        Else
            frmMain.txtMain.Text = s
        End If
    End Sub
    Private Function GetText() As String
        If frmMain.txtMain.SelectedText <> "" Then
            GetText = frmMain.txtMain.SelectedText
        Else
            GetText = frmMain.txtMain.Text
        End If
    End Function

    Private Sub txtScript_TextChanged(sender As Object, e As EventArgs) Handles txtScript.TextChanged

    End Sub
End Class