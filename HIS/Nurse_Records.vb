Imports MySql.Data.MySqlClient
Imports ITA.ITAFunction
Imports MetroFramework
Public Class Nurse_Records
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim pl1 As Integer = 60
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)
        Nurse_Billing.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)
        Doctor_Checkup.Show()
        Me.Hide()
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialSingleLineTextField1.Enabled = False
        MaterialSingleLineTextField2.Enabled = False
        MaterialSingleLineTextField3.Enabled = False
        ConnectMySQL("localhost", "root", "", "HIS", "3306")
        DataGridView1.DataSource = Fetch_Data("userlogs", "*", "")

        Label4.Text = TotalRecord("userlogs").ToString
        Timer1.Start()
        Label9.Text = DateTime.Now.ToLongDateString()


        BunifuFlatButton3.selected = True
        BunifuImageButton4.Visible = False


        ' MysqlConn = New MySqlConnection
        '  MysqlConn.ConnectionString =
        '    "server=localhost;userid=root;password=;database=HIS"
        ' Dim Queryq As String = "SELECT Patient_ID,Room_ID,Findings,Status_of_Deceased,Format(Total_Amount,2) as Total_Amount,Format(Additional_Charges,2) as Additional_Charges,Format(Discount,2) as Discount,Format(Total_Charges,2) as Total_Charges,Format(Amount_Tendered,2) as Amount_Tendered,Format(Amount_Change,2) as Amount_Change,Time_In,Time_Out,Date,Remarks from confine_tbl"
        'Dim adptq As New MySqlDataAdapter(Queryq, MysqlConn)
        ' Dim dsq As New DataSet()
        ' adptq.Fill(dsq, "app_id")
        ' BunifuCustomDataGrid4.DataSource = dsq.Tables(0)
        ' BunifuCustomDataGrid4.Columns("Status_of_Deceased").Width = 200
        ' BunifuCustomDataGrid4.Columns("Findings").Width = 250
        ' BunifuCustomDataGrid4.Columns("Total_Amount").Width = 150
        'BunifuCustomDataGrid4.Columns("Additional_Charges").Width = 250
        ' BunifuCustomDataGrid4.Columns("Discount").Width = 120
        'BunifuCustomDataGrid4.Columns("Total_Charges").Width = 150
        'BunifuCustomDataGrid4.Columns("Amount_Tendered").Width = 150
        ' BunifuCustomDataGrid4.Columns("Amount_Change").Width = 150
        'BunifuCustomDataGrid4.Columns("Time_In").Width = 150
        'BunifuCustomDataGrid4.Columns("Time_Out").Width = 150
        'BunifuCustomDataGrid4.Columns("Date").Width = 150
        ' MysqlConn.Close()

        '   MysqlConn = New MySqlConnection
        '.ConnectionString =
        '     "server=localhost;userid=root;password=;database=HIS"
        ' Dim Query As String = "SELECT Invoice_No,Patient_ID,Format(Total_Amount,2) as Total_Amount,Format(Discount,2) as Discount,Format(Amount_Tendered,2) as Amount_Tendered,Format(Amount_Change,2) as Amount_Change,Date,Payment_Status,Doctor,Process_by from invoice_tbl"
        'Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        'Dim ds As New DataSet()
        ' adpt.Fill(ds, "app_id")
        '  BunifuCustomDataGrid3.DataSource = ds.Tables(0)
        '  BunifuCustomDataGrid3.Columns("Total_Amount").Width = 150
        ' BunifuCustomDataGrid3.Columns("Discount").Width = 150
        ' BunifuCustomDataGrid3.Columns("Amount_Tendered").Width = 150
        ' BunifuCustomDataGrid3.Columns("Amount_Change").Width =
        'BunifuCustomDataGrid3.Columns("Date").Width = 130
        ' BunifuCustomDataGrid3.Columns("Payment_Status").Width = 150
        ' BunifuCustomDataGrid3.Columns("Doctor").Width = 150
        ' BunifuCustomDataGrid3.Columns("Process_by").Width = 150


        'MysqlConn.Close()
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        Tabanimation.ShowSync(BunifuCards1)
        BunifuFlatButton3.selected = True
        BunifuCards1.Location = New Point(251, 97)
        BunifuCards2.Location = New Point(262, 234)
        Panelqwe.Width = 222
        Panelqwe.Visible = False
        animator1.Show(Panelqwe)
        BunifuImageButton4.Visible = False
        BunifuImageButton2.Visible = True

        logoanimator.ShowSync(PictureBox2)
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        BunifuFlatButton3.selected = True
        BunifuCards1.Location = New Point(170, 97)
        BunifuCards2.Location = New Point(170, 234)
        Panelqwe.Width = 52
        Panelqwe.Visible = False
        PictureBox2.Visible = False
        panelanimator1.Show(Panelqwe)
        BunifuImageButton4.Visible = True
        BunifuImageButton2.Visible = False

        logoanimator.Hide(PictureBox2)
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Nurse_Patient.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click_1(sender As Object, e As EventArgs)
        Doctor_Checkup.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Nurse_Billing.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs)
        Doctor_Lab.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
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
            Query = "Update userlogs set id='" & Label4.Text & "',Time_out= '" & Label6.Text & "' where id = '" & Label4.Text & "'"
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
        Label6.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Sub PatientDetails()
        Dim sql As String =
<sql>
SELECT `Patient_ID`, `Firstname`, `Lastname`, `Middleinitial`,
 `Dateofbirth`, `Age`, `Address`, `Phonenumber`, `Blood_Type`,
 `Height`, `Weight`, `Temperature`, `Blood_Pressure`, `Pulse_rate`, 
`Marital_Status`, `Gender` FROM `patient_tbl` WHERE patient_id = '<%= Me.txtSearch.Text %>'
OR concat(lastname,' ',Firstname,' ',Middleinitial,'.') LIKE '%<%= txtSearch.Text %>%' LIMIT 1
</sql>
        Me.BunifuCustomDataGrid1.DataSource = MySQL_Fetch_Array(sql)


    End Sub
    Sub PatientCheckupDetails()
        Dim sql As String =
<sql>
SELECT `Reference_ID`, `PatientID`, `Findings`, `Prescribe_Medicine`
, `Treatment`, `Prescribed_by`,`Schedule_of_Checkup`,  `Time`,`Date` FROM `checkup`
 WHERE PatientID = '<%= Me.txtSearch.Text %>'
OR PatientID LIKE (SELECT patient_id from patient_tbl WHERE 
concat(lastname,' ',Firstname,' ',Middleinitial,'.') LIKE '%<%= txtSearch.Text %>%' LIMIT 1)
</sql>
        Me.BunifuCustomDataGrid2.DataSource = MySQL_Fetch_Array(sql)
    End Sub
    ' Sub InvoiceDetails()
    'Dim sql As String =
    '<sql>
    'SELECT `Invoice_No`, `Patient_ID`, `Total_Amount`, `Discount`, `Total_Charges`, `Amount_Tendered`, 
    '`Amount_Change`, `Date`, `Payment_Status`, `Doctor`, `Process_by` FROM `invoice_tbl`
    ' WHERE Patient_ID = '<%= Me.txtSearch.Text %>'
    'OR Patient_ID LIKE (SELECT patient_id from patient_tbl WHERE 
    'concat(lastname,' ',Firstname,' ',Middleinitial,'.') LIKE '%<%= txtSearch.Text %>%' LIMIT 1)
    '</sql>
    ' Me.BunifuCustomDataGrid5.DataSource = MySQL_Fetch_Array(sql)
    '  End Sub
    Sub PatientConfineDetails()
        Dim sql As String =
<sql>
    SELECT `Confine_ID`, `Patient_ID`, `Room_ID`, `Findings`
, `Status_of_Deceased`,`Time_In`, `Time_Out`,`Date`, `Remarks` FROM `confine_tbl` 
 WHERE Patient_ID = '<%= Me.txtSearch.Text %>'
OR Patient_ID LIKE (SELECT patient_id from patient_tbl WHERE 
concat(lastname,' ',Firstname,' ',Middleinitial,'.') LIKE '%<%= txtSearch.Text %>%' LIMIT 1)
</sql>
        Me.BunifuCustomDataGrid4.DataSource = MySQL_Fetch_Array(sql)
    End Sub



    Sub PatientLabDetails()
        Dim sql As String =
<sql>
    SELECT `Transaction_ID`, `Invoice_no`, a.`Patient_ID`, a.`Lab_ID`,a.`Labservice_Name`,
 `Lab_Fee`, `Date_of_Transaction` FROM `transaction_tbl` a
LEFT JOIN 
(SELECT `Lab_ID`, `Labservice_Name` FROM `labinfo_tbl`) b
ON a.lab_id  = b.lab_id 
WHERE a.patient_id = '<%= Me.txtSearch.Text %>'
OR a.patient_id = (SELECT patient_id from patient_tbl WHERE 
concat(lastname,' ',Firstname,' ',Middleinitial,'.') = '<%= txtSearch.Text %>')
</sql>

        Me.BunifuCustomDataGrid3.DataSource = MySQL_Fetch_Array(sql)
    End Sub
    Sub PatientLabDetails1()
        Dim sql As String =
<sql>
    SELECT `Transaction_ID`, `Invoice_no`, a.`Patient_ID`, a.`Lab_ID`,a.`Labservice_Name`,
 `Lab_Fee`, `Date_of_Transaction` FROM `transaction_tbl` a
LEFT JOIN 
(SELECT `Lab_ID`, `Labservice_Name` FROM `labinfo_tbl`) b
ON a.lab_id  = b.lab_id 
WHERE a.Invoice_no = '<%= Me.TextBox1.Text %>'
OR a.patient_id = (SELECT patient_id from patient_tbl WHERE 
concat(lastname,' ',Firstname,' ',Middleinitial,'.') = '<%= txtSearch.Text %>')
</sql>

        Me.DataGridView2.DataSource = MySQL_Fetch_Array(sql)
    End Sub
    Private Sub BunifuCustomDataGrid1_SelectionChanged(sender As Object, e As EventArgs) Handles BunifuCustomDataGrid1.SelectionChanged
        Me.MaterialSingleLineTextField1.Text = Me.BunifuCustomDataGrid1.Item(0, Me.BunifuCustomDataGrid1.CurrentRow.Index).Value.ToString()
        Me.MaterialSingleLineTextField2.Text = Me.BunifuCustomDataGrid1.Item(1, Me.BunifuCustomDataGrid1.CurrentRow.Index).Value.ToString()
        Me.MaterialSingleLineTextField3.Text = Me.BunifuCustomDataGrid1.Item(2, Me.BunifuCustomDataGrid1.CurrentRow.Index).Value.ToString()
    End Sub

    Private Sub txtSearch_KeyDown1(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call PatientCheckupDetails()
            Call PatientDetails()
            Call PatientLabDetails()
            Call PatientConfineDetails()
            Call PatientLabDetails1()
            ' Call InvoiceDetails()
        End If
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        If Patienttab.SelectedIndex = 1 Then
            consultationprint.Show()
        ElseIf Patienttab.SelectedIndex = 2 Then
            labprint.Show()
        End If
    End Sub
    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Nurse_Admission.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuCustomDataGrid3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid3.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid3.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("Invoice_no").Value.ToString
            labprint.Label7.Text = row.Cells("Labservice_Name").Value.ToString
            labprint.Label10.Text = row.Cells("Lab_Fee").Value.ToString
            labprint.Label6.Text = row.Cells("Lab_ID").Value.ToString
            labprint.Label15.Text = row.Cells("Invoice_No").Value.ToString
            labprint.Label2.Text = row.Cells("Patient_ID").Value.ToString
            labprint.Label12.Text = row.Cells("Date_of_Transaction").Value.ToString
        End If
    End Sub

    Private Sub BunifuCustomDataGrid2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid2.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid2.Rows(e.RowIndex)
            consultationprint.Label2.Text = row.Cells("PatientID").Value.ToString
            consultationprint.Label10.Text = row.Cells("Findings").Value.ToString
            consultationprint.Label6.Text = row.Cells("Prescribe_Medicine").Value.ToString
            consultationprint.Label7.Text = row.Cells("Treatment").Value.ToString
            consultationprint.MaterialSingleLineTextField1.Text = row.Cells("Prescribed_by").Value.ToString
            consultationprint.Label12.Text = row.Cells("Date").Value.ToString
            consultationprint.Label13.Text = row.Cells("Time").Value.ToString
            consultationprint.Label15.Text = row.Cells("Reference_ID").Value.ToString
        End If
    End Sub

    Private Sub BunifuCustomDataGrid3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid3.CellContentClick

    End Sub
End Class