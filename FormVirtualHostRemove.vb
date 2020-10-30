Public Class FormVirtualHostRemove
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub FormVirtualHostDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Add Virtual Hosts
        '
        For Each VirtualHost As ClassVirtualHost In VirtualHosts.List
            ComboBoxVirtualHosts.Items.Add(VirtualHost.Host)
        Next


        '
        ' Select the same as in FormMain
        ' Fallback to first item or none
        '
        If FormMain.ComboBoxVirtualHosts.SelectedIndex > -1 Then
            ComboBoxVirtualHosts.SelectedIndex = FormMain.ComboBoxVirtualHosts.SelectedIndex
        ElseIf ComboBoxVirtualHosts.Items.Count > 0 Then
            ComboBoxVirtualHosts.SelectedIndex = 0
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim Index As Integer = ComboBoxVirtualHosts.SelectedIndex
        Dim RemoveVirtualHost As ClassVirtualHost = Functions.getVirtualHosts().Item(Index)

        If VirtualHosts.Remove(Index) Then
            'MessageBox.Show("Virtual Host " & Chr(34) & RemoveVirtualHost.Host & Chr(34) & " removed successfully!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class