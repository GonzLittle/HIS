Imports MySql.Data.MySqlClient
Imports MetroFramework
Public Class Laboratory
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim cmd As MySqlCommand
    Public Property stringpass As String
    Public Property stringpass1 As String
    Private Sub Labtest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialSingleLineTextField4.Text = stringpass
        Label7.Text = stringpass1
        DeleteTable()
        MaterialSingleLineTextField4.Enabled = False

        Label15.Text = DateTime.Now.ToLongDateString()
        id()
        Timer1.Start()
        Label12.Text = DateTime.Now.ToString("yyyy/MM/dd")
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Queryq As String = "SELECT Lab_ID,Labservice_Name,Format(Lab_Fee,2) as Lab_Fee from labinfo_tbl"
        Dim adptq As New MySqlDataAdapter(Queryq, MysqlConn)
        Dim dsq As New DataSet()
        adptq.Fill(dsq, "app_id")
        BunifuCustomDataGrid1.DataSource = dsq.Tables(0)
        BunifuCustomDataGrid1.Columns("Lab_ID").Width = 150
        BunifuCustomDataGrid1.Columns("Labservice_Name").Width = 200
        BunifuCustomDataGrid1.Columns("Lab_Fee").Width = 106
        MysqlConn.Close()
        MaterialSingleLineTextField1.Enabled = False
        MaterialSingleLineTextField2.Enabled = False
        MaterialSingleLineTextField3.Enabled = False
        DeleteTable()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select Invoice_no,Patient_ID,Lab_ID,Labservice_Name,Lab_Fee,Time,Date_Of_Transaction from transaction1_tbl"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        BunifuCustomDataGrid2.DataSource = dsa.Tables(0)

        MysqlConn.Close()

    End Sub
    Friend Sub DeleteTable()

        Dim strSQL As String

        strSQL = "TRUNCATE TABLE transaction1_tbl"

        Using connection As New MySqlConnection("server=localhost;userid=root;password=;database=HIS")

            Dim cmd As New MySqlCommand(strSQL, connection)

            cmd.connection.Open()

            cmd.ExecuteNonQuery()

        End Using

    End Sub

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid1.Rows(e.RowIndex)
            MaterialSingleLineTextField1.Text = row.Cells("Lab_ID").Value.ToString
            MaterialSingleLineTextField2.Text = row.Cells("Labservice_Name").Value.ToString
            MaterialSingleLineTextField3.Text = row.Cells("Lab_Fee").Value.ToString
        End If
    End Sub
    Sub id()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"

        MysqlConn.Open()

        Dim str As String
        Dim empid As Integer

        str = "SELECT MAX(Invoice_no) AS MAXIMUM FROM invoice"
        Dim cmd2 As MySqlCommand = New MySqlCommand(str, MysqlConn)
        Dim dr As MySqlDataReader
        dr = cmd2.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            If IsDBNull(dr("MAXIMUM")) Then
                empid = 1
            Else
                empid = CInt(dr("MAXIMUM")) + 1
            End If
        Else
            empid = 1
        End If
        dr.Close()
        Me.TextBox1.Text = empid
        MysqlConn.Close()
    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        For i = 0 To BunifuCustomDataGrid2.RowCount - 1

            If BunifuCustomDataGrid2.Rows(i).Cells(3).Value = MaterialSingleLineTextField2.Text Then
                MetroFramework.MetroMessageBox.Show(Me, "Duplicate Record! Please Select Another Service!", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub 'So no insert occurs
            End If

        Next

        BunifuCustomDataGrid2.Columns(4).DefaultCellStyle.Format = "f2"
        BunifuCustomDataGrid2.Refresh()


        If MaterialSingleLineTextField1.Text = Nothing And MaterialSingleLineTextField2.Text = Nothing And MaterialSingleLineTextField3.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "You must add Service to proceed", "Missing Field!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString =
                "server=localhost;userid=root;password=;database=HIS"
            Dim READER As MySqlDataReader

            Try
                MysqlConn.Open()
                Dim Sql As String
                Sql = "Insert into transaction1_tbl (Invoice_no,Patient_ID,Lab_ID,Labservice_Name,Lab_Fee,Time,Date_of_Transaction) values ('" & TextBox1.Text & "','" & Label7.Text & "','" & MaterialSingleLineTextField1.Text & "','" & MaterialSingleLineTextField2.Text & "','" & MaterialSingleLineTextField3.Text & "','" & Label13.Text & "','" & Label12.Text & "')"
                Command = New MySqlCommand(Sql, MysqlConn)

                READER = Command.ExecuteReader
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            MysqlConn.Close()
            wew()
            total()
        End If
    End Sub
    Sub invoice()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Sql As String
            Sql = "Insert into invoice (Generate)values ( '" & TextBox1.Text & "')"
            cmd = New MySqlCommand(Sql, MysqlConn)
            reader = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MysqlConn.Close()
    End Sub
    Sub total()
        Dim total As Double = 0
        For i As Double = 0 To BunifuCustomDataGrid2.RowCount - 1
            total += BunifuCustomDataGrid2.Rows(i).Cells(4).Value()
            'Change the number 2 to your column index number (The first column has a 0 index column)
            'In this example the column index of Price is 2
        Next
        Label31.Text = total.ToString("f2")
    End Sub

    Sub wew()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select Invoice_no,Patient_ID,Lab_ID,Labservice_Name,Lab_Fee,Time,Date_Of_Transaction from transaction1_tbl"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        BunifuCustomDataGrid2.DataSource = dsa.Tables(0)
        MysqlConn.Close()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label13.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs)
        inserttoDatagridview()
    End Sub
    Private Sub inserttoDatagridview()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim READER As MySqlDataReader
        Dim StrQuery As String
        Try

            MysqlConn.Open()
            For i As Integer = 0 To BunifuCustomDataGrid2.Rows.Count - 1
                StrQuery = "INSERT INTO transaction_tbl VALUES ('" & BunifuCustomDataGrid2.Rows(i).Cells("Lab_ID").Value.ToString & "','" & BunifuCustomDataGrid2.Rows(i).Cells("Lab_Fee").Value.ToString & "','" & BunifuCustomDataGrid2.Rows(i).Cells("Date_of_Transaction").Value.ToString & "')"
                Command = New MySqlCommand(StrQuery, MysqlConn)
                READER = Command.ExecuteReader
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MysqlConn.Close()
        MessageBox.Show("Records inserted.")
    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        Dim reader As MySqlDataReader
        Dim conn As MySqlConnection
        conn = New MySqlConnection
        conn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Try
            conn.Open()
            Dim query As String
            query = "Delete from transaction1_tbl where Lab_ID = '" & TextBox2.Text & "'"
            Command = New MySqlCommand(query, conn)
            reader = Command.ExecuteReader
            MetroFramework.MetroMessageBox.Show(Me, "Successfully Delete!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            automatic()
            total()


            conn.Close()
        Catch ex As Exception
            MsgBox("ERROR NA")
        Finally
            conn.Dispose()
        End Try
    End Sub

    Sub automatic()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select Invoice_no,Patient_ID,Lab_ID,Labservice_Name,Lab_Fee,Time,Date_Of_Transaction from transaction1_tbl"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        BunifuCustomDataGrid2.DataSource = dsa.Tables(0)
        MysqlConn.Close()

    End Sub

    Private Sub BunifuCustomDataGrid2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid2.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid2.Rows(e.RowIndex)
            TextBox2.Text = row.Cells("Lab_ID").Value.ToString
        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        TextBox3.Text = Val(Label31.Text) - Val(Label43.Text)
        If MaterialSingleLineTextField1.Text = Nothing And MaterialSingleLineTextField2.Text = Nothing And MaterialSingleLineTextField3.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "You must Complete all the Details!", "Missing Field!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      
        ElseIf MessageBox.Show("Are you sure to save?", "Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            DeleteTable()
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"

            Dim StrQuery As String
            Try

                MysqlConn.Open()
                For i As Integer = 0 To BunifuCustomDataGrid2.Rows.Count - 1
                    With BunifuCustomDataGrid2.Rows(i)

                        StrQuery = "INSERT INTO transaction_tbl (Invoice_no,Patient_ID,Lab_Id,Labservice_Name,Lab_Fee,Date_of_Transaction) " & _
                        "VALUES" & _
                         "('" & .Cells("Invoice_no").Value.ToString() & _
                        "','" & .Cells("Patient_ID").Value.ToString() & _
                         "','" & .Cells("Lab_ID").Value.ToString() & _
                         "','" & .Cells("Labservice_Name").Value.ToString() & _
                         "','" & .Cells("Lab_Fee").Value.ToString() & _
                         "','" & .Cells("Date_of_Transaction").Value.ToString() & "')"

                        Command = New MySqlCommand(StrQuery, MysqlConn)
                        Command.ExecuteNonQuery()
                    End With
                Next
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try





            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString =
                "server=localhost;userid=root;password=;database=HIS"
            Dim reader As MySqlDataReader

            Try
                MysqlConn.Open()
                Dim Sql As String
                Sql = "Insert into invoice_tbl (Invoice_no,Patient_ID,Total_Amount,Discount,Total_Charges,Amount_Tendered,Amount_Change,Date,Payment_Status,Doctor,Process_by) values ( '" & TextBox1.Text & "','" & Label7.Text & "','" & Label31.Text & "','" & Label43.Text & "','" & TextBox3.Text & "','" & Label16.Text & "','" & Label14.Text & "','" & Label15.Text & "','" & Label17.Text & "','" & MaterialSingleLineTextField4.Text & "','" & Label18.Text & "')"
                cmd = New MySqlCommand(Sql, MysqlConn)
                reader = cmd.ExecuteReader
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            MysqlConn.Close()

            invoice()
            invoice_billing()
            MessageBox.Show(Me, "Successfully Saved.", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information)
         
            Me.Hide()
            TextBox1.Clear()
            Doctor_Lab.TextBox1.Clear()
            Label43.Text = printresult.Label2.Text
            Dim dr As New System.Windows.Forms.DataGridViewRow
            For Each dr In BunifuCustomDataGrid2.Rows()
                printresult.printdatagrid.Rows.Add(dr.Cells(0).Value, dr.Cells(3).Value, dr.Cells(4).Value)
            Next
            printresult.Show()

            PrintDocument1.Print()

            PrintPreviewDialog1.Document = PrintDocument1

            PrintPreviewDialog1.ShowDialog()

            printresult.DataGridView1.Columns.Clear()
        End If

    End Sub

    Private Sub MaterialCheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox15.CheckedChanged
        Dim a As Double = 0.2
        If MaterialCheckBox15.Checked Then
            Label43.Text = Val(Label31.Text) * a
            printresult.Label6.Text = Val(Label31.Text) * a
        ElseIf MaterialCheckBox15.CheckState = CheckState.Unchecked Then
            Label43.Text = 0
        End If
    End Sub

    Private Sub BunifuMetroTextbox4_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox4.OnValueChanged
        Dim Santie As New MySqlDataAdapter
        Dim Pelayo As New DataTable
        Dim binding As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * from labinfo_tbl where CONCAT(Lab_ID,Labservice_Name,Lab_Fee) LIKE '%" & BunifuMetroTextbox4.Text & "%'"
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
    Sub invoice_billing()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "SELECT Invoice_No,Patient_ID,Format(Total_Amount,2) as Total_Amount,Format(Discount,2) as Discount,Format(Total_Charges,2) as Total_Charges,Format(Amount_Tendered,2) as Amount_Tendered,Format(Amount_Change,2) as Amount_Change,Date,Payment_Status,Doctor,Process_by from invoice_tbl"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "app_id")
        Nurse_Billing.BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        Nurse_Billing.BunifuCustomDataGrid1.Columns("Total_Amount").Width = 150
        Nurse_Billing.BunifuCustomDataGrid1.Columns("Discount").Width = 150
        Nurse_Billing.BunifuCustomDataGrid1.Columns("Total_Charges").Width = 150
        Nurse_Billing.BunifuCustomDataGrid1.Columns("Amount_Tendered").Width = 150
        Nurse_Billing.BunifuCustomDataGrid1.Columns("Amount_Change").Width = 150
        Nurse_Billing.BunifuCustomDataGrid1.Columns("Date").Width = 130
        Nurse_Billing.BunifuCustomDataGrid1.Columns("Payment_Status").Width = 150
        Nurse_Billing.BunifuCustomDataGrid1.Columns("Doctor").Width = 150
        Nurse_Billing.BunifuCustomDataGrid1.Columns("Process_by").Width = 150


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(printresult.Width, printresult.Height)
        printresult.DrawToBitmap(bm, New Rectangle(0, 0, printresult.Width, printresult.Height))
        e.Graphics.DrawImage(bm, 0, 0)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs)
        DeleteTable()
        Me.Hide()

    End Sub
End Class