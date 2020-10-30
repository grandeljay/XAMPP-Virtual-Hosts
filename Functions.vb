Imports System.IO
Imports System.Text.RegularExpressions

Module Functions
    Function getFileContents(ByVal Filepath As String) As String
        If Not File.Exists(Filepath) Then Return ""

        Dim FilepathContents As String = File.ReadAllText(Filepath)

        Return FilepathContents
    End Function

    Function getRegexGroups(ByVal Subject As String, ByVal Regex As String, Optional ByVal Groups As Integer() = Nothing) As String()
        Dim DoRegex As New Regex(Regex)
        Dim DoRegexMatch As MatchCollection = DoRegex.Matches(Subject)
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


    Function getRegexGroup(ByVal Subject As String, ByVal Regex As String, Optional ByVal GroupIndex As Integer = 1) As String
        Dim DoRegex As New Regex(Regex)
        Dim DoRegexMatch As Match = DoRegex.Match(Subject)
        Dim DoRegexOutput As String = ""

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

    Function getTextBetween(ByVal Subject As String, ByVal TextStart As String, ByVal TextEnd As String) As String()
        Dim TextBetween As String = ""

        Dim IndexStart As Integer = -1
        Dim IndexEnd As Integer = -1

        Dim TextsBetween As New List(Of String)

        For i = 0 To Subject.Length - 1
            '
            ' Start
            '
            If Subject.Length >= i + TextStart.Length AndAlso Subject.Substring(i, TextStart.Length) = TextStart Then
                IndexStart = i
            End If

            '
            ' End
            '
            If Subject.Length >= i + TextEnd.Length AndAlso Subject.Substring(i, TextEnd.Length) = TextEnd Then
                IndexEnd = i + TextEnd.Length

                Dim TextToAdd As String = Subject.Substring(IndexStart, IndexEnd - IndexStart).Trim
                TextsBetween.Add(TextToAdd)

                IndexStart = IndexEnd
                IndexEnd = -1
            End If
        Next

        Return TextsBetween.ToArray
    End Function

End Module
