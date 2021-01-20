Imports System.IO
Imports System.Net

Public Class FormUpdater
    Dim DownloadFileTo As String

    Private Sub FormUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormUpdater_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub ButtonDownload_Click(sender As Object, e As EventArgs) Handles ButtonDownload.Click
        DownloadFileTo = Path.GetTempFileName

        Dim HTML As String = New System.Net.WebClient().DownloadString("https://github.com/grandeljay/XAMPP-Virtual-Hosts/releases/latest")
        Dim DownloadPaths As String() = Regex.GetGroups(HTML, "\/grandeljay\/XAMPP-Virtual-Hosts\/releases\/download\/v\d+\.\d+\.\d+\/XAMPP-Virtual-Hosts\.exe")

        If DownloadPaths.Count > 0 Then
            Dim DownloadString As New Uri("https://github.com" & DownloadPaths.First)
            Dim Downloader As New WebClient
            AddHandler Downloader.DownloadProgressChanged, AddressOf Downloader_ProgressChanged
            AddHandler Downloader.DownloadFileCompleted, AddressOf Downloader_DownloadFileCompleted

            Downloader.DownloadFileAsync(DownloadString, DownloadFileTo)
        Else
            MessageBox.Show("Failed to fetch update. Please try again another time.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ButtonClose_Click(sender, e)
        End If
    End Sub

    Private Sub Downloader_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        ProgressBarUpdate.Value = e.ProgressPercentage
    End Sub

    Private Sub Downloader_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        ButtonLaunch.Enabled = True
    End Sub

    Private Sub ButtonLaunch_Click(sender As Object, e As EventArgs) Handles ButtonLaunch.Click
        Process.Start(DownloadFileTo.Replace(".tmp", ".exe"), Chr(34) & "update " & Application.StartupPath & Chr(34))

        End
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Dim SenderButton As Button = TryCast(sender, Button)
        Dim Cancel As DialogResult

        If SenderButton.Name = "ButtonClose" Then
            Cancel = MessageBox.Show("It is highly recommended to keep your software up-to-date." & Environment.NewLine & Environment.NewLine & "Proceed anyway?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Else
            Cancel = DialogResult.Yes
        End If

        If Cancel = DialogResult.Yes Then
            FormMain.IgnoreUpdate = True
            FormMain.Show()
            Me.Close()
        End If
    End Sub
End Class