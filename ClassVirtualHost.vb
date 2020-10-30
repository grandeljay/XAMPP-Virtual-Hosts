Public Class ClassVirtualHost
    Public Property IPv4 As New ClassVirtualHostIP
    Public Property IPv6 As New ClassVirtualHostIP
    Public Property vHostsEntry As New ClassVirtualHostEntry

    Public ReadOnly Property Host() As String
        Get
            Dim TheHost As String = ""

            If Not String.IsNullOrEmpty(IPv4.Host) Then TheHost = IPv4.Host
            If Not String.IsNullOrEmpty(IPv6.Host) Then TheHost = IPv6.Host

            Return TheHost
        End Get
    End Property
End Class
