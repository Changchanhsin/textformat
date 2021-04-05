<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
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
        Me.ScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddNormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSubTitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddReferenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRightAlignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPageBreakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveTrimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReplaceFullToHalfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplaceSingleToDoubleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ssrMain = New System.Windows.Forms.StatusStrip()
        Me.tssCodeset = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menuMain.SuspendLayout()
        Me.ssrMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMain
        '
        resources.ApplyResources(Me.txtMain, "txtMain")
        Me.txtMain.AllowDrop = True
        Me.txtMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMain.HideSelection = False
        Me.txtMain.Name = "txtMain"
        '
        'menuMain
        '
        resources.ApplyResources(Me.menuMain, "menuMain")
        Me.menuMain.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.menuMain.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ScriptToolStripMenuItem, Me.FormatToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menuMain.Name = "menuMain"
        '
        'FileToolStripMenuItem
        '
        resources.ApplyResources(Me.FileToolStripMenuItem, "FileToolStripMenuItem")
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ReopenToolStripMenuItem, Me.ToolStripMenuItem7, Me.SaveToolStripMenuItem, Me.ChangeEncodingToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        '
        'NewToolStripMenuItem
        '
        resources.ApplyResources(Me.NewToolStripMenuItem, "NewToolStripMenuItem")
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        '
        'OpenToolStripMenuItem
        '
        resources.ApplyResources(Me.OpenToolStripMenuItem, "OpenToolStripMenuItem")
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        '
        'ReopenToolStripMenuItem
        '
        resources.ApplyResources(Me.ReopenToolStripMenuItem, "ReopenToolStripMenuItem")
        Me.ReopenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsGB18030ToolStripMenuItem, Me.AsUTF8ToolStripMenuItem, Me.AsBIG5ToolStripMenuItem, Me.AsShiftJISToolStripMenuItem})
        Me.ReopenToolStripMenuItem.Name = "ReopenToolStripMenuItem"
        '
        'AsGB18030ToolStripMenuItem
        '
        resources.ApplyResources(Me.AsGB18030ToolStripMenuItem, "AsGB18030ToolStripMenuItem")
        Me.AsGB18030ToolStripMenuItem.Name = "AsGB18030ToolStripMenuItem"
        '
        'AsUTF8ToolStripMenuItem
        '
        resources.ApplyResources(Me.AsUTF8ToolStripMenuItem, "AsUTF8ToolStripMenuItem")
        Me.AsUTF8ToolStripMenuItem.Name = "AsUTF8ToolStripMenuItem"
        '
        'AsBIG5ToolStripMenuItem
        '
        resources.ApplyResources(Me.AsBIG5ToolStripMenuItem, "AsBIG5ToolStripMenuItem")
        Me.AsBIG5ToolStripMenuItem.Name = "AsBIG5ToolStripMenuItem"
        '
        'AsShiftJISToolStripMenuItem
        '
        resources.ApplyResources(Me.AsShiftJISToolStripMenuItem, "AsShiftJISToolStripMenuItem")
        Me.AsShiftJISToolStripMenuItem.Name = "AsShiftJISToolStripMenuItem"
        '
        'ToolStripMenuItem7
        '
        resources.ApplyResources(Me.ToolStripMenuItem7, "ToolStripMenuItem7")
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        '
        'SaveToolStripMenuItem
        '
        resources.ApplyResources(Me.SaveToolStripMenuItem, "SaveToolStripMenuItem")
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        '
        'ChangeEncodingToolStripMenuItem
        '
        resources.ApplyResources(Me.ChangeEncodingToolStripMenuItem, "ChangeEncodingToolStripMenuItem")
        Me.ChangeEncodingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GB18030ToolStripMenuItem, Me.UTF8ToolStripMenuItem, Me.BIG5ToolStripMenuItem, Me.ShiftJISToolStripMenuItem})
        Me.ChangeEncodingToolStripMenuItem.Name = "ChangeEncodingToolStripMenuItem"
        '
        'GB18030ToolStripMenuItem
        '
        resources.ApplyResources(Me.GB18030ToolStripMenuItem, "GB18030ToolStripMenuItem")
        Me.GB18030ToolStripMenuItem.Name = "GB18030ToolStripMenuItem"
        '
        'UTF8ToolStripMenuItem
        '
        resources.ApplyResources(Me.UTF8ToolStripMenuItem, "UTF8ToolStripMenuItem")
        Me.UTF8ToolStripMenuItem.Name = "UTF8ToolStripMenuItem"
        '
        'BIG5ToolStripMenuItem
        '
        resources.ApplyResources(Me.BIG5ToolStripMenuItem, "BIG5ToolStripMenuItem")
        Me.BIG5ToolStripMenuItem.Name = "BIG5ToolStripMenuItem"
        '
        'ShiftJISToolStripMenuItem
        '
        resources.ApplyResources(Me.ShiftJISToolStripMenuItem, "ShiftJISToolStripMenuItem")
        Me.ShiftJISToolStripMenuItem.Name = "ShiftJISToolStripMenuItem"
        '
        'SaveAsToolStripMenuItem
        '
        resources.ApplyResources(Me.SaveAsToolStripMenuItem, "SaveAsToolStripMenuItem")
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        '
        'ToolStripMenuItem1
        '
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        '
        'ExitToolStripMenuItem
        '
        resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        '
        'EditToolStripMenuItem
        '
        resources.ApplyResources(Me.EditToolStripMenuItem, "EditToolStripMenuItem")
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripMenuItem2, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripMenuItem3, Me.FindToolStripMenuItem, Me.FindNextToolStripMenuItem, Me.PrevToolStripMenuItem, Me.GotoToolStripMenuItem, Me.ToolStripMenuItem4, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        '
        'UndoToolStripMenuItem
        '
        resources.ApplyResources(Me.UndoToolStripMenuItem, "UndoToolStripMenuItem")
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        '
        'RedoToolStripMenuItem
        '
        resources.ApplyResources(Me.RedoToolStripMenuItem, "RedoToolStripMenuItem")
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        '
        'ToolStripMenuItem2
        '
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        '
        'CutToolStripMenuItem
        '
        resources.ApplyResources(Me.CutToolStripMenuItem, "CutToolStripMenuItem")
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        '
        'CopyToolStripMenuItem
        '
        resources.ApplyResources(Me.CopyToolStripMenuItem, "CopyToolStripMenuItem")
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        '
        'PasteToolStripMenuItem
        '
        resources.ApplyResources(Me.PasteToolStripMenuItem, "PasteToolStripMenuItem")
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        '
        'DeleteToolStripMenuItem
        '
        resources.ApplyResources(Me.DeleteToolStripMenuItem, "DeleteToolStripMenuItem")
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        '
        'ToolStripMenuItem3
        '
        resources.ApplyResources(Me.ToolStripMenuItem3, "ToolStripMenuItem3")
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        '
        'FindToolStripMenuItem
        '
        resources.ApplyResources(Me.FindToolStripMenuItem, "FindToolStripMenuItem")
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        '
        'FindNextToolStripMenuItem
        '
        resources.ApplyResources(Me.FindNextToolStripMenuItem, "FindNextToolStripMenuItem")
        Me.FindNextToolStripMenuItem.Name = "FindNextToolStripMenuItem"
        '
        'PrevToolStripMenuItem
        '
        resources.ApplyResources(Me.PrevToolStripMenuItem, "PrevToolStripMenuItem")
        Me.PrevToolStripMenuItem.Name = "PrevToolStripMenuItem"
        '
        'GotoToolStripMenuItem
        '
        resources.ApplyResources(Me.GotoToolStripMenuItem, "GotoToolStripMenuItem")
        Me.GotoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NextTitleToolStripMenuItem, Me.PrevTitleToolStripMenuItem, Me.ToolStripMenuItem8, Me.NextSubTitleToolStripMenuItem, Me.PrevSubTitleToolStripMenuItem})
        Me.GotoToolStripMenuItem.Name = "GotoToolStripMenuItem"
        '
        'NextTitleToolStripMenuItem
        '
        resources.ApplyResources(Me.NextTitleToolStripMenuItem, "NextTitleToolStripMenuItem")
        Me.NextTitleToolStripMenuItem.Name = "NextTitleToolStripMenuItem"
        '
        'PrevTitleToolStripMenuItem
        '
        resources.ApplyResources(Me.PrevTitleToolStripMenuItem, "PrevTitleToolStripMenuItem")
        Me.PrevTitleToolStripMenuItem.Name = "PrevTitleToolStripMenuItem"
        '
        'ToolStripMenuItem8
        '
        resources.ApplyResources(Me.ToolStripMenuItem8, "ToolStripMenuItem8")
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        '
        'NextSubTitleToolStripMenuItem
        '
        resources.ApplyResources(Me.NextSubTitleToolStripMenuItem, "NextSubTitleToolStripMenuItem")
        Me.NextSubTitleToolStripMenuItem.Name = "NextSubTitleToolStripMenuItem"
        '
        'PrevSubTitleToolStripMenuItem
        '
        resources.ApplyResources(Me.PrevSubTitleToolStripMenuItem, "PrevSubTitleToolStripMenuItem")
        Me.PrevSubTitleToolStripMenuItem.Name = "PrevSubTitleToolStripMenuItem"
        '
        'ToolStripMenuItem4
        '
        resources.ApplyResources(Me.ToolStripMenuItem4, "ToolStripMenuItem4")
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        '
        'SelectAllToolStripMenuItem
        '
        resources.ApplyResources(Me.SelectAllToolStripMenuItem, "SelectAllToolStripMenuItem")
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        '
        'ScriptToolStripMenuItem
        '
        resources.ApplyResources(Me.ScriptToolStripMenuItem, "ScriptToolStripMenuItem")
        Me.ScriptToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageToolStripMenuItem, Me.ToolStripMenuItem5, Me.AddNormalToolStripMenuItem, Me.AddTitleToolStripMenuItem, Me.AddSubTitleToolStripMenuItem, Me.AddReferenceToolStripMenuItem, Me.AddRightAlignToolStripMenuItem, Me.AddPageBreakToolStripMenuItem, Me.ToolStripMenuItem9, Me.RemoveTrimToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.ToolStripMenuItem10, Me.ReplaceFullToHalfToolStripMenuItem, Me.ReplaceSingleToDoubleToolStripMenuItem})
        Me.ScriptToolStripMenuItem.Name = "ScriptToolStripMenuItem"
        '
        'ManageToolStripMenuItem
        '
        resources.ApplyResources(Me.ManageToolStripMenuItem, "ManageToolStripMenuItem")
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        '
        'ToolStripMenuItem5
        '
        resources.ApplyResources(Me.ToolStripMenuItem5, "ToolStripMenuItem5")
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        '
        'AddNormalToolStripMenuItem
        '
        resources.ApplyResources(Me.AddNormalToolStripMenuItem, "AddNormalToolStripMenuItem")
        Me.AddNormalToolStripMenuItem.Name = "AddNormalToolStripMenuItem"
        '
        'AddTitleToolStripMenuItem
        '
        resources.ApplyResources(Me.AddTitleToolStripMenuItem, "AddTitleToolStripMenuItem")
        Me.AddTitleToolStripMenuItem.Name = "AddTitleToolStripMenuItem"
        '
        'AddSubTitleToolStripMenuItem
        '
        resources.ApplyResources(Me.AddSubTitleToolStripMenuItem, "AddSubTitleToolStripMenuItem")
        Me.AddSubTitleToolStripMenuItem.Name = "AddSubTitleToolStripMenuItem"
        '
        'AddReferenceToolStripMenuItem
        '
        resources.ApplyResources(Me.AddReferenceToolStripMenuItem, "AddReferenceToolStripMenuItem")
        Me.AddReferenceToolStripMenuItem.Name = "AddReferenceToolStripMenuItem"
        '
        'AddRightAlignToolStripMenuItem
        '
        resources.ApplyResources(Me.AddRightAlignToolStripMenuItem, "AddRightAlignToolStripMenuItem")
        Me.AddRightAlignToolStripMenuItem.Name = "AddRightAlignToolStripMenuItem"
        '
        'AddPageBreakToolStripMenuItem
        '
        resources.ApplyResources(Me.AddPageBreakToolStripMenuItem, "AddPageBreakToolStripMenuItem")
        Me.AddPageBreakToolStripMenuItem.Name = "AddPageBreakToolStripMenuItem"
        '
        'ToolStripMenuItem9
        '
        resources.ApplyResources(Me.ToolStripMenuItem9, "ToolStripMenuItem9")
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        '
        'RemoveTrimToolStripMenuItem
        '
        resources.ApplyResources(Me.RemoveTrimToolStripMenuItem, "RemoveTrimToolStripMenuItem")
        Me.RemoveTrimToolStripMenuItem.Name = "RemoveTrimToolStripMenuItem"
        '
        'RemoveToolStripMenuItem
        '
        resources.ApplyResources(Me.RemoveToolStripMenuItem, "RemoveToolStripMenuItem")
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        '
        'ToolStripMenuItem10
        '
        resources.ApplyResources(Me.ToolStripMenuItem10, "ToolStripMenuItem10")
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        '
        'ReplaceFullToHalfToolStripMenuItem
        '
        resources.ApplyResources(Me.ReplaceFullToHalfToolStripMenuItem, "ReplaceFullToHalfToolStripMenuItem")
        Me.ReplaceFullToHalfToolStripMenuItem.Name = "ReplaceFullToHalfToolStripMenuItem"
        '
        'ReplaceSingleToDoubleToolStripMenuItem
        '
        resources.ApplyResources(Me.ReplaceSingleToDoubleToolStripMenuItem, "ReplaceSingleToDoubleToolStripMenuItem")
        Me.ReplaceSingleToDoubleToolStripMenuItem.Name = "ReplaceSingleToDoubleToolStripMenuItem"
        '
        'FormatToolStripMenuItem
        '
        resources.ApplyResources(Me.FormatToolStripMenuItem, "FormatToolStripMenuItem")
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        '
        'AutoToolStripMenuItem
        '
        resources.ApplyResources(Me.AutoToolStripMenuItem, "AutoToolStripMenuItem")
        Me.AutoToolStripMenuItem.Checked = True
        Me.AutoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutoToolStripMenuItem.Name = "AutoToolStripMenuItem"
        '
        'FontToolStripMenuItem
        '
        resources.ApplyResources(Me.FontToolStripMenuItem, "FontToolStripMenuItem")
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        '
        'ViewToolStripMenuItem
        '
        resources.ApplyResources(Me.ViewToolStripMenuItem, "ViewToolStripMenuItem")
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomToolStripMenuItem, Me.StatusBarToolStripMenuItem, Me.ShowScriptToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        '
        'ZoomToolStripMenuItem
        '
        resources.ApplyResources(Me.ZoomToolStripMenuItem, "ZoomToolStripMenuItem")
        Me.ZoomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomInToolStripMenuItem, Me.ZoomOutToolStripMenuItem, Me.RestoreToolStripMenuItem})
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        '
        'ZoomInToolStripMenuItem
        '
        resources.ApplyResources(Me.ZoomInToolStripMenuItem, "ZoomInToolStripMenuItem")
        Me.ZoomInToolStripMenuItem.Name = "ZoomInToolStripMenuItem"
        '
        'ZoomOutToolStripMenuItem
        '
        resources.ApplyResources(Me.ZoomOutToolStripMenuItem, "ZoomOutToolStripMenuItem")
        Me.ZoomOutToolStripMenuItem.Name = "ZoomOutToolStripMenuItem"
        '
        'RestoreToolStripMenuItem
        '
        resources.ApplyResources(Me.RestoreToolStripMenuItem, "RestoreToolStripMenuItem")
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        '
        'StatusBarToolStripMenuItem
        '
        resources.ApplyResources(Me.StatusBarToolStripMenuItem, "StatusBarToolStripMenuItem")
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        '
        'ShowScriptToolStripMenuItem
        '
        resources.ApplyResources(Me.ShowScriptToolStripMenuItem, "ShowScriptToolStripMenuItem")
        Me.ShowScriptToolStripMenuItem.Checked = True
        Me.ShowScriptToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowScriptToolStripMenuItem.Name = "ShowScriptToolStripMenuItem"
        '
        'HelpToolStripMenuItem
        '
        resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        '
        'HelpToolStripMenuItem1
        '
        resources.ApplyResources(Me.HelpToolStripMenuItem1, "HelpToolStripMenuItem1")
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        '
        'AboutToolStripMenuItem
        '
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        '
        'ssrMain
        '
        resources.ApplyResources(Me.ssrMain, "ssrMain")
        Me.ssrMain.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ssrMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssCodeset})
        Me.ssrMain.Name = "ssrMain"
        '
        'tssCodeset
        '
        resources.ApplyResources(Me.tssCodeset, "tssCodeset")
        Me.tssCodeset.Name = "tssCodeset"
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ssrMain)
        Me.Controls.Add(Me.txtMain)
        Me.Controls.Add(Me.menuMain)
        Me.MainMenuStrip = Me.menuMain
        Me.Name = "frmMain"
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
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents AddNormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddTitleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddSubTitleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddReferenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddRightAlignToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddPageBreakToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripSeparator
    Friend WithEvents RemoveTrimToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripSeparator
    Friend WithEvents ReplaceFullToHalfToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReplaceSingleToDoubleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ShowScriptToolStripMenuItem As ToolStripMenuItem
End Class
