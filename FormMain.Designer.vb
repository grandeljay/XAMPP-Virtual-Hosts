<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ComboBoxVirtualHosts = New System.Windows.Forms.ComboBox()
        Me.TextBoxVirtualHostEntryRaw = New System.Windows.Forms.TextBox()
        Me.GroupBoxViewVirtualHosts = New System.Windows.Forms.GroupBox()
        Me.ButtonReload = New System.Windows.Forms.Button()
        Me.ButtonVirtualHostRemove = New System.Windows.Forms.Button()
        Me.LabelPreview = New System.Windows.Forms.Label()
        Me.LabelSelect = New System.Windows.Forms.Label()
        Me.ButtonVirtualHostAdd = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VirtualHostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecifyPathsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.ButtonVirtualHostRestore = New System.Windows.Forms.Button()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBoxViewVirtualHosts.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxVirtualHosts
        '
        Me.ComboBoxVirtualHosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVirtualHosts.FormattingEnabled = True
        Me.ComboBoxVirtualHosts.Location = New System.Drawing.Point(20, 56)
        Me.ComboBoxVirtualHosts.Margin = New System.Windows.Forms.Padding(0, 0, 20, 20)
        Me.ComboBoxVirtualHosts.Name = "ComboBoxVirtualHosts"
        Me.ComboBoxVirtualHosts.Size = New System.Drawing.Size(320, 26)
        Me.ComboBoxVirtualHosts.TabIndex = 0
        '
        'TextBoxVirtualHostEntryRaw
        '
        Me.TextBoxVirtualHostEntryRaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxVirtualHostEntryRaw.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVirtualHostEntryRaw.Location = New System.Drawing.Point(360, 56)
        Me.TextBoxVirtualHostEntryRaw.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxVirtualHostEntryRaw.Multiline = True
        Me.TextBoxVirtualHostEntryRaw.Name = "TextBoxVirtualHostEntryRaw"
        Me.TextBoxVirtualHostEntryRaw.ReadOnly = True
        Me.TextBoxVirtualHostEntryRaw.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxVirtualHostEntryRaw.Size = New System.Drawing.Size(450, 270)
        Me.TextBoxVirtualHostEntryRaw.TabIndex = 1
        Me.TextBoxVirtualHostEntryRaw.WordWrap = False
        '
        'GroupBoxViewVirtualHosts
        '
        Me.GroupBoxViewVirtualHosts.AutoSize = True
        Me.GroupBoxViewVirtualHosts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxViewVirtualHosts.Controls.Add(Me.ButtonVirtualHostRestore)
        Me.GroupBoxViewVirtualHosts.Controls.Add(Me.ButtonReload)
        Me.GroupBoxViewVirtualHosts.Controls.Add(Me.ButtonVirtualHostRemove)
        Me.GroupBoxViewVirtualHosts.Controls.Add(Me.LabelPreview)
        Me.GroupBoxViewVirtualHosts.Controls.Add(Me.LabelSelect)
        Me.GroupBoxViewVirtualHosts.Controls.Add(Me.ButtonVirtualHostAdd)
        Me.GroupBoxViewVirtualHosts.Controls.Add(Me.ComboBoxVirtualHosts)
        Me.GroupBoxViewVirtualHosts.Controls.Add(Me.TextBoxVirtualHostEntryRaw)
        Me.GroupBoxViewVirtualHosts.Location = New System.Drawing.Point(29, 46)
        Me.GroupBoxViewVirtualHosts.Margin = New System.Windows.Forms.Padding(20)
        Me.GroupBoxViewVirtualHosts.Name = "GroupBoxViewVirtualHosts"
        Me.GroupBoxViewVirtualHosts.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBoxViewVirtualHosts.Size = New System.Drawing.Size(830, 364)
        Me.GroupBoxViewVirtualHosts.TabIndex = 2
        Me.GroupBoxViewVirtualHosts.TabStop = False
        Me.GroupBoxViewVirtualHosts.Text = "View Virtual Hosts"
        '
        'ButtonReload
        '
        Me.ButtonReload.AutoSize = True
        Me.ButtonReload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonReload.Location = New System.Drawing.Point(19, 294)
        Me.ButtonReload.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ButtonReload.Name = "ButtonReload"
        Me.ButtonReload.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonReload.Size = New System.Drawing.Size(63, 32)
        Me.ButtonReload.TabIndex = 8
        Me.ButtonReload.Text = "Reload"
        Me.ButtonReload.UseVisualStyleBackColor = True
        '
        'ButtonVirtualHostRemove
        '
        Me.ButtonVirtualHostRemove.AutoSize = True
        Me.ButtonVirtualHostRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonVirtualHostRemove.Location = New System.Drawing.Point(19, 140)
        Me.ButtonVirtualHostRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonVirtualHostRemove.Name = "ButtonVirtualHostRemove"
        Me.ButtonVirtualHostRemove.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonVirtualHostRemove.Size = New System.Drawing.Size(145, 32)
        Me.ButtonVirtualHostRemove.TabIndex = 7
        Me.ButtonVirtualHostRemove.Text = "Remove Virtual Host"
        Me.ButtonVirtualHostRemove.UseVisualStyleBackColor = True
        '
        'LabelPreview
        '
        Me.LabelPreview.AutoSize = True
        Me.LabelPreview.Location = New System.Drawing.Point(357, 38)
        Me.LabelPreview.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPreview.Name = "LabelPreview"
        Me.LabelPreview.Size = New System.Drawing.Size(55, 18)
        Me.LabelPreview.TabIndex = 6
        Me.LabelPreview.Text = "Preview"
        '
        'LabelSelect
        '
        Me.LabelSelect.AutoSize = True
        Me.LabelSelect.Location = New System.Drawing.Point(17, 38)
        Me.LabelSelect.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelSelect.Name = "LabelSelect"
        Me.LabelSelect.Size = New System.Drawing.Size(43, 18)
        Me.LabelSelect.TabIndex = 5
        Me.LabelSelect.Text = "Select"
        '
        'ButtonVirtualHostAdd
        '
        Me.ButtonVirtualHostAdd.AutoSize = True
        Me.ButtonVirtualHostAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonVirtualHostAdd.Location = New System.Drawing.Point(19, 104)
        Me.ButtonVirtualHostAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonVirtualHostAdd.Name = "ButtonVirtualHostAdd"
        Me.ButtonVirtualHostAdd.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonVirtualHostAdd.Size = New System.Drawing.Size(120, 32)
        Me.ButtonVirtualHostAdd.TabIndex = 4
        Me.ButtonVirtualHostAdd.Text = "Add Virtual Host"
        Me.ButtonVirtualHostAdd.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VirtualHostToolStripMenuItem, Me.WindowToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(914, 26)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VirtualHostToolStripMenuItem
        '
        Me.VirtualHostToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem1, Me.RemoveToolStripMenuItem1, Me.RestoreToolStripMenuItem})
        Me.VirtualHostToolStripMenuItem.Name = "VirtualHostToolStripMenuItem"
        Me.VirtualHostToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.VirtualHostToolStripMenuItem.Text = "Virtual Host"
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AddToolStripMenuItem1.Text = "Add"
        '
        'RemoveToolStripMenuItem1
        '
        Me.RemoveToolStripMenuItem1.Name = "RemoveToolStripMenuItem1"
        Me.RemoveToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.RemoveToolStripMenuItem1.Text = "Remove"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpecifyPathsToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(69, 22)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'SpecifyPathsToolStripMenuItem
        '
        Me.SpecifyPathsToolStripMenuItem.Name = "SpecifyPathsToolStripMenuItem"
        Me.SpecifyPathsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SpecifyPathsToolStripMenuItem.Text = "Specify Paths"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(57, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Location = New System.Drawing.Point(26, 430)
        Me.LabelVersion.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(53, 18)
        Me.LabelVersion.TabIndex = 6
        Me.LabelVersion.Text = "Version"
        '
        'ButtonVirtualHostRestore
        '
        Me.ButtonVirtualHostRestore.AutoSize = True
        Me.ButtonVirtualHostRestore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonVirtualHostRestore.Location = New System.Drawing.Point(19, 176)
        Me.ButtonVirtualHostRestore.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonVirtualHostRestore.Name = "ButtonVirtualHostRestore"
        Me.ButtonVirtualHostRestore.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonVirtualHostRestore.Size = New System.Drawing.Size(142, 32)
        Me.ButtonVirtualHostRestore.TabIndex = 9
        Me.ButtonVirtualHostRestore.Text = "Restore Virtual Host"
        Me.ButtonVirtualHostRestore.UseVisualStyleBackColor = True
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(914, 472)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.GroupBoxViewVirtualHosts)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XAMPP Virtual Hosts"
        Me.GroupBoxViewVirtualHosts.ResumeLayout(False)
        Me.GroupBoxViewVirtualHosts.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxVirtualHosts As ComboBox
    Friend WithEvents TextBoxVirtualHostEntryRaw As TextBox
    Friend WithEvents GroupBoxViewVirtualHosts As GroupBox
    Friend WithEvents ButtonVirtualHostAdd As Button
    Friend WithEvents LabelPreview As Label
    Friend WithEvents LabelSelect As Label
    Friend WithEvents ButtonVirtualHostRemove As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VirtualHostToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpecifyPathsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonReload As Button
    Friend WithEvents LabelVersion As Label
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonVirtualHostRestore As Button
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
End Class
