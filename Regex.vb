Module Regex
    Public Function IsValid(ByVal Subject As String, ByVal Regex As String) As Boolean
        If GetGroups(Subject, Regex).Count > 0 Then Return True

        Return False
    End Function

    Public Function GetGroups(ByVal Subject As String, ByVal Regex As String, Optional ByVal Groups As Integer() = Nothing) As String()
        Dim DoRegex As New System.Text.RegularExpressions.Regex(Regex)
        Dim DoRegexMatch As System.Text.RegularExpressions.MatchCollection = DoRegex.Matches(Subject)
        Dim DoRegexOutput As New List(Of String)

        For i = 0 To DoRegexMatch.Count - 1
            If Groups Is Nothing OrElse Groups.Count > i AndAlso (Groups(i) = Nothing OrElse Groups(i) <= 0) Then
                DoRegexOutput.Add(DoRegexMatch(i).Value)
            Else
                For Each iGroup As Integer In Groups
                    DoRegexOutput.Add(DoRegexMatch(i).Groups(iGroup).Value)
                Next
            End If
        Next

        Return DoRegexOutput.ToArray
    End Function

    Public Function GetGroup(ByVal Subject As String, ByVal Regex As String, Optional ByVal GroupIndex As Integer = 1) As String
        Dim DoRegex As New System.Text.RegularExpressions.Regex(Regex)
        Dim DoRegexMatch As System.Text.RegularExpressions.Match = DoRegex.Match(Subject)
        Dim DoRegexOutput As String

        If GroupIndex >= DoRegexMatch.Groups.Count Then GroupIndex = DoRegexMatch.Groups.Count - 1

        If DoRegexMatch.Groups.Count > 0 Then
            DoRegexOutput = DoRegexMatch.Groups(GroupIndex).Value
        Else
            DoRegexOutput = DoRegexMatch.Value
        End If

        If Not DoRegexMatch.Success Then
            DoRegexOutput = "Regex operation: " & Regex & " failed."
        End If

        Return DoRegexOutput
    End Function
End Module
