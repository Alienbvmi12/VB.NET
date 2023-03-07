Public Class ManageMenu
    Public dt As New DataTable
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As IO.FileSystemEventArgs)

    End Sub

    Private Sub ManageMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "Select * from msmenu"
        Panel1.Controls.Clear()
        dt = SqlCommand(query)
        Dim dgv As New DataGridView()
        Panel1.Controls.Add(dgv)
        dgv.Dock = DockStyle.Fill
        dgv.DataSource = dt
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class