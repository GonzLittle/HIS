Imports MySql.Data.MySqlClient
Imports DGV2Printer
Imports System.Drawing.Printing
Imports System.IO
Imports MetroFramework
Public Class Admin_Roominfo
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        BunifuFlatButton2.selected = True
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

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs)
        BunifuFlatButton2.selected = True
        Panel9.Location = New Point(277, 117)
        Panel.Width = 222
        Panel.Visible = False
        animator1.Show(Panel)
        BunifuImageButton3.Visible = False
        BunifuImageButton2.Visible = True
        Label1.Visible = True
        logoanimator.ShowSync(PictureBox1)
    End Sub

    Private Sub Admin_Roominfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuFlatButton13.selected = True
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query1 As String = "select Room_ID,Room_no,Format(Price,2) as Price from roominfo_tbl"
        Dim adpt1 As New MySqlDataAdapter(Query1, MysqlConn)
        Dim ds1 As New DataSet()
        adpt1.Fill(ds1, "id")
        BunifuCustomDataGrid1.DataSource = ds1.Tables(0)
        MysqlConn.Close()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from userlogs"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        DataGridView1.DataSource = dsa.Tables(0)
        Label6.Text = dsa.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()
        Timer1.Start()
        BunifuImageButton3.Visible = False



    End Sub

    Private Sub BunifuImageButton3_Click_1(sender As Object, e As EventArgs)
        BunifuFlatButton2.selected = True
        Panel9.Location = New Point(277, 117)
        Panel.Width = 222
        Panel.Visible = False
        animator1.Show(Panel)
        BunifuImageButton3.Visible = False
        BunifuImageButton2.Visible = True
        Label1.Visible = True
        logoanimator.ShowSync(PictureBox1)
    End Sub

    Private Sub BunifuFlatButton5_Click_1(sender As Object, e As EventArgs)
        Mainform.Show()
        Me.Hide()
        Dim total As String = 0
        For i As Integer = 0 To Admin_Billing.BunifuCustomDataGrid1.RowCount - 1
            total += Admin_Billing.BunifuCustomDataGrid1.Rows(i).Cells(9).Value
            'Change the number 2 to your column index number (The first column has a 0 index column)
            'In this example the column index of Price is 2
        Next
        Mainform.Label18.Text = total
    End Sub

    Private Sub BunifuFlatButton1_Click_1(sender As Object, e As EventArgs)
        Admin_Billing.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton3_Click_1(sender As Object, e As EventArgs)
        Admin_Patient.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton4_Click_1(sender As Object, e As EventArgs)
        Admin_Add_Accounts.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        If TextBox1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please choose room to update", "Select Room", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            update_room.Show()
        End If
    End Sub
    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs)
        Admin_Reports.Show()
        Me.Hide()
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
            Query = "Update userlogs set id='" & Label6.Text & "',Time_out= '" & Label13.Text & "' where id = '" & Label6.Text & "'"
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

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs)
        Admin_Userlog.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label13.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub BunifuFlatButton11_Click(sender As Object, e As EventArgs)
        Admin_Physician.Show()
        Me.Hide()
    End Sub


    Private Sub BunifuFlatButton6_Click_1(sender As Object, e As EventArgs)
        Admin_Labinfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        Add_Room.Show()
    End Sub

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("Room_ID").Value.ToString
            update_room.TextBox1.Text = row.Cells("Room_ID").Value.ToString
            update_room.MetroComboBox1.Text = row.Cells("Room_no").Value.ToString
            update_room.MaterialSingleLineTextField1.Text = row.Cells("Price").Value.ToString
        End If
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs)
        Admin_Userlog.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton3_Click_2(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Mainform.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Admin_Billing.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton5_Click_2(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Admin_Patient.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton4_Click_2(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Admin_Add_Accounts.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton11_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton11.Click
        Admin_Physician.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click_2(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Admin_Labinfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton10_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton10.Click
        Admin_Reports.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton7_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        Admin_Userlog.Show()
        Me.Hide()
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