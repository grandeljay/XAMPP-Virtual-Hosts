<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVirtualHostRemove
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVirtualHostRemove))
        Me.GroupBoxRemoveVirtualHost = New System.Windows.Forms.GroupBox()
        Me.ComboBoxVirtualHosts = New System.Windows.Forms.ComboBox()
        Me.LabelSelect = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.GroupBoxRemoveVirtualHost.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxRemoveVirtualHost
        '
        Me.GroupBoxRemoveVirtualHost.AutoSize = True
        Me.GroupBoxRemoveVirtualHost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxRemoveVirtualHost.Controls.Add(Me.ComboBoxVirtualHosts)
        Me.GroupBoxRemoveVirtualHost.Controls.Add(Me.LabelSelect)
        Me.GroupBoxRemoveVirtualHost.Location = New System.Drawing.Point(20, 20)
        Me.GroupBoxRemoveVirtualHost.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.GroupBoxRemoveVirtualHost.Name = "GroupBoxRemoveVirtualHost"
        Me.GroupBoxRemoveVirtualHost.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBoxRemoveVirtualHost.Size = New System.Drawing.Size(360, 120)
        Me.GroupBoxRemoveVirtualHost.TabIndex = 5
        Me.GroupBoxRemoveVirtualHost.TabStop = False
        Me.GroupBoxRemoveVirtualHost.Text = "Remove Virtual Host"
        '
        'ComboBoxVirtualHosts
        '
        Me.ComboBoxVirtualHosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVirtualHosts.FormattingEnabled = True
        Me.ComboBoxVirtualHosts.Location = New System.Drawing.Point(20, 56)
        Me.ComboBoxVirtualHosts.Margin = New System.Windows.Forms.Padding(0)
        Me.ComboBoxVirtualHosts.Name = "ComboBoxVirtualHosts"
        Me.ComboBoxVirtualHosts.Size = New System.Drawing.Size(320, 26)
        Me.ComboBoxVirtualHosts.TabIndex = 3
        '
        'LabelSelect
        '
        Me.LabelSelect.AutoSize = True
        Me.LabelSelect.Location = New System.Drawing.Point(17, 38)
        Me.LabelSelect.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelSelect.Name = "LabelSelect"
        Me.LabelSelect.Size = New System.Drawing.Size(43, 18)
        Me.LabelSelect.TabIndex = 2
        Me.LabelSelect.Text = "Select"
        '
        'ButtonClose
        '
        Me.ButtonClose.AutoSize = True
        Me.ButtonClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonClose.Location = New System.Drawing.Point(326, 160)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonClose.Size = New System.Drawing.Size(54, 32)
        Me.ButtonClose.TabIndex = 8
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.AutoSize = True
        Me.ButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonSave.Location = New System.Drawing.Point(20, 160)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonSave.Size = New System.Drawing.Size(71, 32)
        Me.ButtonSave.TabIndex = 7
        Me.ButtonSave.Text = "Remove"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'FormVirtualHostRemove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(410, 221)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.GroupBoxRemoveVirtualHost)
        Me.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormVirtualHostRemove"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remove Virtual Host"
        Me.GroupBoxRemoveVirtualHost.ResumeLayout(False)
        Me.GroupBoxRemoveVirtualHost.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxRemoveVirtualHost As GroupBox
    Friend WithEvents LabelSelect As Label
    Friend WithEvents ComboBoxVirtualHosts As ComboBox
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonSave As Button
End Class
