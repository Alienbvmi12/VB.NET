<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Order
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarboH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProteinN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.carbo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.protein = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(63, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(874, 269)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(874, 263)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Location = New System.Drawing.Point(63, 664)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(874, 244)
        Me.Panel2.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Menu, Me.Qty, Me.CarboH, Me.ProteinN, Me.Price, Me.Total})
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 33
        Me.DataGridView2.Size = New System.Drawing.Size(874, 241)
        Me.DataGridView2.TabIndex = 0
        '
        'Menu
        '
        Me.Menu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Menu.HeaderText = "Menu"
        Me.Menu.MinimumWidth = 8
        Me.Menu.Name = "Menu"
        Me.Menu.ReadOnly = True
        Me.Menu.Width = 93
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.MinimumWidth = 8
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        Me.Qty.Width = 150
        '
        'CarboH
        '
        Me.CarboH.HeaderText = "Carbo"
        Me.CarboH.MinimumWidth = 8
        Me.CarboH.Name = "CarboH"
        Me.CarboH.ReadOnly = True
        Me.CarboH.Width = 150
        '
        'ProteinN
        '
        Me.ProteinN.HeaderText = "Protein"
        Me.ProteinN.MinimumWidth = 8
        Me.ProteinN.Name = "ProteinN"
        Me.ProteinN.ReadOnly = True
        Me.ProteinN.Width = 150
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 8
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 150
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 8
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 150
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(424, 452)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 161)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(751, 489)
        Me.MaskedTextBox2.Mask = "00000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(150, 31)
        Me.MaskedTextBox2.TabIndex = 4
        Me.MaskedTextBox2.ValidatingType = GetType(Integer)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(621, 452)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Menu name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(621, 489)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Qty"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(621, 579)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(789, 579)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 34)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 938)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Carbo : "
        '
        'carbo
        '
        Me.carbo.Location = New System.Drawing.Point(212, 938)
        Me.carbo.Name = "carbo"
        Me.carbo.Size = New System.Drawing.Size(83, 38)
        Me.carbo.TabIndex = 10
        Me.carbo.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(301, 938)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Protein : "
        '
        'protein
        '
        Me.protein.Location = New System.Drawing.Point(380, 938)
        Me.protein.Name = "protein"
        Me.protein.Size = New System.Drawing.Size(81, 38)
        Me.protein.TabIndex = 12
        Me.protein.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(402, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 42)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Order form"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(467, 933)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 34)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Order"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(713, 933)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 25)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Total :"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(76, 452)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 10)
        Me.Label8.TabIndex = 35
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(752, 450)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(149, 32)
        Me.MaskedTextBox1.TabIndex = 36
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(751, 526)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 33)
        Me.ComboBox1.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(621, 529)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 25)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Member"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(821, 933)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 38)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(777, 933)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 25)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Rp."
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(63, 399)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 41
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(621, 624)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 34)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 1001)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.protein)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.carbo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Order"
        Me.Text = "Order"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents carbo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents protein As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MaskedTextBox1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Menu As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents CarboH As DataGridViewTextBoxColumn
    Friend WithEvents ProteinN As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Button4 As Button
End Class
