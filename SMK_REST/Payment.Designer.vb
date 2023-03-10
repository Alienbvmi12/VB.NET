<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NamaBank = New System.Windows.Forms.ComboBox()
        Me.CardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Nominal = New System.Windows.Forms.MaskedTextBox()
        Me.Kembalian = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(52, 167)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(585, 243)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(579, 237)
        Me.DataGridView1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Credit Card", "Cash"})
        Me.ComboBox1.Location = New System.Drawing.Point(193, 439)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 33)
        Me.ComboBox1.TabIndex = 38
        '
        'NamaBank
        '
        Me.NamaBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NamaBank.FormattingEnabled = True
        Me.NamaBank.Items.AddRange(New Object() {"BCA", "BNI", "BTN", "Danamon", "BJB", "BSI", "Mandiri", "Mega"})
        Me.NamaBank.Location = New System.Drawing.Point(193, 515)
        Me.NamaBank.Name = "NamaBank"
        Me.NamaBank.Size = New System.Drawing.Size(182, 33)
        Me.NamaBank.TabIndex = 39
        '
        'CardNumber
        '
        Me.CardNumber.Location = New System.Drawing.Point(193, 478)
        Me.CardNumber.Mask = "0000000000000000"
        Me.CardNumber.Name = "CardNumber"
        Me.CardNumber.Size = New System.Drawing.Size(182, 31)
        Me.CardNumber.TabIndex = 40
        Me.CardNumber.ValidatingType = GetType(Integer)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 439)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Payment Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 478)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Card Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 515)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 25)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Bank Name"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(286, 579)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(432, 428)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 25)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Total :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(528, 428)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 25)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "0"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(487, 428)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 25)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Rp."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(250, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 42)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Payment"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(287, 100)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(182, 33)
        Me.ComboBox3.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(185, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 25)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Order Id"
        '
        'Nominal
        '
        Me.Nominal.Location = New System.Drawing.Point(193, 478)
        Me.Nominal.Mask = "0000000000000000"
        Me.Nominal.Name = "Nominal"
        Me.Nominal.Size = New System.Drawing.Size(182, 31)
        Me.Nominal.TabIndex = 52
        Me.Nominal.Text = "0"
        Me.Nominal.ValidatingType = GetType(Integer)
        Me.Nominal.Visible = False
        '
        'Kembalian
        '
        Me.Kembalian.Location = New System.Drawing.Point(193, 517)
        Me.Kembalian.Name = "Kembalian"
        Me.Kembalian.ReadOnly = True
        Me.Kembalian.Size = New System.Drawing.Size(182, 31)
        Me.Kembalian.TabIndex = 51
        Me.Kembalian.Text = "0"
        Me.Kembalian.Visible = False
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 641)
        Me.Controls.Add(Me.Nominal)
        Me.Controls.Add(Me.Kembalian)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CardNumber)
        Me.Controls.Add(Me.NamaBank)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Payment"
        Me.Text = "Payment"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents NamaBank As ComboBox
    Friend WithEvents CardNumber As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Nominal As MaskedTextBox
    Friend WithEvents Kembalian As MaskedTextBox
End Class
