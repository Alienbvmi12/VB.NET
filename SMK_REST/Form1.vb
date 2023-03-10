Public Class Form1
    Public dt As New DataTable
    Public UserId As String
    Public UserName As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As String
        command = "select * from msemployee where (email='" & TextBox1.Text & "' or handphone='" & TextBox1.Text & "') and password='" & Koneksi.sha512enc(TextBox2.Text) & "'"
        dt = Read(command)
        If dt.Rows.Count > 0 Then
            If dt(0).Item("position") = "ADMIN" Then
                MsgBox("Hello " + dt.Rows(0)(1))
                Home.Show()
                Me.Hide()
                UserId = dt.Rows(0)(0)
                UserName = dt.Rows(0)(1)
            Else
                MsgBox("Hello " + dt.Rows(0)(1))
                HomeCashier.Show()
                Me.Hide()
                UserId = dt.Rows(0)(0)
                UserName = dt.Rows(0)(1)
            End If
        Else
            MsgBox("Email ataw password salah")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi.config()
        MsgBox(Date.Now)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
