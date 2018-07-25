Imports MySql.Data.MySqlClient
Imports MetroFramework
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Admin_Patient
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        BunifuFlatButton3.selected = True
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

    Private Sub Admin_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        BunifuFlatButton3.selected = True
   

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
        Mainform.Label9.Text = ds.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()
    End Sub

    Private Sub BunifuImageButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        BunifuFlatButton3.selected = True
        Panel9.Location = New Point(277, 117)
        Panel.Width = 222
        Panel.Visible = False
        animator1.Show(Panel)
        BunifuImageButton3.Visible = False
        BunifuImageButton2.Visible = True
        Label4.Visible = True
        logoanimator.ShowSync(PictureBox2)
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Mainform.Show()
        Me.Hide()
        '  Dim total As String = 0
        '  For i As Integer = 0 To Admin_Billing.BunifuCustomDataGrid1.RowCount - 1
        '  total += Admin_Billing.BunifuCustomDataGrid1.Rows(i).Cells(11).Value
        'Change the number 2 to your column index number (The first column has a 0 index column)
        'In this example the column index of Price is 2
        '  Next
        'Mainform.Label18.Text = total
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Admin_Billing.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)
        Admin_Roominfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Admin_Add_Accounts.Show()
        Me.Hide()
    End Sub
    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs)
        Admin_Reports.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs)
        If TextBox1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please choose record to print!", "Choose Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            PatientPrint.Show()
        End If
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

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("Patient_ID").Value.ToString
            PatientPrint.Label32.Text = row.Cells("Patient_ID").Value.ToString
            PatientPrint.Firstname.Text = row.Cells("Firstname").Value.ToString
            PatientPrint.Lastname.Text = row.Cells("Lastname").Value.ToString
            PatientPrint.Middle.Text = row.Cells("Middleinitial").Value.ToString
            PatientPrint.dob.Text = row.Cells("Dateofbirth").Value.ToString
            PatientPrint.age.Text = row.Cells("Age").Value.ToString
            PatientPrint.Address.Text = row.Cells("Address").Value.ToString
            PatientPrint.Phonenumber.Text = row.Cells("Phonenumber").Value.ToString
            PatientPrint.Bloodtype.Text = row.Cells("Blood_Type").Value.ToString
            '  PatientPrint.Label2.Text = row.Cells("Height").Value.ToString
            PatientPrint.Weight.Text = row.Cells("Weight").Value.ToString
            PatientPrint.Temperature.Text = row.Cells("Temperature").Value.ToString
            PatientPrint.bloodpressure.Text = row.Cells("Blood_Pressure").Value.ToString
            PatientPrint.pulserate.Text = row.Cells("Pulse_rate").Value.ToString
            PatientPrint.Marital.Text = row.Cells("Marital_Status").Value.ToString
            PatientPrint.Gender.Text = row.Cells("Gender").Value.ToString
        End If
    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick

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

    Private Sub BunifuFlatButton6_Click_1(sender As Object, e As EventArgs)
        Admin_Userlog.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label13.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub
    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        Admin_Physician.Show()
        Me.Hide()
    End Sub

    Private Sub Panel_Paint(sender As Object, e As PaintEventArgs) Handles Panel.Paint

    End Sub

    Private Sub BunifuFlatButton2_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Admin_Labinfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton7_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        Dim i As Int16, j As Int16

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Sheet1")


        For i = 0 To BunifuCustomDataGrid1.RowCount - 1
            For j = 0 To BunifuCustomDataGrid1.ColumnCount - 1
                xlWorkSheet.Cells(i + 1, j + 1) = BunifuCustomDataGrid1(j, i).Value.ToString()
            Next
        Next

        xlWorkBook.SaveAs("C:\Users\Santie\Desktop\PATIENTLIST\Patientlist.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
        Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
        xlWorkBook.Close(True, misValue, misValue)
        xlApp.Quit()


        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)

        MetroFramework.MetroMessageBox.Show(Me, "Successfully Exported to Excel.", "Saved to Desktop/PATIENTLIST/Patientlist.xls.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Admin_Userlog.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton12_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton12.Click
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