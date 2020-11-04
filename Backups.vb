Imports System.IO

Module Backups
    ReadOnly DirectoryBackup As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\Backups"

    ReadOnly BackupsList As New List(Of ClassBackup)

    Public Sub Add(ByVal Backup As ClassBackup)
        BackupsList.Add(Backup)
    End Sub

    Public Function Item(ByVal Index As Integer) As ClassBackup
        Return BackupsList.Item(Index)
    End Function

    Public Function GetBackups(Optional ByVal UseCache As Boolean = True) As List(Of ClassBackup)
        If UseCache AndAlso BackupsList.Count > 0 Then Return BackupsList

        BackupsList.Clear()

        For Each BackupFile As String In Directory.GetFiles(DirectoryBackup, "*", SearchOption.TopDirectoryOnly)
            Dim Backup As New ClassBackup


            '
            ' Filepath & Type
            '
            If IsFile_hosts(BackupFile) Then
                Backup.Type = ClassBackup.BackupType.host
                Backup.Filepath = BackupFile
            End If

            If IsFile_httpd_vhosts_conf(BackupFile) Then
                Backup.Type = ClassBackup.BackupType.httpd_vhosts_conf
                Backup.Filepath = BackupFile
            End If


            '
            ' Date
            '
            Dim DateParts As String() = Path.GetExtension(BackupFile).TrimStart(".").Split("-")
            Dim Year, Month, Day, Hour, Minute As String

            If DateParts.Count >= 1 Then Year = DateParts.ElementAt(0) Else Year = 0
            If DateParts.Count >= 2 Then Month = DateParts.ElementAt(1) Else Month = 0
            If DateParts.Count >= 3 Then Day = DateParts.ElementAt(2) Else Day = 0
            If DateParts.Count >= 4 Then Hour = DateParts.ElementAt(3) Else Hour = 0
            If DateParts.Count >= 5 Then Minute = DateParts.ElementAt(4) Else Minute = 0

            Backup.CreatedAt = New Date(Year, Month, Day, Hour, Minute, 0)


            '
            ' Name
            '
            Backup.Name = Path.GetFileNameWithoutExtension(BackupFile) & " backup from " & Backup.CreatedAt.ToShortDateString & " at " & Backup.CreatedAt.ToShortTimeString


            Add(Backup)
        Next

        Return BackupsList
    End Function

    Public Function CreateNew(ByVal OriginalFilepath As String) As Boolean
        '
        ' Create Backup
        '
        Dim DateNow As String = Date.Now.Year & "-" & Date.Now.Month.ToString.PadLeft(2, "0") & "-" & Date.Now.Day.ToString.PadLeft(2, "0") & "-" & Date.Now.TimeOfDay.Hours.ToString.PadLeft(2, "0") & "-" & Date.Now.TimeOfDay.Minutes.ToString.PadLeft(2, "0")
        Dim BackupFilepath As String = DirectoryBackup & "\" & Path.GetFileName(OriginalFilepath) & "." & DateNow

        If Not Directory.Exists(DirectoryBackup) Then Directory.CreateDirectory(DirectoryBackup)

        File.Copy(OriginalFilepath, BackupFilepath, True)

        Return RemoveOld()
    End Function

    Private Function RemoveOld() As Boolean
        '
        ' Remove Old Backups
        '
        Dim Backups As New List(Of List(Of String))

        ' hosts
        Dim hosts As New List(Of String)
        For Each hostsFile As String In Directory.GetFiles(DirectoryBackup, "hosts.*", SearchOption.TopDirectoryOnly)
            hosts.Add(hostsFile)
        Next

        Backups.Add(hosts)

        ' httpd-vhosts.conf
        Dim httpd_vhostsConf As New List(Of String)

        For Each httpd_vhostsConfFile As String In Directory.GetFiles(DirectoryBackup, "httpd-vhosts.conf.*", SearchOption.TopDirectoryOnly)
            httpd_vhostsConf.Add(httpd_vhostsConfFile)
        Next

        Backups.Add(httpd_vhostsConf)


        '
        ' Delete Backups
        '
        For Each Backup As List(Of String) In Backups
            If Backup.Count > 10 Then
                Do
                    File.Delete(Backup(0))
                    Backup.RemoveAt(0)

                    Application.DoEvents()
                Loop Until Backup.Count <= 10
            End If
        Next

        Return True
    End Function

    Private Function IsFile_hosts(ByVal BackupFile As String) As Boolean
        Dim Name As String = Path.GetFileNameWithoutExtension(BackupFile).ToLower

        If Name = "hosts" Then Return True

        Return False
    End Function

    Private Function IsFile_httpd_vhosts_conf(ByVal BackupFile As String) As Boolean
        Dim Name As String = Path.GetFileNameWithoutExtension(BackupFile).ToLower

        If Name = "httpd-vhosts.conf" Then Return True

        Return False
    End Function
End Module
