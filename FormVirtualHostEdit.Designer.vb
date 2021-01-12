<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVirtualHostEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVirtualHostEdit))
        Me.GroupBox_hosts = New System.Windows.Forms.GroupBox()
        Me.LabelIPv6Host = New System.Windows.Forms.Label()
        Me.TextBoxIPv6Host = New System.Windows.Forms.TextBox()
        Me.TextBoxIPv6Address = New System.Windows.Forms.TextBox()
        Me.LabelIPv6Address = New System.Windows.Forms.Label()
        Me.LabelIPv4Host = New System.Windows.Forms.Label()
        Me.TextBoxIPv4Host = New System.Windows.Forms.TextBox()
        Me.TextBoxIPv4Address = New System.Windows.Forms.TextBox()
        Me.LabelIPv4Address = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox_httpd_vhosts_conf = New System.Windows.Forms.GroupBox()
        Me.LabelDocumentRoot = New System.Windows.Forms.Label()
        Me.TextBoxDocumentRoot = New System.Windows.Forms.TextBox()
        Me.TextBoxPort = New System.Windows.Forms.TextBox()
        Me.LabelPort = New System.Windows.Forms.Label()
        Me.GroupBoxGeneral = New System.Windows.Forms.GroupBox()
        Me.LabelPHPVersion = New System.Windows.Forms.Label()
        Me.ComboBoxPHPVersion = New System.Windows.Forms.ComboBox()
        Me.LabelGeneralDocumentRoot = New System.Windows.Forms.Label()
        Me.TextBoxGeneralDocumentRoot = New System.Windows.Forms.TextBox()
        Me.CheckBoxSSL = New System.Windows.Forms.CheckBox()
        Me.TextBoxGeneralDomain = New System.Windows.Forms.TextBox()
        Me.LabelGeneralHost = New System.Windows.Forms.Label()
        Me.GroupBoxSSL_httpd_vhosts_conf = New System.Windows.Forms.GroupBox()
        Me.LabelSSLCertificateKey = New System.Windows.Forms.Label()
        Me.TextBoxCertificateKey = New System.Windows.Forms.TextBox()
        Me.LabelSSLCertificate = New System.Windows.Forms.Label()
        Me.TextBoxCertificate = New System.Windows.Forms.TextBox()
        Me.TextBoxPortSSL = New System.Windows.Forms.TextBox()
        Me.LabelSSLPort = New System.Windows.Forms.Label()
        Me.GroupBoxPreview = New System.Windows.Forms.GroupBox()
        Me.TextBoxPreview = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.GroupBox_hosts.SuspendLayout()
        Me.GroupBox_httpd_vhosts_conf.SuspendLayout()
        Me.GroupBoxGeneral.SuspendLayout()
        Me.GroupBoxSSL_httpd_vhosts_conf.SuspendLayout()
        Me.GroupBoxPreview.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_hosts
        '
        Me.GroupBox_hosts.AutoSize = True
        Me.GroupBox_hosts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox_hosts.Controls.Add(Me.LabelIPv6Host)
        Me.GroupBox_hosts.Controls.Add(Me.TextBoxIPv6Host)
        Me.GroupBox_hosts.Controls.Add(Me.TextBoxIPv6Address)
        Me.GroupBox_hosts.Controls.Add(Me.LabelIPv6Address)
        Me.GroupBox_hosts.Controls.Add(Me.LabelIPv4Host)
        Me.GroupBox_hosts.Controls.Add(Me.TextBoxIPv4Host)
        Me.GroupBox_hosts.Controls.Add(Me.TextBoxIPv4Address)
        Me.GroupBox_hosts.Controls.Add(Me.LabelIPv4Address)
        Me.GroupBox_hosts.Location = New System.Drawing.Point(20, 234)
        Me.GroupBox_hosts.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.GroupBox_hosts.Name = "GroupBox_hosts"
        Me.GroupBox_hosts.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBox_hosts.Size = New System.Drawing.Size(349, 196)
        Me.GroupBox_hosts.TabIndex = 0
        Me.GroupBox_hosts.TabStop = False
        Me.GroupBox_hosts.Text = "hosts"
        '
        'LabelIPv6Host
        '
        Me.LabelIPv6Host.AutoSize = True
        Me.LabelIPv6Host.Location = New System.Drawing.Point(20, 131)
        Me.LabelIPv6Host.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelIPv6Host.Name = "LabelIPv6Host"
        Me.LabelIPv6Host.Size = New System.Drawing.Size(66, 18)
        Me.LabelIPv6Host.TabIndex = 7
        Me.LabelIPv6Host.Text = "IPv6 Host"
        '
        'TextBoxIPv6Host
        '
        Me.TextBoxIPv6Host.Location = New System.Drawing.Point(129, 128)
        Me.TextBoxIPv6Host.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.TextBoxIPv6Host.Name = "TextBoxIPv6Host"
        Me.TextBoxIPv6Host.Size = New System.Drawing.Size(200, 25)
        Me.TextBoxIPv6Host.TabIndex = 6
        '
        'TextBoxIPv6Address
        '
        Me.TextBoxIPv6Address.Location = New System.Drawing.Point(129, 98)
        Me.TextBoxIPv6Address.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.TextBoxIPv6Address.Name = "TextBoxIPv6Address"
        Me.TextBoxIPv6Address.Size = New System.Drawing.Size(200, 25)
        Me.TextBoxIPv6Address.TabIndex = 5
        Me.TextBoxIPv6Address.Text = "::1"
        '
        'LabelIPv6Address
        '
        Me.LabelIPv6Address.AutoSize = True
        Me.LabelIPv6Address.Location = New System.Drawing.Point(20, 101)
        Me.LabelIPv6Address.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelIPv6Address.Name = "LabelIPv6Address"
        Me.LabelIPv6Address.Size = New System.Drawing.Size(85, 18)
        Me.LabelIPv6Address.TabIndex = 4
        Me.LabelIPv6Address.Text = "IPv6 Address"
        '
        'LabelIPv4Host
        '
        Me.LabelIPv4Host.AutoSize = True
        Me.LabelIPv4Host.Location = New System.Drawing.Point(20, 71)
        Me.LabelIPv4Host.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelIPv4Host.Name = "LabelIPv4Host"
        Me.LabelIPv4Host.Size = New System.Drawing.Size(66, 18)
        Me.LabelIPv4Host.TabIndex = 3
        Me.LabelIPv4Host.Text = "IPv4 Host"
        '
        'TextBoxIPv4Host
        '
        Me.TextBoxIPv4Host.Location = New System.Drawing.Point(129, 68)
        Me.TextBoxIPv4Host.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.TextBoxIPv4Host.Name = "TextBoxIPv4Host"
        Me.TextBoxIPv4Host.Size = New System.Drawing.Size(200, 25)
        Me.TextBoxIPv4Host.TabIndex = 2
        '
        'TextBoxIPv4Address
        '
        Me.TextBoxIPv4Address.Location = New System.Drawing.Point(129, 38)
        Me.TextBoxIPv4Address.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.TextBoxIPv4Address.Name = "TextBoxIPv4Address"
        Me.TextBoxIPv4Address.Size = New System.Drawing.Size(200, 25)
        Me.TextBoxIPv4Address.TabIndex = 1
        Me.TextBoxIPv4Address.Text = "127.0.0.1"
        '
        'LabelIPv4Address
        '
        Me.LabelIPv4Address.AutoSize = True
        Me.LabelIPv4Address.Location = New System.Drawing.Point(20, 41)
        Me.LabelIPv4Address.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelIPv4Address.Name = "LabelIPv4Address"
        Me.LabelIPv4Address.Size = New System.Drawing.Size(85, 18)
        Me.LabelIPv4Address.TabIndex = 0
        Me.LabelIPv4Address.Text = "IPv4 Address"
        '
        'GroupBox_httpd_vhosts_conf
        '
        Me.GroupBox_httpd_vhosts_conf.AutoSize = True
        Me.GroupBox_httpd_vhosts_conf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox_httpd_vhosts_conf.Controls.Add(Me.LabelDocumentRoot)
        Me.GroupBox_httpd_vhosts_conf.Controls.Add(Me.TextBoxDocumentRoot)
        Me.GroupBox_httpd_vhosts_conf.Controls.Add(Me.TextBoxPort)
        Me.GroupBox_httpd_vhosts_conf.Controls.Add(Me.LabelPort)
        Me.GroupBox_httpd_vhosts_conf.Location = New System.Drawing.Point(389, 234)
        Me.GroupBox_httpd_vhosts_conf.Margin = New System.Windows.Forms.Padding(0, 0, 20, 20)
        Me.GroupBox_httpd_vhosts_conf.Name = "GroupBox_httpd_vhosts_conf"
        Me.GroupBox_httpd_vhosts_conf.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBox_httpd_vhosts_conf.Size = New System.Drawing.Size(349, 136)
        Me.GroupBox_httpd_vhosts_conf.TabIndex = 1
        Me.GroupBox_httpd_vhosts_conf.TabStop = False
        Me.GroupBox_httpd_vhosts_conf.Text = "httpd-vhosts.conf"
        '
        'LabelDocumentRoot
        '
        Me.LabelDocumentRoot.AutoSize = True
        Me.LabelDocumentRoot.Location = New System.Drawing.Point(23, 71)
        Me.LabelDocumentRoot.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDocumentRoot.Name = "LabelDocumentRoot"
        Me.LabelDocumentRoot.Size = New System.Drawing.Size(103, 18)
        Me.LabelDocumentRoot.TabIndex = 3
        Me.LabelDocumentRoot.Text = "Document Root"
        '
        'TextBoxDocumentRoot
        '
        Me.TextBoxDocumentRoot.Location = New System.Drawing.Point(129, 68)
        Me.TextBoxDocumentRoot.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.TextBoxDocumentRoot.Name = "TextBoxDocumentRoot"
        Me.TextBoxDocumentRoot.Size = New System.Drawing.Size(200, 25)
        Me.TextBoxDocumentRoot.TabIndex = 2
        Me.TextBoxDocumentRoot.Text = "\XAMPP\htdocs\test"
        '
        'TextBoxPort
        '
        Me.TextBoxPort.Location = New System.Drawing.Point(129, 38)
        Me.TextBoxPort.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.TextBoxPort.Name = "TextBoxPort"
        Me.TextBoxPort.Size = New System.Drawing.Size(200, 25)
        Me.TextBoxPort.TabIndex = 1
        Me.TextBoxPort.Text = "80"
        '
        'LabelPort
        '
        Me.LabelPort.AutoSize = True
        Me.LabelPort.Location = New System.Drawing.Point(23, 41)
        Me.LabelPort.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPort.Name = "LabelPort"
        Me.LabelPort.Size = New System.Drawing.Size(34, 18)
        Me.LabelPort.TabIndex = 0
        Me.LabelPort.Text = "Port"
        '
        'GroupBoxGeneral
        '
        Me.GroupBoxGeneral.AutoSize = True
        Me.GroupBoxGeneral.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxGeneral.Controls.Add(Me.LabelPHPVersion)
        Me.GroupBoxGeneral.Controls.Add(Me.ComboBoxPHPVersion)
        Me.GroupBoxGeneral.Controls.Add(Me.LabelGeneralDocumentRoot)
        Me.GroupBoxGeneral.Controls.Add(Me.TextBoxGeneralDocumentRoot)
        Me.GroupBoxGeneral.Controls.Add(Me.CheckBoxSSL)
        Me.GroupBoxGeneral.Controls.Add(Me.TextBoxGeneralDomain)
        Me.GroupBoxGeneral.Controls.Add(Me.LabelGeneralHost)
        Me.GroupBoxGeneral.Location = New System.Drawing.Point(20, 20)
        Me.GroupBoxGeneral.Margin = New System.Windows.Forms.Padding(0, 0, 20, 20)
        Me.GroupBoxGeneral.Name = "GroupBoxGeneral"
        Me.GroupBoxGeneral.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBoxGeneral.Size = New System.Drawing.Size(349, 194)
        Me.GroupBoxGeneral.TabIndex = 2
        Me.GroupBoxGeneral.TabStop = False
        Me.GroupBoxGeneral.Text = "General"
        '
        'LabelPHPVersion
        '
        Me.LabelPHPVersion.AutoSize = True
        Me.LabelPHPVersion.Location = New System.Drawing.Point(20, 101)
        Me.LabelPHPVersion.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPHPVersion.Name = "LabelPHPVersion"
        Me.LabelPHPVersion.Size = New System.Drawing.Size(82, 18)
        Me.LabelPHPVersion.TabIndex = 8
        Me.LabelPHPVersion.Text = "PHP Version"
        '
        'ComboBoxPHPVersion
        '
        Me.ComboBoxPHPVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPHPVersion.FormattingEnabled = True
        Me.ComboBoxPHPVersion.Location = New System.Drawing.Point(129, 98)
        Me.ComboBoxPHPVersion.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.ComboBoxPHPVersion.Name = "ComboBoxPHPVersion"
        Me.ComboBoxPHPVersion.Size = New System.Drawing.Size(200, 26)
        Me.ComboBoxPHPVersion.TabIndex = 7
        '
        'LabelGeneralDocumentRoot
        '
        Me.LabelGeneralDocumentRoot.AutoSize = True
        Me.LabelGeneralDocumentRoot.Location = New System.Drawing.Point(20, 71)
        Me.LabelGeneralDocumentRoot.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelGeneralDocumentRoot.Name = "LabelGeneralDocumentRoot"
        Me.LabelGeneralDocumentRoot.Size = New System.Drawing.Size(103, 18)
        Me.LabelGeneralDocumentRoot.TabIndex = 6
        Me.LabelGeneralDocumentRoot.Text = "Document Root"
        '
        'TextBoxGeneralDocumentRoot
        '
        Me.TextBoxGeneralDocumentRoot.Location = New System.Drawing.Point(129, 68)
        Me.TextBoxGeneralDocumentRoot.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.TextBoxGeneralDocumentRoot.Name = "TextBoxGeneralDocumentRoot"
        Me.TextBoxGeneralDocumentRoot.Size = New System.Drawing.Size(200, 25)
        Me.TextBoxGeneralDocumentRoot.TabIndex = 5
        Me.TextBoxGeneralDocumentRoot.Text = "\XAMPP\htdocs\test"
        '
        'CheckBoxSSL
        '
        Me.CheckBoxSSL.AutoSize = True
        Me.CheckBoxSSL.Location = New System.Drawing.Point(129, 129)
        Me.CheckBoxSSL.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.CheckBoxSSL.Name = "CheckBoxSSL"
        Me.CheckBoxSSL.Size = New System.Drawing.Size(48, 22)
        Me.CheckBoxSSL.TabIndex = 4
        Me.CheckBoxSSL.Text = "SSL"
        Me.CheckBoxSSL.UseVisualStyleBackColor = True
        '
        'TextBoxGeneralDomain
        '
        Me.TextBoxGeneralDomain.Location = New System.Drawing.Point(129, 38)
        Me.TextBoxGeneralDomain.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.TextBoxGeneralDomain.Name = "TextBoxGeneralDomain"
        Me.TextBoxGeneralDomain.Size = New System.Drawing.Size(200, 25)
        Me.TextBoxGeneralDomain.TabIndex = 1
        Me.TextBoxGeneralDomain.Text = "test.localhost"
        '
        'LabelGeneralHost
        '
        Me.LabelGeneralHost.AutoSize = True
        Me.LabelGeneralHost.Location = New System.Drawing.Point(20, 41)
        Me.LabelGeneralHost.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelGeneralHost.Name = "LabelGeneralHost"
        Me.LabelGeneralHost.Size = New System.Drawing.Size(55, 18)
        Me.LabelGeneralHost.TabIndex = 0
        Me.LabelGeneralHost.Text = "Domain"
        '
        'GroupBoxSSL_httpd_vhosts_conf
        '
        Me.GroupBoxSSL_httpd_vhosts_conf.AutoSize = True
        Me.GroupBoxSSL_httpd_vhosts_conf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxSSL_httpd_vhosts_conf.Controls.Add(Me.LabelSSLCertificateKey)
        Me.GroupBoxSSL_httpd_vhosts_conf.Controls.Add(Me.TextBoxCertificateKey)
        Me.GroupBoxSSL_httpd_vhosts_conf.Controls.Add(Me.LabelSSLCertificate)
        Me.GroupBoxSSL_httpd_vhosts_conf.Controls.Add(Me.TextBoxCertificate)
        Me.GroupBoxSSL_httpd_vhosts_conf.Controls.Add(Me.TextBoxPortSSL)
        Me.GroupBoxSSL_httpd_vhosts_conf.Controls.Add(Me.LabelSSLPort)
        Me.GroupBoxSSL_httpd_vhosts_conf.Location = New System.Drawing.Point(389, 387)
        Me.GroupBoxSSL_httpd_vhosts_conf.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.GroupBoxSSL_httpd_vhosts_conf.Name = "GroupBoxSSL_httpd_vhosts_conf"
        Me.GroupBoxSSL_httpd_vhosts_conf.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBoxSSL_httpd_vhosts_conf.Size = New System.Drawing.Size(349, 166)
        Me.GroupBoxSSL_httpd_vhosts_conf.TabIndex = 3
        Me.GroupBoxSSL_httpd_vhosts_conf.TabStop = False
        Me.GroupBoxSSL_httpd_vhosts_conf.Text = "httpd-vhosts.conf (SSL)"
        Me.GroupBoxSSL_httpd_vhosts_conf.Visible = False
        '
        'LabelSSLCertificateKey
        '
        Me.LabelSSLCertificateKey.AutoSize = True
        Me.LabelSSLCertificateKey.Location = New System.Drawing.Point(23, 101)
        Me.LabelSSLCertificateKey.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelSSLCertificateKey.Name = "LabelSSLCertificateKey"
        Me.LabelSSLCertificateKey.Size = New System.Drawing.Size(94, 18)
        Me.LabelSSLCertificateKey.TabIndex = 5
        Me.LabelSSLCertificateKey.Text = "Certificate Key"
        '
        'TextBoxCertificateKey
        '
        Me.TextBoxCertificateKey.Location = New System.Drawing.Point(129, 98)
        Me.TextBoxCertificateKey.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.TextBoxCertificateKey.Name = "TextBoxCertificateKey"
        Me.TextBoxCertificateKey.Size = New System.Drawing.Size(200, 25)
        Me.TextBoxCertificateKey.TabIndex = 4
        Me.TextBoxCertificateKey.Text = "\XAMPP\apache\conf\ssl.key\server.key"
        '
        'LabelSSLCertificate
        '
        Me.LabelSSLCertificate.AutoSize = True
        Me.LabelSSLCertificate.Location = New System.Drawing.Point(23, 71)
        Me.LabelSSLCertificate.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelSSLCertificate.Name = "LabelSSLCertificate"
        Me.LabelSSLCertificate.Size = New System.Drawing.Size(69, 18)
        Me.LabelSSLCertificate.TabIndex = 3
        Me.LabelSSLCertificate.Text = "Certificate"
        '
        'TextBoxCertificate
        '
        Me.TextBoxCertificate.Location = New System.Drawing.Point(129, 68)
        Me.TextBoxCertificate.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.TextBoxCertificate.Name = "TextBoxCertificate"
        Me.TextBoxCertificate.Size = New System.Drawing.Size(200, 25)
        Me.TextBoxCertificate.TabIndex = 2
        Me.TextBoxCertificate.Text = "\XAMPP\apache\conf\ssl.crt\server.crt"
        '
        'TextBoxPortSSL
        '
        Me.TextBoxPortSSL.Location = New System.Drawing.Point(129, 38)
        Me.TextBoxPortSSL.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.TextBoxPortSSL.Name = "TextBoxPortSSL"
        Me.TextBoxPortSSL.Size = New System.Drawing.Size(200, 25)
        Me.TextBoxPortSSL.TabIndex = 1
        Me.TextBoxPortSSL.Text = "443"
        '
        'LabelSSLPort
        '
        Me.LabelSSLPort.AutoSize = True
        Me.LabelSSLPort.Location = New System.Drawing.Point(23, 41)
        Me.LabelSSLPort.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelSSLPort.Name = "LabelSSLPort"
        Me.LabelSSLPort.Size = New System.Drawing.Size(34, 18)
        Me.LabelSSLPort.TabIndex = 0
        Me.LabelSSLPort.Text = "Port"
        '
        'GroupBoxPreview
        '
        Me.GroupBoxPreview.AutoSize = True
        Me.GroupBoxPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxPreview.Controls.Add(Me.TextBoxPreview)
        Me.GroupBoxPreview.Location = New System.Drawing.Point(758, 20)
        Me.GroupBoxPreview.Margin = New System.Windows.Forms.Padding(0, 0, 20, 20)
        Me.GroupBoxPreview.Name = "GroupBoxPreview"
        Me.GroupBoxPreview.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBoxPreview.Size = New System.Drawing.Size(440, 499)
        Me.GroupBoxPreview.TabIndex = 4
        Me.GroupBoxPreview.TabStop = False
        Me.GroupBoxPreview.Text = "Preview"
        '
        'TextBoxPreview
        '
        Me.TextBoxPreview.Location = New System.Drawing.Point(20, 38)
        Me.TextBoxPreview.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.TextBoxPreview.Multiline = True
        Me.TextBoxPreview.Name = "TextBoxPreview"
        Me.TextBoxPreview.ReadOnly = True
        Me.TextBoxPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxPreview.Size = New System.Drawing.Size(400, 418)
        Me.TextBoxPreview.TabIndex = 1
        Me.TextBoxPreview.WordWrap = False
        '
        'ButtonSave
        '
        Me.ButtonSave.AutoSize = True
        Me.ButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonSave.Location = New System.Drawing.Point(43, 539)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonSave.Size = New System.Drawing.Size(97, 32)
        Me.ButtonSave.TabIndex = 6
        Me.ButtonSave.Text = "Save && Close"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'FormVirtualHostEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1218, 593)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.GroupBoxPreview)
        Me.Controls.Add(Me.GroupBoxSSL_httpd_vhosts_conf)
        Me.Controls.Add(Me.GroupBoxGeneral)
        Me.Controls.Add(Me.GroupBox_httpd_vhosts_conf)
        Me.Controls.Add(Me.GroupBox_hosts)
        Me.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormVirtualHostEdit"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Virtual Host"
        Me.GroupBox_hosts.ResumeLayout(False)
        Me.GroupBox_hosts.PerformLayout()
        Me.GroupBox_httpd_vhosts_conf.ResumeLayout(False)
        Me.GroupBox_httpd_vhosts_conf.PerformLayout()
        Me.GroupBoxGeneral.ResumeLayout(False)
        Me.GroupBoxGeneral.PerformLayout()
        Me.GroupBoxSSL_httpd_vhosts_conf.ResumeLayout(False)
        Me.GroupBoxSSL_httpd_vhosts_conf.PerformLayout()
        Me.GroupBoxPreview.ResumeLayout(False)
        Me.GroupBoxPreview.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox_hosts As GroupBox
    Friend WithEvents TextBoxIPv4Address As TextBox
    Friend WithEvents LabelIPv4Address As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelIPv4Host As Label
    Friend WithEvents TextBoxIPv4Host As TextBox
    Friend WithEvents LabelIPv6Host As Label
    Friend WithEvents TextBoxIPv6Host As TextBox
    Friend WithEvents TextBoxIPv6Address As TextBox
    Friend WithEvents LabelIPv6Address As Label
    Friend WithEvents GroupBox_httpd_vhosts_conf As GroupBox
    Friend WithEvents LabelDocumentRoot As Label
    Friend WithEvents TextBoxDocumentRoot As TextBox
    Friend WithEvents TextBoxPort As TextBox
    Friend WithEvents LabelPort As Label
    Friend WithEvents GroupBoxGeneral As GroupBox
    Friend WithEvents TextBoxGeneralDomain As TextBox
    Friend WithEvents LabelGeneralHost As Label
    Friend WithEvents LabelGeneralDocumentRoot As Label
    Friend WithEvents TextBoxGeneralDocumentRoot As TextBox
    Friend WithEvents CheckBoxSSL As CheckBox
    Friend WithEvents GroupBoxSSL_httpd_vhosts_conf As GroupBox
    Friend WithEvents LabelSSLCertificateKey As Label
    Friend WithEvents TextBoxCertificateKey As TextBox
    Friend WithEvents LabelSSLCertificate As Label
    Friend WithEvents TextBoxCertificate As TextBox
    Friend WithEvents TextBoxPortSSL As TextBox
    Friend WithEvents LabelSSLPort As Label
    Friend WithEvents GroupBoxPreview As GroupBox
    Friend WithEvents TextBoxPreview As TextBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents LabelPHPVersion As Label
    Friend WithEvents ComboBoxPHPVersion As ComboBox
End Class
