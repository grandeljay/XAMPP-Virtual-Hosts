Imports System.IO

Module VirtualHosts
    Public Property List As New List(Of ClassVirtualHost)

    Public Const FileHosts As String = "C:\Windows\System32\drivers\etc\hosts"
    Public Const FileHttpdVhosts As String = "D:\XAMPP\apache\conf\extra\httpd-vhosts.conf"

    Public Function Save() As Boolean
        Dim FileContentsHosts As String = File.ReadAllText(FileHosts).Trim
        Dim FileContentsHttpdVhosts As String = File.ReadAllText(FileHttpdVhosts).Trim

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

        Functions.WriteToFile(FileHosts, FileContentsHosts, True)
        Functions.WriteToFile(FileHttpdVhosts, FileContentsHttpdVhosts, True)

        Return True
    End Function

    Public Function Add(ByVal VirtualHostToAdd As ClassVirtualHost)
        '
        ' Write hosts
        '
        Dim FileContentsHosts As String = File.ReadAllText(FileHosts).Trim
        Dim WriteLinesHosts As String() = {
            FileContentsHosts,
            String.Empty,
            VirtualHostToAdd.IPv4.Entry,
            VirtualHostToAdd.IPv6.Entry
        }

        Functions.WriteToFile(FileHosts, WriteLinesHosts, True)


        '
        ' Write httpd-vhosts.conf
        '
        Dim FileContentsFileHttpdVhosts As String = File.ReadAllText(FileHttpdVhosts).Trim
        Dim WriteLinesVHosts As String() = {
            FileContentsFileHttpdVhosts,
            String.Empty,
            VirtualHostToAdd.vHosts.Entry
        }

        Functions.WriteToFile(FileHttpdVhosts, WriteLinesVHosts, True)


        Return Save()
    End Function

    Public Function Remove(ByVal Index As Integer) As Boolean
        List(Index).Remove = True

        Return Save()
    End Function
End Module
