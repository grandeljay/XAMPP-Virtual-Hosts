Imports System.IO

Public Class FormDatabaseImport
    Const XAMPP_MYSQL_BIN As String = "\mysql\bin"

    Dim Databases As New List(Of String)

    Private Sub FormDatabaseImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Databases.Clear()

        For Each SQL As String In Directory.GetFiles(My.Settings.DirectoryXAMPP & XAMPP_MYSQL_BIN, "*.sql", SearchOption.TopDirectoryOnly)
            Databases.Add(SQL)
            ComboBoxDatabaseSelect.Items.Add(Path.GetFileNameWithoutExtension(SQL))
        Next

        ComboBoxDatabaseSelect.SelectedIndex = 0
    End Sub

    Private Sub FormDatabaseImport_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LabelDatabaseSelectDescription.Text = "Database must be in " & My.Settings.DirectoryXAMPP & XAMPP_MYSQL_BIN & "."
    End Sub

    Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click
        Dim Database As String = Databases(ComboBoxDatabaseSelect.SelectedIndex)
        Dim DatabaseLine As String = ""
        Dim DatabaseReplaced As String = Database & ".new"

        Dim SW As New StreamWriter(DatabaseReplaced)

        Using SR As New StreamReader(Database)
            Do Until SR.EndOfStream
                DatabaseLine = SR.ReadLine()

                ' UK
                DatabaseLine = DatabaseLine.Replace(TextBoxSearchDomainUK.Text, TextBoxReplaceDomainUK.Text)
                DatabaseLine = DatabaseLine.Replace(TextBoxSearchDomainEscapedUK.Text, TextBoxReplaceDomainEscapedUK.Text)
                DatabaseLine = DatabaseLine.Replace(TextBoxSearchDomainEncodedUK.Text, TextBoxReplaceDomainEncodedUK.Text)

                ' DE
                DatabaseLine = DatabaseLine.Replace(TextBoxSearchDomainDE.Text, TextBoxReplaceDomainDE.Text)
                DatabaseLine = DatabaseLine.Replace(TextBoxSearchDomainEscapedDE.Text, TextBoxReplaceDomainEscapedDE.Text)
                DatabaseLine = DatabaseLine.Replace(TextBoxSearchDomainEncodedDE.Text, TextBoxReplaceDomainEncodedDE.Text)

                ' Absolute Path
                DatabaseLine = DatabaseLine.Replace(TextBoxSearchDirectoryAbsolute.Text, TextBoxReplaceDirectoryAbsolute.Text)

                SW.WriteLine(DatabaseLine)
            Loop
        End Using

        SW.Close()


        '
        ' Backup
        '
        File.Move(Database, Database & ".original")
        File.Move(DatabaseReplaced, Database)


        '
        ' Import
        '
        Dim DB_Name As String = "hybridsupplytest"
        Dim DB_User As String = "hybridsupplytest"
        Dim DB_Password As String = "hybridsupplytest"

        Dim DB_Options As New List(Of String)
        DB_Options.Add("-f")

        Dim Arguments As New List(Of String)
        Arguments.Add("mysql.exe")
        Arguments.Add("-u " & DB_User)
        Arguments.Add("-p" & DB_Password)
        Arguments.Add(String.Join(" ", DB_Options))
        Arguments.Add(DB_Name & " < " & DB_Name & ".sql")

        Dim Lines As New List(Of String)
        Lines.Add("@echo on")
        Lines.Add("C:\xampp\mysql\bin\mysql.exe -u root -e " & Chr(34) & "DROP DATABASE " & DB_Name & Chr(34) & ";")
        Lines.Add("C:\xampp\mysql\bin\mysql.exe -u root -e " & Chr(34) & "CREATE DATABASE " & DB_Name & Chr(34) & ";")
        Lines.Add(String.Join(" ", Arguments))
        Lines.Add("pause")


        '
        ' Create CMD
        '        
        Dim FileCMD As String = My.Settings.DirectoryXAMPP & XAMPP_MYSQL_BIN & "\import.cmd"
        File.WriteAllLines(FileCMD, Lines)

        MessageBox.Show("Complete")

        Process.Start(FileCMD)

        End
    End Sub

    Private Sub ComboBoxDatabaseSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDatabaseSelect.SelectedIndexChanged
        ButtonImport.Enabled = ComboBoxDatabaseSelect.SelectedIndex > -1
    End Sub
End Class