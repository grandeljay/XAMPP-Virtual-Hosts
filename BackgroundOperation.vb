Imports System.ComponentModel
Imports System.IO

Module BackgroundOperation
    Public BackgroundWorkerGetFileHttpdVhostsConf As New BackgroundWorker

    Structure SetHosts
        Shared ProgressDirectory As String

        Public Shared Sub Run()
            Dim CommonLocations As String() = {
                 My.Settings.FileHosts,
                "C:\Windows\System32\drivers\etc\" & Hosts
            }

            For Each Location As String In CommonLocations
                If File.Exists(Location) Then
                    My.Settings.FileHosts = Location
                    Exit Sub
                End If
            Next

            FilesMissing()
        End Sub
    End Structure

    Structure SetHttpdVhostsConf
        Shared ProgressDirectory As String

        Public Shared Sub Run()
            '
            ' Initialise Backgroundworker
            '
            AddHandler BackgroundWorkerGetFileHttpdVhostsConf.DoWork, AddressOf BackgroundWorkerGetFileHttpdVhostsConf_DoWork
            AddHandler BackgroundWorkerGetFileHttpdVhostsConf.ProgressChanged, AddressOf BackgroundWorkerGetFileHttpdVhostsConf_ProgressChanged
            AddHandler BackgroundWorkerGetFileHttpdVhostsConf.RunWorkerCompleted, AddressOf BackgroundWorkerGetFileHttpdVhostsConf_RunWorkerCompleted
            BackgroundWorkerGetFileHttpdVhostsConf.WorkerReportsProgress = True
            BackgroundWorkerGetFileHttpdVhostsConf.WorkerSupportsCancellation = True

            Dim CommonLocations As String() = {
                My.Settings.FileHttpdVhostsConf,
                "C:\XAMPP\apache\conf\extra\" & HttpdVhostsConf,
                "D:\XAMPP\apache\conf\extra\" & HttpdVhostsConf
            }

            For Each Location As String In CommonLocations
                If File.Exists(Location) Then
                    My.Settings.FileHttpdVhostsConf = Location
                    Exit Sub
                End If
            Next

            FilesMissing()

            If BackgroundWorkerGetFileHttpdVhostsConf.IsBusy Then Exit Sub
            BackgroundWorkerGetFileHttpdVhostsConf.RunWorkerAsync()
            FormPathsSpecify.TimerUpdateDirectory.Start()
        End Sub

        Private Shared Sub BackgroundWorkerGetFileHttpdVhostsConf_DoWork(ByVal sender As Object, e As DoWorkEventArgs)
            For Each LogicalDrive As String In Environment.GetLogicalDrives
                GetFileIndexHttpdVhostsConf(LogicalDrive, VirtualHosts.HttpdVhostsConf)
            Next
        End Sub

        Private Shared Sub BackgroundWorkerGetFileHttpdVhostsConf_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
            ProgressDirectory = e.UserState
        End Sub

        Private Shared Sub BackgroundWorkerGetFileHttpdVhostsConf_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
            FormPathsSpecify.TimerUpdateDirectory.Stop()
            FormPathsSpecify.TextBoxHttpdVhostsConfDirectory.Text = My.Settings.FileHttpdVhostsConf
        End Sub

        Private Shared Sub GetFileIndexHttpdVhostsConf(ByVal DirectoryToSearch As String, ByVal FileToSearchFor As String)
            If BackgroundWorkerGetFileHttpdVhostsConf.CancellationPending Then Exit Sub


            '
            ' Report Progress
            '
            BackgroundWorkerGetFileHttpdVhostsConf.ReportProgress(0, DirectoryToSearch)

            For Each iFile As String In Directory.GetFiles(DirectoryToSearch, FileToSearchFor, SearchOption.TopDirectoryOnly)
                If Not iFile.ToLower.EndsWith("apache\conf\extra\httpd-vhosts.conf") Then Continue For

                Dim UseFile As DialogResult = MessageBox.Show(
                    "Is this your " & FileToSearchFor & " file?" & Environment.NewLine & Environment.NewLine &
                    iFile,
                    Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If UseFile = DialogResult.Yes Then
                    My.Settings.FileHttpdVhostsConf = iFile
                    BackgroundWorkerGetFileHttpdVhostsConf.CancelAsync()
                    Exit Sub
                End If
            Next

            For Each iDirectory As String In Directory.GetDirectories(DirectoryToSearch, "*", SearchOption.TopDirectoryOnly)
                If iDirectory.Contains("$") Then Continue For

                Try
                    GetFileIndexHttpdVhostsConf(iDirectory, FileToSearchFor)
                Catch UAE As System.UnauthorizedAccessException
                Catch DNFE As System.IO.DirectoryNotFoundException
                    'Skip Directory
                End Try
            Next
        End Sub
    End Structure

    Dim FilesMissingCount As Integer
    Private Sub FilesMissing()
        FilesMissingCount += 1

        If FilesMissingCount > 1 Then Exit Sub

        '
        ' Prompt for manual input or progress
        '
        Dim SpecifyPaths As DialogResult = MessageBox.Show("At least 1 required file could not be found." & Environment.NewLine & Environment.NewLine & "Would you like to specify it now?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If SpecifyPaths = DialogResult.Yes Then
            FormPathsSpecify.Show()
        End If
    End Sub
End Module
