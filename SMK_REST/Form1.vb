Public Class Form1
    Public dt As New DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As String
        command = "select * from msemployee where (email='" & TextBox1.Text & "' or handphone='" & TextBox1.Text & "') and password='" & Koneksi.sha512enc(TextBox2.Text) & "'"
        dt = SqlCommand(command)
        If dt.Rows.Count > 0 Then
            MsgBox("Hello " + dt.Rows(0)(1))
            Home.Show()
        Else
            MsgBox("Email ataw password salah")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi.config()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
