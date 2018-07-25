Imports MySql.Data.MySqlClient
Imports MetroFramework
Public Class Add_Room
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()

            Dim Sql As String
            Sql = "Insert into roominfo_tbl (Room_no,Price) values ('" & MetroComboBox1.Text & "','" & MaterialSingleLineTextField1.Text & "')"

            Command = New MySqlCommand(Sql, MysqlConn)
            READER = Command.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MysqlConn.Close()
        Me.Hide()
        MetroFramework.MetroMessageBox.Show(Me, "Successfully Saved.", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        dbcall()
    End Sub
    Sub dbcall()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query1 As String = "select Room_ID,Room_no,Format(Price,2) as Price from roominfo_tbl"
        Dim adpt1 As New MySqlDataAdapter(Query1, MysqlConn)
        Dim ds1 As New DataSet()
        adpt1.Fill(ds1, "id")
        Admin_Roominfo.BunifuCustomDataGrid1.DataSource = ds1.Tables(0)
        MysqlConn.Close()
    End Sub
End Class
