Imports System.IO

Public Class FormPathsSpecify
    Private Sub TimerUpdateDirectory_Tick(sender As Object, e As EventArgs) Handles TimerUpdateDirectory.Tick
        LabelHttpdVhostsConfDirectory.Text = BackgroundOperation.SetHttpdVhostsConf.ProgressDirectory
    End Sub

    Private Sub ButtonSaveAndClose_Click(sender As Object, e As EventArgs) Handles ButtonSaveAndClose.Click
        '
        ' hosts
        '
        Dim Hosts As String = TextBoxHostsDirectory.Text

        If File.Exists(Hosts) Then
            My.Settings.FileHosts = Hosts
        End If


        '
        ' httpd-vhosts.conf
        '
        Dim HttpdfVhostsConf As String = TextBoxHttpdVhostsConfDirectory.Text

        If File.Exists(HttpdfVhostsConf) Then

        End If

        If Not BackgroundOperation.BackgroundWorkerGetFileHttpdVhostsConf Is Nothing Then BackgroundOperation.BackgroundWorkerGetFileHttpdVhostsConf.CancelAsync()

        My.Settings.FileHttpdVhostsConf = HttpdfVhostsConf

        If File.Exists(Hosts) AndAlso File.Exists(HttpdfVhostsConf) Then

        Else
            Beep()
        End If
        Me.Close()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub FormPathsSpecify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxHostsDirectory.Text = My.Settings.FileHosts
        TextBoxHttpdVhostsConfDirectory.Text = My.Settings.FileHttpdVhostsConf
    End Sub
End Class