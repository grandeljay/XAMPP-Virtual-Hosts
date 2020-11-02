<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPathsSpecify
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBoxHosts = New System.Windows.Forms.GroupBox()
        Me.LabelHostsDirectoryDescription = New System.Windows.Forms.Label()
        Me.PictureBoxHostsProgress = New System.Windows.Forms.PictureBox()
        Me.TextBoxHostsDirectory = New System.Windows.Forms.TextBox()
        Me.TimerUpdateDirectory = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelHttpdVhostsConfDirectoryDescription = New System.Windows.Forms.Label()
        Me.LabelHttpdVhostsConfDirectory = New System.Windows.Forms.Label()
        Me.PictureBoxHttpdVhostsConfProgress = New System.Windows.Forms.PictureBox()
        Me.TextBoxHttpdVhostsConfDirectory = New System.Windows.Forms.TextBox()
        Me.ButtonSaveAndClose = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.GroupBoxHosts.SuspendLayout()
        CType(Me.PictureBoxHostsProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxHttpdVhostsConfProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxHosts
        '
        Me.GroupBoxHosts.AutoSize = True
        Me.GroupBoxHosts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxHosts.Controls.Add(Me.LabelHostsDirectoryDescription)
        Me.GroupBoxHosts.Controls.Add(Me.PictureBoxHostsProgress)
        Me.GroupBoxHosts.Controls.Add(Me.TextBoxHostsDirectory)
        Me.GroupBoxHosts.Location = New System.Drawing.Point(20, 20)
        Me.GroupBoxHosts.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.GroupBoxHosts.Name = "GroupBoxHosts"
        Me.GroupBoxHosts.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBoxHosts.Size = New System.Drawing.Size(475, 137)
        Me.GroupBoxHosts.TabIndex = 0
        Me.GroupBoxHosts.TabStop = False
        Me.GroupBoxHosts.Text = "Hosts"
        '
        'LabelHostsDirectoryDescription
        '
        Me.LabelHostsDirectoryDescription.Location = New System.Drawing.Point(17, 63)
        Me.LabelHostsDirectoryDescription.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelHostsDirectoryDescription.Name = "LabelHostsDirectoryDescription"
        Me.LabelHostsDirectoryDescription.Size = New System.Drawing.Size(438, 36)
        Me.LabelHostsDirectoryDescription.TabIndex = 3
        Me.LabelHostsDirectoryDescription.Text = "Please specify the location of your hosts file. This process can not be automated" &
    " for the hosts file."
        '
        'PictureBoxHostsProgress
        '
        Me.PictureBoxHostsProgress.Location = New System.Drawing.Point(20, 38)
        Me.PictureBoxHostsProgress.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBoxHostsProgress.Name = "PictureBoxHostsProgress"
        Me.PictureBoxHostsProgress.Size = New System.Drawing.Size(25, 25)
        Me.PictureBoxHostsProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxHostsProgress.TabIndex = 1
        Me.PictureBoxHostsProgress.TabStop = False
        '
        'TextBoxHostsDirectory
        '
        Me.TextBoxHostsDirectory.Location = New System.Drawing.Point(45, 38)
        Me.TextBoxHostsDirectory.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxHostsDirectory.Name = "TextBoxHostsDirectory"
        Me.TextBoxHostsDirectory.Size = New System.Drawing.Size(410, 25)
        Me.TextBoxHostsDirectory.TabIndex = 0
        '
        'TimerUpdateDirectory
        '
        Me.TimerUpdateDirectory.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.LabelHttpdVhostsConfDirectoryDescription)
        Me.GroupBox1.Controls.Add(Me.LabelHttpdVhostsConfDirectory)
        Me.GroupBox1.Controls.Add(Me.PictureBoxHttpdVhostsConfProgress)
        Me.GroupBox1.Controls.Add(Me.TextBoxHttpdVhostsConfDirectory)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 177)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBox1.Size = New System.Drawing.Size(475, 173)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "httpd-vhosts.conf"
        '
        'LabelHttpdVhostsConfDirectoryDescription
        '
        Me.LabelHttpdVhostsConfDirectoryDescription.Location = New System.Drawing.Point(17, 63)
        Me.LabelHttpdVhostsConfDirectoryDescription.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelHttpdVhostsConfDirectoryDescription.Name = "LabelHttpdVhostsConfDirectoryDescription"
        Me.LabelHttpdVhostsConfDirectoryDescription.Size = New System.Drawing.Size(438, 36)
        Me.LabelHttpdVhostsConfDirectoryDescription.TabIndex = 3
        Me.LabelHttpdVhostsConfDirectoryDescription.Text = "Please specify the location of your httpd-vhosts.conf file. This is optional, you" &
    " could also just wait until it is automatically found."
        '
        'LabelHttpdVhostsConfDirectory
        '
        Me.LabelHttpdVhostsConfDirectory.ForeColor = System.Drawing.Color.Gray
        Me.LabelHttpdVhostsConfDirectory.Location = New System.Drawing.Point(17, 117)
        Me.LabelHttpdVhostsConfDirectory.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelHttpdVhostsConfDirectory.Name = "LabelHttpdVhostsConfDirectory"
        Me.LabelHttpdVhostsConfDirectory.Size = New System.Drawing.Size(438, 18)
        Me.LabelHttpdVhostsConfDirectory.TabIndex = 2
        Me.LabelHttpdVhostsConfDirectory.Text = "Getting progress..."
        '
        'PictureBoxHttpdVhostsConfProgress
        '
        Me.PictureBoxHttpdVhostsConfProgress.Location = New System.Drawing.Point(20, 38)
        Me.PictureBoxHttpdVhostsConfProgress.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBoxHttpdVhostsConfProgress.Name = "PictureBoxHttpdVhostsConfProgress"
        Me.PictureBoxHttpdVhostsConfProgress.Size = New System.Drawing.Size(25, 25)
        Me.PictureBoxHttpdVhostsConfProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxHttpdVhostsConfProgress.TabIndex = 1
        Me.PictureBoxHttpdVhostsConfProgress.TabStop = False
        '
        'TextBoxHttpdVhostsConfDirectory
        '
        Me.TextBoxHttpdVhostsConfDirectory.Location = New System.Drawing.Point(45, 38)
        Me.TextBoxHttpdVhostsConfDirectory.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxHttpdVhostsConfDirectory.Name = "TextBoxHttpdVhostsConfDirectory"
        Me.TextBoxHttpdVhostsConfDirectory.Size = New System.Drawing.Size(410, 25)
        Me.TextBoxHttpdVhostsConfDirectory.TabIndex = 0
        '
        'ButtonSaveAndClose
        '
        Me.ButtonSaveAndClose.AutoSize = True
        Me.ButtonSaveAndClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonSaveAndClose.Location = New System.Drawing.Point(20, 370)
        Me.ButtonSaveAndClose.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ButtonSaveAndClose.Name = "ButtonSaveAndClose"
        Me.ButtonSaveAndClose.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonSaveAndClose.Size = New System.Drawing.Size(97, 32)
        Me.ButtonSaveAndClose.TabIndex = 9
        Me.ButtonSaveAndClose.Text = "Save && Close"
        Me.ButtonSaveAndClose.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.AutoSize = True
        Me.ButtonClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonClose.Location = New System.Drawing.Point(441, 370)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonClose.Size = New System.Drawing.Size(54, 32)
        Me.ButtonClose.TabIndex = 10
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'FormPathsSpecify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(736, 506)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonSaveAndClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxHosts)
        Me.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormPathsSpecify"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Specify Paths"
        Me.GroupBoxHosts.ResumeLayout(False)
        Me.GroupBoxHosts.PerformLayout()
        CType(Me.PictureBoxHostsProgress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxHttpdVhostsConfProgress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxHosts As GroupBox
    Friend WithEvents TextBoxHostsDirectory As TextBox
    Friend WithEvents PictureBoxHostsProgress As PictureBox
    Friend WithEvents TimerUpdateDirectory As Timer
    Friend WithEvents LabelHostsDirectoryDescription As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelHttpdVhostsConfDirectoryDescription As Label
    Friend WithEvents LabelHttpdVhostsConfDirectory As Label
    Friend WithEvents PictureBoxHttpdVhostsConfProgress As PictureBox
    Friend WithEvents TextBoxHttpdVhostsConfDirectory As TextBox
    Friend WithEvents ButtonSaveAndClose As Button
    Friend WithEvents ButtonClose As Button
End Class
