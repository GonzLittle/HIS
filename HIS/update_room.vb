Imports MySql.Data.MySqlClient
Public Class update_room
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=HIS"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update roominfo_tbl set Room_ID='" & TextBox1.Text & "',Room_no='" & MetroComboBox1.Text & "',Price='" & MaterialSingleLineTextField1.Text & "'  where Room_ID = '" & TextBox1.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
            Me.Hide()
            dbcall()
            MysqlConn.Close()
            MetroFramework.MetroMessageBox.Show(Me, "Successfully Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Admin_Roominfo.TextBox1.Clear()
        End Try

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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Admin_Roominfo.TextBox1.Clear()
        Me.Hide()
    End Sub
End Class