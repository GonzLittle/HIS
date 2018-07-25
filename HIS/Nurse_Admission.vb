Imports MySql.Data.MySqlClient
Imports MetroFramework

Public Class Nurse_Admission

    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Public Property stringpass As String
    Private Sub Employee_Confine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label9.Text = stringpass
        Label3.Text = DateTime.Now.ToLongDateString()
        Timer1.Start()
        BunifuImageButton4.Visible = False
        BunifuFlatButton6.selected = True
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "SELECT Patient_ID,Firstname,Lastname,Middleinitial,Dateofbirth,Age,Address,Phonenumber,Blood_type,Height,Format(Weight,1) as Weight,Format(Temperature,1) as Temperature,Blood_Pressure,Pulse_rate,Marital_status,Gender from patient_tbl"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "app_id")
        BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        BunifuCustomDataGrid1.Columns("Address").Width = 200
        BunifuCustomDataGrid1.Columns("Dateofbirth").Width = 150
        BunifuCustomDataGrid1.Columns("Phonenumber").Width = 150
        BunifuCustomDataGrid1.Columns("Blood_Pressure").Width = 150
        BunifuCustomDataGrid1.Columns("Marital_Status").Width = 150
        BunifuCustomDataGrid1.Columns("Temperature").Width = 150
        MysqlConn.Close()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from userlogs"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        DataGridView1.DataSource = dsa.Tables(0)
        Label5.Text = dsa.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()
        Timer1.Start()

    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Dim obj As New Nurse_Patient
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()

        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)
        Doctor_Checkup.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim obj As New Nurse_Billing
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()

        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs)
        Doctor_Lab.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim obj As New Nurse_Recordss
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()
        Me.Hide()
    End Sub
    Sub refreshdb()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Queryq As String = "SELECT Room_ID,Room_no,Format(Price,2) as Price,Status from roominfo_tbl"
        Dim adptq As New MySqlDataAdapter(Queryq, MysqlConn)
        Dim dsq As New DataSet()
        adptq.Fill(dsq, "app_id")
        Confineform.BunifuCustomDataGrid1.DataSource = dsq.Tables(0)
        Confineform.BunifuCustomDataGrid1.Columns("Room_ID").Width = 120
        Confineform.BunifuCustomDataGrid1.Columns("Price").Width = 130
        Confineform.BunifuCustomDataGrid1.Columns("Status").Width = 150
        MysqlConn.Close()
    End Sub
    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        refreshdb()
        If TextBox1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please choose patient record to be Confine", "Select", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim obj As New Confineform
            obj.stringpass1 = Login.MaterialSingleLineTextField1.Text
            obj.stringpass2 = TextBox1.Text
            obj.Show()
        End If
    End Sub

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("Patient_ID").Value.ToString
            Confineform.Label7.Text = row.Cells("Patient_ID").Value.ToString
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        BunifuFlatButton6.selected = True
        Panel9.Location = New Point(200, 132)
        Panel.Width = 52
        Panel.Visible = False
        PictureBox2.Visible = False
        panelanimator1.Show(Panel)
        BunifuImageButton4.Visible = True
        BunifuImageButton3.Visible = False
        Label1.Visible = False
        logoanimator.Hide(PictureBox2)
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        BunifuFlatButton6.selected = True
        Panel9.Location = New Point(270, 132)
        Panel.Width = 222
        Panel.Visible = False
        animator1.Show(Panel)
        BunifuImageButton4.Visible = False
        BunifuImageButton3.Visible = True
        Label1.Visible = True
        logoanimator.ShowSync(PictureBox2)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Select Case MetroMessageBox.Show(Me, "Are you sure to exit the application?", "LOG OUT.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            Case MsgBoxResult.Ok
                Login.Show()
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
            Query = "Update userlogs set id='" & Label5.Text & "',Time_out= '" & Label3.Text & "' where id = '" & Label5.Text & "'"
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


    Private Sub BunifuImageButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        BunifuFlatButton5.selected = True
        Panel9.Location = New Point(200, 132)
        Panel.Width = 52
        Panel.Visible = False
        PictureBox2.Visible = False
        panelanimator1.Show(Panel)
        BunifuImageButton4.Visible = True
        BunifuImageButton3.Visible = False
        Label1.Visible = False
        logoanimator.Hide(PictureBox2)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub
End Class