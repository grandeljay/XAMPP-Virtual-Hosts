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
        Me.TextBoxReplaceDomainEscapedUK = New System.Windows.Forms.TextBox()
        Me.TextBoxSearchDomainEscapedUK = New System.Windows.Forms.TextBox()
        Me.TextBoxReplaceDomainEncodedUK = New System.Windows.Forms.TextBox()
        Me.TextBoxSearchDomainEncodedUK = New System.Windows.Forms.TextBox()
        Me.TextBoxReplaceDomainUK = New System.Windows.Forms.TextBox()
        Me.TextBoxSearchDomainUK = New System.Windows.Forms.TextBox()
        Me.TextBoxReplaceDirectoryAbsolute = New System.Windows.Forms.TextBox()
        Me.TextBoxSearchDirectoryAbsolute = New System.Windows.Forms.TextBox()
        Me.LabelReplace = New System.Windows.Forms.Label()
        Me.LabelSearch = New System.Windows.Forms.Label()
        Me.ButtonImport = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TextBoxReplaceDomainEscapedDE = New System.Windows.Forms.TextBox()
        Me.TextBoxSearchDomainEscapedDE = New System.Windows.Forms.TextBox()
        Me.TextBoxReplaceDomainEncodedDE = New System.Windows.Forms.TextBox()
        Me.TextBoxSearchDomainEncodedDE = New System.Windows.Forms.TextBox()
        Me.TextBoxReplaceDomainDE = New System.Windows.Forms.TextBox()
        Me.TextBoxSearchDomainDE = New System.Windows.Forms.TextBox()
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
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxReplaceDomainEscapedDE)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxReplaceDomainEscapedUK)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxSearchDomainEscapedUK)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxSearchDomainEscapedDE)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxReplaceDomainEncodedUK)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxSearchDomainEncodedUK)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxReplaceDomainEncodedDE)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxReplaceDomainUK)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxSearchDomainUK)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxSearchDomainEncodedDE)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxReplaceDirectoryAbsolute)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxSearchDirectoryAbsolute)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxReplaceDomainDE)
        Me.GroupBoxReplace.Controls.Add(Me.LabelReplace)
        Me.GroupBoxReplace.Controls.Add(Me.TextBoxSearchDomainDE)
        Me.GroupBoxReplace.Controls.Add(Me.LabelSearch)
        Me.GroupBoxReplace.Location = New System.Drawing.Point(20, 160)
        Me.GroupBoxReplace.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.GroupBoxReplace.Name = "GroupBoxReplace"
        Me.GroupBoxReplace.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBoxReplace.Size = New System.Drawing.Size(883, 304)
        Me.GroupBoxReplace.TabIndex = 1
        Me.GroupBoxReplace.TabStop = False
        Me.GroupBoxReplace.Text = "Search && Replace"
        '
        'TextBoxReplaceDomainEscapedUK
        '
        Me.TextBoxReplaceDomainEscapedUK.Location = New System.Drawing.Point(440, 86)
        Me.TextBoxReplaceDomainEscapedUK.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.TextBoxReplaceDomainEscapedUK.Name = "TextBoxReplaceDomainEscapedUK"
        Me.TextBoxReplaceDomainEscapedUK.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxReplaceDomainEscapedUK.TabIndex = 14
        Me.TextBoxReplaceDomainEscapedUK.Text = "http:\/\/hybridsupply-uk.localhost"
        '
        'TextBoxSearchDomainEscapedUK
        '
        Me.TextBoxSearchDomainEscapedUK.Location = New System.Drawing.Point(17, 86)
        Me.TextBoxSearchDomainEscapedUK.Margin = New System.Windows.Forms.Padding(0, 0, 20, 5)
        Me.TextBoxSearchDomainEscapedUK.Name = "TextBoxSearchDomainEscapedUK"
        Me.TextBoxSearchDomainEscapedUK.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxSearchDomainEscapedUK.TabIndex = 13
        Me.TextBoxSearchDomainEscapedUK.Text = "https:\/\/hybridsupply.uk"
        '
        'TextBoxReplaceDomainEncodedUK
        '
        Me.TextBoxReplaceDomainEncodedUK.Location = New System.Drawing.Point(440, 116)
        Me.TextBoxReplaceDomainEncodedUK.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.TextBoxReplaceDomainEncodedUK.Name = "TextBoxReplaceDomainEncodedUK"
        Me.TextBoxReplaceDomainEncodedUK.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxReplaceDomainEncodedUK.TabIndex = 12
        Me.TextBoxReplaceDomainEncodedUK.Text = "http%3A%2F%2Fhybridsupply-uk.localhost"
        '
        'TextBoxSearchDomainEncodedUK
        '
        Me.TextBoxSearchDomainEncodedUK.Location = New System.Drawing.Point(17, 116)
        Me.TextBoxSearchDomainEncodedUK.Margin = New System.Windows.Forms.Padding(0, 0, 20, 5)
        Me.TextBoxSearchDomainEncodedUK.Name = "TextBoxSearchDomainEncodedUK"
        Me.TextBoxSearchDomainEncodedUK.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxSearchDomainEncodedUK.TabIndex = 11
        Me.TextBoxSearchDomainEncodedUK.Text = "https%3A%2F%2Fhybridsupply.uk"
        '
        'TextBoxReplaceDomainUK
        '
        Me.TextBoxReplaceDomainUK.Location = New System.Drawing.Point(440, 56)
        Me.TextBoxReplaceDomainUK.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.TextBoxReplaceDomainUK.Name = "TextBoxReplaceDomainUK"
        Me.TextBoxReplaceDomainUK.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxReplaceDomainUK.TabIndex = 10
        Me.TextBoxReplaceDomainUK.Text = "http://hybridsupply-uk.localhost"
        '
        'TextBoxSearchDomainUK
        '
        Me.TextBoxSearchDomainUK.Location = New System.Drawing.Point(17, 56)
        Me.TextBoxSearchDomainUK.Margin = New System.Windows.Forms.Padding(0, 0, 20, 5)
        Me.TextBoxSearchDomainUK.Name = "TextBoxSearchDomainUK"
        Me.TextBoxSearchDomainUK.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxSearchDomainUK.TabIndex = 9
        Me.TextBoxSearchDomainUK.Text = "https://hybridsupply.uk"
        '
        'TextBoxReplaceDirectoryAbsolute
        '
        Me.TextBoxReplaceDirectoryAbsolute.Location = New System.Drawing.Point(440, 236)
        Me.TextBoxReplaceDirectoryAbsolute.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.TextBoxReplaceDirectoryAbsolute.Name = "TextBoxReplaceDirectoryAbsolute"
        Me.TextBoxReplaceDirectoryAbsolute.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxReplaceDirectoryAbsolute.TabIndex = 8
        Me.TextBoxReplaceDirectoryAbsolute.Text = "C:\xampp\htdocs\hybridsupply.de-2019"
        '
        'TextBoxSearchDirectoryAbsolute
        '
        Me.TextBoxSearchDirectoryAbsolute.Location = New System.Drawing.Point(17, 236)
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
        Me.ButtonImport.Location = New System.Drawing.Point(20, 669)
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
        Me.ProgressBar1.Location = New System.Drawing.Point(460, 669)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(403, 32)
        Me.ProgressBar1.TabIndex = 10
        '
        'TextBoxReplaceDomainEscapedDE
        '
        Me.TextBoxReplaceDomainEscapedDE.Location = New System.Drawing.Point(440, 176)
        Me.TextBoxReplaceDomainEscapedDE.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.TextBoxReplaceDomainEscapedDE.Name = "TextBoxReplaceDomainEscapedDE"
        Me.TextBoxReplaceDomainEscapedDE.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxReplaceDomainEscapedDE.TabIndex = 20
        Me.TextBoxReplaceDomainEscapedDE.Text = "http:\/\/hybridsupply-de.localhost"
        '
        'TextBoxSearchDomainEscapedDE
        '
        Me.TextBoxSearchDomainEscapedDE.Location = New System.Drawing.Point(17, 176)
        Me.TextBoxSearchDomainEscapedDE.Margin = New System.Windows.Forms.Padding(0, 0, 20, 5)
        Me.TextBoxSearchDomainEscapedDE.Name = "TextBoxSearchDomainEscapedDE"
        Me.TextBoxSearchDomainEscapedDE.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxSearchDomainEscapedDE.TabIndex = 19
        Me.TextBoxSearchDomainEscapedDE.Text = "https:\/\/hybridsupply.de"
        '
        'TextBoxReplaceDomainEncodedDE
        '
        Me.TextBoxReplaceDomainEncodedDE.Location = New System.Drawing.Point(440, 206)
        Me.TextBoxReplaceDomainEncodedDE.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.TextBoxReplaceDomainEncodedDE.Name = "TextBoxReplaceDomainEncodedDE"
        Me.TextBoxReplaceDomainEncodedDE.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxReplaceDomainEncodedDE.TabIndex = 18
        Me.TextBoxReplaceDomainEncodedDE.Text = "http%3A%2F%2Fhybridsupply-de.localhost"
        '
        'TextBoxSearchDomainEncodedDE
        '
        Me.TextBoxSearchDomainEncodedDE.Location = New System.Drawing.Point(17, 206)
        Me.TextBoxSearchDomainEncodedDE.Margin = New System.Windows.Forms.Padding(0, 0, 20, 5)
        Me.TextBoxSearchDomainEncodedDE.Name = "TextBoxSearchDomainEncodedDE"
        Me.TextBoxSearchDomainEncodedDE.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxSearchDomainEncodedDE.TabIndex = 17
        Me.TextBoxSearchDomainEncodedDE.Text = "https%3A%2F%2Fhybridsupply.de"
        '
        'TextBoxReplaceDomainDE
        '
        Me.TextBoxReplaceDomainDE.Location = New System.Drawing.Point(440, 146)
        Me.TextBoxReplaceDomainDE.Margin = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.TextBoxReplaceDomainDE.Name = "TextBoxReplaceDomainDE"
        Me.TextBoxReplaceDomainDE.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxReplaceDomainDE.TabIndex = 16
        Me.TextBoxReplaceDomainDE.Text = "http://hybridsupply-de.localhost"
        '
        'TextBoxSearchDomainDE
        '
        Me.TextBoxSearchDomainDE.Location = New System.Drawing.Point(17, 146)
        Me.TextBoxSearchDomainDE.Margin = New System.Windows.Forms.Padding(0, 0, 20, 5)
        Me.TextBoxSearchDomainDE.Name = "TextBoxSearchDomainDE"
        Me.TextBoxSearchDomainDE.Size = New System.Drawing.Size(403, 25)
        Me.TextBoxSearchDomainDE.TabIndex = 15
        Me.TextBoxSearchDomainDE.Text = "https://hybridsupply.de"
        '
        'FormDatabaseImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(933, 721)
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
    Friend WithEvents TextBoxSearchDomainUK As TextBox
    Friend WithEvents TextBoxReplaceDomainUK As TextBox
    Friend WithEvents ButtonImport As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TextBoxReplaceDomainEscapedUK As TextBox
    Friend WithEvents TextBoxSearchDomainEscapedUK As TextBox
    Friend WithEvents TextBoxReplaceDomainEncodedUK As TextBox
    Friend WithEvents TextBoxSearchDomainEncodedUK As TextBox
    Friend WithEvents TextBoxReplaceDomainEscapedDE As TextBox
    Friend WithEvents TextBoxSearchDomainEscapedDE As TextBox
    Friend WithEvents TextBoxReplaceDomainEncodedDE As TextBox
    Friend WithEvents TextBoxSearchDomainEncodedDE As TextBox
    Friend WithEvents TextBoxReplaceDomainDE As TextBox
    Friend WithEvents TextBoxSearchDomainDE As TextBox
End Class
