<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form201
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TestDataSet = New SupermarketDemo.testDataSet()
        Me.TbEmpInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_EmpInfoTableAdapter = New SupermarketDemo.testDataSetTableAdapters.tb_EmpInfoTableAdapter()
        Me.TbEmpInfoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpSexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpDeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpPostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbEmpInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbEmpInfoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "员工姓名："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "家庭电话："
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(353, 139)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(154, 25)
        Me.TextBox4.TabIndex = 11
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(353, 91)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(154, 25)
        Me.TextBox5.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(265, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "手机号码："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(265, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "登录密码："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(265, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "出生日期："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(581, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "所属部门："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(581, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "员工职位："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(581, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "性别："
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"男", "女"})
        Me.ComboBox1.Location = New System.Drawing.Point(660, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 15
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"部长", "部员"})
        Me.ComboBox2.Location = New System.Drawing.Point(660, 91)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox2.TabIndex = 16
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"测试部", "开发部"})
        Me.ComboBox3.Location = New System.Drawing.Point(660, 139)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox3.TabIndex = 17
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(353, 42)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(154, 25)
        Me.DateTimePicker1.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 198)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 15)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "家庭地址："
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(109, 195)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(672, 99)
        Me.TextBox6.TabIndex = 20
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpIdDataGridViewTextBoxColumn, Me.EmpNameDataGridViewTextBoxColumn, Me.EmpSexDataGridViewTextBoxColumn, Me.EmpDeptDataGridViewTextBoxColumn, Me.EmpPostDataGridViewTextBoxColumn, Me.EmpPhoneDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbEmpInfoBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(109, 300)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(672, 150)
        Me.DataGridView1.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "保存"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(83, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "取消"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(164, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "添加"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(245, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "修改"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(326, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "删除"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(407, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 15)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "查询条件："
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(495, 2)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(102, 23)
        Me.ComboBox4.TabIndex = 28
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(603, 2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 25)
        Me.TextBox7.TabIndex = 29
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(706, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 30
        Me.Button6.Text = "查找"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(785, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 31
        Me.Button7.Text = "退出"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "系统登录名："
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(109, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 25)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(109, 91)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 25)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(109, 139)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 25)
        Me.TextBox3.TabIndex = 5
        '
        'TestDataSet
        '
        Me.TestDataSet.DataSetName = "testDataSet"
        Me.TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbEmpInfoBindingSource
        '
        Me.TbEmpInfoBindingSource.DataMember = "tb_EmpInfo"
        Me.TbEmpInfoBindingSource.DataSource = Me.TestDataSet
        '
        'Tb_EmpInfoTableAdapter
        '
        Me.Tb_EmpInfoTableAdapter.ClearBeforeFill = True
        '
        'TbEmpInfoBindingSource1
        '
        Me.TbEmpInfoBindingSource1.DataMember = "tb_EmpInfo"
        Me.TbEmpInfoBindingSource1.DataSource = Me.TestDataSet
        '
        'EmpIdDataGridViewTextBoxColumn
        '
        Me.EmpIdDataGridViewTextBoxColumn.DataPropertyName = "EmpId"
        Me.EmpIdDataGridViewTextBoxColumn.HeaderText = "员工编号"
        Me.EmpIdDataGridViewTextBoxColumn.Name = "EmpIdDataGridViewTextBoxColumn"
        '
        'EmpNameDataGridViewTextBoxColumn
        '
        Me.EmpNameDataGridViewTextBoxColumn.DataPropertyName = "EmpName"
        Me.EmpNameDataGridViewTextBoxColumn.HeaderText = "员工姓名"
        Me.EmpNameDataGridViewTextBoxColumn.Name = "EmpNameDataGridViewTextBoxColumn"
        '
        'EmpSexDataGridViewTextBoxColumn
        '
        Me.EmpSexDataGridViewTextBoxColumn.DataPropertyName = "EmpSex"
        Me.EmpSexDataGridViewTextBoxColumn.HeaderText = "性别"
        Me.EmpSexDataGridViewTextBoxColumn.Name = "EmpSexDataGridViewTextBoxColumn"
        '
        'EmpDeptDataGridViewTextBoxColumn
        '
        Me.EmpDeptDataGridViewTextBoxColumn.DataPropertyName = "EmpDept"
        Me.EmpDeptDataGridViewTextBoxColumn.HeaderText = "所属部门"
        Me.EmpDeptDataGridViewTextBoxColumn.Name = "EmpDeptDataGridViewTextBoxColumn"
        '
        'EmpPostDataGridViewTextBoxColumn
        '
        Me.EmpPostDataGridViewTextBoxColumn.DataPropertyName = "EmpPost"
        Me.EmpPostDataGridViewTextBoxColumn.HeaderText = "员工职位"
        Me.EmpPostDataGridViewTextBoxColumn.Name = "EmpPostDataGridViewTextBoxColumn"
        '
        'EmpPhoneDataGridViewTextBoxColumn
        '
        Me.EmpPhoneDataGridViewTextBoxColumn.DataPropertyName = "EmpPhone"
        Me.EmpPhoneDataGridViewTextBoxColumn.HeaderText = "联系电话"
        Me.EmpPhoneDataGridViewTextBoxColumn.Name = "EmpPhoneDataGridViewTextBoxColumn"
        '
        'Form201
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(872, 450)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximizeBox = False
        Me.Name = "Form201"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "员工基本信息"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbEmpInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbEmpInfoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TestDataSet As testDataSet
    Friend WithEvents TbEmpInfoBindingSource As BindingSource
    Friend WithEvents Tb_EmpInfoTableAdapter As testDataSetTableAdapters.tb_EmpInfoTableAdapter
    Friend WithEvents EmpIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpSexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpDeptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpPostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TbEmpInfoBindingSource1 As BindingSource
End Class
