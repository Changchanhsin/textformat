Public Class frmMain
    Dim isUntitled = True
    Dim isChanged = False
    Dim currFilename = ""

    Const charcodeUTF8 = "UTF-8"
    Const charcodeGB = "GB2312"
    Const charcodeBIG5 = "BIG5"
    Const charcodeSJIS = "SJIS"
    Dim currCodeset = charcodeGB
    Dim sfd As New System.Windows.Forms.SaveFileDialog
    Dim ofd As New System.Windows.Forms.OpenFileDialog
    Dim f As New clsFile
    Dim fd As New FontDialog

    Private Sub UpdateFormTitle()
        If isUntitled = True Then
            Me.Text = "[Untitled]"
        Else
            Me.Text = currFilename
        End If
        If isChanged = True Then
            Me.Text = Me.Text & " *"
        End If
    End Sub

    Private Sub UpdateCodeset()
        tssCodeset.Text = currCodeset
    End Sub

    Private Sub UpdateScreen()
        txtMain.Top = menuMain.Size.Height
        If ssrMain.Visible = True Then
            txtMain.Height = Me.ClientSize.Height - menuMain.Size.Height - ssrMain.Height
        Else
            txtMain.Height = Me.ClientSize.Height - menuMain.Size.Height
        End If
    End Sub

    Private Sub LoadFile()
        f.Load(currFilename, txtMain, currCodeset)
        isChanged = False
        isUntitled = False
        UpdateFormTitle()
    End Sub

    Private Sub SaveFile()
        f.Save(currFilename, txtMain, currCodeset)
        isChanged = False
        isUntitled = False
        UpdateFormTitle()
    End Sub

    Private Sub ManageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageToolStripMenuItem.Click
        frmScript.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMain.Top = menuMain.Size.Height
        txtMain.Height = Me.ClientSize.Height - menuMain.Size.Height
        txtMain.WordWrap = False
        AutoToolStripMenuItem.Checked = txtMain.WordWrap
        StatusBarToolStripMenuItem.Checked = ssrMain.Visible
        isChanged = False
        isUntitled = True
        UpdateFormTitle()
        UpdateCodeset()
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        UpdateScreen()
    End Sub

    Private Sub AutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoToolStripMenuItem.Click
        txtMain.WordWrap = Not txtMain.WordWrap
        AutoToolStripMenuItem.Checked = txtMain.WordWrap
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        txtMain.Text = ""
        isUntitled = True
        isChanged = False
        UpdateFormTitle()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If (isUntitled = True) Then
            If sfd.ShowDialog() = DialogResult.Cancel Then
                Exit Sub
            End If
            currFilename = sfd.FileName
        End If
        SaveFile()
    End Sub

    Private Sub txtMain_TextChanged(sender As Object, e As EventArgs) Handles txtMain.TextChanged
        If isChanged = False Then
            isChanged = True
            UpdateFormTitle()
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        If (isUntitled = False) Then
            sfd.FileName = currFilename
        End If
        If sfd.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If
        currFilename = sfd.FileName
        SaveFile()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If (isUntitled = False) Then
            ofd.FileName = currFilename
        End If
        If ofd.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If
        currFilename = ofd.FileName
        LoadFile()
    End Sub

    Private Sub BIG5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BIG5ToolStripMenuItem.Click
        currCodeset = charcodeBIG5
        updateCodeset()
    End Sub

    Private Sub GB18030ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GB18030ToolStripMenuItem.Click
        currCodeset = charcodeGB
        updateCodeset()
    End Sub

    Private Sub ShiftJISToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShiftJISToolStripMenuItem.Click
        currCodeset = charcodeSJIS
        updateCodeset()
    End Sub

    Private Sub UTF8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UTF8ToolStripMenuItem.Click
        currCodeset = charcodeUTF8
        updateCodeset()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        fd.Font = txtMain.Font
        If fd.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If
        txtMain.Font = fd.Font
    End Sub

    Private Sub txtMain_DragDrop(sender As Object, e As DragEventArgs) Handles txtMain.DragDrop
        Dim filePath() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each file As String In filePath
            currFilename = file
            LoadFile()
            Exit Sub
        Next
    End Sub

    Private Sub txtMain_DragEnter(sender As Object, e As DragEventArgs) Handles txtMain.DragEnter
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.None
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AsGB18030ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsGB18030ToolStripMenuItem.Click
        currCodeset = charcodeGB
        UpdateCodeset()
        LoadFile()
    End Sub

    Private Sub AsUTF8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsUTF8ToolStripMenuItem.Click
        currCodeset = charcodeUTF8
        UpdateCodeset()
        LoadFile()
    End Sub

    Private Sub AsBIG5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsBIG5ToolStripMenuItem.Click
        currCodeset = charcodeBIG5
        UpdateCodeset()
        LoadFile()
    End Sub

    Private Sub AsShiftJISToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsShiftJISToolStripMenuItem.Click
        currCodeset = charcodeSJIS
        UpdateCodeset()
        LoadFile()
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        ssrMain.Visible = Not ssrMain.Visible
        StatusBarToolStripMenuItem.Checked = ssrMain.Visible
        UpdateScreen()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        txtMain.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        txtMain.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        txtMain.Paste()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        txtMain.SelectedText = ""
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        txtMain.SelectAll()
    End Sub

    Private Sub ZoomInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomInToolStripMenuItem.Click
        txtMain.Font = New Font(txtMain.Font.FontFamily, txtMain.Font.Size + 1)
    End Sub

    Private Sub ZoomOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomOutToolStripMenuItem.Click
        Try
            txtMain.Font = New Font(txtMain.Font.FontFamily, txtMain.Font.Size - 1)
            Exit Sub
        Catch
        End Try
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        Try
            txtMain.Font = New Font(txtMain.Font.FontFamily, 12)
            Exit Sub
        Catch
        End Try
    End Sub
End Class