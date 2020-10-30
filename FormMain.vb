Public Class FormMain
    Const FileHosts As String = "C:\Windows\System32\drivers\etc\hosts"
    Const FileHttpdVhosts As String = "D:\XAMPP\apache\conf\extra\httpd-vhosts.conf"

    Dim VirtualHosts As New List(Of ClassVirtualHost)

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Hosts
        '
        Dim FileHostsContents As String = Functions.getFileContents(FileHosts)

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

            VirtualHosts.Add(VirtualHost)
        Next


        '
        ' Virtual Hosts
        '
        Dim FileHttpdVhostsContents As String = Functions.getFileContents(FileHttpdVhosts)

        Dim vHostsEntries As String() = Functions.getTextBetween(FileHttpdVhostsContents, "<VirtualHost *:80>", "</VirtualHost>")

        For Each vHostEntry As String In vHostsEntries
            For Each VirtualHost As ClassVirtualHost In VirtualHosts
                If vHostEntry.Contains(" " & VirtualHost.Host) Then
                    VirtualHost.vHostsEntry.Raw = vHostEntry
                End If
            Next
        Next


        '
        ' Show Virtual Hosts in Form
        '
        For Each VirtualHost As ClassVirtualHost In VirtualHosts
            ComboBox1.Items.Add(VirtualHost.Host)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = VirtualHosts(ComboBox1.SelectedIndex).vHostsEntry.Raw
    End Sub
End Class
