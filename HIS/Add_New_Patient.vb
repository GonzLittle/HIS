Imports MySql.Data.MySqlClient

Public Class Add_New_Patient
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=192.168.43.159;userid=root;password=;database=HIS"
        If MaterialSingleLineTextField1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write your Firstname!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField2.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write Lastname!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField3.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write Middle Initial!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MetroDateTime1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please select Date of Birth!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MetroDateTime1.Value > Date.Today Then
            MetroFramework.MetroMessageBox.Show(Me, "Invalid Date in Date of Birth!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField4.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please choose date to Age!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField5.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write Address!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField6.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write Contact Number!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MetroComboBox3.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write Blood Type!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField8.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write Height!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField9.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write Weight!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField10.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write Temperature!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField11.Text = "Nothing" Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write Blood Pressure!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField11.Text = "0123456789" Then
            MetroFramework.MetroMessageBox.Show(Me, "Invalid Blood Pressure!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField12.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write Pulse Rate!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MetroComboBox1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please select Marital Status!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MetroComboBox2.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please select Gender!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MysqlConn.Open()
            Dim theQuery As String = "SELECT * FROM patient_tbl WHERE Firstname=@Username"
            Dim cmd1 As MySqlCommand = New MySqlCommand(theQuery, MysqlConn)
            cmd1.Parameters.AddWithValue("@Username", MaterialSingleLineTextField1.Text)

            Using reader As MySqlDataReader = cmd1.ExecuteReader()
                If reader.HasRows Then
                    ' User already exists
                    MetroFramework.MetroMessageBox.Show(Me, "Patient is already Exist!", "Invalid to Saved!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    MaterialSingleLineTextField1.Clear()
                Else
                    MysqlConn = New MySqlConnection
                    MysqlConn.ConnectionString =
                        "server=192.168.43.159;userid=root;password=;database=HIS"
                    Dim READER1 As MySqlDataReader

                    Try

                        MysqlConn.Open()

                        Dim Sql As String
                        Sql = "Insert into patient_tbl (Firstname,Lastname,Middleinitial,Dateofbirth,Age,Address,Phonenumber,Blood_Type,Height,Weight,Temperature,Blood_Pressure,Pulse_rate,Marital_Status,Gender) values ('" & MaterialSingleLineTextField1.Text & "','" & MaterialSingleLineTextField2.Text & "','" & MaterialSingleLineTextField3.Text & "','" & MetroDateTime1.Text & "','" & MaterialSingleLineTextField4.Text & "','" & MaterialSingleLineTextField5.Text & "','" & MaterialSingleLineTextField6.Text & "','" & MetroComboBox3.Text & "','" & MaterialSingleLineTextField8.Text & "','" & MaterialSingleLineTextField9.Text & "','" & MaterialSingleLineTextField10.Text & "','" & MaterialSingleLineTextField11.Text & "','" & MaterialSingleLineTextField12.Text & "','" & MetroComboBox1.Text & "','" & MetroComboBox2.Text & "')"

                        Command = New MySqlCommand(Sql, MysqlConn)
                        READER1 = Command.ExecuteReader
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    patientdatabase()
                    MysqlConn.Close()
                    Me.Hide()
                    MetroFramework.MetroMessageBox.Show(Me, "Successfully Added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End If
    End Sub

    Sub patientdatabase()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=192.168.43.159;userid=root;password=;database=HIS"
        Dim Query As String = "SELECT Patient_ID,Firstname,Lastname,Middleinitial,Dateofbirth,Age,Address,Phonenumber,Blood_type,Height,Format(Weight,1) as Weight,Format(Temperature,1) as Temperature,Blood_Pressure,Pulse_rate,Marital_status,Gender from patient_tbl"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "app_id")
        Nurse_Patient.BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        Nurse_Patient.BunifuCustomDataGrid1.Columns("Address").Width = 200
        Nurse_Patient.BunifuCustomDataGrid1.Columns("Dateofbirth").Width = 150
        Nurse_Patient.BunifuCustomDataGrid1.Columns("Phonenumber").Width = 150
        Nurse_Patient.BunifuCustomDataGrid1.Columns("Blood_Pressure").Width = 150
        Nurse_Patient.BunifuCustomDataGrid1.Columns("Marital_Status").Width = 150
        Nurse_Patient.BunifuCustomDataGrid1.Columns("Temperature").Width = 150
        MysqlConn.Close()

    End Sub

    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime1.ValueChanged
        Dim Age As Double = Math.Floor(DateDiff(DateInterval.Month, MetroDateTime1.Value, System.DateTime.Now) / 12)
        MaterialSingleLineTextField4.Text = Age
    End Sub

    Private Sub Add_New_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialSingleLineTextField4.Enabled = False

    End Sub

    Private Sub MaterialSingleLineTextField1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField1.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub MaterialSingleLineTextField2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField2.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub MaterialSingleLineTextField3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField3.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
        If MaterialSingleLineTextField3.Text.Length >= 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MetroFramework.MetroMessageBox.Show(Me, "2 Characters Only!", "Invalid Middle Initial", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub


    Private Sub MaterialSingleLineTextField4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField4.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub MaterialSingleLineTextField6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField6.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
        If MaterialSingleLineTextField6.Text.Length >= 11 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MetroFramework.MetroMessageBox.Show(Me, "11 Digits Only!", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub MaterialSingleLineTextField8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField8.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
        If MaterialSingleLineTextField8.Text.Length >= 3 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MetroFramework.MetroMessageBox.Show(Me, "3 Digits Only!", "Invalid Height", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Sub MaterialSingleLineTextField9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField9.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
        If MaterialSingleLineTextField9.Text.Length >= 3 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MetroFramework.MetroMessageBox.Show(Me, "3 Digits Only!", "Invalid Height", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Sub MaterialSingleLineTextField10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField10.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
        If MaterialSingleLineTextField10.Text.Length >= 3 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MetroFramework.MetroMessageBox.Show(Me, "3 Digits Only!", "Invalid Temperature", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Sub MaterialSingleLineTextField11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField11.KeyPress
        Dim allowedChars As String = "0123456789/"
        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
        If MaterialSingleLineTextField11.Text.Length >= 8 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MetroFramework.MetroMessageBox.Show(Me, "8 Characters Only!", "Invalid Blood Pressure", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub MaterialSingleLineTextField12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField12.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
        Dim allowedChars As String = "0123456789-/"
        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
        If MaterialSingleLineTextField12.Text.Length >= 7 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MetroFramework.MetroMessageBox.Show(Me, "7 Chacters Only!", "Invalid Pulse Rate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Hide()
    End Sub

    Private Sub MaterialSingleLineTextField6_Click(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField6.Click

    End Sub
End Class