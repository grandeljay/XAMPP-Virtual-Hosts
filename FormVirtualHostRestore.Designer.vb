<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVirtualHostRestore
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
        Me.GroupBoxRestore = New System.Windows.Forms.GroupBox()
        Me.LabelSelectBackup = New System.Windows.Forms.Label()
        Me.ComboBoxVirtualHosts = New System.Windows.Forms.ComboBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonRestore = New System.Windows.Forms.Button()
        Me.GroupBoxPreview = New System.Windows.Forms.GroupBox()
        Me.TextBox_hosts = New System.Windows.Forms.TextBox()
        Me.GroupBoxRestore.SuspendLayout()
        Me.GroupBoxPreview.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxRestore
        '
        Me.GroupBoxRestore.AutoSize = True
        Me.GroupBoxRestore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxRestore.Controls.Add(Me.ComboBoxVirtualHosts)
        Me.GroupBoxRestore.Controls.Add(Me.LabelSelectBackup)
        Me.GroupBoxRestore.Location = New System.Drawing.Point(23, 28)
        Me.GroupBoxRestore.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.GroupBoxRestore.Name = "GroupBoxRestore"
        Me.GroupBoxRestore.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBoxRestore.Size = New System.Drawing.Size(633, 120)
        Me.GroupBoxRestore.TabIndex = 0
        Me.GroupBoxRestore.TabStop = False
        Me.GroupBoxRestore.Text = "Restore Virtual Host"
        '
        'LabelSelectBackup
        '
        Me.LabelSelectBackup.AutoSize = True
        Me.LabelSelectBackup.Location = New System.Drawing.Point(17, 38)
        Me.LabelSelectBackup.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelSelectBackup.Name = "LabelSelectBackup"
        Me.LabelSelectBackup.Size = New System.Drawing.Size(90, 18)
        Me.LabelSelectBackup.TabIndex = 0
        Me.LabelSelectBackup.Text = "Select Backup"
        '
        'ComboBoxVirtualHosts
        '
        Me.ComboBoxVirtualHosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVirtualHosts.FormattingEnabled = True
        Me.ComboBoxVirtualHosts.Location = New System.Drawing.Point(20, 56)
        Me.ComboBoxVirtualHosts.Margin = New System.Windows.Forms.Padding(0)
        Me.ComboBoxVirtualHosts.Name = "ComboBoxVirtualHosts"
        Me.ComboBoxVirtualHosts.Size = New System.Drawing.Size(593, 26)
        Me.ComboBoxVirtualHosts.TabIndex = 1
        '
        'ButtonClose
        '
        Me.ButtonClose.AutoSize = True
        Me.ButtonClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonClose.Location = New System.Drawing.Point(582, 522)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonClose.Size = New System.Drawing.Size(54, 32)
        Me.ButtonClose.TabIndex = 10
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonRestore
        '
        Me.ButtonRestore.AutoSize = True
        Me.ButtonRestore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonRestore.Enabled = False
        Me.ButtonRestore.Location = New System.Drawing.Point(43, 522)
        Me.ButtonRestore.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonRestore.Name = "ButtonRestore"
        Me.ButtonRestore.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonRestore.Size = New System.Drawing.Size(68, 32)
        Me.ButtonRestore.TabIndex = 9
        Me.ButtonRestore.Text = "Restore"
        Me.ButtonRestore.UseVisualStyleBackColor = True
        '
        'GroupBoxPreview
        '
        Me.GroupBoxPreview.AutoSize = True
        Me.GroupBoxPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxPreview.Controls.Add(Me.TextBox_hosts)
        Me.GroupBoxPreview.Location = New System.Drawing.Point(23, 168)
        Me.GroupBoxPreview.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.GroupBoxPreview.Name = "GroupBoxPreview"
        Me.GroupBoxPreview.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBoxPreview.Size = New System.Drawing.Size(633, 332)
        Me.GroupBoxPreview.TabIndex = 11
        Me.GroupBoxPreview.TabStop = False
        Me.GroupBoxPreview.Text = "Preview"
        '
        'TextBox_hosts
        '
        Me.TextBox_hosts.Location = New System.Drawing.Point(20, 38)
        Me.TextBox_hosts.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox_hosts.Multiline = True
        Me.TextBox_hosts.Name = "TextBox_hosts"
        Me.TextBox_hosts.ReadOnly = True
        Me.TextBox_hosts.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox_hosts.Size = New System.Drawing.Size(593, 256)
        Me.TextBox_hosts.TabIndex = 2
        Me.TextBox_hosts.WordWrap = False
        '
        'FormVirtualHostRestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(733, 607)
        Me.Controls.Add(Me.GroupBoxPreview)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonRestore)
        Me.Controls.Add(Me.GroupBoxRestore)
        Me.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormVirtualHostRestore"
        Me.Padding = New System.Windows.Forms.Padding(23, 28, 23, 28)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restore Virtual Host"
        Me.GroupBoxRestore.ResumeLayout(False)
        Me.GroupBoxRestore.PerformLayout()
        Me.GroupBoxPreview.ResumeLayout(False)
        Me.GroupBoxPreview.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxRestore As GroupBox
    Friend WithEvents LabelSelectBackup As Label
    Friend WithEvents ComboBoxVirtualHosts As ComboBox
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonRestore As Button
    Friend WithEvents GroupBoxPreview As GroupBox
    Friend WithEvents TextBox_hosts As TextBox
End Class
