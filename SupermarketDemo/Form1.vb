Public Class Form1
    Private Sub Tb_EmpInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tb_EmpInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TestDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“TestDataSet.tb_EmpInfo”中。您可以根据需要移动或删除它。
        Me.Tb_EmpInfoTableAdapter.Fill(Me.TestDataSet.tb_EmpInfo)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim EmpLoginName As String
        Dim EmpLoginPwd As String

        EmpLoginName = TextBox1.Text
        EmpLoginPwd = TextBox2.Text

        If Me.Tb_EmpInfoTableAdapter.ScalarQueryLogin(EmpLoginName, EmpLoginPwd) Then

            MessageBox.Show("太不容易了- -。")
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("不对不对不对！！！")
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If
    End Sub
End Class
