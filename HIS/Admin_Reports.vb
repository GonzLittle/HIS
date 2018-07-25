Imports MySql.Data.MySqlClient
Imports DGV2Printer
Imports System.Drawing.Printing
Imports System.IO
Imports MetroFramework

Imports Excel = Microsoft.Office.Interop.Excel
Public Class Admin_Reports
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Private Sub Admin_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "SELECT * from invoice_tbl"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "app_id")
        BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        MysqlConn.Close()


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query2 As String = "SELECT * from confine_tbl"
        Dim adpt2 As New MySqlDataAdapter(Query2, MysqlConn)
        Dim ds2 As New DataSet()
        adpt2.Fill(ds2, "app_id")
        BunifuCustomDataGrid3.DataSource = ds2.Tables(0)
        MysqlConn.Close()


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query1 As String = "SELECT * from checkup"
        Dim adpt1 As New MySqlDataAdapter(Query1, MysqlConn)
        Dim ds1 As New DataSet()
        adpt1.Fill(ds1, "app_id")
        BunifuCustomDataGrid2.DataSource = ds1.Tables(0)
        MysqlConn.Close()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from userlogs"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        DataGridView1.DataSource = dsa.Tables(0)
        Label10.Text = dsa.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()
        Timer1.Start()
        BunifuImageButton3.Visible = False
        BunifuFlatButton7.selected = True
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        BunifuFlatButton7.selected = True
        Panel9.Location = New Point(200, 117)
        Panel.Width = 52
        Panel.Visible = False
        PictureBox2.Visible = False
        panelanimator1.Show(Panel)
        BunifuImageButton3.Visible = True
        BunifuImageButton2.Visible = False
        Label1.Visible = False
        logoanimator.Hide(PictureBox2)
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        BunifuFlatButton7.selected = True
        Panel9.Location = New Point(277, 117)
        Panel.Width = 222
        Panel.Visible = False
        animator1.Show(Panel)
        BunifuImageButton3.Visible = False
        BunifuImageButton2.Visible = True
        Label1.Visible = True
        logoanimator.ShowSync(PictureBox2)
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
            Query = "Update userlogs set id='" & Label10.Text & "',Time_out= '" & Label13.Text & "' where id = '" & Label10.Text & "'"
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

    Private Sub MaterialTabSelector1_Click(sender As Object, e As EventArgs) Handles MaterialTabSelector1.Click

    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs)
        Admin_Add_Accounts.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Admin_Patient.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Mainform.Show()
        Me.Hide()
        '  Dim total As String = 0
        ' For i As Integer = 0 To Admin_Billing.BunifuCustomDataGrid1.RowCount - 1
        ' total += Admin_Billing.BunifuCustomDataGrid1.Rows(i).Cells(9).Value
        'Change the number 2 to your column index number (The first column has a 0 index column)
        'In this example the column index of Price is 2
        ' Next
        ' Mainform.Label18.Text = total
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Admin_Billing.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)
        Admin_Roominfo.Show()
        Me.Hide()
    End Sub
    Private bitmap As Bitmap


    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Admin_Add_Accounts.Show()
        Me.Hide()
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



    Private Sub BunifuFlatButton2_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Admin_Labinfo.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton6_Click_2(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Admin_Userlog.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton12_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton12.Click
        Admin_Roominfo.Show()
        Me.Hide()
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Try
            Dim bs As New BindingSource
            bs.DataSource = BunifuCustomDataGrid1.DataSource
            bs.Filter = String.Format("Date >= #{0:yyyy/MM/dd}# And Date <= #{1:yyyy/MM/dd}#", MetroDateTime1.Value, MetroDateTime2.Value)
            BunifuCustomDataGrid1.DataSource = bs

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        MysqlConn.Close()

        Dim total As String = 0
        For i As Integer = 0 To BunifuCustomDataGrid1.RowCount - 1
            total += BunifuCustomDataGrid1.Rows(i).Cells(4).Value

        Next
        Label9.Text = total
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Try
            Dim bs As New BindingSource
            bs.DataSource = BunifuCustomDataGrid2.DataSource
            bs.Filter = String.Format("Date >= #{0:yyyy/MM/dd}# And Date <= #{1:yyyy/MM/dd}#", MetroDateTime4.Value, MetroDateTime3.Value)
            BunifuCustomDataGrid2.DataSource = bs

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        MysqlConn.Close()

        Dim total As String = 0
        For i As Integer = 0 To BunifuCustomDataGrid2.RowCount - 1
            total += BunifuCustomDataGrid2.Rows(i).Cells(9).Value

        Next
        Label12.Text = total
    End Sub

    Private Sub MaterialRaisedButton5_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton5.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Try
            Dim bs As New BindingSource
            bs.DataSource = BunifuCustomDataGrid3.DataSource
            bs.Filter = String.Format("Date >= #{0:yyyy/MM/dd}# And Date <= #{1:yyyy/MM/dd}#", MetroDateTime6.Value, MetroDateTime5.Value)
            BunifuCustomDataGrid3.DataSource = bs

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        MysqlConn.Close()

        Dim total As String = 0
        For i As Integer = 0 To BunifuCustomDataGrid3.RowCount - 1
            total += BunifuCustomDataGrid3.Rows(i).Cells(8).Value

        Next
        Label7.Text = total
    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        If MaterialTabControl1.SelectedIndex = 0 Then
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

            xlWorkBook.SaveAs("C:\Users\Santie\Desktop\REPORTS\TotalSalesinLaboratory.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
            xlWorkBook.Close(True, misValue, misValue)
            xlApp.Quit()


            releaseObject(xlWorkSheet)
            releaseObject(xlWorkBook)
            releaseObject(xlApp)

            MetroFramework.MetroMessageBox.Show(Me, "Successfully Exported to Excel.", "Saved to Desktop\REPORTS\TotalSalesinLaboratory.xls", MessageBoxButtons.OK, MessageBoxIcon.Information)



        ElseIf MaterialTabControl1.SelectedIndex = 1 Then
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

            xlWorkBook.SaveAs("C:\Users\Santie\Desktop\REPORTS\TotalSalesinConsultation.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
            xlWorkBook.Close(True, misValue, misValue)
            xlApp.Quit()


            releaseObject(xlWorkSheet)
            releaseObject(xlWorkBook)
            releaseObject(xlApp)

            MetroFramework.MetroMessageBox.Show(Me, "Successfully Exported to Excel.", "Saved to Desktop\REPORTS\TotalSalesinConsultation.xls", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf MaterialTabControl1.SelectedIndex = 2 Then


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

            xlWorkBook.SaveAs("C:\Users\Santie\Desktop\REPORTS\TotalSalesinConfine.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
            xlWorkBook.Close(True, misValue, misValue)
            xlApp.Quit()


            releaseObject(xlWorkSheet)
            releaseObject(xlWorkBook)
            releaseObject(xlApp)

            MetroFramework.MetroMessageBox.Show(Me, "Successfully Exported to Excel.", "Saved to Desktop\REPORTS\TotalSalesinConfine.xls", MessageBoxButtons.OK, MessageBoxIcon.Information)
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