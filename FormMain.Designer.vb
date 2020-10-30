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
        Me.ButtonAddNewVirtualHost = New System.Windows.Forms.Button()
        Me.GroupBoxViewVirtualHosts.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxVirtualHosts
        '
        Me.ComboBoxVirtualHosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVirtualHosts.FormattingEnabled = True
        Me.ComboBoxVirtualHosts.Location = New System.Drawing.Point(20, 38)
        Me.ComboBoxVirtualHosts.Margin = New System.Windows.Forms.Padding(0, 0, 20, 20)
        Me.ComboBoxVirtualHosts.Name = "ComboBoxVirtualHosts"
        Me.ComboBoxVirtualHosts.Size = New System.Drawing.Size(320, 26)
        Me.ComboBoxVirtualHosts.TabIndex = 0
        '
        'TextBoxVirtualHostEntryRaw
        '
        Me.TextBoxVirtualHostEntryRaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxVirtualHostEntryRaw.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVirtualHostEntryRaw.Location = New System.Drawing.Point(360, 38)
        Me.TextBoxVirtualHostEntryRaw.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxVirtualHostEntryRaw.Multiline = True
        Me.TextBoxVirtualHostEntryRaw.Name = "TextBoxVirtualHostEntryRaw"
        Me.TextBoxVirtualHostEntryRaw.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxVirtualHostEntryRaw.Size = New System.Drawing.Size(437, 236)
        Me.TextBoxVirtualHostEntryRaw.TabIndex = 1
        Me.TextBoxVirtualHostEntryRaw.WordWrap = False
        '
        'GroupBoxViewVirtualHosts
        '
        Me.GroupBoxViewVirtualHosts.AutoSize = True
        Me.GroupBoxViewVirtualHosts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxViewVirtualHosts.Controls.Add(Me.ButtonAddNewVirtualHost)
        Me.GroupBoxViewVirtualHosts.Controls.Add(Me.ComboBoxVirtualHosts)
        Me.GroupBoxViewVirtualHosts.Controls.Add(Me.TextBoxVirtualHostEntryRaw)
        Me.GroupBoxViewVirtualHosts.Location = New System.Drawing.Point(20, 20)
        Me.GroupBoxViewVirtualHosts.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.GroupBoxViewVirtualHosts.Name = "GroupBoxViewVirtualHosts"
        Me.GroupBoxViewVirtualHosts.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBoxViewVirtualHosts.Size = New System.Drawing.Size(817, 312)
        Me.GroupBoxViewVirtualHosts.TabIndex = 2
        Me.GroupBoxViewVirtualHosts.TabStop = False
        Me.GroupBoxViewVirtualHosts.Text = "View Virtual Hosts"
        '
        'ButtonAddNewVirtualHost
        '
        Me.ButtonAddNewVirtualHost.AutoSize = True
        Me.ButtonAddNewVirtualHost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonAddNewVirtualHost.Location = New System.Drawing.Point(20, 84)
        Me.ButtonAddNewVirtualHost.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonAddNewVirtualHost.Name = "ButtonAddNewVirtualHost"
        Me.ButtonAddNewVirtualHost.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonAddNewVirtualHost.Size = New System.Drawing.Size(150, 32)
        Me.ButtonAddNewVirtualHost.TabIndex = 4
        Me.ButtonAddNewVirtualHost.Text = "Add New Virtual Host"
        Me.ButtonAddNewVirtualHost.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1026, 574)
        Me.Controls.Add(Me.GroupBoxViewVirtualHosts)
        Me.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XAMPP Virtual Hosts"
        Me.GroupBoxViewVirtualHosts.ResumeLayout(False)
        Me.GroupBoxViewVirtualHosts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxVirtualHosts As ComboBox
    Friend WithEvents TextBoxVirtualHostEntryRaw As TextBox
    Friend WithEvents GroupBoxViewVirtualHosts As GroupBox
    Friend WithEvents ButtonAddNewVirtualHost As Button
End Class
