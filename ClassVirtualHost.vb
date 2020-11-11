Public Class ClassVirtualHost
    Public Property ID() As Integer
    Public Property IPv4 As New ClassVirtualHostIP
    Public Property IPv6 As New ClassVirtualHostIP
    Public Property VHosts As New ClassVirtualHostVHost
    Public Property IsOrphan As Boolean
    Public Property Errors As New List(Of Exception)
    Public Property Action As EnumAction

    Enum EnumAction
        None
        Add
        Remove
        Update
    End Enum

    Public ReadOnly Property Entry() As String
        Get
            Dim Entries As New List(Of String)
            If IPv4.Entry.Trim.Length > 0 Then Entries.Add(IPv4.Entry)
            If IPv6.Entry.Trim.Length > 0 Then Entries.Add(IPv6.Entry)

            Return String.Join(Environment.NewLine, Entries)
        End Get
    End Property

    Public ReadOnly Property Host() As String
        Get
            Dim TheHost As String = ""

            If Not String.IsNullOrEmpty(IPv4.Host) Then TheHost = IPv4.Host
            If Not String.IsNullOrEmpty(IPv6.Host) Then TheHost = IPv6.Host

            Return TheHost
        End Get
    End Property

    Public Function Clone()
        Return Me.MemberwiseClone()
    End Function
End Class
