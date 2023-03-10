Public Class Payment
    Dim sql As String
    Dim dt As DataTable
    Dim timer As New Timer()
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNo()
        timer.Interval = 5000
        AddHandler timer.Tick, AddressOf LoadNo
    End Sub

    Public Sub LoadNo()
        sql = "select distinct orderid from orderdetail where status='Belum'"
        dt = Read(sql)
        Dim cnt = 0
        ComboBox3.Items.Clear()
        For Each row As DataRow In dt.Rows
            ComboBox3.Items.Add(dt.Rows(cnt)(0).ToString())
            cnt += 1
        Next
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        sql = "select msmenu.name, orderdetail.qty, msmenu.price, (orderdetail.qty * msmenu.price) as total from orderdetail,msmenu where orderdetail.orderid='" & ComboBox3.Text & "' and orderdetail.menuid=msmenu.id"
        dt = Read(sql)
        DataGridView1.DataSource = dt
        Label5.Text = 0
        For Each row As DataRow In dt.Rows
            Label5.Text = Integer.Parse(Label5.Text) + row.Item(3)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Label2.Text = "Card Number"
            Label3.Text = "Nama Bank"
            Kembalian.Visible = False
            Nominal.Visible = False
            NamaBank.Visible = True
            CardNumber.Visible = True
            Button1.Enabled = True
        Else
            Label2.Text = "Nominal"
            Label3.Text = "Kembalian"
            Kembalian.Visible = True
            NamaBank.Visible = False
            CardNumber.Visible = False
            Nominal.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "update orderdetail set status='Sudah' where orderId=@a"
        Dim finalSql = Bind(sql, {"a"}, {ComboBox3.Text})
        NoReturnValue(finalSql)
        If ComboBox1.SelectedIndex = 0 Then
            sql = "update orderheader set paymenttype=@payt, cardnumber=@card, bank=@bank where id=@a"
            finalSql = Bind(sql, {"a", "@payt", "@card", "@bank"}, {ComboBox3.Text, ComboBox1.Text, CardNumber.Text, NamaBank.Text})
        Else
            sql = "update orderheader set paymenttype=@payt where id=@a"
            finalSql = Bind(sql, {"a", "@payt"}, {ComboBox3.Text, ComboBox1.Text})
        End If
        NoReturnValue(finalSql)
        LoadNo()
    End Sub

    Private Sub Nominal_KeyUp(sender As Object, e As KeyEventArgs) Handles Nominal.KeyUp
        Try
            Kembalian.Text = (Integer.Parse(Nominal.Text) - Integer.Parse(Label5.Text)).ToString()
            If Integer.Parse(Kembalian.Text) < 0 Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Kembalian_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles Kembalian.MaskInputRejected

    End Sub
End Class