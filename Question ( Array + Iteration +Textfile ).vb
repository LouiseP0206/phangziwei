Imports System.IO
Imports System.Text

Public Class Form5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("testFile.txt", True)

        file.WriteLine("HUMAN RESOURCES")
        file.WriteLine("FINANCE")
        file.WriteLine("DECISION SCIENCE")
        file.WriteLine("ACCOUNTING")
        file.WriteLine("ENTREPRENEURSHIP")
        file.WriteLine("COMMUNICATION")
        file.WriteLine("LAW")
        file.WriteLine("MARKETING")
        file.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

       Dim line As String
        Dim readFile As System.IO.TextReader = New  _
            StreamReader("testFile.txt")

        While True
            line = readFile.ReadLine()
            If line Is Nothing Then
                Exit While
            Else
                ListBox1.Items.Add(line)
            End If
        End While
        readFile.Close()
        readFile = Nothing

    End Sub

    Private Sub displaySortedLine()

        For Each item As String In ListBox1.Text

            ListBox1.Items.Add(item)

        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ListBox1.Items.Clear()

        ClearList()

        Dim line(7) As String
        Dim i As Integer

        line(0) = " HUMAN RESOURCES "
        line(1) = " FINANCE "
        line(2) = " DECISION SCIENCE "
        line(3) = " ACCOUNTING "
        line(4) = " ENTREPRENEURSHIP "
        line(5) = " COMMUNICATION "
        line(6) = " LAW "
        line(7) = " MARKETING "

        For i = 0 To 7

            ListBox1.Items.Add(line(i))

        Next

        ClearList()
        Array.Sort(line)

        For i = 0 To 7

            ListBox1.Items.Add(line(i))

        Next


    End Sub

    Private Sub ClearList()

        ListBox1.Items.Clear()

    End Sub

End Class