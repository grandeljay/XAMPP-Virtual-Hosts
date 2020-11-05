Imports System.ComponentModel
Imports System.IO

Module BackgroundOperation
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
        Public Shared BackgroundWorker As New BackgroundWorker

        Shared ProgressDirectory As String

        Public Shared Sub Run()
            '
            ' Initialise Backgroundworker
            '
            AddHandler BackgroundWorker.DoWork, AddressOf BackgroundWorker_DoWork
            AddHandler BackgroundWorker.ProgressChanged, AddressOf BackgroundWorker_ProgressChanged
            AddHandler BackgroundWorker.RunWorkerCompleted, AddressOf BackgroundWorker_RunWorkerCompleted
            BackgroundWorker.WorkerReportsProgress = True
            BackgroundWorker.WorkerSupportsCancellation = True

            '
            ' Guess Locations
            '
            Dim CommonLocations As New List(Of String)
            CommonLocations.Add(My.Settings.FileHttpdVhostsConf)

            For Each Drive As String In Environment.GetLogicalDrives
                CommonLocations.Add(Drive & "XAMPP\apache\conf\extra\" & HttpdVhostsConf)
            Next

            For Each Location As String In CommonLocations
                If File.Exists(Location) Then
                    My.Settings.FileHttpdVhostsConf = Location
                    Exit Sub
                End If
            Next

            '
            ' Search Drives if previously unsuccessful
            '
            FilesMissing()

            If BackgroundWorker.IsBusy Then Exit Sub
            BackgroundWorker.RunWorkerAsync()

            FormPathsSpecify.TimerDirectoryHttpdVhostsConf.Start()
            FormPathsSpecify.LabelProgressHttpdVhostsConf.Visible = True
        End Sub

        Private Shared Sub BackgroundWorker_DoWork(ByVal sender As Object, e As DoWorkEventArgs)
            For Each LogicalDrive As String In Environment.GetLogicalDrives
                GetFileIndexHttpdVhostsConf(LogicalDrive, VirtualHosts.HttpdVhostsConf)
            Next
        End Sub

        Private Shared Sub BackgroundWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
            ProgressDirectory = e.UserState
        End Sub

        Private Shared Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
            FormPathsSpecify.TimerDirectoryHttpdVhostsConf.Stop()
            FormPathsSpecify.TextBoxDirectoryHttpdVhostsConf.Text = My.Settings.FileHttpdVhostsConf
        End Sub

        Private Shared Sub GetFileIndexHttpdVhostsConf(ByVal DirectoryToSearch As String, ByVal FileToSearchFor As String)
            If BackgroundWorker.CancellationPending Then Exit Sub


            '
            ' Report Progress
            '
            BackgroundWorker.ReportProgress(0, DirectoryToSearch)

            For Each iFile As String In Directory.GetFiles(DirectoryToSearch, FileToSearchFor, SearchOption.TopDirectoryOnly)
                If Not iFile.ToLower.EndsWith("apache\conf\extra\httpd-vhosts.conf") Then Continue For

                Dim UseFile As DialogResult = MessageBox.Show(
                    "Is this your " & FileToSearchFor & " file?" & Environment.NewLine & Environment.NewLine &
                    iFile,
                    Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If UseFile = DialogResult.Yes Then
                    My.Settings.FileHttpdVhostsConf = iFile
                    BackgroundWorker.CancelAsync()
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

    Structure SetXAMPP
        Public Shared BackgroundWorker As New BackgroundWorker
        Public Shared ProgressDirectory As String

        Private Shared DirectoryMustContain As String() = {
            "service.exe",
            "uninstall.exe",
            "xampp_start.exe",
            "xampp_stop.exe",
            "xampp-control.exe"
        }

        Public Shared Sub Run()
            '
            ' Initialise Backgroundworker
            '
            AddHandler BackgroundWorker.DoWork, AddressOf BackgroundWorker_DoWork
            AddHandler BackgroundWorker.ProgressChanged, AddressOf BackgroundWorker_ProgressChanged
            AddHandler BackgroundWorker.RunWorkerCompleted, AddressOf BackgroundWorker_RunWorkerCompleted
            BackgroundWorker.WorkerReportsProgress = True
            BackgroundWorker.WorkerSupportsCancellation = True

            '
            ' Guess Locations
            '
            Dim CommonLocations As New List(Of String)
            CommonLocations.Add(My.Settings.DirectoryXAMPP)

            For Each Drive As String In Environment.GetLogicalDrives
                CommonLocations.Add(Drive & "XAMPP")
            Next

            For Each Location As String In CommonLocations
                If Directory.Exists(Location) Then
                    My.Settings.DirectoryXAMPP = Location
                    Exit Sub
                End If
            Next

            '
            ' Search Drives if previously unsuccessful
            '
            If BackgroundWorker.IsBusy Then Exit Sub
            BackgroundWorker.RunWorkerAsync()

            FormPathsSpecify.TimerDirectoryXAMPP.Start()
            FormPathsSpecify.LabelProgressXAMPP.Visible = True
        End Sub

        Private Shared Sub BackgroundWorker_DoWork(ByVal sender As Object, e As DoWorkEventArgs)
            For Each LogicalDrive As String In Environment.GetLogicalDrives
                GetDirectoryXAMPP(LogicalDrive, VirtualHosts.XAMPP)
            Next
        End Sub

        Private Shared Sub BackgroundWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
            ProgressDirectory = e.UserState
        End Sub

        Private Shared Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
            FormPathsSpecify.TimerDirectoryXAMPP.Stop()
            FormPathsSpecify.TextBoxDirectoryXAMPP.Text = My.Settings.DirectoryXAMPP
        End Sub

        Private Shared Sub GetDirectoryXAMPP(ByVal DirectoryToSearch As String, ByVal FileToSearchFor As String)
            If BackgroundWorker.CancellationPending Then Exit Sub


            '
            ' Report Progress
            '
            BackgroundWorker.ReportProgress(0, DirectoryToSearch)

            For Each iDirectory As String In Directory.GetDirectories(DirectoryToSearch, "*", SearchOption.TopDirectoryOnly)
                If iDirectory.Contains("$") Then Continue For

                If Path.GetFileName(iDirectory).ToLower = FileToSearchFor.ToLower Then
                    '
                    ' Determine if the Directory contians XAMPP specific files
                    ' Exit For and skip current directory if it doesn't
                    '
                    Dim SkipDirectory As Boolean = False

                    For Each RequiredFile As String In DirectoryMustContain
                        If Not File.Exists(iDirectory & "\" & RequiredFile) Then
                            SkipDirectory = True
                            Exit For
                        End If
                    Next

                    If SkipDirectory Then Continue For


                    '
                    ' Continue if it does
                    '
                    Dim UseDirectory As DialogResult = MessageBox.Show(
                                                  "Is this your " & FileToSearchFor & " installation directory?" & Environment.NewLine & Environment.NewLine &
                                                  iDirectory,
                                                  Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If UseDirectory = DialogResult.Yes Then
                        My.Settings.DirectoryXAMPP = iDirectory
                        BackgroundWorker.CancelAsync()
                        Exit Sub
                    End If
                End If

                Try
                    GetDirectoryXAMPP(iDirectory, FileToSearchFor)
                Catch UAE As System.UnauthorizedAccessException
                Catch DNFE As System.IO.DirectoryNotFoundException
                    ' Skip Directory
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
