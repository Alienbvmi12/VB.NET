Imports System.IO
Imports System.Net

Public Class Order
    Dim sql As String
    Dim dt As New DataTable
    Dim dt2 As New DataTable
    Dim IdRow As New List(Of Integer)
    Dim aydi As Integer
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles protein.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "select * from msmenu where name='" & MaskedTextBox1.Text & "'"
        dt = Read(sql)
        Dim pil = True
        If DataGridView2.RowCount > 0 Then
            For Each row As DataGridViewRow In DataGridView2.Rows
                If row.Cells(0).Value = MaskedTextBox1.Text Then
                    row.Cells(1).Value = (Integer.Parse(row.Cells(1).Value) + Integer.Parse(MaskedTextBox2.Text)).ToString()
                    row.Cells(2).Value = (Integer.Parse(row.Cells(2).Value) + Integer.Parse(MaskedTextBox2.Text)).ToString()
                    row.Cells(3).Value = (Integer.Parse(row.Cells(3).Value) + Integer.Parse(MaskedTextBox2.Text)).ToString()
                    row.Cells(5).Value = (Integer.Parse(row.Cells(5).Value) + Integer.Parse(MaskedTextBox2.Text) * dt.Rows(0)(2)).ToString()
                    pil = False
                    Hasil()
                End If

            Next
            If pil Then
                Dim newRow As New DataGridViewRow
                newRow.CreateCells(DataGridView2)
                newRow.Cells(0).Value = MaskedTextBox1.Text
                newRow.Cells(1).Value = MaskedTextBox2.Text
                newRow.Cells(2).Value = dt.Rows(0)(4)
                newRow.Cells(3).Value = dt.Rows(0)(5)
                newRow.Cells(4).Value = dt.Rows(0)(2)
                newRow.Cells(5).Value = dt.Rows(0)(2) * newRow.Cells(1).Value
                IdRow.Add(aydi)
                DataGridView2.Rows.Add(newRow)
                Hasil()
            End If
        Else
            If pil Then
                Dim newRow As New DataGridViewRow
                newRow.CreateCells(DataGridView2)
                newRow.Cells(0).Value = MaskedTextBox1.Text
                newRow.Cells(1).Value = MaskedTextBox2.Text
                newRow.Cells(2).Value = dt.Rows(0)(4)
                newRow.Cells(3).Value = dt.Rows(0)(5)
                newRow.Cells(4).Value = dt.Rows(0)(2)
                newRow.Cells(5).Value = dt.Rows(0)(2) * newRow.Cells(1).Value
                DataGridView2.Rows.Add(newRow)
                IdRow.Add(aydi)
                Hasil()
            End If
        End If
    End Sub

    Private Sub Hasil()
        Dim CarboH As Integer
        Dim ProteinN As Integer
        Dim Total As Integer
        Dim Qty As Integer
        For Each row As DataGridViewRow In DataGridView2.Rows
            CarboH = row.Cells(2).Value
            ProteinN = row.Cells(3).Value
            Total = row.Cells(5).Value
            Qty = row.Cells(1).Value
            carbo.Text = (Integer.Parse(carbo.Text) + (CarboH * Qty)).ToString()
            protein.Text = (Integer.Parse(protein.Text) + (ProteinN * Qty)).ToString()
            Label7.Text = (Integer.Parse(Label7.Text) + Total).ToString()
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Count As Integer
        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = MaskedTextBox1.Text Then
                DataGridView2.Rows.Remove(row)
                IdRow.RemoveAt(Count)
            End If
            Count += 1
        Next
        Hasil()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub carbo_Click(sender As Object, e As EventArgs) Handles carbo.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilTabelMenu()
        TampilMember()
    End Sub

    Private Function TampilTabelMenu()
        sql = "Select name, carbo, protein, price from msmenu"
        dt = Read(sql)
        DataGridView1.DataSource = dt
    End Function

    Private Sub TampilMember()
        sql = "select id, name from msmember"
        dt = Read(sql)
        Dim cnt As Integer
        For Each cmb As DataRow In dt.Rows
            ComboBox1.Items.Add(dt.Rows(cnt)(0).ToString() & "." & dt.Rows(cnt)(1).ToString())
            cnt += 1
        Next
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        MaskedTextBox1.Text = selectedRow.Cells(0).Value.ToString()
        sql = "select photo, id from msmenu where name='" & MaskedTextBox1.Text & "'"
        dt = Read(sql)
        aydi = Integer.Parse(dt.Rows(0)(1))
        previewImage(dt.Rows(0)(0))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myTime As DateTime = MonthCalendar1.SelectionStart
        sql = "select count(id) from orderheader"
        dt2 = Read(sql)
        Dim AI As String = dt2.Rows(0)(0).ToString()
        If AI.Length = 4 Then
            AI = AI
        ElseIf AI.Length = 3 Then
            AI = "0" & AI
        ElseIf AI.Length = 2 Then
            AI = "00" & AI
        ElseIf AI.Length = 1 Then
            AI = "000" & AI
        Else
            AI = "000" & AI
        End If
        Dim bindSql
        Dim orderId As String = myTime.ToString("yyyyMMdd") & AI

        sql = "Insert into orderheader (id, employeeid, memberid, date) values(@id, @emp, @mid, @date)"
        bindSql = Bind(sql, {"id", "@emp", "@mid", "@date"}, {orderId, Form1.UserId, ComboBox1.Text.Split(".")(0), myTime.ToString("yyyy-MM-dd")})
        NoReturnValue(bindSql)

        Dim Count As Integer = 0

        Dim JumRow = DataGridView2.Rows.Count - 2

        For Index As Integer = 0 To JumRow
            Dim row As DataGridViewRow = DataGridView2.Rows(Count)
            sql = "Insert into orderdetail (orderid, menuid, qty, status) values (@oid, @mid, @qty, @stat)"
            bindSql = Bind(sql, {"@oid", "@mid", "@qty", "@stat"}, {orderId, IdRow.Item(Count), row.Cells(1).Value.ToString(), "Belum"})
            NoReturnValue(bindSql)
            Count += 1
        Next
        Payment.LoadNo()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim SelectedRows As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
        MaskedTextBox1.Text = SelectedRows.Cells(0).Value.ToString()
        sql = "select photo, id from msmenu where name='" & MaskedTextBox1.Text & "'"
        dt = Read(sql)
        aydi = Integer.Parse(dt.Rows(0)(1))
        previewImage(dt.Rows(0)(0))
    End Sub

    Private Sub MaskedTextBox1_KeyUp(sender As Object, e As KeyEventArgs)

    End Sub

    Private Function previewImage(File As String)
        Try
            Dim imagePreview As Image
            Try
                imagePreview = Image.FromFile(File)
            Catch ex As Exception
                Dim request As WebRequest = WebRequest.Create(File)
                Dim response As WebResponse = request.GetResponse()
                Dim myImage As Stream = response.GetResponseStream()

                imagePreview = Image.FromStream(myImage)

                myImage.Close()
                response.Close()
            End Try
            PictureBox1.Image = imagePreview
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Catch ex As Exception
            PictureBox1.Image = Nothing
        End Try
    End Function

    Private Sub MaskedTextBox1_Leave(sender As Object, e As EventArgs)
        sql = "select photo from msmenu where name='" & MaskedTextBox1.Text & "'"
        dt = Read(sql)
        If dt.Rows.Count > 0 Then
            previewImage(dt.Rows(0)(0).ToString())
        Else
            previewImage("http://false.net")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView2.Rows.Clear()
    End Sub
End Class

'sql = "Insert into orderdetail (orderid, menuid, qty, status) values (@orderid, @menuid, @qty, @status)"
'Dim finalSql As DataTable = Bind(sql, {"@orderid", "@menuid", "@qty", "@status"}, {, dt.Rows(0)(0), MaskedTextBox2.Text, "Belum bayar"})