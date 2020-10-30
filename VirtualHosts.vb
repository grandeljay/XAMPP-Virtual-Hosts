Imports System.IO

Module VirtualHosts
    Public Const FileHosts As String = "C:\Windows\System32\drivers\etc\hosts"
    Public Const FileHttpdVhosts As String = "D:\XAMPP\apache\conf\extra\httpd-vhosts.conf"

    Public Sub Save()
        For Each VirtualHost As ClassVirtualHost In Functions.getVirtualHosts()

        Next
    End Sub

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

        File.WriteAllLines(FileHosts, WriteLinesHosts)


        '
        ' Write httpd-vhosts.conf
        '
        Dim FileContentsFileHttpdVhosts As String = File.ReadAllText(FileHttpdVhosts).Trim
        Dim WriteLinesVHosts As String() = {
            FileContentsFileHttpdVhosts,
            String.Empty,
            VirtualHostToAdd.vHosts.Entry
        }

        File.WriteAllLines(FileHttpdVhosts, WriteLinesVHosts)


        Return True
    End Function
End Module
