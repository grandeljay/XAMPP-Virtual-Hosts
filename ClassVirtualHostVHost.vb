Imports System.Text

Public Class ClassVirtualHostVHost
    Public Property Raw As New List(Of String)
    Public Property Port As Integer = 80
    Public Property PortSSL As Integer = 443
    Public Property DocumentRoot As String = ""
    Public Property ServerName As String = ""
    Public Property SSL As Boolean = false
    Public Property Certificate As String
    Public Property CertificateKey As String
    Public Property Directory As String = ""

    Public ReadOnly Property Entry() As String
        Get
            If DocumentRoot.Trim.Length <= 0 OrElse ServerName.Trim.Length <= 0 Then Return ""

            Dim Output As New StringBuilder("")

            ' Default
            Output.AppendLine("<VirtualHost " & ServerName & ":" & Port & ">")
            If DocumentRoot.Trim.Length > 0 Then Output.AppendLine(vbTab & "DocumentRoot " & Chr(34) & DocumentRoot & Chr(34))
            If ServerName.Trim.Length > 0 Then Output.AppendLine(vbTab & "ServerName " & ServerName)
            If Directory.Trim.Length > 0 Then Output.AppendLine(vbTab & Directory)

            Output.AppendLine("</VirtualHost>")

            ' SSL
            If SSL Then
                Output.AppendLine()
                Output.AppendLine("<VirtualHost " & ServerName & ":" & PortSSL & ">")
                If DocumentRoot.Trim.Length > 0 Then Output.AppendLine(vbTab & "DocumentRoot " & Chr(34) & DocumentRoot & Chr(34))
                If ServerName.Trim.Length > 0 Then Output.AppendLine(vbTab & "ServerName " & ServerName)

                Output.AppendLine(vbTab & "SSLEngine On")
                Output.AppendLine(vbTab & "SSLCertificateFile " & Chr(34) & Certificate & Chr(34))
                Output.AppendLine(vbTab & "SSLCertificateKeyFile " & Chr(34) & CertificateKey & Chr(34))

                If Directory.Trim.Length > 0 Then Output.AppendLine(vbTab & Directory)

                Output.AppendLine("</VirtualHost>")
            End If

            Return Output.ToString.Trim
        End Get
    End Property

    Public Function Parse(ByVal Input As String) As Boolean
        Dim DirectoryBlock As String()

        Raw.Add(Input)

        If Input.Contains("SSLEngine On") Then
            PortSSL = Regex.GetGroup(Input, "<VirtualHost.+?:(\d+)>")
        Else
            Port = Regex.GetGroup(Input, "<VirtualHost.+?:(\d+)>")
        End If

        DocumentRoot = Regex.GetGroup(Input, "DocumentRoot.+?" & Chr(34) & "(.+?)" & Chr(34))
        ServerName = Regex.GetGroup(Input, "\s+ServerName.+?([a-z0-9\.\-]+)")
        SSL = Regex.IsValid(String.Join(Environment.NewLine, Raw), "<VirtualHost " & ServerName & ":443>")
        Certificate = Regex.GetGroup(Input, "SSLCertificateFile\s*" & Chr(34) & "(.+?)" & Chr(34))
        CertificateKey = Regex.GetGroup(Input, "SSLCertificateKeyFile\s*" & Chr(34) & "(.+?)" & Chr(34))

        DirectoryBlock = Functions.GetTextBetween(Input, "<Directory", "</Directory>")
        If DirectoryBlock.Count > 0 Then
            Directory = DirectoryBlock.First
        End If

        Return True
    End Function
End Class
