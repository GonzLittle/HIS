Imports MySql.Data.MySqlClient

Public Class Admin_Total
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Try
            Dim bs As New BindingSource
            bs.DataSource = BunifuCustomDataGrid1.DataSource
            bs.Filter = String.Format("Date >= #{0:yyyy/MM/dd}# And Date <= #{1:yyyy/MM/dd}#", DateTimePicker1.Value, DateTimePicker2.Value)
            BunifuCustomDataGrid1.DataSource = bs

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        MysqlConn.Close()

        Dim total As String = 0
        For i As Integer = 0 To BunifuCustomDataGrid1.RowCount - 1
            total += BunifuCustomDataGrid1.Rows(i).Cells(2).Value

        Next
        Label6.Text = total
    End Sub
    Private Sub Admin_Total_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from invoice_tbl"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        BunifuCustomDataGrid1.DataSource = dsa.Tables(0)
        MysqlConn.Close()
    End Sub

    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime1.ValueChanged
        Format(MetroDateTime1.Value, "yyyy-MM-dd")
    End Sub

    Private Sub MetroDateTime2_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime2.ValueChanged
        Format(MetroDateTime2.Value, "yyyy-MM-dd")
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Admin_Labinfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Admin_Userlog.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton12_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton12.Click
        Admin_Roominfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click

    End Sub
End Class