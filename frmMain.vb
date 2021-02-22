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
        frmScript.Show()
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

    Private Sub NextTitleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextTitleToolStripMenuItem.Click
        If txtMain.SelectionStart > 0 Then
            txtMain.SelectionStart = InStr(txtMain.SelectionStart + 1, txtMain.Text, vbCrLf & vbCrLf & vbCrLf)
            txtMain.SelectionLength = 3
        Else
            txtMain.SelectionStart = InStr(txtMain.Text, vbCrLf & vbCrLf & vbCrLf)
            txtMain.SelectionLength = 3
        End If
        txtMain.ScrollToCaret()
    End Sub

    Private Sub PrevTitleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrevTitleToolStripMenuItem.Click
        If txtMain.SelectionStart > 0 Then
            txtMain.SelectionStart = InStrRev(txtMain.Text, vbCrLf & vbCrLf & vbCrLf, txtMain.SelectionStart - 1)
            txtMain.SelectionLength = 5
        Else
            txtMain.SelectionStart = InStrRev(txtMain.Text, vbCrLf & vbCrLf & vbCrLf)
            txtMain.SelectionLength = 5
        End If
        txtMain.ScrollToCaret()
    End Sub

    Private Sub NextSubTitleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextSubTitleToolStripMenuItem.Click
        If txtMain.SelectionStart > 0 Then
            txtMain.SelectionStart = InStr(txtMain.SelectionStart + 1, txtMain.Text, vbCrLf & vbCrLf & "　　　　")
            txtMain.SelectionLength = 7
        Else
            txtMain.SelectionStart = InStr(txtMain.Text, vbCrLf & vbCrLf & "　　　　")
            txtMain.SelectionLength = 7
        End If
        txtMain.ScrollToCaret()
    End Sub

    Private Sub PrevSubTitleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrevSubTitleToolStripMenuItem.Click
        If txtMain.SelectionStart > 0 Then
            txtMain.SelectionStart = InStrRev(txtMain.Text, vbCrLf & vbCrLf & "　　　　", txtMain.SelectionStart - 1)
            txtMain.SelectionLength = 7
        Else
            txtMain.SelectionStart = InStrRev(txtMain.Text, vbCrLf & vbCrLf & "　　　　")
            txtMain.SelectionLength = 7
        End If
        txtMain.ScrollToCaret()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If txtMain.CanUndo Then
            txtMain.Undo()
        End If
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        If txtMain.CanUndo Then
            txtMain.Undo()
        End If
    End Sub

    Private Sub AddSubTitleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSubTitleToolStripMenuItem.Click
        txtMain.Paste(vbCrLf & vbCrLf & "　　　　")
    End Sub

    Private Sub AddTitleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTitleToolStripMenuItem.Click
        txtMain.Paste(vbCrLf & vbCrLf)
    End Sub

    Private Sub AddNormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNormalToolStripMenuItem.Click
        txtMain.Paste(vbCrLf & "　　")
    End Sub

    Private Sub RemoveTrimToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveTrimToolStripMenuItem.Click
        txtMain.Text = txtMain.Text.Replace(" " & vbCrLf, vbCrLf)
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        txtMain.Text = txtMain.Text.Replace(vbCrLf & vbCrLf & vbCrLf, vbCrLf & vbCrLf)
    End Sub

    Private Sub ReplaceFullToHalfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceFullToHalfToolStripMenuItem.Click
        txtMain.Text = txtMain.Text.Replace("０", "0")
        txtMain.Text = txtMain.Text.Replace("１", "1")
        txtMain.Text = txtMain.Text.Replace("２", "2")
        txtMain.Text = txtMain.Text.Replace("３", "3")
        txtMain.Text = txtMain.Text.Replace("４", "4")
        txtMain.Text = txtMain.Text.Replace("５", "5")
        txtMain.Text = txtMain.Text.Replace("６", "6")
        txtMain.Text = txtMain.Text.Replace("７", "7")
        txtMain.Text = txtMain.Text.Replace("８", "8")
        txtMain.Text = txtMain.Text.Replace("９", "9")
        txtMain.Text = txtMain.Text.Replace("ａ", "a")
        txtMain.Text = txtMain.Text.Replace("ｂ", "b")
        txtMain.Text = txtMain.Text.Replace("ｃ", "c")
        txtMain.Text = txtMain.Text.Replace("ｄ", "d")
        txtMain.Text = txtMain.Text.Replace("ｅ", "e")
        txtMain.Text = txtMain.Text.Replace("ｆ", "f")
        txtMain.Text = txtMain.Text.Replace("ｇ", "g")
        txtMain.Text = txtMain.Text.Replace("ｈ", "h")
        txtMain.Text = txtMain.Text.Replace("ｉ", "i")
        txtMain.Text = txtMain.Text.Replace("ｊ", "j")
        txtMain.Text = txtMain.Text.Replace("ｋ", "k")
        txtMain.Text = txtMain.Text.Replace("ｌ", "l")
        txtMain.Text = txtMain.Text.Replace("ｍ", "m")
        txtMain.Text = txtMain.Text.Replace("ｎ", "n")
        txtMain.Text = txtMain.Text.Replace("ｏ", "o")
        txtMain.Text = txtMain.Text.Replace("ｐ", "p")
        txtMain.Text = txtMain.Text.Replace("ｑ", "q")
        txtMain.Text = txtMain.Text.Replace("ｒ", "r")
        txtMain.Text = txtMain.Text.Replace("ｓ", "s")
        txtMain.Text = txtMain.Text.Replace("ｔ", "t")
        txtMain.Text = txtMain.Text.Replace("ｕ", "u")
        txtMain.Text = txtMain.Text.Replace("ｖ", "v")
        txtMain.Text = txtMain.Text.Replace("ｗ", "w")
        txtMain.Text = txtMain.Text.Replace("ｘ", "x")
        txtMain.Text = txtMain.Text.Replace("ｙ", "y")
        txtMain.Text = txtMain.Text.Replace("ｚ", "z")
        txtMain.Text = txtMain.Text.Replace("Ａ", "A")
        txtMain.Text = txtMain.Text.Replace("Ｂ", "B")
        txtMain.Text = txtMain.Text.Replace("Ｃ", "C")
        txtMain.Text = txtMain.Text.Replace("Ｄ", "D")
        txtMain.Text = txtMain.Text.Replace("Ｅ", "E")
        txtMain.Text = txtMain.Text.Replace("Ｆ", "F")
        txtMain.Text = txtMain.Text.Replace("Ｇ", "G")
        txtMain.Text = txtMain.Text.Replace("Ｈ", "H")
        txtMain.Text = txtMain.Text.Replace("Ｉ", "I")
        txtMain.Text = txtMain.Text.Replace("Ｊ", "J")
        txtMain.Text = txtMain.Text.Replace("Ｋ", "K")
        txtMain.Text = txtMain.Text.Replace("Ｌ", "L")
        txtMain.Text = txtMain.Text.Replace("Ｍ", "M")
        txtMain.Text = txtMain.Text.Replace("Ｎ", "N")
        txtMain.Text = txtMain.Text.Replace("Ｏ", "O")
        txtMain.Text = txtMain.Text.Replace("Ｐ", "P")
        txtMain.Text = txtMain.Text.Replace("Ｑ", "Q")
        txtMain.Text = txtMain.Text.Replace("Ｒ", "R")
        txtMain.Text = txtMain.Text.Replace("Ｓ", "S")
        txtMain.Text = txtMain.Text.Replace("Ｔ", "T")
        txtMain.Text = txtMain.Text.Replace("Ｕ", "U")
        txtMain.Text = txtMain.Text.Replace("Ｖ", "V")
        txtMain.Text = txtMain.Text.Replace("Ｗ", "W")
        txtMain.Text = txtMain.Text.Replace("Ｘ", "X")
        txtMain.Text = txtMain.Text.Replace("Ｙ", "Y")
        txtMain.Text = txtMain.Text.Replace("Ｚ", "Z")
    End Sub

    Private Sub ReplaceSingleToDoubleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceSingleToDoubleToolStripMenuItem.Click
        txtMain.Text = txtMain.Text.Replace(vbCrLf, vbCrLf & vbCrLf)
    End Sub

    Private Sub AddReferenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddReferenceToolStripMenuItem.Click
        txtMain.Paste(vbCrLf & "　　　")
    End Sub

    Private Sub AddRightAlignToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRightAlignToolStripMenuItem.Click
        txtMain.Paste(vbCrLf & "　　　　　　　　")
    End Sub

    Private Sub AddPageBreakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPageBreakToolStripMenuItem.Click
        txtMain.Paste(vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf)
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        frmSearch.Show()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        frmHelp.Show()
    End Sub
End Class