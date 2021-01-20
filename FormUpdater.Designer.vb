<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdater))
        Me.GroupBoxUpdate = New System.Windows.Forms.GroupBox()
        Me.ButtonLaunch = New System.Windows.Forms.Button()
        Me.ButtonDownload = New System.Windows.Forms.Button()
        Me.LabelProgress = New System.Windows.Forms.Label()
        Me.LabelDirectory = New System.Windows.Forms.Label()
        Me.ProgressBarUpdate = New System.Windows.Forms.ProgressBar()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.GroupBoxUpdate.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxUpdate
        '
        Me.GroupBoxUpdate.AutoSize = True
        Me.GroupBoxUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxUpdate.Controls.Add(Me.ButtonLaunch)
        Me.GroupBoxUpdate.Controls.Add(Me.ButtonDownload)
        Me.GroupBoxUpdate.Controls.Add(Me.LabelProgress)
        Me.GroupBoxUpdate.Controls.Add(Me.LabelDirectory)
        Me.GroupBoxUpdate.Controls.Add(Me.ProgressBarUpdate)
        Me.GroupBoxUpdate.Location = New System.Drawing.Point(20, 20)
        Me.GroupBoxUpdate.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.GroupBoxUpdate.Name = "GroupBoxUpdate"
        Me.GroupBoxUpdate.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBoxUpdate.Size = New System.Drawing.Size(437, 223)
        Me.GroupBoxUpdate.TabIndex = 0
        Me.GroupBoxUpdate.TabStop = False
        Me.GroupBoxUpdate.Text = "Update Available"
        '
        'ButtonLaunch
        '
        Me.ButtonLaunch.AutoSize = True
        Me.ButtonLaunch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonLaunch.Enabled = False
        Me.ButtonLaunch.Location = New System.Drawing.Point(20, 153)
        Me.ButtonLaunch.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.ButtonLaunch.Name = "ButtonLaunch"
        Me.ButtonLaunch.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonLaunch.Size = New System.Drawing.Size(66, 32)
        Me.ButtonLaunch.TabIndex = 10
        Me.ButtonLaunch.Text = "Launch"
        Me.ButtonLaunch.UseVisualStyleBackColor = True
        '
        'ButtonDownload
        '
        Me.ButtonDownload.AutoSize = True
        Me.ButtonDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonDownload.Location = New System.Drawing.Point(20, 58)
        Me.ButtonDownload.Margin = New System.Windows.Forms.Padding(0, 2, 0, 20)
        Me.ButtonDownload.Name = "ButtonDownload"
        Me.ButtonDownload.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonDownload.Size = New System.Drawing.Size(83, 32)
        Me.ButtonDownload.TabIndex = 9
        Me.ButtonDownload.Text = "Download"
        Me.ButtonDownload.UseVisualStyleBackColor = True
        '
        'LabelProgress
        '
        Me.LabelProgress.AutoSize = True
        Me.LabelProgress.Location = New System.Drawing.Point(17, 110)
        Me.LabelProgress.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelProgress.Name = "LabelProgress"
        Me.LabelProgress.Size = New System.Drawing.Size(60, 18)
        Me.LabelProgress.TabIndex = 3
        Me.LabelProgress.Text = "Progress"
        '
        'LabelDirectory
        '
        Me.LabelDirectory.AutoSize = True
        Me.LabelDirectory.Location = New System.Drawing.Point(17, 38)
        Me.LabelDirectory.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDirectory.Name = "LabelDirectory"
        Me.LabelDirectory.Size = New System.Drawing.Size(344, 18)
        Me.LabelDirectory.TabIndex = 1
        Me.LabelDirectory.Text = "There is an update available. Please download and run it."
        '
        'ProgressBarUpdate
        '
        Me.ProgressBarUpdate.Location = New System.Drawing.Point(20, 128)
        Me.ProgressBarUpdate.Margin = New System.Windows.Forms.Padding(0)
        Me.ProgressBarUpdate.Name = "ProgressBarUpdate"
        Me.ProgressBarUpdate.Size = New System.Drawing.Size(397, 23)
        Me.ProgressBarUpdate.TabIndex = 1
        '
        'ButtonClose
        '
        Me.ButtonClose.AutoSize = True
        Me.ButtonClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonClose.Location = New System.Drawing.Point(390, 263)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonClose.Size = New System.Drawing.Size(47, 32)
        Me.ButtonClose.TabIndex = 11
        Me.ButtonClose.Text = "Skip"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'FormUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(766, 393)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.GroupBoxUpdate)
        Me.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormUpdater"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Updater"
        Me.GroupBoxUpdate.ResumeLayout(False)
        Me.GroupBoxUpdate.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxUpdate As GroupBox
    Friend WithEvents ProgressBarUpdate As ProgressBar
    Friend WithEvents LabelProgress As Label
    Friend WithEvents LabelDirectory As Label
    Friend WithEvents ButtonDownload As Button
    Friend WithEvents ButtonLaunch As Button
    Friend WithEvents ButtonClose As Button
End Class
