Imports MySql.Data.MySqlClient
Imports System.IO
Imports MetroFramework

Public Class Admin_Add_Accounts
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim cn As New MySqlConnection("Server=127.0.0.1; User ID=root;Password=; Database=HIS")
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)
        Admin_Billing.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)
        Admin_Roominfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs)
        Admin_Patient.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Mainform.Show()
        Me.Hide()
    End Sub
    Private Sub BunifuFlatButton1_Click_1(sender As Object, e As EventArgs)
        Admin_Billing.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click_1(sender As Object, e As EventArgs)
        Admin_Roominfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton3_Click_1(sender As Object, e As EventArgs)
        Admin_Patient.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        BunifuFlatButton4.selected = True
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
    Private Sub BunifuFlatButton3_Click_2(sender As Object, e As EventArgs)
        Mainform.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click_2(sender As Object, e As EventArgs)
        Admin_Billing.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs)
        Admin_Roominfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs)
        Admin_Patient.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)
        Mainform.Show()
        Me.Hide()
    End Sub

    Private Sub Admin_Physician_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuFlatButton4.selected = True
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from userlogs"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        DataGridView1.DataSource = dsa.Tables(0)
        Label3.Text = dsa.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()
        Timer1.Start()
        BunifuImageButton3.Visible = False
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "select * from user_accounts"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        Dim table As New DataTable()
        adpt.Fill(ds, "id")
        BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        Mainform.Label16.Text = ds.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()
    End Sub

    Private Sub BunifuFlatButton3_Click_3(sender As Object, e As EventArgs)
        Mainform.Show()
    End Sub

    Private Sub BunifuFlatButton3_Click_4(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Mainform.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuFlatButton2_Click_3(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Admin_Billing.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs)
        Admin_Roominfo.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuFlatButton8_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        Admin_Patient.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Add_Account.Show()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        If TextBox1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Select Account to be Update!", "Select Account", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            update_account.Show()
        End If
    End Sub

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        Dim table As New DataTable()
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("id").Value.ToString
            update_account.TextBox1.Text = row.Cells("id").Value.ToString
            update_account.MaterialSingleLineTextField1.Text = row.Cells("Firstname").Value.ToString
            update_account.MaterialSingleLineTextField2.Text = row.Cells("Lastname").Value.ToString
            update_account.MaterialSingleLineTextField3.Text = row.Cells("Address").Value.ToString
            update_account.MaterialSingleLineTextField4.Text = row.Cells("Phone_Number").Value.ToString
            update_account.MaterialSingleLineTextField5.Text = row.Cells("Email").Value.ToString
            update_account.MaterialSingleLineTextField6.Text = row.Cells("Username").Value.ToString
            update_account.MaterialSingleLineTextField7.Text = row.Cells("Password").Value.ToString
            update_account.MetroComboBox1.Text = row.Cells("User_Type").Value.ToString
            Me.TextBox2.Text = row.Cells("User_Type").Value.ToString
        End If
    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick

    End Sub

    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs)
        Admin_Reports.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
        Select Case MetroMessageBox.Show(Me, "Are you sure to exit the application?", "LOG OUT.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            Case MsgBoxResult.Ok
                Login.Show()
                UpdateStatus()
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
            Query = "Update userlogs set id='" & Label3.Text & "',Time_out= '" & Label13.Text & "' where id = '" & Label3.Text & "'"
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

    Private Sub BunifuFlatButton1_Click_2(sender As Object, e As EventArgs)
        Admin_Userlog.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label13.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub BunifuFlatButton9_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        If TextBox2.Text = "ADMIN" Then
            MetroFramework.MetroMessageBox.Show(Me, "Warning cannot be deleted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TextBox2.Text = "NURSE" Then
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString =
                "server=localhost;userid=root;password=;database=HIS"
            Dim READER As MySqlDataReader

            Try
                MysqlConn.Open()
                Dim query As String
                query = "Delete from user_accounts where id = '" & TextBox1.Text & "'"
                MetroFramework.MetroMessageBox.Show(Me, "Successfully Deleted! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Command = New MySqlCommand(query, MysqlConn)
                automatic()
                READER = Command.ExecuteReader
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Sub automatic()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from user_accounts"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        BunifuCustomDataGrid1.DataSource = dsa.Tables(0)
        MysqlConn.Close()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        BunifuFlatButton4.selected = True
        Panel9.Location = New Point(277, 117)
        Panel.Width = 222
        Panel.Visible = False
        animator1.Show(Panel)
        BunifuImageButton3.Visible = False
        BunifuImageButton2.Visible = True
        Label1.Visible = True
        logoanimator.ShowSync(PictureBox1)
    End Sub
    Private Sub BunifuFlatButton11_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton11.Click
        Admin_Physician.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click_3(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Admin_Labinfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton7_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        Admin_Userlog.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton13_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton13.Click
        Admin_Roominfo.Show()
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