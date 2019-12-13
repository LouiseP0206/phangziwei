Public Class Database

    Private Sub DataBaseHEREDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Database_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DataBase_HEREDataSet1.STUDENT' table. You can move, or remove it, as needed.
        Me.STUDENTTableAdapter.Fill(Me.DataBase_HEREDataSet1.STUDENT)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        STUDENTBindingSource.MovePrevious()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        STUDENTBindingSource.AddNew()
        STUDENTTableAdapter.Update(DataBase_HEREDataSet1.STUDENT)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        STUDENTBindingSource.MoveNext()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        On Error GoTo SaveErr

        STUDENTBindingSource.EndEdit()
        STUDENTTableAdapter.Update(DataBase_HEREDataSet1.STUDENT)
        MessageBox.Show("Okay,it is save successfully")

SaveErr:

        Exit Sub

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        STUDENTBindingSource.RemoveCurrent()
        STUDENTTableAdapter.Update(DataBase_HEREDataSet1.STUDENT)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Me.Close()

    End Sub

End Class