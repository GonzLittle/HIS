Imports MySql.Data.MySqlClient
Imports MetroFramework
Public Class Nurse_Patient
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Public Property stringpass As String
    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs)
        ffff.Show()
    End Sub
    Private Sub Employee_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label9.Text = stringpass
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from userlogs"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        DataGridView1.DataSource = dsa.Tables(0)
        Label8.Text = dsa.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()
        Timer1.Start()
        BunifuImageButton4.Visible = False
        BunifuFlatButton5.selected = True
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

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)
        Doctor_Checkup.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)
        Nurse_Billing.Show()
        Me.Hide()
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

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid1.Rows(e.RowIndex)
            TextBox2.Text = row.Cells("Patient_ID").Value.ToString
            PatientPrint.Label32.Text = row.Cells("Patient_ID").Value.ToString
            PatientPrint.Firstname.Text = row.Cells("Firstname").Value.ToString
            PatientPrint.Lastname.Text = row.Cells("Lastname").Value.ToString
            PatientPrint.Middle.Text = row.Cells("Middleinitial").Value.ToString
            PatientPrint.dob.Text = row.Cells("Dateofbirth").Value.ToString
            PatientPrint.age.Text = row.Cells("Age").Value.ToString
            PatientPrint.Address.Text = row.Cells("Address").Value.ToString
            PatientPrint.Phonenumber.Text = row.Cells("Phonenumber").Value.ToString
            PatientPrint.Bloodtype.Text = row.Cells("Blood_Type").Value.ToString
            PatientPrint.Height.Text = row.Cells("Height").Value.ToString
            PatientPrint.Weight.Text = row.Cells("Weight").Value.ToString
            PatientPrint.Temperature.Text = row.Cells("Temperature").Value.ToString
            PatientPrint.bloodpressure.Text = row.Cells("Blood_Pressure").Value.ToString
            PatientPrint.pulserate.Text = row.Cells("Pulse_rate").Value.ToString
            PatientPrint.Marital.Text = row.Cells("Marital_Status").Value.ToString
            PatientPrint.Gender.Text = row.Cells("Gender").Value.ToString
        End If
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("Patient_ID").Value.ToString
            ffff.TextBox1.Text = row.Cells("Patient_ID").Value.ToString
            ffff.MaterialSingleLineTextField1.Text = row.Cells("Firstname").Value.ToString
            ffff.MaterialSingleLineTextField2.Text = row.Cells("Lastname").Value.ToString
            ffff.MaterialSingleLineTextField3.Text = row.Cells("Middleinitial").Value.ToString
            ffff.MetroDateTime1.Text = row.Cells("Dateofbirth").Value.ToString
            ffff.MaterialSingleLineTextField4.Text = row.Cells("Age").Value.ToString
            ffff.MaterialSingleLineTextField5.Text = row.Cells("Address").Value.ToString
            ffff.MaterialSingleLineTextField6.Text = row.Cells("Phonenumber").Value.ToString
            ffff.MaterialSingleLineTextField7.Text = row.Cells("Blood_Type").Value.ToString
            ffff.MaterialSingleLineTextField8.Text = row.Cells("Height").Value.ToString
            ffff.MaterialSingleLineTextField9.Text = row.Cells("Weight").Value.ToString
            ffff.MaterialSingleLineTextField10.Text = row.Cells("Temperature").Value.ToString
            ffff.MaterialSingleLineTextField11.Text = row.Cells("Blood_Pressure").Value.ToString
            ffff.MaterialSingleLineTextField12.Text = row.Cells("Pulse_rate").Value.ToString
            ffff.MetroComboBox1.Text = row.Cells("Marital_Status").Value.ToString
            ffff.MetroComboBox2.Text = row.Cells("Gender").Value.ToString
        End If
    End Sub
    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        If TextBox2.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please choose patient record to be update", "Select", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ffff.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub
    Private Sub BunifuFlatButton2_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim obj As New Nurse_Billing
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click_1(sender As Object, e As EventArgs)
        Doctor_Checkup.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs)
        Doctor_Lab.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton4_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
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


    Private Sub BunifuFlatButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim obj As New Nurse_Recordss
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Add_New_Patient.Show()
    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick

    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        Dim obj As New Nurse_Admission
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton7_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        If TextBox2.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please choose patient record to be print", "Select", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            PatientPrint.Show()
        End If
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click

    End Sub

    Private Sub BunifuFlatButton1_Click_2(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
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
    End Sub
End Class