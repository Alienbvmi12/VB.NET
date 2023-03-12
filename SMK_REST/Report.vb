Imports MySql.Data.MySqlClient
Imports ScottPlot
Public Class Report
    Dim months() As String = {"January", "February", "March", "April", "May", "June",
                           "July", "August", "September", "October", "November", "December"}
    Dim year As String = DateTime.Now.ToString("yyyy")
    Dim sql As String
    Dim dt As New DataTable
    Dim reader As New DataTable
    Dim document As HtmlDocument

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each month As String In months
            ComboBox2.Items.Add(month)
        Next
    End Sub

    Private Sub Income_Report()
        Dim indexFrom As String = ComboBox2.SelectedIndex + 1
        Dim indexTo As String = Integer.Parse(indexFrom) + Integer.Parse(ComboBox1.SelectedIndex)
        If indexFrom.Length = 1 Then
            indexFrom = "0" & indexFrom
        End If
        If indexTo.Length = 1 Then
            indexTo = "0" & indexTo
        End If
        sql = "select month(orderheader.date) as date,sum(orderdetail.qty * msmenu.price) as income 
                from orderdetail, msmenu, orderheader 
                where (orderheader.date between '" & year & "-" & indexFrom & "-01' and '" & year & "-" & indexTo & "-31') 
                and orderdetail.menuid=msmenu.id 
                and orderdetail.orderid=orderheader.id group by month(date)"
        dt = Read(sql)
        Dim Values As New List(Of Double)
        Dim Positions As New List(Of Double)
        Dim Count As Integer = 1
        For Each row As DataRow In dt.Rows
            If row(1) <> 0 Or row(1) <> Nothing Then
                Values.Add(row(1))
            Else
                Values.Add(0)
            End If
            Positions.Add(Count)
            Count += 1
        Next
        Dim ValuesFF As Double() = Values.ToArray()
        Dim PositionsFF As Double() = Positions.ToArray()
        FormsPlot1.Plot.Clear()
        FormsPlot1.Plot.AddBar(ValuesFF, PositionsFF)
        FormsPlot1.Refresh()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim index As Integer = ComboBox2.SelectedIndex
        ComboBox1.Items.Clear()
        For item = index To months.Length - 1
            ComboBox1.Items.Add(months(item))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim indexFrom As String = ComboBox2.SelectedIndex + 1
        Dim indexTo As String = Integer.Parse(indexFrom) + Integer.Parse(ComboBox1.SelectedIndex)
        If indexFrom.Length = 1 Then
            indexFrom = "0" & indexFrom
        End If
        If indexTo.Length = 1 Then
            indexTo = "0" & indexTo
        End If
        sql = "select month(orderheader.date) as date,sum(orderdetail.qty * msmenu.price) as income 
                from orderdetail, msmenu, orderheader 
                where (orderheader.date between '" & year & "-" & indexFrom & "-01' and '" & year & "-" & indexTo & "-31') 
                and orderdetail.menuid=msmenu.id 
                and orderdetail.orderid=orderheader.id group by month(date)"
        dt = Read(sql)
        reader = Read(sql)
        DataGridView1.DataSource = dt
        Income_Report()
    End Sub
End Class