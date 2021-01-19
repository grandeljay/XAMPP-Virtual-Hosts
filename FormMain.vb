Imports System.ComponentModel
Imports System.IO

Public Class FormMain
    Public IgnoreUpdate As Boolean = False

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NewestVersion As Version = Version.Parse(Functions.GetNewestVersion)
        Dim CurrentVersion As Version = Version.Parse(Application.ProductVersion)

        If NewestVersion > CurrentVersion AndAlso Not IgnoreUpdate Then
            FormUpdater.Show()
            Me.Close()
        End If

        LabelVersion.Text = "Version " & Application.ProductVersion
    End Sub

    Public Sub FormMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        '
        ' Debug
        '
        My.Settings.Reset()


        '
        ' Determine Hosts and httpd-vhosts.conf files
        '
        BackgroundOperation.SetHosts.Run()
        BackgroundOperation.SetXAMPP.Run()
        BackgroundOperation.SetHttpdVhostsConf.Run()


        '
        ' Show Virtual Hosts in Form
        '
        ComboBoxVirtualHosts.Items.Clear()

        For Each VirtualHost As ClassVirtualHost In VirtualHosts.GetVirtualHosts(False)
            ComboBoxVirtualHosts.Items.Add(VirtualHost.Host)
        Next

        If ComboBoxVirtualHosts.Items.Count > 0 Then ComboBoxVirtualHosts.SelectedIndex = 0
    End Sub

    Private Sub ComboBoxVirtualHosts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxVirtualHosts.SelectedIndexChanged
        '
        ' Selection
        '
        Dim ValidSelection As Boolean = ComboBoxVirtualHosts.SelectedIndex > -1

        ButtonVirtualHostEdit.Enabled = ValidSelection

        If ValidSelection Then VirtualHosts.SelectedIndex = ComboBoxVirtualHosts.SelectedIndex

        Dim VirtualHostSelection As ClassVirtualHost = VirtualHosts.GetVirtualHosts.Item(VirtualHosts.SelectedIndex)


        '
        ' httpd-vhosts.conf Preview
        '
        TextBoxVirtualHostEntryRaw.Text = String.Join(Environment.NewLine & Environment.NewLine, VirtualHostSelection.VHosts.Raw).Replace(vbTab, "    ")


        '
        ' Status
        '        
        If VirtualHostSelection.Errors.Count > 0 Then
            LinkLabelStatus.Text = VirtualHostSelection.Errors.First.Message

            If LinkLabelStatus.Text.Contains(VirtualHosts.Hosts) Then
                Dim LinkStart As Integer = LinkLabelStatus.Text.IndexOf(VirtualHosts.Hosts)
                LinkLabelStatus.LinkArea = New LinkArea(LinkStart, VirtualHosts.Hosts.Length)
            End If

            If LinkLabelStatus.Text.Contains(VirtualHosts.HttpdVhostsConf) Then
                Dim LinkStart As Integer = LinkLabelStatus.Text.IndexOf(VirtualHosts.HttpdVhostsConf)
                LinkLabelStatus.LinkArea = New LinkArea(LinkStart, VirtualHosts.HttpdVhostsConf.Length)
            End If
        Else
            LinkLabelStatus.Text = "No issues found for " & Chr(34) & VirtualHostSelection.Host & Chr(34) & "."

            Dim LinkStart As Integer = LinkLabelStatus.Text.IndexOf(VirtualHostSelection.Host)
            LinkLabelStatus.LinkArea = New LinkArea(LinkStart, VirtualHostSelection.Host.Length)
        End If
    End Sub

    Private Sub ButtonAddNewVirtualHost_Click(sender As Object, e As EventArgs) Handles ButtonVirtualHostAdd.Click
        If FormVirtualHostAdd.ShowDialog() Then
            FormMain_Shown(sender, e)
        End If
    End Sub

    Private Sub ButtonRemoveVirtualHost_Click(sender As Object, e As EventArgs) Handles ButtonVirtualHostRemove.Click
        If FormVirtualHostRemove.ShowDialog() Then
            FormMain_Shown(sender, e)
        End If
    End Sub

    Private Sub SpecifyPathsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpecifyPathsToolStripMenuItem.Click
        If FormPathsSpecify.ShowDialog() Then
            FormMain_Shown(sender, e)
        End If
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        ButtonAddNewVirtualHost_Click(sender, e)
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        ButtonVirtualHostEdit_Click(sender, e)
    End Sub

    Private Sub RemoveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem1.Click
        ButtonRemoveVirtualHost_Click(sender, e)
    End Sub

    Private Sub ButtonReload_Click(sender As Object, e As EventArgs) Handles ButtonReload.Click
        FormMain_Shown(sender, e)
    End Sub
    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        ButtonVirtualHostRestore_Click(sender, e)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FormAbout.Show()
    End Sub

    Private Sub ButtonVirtualHostRestore_Click(sender As Object, e As EventArgs) Handles ButtonVirtualHostRestore.Click
        FormVirtualHostRestore.Show()
    End Sub

    Private Sub LinkLabelStatus_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelStatus.LinkClicked
        Dim LinkedText As String = LinkLabelStatus.Text.Substring(LinkLabelStatus.LinkArea.Start, LinkLabelStatus.LinkArea.Length)

        Select Case LinkedText
            Case VirtualHosts.Hosts : Process.Start(My.Settings.FileHosts)
            Case VirtualHosts.HttpdVhostsConf : Process.Start(My.Settings.FileHttpdVhostsConf)
            Case Else
                '
                ' To do: determine if host is using SSL or not
                '
                If LinkedText.Trim.Length > 0 Then Process.Start("http://" & LinkedText)
        End Select
    End Sub

    Private Sub HostsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HostsToolStripMenuItem.Click
        If File.Exists(My.Settings.FileHosts) Then Process.Start(My.Settings.FileHosts)

    End Sub

    Private Sub HttpdvhostsvonfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HttpdvhostsvonfToolStripMenuItem.Click
        If File.Exists(My.Settings.FileHttpdVhostsConf) Then Process.Start(My.Settings.FileHttpdVhostsConf)
    End Sub

    Private Sub HtdocsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HtdocsToolStripMenuItem.Click
        Dim htdocs As String = My.Settings.DirectoryXAMPP.TrimEnd("\") & "\htdocs"

        If Directory.Exists(htdocs) Then Process.Start(htdocs)
    End Sub

    Private Sub ButtonVirtualHostEdit_Click(sender As Object, e As EventArgs) Handles ButtonVirtualHostEdit.Click
        FormVirtualHostEdit.Show()
    End Sub

    Private Sub ImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem.Click
        FormDatabaseImport.Show()
    End Sub
End Class
