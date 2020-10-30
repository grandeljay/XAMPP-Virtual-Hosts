Public Class FormMain
    Dim VirtualHosts As New List(Of ClassVirtualHost)

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Get Existing Virtual Hosts
        '
        VirtualHosts.AddRange(Functions.getVirtualHosts)


        '
        ' Show Virtual Hosts in Form
        '
        For Each VirtualHost As ClassVirtualHost In VirtualHosts
            ComboBoxVirtualHosts.Items.Add(VirtualHost.Host)
        Next

        If ComboBoxVirtualHosts.Items.Count > 0 Then ComboBoxVirtualHosts.SelectedIndex = 0
    End Sub

    Private Sub ComboBoxVirtualHosts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxVirtualHosts.SelectedIndexChanged
        TextBoxVirtualHostEntryRaw.Text = VirtualHosts(ComboBoxVirtualHosts.SelectedIndex).vHosts.Raw.Replace(vbTab, "    ")
    End Sub

    Private Sub ButtonAddNewVirtualHost_Click(sender As Object, e As EventArgs) Handles ButtonAddNewVirtualHost.Click
        FormVirtualHostNew.Show()
    End Sub
End Class
