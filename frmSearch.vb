Public Class frmSearch
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If InStr(txtSearch.Text, vbCrLf) > 0 Then
            txtSearch.Text = txtSearch.Text.Replace(vbCrLf, "^p")
            txtSearch.SelectionStart = txtSearch.Text.Length
        End If
    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        Dim i As Integer

        If (txtSearch.Text.Length = 0) Then
            Exit Sub
        End If
        i = frmMain.txtMain.SelectionStart + frmMain.txtMain.SelectionLength + 1
        If (i <= 0) Then
            i = 1
        End If
        i = InStr(i, frmMain.txtMain.Text, Replace(txtSearch.Text, "^p", vbCrLf))
        If (i <= 0) Then
            frmMain.txtMain.SelectionStart = 0
            frmMain.txtMain.SelectionLength = 0
            frmMain.txtMain.ScrollToCaret()
            Exit Sub
        End If
        frmMain.txtMain.Select(i - 1, txtSearch.Text.Length)
        frmMain.txtMain.ScrollToCaret()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMain.txtMain.Text = Replace(frmMain.txtMain.Text,
                                       Replace(txtSearch.Text, "^p", vbCrLf),
                                       Replace(txtReplace.Text, "^p", vbCrLf))
    End Sub

    Private Sub txtReplace_TextChanged(sender As Object, e As EventArgs) Handles txtReplace.TextChanged
        If InStr(txtReplace.Text, vbCrLf) > 0 Then
            txtReplace.Text = txtReplace.Text.Replace(vbCrLf, "^p")
            txtReplace.SelectionStart = txtReplace.Text.Length
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer

        If (txtSearch.Text.Length = 0) Then
            Exit Sub
        End If
        i = frmMain.txtMain.SelectionStart + frmMain.txtMain.SelectionLength + 1
        If (i <= 0) Then
            i = 1
        End If
        i = InStr(i, frmMain.txtMain.Text, Replace(txtSearch.Text, "^p", vbCrLf))
        If (i <= 0) Then
            frmMain.txtMain.SelectionStart = 0
            frmMain.txtMain.SelectionLength = 0
            frmMain.txtMain.ScrollToCaret()
            Exit Sub
        End If
        frmMain.txtMain.Select(i - 1, Replace(txtSearch.Text, "^p", vbCrLf).Length)
        frmMain.txtMain.ScrollToCaret()
        frmMain.txtMain.Paste(Replace(txtReplace.Text, "^p", vbCrLf))
        frmMain.txtMain.Select(i - 1, Replace(txtReplace.Text, "^p", vbCrLf).Length)
    End Sub
End Class