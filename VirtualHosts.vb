Imports System.IO

Module VirtualHosts
    Public Const Hosts As String = "hosts"
    Public Const XAMPP As String = "XAMPP"
    Public Const HttpdVhostsConf As String = "httpd-vhosts.conf"

    Private Property VirtualHostsList As New List(Of ClassVirtualHost)

    Public Function GetVirtualHosts(Optional ByVal UseCache As Boolean = True) As List(Of ClassVirtualHost)
        If UseCache AndAlso VirtualHostsList.Count > 0 Then Return VirtualHostsList

        Dim FileContents_hosts As String = Functions.GetFileContents(My.Settings.FileHosts)
        Dim FileContents_httpd_vhosts_conf As String = Functions.GetFileContents(My.Settings.FileHttpdVhostsConf)

        VirtualHostsList.Clear()
        VirtualHostsList.AddRange(Parse(FileContents_hosts, FileContents_httpd_vhosts_conf))

        Return VirtualHostsList
    End Function

    Public Function Save(Optional ByVal BackupOriginal As Boolean = False) As Boolean
        Dim FileContentsHosts As String = File.ReadAllText(My.Settings.FileHosts).Trim
        Dim FileContentsHttpdVhosts As String = File.ReadAllText(My.Settings.FileHttpdVhostsConf).Trim

        For Each VirtualHost As ClassVirtualHost In VirtualHostsList
            '
            ' Remove Virtual Host
            '
            If VirtualHost.Remove Then
                ' hosts             
                If VirtualHost.IPv4.Entry.Trim.Length > 0 Then FileContentsHosts = FileContentsHosts.Replace(VirtualHost.IPv4.Entry, "")
                If VirtualHost.IPv6.Entry.Trim.Length > 0 Then FileContentsHosts = FileContentsHosts.Replace(VirtualHost.IPv6.Entry, "")
                FileContentsHosts = RemoveExtraLines(FileContentsHosts)

                ' httpd-vhosts.conf
                For Each vHostsEntry As String In VirtualHost.VHosts.Raw
                    FileContentsHttpdVhosts = FileContentsHttpdVhosts.Replace(vHostsEntry, "")
                Next

                FileContentsHttpdVhosts = RemoveExtraLines(FileContentsHttpdVhosts)
            End If
        Next

        Functions.WriteToFile(My.Settings.FileHosts, FileContentsHosts, BackupOriginal)
        Functions.WriteToFile(My.Settings.FileHttpdVhostsConf, FileContentsHttpdVhosts, BackupOriginal)

        Return True
    End Function

    Public Function Add(ByVal VirtualHostToAdd As ClassVirtualHost)
        '
        ' Write hosts
        '
        Dim FileContentsHosts As String = File.ReadAllText(My.Settings.FileHosts).Trim
        Dim WriteLinesHosts As String() = {
            FileContentsHosts,
            String.Empty,
            VirtualHostToAdd.IPv4.Entry,
            VirtualHostToAdd.IPv6.Entry
        }

        Functions.WriteToFile(My.Settings.FileHosts, WriteLinesHosts, True)


        '
        ' Write httpd-vhosts.conf
        '
        Dim FileContentsFileHttpdVhosts As String = File.ReadAllText(My.Settings.FileHttpdVhostsConf).Trim
        Dim WriteLinesVHosts As String() = {
            FileContentsFileHttpdVhosts,
            String.Empty,
            VirtualHostToAdd.vHosts.Entry
        }

        Functions.WriteToFile(My.Settings.FileHttpdVhostsConf, WriteLinesVHosts, True)


        Return Save(False)
    End Function

    Public Function Remove(ByVal Index As Integer) As Boolean
        VirtualHostsList(Index).Remove = True

        Return Save(True)
    End Function

    Public Function Parse(ByVal FileContents_hosts As String, ByVal FileContents_httpd_vhosts_conf As String) As List(Of ClassVirtualHost)
        Dim VirtualHosts As New List(Of ClassVirtualHost)

        '
        ' Hosts
        '
        Dim ListCount As New List(Of Integer)

        ' IPv4 Address
        Dim IPv4Addresses As New List(Of String)
        IPv4Addresses.AddRange(Functions.GetRegexGroups(FileContents_hosts, "\n([0-9\.]+)", {1}))
        ListCount.Add(IPv4Addresses.Count)

        ' IPv4 Host
        Dim IPv4Hosts As New List(Of String)
        IPv4Hosts.AddRange(Functions.GetRegexGroups(FileContents_hosts, "\n[0-9\.]+\s+([a-z\.\-]+)", {1}))
        ListCount.Add(IPv4Hosts.Count)

        ' IPv6 Address
        Dim IPv6Addresses As New List(Of String)
        IPv6Addresses.AddRange(Functions.GetRegexGroups(FileContents_hosts, "\n([0-9:a-f]+)\s+", {1}))
        ListCount.Add(IPv6Addresses.Count)

        ' IPv6 Host
        Dim IPv6Hosts As New List(Of String)
        IPv6Hosts.AddRange(Functions.GetRegexGroups(FileContents_hosts, "\n[0-9:a-f]+\s+([a-z\.\-]+)", {1}))
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
                If FileContents_hosts.IndexOf(IPv4Hosts(i4)) < FileContents_hosts.IndexOf(IPv6Hosts(i6)) Then
                    VirtualHost.IPv4.Address = IPv4Addresses(i4)
                    VirtualHost.IPv4.Host = IPv4Hosts(i4)

                    IPv6Index -= 1
                Else
                    VirtualHost.IPv6.Address = IPv6Addresses(i6)
                    VirtualHost.IPv6.Host = IPv6Hosts(i6)

                    IPv4Index -= 1
                End If
            End If

            VirtualHosts.Add(VirtualHost)
        Next


        '
        ' httpd-vhosts.conf
        '
        Dim vHostsEntries As String() = Functions.GetTextBetween(FileContents_httpd_vhosts_conf, "<VirtualHost *:80>", "</VirtualHost>")
        Dim vHostsEntriesOrphans As New List(Of String)
        Dim VirtualHostsOrphans As New List(Of String)

        For Each vHostEntry As String In vHostsEntries
            Dim vHostIsOrphan As Boolean = True

            For Each VirtualHost As ClassVirtualHost In VirtualHosts
                If vHostEntry.Contains(" " & VirtualHost.Host) Then
                    VirtualHost.VHosts.Parse(vHostEntry)

                    vHostIsOrphan = False
                End If
            Next

            ' vHost Orphan
            If vHostIsOrphan Then
                Dim VirtualHost As New ClassVirtualHost
                VirtualHost.VHosts.Parse(vHostEntry)
                VirtualHost.IPv4.Host = VirtualHost.VHosts.ServerName
                VirtualHost.IPv6.Host = VirtualHost.VHosts.ServerName
                VirtualHost.Errors.Add(New Exception("No entry found in the hosts file for " & Chr(34) & VirtualHost.VHosts.ServerName & Chr(34) & "."))
                VirtualHosts.Add(VirtualHost)
            End If

        Next

        ' host Orphan
        For Each VirtualHost As ClassVirtualHost In VirtualHosts
            If VirtualHost.VHosts.Raw.Count <= 0 Then
                VirtualHost.Errors.Add(New Exception("No entry found in the httpd-vhosts.conf file for " & Chr(34) & VirtualHost.Host & Chr(34) & "."))
            End If
        Next

        Return VirtualHosts
    End Function
End Module
