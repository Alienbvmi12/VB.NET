Imports System.IO
Imports System.Net
Imports MySql.Data.MySqlClient
Public Class ManageMenu
    Public dt As New DataTable
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As IO.FileSystemEventArgs)

    End Sub

    Private Sub ManageMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilTabel()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MaskedTextBox2.Text = UploadFile("http://localhost:8080/rayhan/uploadImg.php", MaskedTextBox2.Text)
        insert()
    End Sub

    Private Function TampilTabel()
        Dim query As String = "Select * from msmenu"
        dt = Read(query)
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.DataSource = dt
    End Function

    Private Function insert()
        If CheckBox1.Checked = False Then
            If MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim sql As String = "Insert into msmenu(name, price, photo, carbo, protein) values (@name, @price, @photo, @carbo, @protein)"
                Dim finalSql = Bind(sql, {"@name", "@price", "@photo", "@carbo", "@protein"}, {MaskedTextBox0.Text, MaskedTextBox1.Text, MaskedTextBox2.Text, MaskedTextBox3.Text, MaskedTextBox4.Text})
                NoReturnValue(finalSql)
                TampilTabel()
            End If
        Else
            Dim sql As String = "Insert into msmenu(name, price, photo, carbo, protein) values (@name, @price, @photo, @carbo, @protein)"
            Dim finalSql = Bind(sql, {"@name", "@price", "@photo", "@carbo", "@protein"}, {MaskedTextBox0.Text, MaskedTextBox1.Text, MaskedTextBox2.Text, MaskedTextBox3.Text, MaskedTextBox4.Text})
            NoReturnValue(finalSql)
            TampilTabel()
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Image files(*.jpg, *.jpeg, *.png, *.bmp, *.gif) | *.jpg; *.jpeg; *.png; *.bmp; *.gif "
        file.FilterIndex = 1
        file.RestoreDirectory = True

        If file.ShowDialog() = DialogResult.OK Then
            MaskedTextBox2.Text = file.FileName
            PreviewImage(file.FileName)
        End If
    End Sub

    Private Function PreviewImage(File As String)
        Try
            Dim imagePreview As Image
            Try
                imagePreview = Image.FromFile(File)
            Catch ex As Exception
                Dim request As WebRequest = WebRequest.Create(File)
                Dim response As WebResponse = request.GetResponse()
                Dim stream As Stream = response.GetResponseStream()
                Dim myImage As Stream = stream

                imagePreview = Image.FromStream(myImage)

                stream.Close()
                response.Close()
            End Try
            PictureBox1.Image = imagePreview
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Catch ex As Exception
            PictureBox1.Image = Nothing
        End Try
    End Function

    Private Sub MaskedTextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles MaskedTextBox2.KeyUp
        PreviewImage(MaskedTextBox2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CheckBox1.Checked = False Then
            If MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim sql As String = "Delete from msmenu where id='" & Label3.Text & "'"
                Dim finalSql = NoBind(sql)
                NoReturnValue(finalSql)
                TampilTabel()
            End If
        Else
            Dim sql As String = "Delete from msmenu where id='" & Label3.Text & "'"
            Dim finalSql = NoBind(sql)
            NoReturnValue(finalSql)
            TampilTabel()
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            PreviewImage(MaskedTextBox2.Text)
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            MaskedTextBox0.Text = selectedRow.Cells(1).Value.ToString()
            MaskedTextBox1.Text = selectedRow.Cells(2).Value.ToString()
            MaskedTextBox2.Text = selectedRow.Cells(3).Value.ToString()
            MaskedTextBox3.Text = selectedRow.Cells(4).Value.ToString()
            MaskedTextBox4.Text = selectedRow.Cells(5).Value.ToString()
            Label3.Text = selectedRow.Cells(0).Value.ToString()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox1.Checked = False Then
            If MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                MaskedTextBox2.Text = UploadFile("http://localhost:8080/rayhan/uploadImg.php", MaskedTextBox2.Text)
                Dim sql As String = "update msmenu set name=@name, price=@price, photo=@photo, carbo=@carbo, protein=@protein where id=@id"
                Dim finalSql = Bind(sql, {"@name", "@price", "@photo", "@carbo", "@protein", "@id"}, {MaskedTextBox0.Text, MaskedTextBox1.Text, MaskedTextBox2.Text, MaskedTextBox3.Text, MaskedTextBox4.Text, Label3.Text})
                NoReturnValue(finalSql)
                TampilTabel()
            End If
        Else
            MaskedTextBox2.Text = UploadFile("http://localhost:8080/rayhan/uploadImg.php", MaskedTextBox2.Text)
            Dim sql As String = "update msmenu set name=@name, price=@price, photo=@photo, carbo=@carbo, protein=@protein where id=@id"
            Dim finalSql = Bind(sql, {"@name", "@price", "@photo", "@carbo", "@protein", "@id"}, {MaskedTextBox0.Text, MaskedTextBox1.Text, MaskedTextBox2.Text, MaskedTextBox3.Text, MaskedTextBox4.Text, Label3.Text})
            NoReturnValue(finalSql)
            TampilTabel()
        End If
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Dim query As String = "Select * from msmenu where name like '%" & TextBox1.Text & "%' or price like '%" & TextBox1.Text & "%' or photo like '%" & TextBox1.Text & "%' or carbo like '%" & TextBox1.Text & "%' or protein like '%" & TextBox1.Text & "%' or id like '%" & TextBox1.Text & "%'"
        dt = Read(query)
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label3.Text = ""
        MaskedTextBox0.Text = ""
        MaskedTextBox1.Text = ""
        MaskedTextBox2.Text = ""
        MaskedTextBox3.Text = ""
        MaskedTextBox4.Text = ""
    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected

    End Sub
End Class