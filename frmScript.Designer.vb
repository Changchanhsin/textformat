<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScript
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
        Me.cmdReload = New System.Windows.Forms.Button()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.lstMicro = New System.Windows.Forms.ListBox()
        Me.txtScript = New System.Windows.Forms.TextBox()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdReload
        '
        Me.cmdReload.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdReload.Location = New System.Drawing.Point(0, 0)
        Me.cmdReload.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdReload.Name = "cmdReload"
        Me.cmdReload.Size = New System.Drawing.Size(366, 33)
        Me.cmdReload.TabIndex = 14
        Me.cmdReload.Text = "Reload"
        Me.cmdReload.UseVisualStyleBackColor = True
        '
        'cmdRemove
        '
        Me.cmdRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdRemove.Location = New System.Drawing.Point(160, 549)
        Me.cmdRemove.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(76, 33)
        Me.cmdRemove.TabIndex = 13
        Me.cmdRemove.Text = "Remove"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdUpdate.Location = New System.Drawing.Point(80, 549)
        Me.cmdUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(76, 33)
        Me.cmdUpdate.TabIndex = 12
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Location = New System.Drawing.Point(0, 549)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(76, 33)
        Me.cmdAdd.TabIndex = 11
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'lstMicro
        '
        Me.lstMicro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstMicro.FormattingEnabled = True
        Me.lstMicro.ItemHeight = 18
        Me.lstMicro.Location = New System.Drawing.Point(0, 38)
        Me.lstMicro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstMicro.Name = "lstMicro"
        Me.lstMicro.Size = New System.Drawing.Size(366, 184)
        Me.lstMicro.TabIndex = 10
        '
        'txtScript
        '
        Me.txtScript.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtScript.Location = New System.Drawing.Point(0, 225)
        Me.txtScript.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtScript.Multiline = True
        Me.txtScript.Name = "txtScript"
        Me.txtScript.Size = New System.Drawing.Size(366, 320)
        Me.txtScript.TabIndex = 9
        '
        'cmdRun
        '
        Me.cmdRun.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRun.Location = New System.Drawing.Point(243, 549)
        Me.cmdRun.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(113, 33)
        Me.cmdRun.TabIndex = 8
        Me.cmdRun.Text = "Run"
        Me.cmdRun.UseVisualStyleBackColor = True
        '
        'frmScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 593)
        Me.Controls.Add(Me.cmdReload)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lstMicro)
        Me.Controls.Add(Me.txtScript)
        Me.Controls.Add(Me.cmdRun)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmScript"
        Me.Text = "Script"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdReload As Button
    Friend WithEvents cmdRemove As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents lstMicro As ListBox
    Friend WithEvents txtScript As TextBox
    Friend WithEvents cmdRun As Button
End Class
