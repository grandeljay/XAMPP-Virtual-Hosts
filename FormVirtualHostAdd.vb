Imports System.IO

Public Class FormVirtualHostAdd
    Private Sub FormVirtualHostAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Directory.Exists(My.Settings.DirectoryXAMPP & "\htdocs") Then TextBoxAbsolutePath.Text = My.Settings.DirectoryXAMPP & "\"

        TextBoxHostName_TextChanged(sender, e)
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        '
        ' Create Specified Directory
        ' If it does not exist
        '
        If Not Directory.Exists(TextBoxAbsolutePath.Text) Then
            Dim CreateDirectory As DialogResult = MessageBox.Show("The directory " & Chr(34) & TextBoxAbsolutePath.Text & Chr(34) & " does not exist." & Environment.NewLine & Environment.NewLine & "Would you like to create it?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If CreateDirectory = DialogResult.Yes Then Directory.CreateDirectory(TextBoxAbsolutePath.Text)
        End If


        '
        ' Add New Virtual Host
        '
        Dim NewVirtualHost As New ClassVirtualHost
        NewVirtualHost.IPv4.Address = "127.0.0.1"
        NewVirtualHost.IPv4.Host = TextBoxHostName.Text
        NewVirtualHost.IPv6.Address = "::1"
        NewVirtualHost.IPv6.Host = TextBoxHostName.Text
        NewVirtualHost.VHosts.DocumentRoot = TextBoxAbsolutePath.Text
        NewVirtualHost.VHosts.ServerName = TextBoxHostName.Text


        '
        ' Close on Success
        '
        If VirtualHosts.Add(NewVirtualHost) Then
            MessageBox.Show("Virtual Host " & Chr(34) & NewVirtualHost.Host & Chr(34) & " created successfully! You need to restart Apache for the changes to take effect.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub TextBoxHostName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxHostName.TextChanged
        TextBoxAbsolutePath.Text = My.Settings.DirectoryXAMPP & "\htdocs\" & Functions.SanitiseDomain(TextBoxHostName.Text)
    End Sub
End Class