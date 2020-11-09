Imports System.IO
Imports System.Net


Module Functions
    Public Function GetFileContents(ByVal Filepath As String) As String
        If Not File.Exists(Filepath) Then Return ""

        Dim FilepathContents As String = File.ReadAllText(Filepath)

        Return FilepathContents
    End Function


    Public Function GetTextBetween(ByVal Subject As String, ByVal TextStart As String, ByVal TextEnd As String) As String()
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

        'Dim RegexVersion As New System.Text.RegularExpressions.Regex("<a href=" & Chr(34) & ".+?" & Chr(34) & ">v(\d+.\d+.\d+)<\/a>")
        'Dim RegexVersionMatch As System.Text.RegularExpressions.Match = RegexVersion.Match(HTML)

        'Return RegexVersionMatch.Groups(1).Value

        Return Regex.GetGroup(HTML, "<a href=" & Chr(34) & ".+?" & Chr(34) & ">v(\d+.\d+.\d+)<\/a>")
    End Function


    Public Function WriteToFile(ByVal Filepath As String, ByVal Contents As Object, Optional ByVal BackupOriginal As Boolean = False) As Boolean
        If BackupOriginal Then Backups.CreateNew(Filepath)

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

    Public Function SanitiseDomain(ByVal Domain As String) As String
        Domain = Domain.ToLower.Trim
        Domain = System.Text.RegularExpressions.Regex.Replace(Domain, "[^a-z\-\.0-9]", "-")

        Do
            Domain = Domain.Replace("--", "-")
        Loop Until Not Domain.Contains("--")

        Domain = Domain.Trim("-")

        Return Domain
    End Function
End Module
