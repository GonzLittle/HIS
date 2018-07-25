Imports MySql.Data.MySqlClient
Imports MetroFramework

Public Class Admin_Labinfo

    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub Panel_Paint(sender As Object, e As PaintEventArgs) Handles Panel.Paint

    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Mainform.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Admin_Billing.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Admin_Patient.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Admin_Add_Accounts.Show()        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        Admin_Physician.Show()        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Admin_Reports.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        Admin_Userlog.Show()
        Me.Hide()
    End Sub

    Private Sub Admin_Labinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "select * from labinfo_tbl"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "app_id")
        BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        BunifuCustomDataGrid1.Columns("Lab_ID").Width = 150
        BunifuCustomDataGrid1.Columns("Labservice_Name").Width = 350
        BunifuCustomDataGrid1.Columns("Lab_fee").Width = 150
        Mainform.Label11.Text = ds.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        BunifuFlatButton1.selected = True
        Panel9.Location = New Point(277, 117)
        Panel.Width = 222
        Panel.Visible = False
        animator1.Show(Panel)
        BunifuImageButton3.Visible = False
        BunifuImageButton2.Visible = True
        Label4.Visible = True
        logoanimator.ShowSync(PictureBox2)
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        BunifuFlatButton1.selected = True
        Panel9.Location = New Point(200, 117)
        Panel.Width = 52
        Panel.Visible = False
        PictureBox2.Visible = False
        panelanimator1.Show(Panel)
        BunifuImageButton3.Visible = True
        BunifuImageButton2.Visible = False
        Label4.Visible = False
        logoanimator.Hide(PictureBox2)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label13.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        Addnew_Lab.Show()
        Addnew_Lab.MaterialSingleLineTextField1.Text = BunifuCustomDataGrid1.Item("Lab_ID", Me.BunifuCustomDataGrid1.Rows.Count - 1).Value.ToString() + 1
    End Sub

    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton10.Click
        If TextBox1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Select Service to Update!", "Select Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            update_service.Show()
        End If
    End Sub

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("Lab_ID").Value.ToString
            update_service.MaterialSingleLineTextField1.Text = row.Cells("Lab_ID").Value.ToString
            update_service.MaterialSingleLineTextField2.Text = row.Cells("Labservice_Name").Value.ToString
            update_service.MaterialSingleLineTextField3.Text = row.Cells("Lab_Fee").Value.ToString
        End If
    End Sub


    Private Sub BunifuFlatButton12_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton12.Click
        Admin_Roominfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton11_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton11.Click
        If TextBox1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Select Service to Delete!", "Select Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim reader As MySqlDataReader
            Dim conn As MySqlConnection
            conn = New MySqlConnection
            conn.ConnectionString =
                "server=localhost;userid=root;password=;database=HIS"
            Try
                conn.Open()
                Dim query As String
                query = "Delete from labinfo_tbl where Lab_ID = '" & TextBox1.Text & "'"
                Command = New MySqlCommand(query, conn)
                reader = Command.ExecuteReader
                MetroFramework.MetroMessageBox.Show(Me, "Successfully Delete!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                automatic()
                conn.Close()
            Catch ex As Exception
                MsgBox("ERROR NA")
            Finally
                conn.Dispose()
            End Try
        End If
    End Sub
    Sub automatic()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from labinfo_tbl"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        BunifuCustomDataGrid1.DataSource = dsa.Tables(0)
        MysqlConn.Close()
    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.OnValueChanged
        Dim Santie As New MySqlDataAdapter
        Dim Pelayo As New DataTable
        Dim binding As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * from labinfo_tbl where CONCAT(Lab_ID,Labservice_Name,Lab_Fee) LIKE '%" & BunifuMetroTextbox1.Text & "%'"
            Command = New MySqlCommand(Query, MysqlConn)
            Santie.SelectCommand = Command
            Santie.Fill(Pelayo)
            binding.DataSource = Pelayo
            BunifuCustomDataGrid1.DataSource = binding
            Santie.Update(Pelayo)
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
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