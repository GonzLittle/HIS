Imports MySql.Data.MySqlClient
Imports MetroFramework
Public Class Admin_Userlog
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Mainform.Show()
        Me.Hide()
    End Sub

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

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs)
        Admin_Reports.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        BunifuFlatButton8.selected = True
        Panel9.Location = New Point(200, 117)
        Panel.Width = 52
        Panel.Visible = False
        PictureBox1.Visible = False
        panelanimator1.Show(Panel)
        BunifuImageButton3.Visible = True
        BunifuImageButton2.Visible = False
        Label4.Visible = False
        logoanimator.Hide(PictureBox1)
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        BunifuFlatButton8.selected = True
        Panel9.Location = New Point(277, 117)
        Panel.Width = 222
        Panel.Visible = False
        animator1.Show(Panel)
        BunifuImageButton3.Visible = False
        BunifuImageButton2.Visible = True
        Label4.Visible = True
        logoanimator.ShowSync(PictureBox1)
    End Sub

    Private Sub Admin_Userlog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        BunifuFlatButton8.selected = True
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "select * from Userlogs"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "app_id")
        BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        MysqlConn.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label13.Text = TimeOfDay.ToString("h:mm:ss tt")
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

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        Admin_Physician.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Admin_Labinfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton12_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton12.Click
        Admin_Roominfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton6_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Admin_Reports.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        PrintDocument1.DefaultPageSettings.PaperSize = New Printing.PaperSize("Legal", 850, 1400)
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintDocument1.Print()
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(BunifuCustomDataGrid1.Width, BunifuCustomDataGrid1.Height)
        BunifuCustomDataGrid1.DrawToBitmap(bm, New Rectangle(10, 10, BunifuCustomDataGrid1.Width, BunifuCustomDataGrid1.Height))
        e.Graphics.DrawImage(bm, 10, 10)
        Dim aps As New PageSetupDialog
        aps.Document = PrintDocument1
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