Public Class Form4

    Public marks(9) As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ListBox1.Items.Clear()

        For i As Integer = 0 To 9
            marks(i) = InputBox("PLEASE INSERT YOUR INTEGER,THANKS", "INSERT MARK")
            ListBox1.Items.Add(marks(i))

        Next
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ListBox1.Items.Clear()
        Array.Sort(marks)
        Array.Reverse(marks)
        displaySortedMarks()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ListBox1.Items.Clear()
        Array.Sort(marks)
        displaySortedMarks()

    End Sub
    Private Sub displaySortedMarks()

        For Each item As String In marks

            ListBox1.Items.Add(item)

        Next
    End Sub
End Class