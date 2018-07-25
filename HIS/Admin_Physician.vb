Imports MySql.Data.MySqlClient
Imports Bunifu.Framework.Lib
Imports MetroFramework
Public Class Admin_Physician
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub Admin_Physician_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuImageButton3.Visible = False
        BunifuFlatButton4.selected = True
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from userlogs"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        DataGridView1.DataSource = dsa.Tables(0)
        Label7.Text = dsa.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()
        Timer1.Start()
        BunifuImageButton3.Visible = False
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "select Doctor_Name,Address,Phonenumber,Email,Department from doctor_tbl"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "app_id")
        BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        Mainform.Label9.Text = ds.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        BunifuFlatButton3.selected = True
        Panel9.Location = New Point(277, 117)
        Panel.Width = 222
        Panel.Visible = False
        animator1.Show(Panel)
        BunifuImageButton3.Visible = False
        BunifuImageButton2.Visible = True
        Label1.Visible = True
        logoanimator.ShowSync(PictureBox1)
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

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        Add_New_Physician.Show()
    End Sub

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
      
    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        If TextBox1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please choose physician record to be update", "Select", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        else
            update_physician.Show()
        End If
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Mainform.Show()
        Me.Hide()
    
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Admin_Billing.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)
        Admin_Roominfo.Show()        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Admin_Patient.Show()        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton11_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton11.Click
        Admin_Add_Accounts.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs)
        Admin_Reports.Show()        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs)
        Admin_Userlog.Show()        Me.Hide()
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
            Query = "Update userlogs set id='" & Label7.Text & "',Time_out= '" & Label13.Text & "' where id = '" & Label7.Text & "'"
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label13.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub BunifuFlatButton2_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Admin_Labinfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton6_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Admin_Userlog.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton12_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton12.Click
        Admin_Roominfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuCustomDataGrid1_CellClick1(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid1.Rows(e.RowIndex)
      
            update_physician.MaterialSingleLineTextField1.Text = row.Cells("Doctor_Name").Value.ToString
            update_physician.MaterialSingleLineTextField2.Text = row.Cells("Address").Value.ToString
            update_physician.MaterialSingleLineTextField3.Text = row.Cells("Phonenumber").Value.ToString
            update_physician.MaterialSingleLineTextField4.Text = row.Cells("Email").Value.ToString
            update_physician.MetroComboBox1.Text = row.Cells("Department").Value.ToString
        End If
    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick

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
            MetroFramework.MetroMessageBox.Show(Me, "Successfully Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class