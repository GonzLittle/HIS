Imports MySql.Data.MySqlClient
Imports MetroFramework

Public Class Doctor_Patient
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Public Property stringpass As String
    Private Sub Doctor_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuImageButton4.Visible = False
        Label9.Text = stringpass
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
        Label4.Text = DateTime.Now.ToLongDateString()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        Me.Hide()
        Dim obj As New Doctor_Checkup
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Me.Hide()
        Dim obj As New Doctor_Lab
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()


    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Me.Hide()
        Dim obj As New Doctor_Records
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()


    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
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

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        BunifuFlatButton5.selected = True
        Panel9.Location = New Point(270, 132)
        Panel.Width = 222
        Panel.Visible = False
        animator1.Show(Panel)
        BunifuImageButton4.Visible = False
        BunifuImageButton3.Visible = True
        Label1.Visible = True
        logoanimator.ShowSync(PictureBox2)
    End Sub

    Private Sub BunifuMetroTextbox4_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox4.OnValueChanged
        Dim Santie As New MySqlDataAdapter
        Dim Pelayo As New DataTable
        Dim binding As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * from patient_tbl where CONCAT(Firstname,Lastname,Middleinitial,Dateofbirth,Age,Address,Phonenumber,Blood_type,Height,Weight,Temperature,Blood_Pressure,Pulse_rate,Marital_status,Gender) LIKE '%" & BunifuMetroTextbox4.Text & "%'"
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
            Query = "Update userlogs set id='" & Label8.Text & "',Time_out= '" & Label3.Text & "' where id = '" & Label8.Text & "'"
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

End Class