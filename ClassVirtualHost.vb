Public Class ClassVirtualHost
    Public Property ID() As Integer
    Public Property IPv4 As New ClassVirtualHostIP
    Public Property IPv6 As New ClassVirtualHostIP
    Public Property vHosts As New ClassVirtualHostEntry
    Public Property Remove As Boolean

    Public ReadOnly Property Host() As String
        Get
            Dim TheHost As String = ""

            If Not String.IsNullOrEmpty(IPv4.Host) Then TheHost = IPv4.Host
            If Not String.IsNullOrEmpty(IPv6.Host) Then TheHost = IPv6.Host

            Return TheHost
        End Get
    End Property
End Class
