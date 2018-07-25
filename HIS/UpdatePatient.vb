Imports MySql.Data.MySqlClient
Public Class ffff

    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Sub Employeedatabase()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "select * from patient_tbl"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "id")
        Nurse_Patient.BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        MysqlConn.Close()
    End Sub

    Private Sub Add_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialSingleLineTextField4.Enabled = False
        MaterialSingleLineTextField6.ForeColor = Color.Gray
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "select * from patient_tbl"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "id")
        Nurse_Patient.BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        MysqlConn.Close()
    End Sub


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Hide()
    End Sub
    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime1.ValueChanged
        Dim Age As Double = Math.Floor(DateDiff(DateInterval.Month, MetroDateTime1.Value, System.DateTime.Now) / 12)
        MaterialSingleLineTextField4.Text = Age
    End Sub
    Private Sub MaterialSingleLineTextField6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField6.KeyPress
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
        If MaterialSingleLineTextField6.Text.Length >= 12 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MetroFramework.MetroMessageBox.Show(Me, "11 Digits Only.", "Patient", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        End If
    End Sub

    Private Sub MaterialSingleLineTextField7_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
    Private Sub MaterialSingleLineTextField8_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        MysqlConn.Open()
        Dim theQuery As String = "SELECT * FROM patient_tbl WHERE Firstname=@Username"
        Dim cmd1 As MySqlCommand = New MySqlCommand(theQuery, MysqlConn)
        cmd1.Parameters.AddWithValue("@Username", MaterialSingleLineTextField1.Text)

        Using reader As MySqlDataReader = cmd1.ExecuteReader()
            If reader.HasRows Then
                ' User already exists
                MetroFramework.MetroMessageBox.Show(Me, "Patient is already Exist!", "Invalid to Update!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                MaterialSingleLineTextField1.Clear()
            Else
                MysqlConn = New MySqlConnection
                MysqlConn.ConnectionString =
                    "server=localhost;userid=root;password=;database=HIS"
                Dim READER1 As MySqlDataReader

                Try
                    MysqlConn.Open()
                    Dim Query As String
                    Query = "Update patient_tbl set Patient_ID='" & TextBox1.Text & "',Firstname='" & MaterialSingleLineTextField1.Text & "',Lastname='" & MaterialSingleLineTextField2.Text & "',Middleinitial='" & MaterialSingleLineTextField3.Text & "',Dateofbirth='" & MetroDateTime1.Text &
                   "',Age='" & MaterialSingleLineTextField4.Text & "',Address='" & MaterialSingleLineTextField5.Text & "',Phonenumber='" & MaterialSingleLineTextField6.Text & "',Blood_Type='" & MaterialSingleLineTextField9.Text & "',Height='" & MaterialSingleLineTextField10.Text & "',Weight='" & MaterialSingleLineTextField7.Text & "',Temperature='" & MaterialSingleLineTextField11.Text & "',Blood_Pressure='" & MaterialSingleLineTextField8.Text & "',Pulse_Rate='" & MaterialSingleLineTextField12.Text & "',Marital_status='" & MetroComboBox1.Text & "',Gender='" & MetroComboBox2.Text & "' where Patient_ID = '" & TextBox1.Text & "'"
                    Command = New MySqlCommand(Query, MysqlConn)
                    READER1 = Command.ExecuteReader

                    MysqlConn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    Nurse_Patient.Show()
                    Me.Hide()
                    Employeedatabase()
                    MysqlConn.Dispose()
                    MetroFramework.MetroMessageBox.Show(Me, "Succesfully Updated!.", "Thankyou!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Nurse_Patient.TextBox2.Clear()
                End Try
            End If
        End Using

    End Sub


    Private Sub MaterialSingleLineTextField4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField4.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Nurse_Patient.TextBox2.Clear()
        Me.Hide()
    End Sub
End Class