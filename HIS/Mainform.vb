Imports MySql.Data.MySqlClient
Imports MetroFramework
Public Class Mainform
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Admin_Billing.Show()
        Me.Hide()
    End Sub
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)
        Admin_Roominfo.Show()
        Me.Hide()
    End Sub
    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Admin_Patient.Show()
        Me.Hide()
    End Sub
    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Admin_Add_Accounts.Show()
        Me.Hide()
    End Sub
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        BunifuFlatButton5.selected = True
        Panel9.Location = New Point(200, 117)
        Panel.Width = 52
        Panel.Visible = False
        PictureBox1.Visible = False
        panelanimator1.Show(Panel)
        BunifuImageButton3.Visible = True
        BunifuImageButton2.Visible = False
        Label1.Visible = False
        logoanimator.Hide(PictureBox1)
    End Sub
    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuFlatButton5.selected = True
        Label22.Text = DateTime.Now.ToLongDateString()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from userlogs"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        DataGridView1.DataSource = dsa.Tables(0)
        Label12.Text = dsa.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()
        Timer1.Start()



        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim qwe As String = "select * from invoice_tbl"
        Dim adpte As New MySqlDataAdapter(qwe, MysqlConn)
        Dim dse As New DataSet()
        adpte.Fill(dse, "app_id")
        Label27.Text = dse.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim qwa As String = "select * from confine_tbl"
        Dim adp As New MySqlDataAdapter(qwa, MysqlConn)
        Dim d As New DataSet()
        adp.Fill(d, "app_id")
        Label26.Text = d.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()



        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim qw As String = "select * from checkup"
        Dim ad As New MySqlDataAdapter(qw, MysqlConn)
        Dim dee As New DataSet()
        ad.Fill(dee, "app_id")
        Label28.Text = dee.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()

        Label11.Text = Val(Label26.Text) + Val(Label27.Text) + Val(Label28.Text)



        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "select * from patient_tbl"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "app_id")
        Admin_Patient.BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        Label9.Text = ds.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query1 As String = "select * from doctor_tbl"
        Dim adpt1 As New MySqlDataAdapter(Query1, MysqlConn)
        Dim ds1 As New DataSet()
        adpt1.Fill(ds1, "app_id")
        Admin_Physician.BunifuCustomDataGrid1.DataSource = ds1.Tables(0)
        Label14.Text = ds1.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query3 As String = "select * from user_accounts"
        Dim adpt3 As New MySqlDataAdapter(Query3, MysqlConn)
        Dim ds3 As New DataSet()
        adpt3.Fill(ds3, "app_id")
        Admin_Add_Accounts.BunifuCustomDataGrid1.DataSource = ds3.Tables(0)
        Label16.Text = ds3.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()
        BunifuImageButton3.Visible = False
    End Sub
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        BunifuFlatButton5.selected = True
        Panel9.Location = New Point(277, 117)
        Panel.Width = 222
        Panel.Visible = False
        animator1.Show(Panel)
        BunifuImageButton3.Visible = False
        BunifuImageButton2.Visible = True
        Label1.Visible = True
        logoanimator.ShowSync(PictureBox1)
    End Sub
    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
        Select Case MetroMessageBox.Show(Me, "Are you sure to exit the application?", "LOG OUT.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            Case MsgBoxResult.Ok
                Login.Show()
                updatestatus()
                Login.MaterialSingleLineTextField1.Clear()
                Login.MaterialSingleLineTextField2.Clear()
                Me.Hide()
            Case MsgBoxResult.Cancel
        End Select
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=HIS"
        Dim Reader As MySqlDataReader


        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update userlogs set id='" & Label12.Text & "',Time_out= '" & Label10.Text & "' where id = '" & Label12.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
            MysqlConn.Close()
        End Try
    End Sub

    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs)
        Admin_Reports.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs)
        Admin_Userlog.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub



    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Admin_Patient.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs)
        Admin_Roominfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        Admin_Billing.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton8_Click(sender As Object, e As EventArgs) Handles BunifuImageButton8.Click
        Admin_Physician.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        Admin_Physician.Show()
        Me.Hide()
    End Sub



    Private Sub BunifuFlatButton2_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
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

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        Admin_Add_Accounts.Show()
        Me.Hide()
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub

    Private Sub BunifuFlatButton7_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        Admin_Total.Show()
        Me.Hide()

    End Sub
    Sub updatestatus()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=HIS"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update user_accounts set id='" & Label30.Text & "',Status='" & Label29.Text & "'  where id = '" & Label30.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
            Me.Hide()
            MysqlConn.Close()

        End Try
    End Sub
End Class