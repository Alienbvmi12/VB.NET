Imports System.IO
Imports System.Net
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
        insert()
    End Sub

    Private Function TampilTabel()
        Dim query As String = "Select * from msmenu"
        Panel1.Controls.Clear()
        dt = Read(query)
        Dim dgv As New DataGridView()
        Panel1.Controls.Add(dgv)
        dgv.Dock = DockStyle.Fill
        dgv.DataSource = dt
    End Function

    Private Function insert()
        Dim sql As String = "Insert into msmenu(name, price, photo, carbo, protein) values (@name, @price, @photo, @carbo, @protein)"
        Dim finalSql = Bind(sql, {"@name", "@price", "@photo", "@carbo", "@protein"}, {MaskedTextBox0.Text, MaskedTextBox1.Text, MaskedTextBox2.Text, MaskedTextBox3.Text, MaskedTextBox4.Text})
        NoReturnValue(finalSql)
        TampilTabel()
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
        ProgressBar1.Style = ProgressBarStyle.Blocks
        ProgressBar1.Value = 0
        ProgressBar1.Visible = True
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

                ' Get the length of the response stream
                Dim contentLength As Long = response.ContentLength
                Dim totalBytesRead As Long = 0
                Dim buffer As Byte() = New Byte(4096) {}
                Dim bytesRead As Integer = 0

                ' Loop through the response stream and read the data in chunks
                Do
                    bytesRead = stream.Read(buffer, 0, buffer.Length)
                    If bytesRead > 0 Then
                        ' Update the progress bar with the percentage of data read
                        totalBytesRead += bytesRead
                        Dim percentComplete As Integer = CInt(Math.Round((totalBytesRead / contentLength) * 100))
                        ProgressBar1.Value = percentComplete
                    End If
                Loop While bytesRead > 0


                stream.Close()
                response.Close()
            End Try
            PictureBox1.Image = imagePreview
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Catch ex As Exception
            PictureBox1.Image = Nothing
        End Try
        ProgressBar1.Visible = False
    End Function

    Private Sub MaskedTextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles MaskedTextBox2.KeyUp
        PreviewImage(MaskedTextBox2.Text)
    End Sub
End Class