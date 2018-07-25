Imports MySql.Data.MySqlClient

Public Class Addnew_Lab
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim READER As MySqlDataReader

        Try

            MysqlConn.Open()

            Dim Sql As String
            Sql = "Insert into labinfo_tbl (Lab_Id,Labservice_Name,Lab_Fee) values ('" & MaterialSingleLineTextField1.Text & "','" & MaterialSingleLineTextField2.Text & "','" & MaterialSingleLineTextField3.Text & "')"

            Command = New MySqlCommand(Sql, MysqlConn)
            READER = Command.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Hide()
        medicinedatabase()
        labtest()
        MysqlConn.Close()
        MetroFramework.MetroMessageBox.Show(Me, "Successfully Added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MaterialSingleLineTextField2.Clear()
        MaterialSingleLineTextField3.Clear()
    End Sub
    Sub medicinedatabase()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "select * from labinfo_tbl"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "id")
        Admin_Labinfo.BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        MysqlConn.Close()
    End Sub
    Sub labtest()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query1 As String = "select * from labinfo_tbl"
        Dim adpt1 As New MySqlDataAdapter(Query1, MysqlConn)
        Dim ds1 As New DataSet()
        adpt1.Fill(ds1, "id")
        Laboratory.BunifuCustomDataGrid1.DataSource = ds1.Tables(0)
        MysqlConn.Close()
    End Sub

    Private Sub Addnew_Lab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialSingleLineTextField1.Enabled = False
    End Sub

    Private Sub MaterialSingleLineTextField1_Click(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField1.Click

    End Sub
End Class