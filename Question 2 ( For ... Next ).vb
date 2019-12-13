Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Z As Double
        Z = TextBox1.Text
        For Z = 30 To 0 Step -2.5
            ListBox1.Items.Add(Z)
        Next Z
    End Sub
End Class