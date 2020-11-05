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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPathsSpecify))
        Me.GroupBoxHosts = New System.Windows.Forms.GroupBox()
        Me.LabelHostsDirectoryDescription = New System.Windows.Forms.Label()
        Me.PictureBoxProgressHosts = New System.Windows.Forms.PictureBox()
        Me.TextBoxDirectoryHosts = New System.Windows.Forms.TextBox()
        Me.TimerDirectoryHttpdVhostsConf = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelHttpdVhostsConfDirectoryDescription = New System.Windows.Forms.Label()
        Me.LabelProgressHttpdVhostsConf = New System.Windows.Forms.Label()
        Me.PictureBoxProgressHttpdVhostsConf = New System.Windows.Forms.PictureBox()
        Me.TextBoxDirectoryHttpdVhostsConf = New System.Windows.Forms.TextBox()
        Me.ButtonSaveAndClose = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.FlowLayoutPanelMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelControls = New System.Windows.Forms.Panel()
        Me.GroupBoxXAMPP = New System.Windows.Forms.GroupBox()
        Me.LabelXAMPPDescription = New System.Windows.Forms.Label()
        Me.LabelProgressXAMPP = New System.Windows.Forms.Label()
        Me.PictureBoxProgressXAMPP = New System.Windows.Forms.PictureBox()
        Me.TextBoxDirectoryXAMPP = New System.Windows.Forms.TextBox()
        Me.TimerDirectoryXAMPP = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxHosts.SuspendLayout()
        CType(Me.PictureBoxProgressHosts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxProgressHttpdVhostsConf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanelMain.SuspendLayout()
        Me.PanelControls.SuspendLayout()
        Me.GroupBoxXAMPP.SuspendLayout()
        CType(Me.PictureBoxProgressXAMPP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxHosts
        '
        Me.GroupBoxHosts.AutoSize = True
        Me.GroupBoxHosts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxHosts.Controls.Add(Me.LabelHostsDirectoryDescription)
        Me.GroupBoxHosts.Controls.Add(Me.PictureBoxProgressHosts)
        Me.GroupBoxHosts.Controls.Add(Me.TextBoxDirectoryHosts)
        Me.GroupBoxHosts.Location = New System.Drawing.Point(0, 0)
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
        'PictureBoxProgressHosts
        '
        Me.PictureBoxProgressHosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxProgressHosts.Location = New System.Drawing.Point(20, 38)
        Me.PictureBoxProgressHosts.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.PictureBoxProgressHosts.Name = "PictureBoxProgressHosts"
        Me.PictureBoxProgressHosts.Size = New System.Drawing.Size(25, 25)
        Me.PictureBoxProgressHosts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxProgressHosts.TabIndex = 1
        Me.PictureBoxProgressHosts.TabStop = False
        '
        'TextBoxDirectoryHosts
        '
        Me.TextBoxDirectoryHosts.Location = New System.Drawing.Point(47, 38)
        Me.TextBoxDirectoryHosts.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxDirectoryHosts.Name = "TextBoxDirectoryHosts"
        Me.TextBoxDirectoryHosts.Size = New System.Drawing.Size(408, 25)
        Me.TextBoxDirectoryHosts.TabIndex = 0
        '
        'TimerDirectoryHttpdVhostsConf
        '
        Me.TimerDirectoryHttpdVhostsConf.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.LabelHttpdVhostsConfDirectoryDescription)
        Me.GroupBox1.Controls.Add(Me.LabelProgressHttpdVhostsConf)
        Me.GroupBox1.Controls.Add(Me.PictureBoxProgressHttpdVhostsConf)
        Me.GroupBox1.Controls.Add(Me.TextBoxDirectoryHttpdVhostsConf)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 350)
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
        'LabelProgressHttpdVhostsConf
        '
        Me.LabelProgressHttpdVhostsConf.ForeColor = System.Drawing.Color.Gray
        Me.LabelProgressHttpdVhostsConf.Location = New System.Drawing.Point(17, 117)
        Me.LabelProgressHttpdVhostsConf.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelProgressHttpdVhostsConf.Name = "LabelProgressHttpdVhostsConf"
        Me.LabelProgressHttpdVhostsConf.Size = New System.Drawing.Size(438, 18)
        Me.LabelProgressHttpdVhostsConf.TabIndex = 2
        Me.LabelProgressHttpdVhostsConf.Text = "Getting progress..."
        Me.LabelProgressHttpdVhostsConf.Visible = False
        '
        'PictureBoxProgressHttpdVhostsConf
        '
        Me.PictureBoxProgressHttpdVhostsConf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxProgressHttpdVhostsConf.Location = New System.Drawing.Point(20, 38)
        Me.PictureBoxProgressHttpdVhostsConf.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.PictureBoxProgressHttpdVhostsConf.Name = "PictureBoxProgressHttpdVhostsConf"
        Me.PictureBoxProgressHttpdVhostsConf.Size = New System.Drawing.Size(25, 25)
        Me.PictureBoxProgressHttpdVhostsConf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxProgressHttpdVhostsConf.TabIndex = 1
        Me.PictureBoxProgressHttpdVhostsConf.TabStop = False
        '
        'TextBoxDirectoryHttpdVhostsConf
        '
        Me.TextBoxDirectoryHttpdVhostsConf.Location = New System.Drawing.Point(47, 38)
        Me.TextBoxDirectoryHttpdVhostsConf.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxDirectoryHttpdVhostsConf.Name = "TextBoxDirectoryHttpdVhostsConf"
        Me.TextBoxDirectoryHttpdVhostsConf.Size = New System.Drawing.Size(408, 25)
        Me.TextBoxDirectoryHttpdVhostsConf.TabIndex = 0
        '
        'ButtonSaveAndClose
        '
        Me.ButtonSaveAndClose.AutoSize = True
        Me.ButtonSaveAndClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonSaveAndClose.Location = New System.Drawing.Point(20, 0)
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
        Me.ButtonClose.Location = New System.Drawing.Point(401, 0)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonClose.Size = New System.Drawing.Size(54, 32)
        Me.ButtonClose.TabIndex = 10
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanelMain
        '
        Me.FlowLayoutPanelMain.AutoSize = True
        Me.FlowLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanelMain.Controls.Add(Me.GroupBoxHosts)
        Me.FlowLayoutPanelMain.Controls.Add(Me.GroupBoxXAMPP)
        Me.FlowLayoutPanelMain.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanelMain.Controls.Add(Me.PanelControls)
        Me.FlowLayoutPanelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanelMain.Location = New System.Drawing.Point(23, 23)
        Me.FlowLayoutPanelMain.Name = "FlowLayoutPanelMain"
        Me.FlowLayoutPanelMain.Size = New System.Drawing.Size(475, 575)
        Me.FlowLayoutPanelMain.TabIndex = 11
        '
        'PanelControls
        '
        Me.PanelControls.AutoSize = True
        Me.PanelControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelControls.Controls.Add(Me.ButtonSaveAndClose)
        Me.PanelControls.Controls.Add(Me.ButtonClose)
        Me.PanelControls.Location = New System.Drawing.Point(0, 543)
        Me.PanelControls.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelControls.Name = "PanelControls"
        Me.PanelControls.Size = New System.Drawing.Size(457, 32)
        Me.PanelControls.TabIndex = 12
        '
        'GroupBoxXAMPP
        '
        Me.GroupBoxXAMPP.AutoSize = True
        Me.GroupBoxXAMPP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxXAMPP.Controls.Add(Me.LabelXAMPPDescription)
        Me.GroupBoxXAMPP.Controls.Add(Me.LabelProgressXAMPP)
        Me.GroupBoxXAMPP.Controls.Add(Me.PictureBoxProgressXAMPP)
        Me.GroupBoxXAMPP.Controls.Add(Me.TextBoxDirectoryXAMPP)
        Me.GroupBoxXAMPP.Location = New System.Drawing.Point(0, 157)
        Me.GroupBoxXAMPP.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.GroupBoxXAMPP.Name = "GroupBoxXAMPP"
        Me.GroupBoxXAMPP.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBoxXAMPP.Size = New System.Drawing.Size(475, 173)
        Me.GroupBoxXAMPP.TabIndex = 4
        Me.GroupBoxXAMPP.TabStop = False
        Me.GroupBoxXAMPP.Text = "XAMPP"
        '
        'LabelXAMPPDescription
        '
        Me.LabelXAMPPDescription.Location = New System.Drawing.Point(17, 63)
        Me.LabelXAMPPDescription.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelXAMPPDescription.Name = "LabelXAMPPDescription"
        Me.LabelXAMPPDescription.Size = New System.Drawing.Size(438, 36)
        Me.LabelXAMPPDescription.TabIndex = 3
        Me.LabelXAMPPDescription.Text = "Please specify the location of your XAMPP installation directory. This is optiona" &
    "l, you could also just wait until it is automatically found."
        '
        'LabelProgressXAMPP
        '
        Me.LabelProgressXAMPP.ForeColor = System.Drawing.Color.Gray
        Me.LabelProgressXAMPP.Location = New System.Drawing.Point(17, 117)
        Me.LabelProgressXAMPP.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelProgressXAMPP.Name = "LabelProgressXAMPP"
        Me.LabelProgressXAMPP.Size = New System.Drawing.Size(438, 18)
        Me.LabelProgressXAMPP.TabIndex = 2
        Me.LabelProgressXAMPP.Text = "Getting progress..."
        Me.LabelProgressXAMPP.Visible = False
        '
        'PictureBoxProgressXAMPP
        '
        Me.PictureBoxProgressXAMPP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxProgressXAMPP.Location = New System.Drawing.Point(20, 38)
        Me.PictureBoxProgressXAMPP.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.PictureBoxProgressXAMPP.Name = "PictureBoxProgressXAMPP"
        Me.PictureBoxProgressXAMPP.Size = New System.Drawing.Size(25, 25)
        Me.PictureBoxProgressXAMPP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxProgressXAMPP.TabIndex = 1
        Me.PictureBoxProgressXAMPP.TabStop = False
        '
        'TextBoxDirectoryXAMPP
        '
        Me.TextBoxDirectoryXAMPP.Location = New System.Drawing.Point(47, 38)
        Me.TextBoxDirectoryXAMPP.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxDirectoryXAMPP.Name = "TextBoxDirectoryXAMPP"
        Me.TextBoxDirectoryXAMPP.Size = New System.Drawing.Size(408, 25)
        Me.TextBoxDirectoryXAMPP.TabIndex = 0
        '
        'TimerDirectoryXAMPP
        '
        Me.TimerDirectoryXAMPP.Interval = 1000
        '
        'FormPathsSpecify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(962, 663)
        Me.Controls.Add(Me.FlowLayoutPanelMain)
        Me.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormPathsSpecify"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Specify Paths"
        Me.GroupBoxHosts.ResumeLayout(False)
        Me.GroupBoxHosts.PerformLayout()
        CType(Me.PictureBoxProgressHosts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxProgressHttpdVhostsConf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanelMain.ResumeLayout(False)
        Me.FlowLayoutPanelMain.PerformLayout()
        Me.PanelControls.ResumeLayout(False)
        Me.PanelControls.PerformLayout()
        Me.GroupBoxXAMPP.ResumeLayout(False)
        Me.GroupBoxXAMPP.PerformLayout()
        CType(Me.PictureBoxProgressXAMPP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxHosts As GroupBox
    Friend WithEvents TextBoxDirectoryHosts As TextBox
    Friend WithEvents PictureBoxProgressHosts As PictureBox
    Friend WithEvents TimerDirectoryHttpdVhostsConf As Timer
    Friend WithEvents LabelHostsDirectoryDescription As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelHttpdVhostsConfDirectoryDescription As Label
    Friend WithEvents LabelProgressHttpdVhostsConf As Label
    Friend WithEvents PictureBoxProgressHttpdVhostsConf As PictureBox
    Friend WithEvents TextBoxDirectoryHttpdVhostsConf As TextBox
    Friend WithEvents ButtonSaveAndClose As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents FlowLayoutPanelMain As FlowLayoutPanel
    Friend WithEvents PanelControls As Panel
    Friend WithEvents GroupBoxXAMPP As GroupBox
    Friend WithEvents LabelXAMPPDescription As Label
    Friend WithEvents LabelProgressXAMPP As Label
    Friend WithEvents PictureBoxProgressXAMPP As PictureBox
    Friend WithEvents TextBoxDirectoryXAMPP As TextBox
    Friend WithEvents TimerDirectoryXAMPP As Timer
End Class
