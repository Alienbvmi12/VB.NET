Public Class Order
    Dim sql As String
    Dim dt As New DataTable
    Dim dt2 As New DataTable
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

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

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
        If dt.Rows.Count > 0 Then
            Dim newRow As New DataGridViewRow
            newRow.CreateCells(DataGridView2)
            newRow.Cells(0).Value = MaskedTextBox1.Text
            newRow.Cells("Qty").Value = MaskedTextBox2.Text
            newRow.Cells("CarboH").Value = dt.Rows(0)(4).Value
            newRow.Cells("ProteinN").Value = dt.Rows(0)(5).Value
            newRow.Cells("Price").Value = dt.Rows(0)(2).Value
            newRow.Cells("Total").Value = dt.Rows(0)(2).Value * MaskedTextBox2.Text
            DataGridView2.Rows.Add(newRow)
        Else
            MessageBox.Show("Menu tidak ada!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub carbo_Click(sender As Object, e As EventArgs) Handles carbo.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilTabelMenu()
    End Sub

    Private Function TampilTabelMenu()
        sql = "Select * from msmenu"
        dt = Read(sql)
        DataGridView1.DataSource = dt
    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        MaskedTextBox1.Text = selectedRow.Cells(1).Value.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myTime As DateTime = DateTime.Now
        sql = "select count(id) from orderheader"
        dt2 = Read(sql)
        Dim AI As String = dt2.ToString()
        If AI.Length = 4 Then
            AI = AI
        ElseIf AI.Length = 3 Then
            AI = "0" & AI
        ElseIf AI.Length = 2 Then
            AI = "00" & AI
        ElseIf AI.Length = 1 Then
            AI = "000" & AI
        End If
        Dim orderId As String = myTime.ToString("yyyyMMdd") & AI

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class

'sql = "Insert into orderdetail (orderid, menuid, qty, status) values (@orderid, @menuid, @qty, @status)"
'Dim finalSql As DataTable = Bind(sql, {"@orderid", "@menuid", "@qty", "@status"}, {, dt.Rows(0)(0), MaskedTextBox2.Text, "Belum bayar"})