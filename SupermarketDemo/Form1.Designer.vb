<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TestDataSet = New SupermarketDemo.testDataSet()
        Me.Tb_EmpInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_EmpInfoTableAdapter = New SupermarketDemo.testDataSetTableAdapters.tb_EmpInfoTableAdapter()
        Me.TableAdapterManager = New SupermarketDemo.testDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_EmpInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TestDataSet
        '
        Me.TestDataSet.DataSetName = "testDataSet"
        Me.TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_EmpInfoBindingSource
        '
        Me.Tb_EmpInfoBindingSource.DataMember = "tb_EmpInfo"
        Me.Tb_EmpInfoBindingSource.DataSource = Me.TestDataSet
        '
        'Tb_EmpInfoTableAdapter
        '
        Me.Tb_EmpInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_CompanyTableAdapter = Nothing
        Me.TableAdapterManager.tb_EmpInfoTableAdapter = Me.Tb_EmpInfoTableAdapter
        Me.TableAdapterManager.tb_JhGoodsInfoTableAdapter = Nothing
        Me.TableAdapterManager.tb_KcGoodsTableAdapter = Nothing
        Me.TableAdapterManager.tb_SellGoodsTableAdapter = Nothing
        Me.TableAdapterManager.tb_ThGoodsInfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SupermarketDemo.testDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vladimir Script", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-3, 420)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "登录名称："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Vladimir Script", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(307, 417)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "登录密码："
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Vladimir Script", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(617, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Vladimir Script", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(711, 417)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 32)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "取消"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(118, 419)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(183, 25)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(428, 419)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(183, 25)
        Me.TextBox2.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(798, 407)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 452)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "登录信息"
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_EmpInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TestDataSet As testDataSet
    Friend WithEvents Tb_EmpInfoBindingSource As BindingSource
    Friend WithEvents Tb_EmpInfoTableAdapter As testDataSetTableAdapters.tb_EmpInfoTableAdapter
    Friend WithEvents TableAdapterManager As testDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
