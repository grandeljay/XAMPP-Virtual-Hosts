Imports System.IO
Imports System.Text.RegularExpressions

Module Functions
    Function getFileContents(ByVal Filepath As String) As String
        If Not File.Exists(Filepath) Then Return ""

        Dim FilepathContents As String = File.ReadAllText(Filepath)

        Return FilepathContents
    End Function

    Function getRegexGroups(ByVal Subject As String, ByVal Regex As String, Optional ByVal Groups As Integer() = Nothing) As String()
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


    Function getRegexGroup(ByVal Subject As String, ByVal Regex As String, Optional ByVal GroupIndex As Integer = 1) As String
        Dim DoRegex As New Regex(Regex)
        Dim DoRegexMatch As Match = DoRegex.Match(Subject)
        Dim DoRegexOutput As String = ""

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

    Function getTextBetween(ByVal Subject As String, ByVal TextStart As String, ByVal TextEnd As String) As String()
        Dim TextBetween As String = ""

        Dim IndexStart As Integer = -1
        Dim IndexEnd As Integer = -1

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
                IndexEnd = -1
            End If
        Next

        Return TextsBetween.ToArray
    End Function

    Function getVirtualHosts() As List(Of ClassVirtualHost)
        Dim VirtualHostsList As New List(Of ClassVirtualHost)

        '
        ' Hosts
        '
        Dim FileHostsContents As String = Functions.getFileContents(VirtualHosts.FileHosts).Trim

        Dim ListCount As New List(Of Integer)


        ' IPv4 Address
        Dim IPv4Addresses As New List(Of String)
        IPv4Addresses.AddRange(Functions.getRegexGroups(FileHostsContents, "\n([0-9\.]+)", {1}))
        ListCount.Add(IPv4Addresses.Count)


        ' IPv4 Host
        Dim IPv4Hosts As New List(Of String)
        IPv4Hosts.AddRange(Functions.getRegexGroups(FileHostsContents, "\n[0-9\.]+\s+([a-z\.]+)", {1}))
        ListCount.Add(IPv4Hosts.Count)


        ' IPv6 Address
        Dim IPv6Addresses As New List(Of String)
        IPv6Addresses.AddRange(Functions.getRegexGroups(FileHostsContents, "\n([0-9:a-f]+)\s+", {1}))
        ListCount.Add(IPv6Addresses.Count)


        ' IPv6 Host
        Dim IPv6Hosts As New List(Of String)
        IPv6Hosts.AddRange(Functions.getRegexGroups(FileHostsContents, "\n[0-9:a-f]+\s+([a-z\.]+)", {1}))
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
        Dim FileHttpdVhostsContents As String = Functions.getFileContents(VirtualHosts.FileHttpdVhosts)

        Dim vHostsEntries As String() = Functions.getTextBetween(FileHttpdVhostsContents, "<VirtualHost *:80>", "</VirtualHost>")

        For Each vHostEntry As String In vHostsEntries
            For Each VirtualHost As ClassVirtualHost In VirtualHostsList
                If vHostEntry.Contains(" " & VirtualHost.Host) Then
                    VirtualHost.vHosts.Parse(vHostEntry)
                End If
            Next
        Next

        Return VirtualHostsList
    End Function

End Module
