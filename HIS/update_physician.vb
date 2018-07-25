Imports MySql.Data.MySqlClient

Public Class update_physician
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=HIS"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update doctor_tbl set Doctor_ID='" & TextBox1.Text & "',Doctor_Name='" & MaterialSingleLineTextField1.Text & "',Address='" & MaterialSingleLineTextField2.Text & "' ,Phonenumber='" & MaterialSingleLineTextField3.Text & "',Email='" & MaterialSingleLineTextField4.Text & "',Department='" & MetroComboBox1.Text & "' where Doctor_ID = '" & TextBox1.Text & "'"
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
        End Try
    End Sub
    Sub dbcall()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query1 As String = "select Doctor_Name,Address,Phonenumber,Email,Department from doctor_tbl"
        Dim adpt1 As New MySqlDataAdapter(Query1, MysqlConn)
        Dim ds1 As New DataSet()
        adpt1.Fill(ds1, "id")
        Admin_Physician.BunifuCustomDataGrid1.DataSource = ds1.Tables(0)
        MysqlConn.Close()
    End Sub
End Class