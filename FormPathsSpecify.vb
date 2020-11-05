Imports System.IO

Public Class FormPathsSpecify
    Private Sub FormPathsSpecify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxDirectoryHosts.Text = My.Settings.FileHosts
        TextBoxDirectoryXAMPP.Text = My.Settings.DirectoryXAMPP
        TextBoxDirectoryHttpdVhostsConf.Text = My.Settings.FileHttpdVhostsConf
    End Sub

    Private Sub ButtonSaveAndClose_Click(sender As Object, e As EventArgs) Handles ButtonSaveAndClose.Click
        Dim Conditions As New List(Of Boolean)

        '
        ' hosts
        '
        Dim Hosts As String = TextBoxDirectoryHosts.Text

        If File.Exists(Hosts) Then
            My.Settings.FileHosts = Hosts
        End If

        Conditions.Add(File.Exists(Hosts))


        '
        ' XAMPP
        '
        Dim XAMPP As String = TextBoxDirectoryXAMPP.Text

        If Directory.Exists(XAMPP) Then
            If Not BackgroundOperation.SetXAMPP.BackgroundWorker Is Nothing Then BackgroundOperation.SetXAMPP.BackgroundWorker.CancelAsync()

            My.Settings.DirectoryXAMPP = XAMPP
        End If

        Conditions.Add(Directory.Exists(XAMPP))


        '
        ' httpd-vhosts.conf
        '
        Dim HttpdfVhostsConf As String = TextBoxDirectoryHttpdVhostsConf.Text

        If File.Exists(HttpdfVhostsConf) Then
            If Not BackgroundOperation.SetHttpdVhostsConf.BackgroundWorker Is Nothing Then BackgroundOperation.SetHttpdVhostsConf.BackgroundWorker.CancelAsync()

            My.Settings.FileHttpdVhostsConf = HttpdfVhostsConf
        End If

        Conditions.Add(File.Exists(HttpdfVhostsConf))


        '
        ' Check conditions
        '
        If Not Conditions.Contains(False) Then
            Me.Close()
        Else
            Beep()
        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub TimerDirectoryXAMPP_Tick(sender As Object, e As EventArgs) Handles TimerDirectoryXAMPP.Tick
        LabelProgressXAMPP.Text = BackgroundOperation.SetXAMPP.ProgressDirectory
    End Sub

    Private Sub TimerUpdateDirectory_Tick(sender As Object, e As EventArgs) Handles TimerDirectoryHttpdVhostsConf.Tick
        LabelProgressHttpdVhostsConf.Text = BackgroundOperation.SetHttpdVhostsConf.ProgressDirectory
    End Sub
End Class