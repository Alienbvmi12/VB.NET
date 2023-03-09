Imports MySql.Data.MySqlClient

Public Class ManageMember
    Dim dt As New DataTable
    Dim sql As String
    Dim finalSql As MySqlCommand
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "Select * from msmember where name like '%" & TextBox1.Text & "%' or email like '%" & TextBox1.Text & "%' or handphone like '%" & TextBox1.Text & "%' or joinDate like '%" & TextBox1.Text & "%'"
        dt = Read(sql)
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        insert()
    End Sub
    Private Function Tabel()
        sql = "Select * from msmember"
        dt = Read(sql)
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.DataSource = dt
    End Function
    Private Function insert()
        If CheckBox1.Checked = False Then
            If MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim myTime As DateTime = DateTime.Now
                sql = "insert into msmember (name, email, handphone, joindate) values (@name, @email, @handphone, @joindate)"
                finalSql = Bind(sql, {"@name", "@email", "@handphone", "@joindate"}, {MaskedTextBox0.Text, MaskedTextBox1.Text, MaskedTextBox2.Text, myTime.ToString("yyyy-MM-dd HH:mm:ss")})
                NoReturnValue(finalSql)
                Tabel()
            End If
        Else
            Dim myTime As DateTime = DateTime.Now
            sql = "insert into msmember (name, email, handphone, joindate) values (@name, @email, @handphone, @joindate)"
            finalSql = Bind(sql, {"@name", "@email", "@handphone", "@joindate"}, {MaskedTextBox0.Text, MaskedTextBox1.Text, MaskedTextBox2.Text, myTime.ToString("yyyy-MM-dd HH:mm:ss")})
            NoReturnValue(finalSql)
            Tabel()
        End If
    End Function

    Private Function update()
        If CheckBox1.Checked = False Then
            If MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                sql = "Update msmember set name=@name, email=@email, handphone=@handphone where id=@id"
                finalSql = Bind(sql, {"@id", "@name", "@email", "@handphone"}, {Label3.Text, MaskedTextBox0.Text, MaskedTextBox1.Text, MaskedTextBox2.Text})
                NoReturnValue(finalSql)
                Tabel()
            End If
        Else
            sql = "Update msmember set name=@name, email=@email, handphone=@handphone where id=@id"
            finalSql = Bind(sql, {"@id", "@name", "@email", "@handphone"}, {Label3.Text, MaskedTextBox0.Text, MaskedTextBox1.Text, MaskedTextBox2.Text})
            NoReturnValue(finalSql)
            Tabel()
        End If


    End Function

    Private Function delete()
        If CheckBox1.Checked = False Then
            If MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                sql = "Delete from msmember where id=@id"
                finalSql = Bind(sql, {"@id"}, {Label3.Text})
                NoReturnValue(finalSql)
                Tabel()
            End If
        Else
            sql = "Delete from msmember where id=@id"
            finalSql = Bind(sql, {"@id"}, {Label3.Text})
            NoReturnValue(finalSql)
            Tabel()
        End If

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        update()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        delete()
    End Sub

    Private Sub ManageMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabel()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        Label3.Text = selectedRow.Cells(0).Value.ToString()
        MaskedTextBox0.Text = selectedRow.Cells(1).Value.ToString()
        MaskedTextBox1.Text = selectedRow.Cells(2).Value.ToString()
        MaskedTextBox2.Text = selectedRow.Cells(3).Value.ToString()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label3.Text = ""
        MaskedTextBox0.Text = ""
        MaskedTextBox1.Text = ""
        MaskedTextBox2.Text = ""
    End Sub
End Class