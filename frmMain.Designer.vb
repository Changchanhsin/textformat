<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtMain = New System.Windows.Forms.TextBox()
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReopenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsGB18030ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsUTF8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsBIG5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsShiftJISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeEncodingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GB18030ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UTF8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BIG5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShiftJISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindNextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrevToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextTitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrevTitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.NextSubTitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrevSubTitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ssrMain = New System.Windows.Forms.StatusStrip()
        Me.tssCodeset = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menuMain.SuspendLayout()
        Me.ssrMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMain
        '
        Me.txtMain.AllowDrop = True
        Me.txtMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMain.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtMain.Location = New System.Drawing.Point(0, 42)
        Me.txtMain.MaxLength = 33554432
        Me.txtMain.Multiline = True
        Me.txtMain.Name = "txtMain"
        Me.txtMain.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMain.Size = New System.Drawing.Size(565, 193)
        Me.txtMain.TabIndex = 0
        '
        'menuMain
        '
        Me.menuMain.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.menuMain.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ScriptToolStripMenuItem, Me.FormatToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Size = New System.Drawing.Size(565, 48)
        Me.menuMain.TabIndex = 1
        Me.menuMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ReopenToolStripMenuItem, Me.ToolStripMenuItem7, Me.SaveToolStripMenuItem, Me.ChangeEncodingToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(73, 38)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(410, 44)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(410, 44)
        Me.OpenToolStripMenuItem.Text = "&Open..."
        '
        'ReopenToolStripMenuItem
        '
        Me.ReopenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsGB18030ToolStripMenuItem, Me.AsUTF8ToolStripMenuItem, Me.AsBIG5ToolStripMenuItem, Me.AsShiftJISToolStripMenuItem})
        Me.ReopenToolStripMenuItem.Name = "ReopenToolStripMenuItem"
        Me.ReopenToolStripMenuItem.Size = New System.Drawing.Size(410, 44)
        Me.ReopenToolStripMenuItem.Text = "&Reopen Encoding As"
        '
        'AsGB18030ToolStripMenuItem
        '
        Me.AsGB18030ToolStripMenuItem.Name = "AsGB18030ToolStripMenuItem"
        Me.AsGB18030ToolStripMenuItem.Size = New System.Drawing.Size(407, 44)
        Me.AsGB18030ToolStripMenuItem.Text = "&GB2312/GBK/GB18030"
        '
        'AsUTF8ToolStripMenuItem
        '
        Me.AsUTF8ToolStripMenuItem.Name = "AsUTF8ToolStripMenuItem"
        Me.AsUTF8ToolStripMenuItem.Size = New System.Drawing.Size(407, 44)
        Me.AsUTF8ToolStripMenuItem.Text = "&UTF-8"
        '
        'AsBIG5ToolStripMenuItem
        '
        Me.AsBIG5ToolStripMenuItem.Name = "AsBIG5ToolStripMenuItem"
        Me.AsBIG5ToolStripMenuItem.Size = New System.Drawing.Size(407, 44)
        Me.AsBIG5ToolStripMenuItem.Text = "&BIG-5"
        '
        'AsShiftJISToolStripMenuItem
        '
        Me.AsShiftJISToolStripMenuItem.Name = "AsShiftJISToolStripMenuItem"
        Me.AsShiftJISToolStripMenuItem.Size = New System.Drawing.Size(407, 44)
        Me.AsShiftJISToolStripMenuItem.Text = "Shift-&JIS"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(407, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(410, 44)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'ChangeEncodingToolStripMenuItem
        '
        Me.ChangeEncodingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GB18030ToolStripMenuItem, Me.UTF8ToolStripMenuItem, Me.BIG5ToolStripMenuItem, Me.ShiftJISToolStripMenuItem})
        Me.ChangeEncodingToolStripMenuItem.Name = "ChangeEncodingToolStripMenuItem"
        Me.ChangeEncodingToolStripMenuItem.Size = New System.Drawing.Size(410, 44)
        Me.ChangeEncodingToolStripMenuItem.Text = "&Change Encoding"
        '
        'GB18030ToolStripMenuItem
        '
        Me.GB18030ToolStripMenuItem.Name = "GB18030ToolStripMenuItem"
        Me.GB18030ToolStripMenuItem.Size = New System.Drawing.Size(407, 44)
        Me.GB18030ToolStripMenuItem.Text = "&GB2312/GBK/GB18030"
        '
        'UTF8ToolStripMenuItem
        '
        Me.UTF8ToolStripMenuItem.Name = "UTF8ToolStripMenuItem"
        Me.UTF8ToolStripMenuItem.Size = New System.Drawing.Size(407, 44)
        Me.UTF8ToolStripMenuItem.Text = "&UTF-8"
        '
        'BIG5ToolStripMenuItem
        '
        Me.BIG5ToolStripMenuItem.Name = "BIG5ToolStripMenuItem"
        Me.BIG5ToolStripMenuItem.Size = New System.Drawing.Size(407, 44)
        Me.BIG5ToolStripMenuItem.Text = "&BIG-5"
        '
        'ShiftJISToolStripMenuItem
        '
        Me.ShiftJISToolStripMenuItem.Name = "ShiftJISToolStripMenuItem"
        Me.ShiftJISToolStripMenuItem.Size = New System.Drawing.Size(407, 44)
        Me.ShiftJISToolStripMenuItem.Text = "Shift-&JIS"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(410, 44)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(407, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(410, 44)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripMenuItem2, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripMenuItem3, Me.FindToolStripMenuItem, Me.FindNextToolStripMenuItem, Me.PrevToolStripMenuItem, Me.GotoToolStripMenuItem, Me.ToolStripMenuItem4, Me.SelectAllToolStripMenuItem, Me.ToolStripMenuItem5})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(77, 38)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(450, 44)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(450, 44)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(362, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(450, 44)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(450, 44)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(450, 44)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(450, 44)
        Me.DeleteToolStripMenuItem.Text = "De&lete"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(362, 6)
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(450, 44)
        Me.FindToolStripMenuItem.Text = "&Find And Replace..."
        '
        'FindNextToolStripMenuItem
        '
        Me.FindNextToolStripMenuItem.Name = "FindNextToolStripMenuItem"
        Me.FindNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.FindNextToolStripMenuItem.Size = New System.Drawing.Size(450, 44)
        Me.FindNextToolStripMenuItem.Text = "&Next"
        '
        'PrevToolStripMenuItem
        '
        Me.PrevToolStripMenuItem.Name = "PrevToolStripMenuItem"
        Me.PrevToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.PrevToolStripMenuItem.Size = New System.Drawing.Size(450, 44)
        Me.PrevToolStripMenuItem.Text = "Pre&v"
        '
        'GotoToolStripMenuItem
        '
        Me.GotoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NextTitleToolStripMenuItem, Me.PrevTitleToolStripMenuItem, Me.ToolStripMenuItem8, Me.NextSubTitleToolStripMenuItem, Me.PrevSubTitleToolStripMenuItem})
        Me.GotoToolStripMenuItem.Name = "GotoToolStripMenuItem"
        Me.GotoToolStripMenuItem.Size = New System.Drawing.Size(450, 44)
        Me.GotoToolStripMenuItem.Text = "&Goto"
        '
        'NextTitleToolStripMenuItem
        '
        Me.NextTitleToolStripMenuItem.Name = "NextTitleToolStripMenuItem"
        Me.NextTitleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.NextTitleToolStripMenuItem.Size = New System.Drawing.Size(467, 44)
        Me.NextTitleToolStripMenuItem.Text = "Next Title"
        '
        'PrevTitleToolStripMenuItem
        '
        Me.PrevTitleToolStripMenuItem.Name = "PrevTitleToolStripMenuItem"
        Me.PrevTitleToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.PrevTitleToolStripMenuItem.Size = New System.Drawing.Size(467, 44)
        Me.PrevTitleToolStripMenuItem.Text = "Prev Title"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(299, 6)
        '
        'NextSubTitleToolStripMenuItem
        '
        Me.NextSubTitleToolStripMenuItem.Name = "NextSubTitleToolStripMenuItem"
        Me.NextSubTitleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.NextSubTitleToolStripMenuItem.Size = New System.Drawing.Size(467, 44)
        Me.NextSubTitleToolStripMenuItem.Text = "Next SubTitle"
        '
        'PrevSubTitleToolStripMenuItem
        '
        Me.PrevSubTitleToolStripMenuItem.Name = "PrevSubTitleToolStripMenuItem"
        Me.PrevSubTitleToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.PrevSubTitleToolStripMenuItem.Size = New System.Drawing.Size(467, 44)
        Me.PrevSubTitleToolStripMenuItem.Text = "Prev SubTitle"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(362, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(450, 44)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(362, 6)
        '
        'ScriptToolStripMenuItem
        '
        Me.ScriptToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageToolStripMenuItem})
        Me.ScriptToolStripMenuItem.Name = "ScriptToolStripMenuItem"
        Me.ScriptToolStripMenuItem.Size = New System.Drawing.Size(99, 44)
        Me.ScriptToolStripMenuItem.Text = "&Script"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(335, 44)
        Me.ManageToolStripMenuItem.Text = "&Manage"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(115, 38)
        Me.FormatToolStripMenuItem.Text = "F&ormat"
        '
        'AutoToolStripMenuItem
        '
        Me.AutoToolStripMenuItem.Checked = True
        Me.AutoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutoToolStripMenuItem.Name = "AutoToolStripMenuItem"
        Me.AutoToolStripMenuItem.Size = New System.Drawing.Size(271, 44)
        Me.AutoToolStripMenuItem.Text = "Auto &Warp"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(271, 44)
        Me.FontToolStripMenuItem.Text = "&Font..."
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomToolStripMenuItem, Me.StatusBarToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(89, 38)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomInToolStripMenuItem, Me.ZoomOutToolStripMenuItem, Me.RestoreToolStripMenuItem})
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.ZoomToolStripMenuItem.Text = "&Zoom"
        '
        'ZoomInToolStripMenuItem
        '
        Me.ZoomInToolStripMenuItem.Name = "ZoomInToolStripMenuItem"
        Me.ZoomInToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Oemplus), System.Windows.Forms.Keys)
        Me.ZoomInToolStripMenuItem.Size = New System.Drawing.Size(458, 44)
        Me.ZoomInToolStripMenuItem.Text = "Zoom &in"
        '
        'ZoomOutToolStripMenuItem
        '
        Me.ZoomOutToolStripMenuItem.Name = "ZoomOutToolStripMenuItem"
        Me.ZoomOutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.OemMinus), System.Windows.Forms.Keys)
        Me.ZoomOutToolStripMenuItem.Size = New System.Drawing.Size(458, 44)
        Me.ZoomOutToolStripMenuItem.Text = "Zoom &out"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D0), System.Windows.Forms.Keys)
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(458, 44)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(262, 44)
        Me.StatusBarToolStripMenuItem.Text = "&Status Bar"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(88, 44)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'ssrMain
        '
        Me.ssrMain.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ssrMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssCodeset})
        Me.ssrMain.Location = New System.Drawing.Point(0, 251)
        Me.ssrMain.Name = "ssrMain"
        Me.ssrMain.Size = New System.Drawing.Size(565, 41)
        Me.ssrMain.TabIndex = 2
        Me.ssrMain.Text = "StatusStrip1"
        '
        'tssCodeset
        '
        Me.tssCodeset.Name = "tssCodeset"
        Me.tssCodeset.Size = New System.Drawing.Size(139, 31)
        Me.tssCodeset.Text = "tssCodeset"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 292)
        Me.Controls.Add(Me.ssrMain)
        Me.Controls.Add(Me.txtMain)
        Me.Controls.Add(Me.menuMain)
        Me.MainMenuStrip = Me.menuMain
        Me.Name = "frmMain"
        Me.Text = "Text"
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.ssrMain.ResumeLayout(False)
        Me.ssrMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMain As TextBox
    Friend WithEvents menuMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindNextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrevToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GotoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents ScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReopenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsGB18030ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsUTF8ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsBIG5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsShiftJISToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeEncodingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GB18030ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UTF8ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BIG5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShiftJISToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ssrMain As StatusStrip
    Friend WithEvents tssCodeset As ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItem7 As ToolStripSeparator
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextTitleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrevTitleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripSeparator
    Friend WithEvents NextSubTitleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrevSubTitleToolStripMenuItem As ToolStripMenuItem
End Class
