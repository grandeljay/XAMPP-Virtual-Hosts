Imports System.IO

Public Class FormVirtualHostRestore
    ReadOnly BackupVirtualHosts As New List(Of ClassVirtualHost)

    Dim SelectedIndex As Integer
    Dim BackupsByDate As New List(Of ClassBackup)

    Private Sub FormVirtualHostRestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackupsByDate.Clear()
        BackupsByDate.AddRange(Backups.GetBackups)
        BackupsByDate.Sort(Function(x, y) y.CreatedAt.CompareTo(x.CreatedAt))

        For Each Backup As ClassBackup In BackupsByDate
            ComboBoxVirtualHosts.Items.Add(Backup.Name)
        Next

        If ComboBoxVirtualHosts.Items.Count > 0 Then ComboBoxVirtualHosts.SelectedIndex = 0
    End Sub

    Private Sub ComboBoxVirtualHosts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxVirtualHosts.SelectedIndexChanged
        SelectedIndex = ComboBoxVirtualHosts.SelectedIndex

        ButtonRestore.Enabled = SelectedIndex > -1

        If Not SelectedIndex > -1 Then Exit Sub

        Dim BackupFile As String = BackupsByDate.Item(SelectedIndex).Filepath
        Dim BackupFileContent As String = Functions.GetFileContents(BackupFile).Trim

        BackupVirtualHosts.Clear()
        BackupVirtualHosts.AddRange(VirtualHosts.Parse(BackupFileContent, BackupFileContent))

        '
        ' Preview Selection
        '
        TextBox_hosts.Text = Functions.GetFileContents(BackupFile)
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonRestore_Click(sender As Object, e As EventArgs) Handles ButtonRestore.Click
        Dim OverwriteExistingFile As DialogResult = MessageBox.Show("This will overwrite your current " & BackupsByDate.Item(SelectedIndex).Type.ToString & " file." & Environment.NewLine & Environment.NewLine & "Would you like to continue?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        Dim Result As Boolean

        If OverwriteExistingFile = DialogResult.Yes Then
            Select Case BackupsByDate(SelectedIndex).Type
                Case ClassBackup.BackupType.host
                    Result = Functions.WriteToFile(My.Settings.FileHosts, TextBox_hosts.Text)

                Case ClassBackup.BackupType.httpd_vhosts_conf
                    Result = Functions.WriteToFile(My.Settings.FileHttpdVhostsConf, TextBox_hosts.Text)
            End Select
        End If

        If Result Then MessageBox.Show("Your " & BackupsByDate.Item(SelectedIndex).Type.ToString & " file has been successfully restored.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class