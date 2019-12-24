Imports System.Data.SqlClient

Public Class Form201


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub Form201_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“TestDataSet.tb_EmpInfo”中。您可以根据需要移动或删除它。
        Me.Tb_EmpInfoTableAdapter.Fill(Me.TestDataSet.tb_EmpInfo)


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.SelectedRows(1).Cells(2).Value.ToString()
        ComboBox1.Text = DataGridView1.SelectedRows(1).Cells(3).Value.ToString()
        ComboBox3.Text = DataGridView1.SelectedRows(1).Cells(4).Value.ToString()
        ComboBox2.Text = DataGridView1.SelectedRows(1).Cells(5).Value.ToString()
        TextBox4.Text = DataGridView1.SelectedRows(1).Cells(6).Value.ToString()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connStr As String
        connStr = String.Format("server={0};user id={1}; password={2};pooling=false", "localhost", "root", "123456")
        Try
            Dim Conn As New SqlConnection(connStr)
            Conn.Open()
            Dim sql As String = "insert into Emplnfo(EmpId，EmpName,EmpSex,EmpBirthday)values('& TextBox1.Text & ''& TextBox2.Text & ''& TextBox4.Text & ''& TextBox5.Text & ')"
            Dim sqlcmd As New SqlCommand(sql, Conn)
            sqlcmd.ExecuteScalar()
            Conn.Close()
            MessageBox.Show("插入成功！")
        Catch ex As SqlException 'try执行过程中发生错误就会提示'
            'MessageBox.Show(ex.ToString)
            MessageBox.Show("程序出现错误！请重启，或联系维护人员。", "抱歉")
        Finally
            Me.Close()
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox5.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox6.Text = ""
    End Sub
End Class