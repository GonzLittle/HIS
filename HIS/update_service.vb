Imports MySql.Data.MySqlClient

Public Class update_service
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=HIS"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update labinfo_tbl set Lab_ID='" & MaterialSingleLineTextField1.Text & "',Labservice_Name='" & MaterialSingleLineTextField2.Text & "',Lab_Fee='" & MaterialSingleLineTextField3.Text & "'  where Lab_ID = '" & MaterialSingleLineTextField1.Text & "'"
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
        Dim Query1 As String = "select Lab_ID,Labservice_Name,Format(Lab_Fee,2) as Lab_Fee from labinfo_tbl"
        Dim adpt1 As New MySqlDataAdapter(Query1, MysqlConn)
        Dim ds1 As New DataSet()
        adpt1.Fill(ds1, "id")
        Admin_Labinfo.BunifuCustomDataGrid1.DataSource = ds1.Tables(0)
        MysqlConn.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Admin_Labinfo.TextBox1.Clear()
        Me.Hide()
    End Sub

    Private Sub update_service_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialSingleLineTextField1.Enabled = False
    End Sub
End Class