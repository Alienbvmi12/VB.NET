<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report
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
        Panel1 = New Panel()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        FormsPlot1 = New ScottPlot.FormsPlot()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(FormsPlot1)
        Panel1.Location = New Point(68, 500)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(621, 250)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(DataGridView1)
        Panel2.Location = New Point(68, 244)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(621, 250)
        Panel2.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(621, 250)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(253, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(233, 48)
        Label1.TabIndex = 2
        Label1.Text = "Form Report"' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(272, 162)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(150, 33)
        ComboBox1.TabIndex = 38
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(272, 123)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(150, 33)
        ComboBox2.TabIndex = 39
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(190, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 40
        Label2.Text = "From"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(190, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 25)
        Label3.TabIndex = 41
        Label3.Text = "To"' 
        ' Button1
        ' 
        Button1.Location = New Point(428, 162)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 42
        Button1.Text = "Generate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' FormsPlot1
        ' 
        FormsPlot1.Location = New Point(0, 2)
        FormsPlot1.Margin = New Padding(6, 5, 6, 5)
        FormsPlot1.Name = "FormsPlot1"
        FormsPlot1.Size = New Size(621, 248)
        FormsPlot1.TabIndex = 0
        ' 
        ' Report
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(759, 796)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Report"
        Text = "Report"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FormsPlot1 As ScottPlot.FormsPlot
End Class
