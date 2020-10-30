<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVirtualHostNew
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelAbsolutePathExample = New System.Windows.Forms.Label()
        Me.LabelAbsolutePath = New System.Windows.Forms.Label()
        Me.TextBoxAbsolutePath = New System.Windows.Forms.TextBox()
        Me.LabelHostNameExample = New System.Windows.Forms.Label()
        Me.LabelHostName = New System.Windows.Forms.Label()
        Me.TextBoxHostName = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.LabelAbsolutePathExample)
        Me.GroupBox2.Controls.Add(Me.LabelAbsolutePath)
        Me.GroupBox2.Controls.Add(Me.TextBoxAbsolutePath)
        Me.GroupBox2.Controls.Add(Me.LabelHostNameExample)
        Me.GroupBox2.Controls.Add(Me.LabelHostName)
        Me.GroupBox2.Controls.Add(Me.TextBoxHostName)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBox2.Size = New System.Drawing.Size(413, 220)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add New Virtual Host"
        '
        'LabelAbsolutePathExample
        '
        Me.LabelAbsolutePathExample.AutoSize = True
        Me.LabelAbsolutePathExample.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAbsolutePathExample.ForeColor = System.Drawing.Color.Gray
        Me.LabelAbsolutePathExample.Location = New System.Drawing.Point(17, 142)
        Me.LabelAbsolutePathExample.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelAbsolutePathExample.Name = "LabelAbsolutePathExample"
        Me.LabelAbsolutePathExample.Size = New System.Drawing.Size(159, 15)
        Me.LabelAbsolutePathExample.TabIndex = 6
        Me.LabelAbsolutePathExample.Text = "Example: D:\XAMPP\htdocs\test"
        '
        'LabelAbsolutePath
        '
        Me.LabelAbsolutePath.AutoSize = True
        Me.LabelAbsolutePath.Location = New System.Drawing.Point(17, 124)
        Me.LabelAbsolutePath.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelAbsolutePath.Name = "LabelAbsolutePath"
        Me.LabelAbsolutePath.Size = New System.Drawing.Size(92, 18)
        Me.LabelAbsolutePath.TabIndex = 5
        Me.LabelAbsolutePath.Text = "Absolute Path"
        '
        'TextBoxAbsolutePath
        '
        Me.TextBoxAbsolutePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAbsolutePath.Location = New System.Drawing.Point(20, 157)
        Me.TextBoxAbsolutePath.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxAbsolutePath.Name = "TextBoxAbsolutePath"
        Me.TextBoxAbsolutePath.Size = New System.Drawing.Size(373, 25)
        Me.TextBoxAbsolutePath.TabIndex = 4
        '
        'LabelHostNameExample
        '
        Me.LabelHostNameExample.AutoSize = True
        Me.LabelHostNameExample.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHostNameExample.ForeColor = System.Drawing.Color.Gray
        Me.LabelHostNameExample.Location = New System.Drawing.Point(17, 56)
        Me.LabelHostNameExample.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelHostNameExample.Name = "LabelHostNameExample"
        Me.LabelHostNameExample.Size = New System.Drawing.Size(119, 15)
        Me.LabelHostNameExample.TabIndex = 3
        Me.LabelHostNameExample.Text = "Example: test.localhost"
        '
        'LabelHostName
        '
        Me.LabelHostName.AutoSize = True
        Me.LabelHostName.Location = New System.Drawing.Point(17, 38)
        Me.LabelHostName.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelHostName.Name = "LabelHostName"
        Me.LabelHostName.Size = New System.Drawing.Size(76, 18)
        Me.LabelHostName.TabIndex = 2
        Me.LabelHostName.Text = "Host Name"
        '
        'TextBoxHostName
        '
        Me.TextBoxHostName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxHostName.Location = New System.Drawing.Point(20, 71)
        Me.TextBoxHostName.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.TextBoxHostName.Name = "TextBoxHostName"
        Me.TextBoxHostName.Size = New System.Drawing.Size(373, 25)
        Me.TextBoxHostName.TabIndex = 1
        '
        'ButtonSave
        '
        Me.ButtonSave.AutoSize = True
        Me.ButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonSave.Location = New System.Drawing.Point(20, 260)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonSave.Size = New System.Drawing.Size(50, 32)
        Me.ButtonSave.TabIndex = 5
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.AutoSize = True
        Me.ButtonClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonClose.Location = New System.Drawing.Point(379, 260)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonClose.Size = New System.Drawing.Size(54, 32)
        Me.ButtonClose.TabIndex = 6
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'FormVirtualHostNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(479, 320)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormVirtualHostNew"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Virtual Host"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelAbsolutePathExample As Label
    Friend WithEvents LabelAbsolutePath As Label
    Friend WithEvents TextBoxAbsolutePath As TextBox
    Friend WithEvents LabelHostNameExample As Label
    Friend WithEvents LabelHostName As Label
    Friend WithEvents TextBoxHostName As TextBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonClose As Button
End Class
