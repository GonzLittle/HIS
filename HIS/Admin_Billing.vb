Imports MySql.Data.MySqlClient
Imports MetroFramework
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Admin_Billing

    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
   
    Private Sub Admin_Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Quer As String = "select * from transaction_tbl"
        Dim adp As New MySqlDataAdapter(Quer, MysqlConn)
        Dim ds As New DataSet()
        adp.Fill(ds, "Invoice_no")
        BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        Label8.Text = ds.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim qwe As String = "select * from invoice_tbl"
        Dim adapter As New MySqlDataAdapter(qwe, MysqlConn)
        Dim dataset As New DataSet()
        adapter.Fill(dataset, "Invoice_no")
        BunifuCustomDataGrid4.DataSource = dataset.Tables(0)
        Label14.Text = dataset.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Quer1 As String = "select * from confine_tbl"
        Dim adp1 As New MySqlDataAdapter(Quer1, MysqlConn)
        Dim ds1 As New DataSet()
        adp1.Fill(ds1, "Confine_ID")
        BunifuCustomDataGrid3.DataSource = ds1.Tables(0)
        Label11.Text = ds1.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query1 As String = "select * from checkup"
        Dim adpt1 As New MySqlDataAdapter(Query1, MysqlConn)
        Dim ds2 As New DataSet()
        adpt1.Fill(ds2, "app_id")
        BunifuCustomDataGrid2.DataSource = ds2.Tables(0)
        BunifuCustomDataGrid2.Columns("Findings").Width = 200
        BunifuCustomDataGrid2.Columns("PatientID").Width = 120
        BunifuCustomDataGrid2.Columns("Reference_ID").Width = 120
        BunifuCustomDataGrid2.Columns("Prescribe_Medicine").Width = 165
        BunifuCustomDataGrid2.Columns("Treatment").Width = 180
        BunifuCustomDataGrid2.Columns("Consultation_Fee").Width = 150
        BunifuCustomDataGrid2.Columns("Amount_Payment").Width = 150
        BunifuCustomDataGrid2.Columns("Change_Amount").Width = 150
        BunifuCustomDataGrid2.Columns("Status").Width = 120
        BunifuCustomDataGrid2.Columns("Time").Width = 130
        BunifuCustomDataGrid2.Columns("Date").Width = 150

        Label9.Text = ds2.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()
        Timer1.Start()
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
        BunifuFlatButton1.selected = True
        BunifuImageButton3.Visible = False


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

    Private Sub BunifuImageButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
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

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Mainform.Show()
        Me.Hide()
        Dim total As String = 0
        For i As Integer = 0 To BunifuCustomDataGrid2.RowCount - 1
            total += BunifuCustomDataGrid2.Rows(i).Cells(7).Value
            'Change the number 2 to your column index number (The first column has a 0 index column)
            'In this example the column index of Price is 2
        Next
        Mainform.Label24.Text = total

        Dim total1 As String = 0
        For i As Integer = 0 To BunifuCustomDataGrid4.RowCount - 1
            total1 += BunifuCustomDataGrid4.Rows(i).Cells(4).Value
            'Change the number 2 to yo  ur column index number (The first column has a 0 index column)
            'In this example the column index of Price is 2
        Next
        Mainform.Label18.Text = total1

        Dim total2 As String = 0
        For i As Integer = 0 To BunifuCustomDataGrid3.RowCount - 1
            total2 += BunifuCustomDataGrid3.Rows(i).Cells(8).Value
            'Change the number 2 to your column index number (The first column has a 0 index column)
            'In this example the column index of Price is 2
        Next
        Mainform.Label25.Text = total2
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Mainform.Show()
        Me.Hide()
    End Sub
    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs)
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

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs)
        Admin_Userlog.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label13.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub


    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        Admin_Physician.Show()
        Me.Hide()

    End Sub
    Private Sub BunifuFlatButton2_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Admin_Labinfo.Show()
        Me.Hide()
    End Sub


    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        If Billingtab.SelectedIndex = 0 Then
            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            Dim i As Int16, j As Int16

            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("Sheet1")


            For i = 0 To BunifuCustomDataGrid2.RowCount - 1
                For j = 0 To BunifuCustomDataGrid2.ColumnCount - 1
                    xlWorkSheet.Cells(i + 1, j + 1) = BunifuCustomDataGrid2(j, i).Value.ToString()
                Next
            Next

            xlWorkBook.SaveAs("C:\Users\Santie\Desktop\REPORTS\ConsulatationBilling.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
            xlWorkBook.Close(True, misValue, misValue)
            xlApp.Quit()


            releaseObject(xlWorkSheet)
            releaseObject(xlWorkBook)
            releaseObject(xlApp)

            MetroFramework.MetroMessageBox.Show(Me, "Successfully Exported to Excel.", "Saved to Desktop/REPORTS/ConsultationBilling.xls.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Billingtab.SelectedIndex = 1 Then
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

            xlWorkBook.SaveAs("C:\Users\Santie\Desktop\REPORTS\LabBilling.xls.", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
            xlWorkBook.Close(True, misValue, misValue)
            xlApp.Quit()


            releaseObject(xlWorkSheet)
            releaseObject(xlWorkBook)
            releaseObject(xlApp)

            MetroFramework.MetroMessageBox.Show(Me, "Successfully Exported to Excel.", "Saved to Desktop/REPORTS/LabBilling.xls.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Billingtab.SelectedIndex = 2 Then
            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            Dim i As Int16, j As Int16

            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("Sheet1")


            For i = 0 To BunifuCustomDataGrid3.RowCount - 1
                For j = 0 To BunifuCustomDataGrid3.ColumnCount - 1
                    xlWorkSheet.Cells(i + 1, j + 1) = BunifuCustomDataGrid3(j, i).Value.ToString()
                Next
            Next

            xlWorkBook.SaveAs("C:\Users\Santie\Desktop\REPORTS\ConfineBilling.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
            xlWorkBook.Close(True, misValue, misValue)
            xlApp.Quit()


            releaseObject(xlWorkSheet)
            releaseObject(xlWorkBook)
            releaseObject(xlApp)

            MetroFramework.MetroMessageBox.Show(Me, "Successfully Exported to Excel.", "Saved to Desktop/REPORTS/ConfineBilling.xls.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Billingtab.SelectedIndex = 3 Then
            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            Dim i As Int16, j As Int16

            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("Sheet1")


            For i = 0 To BunifuCustomDataGrid4.RowCount - 1
                For j = 0 To BunifuCustomDataGrid4.ColumnCount - 1
                    xlWorkSheet.Cells(i + 1, j + 1) = BunifuCustomDataGrid4(j, i).Value.ToString()
                Next
            Next

            xlWorkBook.SaveAs("C:\Users\Santie\Desktop\REPORTS\InvoiceBilling.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
            xlWorkBook.Close(True, misValue, misValue)
            xlApp.Quit()


            releaseObject(xlWorkSheet)
            releaseObject(xlWorkBook)
            releaseObject(xlApp)

            MetroFramework.MetroMessageBox.Show(Me, "Successfully Exported to Excel.", "Saved to Desktop/REPORTS/InvoiceBilling.xls.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
     
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

    Private Sub BunifuFlatButton8_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        Admin_Userlog.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton12_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton12.Click
        Admin_Roominfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuMetroTextbox3_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuMetroTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.OnValueChanged
        Dim Santie As New MySqlDataAdapter
        Dim Pelayo As New DataTable
        Dim binding As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * from checkup where CONCAT(Reference_ID,PatientID,Prescribe_Medicine,Treatment,Prescribed_by,Schedule_of_Checkup,Consultation_Fee,Additional_Charges,Amount_Payment,Change_Amount,Status,Process_by,Time,Date) LIKE '%" & BunifuMetroTextbox2.Text & "%'"
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

    Private Sub BunifuMetroTextbox4_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox4.OnValueChanged
        Dim Santie As New MySqlDataAdapter
        Dim Pelayo As New DataTable
        Dim binding As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * from transaction_tbl where CONCAT(Transaction_ID,Invoice_No,Patient_ID,Lab_ID,Lab_Fee,Date_of_Transaction) LIKE '%" & BunifuMetroTextbox4.Text & "%'"
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

    Private Sub BunifuMetroTextbox3_OnValueChanged_1(sender As Object, e As EventArgs) Handles BunifuMetroTextbox3.OnValueChanged
        Dim Santie As New MySqlDataAdapter
        Dim Pelayo As New DataTable
        Dim binding As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * from invoice_tbl where CONCAT(Invoice_no,Patient_ID,Total_Amount,Discount,Total_Charges,Amount_Tendered,Amount_Change,Date,Payment_Status,Doctor,Process_by) LIKE '%" & BunifuMetroTextbox3.Text & "%'"
            Command = New MySqlCommand(Query, MysqlConn)
            Santie.SelectCommand = Command
            Santie.Fill(Pelayo)
            binding.DataSource = Pelayo
            BunifuCustomDataGrid4.DataSource = binding
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
            Query = "Select * from confine_tbl where CONCAT(Confine_ID,Patient_ID,Room_ID,Findings,Status_of_Deceased,Total_Amount,Additional_Charges,Discount,Total_Charges,Amount_Tendered,Amount_Change,Time_In,Time_Out,Date,Remarks,Processby) LIKE '%" & BunifuMetroTextbox1.Text & "%'"
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