Public Class FormVirtualHostEdit
    Dim VirtualHost As ClassVirtualHost

    Private Sub FormVirtualHostEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VirtualHost = VirtualHosts.GetVirtualHosts()(VirtualHosts.SelectedIndex)
    End Sub

    Private Sub FormVirtualHostEdit_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' General
        TextBoxGeneralDomain.Text = VirtualHost.Host
        TextBoxGeneralDocumentRoot.Text = VirtualHost.VHosts.DocumentRoot

        For Each DirectoryPHP As String In System.IO.Directory.GetDirectories(My.Settings.DirectoryXAMPP, "*", IO.SearchOption.TopDirectoryOnly)
            Dim NewsTXT As String = DirectoryPHP & "\news.txt"

            If System.IO.File.Exists(NewsTXT) Then
                ComboBoxPHPVersion.Items.Add(System.IO.Path.GetFileName(DirectoryPHP)) 'Regex.GetGroup(Functions.GetFileContents(NewsTXT), "PHP [\d\.]+")
            End If
        Next

        If VirtualHost.VHosts.PHP Then
            ComboBoxPHPVersion.SelectedItem = VirtualHost.VHosts.PHPVersionFolderName
        Else
            ComboBoxPHPVersion.SelectedItem = "php"
        End If

        ' hosts
        TextBoxIPv4Address.Text = VirtualHost.IPv4.Address
        TextBoxIPv4Host.Text = VirtualHost.IPv4.Host
        TextBoxIPv6Address.Text = VirtualHost.IPv6.Address
        TextBoxIPv6Host.Text = VirtualHost.IPv6.Host

        ' vhosts
        CheckBoxSSL.Checked = VirtualHost.VHosts.SSL

        TextBoxDocumentRoot.Text = VirtualHost.VHosts.DocumentRoot
        TextBoxPort.Text = VirtualHost.VHosts.Port
        TextBoxPortSSL.Text = VirtualHost.VHosts.PortSSL

        TextBoxCertificate.Text = VirtualHost.VHosts.Certificate
        TextBoxCertificateKey.Text = VirtualHost.VHosts.CertificateKey
    End Sub
    Private Sub TextBoxGeneralDomain_TextChanged(sender As Object, e As EventArgs) Handles TextBoxGeneralDomain.TextChanged
        TextBoxIPv4Host.Text = TextBoxGeneralDomain.Text
        TextBoxIPv6Host.Text = TextBoxGeneralDomain.Text

        Preview()
    End Sub

    Private Sub TextBoxGeneralDocumentRoot_TextChanged(sender As Object, e As EventArgs) Handles TextBoxGeneralDocumentRoot.TextChanged
        TextBoxDocumentRoot.Text = TextBoxGeneralDocumentRoot.Text

        Preview()
    End Sub

    Private Sub ComboBoxPHPVersion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPHPVersion.SelectedIndexChanged
        If VirtualHost Is Nothing Then Exit Sub

        If ComboBoxPHPVersion.SelectedItem = "php" Then
            VirtualHost.VHosts.PHPVersionFolderName = ""
        Else
            VirtualHost.VHosts.PHPVersionFolderName = ComboBoxPHPVersion.SelectedItem
        End If

        Preview()
    End Sub

    Private Sub CheckBoxSSL_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSSL.CheckedChanged
        If VirtualHost Is Nothing Then Exit Sub

        GroupBoxSSL_httpd_vhosts_conf.Visible = CheckBoxSSL.Checked
        VirtualHost.VHosts.SSL = CheckBoxSSL.Checked

        Preview()
    End Sub

    Private Sub Preview()
        If VirtualHost Is Nothing Then Exit Sub

        TextBoxPreview.Text = VirtualHost.VHosts.Entry
    End Sub

    Private Sub TextBoxIPv4Address_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIPv4Address.TextChanged
        If VirtualHost Is Nothing Then Exit Sub

        VirtualHost.IPv4.Address = TextBoxIPv4Address.Text

        Preview()
    End Sub

    Private Sub TextBoxIPv4Host_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIPv4Host.TextChanged
        If VirtualHost Is Nothing Then Exit Sub

        VirtualHost.IPv4.Host = TextBoxIPv4Host.Text

        Preview()
    End Sub

    Private Sub TextBoxIPv6Address_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIPv6Address.TextChanged
        If VirtualHost Is Nothing Then Exit Sub

        VirtualHost.IPv6.Address = TextBoxIPv6Address.Text

        Preview()
    End Sub

    Private Sub TextBoxIPv6Host_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIPv6Host.TextChanged
        If VirtualHost Is Nothing Then Exit Sub

        VirtualHost.IPv6.Host = TextBoxIPv6Host.Text

        Preview()
    End Sub

    Private Sub TextBoxPort_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPort.TextChanged
        If VirtualHost Is Nothing Then Exit Sub

        VirtualHost.VHosts.Port = TextBoxPort.Text

        Preview()
    End Sub

    Private Sub TextBoxDocumentRoot_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDocumentRoot.TextChanged
        If VirtualHost Is Nothing Then Exit Sub

        VirtualHost.VHosts.DocumentRoot = TextBoxDocumentRoot.Text

        Preview()
    End Sub

    Private Sub TextBoxSSLPort_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPortSSL.TextChanged
        If VirtualHost Is Nothing Then Exit Sub

        VirtualHost.VHosts.PortSSL = TextBoxPortSSL.Text

        Preview()
    End Sub

    Private Sub TextBoxCertificate_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCertificate.TextChanged
        If VirtualHost Is Nothing Then Exit Sub

        VirtualHost.VHosts.Certificate = TextBoxCertificate.Text

        Preview()
    End Sub

    Private Sub TextBoxCertificateKey_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCertificateKey.TextChanged
        If VirtualHost Is Nothing Then Exit Sub

        VirtualHost.VHosts.CertificateKey = TextBoxCertificateKey.Text

        Preview()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        'TextBoxGeneralDomain_TextChanged(sender, e)
        'TextBoxGeneralDocumentRoot_TextChanged(sender, e)


        VirtualHost.Action = ClassVirtualHost.EnumAction.Update
        VirtualHosts.Save()

        '
        ' Reload
        '
        FormVirtualHostEdit_Load(sender, e)

        Me.Close()
    End Sub
End Class