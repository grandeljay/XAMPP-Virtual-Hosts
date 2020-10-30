Imports System.Text

Public Class ClassVirtualHostEntry
    Public Property Raw As New List(Of String)

    Public Property Port As Integer = 80

    Public Property DocumentRoot As String

    Public Property ServerName As String

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

        Port = Functions.getRegexGroup(Input, "<VirtualHost.+?:(\d+)>")
        DocumentRoot = Functions.getRegexGroup(Input, "DocumentRoot.+?" & Chr(34) & "(.+?)" & Chr(34))
        ServerName = Functions.getRegexGroup(Input, "\s+ServerName.+?([a-z0-9\.]+)")

        Return True
    End Function
End Class
