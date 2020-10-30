Public Class FormVirtualHostAdd
    Private Sub FormVirtualHostAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim NewVirtualHost As New ClassVirtualHost

        NewVirtualHost.IPv4.Address = "127.0.0.1"
        NewVirtualHost.IPv4.Host = TextBoxHostName.Text
        NewVirtualHost.IPv6.Address = "::1"
        NewVirtualHost.IPv6.Host = TextBoxHostName.Text
        NewVirtualHost.vHosts.DocumentRoot = TextBoxAbsolutePath.Text
        NewVirtualHost.vHosts.ServerName = TextBoxHostName.Text

        If VirtualHosts.Add(NewVirtualHost) Then
            'MessageBox.Show("Virtual Host " & Chr(34) & NewVirtualHost.Host & Chr(34) & " created successfully!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class