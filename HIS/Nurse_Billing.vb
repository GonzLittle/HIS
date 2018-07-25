Imports MySql.Data.MySqlClient
Imports MetroFramework
Public Class Nurse_Billing
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Public Property stringpass As String
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)
        Doctor_Checkup.Show()
        Me.Hide()
    End Sub

    Private Sub Employee_Biling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label11.Text = stringpass
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from userlogs"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        DataGridView1.DataSource = dsa.Tables(0)
        Label4.Text = dsa.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "SELECT Invoice_No,Patient_ID,Format(Total_Amount,2) as Total_Amount,Format(Discount,2) as Discount,Format(Total_Charges,2) as Total_Charges,Format(Amount_Tendered,2) as Amount_Tendered,Format(Amount_Change,2) as Amount_Change,Date,Payment_Status,Doctor,Process_by from invoice_tbl"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "app_id")
        BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        BunifuCustomDataGrid1.Columns("Total_Amount").Width = 150
        BunifuCustomDataGrid1.Columns("Discount").Width = 150
        BunifuCustomDataGrid1.Columns("Total_Charges").Width = 150
        BunifuCustomDataGrid1.Columns("Amount_Tendered").Width = 150
        BunifuCustomDataGrid1.Columns("Amount_Change").Width = 150
        BunifuCustomDataGrid1.Columns("Date").Width = 130
        BunifuCustomDataGrid1.Columns("Payment_Status").Width = 150
        BunifuCustomDataGrid1.Columns("Doctor").Width = 150
        BunifuCustomDataGrid1.Columns("Process_by").Width = 150


        MysqlConn.Close()


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Quer1 As String = "SELECT Confine_ID,Patient_ID,Room_ID,Findings,Status_of_Deceased,Format(Total_Amount,2) as Total_Amount,Format(Additional_Charges,2) as Additional_Charges,Format(Discount,2) as Discount,Format(Total_Charges,2) as Total_Charges,Format(Amount_Tendered,2) as Amount_Tendered,Format(Amount_Change,2) as Amount_Change,Time_In,Time_Out,Date,Remarks,Processby from confine_tbl"
        Dim adp1 As New MySqlDataAdapter(Quer1, MysqlConn)
        Dim ds1 As New DataSet()
        adp1.Fill(ds1, "Confine_ID")
        BunifuCustomDataGrid3.DataSource = ds1.Tables(0)
        BunifuCustomDataGrid3.Columns("Status_of_Deceased").Width = 200
        BunifuCustomDataGrid3.Columns("Findings").Width = 250
        BunifuCustomDataGrid3.Columns("Total_Amount").Width = 150
        BunifuCustomDataGrid3.Columns("Additional_Charges").Width = 250
        BunifuCustomDataGrid3.Columns("Discount").Width = 120
        BunifuCustomDataGrid3.Columns("Total_Charges").Width = 150
        BunifuCustomDataGrid3.Columns("Amount_Tendered").Width = 150
        BunifuCustomDataGrid3.Columns("Amount_Change").Width = 150
        BunifuCustomDataGrid3.Columns("Time_In").Width = 150
        BunifuCustomDataGrid3.Columns("Time_Out").Width = 150
        BunifuCustomDataGrid3.Columns("Date").Width = 150
        BunifuCustomDataGrid3.Columns("Processby").Width = 150
        MysqlConn.Close()


        Timer1.Start()
        BunifuImageButton4.Visible = False
        BunifuFlatButton2.selected = True
        Label3.Text = DateTime.Now.ToLongDateString()
        Timer1.Start()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query1 As String = "SELECT Reference_ID,PatientID,Findings,Prescribe_Medicine,Treatment,Prescribed_by,Schedule_of_Checkup,Format(Consultation_Fee,2) as Consultation_Fee,Format(Additional_Charges,2) as Additional_Charges,Format(Total_Due,2) as Total_Due,Format(Amount_Payment,2) as Amount_Payment,Format(Change_Amount,2) as Change_Amount,Status,Process_by,Time,Date from checkup"
        Dim adpt1 As New MySqlDataAdapter(Query1, MysqlConn)
        Dim ds2 As New DataSet()
        adpt1.Fill(ds2, "app_id")
        BunifuCustomDataGrid2.DataSource = ds2.Tables(0)
        MysqlConn.Close()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        BunifuFlatButton2.selected = True
        Panel3.Location = New Point(200, 132)
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
        BunifuFlatButton2.selected = True
        Panel3.Location = New Point(270, 132)
        Panel.Width = 222
        Panel.Visible = False
        animator1.Show(Panel)
        BunifuImageButton4.Visible = False
        BunifuImageButton3.Visible = True
        Label1.Visible = True
        logoanimator.ShowSync(PictureBox2)
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Dim obj As New Nurse_Patient
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()

        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Doctor_Checkup.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Doctor_Lab.Show()
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
            Query = "Update userlogs set id='" & Label4.Text & "',Time_out= '" & Label3.Text & "' where id = '" & Label4.Text & "'"
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

    Private Sub BunifuFlatButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim obj As New Nurse_Recordss
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()

        Me.Hide()
    End Sub



    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuMetroTextbox4_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox4.OnValueChanged
        Dim Santie As New MySqlDataAdapter
        Dim Pelayo As New DataTable
        Dim binding As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * from invoice_tbl where CONCAT(Invoice_no,Patient_ID,Total_Amount,Discount,Total_Charges,Amount_Tendered,Amount_Change,Date,Payment_Status,Doctor,Process_by) LIKE '%" & BunifuMetroTextbox4.Text & "%'"
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


    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.OnValueChanged
        Dim Santie As New MySqlDataAdapter
        Dim Pelayo As New DataTable
        Dim binding As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * from checkup where CONCAT(Reference_ID,PatientID,Prescribe_Medicine,Treatment,Prescribed_by,Schedule_of_Checkup,Consultation_Fee,Additional_Charges,Amount_Payment,Change_Amount,Status,Process_by,Time,Date) LIKE '%" & BunifuMetroTextbox1.Text & "%'"
            Command = New MySqlCommand(Query, MysqlConn)
            Santie.SelectCommand = Command
            Santie.Fill(Pelayo)
            binding.DataSource = Pelayo
            BunifuCustomDataGrid2.DataSource = binding
            Santie.Update(Pelayo)
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BunifuCustomDataGrid2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid2.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid2.Rows(e.RowIndex)
            TextBox2.Text = row.Cells("Reference_ID").Value.ToString
            TextBox4.Text = row.Cells("Status").Value.ToString
            TextBox7.Text = row.Cells("Consultation_Fee").Value.ToString
            checkupbill.Label5.Text = row.Cells("Reference_ID").Value.ToString
            checkupbill.MaterialSingleLineTextField5.Text = row.Cells("Consultation_Fee").Value.ToString
            consultationbilling.Label12.Text = row.Cells("Reference_ID").Value.ToString
            consultationbilling.Label3.Text = row.Cells("PatientID").Value.ToString
            consultationbilling.Label22.Text = row.Cells("Consultation_Fee").Value.ToString
            consultationbilling.Label30.Text = row.Cells("Additional_Charges").Value.ToString
            consultationbilling.Label8.Text = row.Cells("Total_Due").Value.ToString
            consultationbilling.Label13.Text = row.Cells("Amount_Payment").Value.ToString
            consultationbilling.Label15.Text = row.Cells("Change_Amount").Value.ToString
            consultationbilling.Label27.Text = row.Cells("Date").Value.ToString
            consultationbilling.Label25.Text = row.Cells("Prescribed_by").Value.ToString
        End If
    End Sub
    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("Invoice_no").Value.ToString
            TextBox10.Text = row.Cells("Invoice_no").Value.ToString
            TextBox3.Text = row.Cells("Payment_Status").Value.ToString
            TextBox8.Text = row.Cells("Total_Amount").Value.ToString
            TextBox9.Text = row.Cells("Discount").Value.ToString
            paid.Label5.Text = row.Cells("Invoice_no").Value.ToString
            paid.MaterialSingleLineTextField6.Text = row.Cells("Total_Amount").Value.ToString
            paid.MaterialSingleLineTextField4.Text = row.Cells("Discount").Value.ToString
            Patientinfoprint.Label12.Text = row.Cells("Invoice_No").Value.ToString
            Patientinfoprint.Label21.Text = row.Cells("Patient_ID").Value.ToString
            Patientinfoprint.Label22.Text = row.Cells("Total_Amount").Value.ToString
            Patientinfoprint.Label20.Text = row.Cells("Total_Charges").Value.ToString
            Patientinfoprint.Label6.Text = row.Cells("Amount_Tendered").Value.ToString
            Patientinfoprint.Label15.Text = row.Cells("Amount_Change").Value.ToString
            Patientinfoprint.Label10.Text = row.Cells("Date").Value.ToString
            Patientinfoprint.Label4.Text = row.Cells("Doctor").Value.ToString
        End If
    End Sub


    Private Sub BunifuFlatButton7_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        Dim obj As New Nurse_Admission
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()


        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs)
        If TextBox2.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Select Patient Record to Paid!", "Select Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TextBox4.Text = "Done" Then
            MetroFramework.MetroMessageBox.Show(Me, "This is already Done , Please Select Another Record", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            checkupbill.Show()
        End If
    End Sub

    Private Sub BunifuFlatButton6_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        If TextBox2.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Select Patient Record to Paid!", "Select Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TextBox4.Text = "Done" Then
            MetroFramework.MetroMessageBox.Show(Me, "This is already Done , Please Select Another Record", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim obj As New checkupbill
            obj.stringpass = Login.MaterialSingleLineTextField1.Text
            obj.stringpass1 = TextBox7.Text
            obj.reference = TextBox2.Text
            obj.Show()

        End If
    End Sub
    Private Sub BunifuFlatButton8_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        If TextBox1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Select Patient Record to Paid!", "Select Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TextBox3.Text = "Done" Then
            MetroFramework.MetroMessageBox.Show(Me, "This is already Done ,Please Select Another Record", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim obj As New paid
            obj.stringpass = Login.MaterialSingleLineTextField1.Text
            obj.stringpass1 = TextBox8.Text
            obj.stringpass2 = TextBox9.Text
            obj.invoice = TextBox10.Text
            obj.Show()
        End If
    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        If Confine.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Select Patient Record to Paid!", "Select Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf RemarksConfine.Text = "Done" Then
            MetroFramework.MetroMessageBox.Show(Me, "This is already Paid ,Please Select Another Record", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Confinepayment.Show()
        End If
    End Sub

    Private Sub BunifuCustomDataGrid3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid3.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid3.Rows(e.RowIndex)
            Confine.Text = row.Cells("Patient_ID").Value.ToString
            Confinepayment.Roomid.Text = row.Cells("Room_ID").Value.ToString
            Confinepayment.TextBox1.Text = row.Cells("Confine_ID").Value.ToString
            RemarksConfine.Text = row.Cells("Remarks").Value.ToString
            Confinepayment.Label6.Text = row.Cells("Patient_ID").Value.ToString
            Confinepayment.MaterialSingleLineTextField1.Text = row.Cells("Total_Amount").Value.ToString
            Confinepayment.Total.Text = row.Cells("Total_Amount").Value.ToString
            TextBox5.Text = row.Cells("Patient_ID").Value.ToString
            Confineprint.Label3.Text = row.Cells("Patient_ID").Value.ToString
            Confineprint.Label22.Text = row.Cells("Total_Amount").Value.ToString
            Confineprint.Label30.Text = row.Cells("Additional_Charges").Value.ToString
            Confineprint.Label12.Text = row.Cells("Discount").Value.ToString
            Confineprint.Label8.Text = row.Cells("Total_Charges").Value.ToString
            Confineprint.Label13.Text = row.Cells("Amount_Tendered").Value.ToString
            Confineprint.Label15.Text = row.Cells("Amount_Change").Value.ToString
            Confineprint.Label27.Text = row.Cells("Date").Value.ToString
            Confineprint.Label25.Text = row.Cells("Processby").Value.ToString
        End If

  
    End Sub

    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton10.Click
        If TextBox5.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Select Patient Record to Print!", "Select Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Confineprint.Show()
        End If
    End Sub

    Private Sub BunifuMetroTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.OnValueChanged
        Dim Santie As New MySqlDataAdapter
        Dim Pelayo As New DataTable
        Dim binding As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * from confine_tbl where CONCAT(Confine_ID,Patient_ID,Room_ID,Findings,Status_of_Deceased,Total_Amount,Additional_Charges,Discount,Total_Charges,Amount_Tendered,Amount_Change,Time_In,Time_Out,Date,Remarks,Processby) LIKE '%" & BunifuMetroTextbox2.Text & "%'"
            Command = New MySqlCommand(Query, MysqlConn)
            Santie.SelectCommand = Command
            Santie.Fill(Pelayo)
            binding.DataSource = Pelayo
            BunifuCustomDataGrid3.DataSource = binding
            Santie.Update(Pelayo)
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BunifuFlatButton11_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton11.Click
        If TextBox1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Select Patient Record to Print!", "Select Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Patientinfoprint.Show()
        End If
    End Sub



    Private Sub BunifuFlatButton12_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton12.Click
        If TextBox2.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Select Patient Record to Print!", "Select Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            consultationbilling.Show()
        End If
    End Sub

    Private Sub BunifuCustomDataGrid2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub BunifuFlatButton14_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton14.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from invoice_tbl"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        BunifuCustomDataGrid1.DataSource = dsa.Tables(0)
        MysqlConn.Close()
    End Sub

    Private Sub BunifuFlatButton13_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton13.Click
        dbcallbilling()
    End Sub
    Sub dbcallbilling()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Quer1 As String = "SELECT Confine_ID,Patient_ID,Room_ID,Findings,Status_of_Deceased,Format(Total_Amount,2) as Total_Amount,Format(Additional_Charges,2) as Additional_Charges,Format(Discount,2) as Discount,Format(Total_Charges,2) as Total_Charges,Format(Amount_Tendered,2) as Amount_Tendered,Format(Amount_Change,2) as Amount_Change,Time_In,Time_Out,Date,Remarks,Processby from confine_tbl"
        Dim adp1 As New MySqlDataAdapter(Quer1, MysqlConn)
        Dim ds1 As New DataSet()
        adp1.Fill(ds1, "Confine_ID")
        BunifuCustomDataGrid3.DataSource = ds1.Tables(0)
        BunifuCustomDataGrid3.Columns("Status_of_Deceased").Width = 200
        BunifuCustomDataGrid3.Columns("Findings").Width = 250
        BunifuCustomDataGrid3.Columns("Total_Amount").Width = 150
        BunifuCustomDataGrid3.Columns("Additional_Charges").Width = 250
        BunifuCustomDataGrid3.Columns("Discount").Width = 120
        BunifuCustomDataGrid3.Columns("Total_Charges").Width = 150
        BunifuCustomDataGrid3.Columns("Amount_Tendered").Width = 150
        BunifuCustomDataGrid3.Columns("Amount_Change").Width = 150
        BunifuCustomDataGrid3.Columns("Time_In").Width = 150
        BunifuCustomDataGrid3.Columns("Time_Out").Width = 150
        BunifuCustomDataGrid3.Columns("Date").Width = 150
        MysqlConn.Close()
    End Sub

    Private Sub BunifuFlatButton15_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton15.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from checkup"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        BunifuCustomDataGrid2.DataSource = dsa.Tables(0)
        MysqlConn.Close()
    End Sub
End Class