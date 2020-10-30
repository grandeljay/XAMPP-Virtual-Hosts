Public Class ClassVirtualHostIP
    Public ReadOnly Property Entry() As String
        Get
            Return Address & " " & Host
        End Get
    End Property

    Public Property Address As String
    Public Property Host As String
End Class
