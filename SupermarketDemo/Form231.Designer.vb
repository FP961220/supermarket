<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form231
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(154, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "设置"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(380, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "退出"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "商品编号："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "进货单价："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "进货数量："
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(129, 25)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(100, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(129, 25)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(100, 109)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(129, 25)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(465, 109)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(137, 25)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(465, 59)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(137, 25)
        Me.TextBox5.TabIndex = 12
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(465, 6)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(137, 25)
        Me.TextBox6.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(377, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "警报数量："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(377, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "销售单价："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(377, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "商品名称："
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 224)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(587, 150)
        Me.DataGridView1.TabIndex = 14
        '
        'Form231
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 379)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.Name = "Form231"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "库存警报"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
