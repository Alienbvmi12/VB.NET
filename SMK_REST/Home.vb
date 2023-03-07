Public Class Home
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text += Form1.dt.Rows(0)(1)
        Form1.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ManageMenu.Show()
    End Sub
End Class