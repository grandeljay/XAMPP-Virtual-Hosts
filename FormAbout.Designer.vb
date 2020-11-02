<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbout
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
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.GroupBoxAbout = New System.Windows.Forms.GroupBox()
        Me.LabelProductVersion = New System.Windows.Forms.Label()
        Me.LabelCompany = New System.Windows.Forms.Label()
        Me.LinkLabelWebsite = New System.Windows.Forms.LinkLabel()
        Me.GroupBoxAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Location = New System.Drawing.Point(23, 38)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(124, 18)
        Me.LabelProductName.TabIndex = 0
        Me.LabelProductName.Text = "LabelProductName"
        '
        'GroupBoxAbout
        '
        Me.GroupBoxAbout.AutoSize = True
        Me.GroupBoxAbout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxAbout.Controls.Add(Me.LinkLabelWebsite)
        Me.GroupBoxAbout.Controls.Add(Me.LabelCompany)
        Me.GroupBoxAbout.Controls.Add(Me.LabelProductVersion)
        Me.GroupBoxAbout.Controls.Add(Me.LabelProductName)
        Me.GroupBoxAbout.Location = New System.Drawing.Point(20, 20)
        Me.GroupBoxAbout.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBoxAbout.Name = "GroupBoxAbout"
        Me.GroupBoxAbout.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBoxAbout.Size = New System.Drawing.Size(179, 148)
        Me.GroupBoxAbout.TabIndex = 1
        Me.GroupBoxAbout.TabStop = False
        Me.GroupBoxAbout.Text = "About"
        '
        'LabelProductVersion
        '
        Me.LabelProductVersion.AutoSize = True
        Me.LabelProductVersion.Location = New System.Drawing.Point(23, 56)
        Me.LabelProductVersion.Name = "LabelProductVersion"
        Me.LabelProductVersion.Size = New System.Drawing.Size(133, 18)
        Me.LabelProductVersion.TabIndex = 1
        Me.LabelProductVersion.Text = "LabelProductVersion"
        '
        'LabelCompany
        '
        Me.LabelCompany.AutoSize = True
        Me.LabelCompany.Location = New System.Drawing.Point(23, 74)
        Me.LabelCompany.Name = "LabelCompany"
        Me.LabelCompany.Size = New System.Drawing.Size(98, 18)
        Me.LabelCompany.TabIndex = 2
        Me.LabelCompany.Text = "LabelCompany"
        '
        'LinkLabelWebsite
        '
        Me.LinkLabelWebsite.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabelWebsite.AutoSize = True
        Me.LinkLabelWebsite.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelWebsite.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabelWebsite.Location = New System.Drawing.Point(23, 92)
        Me.LinkLabelWebsite.Name = "LinkLabelWebsite"
        Me.LinkLabelWebsite.Size = New System.Drawing.Size(113, 18)
        Me.LinkLabelWebsite.TabIndex = 3
        Me.LinkLabelWebsite.TabStop = True
        Me.LinkLabelWebsite.Text = "LinkLabelWebsite"
        Me.LinkLabelWebsite.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'FormAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(531, 381)
        Me.Controls.Add(Me.GroupBoxAbout)
        Me.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormAbout"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.GroupBoxAbout.ResumeLayout(False)
        Me.GroupBoxAbout.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelProductName As Label
    Friend WithEvents GroupBoxAbout As GroupBox
    Friend WithEvents LabelProductVersion As Label
    Friend WithEvents LabelCompany As Label
    Friend WithEvents LinkLabelWebsite As LinkLabel
End Class
