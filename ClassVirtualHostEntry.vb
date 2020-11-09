Imports System.Text

Public Class ClassVirtualHostEntry
    Public Property Raw As New List(Of String)
    Public Property Port As Integer = 80
    Public Property DocumentRoot As String
    Public Property ServerName As String
    Public Property SSL As Boolean

    Public ReadOnly Property Entry() As String
        Get
            Dim Output As New StringBuilder("")

            Output.AppendLine("<VirtualHost " & ServerName & ":" & Port & ">")
            Output.AppendLine(vbTab & "DocumentRoot " & Chr(34) & DocumentRoot & Chr(34))
            Output.AppendLine(vbTab & "ServerName " & Chr(34) & ServerName & Chr(34))
            Output.AppendLine("</VirtualHost>")

            Return Output.ToString
        End Get
    End Property

    Public Function Parse(ByVal Input As String) As Boolean
        Raw.Add(Input)

        Port = Regex.GetGroup(Input, "<VirtualHost.+?:(\d+)>")
        DocumentRoot = Regex.GetGroup(Input, "DocumentRoot.+?" & Chr(34) & "(.+?)" & Chr(34))
        ServerName = Regex.GetGroup(Input, "\s+ServerName.+?([a-z0-9\.\-]+)")
        SSL = Regex.IsValid(String.Join(Environment.NewLine, Raw), "<VirtualHost " & ServerName & ":443>")

        Return True
    End Function
End Class
