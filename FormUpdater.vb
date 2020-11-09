Imports System.IO
Imports System.Net

Public Class FormUpdater
    Dim DownloadFileTo As String

    Private Sub FormUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormUpdater_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub ButtonDownload_Click(sender As Object, e As EventArgs) Handles ButtonDownload.Click
        If Directory.Exists(TextBoxDirectory.Text) Then
            TextBoxDirectory.Text = TextBoxDirectory.Text.TrimEnd("\")

            DownloadFileTo = TextBoxDirectory.Text & "\" & Application.ProductName & ".exe"

            Dim HTML As String = New System.Net.WebClient().DownloadString("https://github.com/grandeljay/XAMPP-Virtual-Hosts/releases/latest")

            Dim DownloadString As New Uri("https://github.com" & Regex.GetGroups(HTML, "\/grandeljay\/XAMPP-Virtual-Hosts\/releases\/download\/v\d+\.\d+\.\d+\/XAMPP-Virtual-Hosts\.exe").First)
            Dim Downloader As New WebClient
            AddHandler Downloader.DownloadProgressChanged, AddressOf Downloader_ProgressChanged
            AddHandler Downloader.DownloadFileCompleted, AddressOf Downloader_DownloadFileCompleted

            Downloader.DownloadFileAsync(DownloadString, DownloadFileTo)
        Else
            Beep()
        End If
    End Sub

    Private Sub Downloader_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        ProgressBarUpdate.Value = e.ProgressPercentage
    End Sub

    Private Sub Downloader_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        ButtonLaunch.Enabled = True
    End Sub

    Private Sub ButtonLaunch_Click(sender As Object, e As EventArgs) Handles ButtonLaunch.Click
        Process.Start(DownloadFileTo)
        End
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Dim Cancel As DialogResult = MessageBox.Show("It is highly recommended to keep your software up-to-date." & Environment.NewLine & Environment.NewLine & "Proceed anyway?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Cancel = DialogResult.Yes Then
            FormMain.IgnoreUpdate = True
            FormMain.Show()
            Me.Close()
        End If
    End Sub
End Class