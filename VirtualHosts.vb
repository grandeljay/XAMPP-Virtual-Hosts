﻿Imports System.IO
Imports System.Text

Module VirtualHosts
    Public Const Hosts As String = "hosts"
    Public Const XAMPP As String = "XAMPP"
    Public Const HttpdVhostsConf As String = "httpd-vhosts.conf"

    Private Const GitHubRepoLink As String = "https://github.com/grandeljay/XAMPP-Virtual-Hosts"

    Dim LocalhostExistsAsked As Boolean = False

    Private ReadOnly Property HeaderApplication() As String
        Get
            Dim Year As String = Date.Now.Year
            Dim Month As String = Date.Now.Month.ToString.PadLeft(2, "0")
            Dim Day As String = Date.Now.Day.ToString.PadLeft(2, "0")
            Dim Hour As String = Date.Now.Hour.ToString.PadLeft(2, "0")
            Dim Minute As String = Date.Now.Minute.ToString.PadLeft(2, "0")

            Dim Header As New StringBuilder(Environment.NewLine & Environment.NewLine)
            Header.AppendLine("# This file was generated by " & Application.ProductName & " on " & Year & "-" & Month & "-" & Day & " at " & Hour & ":" & Minute)
            Header.AppendLine("# " & GitHubRepoLink)
            Header.AppendLine("#")
            Header.AppendLine("# Backups can be found under: " & Backups.DirectoryBackup)

            Return Header.ToString
        End Get
    End Property

    Public ReadOnly Property HeaderHosts() As String
        Get
            Return My.Resources.FileHostsHeader & HeaderApplication
        End Get
    End Property

    Public ReadOnly Property HeaderHttpdVHostsConf() As String
        Get
            Return My.Resources.FileHttpdVHostsConfHeader & HeaderApplication
        End Get
    End Property

    Public Property SelectedIndex As Integer

    Private Property VirtualHostsList As New List(Of ClassVirtualHost)

    Public Function GetVirtualHosts(Optional ByVal UseCache As Boolean = True) As List(Of ClassVirtualHost)
        If UseCache AndAlso VirtualHostsList.Count > 0 Then Return VirtualHostsList

        Dim FileContents_hosts As String = Functions.GetFileContents(My.Settings.FileHosts)
        Dim FileContents_httpd_vhosts_conf As String = Functions.GetFileContents(My.Settings.FileHttpdVhostsConf)

        VirtualHostsList.Clear()
        VirtualHostsList.AddRange(Parse(FileContents_hosts, FileContents_httpd_vhosts_conf))

        '
        ' Add Default (localhost)
        '
        Dim LocalhostExists As Boolean = False

        For Each VirtualHost As ClassVirtualHost In VirtualHostsList
            If VirtualHost.Host.ToLower = "localhost" Then
                LocalhostExists = True
            End If
        Next

        If Not LocalhostExists AndAlso Not LocalhostExistsAsked Then
            Dim DialogDefaultEntryMissing As DialogResult = MessageBox.Show("It seems you are missing a default entry for localhost in your hosts and httpd-vhost.conf. Not having one, may result in your virtual hosts not working." & vbNewLine & vbNewLine & "Would you like me to create it for you?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            LocalhostExistsAsked = True

            If DialogDefaultEntryMissing = DialogResult.Yes Then
                Dim VirtualHostLocalhost As New ClassVirtualHost
                With VirtualHostLocalhost
                    .IPv4.Host = "localhost"
                    .IPv6.Host = "localhost"
                    .IPv4.Address = "127.0.0.1"
                    .IPv6.Address = "::1"
                    .VHosts.DocumentRoot = My.Settings.DirectoryXAMPP & "\htdocs"
                    .VHosts.ServerName = "localhost"
                    .VHosts.Raw.Add(.VHosts.Entry)
                End With

                VirtualHostsList.Insert(0, VirtualHostLocalhost)

                Save()
            End If
        End If

        Return VirtualHostsList
    End Function

    Public Function Add(ByVal VirtualHostToAdd As ClassVirtualHost)
        VirtualHostToAdd.Action = ClassVirtualHost.EnumAction.Add

        VirtualHostsList.Add(VirtualHostToAdd)

        Return Save()
    End Function

    Public Function Save() As Boolean
        Dim FileContentsHostsOld As String = File.ReadAllText(My.Settings.FileHosts).Trim
        Dim FileContentsHostsNew As String = HeaderHosts.Trim & Environment.NewLine & Environment.NewLine
        Dim FileContentsHttpdVhostsOld As String = File.ReadAllText(My.Settings.FileHttpdVhostsConf).Trim
        Dim FileContentsHttpdVhostsNew As String = HeaderHttpdVHostsConf.Trim & Environment.NewLine & Environment.NewLine

        For Each VirtualHost As ClassVirtualHost In VirtualHostsList
            '
            ' Add / Remove / Update
            '
            If Not VirtualHost.Action = ClassVirtualHost.EnumAction.Remove Then
                If VirtualHost.Entry.Trim.Length > 0 Then FileContentsHostsNew &= VirtualHost.Entry & Environment.NewLine & Environment.NewLine
                If VirtualHost.VHosts.Entry.Trim.Length > 0 Then FileContentsHttpdVhostsNew &= VirtualHost.VHosts.Entry & Environment.NewLine & Environment.NewLine
            End If
        Next

        '
        ' First Save?
        '
        Dim WriteToFile As Boolean = False

        If Not FileContentsHostsOld.Contains(GitHubRepoLink) Or Not FileContentsHttpdVhostsOld.Contains(GitHubRepoLink) Then
            Dim DialogFirstSave As DialogResult = MessageBox.Show("During the saving process a new hosts and httpd-vhosts.conf will be generated. Temporary backups (up to 10 different versions) will be made but make sure nothing essential is missing and that everything is working!" & vbNewLine & vbNewLine & "Proceed saving and generating a new hosts and httpd-vhosts.conf?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If DialogFirstSave = DialogResult.Yes Then
                WriteToFile = True
            End If
        Else
            WriteToFile = True
        End If


        '
        ' Write to File
        '
        If WriteToFile Then
            Functions.WriteToFile(My.Settings.FileHosts, FileContentsHostsNew.Trim, True)
            Functions.WriteToFile(My.Settings.FileHttpdVhostsConf, FileContentsHttpdVhostsNew.Trim, True)
        End If


        '
        ' Reload
        '
        GetVirtualHosts(False)

        Return True
    End Function

    Private Function AddToFileHosts(ByVal VirtualHost As ClassVirtualHost, ByVal FileContentsHosts As String) As String
        Dim WriteLinesHosts As String() = {
            FileContentsHosts,
            String.Empty,
            VirtualHost.IPv4.Entry,
            VirtualHost.IPv6.Entry
        }

        Return String.Join(Environment.NewLine, WriteLinesHosts)
    End Function

    Private Function AddToFileHttpdfVHostsConf(ByVal VirtualHost As ClassVirtualHost, ByVal FileContentsHttpdVhosts As String) As String
        Dim WriteLinesVHosts As String() = {
            FileContentsHttpdVhosts,
            String.Empty,
            VirtualHost.VHosts.Entry
        }

        Return String.Join(Environment.NewLine, WriteLinesVHosts)
    End Function

    Private Function RemoveFromFileHosts(ByVal VirtualHost As ClassVirtualHost, ByVal FileContentsHosts As String) As String
        If VirtualHost.IPv4.Entry.Trim.Length > 0 Then FileContentsHosts = Regex.Replace(FileContentsHosts, "\n" & VirtualHost.IPv4.Entry, String.Empty)
        If VirtualHost.IPv6.Entry.Trim.Length > 0 Then FileContentsHosts = Regex.Replace(FileContentsHosts, "\n" & VirtualHost.IPv6.Entry, String.Empty)
        FileContentsHosts = RemoveExtraLines(FileContentsHosts)

        Return FileContentsHosts
    End Function

    Private Function RemoveFromFileHttpdfVHostsConf(ByVal VirtualHost As ClassVirtualHost, ByVal FileContentsHttpdVhosts As String) As String
        For Each vHostsEntry As String In VirtualHost.VHosts.Raw
            FileContentsHttpdVhosts = FileContentsHttpdVhosts.Replace(vHostsEntry, "")
        Next
        FileContentsHttpdVhosts = RemoveExtraLines(FileContentsHttpdVhosts)

        Return FileContentsHttpdVhosts
    End Function

    Public Function Remove(ByVal Index As Integer) As Boolean
        'VirtualHostsList(Index).Action = ClassVirtualHost.EnumAction.Remove = True
        VirtualHostsList.RemoveAt(Index)

        Return Save()
    End Function

    Public Function Parse(ByVal FileContents_hosts As String, ByVal FileContents_httpd_vhosts_conf As String) As List(Of ClassVirtualHost)
        Dim VirtualHostsList As New List(Of ClassVirtualHost)

        '
        ' Hosts
        '
        Dim ListCount As New List(Of Integer)

        ' IPv4 Address
        Dim IPv4Addresses As New List(Of String)
        IPv4Addresses.AddRange(Regex.GetGroups(FileContents_hosts, "\n([0-9\.]+)", {1}))
        ListCount.Add(IPv4Addresses.Count)

        ' IPv4 Host
        Dim IPv4Hosts As New List(Of String)
        IPv4Hosts.AddRange(Regex.GetGroups(FileContents_hosts, "\n[0-9\.]+\s+([0-9a-z\.\-]+)", {1}))
        ListCount.Add(IPv4Hosts.Count)

        ' IPv6 Address
        Dim IPv6Addresses As New List(Of String)
        IPv6Addresses.AddRange(Regex.GetGroups(FileContents_hosts, "\n([0-9:a-f]+)\s+", {1}))
        ListCount.Add(IPv6Addresses.Count)

        ' IPv6 Host
        Dim IPv6Hosts As New List(Of String)
        IPv6Hosts.AddRange(Regex.GetGroups(FileContents_hosts, "\n[0-9:a-f]+\s+([0-9a-z\.\-]+)", {1}))
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

            If IPv4Hosts.Count > i4 Then
                VirtualHost.IPv4.Address = IPv4Addresses(i4)
                VirtualHost.IPv4.Host = IPv4Hosts(i4)
            End If

            If IPv6Hosts.Count > i6 Then
                If IPv4Hosts(i4) = IPv6Hosts(i6) Then
                    VirtualHost.IPv6.Address = IPv6Addresses(i6)
                    VirtualHost.IPv6.Host = IPv6Hosts(i6)
                Else
                    IPv6Index -= 1
                End If
            End If

            VirtualHostsList.Add(VirtualHost)
        Next


        '
        ' httpd-vhosts.conf
        '
        Dim vHostsEntries As String() = Functions.GetTextBetween(FileContents_httpd_vhosts_conf, "<VirtualHost", "</VirtualHost>")
        Dim vHostsEntriesOrphans As New List(Of String)
        Dim VirtualHostsOrphans As New List(Of String)

        For Each vHostEntry As String In vHostsEntries
            Dim vHostIsOrphan As Boolean = True

            For Each VirtualHost As ClassVirtualHost In VirtualHostsList
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
                VirtualHost.Errors.Add(New Exception("No entry found in the " & VirtualHosts.Hosts & " file for " & Chr(34) & VirtualHost.VHosts.ServerName & Chr(34) & "."))
                VirtualHostsList.Add(VirtualHost)
            End If

        Next

        ' host Orphan
        For Each VirtualHost As ClassVirtualHost In VirtualHostsList
            If VirtualHost.VHosts.Raw.Count <= 0 Then
                VirtualHost.Errors.Add(New Exception("No entry found in the " & VirtualHosts.HttpdVhostsConf & " file for " & Chr(34) & VirtualHost.Host & Chr(34) & "."))
            End If
        Next

        Return VirtualHostsList
    End Function
End Module
