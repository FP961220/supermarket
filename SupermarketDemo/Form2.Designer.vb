<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.员工信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.供应商信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.商品进货ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.商品查询ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.商品销售ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.商品退货ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.库存报警ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.库存查询ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.数据备份ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.数据还原ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(883, 407)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(883, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.员工信息ToolStripMenuItem, Me.供应商信息ToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(81, 24)
        Me.ToolStripMenuItem1.Text = "基本档案"
        '
        '员工信息ToolStripMenuItem
        '
        Me.员工信息ToolStripMenuItem.Name = "员工信息ToolStripMenuItem"
        Me.员工信息ToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.员工信息ToolStripMenuItem.Text = "员工信息"
        '
        '供应商信息ToolStripMenuItem
        '
        Me.供应商信息ToolStripMenuItem.Name = "供应商信息ToolStripMenuItem"
        Me.供应商信息ToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.供应商信息ToolStripMenuItem.Text = "供应商信息"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.商品进货ToolStripMenuItem, Me.商品查询ToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(81, 24)
        Me.ToolStripMenuItem2.Text = "进货管理"
        '
        '商品进货ToolStripMenuItem
        '
        Me.商品进货ToolStripMenuItem.Name = "商品进货ToolStripMenuItem"
        Me.商品进货ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.商品进货ToolStripMenuItem.Text = "商品进货"
        '
        '商品查询ToolStripMenuItem
        '
        Me.商品查询ToolStripMenuItem.Name = "商品查询ToolStripMenuItem"
        Me.商品查询ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.商品查询ToolStripMenuItem.Text = "商品查询"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.商品销售ToolStripMenuItem, Me.商品退货ToolStripMenuItem})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(81, 24)
        Me.ToolStripMenuItem3.Text = "销售管理"
        '
        '商品销售ToolStripMenuItem
        '
        Me.商品销售ToolStripMenuItem.Name = "商品销售ToolStripMenuItem"
        Me.商品销售ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.商品销售ToolStripMenuItem.Text = "商品销售"
        '
        '商品退货ToolStripMenuItem
        '
        Me.商品退货ToolStripMenuItem.Name = "商品退货ToolStripMenuItem"
        Me.商品退货ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.商品退货ToolStripMenuItem.Text = "商品退货"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.库存报警ToolStripMenuItem, Me.库存查询ToolStripMenuItem})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(81, 24)
        Me.ToolStripMenuItem4.Text = "库存管理"
        '
        '库存报警ToolStripMenuItem
        '
        Me.库存报警ToolStripMenuItem.Name = "库存报警ToolStripMenuItem"
        Me.库存报警ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.库存报警ToolStripMenuItem.Text = "库存报警"
        '
        '库存查询ToolStripMenuItem
        '
        Me.库存查询ToolStripMenuItem.Name = "库存查询ToolStripMenuItem"
        Me.库存查询ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.库存查询ToolStripMenuItem.Text = "库存查询"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.数据备份ToolStripMenuItem, Me.数据还原ToolStripMenuItem})
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(81, 24)
        Me.ToolStripMenuItem5.Text = "系统维护"
        '
        '数据备份ToolStripMenuItem
        '
        Me.数据备份ToolStripMenuItem.Name = "数据备份ToolStripMenuItem"
        Me.数据备份ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.数据备份ToolStripMenuItem.Text = "数据备份"
        '
        '数据还原ToolStripMenuItem
        '
        Me.数据还原ToolStripMenuItem.Name = "数据还原ToolStripMenuItem"
        Me.数据还原ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.数据还原ToolStripMenuItem.Text = "数据还原"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(883, 442)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "超市进销存管理系统"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents 员工信息ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 供应商信息ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 商品进货ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 商品查询ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 商品销售ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 商品退货ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 库存报警ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 库存查询ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 数据备份ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 数据还原ToolStripMenuItem As ToolStripMenuItem
End Class
