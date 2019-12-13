Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim M As Integer
        M = TextBox1.Text
        M = 50
        Do While M <= 200
            ListBox1.Items.Add(M)
            M = M + 10
        Loop
    End Sub
End Class