Public Class FormMain
    Dim VirtualHosts As New List(Of ClassVirtualHost)

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VirtualHosts.AddRange(Functions.getVirtualHosts)

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
