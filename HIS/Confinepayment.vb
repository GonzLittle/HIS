Imports MySql.Data.MySqlClient
Public Class Confinepayment
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Nurse_Billing.Confine.Clear()
        Nurse_Billing.RemarksConfine.Clear()
        Me.Hide()
        MaterialSingleLineTextField1.Text = 0
        MaterialSingleLineTextField2.Text = 0
        MaterialSingleLineTextField4.Text = 0
        MaterialCheckBox15.CheckState = CheckState.Unchecked
        Payment.Text = 0
        Change.Text = 0
    End Sub

    Sub dbcallbilling()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Quer1 As String = "SELECT Confine_ID,Patient_ID,Room_ID,Findings,Status_of_Deceased,Format(Total_Amount,2) as Total_Amount,Format(Additional_Charges,2) as Additional_Charges,Format(Discount,2) as Discount,Format(Total_Charges,2) as Total_Charges,Format(Amount_Tendered,2) as Amount_Tendered,Format(Amount_Change,2) as Amount_Change,Time_In,Time_Out,Date,Remarks from confine_tbl"
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
        MysqlConn.Close()


    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        If MaterialSingleLineTextField1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Input Amount", "Fill all the fields.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Val(Payment.Text) <= Val(MaterialSingleLineTextField1.Text) Then
            MetroFramework.MetroMessageBox.Show(Me, "Invalid Amount!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=HIS"
            Dim Reader As MySqlDataReader

            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Update confine_tbl set Confine_ID='" & TextBox1.Text & "',Additional_Charges='" & MaterialSingleLineTextField2.Text & "',Discount='" & MaterialSingleLineTextField4.Text & "' ,Total_Charges='" & Total.Text & "' ,Amount_Tendered='" & Payment.Text & "' ,Amount_Change ='" & Change.Text & "',Time_Out ='" & Time.Text & "',Remarks ='" & done.Text & "' where Confine_Id = '" & TextBox1.Text & "'"
                Command = New MySqlCommand(Query, MysqlConn)
                Reader = Command.ExecuteReader
                MysqlConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MysqlConn.Dispose()
                Me.Hide()
                dbcallbilling()
                updateroom()
                MysqlConn.Close()
                MetroFramework.MetroMessageBox.Show(Me, "Successfully Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub Payment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Payment.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub MaterialSingleLineTextField6_TextChanged(sender As Object, e As EventArgs) Handles Payment.TextChanged
        If Payment.Text = "" Then
            Change.Text = 0
        Else
            Change.Text = Val(Payment.Text) - Val(Total.Text)
        End If
    End Sub

    Private Sub Confinepayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Payment.Text = 0
        MaterialSingleLineTextField4.Text = 0
        MaterialSingleLineTextField1.Enabled = False
        Change.Enabled = False
        Total.Enabled = False
        MaterialSingleLineTextField4.Enabled = False
    End Sub

    Private Sub MaterialSingleLineTextField2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField2.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MaterialSingleLineTextField2_TextChanged(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField2.TextChanged
        Total.Text = Val(MaterialSingleLineTextField1.Text) + Val(MaterialSingleLineTextField2.Text)
    End Sub

    Private Sub MaterialCheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox15.CheckedChanged
        Dim a As Double = 0.2
        If MaterialCheckBox15.Checked Then
            MaterialSingleLineTextField4.Text = Val(Total.Text) * a
            Total.Text = Val(Total.Text) - Val(MaterialSingleLineTextField4.Text)
            TextBox2.Text = Val(Total.Text) * a
            Change.Text = Val(Payment.Text) - Val(Total.Text)
        ElseIf MaterialCheckBox15.CheckState = CheckState.Unchecked Then
            Total.Text = Val(MaterialSingleLineTextField4.Text) + Val(Total.Text)
            Change.Text = Val(Total.Text) - Val(Payment.Text)
            Change.Text = 0
            MaterialSingleLineTextField4.Text = 0
        Else
            MaterialSingleLineTextField4.Text = 0
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub
    Sub updateroom()
     
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=HIS"
            Dim Reader As MySqlDataReader
            Try
                MysqlConn.Open()
                Dim Query As String
            Query = "Update roominfo_tbl set Room_ID='" & Roomid.Text & "', Status='" & Available.Text & "' where Room_ID = '" & Roomid.Text & "'"
                Command = New MySqlCommand(Query, MysqlConn)
                Reader = Command.ExecuteReader
                MysqlConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MysqlConn.Dispose()
                Me.Hide()
            updatedb()
                MysqlConn.Close()
            End Try

    End Sub
    Sub updatedb()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from roominfo_tbl"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        Confineform.BunifuCustomDataGrid1.DataSource = dsa.Tables(0)
        MysqlConn.Close()
    End Sub

    Private Sub Payment_Click(sender As Object, e As EventArgs) Handles Payment.Click

    End Sub

    Private Sub MaterialSingleLineTextField2_Click(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField2.Click

    End Sub
End Class