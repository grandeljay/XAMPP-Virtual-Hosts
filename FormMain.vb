﻿Imports System.ComponentModel

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
        TextBoxVirtualHostEntryRaw.Text = String.Join(Environment.NewLine & Environment.NewLine, VirtualHosts.GetVirtualHosts.Item(ComboBoxVirtualHosts.SelectedIndex).VHosts.Raw).Replace(vbTab, "    ")
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
End Class
