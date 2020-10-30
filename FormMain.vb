Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Get Existing Virtual Hosts
        '
        VirtualHosts.List.Clear()
        VirtualHosts.List.AddRange(Functions.getVirtualHosts)


        '
        ' Show Virtual Hosts in Form
        '
        ComboBoxVirtualHosts.Items.Clear()

        For Each VirtualHost As ClassVirtualHost In VirtualHosts.List
            ComboBoxVirtualHosts.Items.Add(VirtualHost.Host)
        Next

        If ComboBoxVirtualHosts.Items.Count > 0 Then ComboBoxVirtualHosts.SelectedIndex = 0
    End Sub

    Private Sub ComboBoxVirtualHosts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxVirtualHosts.SelectedIndexChanged
        TextBoxVirtualHostEntryRaw.Text = String.Join(Environment.NewLine & Environment.NewLine, VirtualHosts.List(ComboBoxVirtualHosts.SelectedIndex).vHosts.Raw).Replace(vbTab, "    ")
    End Sub

    Private Sub ButtonAddNewVirtualHost_Click(sender As Object, e As EventArgs) Handles ButtonAddVirtualHost.Click
        If FormVirtualHostAdd.ShowDialog() Then
            FormMain_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub ButtonRemoveVirtualHost_Click(sender As Object, e As EventArgs) Handles ButtonRemoveVirtualHost.Click
        If FormVirtualHostRemove.ShowDialog() Then
            FormMain_Load(Nothing, Nothing)
        End If
    End Sub
End Class
