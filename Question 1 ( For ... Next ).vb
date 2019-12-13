Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim W As Integer
        W = TextBox1.Text
        For W = 1 To 60
            ListBox1.Items.Add(W)
        Next W
    End Sub
End Class
