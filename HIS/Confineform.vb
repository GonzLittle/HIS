Imports MySql.Data.MySqlClient

Public Class Confineform
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Public Property stringpass1 As String
    Public Property stringpass2 As String
    Private Sub Confineform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuCustomTextbox3.Enabled = False
        Timer1.Start()
        Label7.Text = stringpass2
        BunifuCustomTextbox3.Text = stringpass1
        MaterialSingleLineTextField1.Clear()
        MaterialSingleLineTextField3.Clear()
        Datemoto.Text = DateTime.Now.ToString("yyyy/MM/dd")
        MaterialSingleLineTextField1.Enabled = False
        MaterialSingleLineTextField3.Enabled = False
        MaterialSingleLineTextField2.Enabled = False

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Queryq As String = "SELECT Room_ID,Room_no,Format(Price,2) as Price,Status from roominfo_tbl"
        Dim adptq As New MySqlDataAdapter(Queryq, MysqlConn)
        Dim dsq As New DataSet()
        adptq.Fill(dsq, "app_id")
        BunifuCustomDataGrid1.DataSource = dsq.Tables(0)
        BunifuCustomDataGrid1.Columns("Room_ID").Width = 120
        BunifuCustomDataGrid1.Columns("Price").Width = 130
        BunifuCustomDataGrid1.Columns("Status").Width = 150
        MysqlConn.Close()
    End Sub

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid1.Rows(e.RowIndex)
            MaterialSingleLineTextField1.Text = row.Cells("Room_ID").Value.ToString
            MaterialSingleLineTextField2.Text = row.Cells("Room_No").Value.ToString
            MaterialSingleLineTextField3.Text = row.Cells("Price").Value.ToString
            TextBox1.Text = row.Cells("Status").Value.ToString
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        MaterialSingleLineTextField1.Clear()
        MaterialSingleLineTextField3.Clear()
        Me.Hide()
        Nurse_Admission.TextBox1.Clear()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If MaterialSingleLineTextField1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please select Room", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox1.Text = "Unavailable" Then
            MetroFramework.MetroMessageBox.Show(Me, "This room is currently unavailable!", "Please Select Another Room", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf BunifuCustomTextbox1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Findings!", "Input All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf BunifuCustomTextbox2.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Status of Deceased!", "Input All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf BunifuCustomTextbox3.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Process by!", "Input All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MessageBox.Show("Are you sure to save?", "Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString =
                "server=localhost;userid=root;password=;database=HIS"
            Dim READER As MySqlDataReader
            Try
                MysqlConn.Open()

                Dim Sql As String
                Sql = "Insert into confine_tbl (Patient_ID,Room_ID,Findings,Status_of_Deceased,Total_Amount,Amount_Tendered,Discount,Amount_Change,Time_In,Time_Out,Date,Remarks,Processby) values ('" & Label7.Text & "','" & MaterialSingleLineTextField1.Text & "','" & BunifuCustomTextbox1.Text & "','" & BunifuCustomTextbox2.Text & "','" & MaterialSingleLineTextField3.Text & "','" & Tendered.Text & "','" & discount.Text & "','" & Change.Text & "','" & timein.Text & "','" & timeout.Text & "','" & Datemoto.Text & "','" & Remarks.Text & "','" & BunifuCustomTextbox3.Text & "')"
                Command = New MySqlCommand(Sql, MysqlConn)
                READER = Command.ExecuteReader
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Hide()
            refreshdb()
            updateroom()
            confinedb()
            BunifuCustomTextbox1.Clear()
            BunifuCustomTextbox2.Clear()
            BunifuCustomTextbox3.Clear()
            MaterialSingleLineTextField1.Clear()
            MaterialSingleLineTextField2.Clear()
            MaterialSingleLineTextField3.Clear()
            MysqlConn.Close()
            MetroFramework.MetroMessageBox.Show(Me, "Successfully Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Sub refreshdb()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Queryq As String = "SELECT Room_ID,Room_no,Format(Price,2) as Price,Status from roominfo_tbl"
        Dim adptq As New MySqlDataAdapter(Queryq, MysqlConn)
        Dim dsq As New DataSet()
        adptq.Fill(dsq, "app_id")
        BunifuCustomDataGrid1.DataSource = dsq.Tables(0)
        BunifuCustomDataGrid1.Columns("Room_ID").Width = 120
        BunifuCustomDataGrid1.Columns("Price").Width = 130
        BunifuCustomDataGrid1.Columns("Status").Width = 150
        MysqlConn.Close()
    End Sub
    Sub updateroom()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=HIS"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update roominfo_tbl set Room_ID='" & MaterialSingleLineTextField1.Text & "',Status='" & Unavailable.Text & "' where Room_ID = '" & MaterialSingleLineTextField1.Text & "'"
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
    Sub confinedb()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Quer1 As String = "SELECT Confine_ID,Patient_ID,Room_ID,Findings,Status_of_Deceased,Format(Total_Amount,2) as Total_Amount,Format(Additional_Charges,2) as Additional_Charges,Format(Discount,2) as Discount,Format(Total_Charges,2) as Total_Charges,Format(Amount_Tendered,2) as Amount_Tendered,Format(Amount_Change,2) as Amount_Change,Time_In,Time_Out,Date,Remarks,Processby from confine_tbl"
        Dim adp1 As New MySqlDataAdapter(Quer1, MysqlConn)
        Dim ds1 As New DataSet()
        adp1.Fill(ds1, "Confine_ID")
        Nurse_Billing.BunifuCustomDataGrid3.DataSource = ds1.Tables(0)
        Nurse_Billing.BunifuCustomDataGrid3.Columns("Status_of_Deceased").Width = 200
        Nurse_Billing.BunifuCustomDataGrid3.Columns("Findings").Width = 250
        Nurse_Billing.BunifuCustomDataGrid3.Columns("Total_Amount").Width = 150
        Nurse_Billing.BunifuCustomDataGrid3.Columns("Additional_Charges").Width = 250
        Nurse_Billing.BunifuCustomDataGrid3.Columns("Discount").Width = 120
        Nurse_Billing.BunifuCustomDataGrid3.Columns("Total_Charges").Width = 150
        Nurse_Billing.BunifuCustomDataGrid3.Columns("Amount_Tendered").Width = 150
        Nurse_Billing.BunifuCustomDataGrid3.Columns("Amount_Change").Width = 150
        Nurse_Billing.BunifuCustomDataGrid3.Columns("Time_In").Width = 150
        Nurse_Billing.BunifuCustomDataGrid3.Columns("Time_Out").Width = 150
        Nurse_Billing.BunifuCustomDataGrid3.Columns("Date").Width = 150
        Nurse_Billing.BunifuCustomDataGrid3.Columns("Processby").Width = 150
        MysqlConn.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timein.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub BunifuCustomTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuCustomTextbox1.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuCustomTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuCustomTextbox2.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuCustomTextbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuCustomTextbox3.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class