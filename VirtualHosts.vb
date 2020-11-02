Imports System.IO

Module VirtualHosts
    Public Const Hosts As String = "hosts"
    Public Const HttpdVhostsConf As String = "httpd-vhosts.conf"

    Public Property List As New List(Of ClassVirtualHost)

    Public Function Save() As Boolean
        Dim FileContentsHosts As String = File.ReadAllText(My.Settings.FileHosts).Trim
        Dim FileContentsHttpdVhosts As String = File.ReadAllText(My.Settings.FileHttpdVhostsConf).Trim

        For Each VirtualHost As ClassVirtualHost In List
            '
            ' Remove Virtual Host
            '
            If VirtualHost.Remove Then
                ' hosts             
                FileContentsHosts = FileContentsHosts.Replace(VirtualHost.IPv4.Entry, "")
                FileContentsHosts = FileContentsHosts.Replace(VirtualHost.IPv6.Entry, "")
                FileContentsHosts = removeExtraLines(FileContentsHosts)

                ' httpd-vhosts.conf
                For Each vHostsEntry As String In VirtualHost.vHosts.Raw
                    FileContentsHttpdVhosts = FileContentsHttpdVhosts.Replace(vHostsEntry, "")
                Next

                FileContentsHttpdVhosts = removeExtraLines(FileContentsHttpdVhosts)
            End If
        Next

        Functions.WriteToFile(My.Settings.FileHosts, FileContentsHosts, True)
        Functions.WriteToFile(My.Settings.FileHttpdVhostsConf, FileContentsHttpdVhosts, True)

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


        Return Save()
    End Function

    Public Function Remove(ByVal Index As Integer) As Boolean
        List(Index).Remove = True

        Return Save()
    End Function
End Module
