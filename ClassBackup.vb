Public Class ClassBackup
    Enum BackupType
        host
        httpd_vhosts_conf
    End Enum

    Property Filepath As String
    Property Name As String
    Property CreatedAt As Date
    Property Type As BackupType
End Class
