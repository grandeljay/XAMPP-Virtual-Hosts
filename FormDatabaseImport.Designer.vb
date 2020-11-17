<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDatabaseImport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDatabaseImport))
        Me.GroupBoxDatabaseSelect = New System.Windows.Forms.GroupBox()
        Me.LabelDatabaseSelectDescription = New System.Windows.Forms.Label()
        Me.ComboBoxDatabaseSelect = New System.Windows.Forms.ComboBox()
        Me.GroupBoxReplace = New System.Windows.Forms.GroupBox()
        Me.TextBoxReplaceDomain = New System.Windows.Forms.TextBox()
        Me.TextBoxSearchDomain = New System.Windows.Forms.TextBox()
        Me.TextBoxReplaceDirectoryAbsolute = New System.Windows.Forms.TextBox()
        Me.TextBoxSearchDirectoryAbsolute = New System.Windows.Forms.TextBox()
        Me.LabelReplace = New System.Windows.Forms.Label()
        Me.LabelSearch = New System.Windows.Forms.Label()
        Me.ButtonImport = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TextBoxSearchDomainEncoded = New System.Windows.Forms.TextBox()
        Me.TextBoxReplaceDomainEncoded = New System.Windows.Forms.TextBox()
        Me.TextBoxSearchDomainEscaped = New System.Windows.Forms.TextBox()
        Me.TextBoxReplaceDomainEscaped = New System.Windows.Forms.TextBox()
        Me.GroupBoxDatabaseSelect.SuspendLayout()
        Me.GroupBoxReplace.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxDatabaseSelect
        '
        Me.GroupBoxDatabaseSelect.AutoSize = True
        Me.GroupBoxDatabaseSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxDatabaseSelect.Controls.Add(Me.LabelDatabaseSelectDescription)
        Me.GroupBoxDatabaseSelect.Controls.Add(Me.ComboBoxDatabaseSelect)
        Me.GroupBoxDatabaseSelect.Location = New System.Drawing.Point(20, 20)
        Me.GroupBoxDatabaseSelect.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.GroupBoxDatabaseSelect.Name = "GroupBoxDatabaseSelect"
        Me.GroupBoxDatabaseSelect.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBoxDatabaseSelect.Size = New System.Drawing.Size(443, 120)
        Me.GroupBoxDatabaseSelect.TabIndex = 0
        Me.GroupBoxDatabaseSelect.TabStop = False
        Me.GroupBoxDatabaseSelect.Text = "Select Database"
        '
        'LabelDatabaseSelectDescription
        '
        Me.LabelDatabaseSelectDescription.AutoSize = True
        Me.LabelDatabaseSelectDescription.ForeColor = System.Drawing.Color.Gray
        Me.LabelDatabaseSelectDescription.Location = New System.Drawing.Point(17, 64)
        Me.LabelDatabaseSelectDescription.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDatabaseSelectDescription.Name = "LabelDatabaseSelectDescription"
        Me.LabelDatabaseSelectDescription.Size = New System.Drawing.Size(260, 18)
        Me.LabelDatabaseSelectDescription.TabIndex = 1
        Me.LabelDatabaseSelectDescription.Text = "Database must be in ""\XAMPP\mysql\bin""."
        '
        'ComboBoxDatabaseSelect
        '
        Me.ComboBoxDatabaseSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDatabaseSelect.FormattingEnabled = True
        Me.ComboBoxDatabaseSelect.Location = New System.Drawing.Point(20, 38)
        Me.ComboBoxDatabaseSelect.Margin = New System.Windows.Forms.Padding(0)
        Me.ComboBoxDatabaseSelect.Name = "ComboBoxDatabaseSelect"
        Me.ComboBoxDatabaseSelect.Size = New System.Drawing.Size(403, 26)
        Me.ComboBoxDatabaseSelect.TabIndex = 0
        '
        'GroupBoxReplace
        '
        Me.GroupBoxReplace.AutoSize = True
        Me.GroupBoxReplace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxReplaceDomainEscaped)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxSearchDomainEscaped)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxReplaceDomainEncoded)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxSearchDomainEncoded)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxReplaceDomain)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxSearchDomain)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxReplaceDirectoryAbsolute)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxSearchDirectoryAbsolute)
        Me.GroupBoxReplace.Controls.Add(Me.LabelReplace)
        Me.GroupBoxReplace.Controls.Add(Me.LabelSearch)
        Me.GroupBoxReplace.Location = New System.Drawing.Point(20, 160)
        Me.GroupBoxReplace.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.GroupBoxReplace.Name = "GroupBoxReplace"
        Me.GroupBoxReplace.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBoxReplace.Size = New System.Drawing.Size(883, 214)
        Me.GroupBoxReplace.TabIndex = 1
        Me.GroupBoxReplace.TabStop = False
        Me.GroupBoxReplace.Text = "Search && Replace"
        '
        'TextBoxReplaceDomain
        '
        Me.TextBoxReplaceDomain.Location = New System.Drawing.Point(440, 56)
        Me.TextBoxReplaceDomain.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.TextBoxReplaceDomain.Name = "TextBoxReplaceDomain"
        Me.TextBoxReplaceDomain.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxReplaceDomain.TabIndex = 10
        Me.TextBoxReplaceDomain.Text = "https://hybridsupply.localhost"
        '
        'TextBoxSearchDomain
        '
        Me.TextBoxSearchDomain.Location = New System.Drawing.Point(17, 56)
        Me.TextBoxSearchDomain.Margin = New System.Windows.Forms.Padding(0, 0, 20, 5)
        Me.TextBoxSearchDomain.Name = "TextBoxSearchDomain"
        Me.TextBoxSearchDomain.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxSearchDomain.TabIndex = 9
        Me.TextBoxSearchDomain.Text = "https://hybridsupply.uk"
        '
        'TextBoxReplaceDirectoryAbsolute
        '
        Me.TextBoxReplaceDirectoryAbsolute.Location = New System.Drawing.Point(440, 146)
        Me.TextBoxReplaceDirectoryAbsolute.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.TextBoxReplaceDirectoryAbsolute.Name = "TextBoxReplaceDirectoryAbsolute"
        Me.TextBoxReplaceDirectoryAbsolute.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxReplaceDirectoryAbsolute.TabIndex = 8
        Me.TextBoxReplaceDirectoryAbsolute.Text = "D:/XAMPP/htdocs/hybridsupply.de-2019"
        '
        'TextBoxSearchDirectoryAbsolute
        '
        Me.TextBoxSearchDirectoryAbsolute.Location = New System.Drawing.Point(17, 146)
        Me.TextBoxSearchDirectoryAbsolute.Margin = New System.Windows.Forms.Padding(0, 0, 20, 5)
        Me.TextBoxSearchDirectoryAbsolute.Name = "TextBoxSearchDirectoryAbsolute"
        Me.TextBoxSearchDirectoryAbsolute.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxSearchDirectoryAbsolute.TabIndex = 7
        Me.TextBoxSearchDirectoryAbsolute.Text = "/var/www/customers/hybridwebsite/hybridsupply.de-2019"
        '
        'LabelReplace
        '
        Me.LabelReplace.AutoSize = True
        Me.LabelReplace.Location = New System.Drawing.Point(440, 38)
        Me.LabelReplace.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelReplace.Name = "LabelReplace"
        Me.LabelReplace.Size = New System.Drawing.Size(83, 18)
        Me.LabelReplace.TabIndex = 6
        Me.LabelReplace.Text = "Replace with"
        '
        'LabelSearch
        '
        Me.LabelSearch.AutoSize = True
        Me.LabelSearch.Location = New System.Drawing.Point(17, 38)
        Me.LabelSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelSearch.Name = "LabelSearch"
        Me.LabelSearch.Size = New System.Drawing.Size(68, 18)
        Me.LabelSearch.TabIndex = 1
        Me.LabelSearch.Text = "Search for"
        '
        'ButtonImport
        '
        Me.ButtonImport.AutoSize = True
        Me.ButtonImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonImport.Location = New System.Drawing.Point(37, 394)
        Me.ButtonImport.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ButtonImport.Name = "ButtonImport"
        Me.ButtonImport.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonImport.Size = New System.Drawing.Size(64, 32)
        Me.ButtonImport.TabIndex = 9
        Me.ButtonImport.Text = "Import"
        Me.ButtonImport.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(460, 394)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(403, 32)
        Me.ProgressBar1.TabIndex = 10
        '
        'TextBoxSearchDomainEncoded
        '
        Me.TextBoxSearchDomainEncoded.Location = New System.Drawing.Point(17, 116)
        Me.TextBoxSearchDomainEncoded.Margin = New System.Windows.Forms.Padding(0, 0, 20, 5)
        Me.TextBoxSearchDomainEncoded.Name = "TextBoxSearchDomainEncoded"
        Me.TextBoxSearchDomainEncoded.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxSearchDomainEncoded.TabIndex = 11
        Me.TextBoxSearchDomainEncoded.Text = "https%3A%2F%2Fhybridsupply.uk"
        '
        'TextBoxReplaceDomainEncoded
        '
        Me.TextBoxReplaceDomainEncoded.Location = New System.Drawing.Point(440, 116)
        Me.TextBoxReplaceDomainEncoded.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.TextBoxReplaceDomainEncoded.Name = "TextBoxReplaceDomainEncoded"
        Me.TextBoxReplaceDomainEncoded.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxReplaceDomainEncoded.TabIndex = 12
        Me.TextBoxReplaceDomainEncoded.Text = "https%3A%2F%2Fhybridsupply.localhost"
        '
        'TextBoxSearchDomainEscaped
        '
        Me.TextBoxSearchDomainEscaped.Location = New System.Drawing.Point(17, 86)
        Me.TextBoxSearchDomainEscaped.Margin = New System.Windows.Forms.Padding(0, 0, 20, 5)
        Me.TextBoxSearchDomainEscaped.Name = "TextBoxSearchDomainEscaped"
        Me.TextBoxSearchDomainEscaped.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxSearchDomainEscaped.TabIndex = 13
        Me.TextBoxSearchDomainEscaped.Text = "https:\/\/hybridsupply.uk"
        '
        'TextBoxReplaceDomainEscaped
        '
        Me.TextBoxReplaceDomainEscaped.Location = New System.Drawing.Point(440, 86)
        Me.TextBoxReplaceDomainEscaped.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.TextBoxReplaceDomainEscaped.Name = "TextBoxReplaceDomainEscaped"
        Me.TextBoxReplaceDomainEscaped.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxReplaceDomainEscaped.TabIndex = 14
        Me.TextBoxReplaceDomainEscaped.Text = "https:\/\/hybridsupply.localhost"
        '
        'FormDatabaseImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(933, 493)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ButtonImport)
        Me.Controls.Add(Me.GroupBoxReplace)
        Me.Controls.Add(Me.GroupBoxDatabaseSelect)
        Me.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormDatabaseImport"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Database"
        Me.GroupBoxDatabaseSelect.ResumeLayout(False)
        Me.GroupBoxDatabaseSelect.PerformLayout()
        Me.GroupBoxReplace.ResumeLayout(False)
        Me.GroupBoxReplace.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxDatabaseSelect As GroupBox
    Friend WithEvents LabelDatabaseSelectDescription As Label
    Friend WithEvents ComboBoxDatabaseSelect As ComboBox
    Friend WithEvents GroupBoxReplace As GroupBox
    Friend WithEvents LabelSearch As Label
    Friend WithEvents LabelReplace As Label
    Friend WithEvents TextBoxReplaceDirectoryAbsolute As TextBox
    Friend WithEvents TextBoxSearchDirectoryAbsolute As TextBox
    Friend WithEvents TextBoxSearchDomain As TextBox
    Friend WithEvents TextBoxReplaceDomain As TextBox
    Friend WithEvents ButtonImport As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TextBoxReplaceDomainEscaped As TextBox
    Friend WithEvents TextBoxSearchDomainEscaped As TextBox
    Friend WithEvents TextBoxReplaceDomainEncoded As TextBox
    Friend WithEvents TextBoxSearchDomainEncoded As TextBox
End Class
