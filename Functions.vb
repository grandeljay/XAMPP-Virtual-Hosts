Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions

Module Functions
    Function GetFileContents(ByVal Filepath As String) As String
        If Not File.Exists(Filepath) Then Return ""

        Dim FilepathContents As String = File.ReadAllText(Filepath)

        Return FilepathContents
    End Function

    Function GetRegexGroups(ByVal Subject As String, ByVal Regex As String, Optional ByVal Groups As Integer() = Nothing) As String()
        Dim DoRegex As New Regex(Regex)
        Dim DoRegexMatch As MatchCollection = DoRegex.Matches(Subject)
        Dim DoRegexOutput As New List(Of String)

        For i = 0 To DoRegexMatch.Count - 1
            If Groups Is Nothing OrElse Groups.Count > i AndAlso (Groups(i) = Nothing OrElse Groups(i) <= 0) Then
                DoRegexOutput.Add(DoRegexMatch(i).Value)
            Else
                For Each iGroup As Integer In Groups
                    DoRegexOutput.Add(DoRegexMatch(i).Groups(iGroup).Value)
                Next
            End If
        Next

        Return DoRegexOutput.ToArray
    End Function


    Function GetRegexGroup(ByVal Subject As String, ByVal Regex As String, Optional ByVal GroupIndex As Integer = 1) As String
        Dim DoRegex As New Regex(Regex)
        Dim DoRegexMatch As Match = DoRegex.Match(Subject)
        Dim DoRegexOutput As String

        If GroupIndex >= DoRegexMatch.Groups.Count Then GroupIndex = DoRegexMatch.Groups.Count - 1

        If DoRegexMatch.Groups.Count > 0 Then
            DoRegexOutput = DoRegexMatch.Groups(GroupIndex).Value
        Else
            DoRegexOutput = DoRegexMatch.Value
        End If

        If Not DoRegexMatch.Success Then
            DoRegexOutput = "Regex operation: " & Regex & " failed."
        End If

        Return DoRegexOutput
    End Function

    Function GetTextBetween(ByVal Subject As String, ByVal TextStart As String, ByVal TextEnd As String) As String()
        Dim IndexStart As Integer
        Dim IndexEnd As Integer

        Dim TextsBetween As New List(Of String)

        For i = 0 To Subject.Length - 1
            '
            ' Start
            '
            If Subject.Length >= i + TextStart.Length AndAlso Subject.Substring(i, TextStart.Length) = TextStart Then
                IndexStart = i
            End If

            '
            ' End
            '
            If Subject.Length >= i + TextEnd.Length AndAlso Subject.Substring(i, TextEnd.Length) = TextEnd Then
                IndexEnd = i + TextEnd.Length

                Dim TextToAdd As String = Subject.Substring(IndexStart, IndexEnd - IndexStart).Trim
                TextsBetween.Add(TextToAdd)

                IndexStart = IndexEnd
            End If
        Next

        Return TextsBetween.ToArray
    End Function

    Function GetVirtualHosts() As List(Of ClassVirtualHost)
        Dim VirtualHostsList As New List(Of ClassVirtualHost)

        '
        ' Hosts
        '
        Dim FileHostsContents As String = Functions.GetFileContents(My.Settings.FileHosts).Trim

        Dim ListCount As New List(Of Integer)


        ' IPv4 Address
        Dim IPv4Addresses As New List(Of String)
        IPv4Addresses.AddRange(Functions.GetRegexGroups(FileHostsContents, "\n([0-9\.]+)", {1}))
        ListCount.Add(IPv4Addresses.Count)


        ' IPv4 Host
        Dim IPv4Hosts As New List(Of String)
        IPv4Hosts.AddRange(Functions.GetRegexGroups(FileHostsContents, "\n[0-9\.]+\s+([a-z\.]+)", {1}))
        ListCount.Add(IPv4Hosts.Count)


        ' IPv6 Address
        Dim IPv6Addresses As New List(Of String)
        IPv6Addresses.AddRange(Functions.GetRegexGroups(FileHostsContents, "\n([0-9:a-f]+)\s+", {1}))
        ListCount.Add(IPv6Addresses.Count)


        ' IPv6 Host
        Dim IPv6Hosts As New List(Of String)
        IPv6Hosts.AddRange(Functions.GetRegexGroups(FileHostsContents, "\n[0-9:a-f]+\s+([a-z\.]+)", {1}))
        ListCount.Add(IPv6Hosts.Count)


        ' Add to Class
        Dim IPv4Index As Integer = 0
        Dim IPv6Index As Integer = 0
        Dim i4 As Integer
        Dim i6 As Integer

        For i = 0 To ListCount.Max - 1
            Dim VirtualHost As New ClassVirtualHost

            i4 = i + IPv4Index
            i6 = i + IPv6Index

            If IPv4Hosts.Count > i4 AndAlso IPv6Hosts.Count > i6 AndAlso IPv4Hosts(i4) = IPv6Hosts(i6) Then
                ' Add entries if there is an equal amount of IPv6 and IPv4 Entries
                VirtualHost.IPv4.Address = IPv4Addresses(i4)
                VirtualHost.IPv4.Host = IPv4Hosts(i4)
                VirtualHost.IPv6.Address = IPv6Addresses(i6)
                VirtualHost.IPv6.Host = IPv6Hosts(i6)
            Else
                ' Determine if IPv4 or IPv6 Entry is missing
                ' offset the opposite index for the missing entry
                If FileHostsContents.IndexOf(IPv4Hosts(i4)) < FileHostsContents.IndexOf(IPv6Hosts(i6)) Then
                    VirtualHost.IPv4.Address = IPv4Addresses(i4)
                    VirtualHost.IPv4.Host = IPv4Hosts(i4)

                    IPv6Index -= 1
                Else
                    VirtualHost.IPv6.Address = IPv6Addresses(i6)
                    VirtualHost.IPv6.Host = IPv6Hosts(i6)

                    IPv4Index -= 1
                End If
            End If

            VirtualHostsList.Add(VirtualHost)
        Next


        '
        ' Virtual Hosts
        '
        Dim FileHttpdVhostsContents As String = Functions.GetFileContents(My.Settings.FileHttpdVhostsConf)

        Dim vHostsEntries As String() = Functions.GetTextBetween(FileHttpdVhostsContents, "<VirtualHost *:80>", "</VirtualHost>")

        For Each vHostEntry As String In vHostsEntries
            For Each VirtualHost As ClassVirtualHost In VirtualHostsList
                If vHostEntry.Contains(" " & VirtualHost.Host) Then
                    VirtualHost.VHosts.Parse(vHostEntry)
                End If
            Next
        Next

        Return VirtualHostsList
    End Function

    ''' <summary>
    ''' Determine where a file is.
    ''' </summary>
    ''' <param name="SearchFor">The file you want to locate (case insensitive). Substrings allowed.</param>
    ''' <returns>The full file path.</returns>
    Public Function GetFile(ByVal SearchFor As String) As String
        For Each LogicalDrive As String In Environment.GetLogicalDrives
            Dim SearchForFile As String = GetFileIndex(SearchFor, LogicalDrive)

            If File.Exists(SearchForFile) Then Return SearchForFile
        Next

        Return ""
    End Function

    Private Function GetFileIndex(ByVal SearchFor As String, ByVal DirectoryToSearch As String, Optional ByVal SearchPattern As String = "*") As String
        If SearchPattern = "*" Then
            If Path.HasExtension(SearchFor) Then
                SearchPattern = SearchFor
            Else
                SearchPattern = SearchFor & ".*"
            End If
        End If

        For Each iFile As String In Directory.GetFiles(DirectoryToSearch, SearchPattern, SearchOption.TopDirectoryOnly)
            If iFile.ToLower.Contains(SearchFor) Then
                Return iFile
            End If
        Next

        For Each iDirectory As String In Directory.GetDirectories(DirectoryToSearch, "*", SearchOption.TopDirectoryOnly)
            Dim iDirectoryInfo As New DirectoryInfo(iDirectory)

            If Not iDirectoryInfo.Attributes.HasFlag(FileAttributes.Hidden) AndAlso Directory.Exists(iDirectory) Then
                Try
                    GetFileIndex(SearchFor, iDirectory)
                Catch UAE As System.UnauthorizedAccessException
                    'Skip Directory
                End Try
            End If
        Next

        Return ""
    End Function

    ''' <summary>
    ''' Determine where a directory is.
    ''' </summary>
    ''' <param name="SearchFor">The directory you want to locate (case insensitive). Substrings allowed.</param>
    ''' <returns>The full directory path.</returns>
    Public Function GetDirectory(ByVal SearchFor As String) As String
        For Each LogicalDrive As String In Environment.GetLogicalDrives
            Dim SearchForDirectory As String = GetDirectoryIndex(SearchFor, LogicalDrive)

            If Directory.Exists(SearchForDirectory) Then Return SearchForDirectory
        Next

        Return ""
    End Function

    Private Function GetDirectoryIndex(ByVal SearchFor As String, ByVal DirectoryToSearch As String, Optional ByVal SearchPattern As String = "*") As String
        For Each iDirectory As String In Directory.GetDirectories(DirectoryToSearch, SearchPattern, SearchOption.TopDirectoryOnly)
            Dim iDirectoryInfo As New DirectoryInfo(iDirectory)

            If iDirectory.ToLower.Contains(SearchFor.ToLower) Then
                Return iDirectory
            End If

            If Not iDirectoryInfo.Attributes.HasFlag(FileAttributes.Hidden) Then
                Try
                    GetDirectoryIndex(SearchFor, iDirectory)
                Catch UAE As System.UnauthorizedAccessException
                    'Skip Directory
                End Try
            End If
        Next

        Return ""
    End Function

    Public Function GetNewestVersion() As String
        Dim HTML As String = New WebClient().DownloadString("https://github.com/grandeljay/XAMPP-Virtual-Hosts/releases/latest")

        Dim RegexVersion As New Regex("<a href=" & Chr(34) & ".+?" & Chr(34) & ">v(\d+.\d+.\d+)<\/a>")
        Dim RegexVersionMatch As Match = RegexVersion.Match(HTML)

        Return RegexVersionMatch.Groups(1).Value
    End Function

    Public Function WriteToFile(ByVal Filepath As String, ByVal Contents As Object, Optional ByVal BackupOriginal As Boolean = False)
        If BackupOriginal Then
            '
            ' Create Backup
            '
            Dim DateNow As String = Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "-" & Date.Now.TimeOfDay.Hours & "-" & Date.Now.TimeOfDay.Minutes
            Dim BackupDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\Backups"
            Dim BackupFilepath As String = BackupDirectory & "\" & Path.GetFileName(Filepath) & "." & DateNow

            If Not Directory.Exists(BackupDirectory) Then Directory.CreateDirectory(BackupDirectory)

            File.Copy(Filepath, BackupFilepath, True)

            '
            ' Remove Old Backups
            '
            Dim Backups As New List(Of List(Of String))

            ' hosts
            Dim hosts As New List(Of String)
            For Each hostsFile As String In Directory.GetFiles(BackupDirectory, "hosts.*", SearchOption.TopDirectoryOnly)
                hosts.Add(hostsFile)
            Next

            Backups.Add(hosts)

            ' httpd-vhosts.conf
            Dim httpd_vhostsConf As New List(Of String)

            For Each httpd_vhostsConfFile As String In Directory.GetFiles(BackupDirectory, "httpd-vhosts.conf.*", SearchOption.TopDirectoryOnly)
                httpd_vhostsConf.Add(httpd_vhostsConfFile)
            Next

            Backups.Add(httpd_vhostsConf)


            '
            ' Delete Backups
            '
            For Each Backup As List(Of String) In Backups
                If Backup.Count > 10 Then
                    Do
                        File.Delete(Backup(0))
                        Backup.RemoveAt(0)

                        Application.DoEvents()
                    Loop Until Backup.Count <= 10
                End If
            Next
        End If


        '
        ' Write To File
        '
        If IsArray(Contents) Then
            File.WriteAllLines(Filepath, Contents)
        Else
            File.WriteAllText(Filepath, Contents)
        End If

        Return True
    End Function

    ''' <summary>
    ''' Removes all unnecessary line breaks and trims Input.
    ''' </summary>
    ''' <param name="Input">The string you would like to process.</param>
    ''' <returns>Trimmed Input without more than 1 empty line between paragraphs.</returns>
    Public Function RemoveExtraLines(ByVal Input As String) As String
        Do
            Input = Input.Replace(Environment.NewLine & Environment.NewLine & Environment.NewLine, Environment.NewLine & Environment.NewLine)
        Loop Until Not Input.Contains(Environment.NewLine & Environment.NewLine & Environment.NewLine)

        Return Input.Trim
    End Function
End Module
