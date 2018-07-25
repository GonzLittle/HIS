Imports MySql.Data.MySqlClient
Public Class Add_Treatment
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim cmd As MySqlCommand
    Dim command1 As MySqlCommand
    Dim type As String
    Public Property stringpass As String
    Public Property stringpass1 As String
    Public Property stringpass2 As String
    Public Property stringpass3 As String
    Private Sub Add_Treatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialSingleLineTextField1.Text = stringpass
        Label11.Text = stringpass1
        Label17.Text = stringpass2
        Label22.Text = stringpass3
        MaterialSingleLineTextField1.Enabled = False
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "select Reference_ID,PatientID,Findings,Prescribe_Medicine,Treatment,Prescribed_by from checkup where PatientID = '" & Label11.Text & "'"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "id")
        BunifuCustomDataGrid1.DataSource = ds.Tables(0)

        MysqlConn.Close()

        Label1.Text = DateTime.Now.ToLongDateString()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
      
            If BunifuCustomTextbox1.Text = Nothing Then
                MetroFramework.MetroMessageBox.Show(Me, "Please input Findings to patient", "Missing Fields!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf BunifuCustomTextbox2.Text = Nothing Then
                MetroFramework.MetroMessageBox.Show(Me, "Please input Treatment to patient", "Missing Fields!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf BunifuCustomTextbox3.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please input Prescribe Medicine to patient", "Missing Fields!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
     
        ElseIf BunifuDatepicker1.Value < Date.Today Then
            MetroFramework.MetroMessageBox.Show(Me, "Please Select Proper Date!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MessageBox.Show("Are you sure to save?", "Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString =
                "server=localhost;userid=root;password=;database=HIS"
            Dim READER As MySqlDataReader

            Try
                MysqlConn.Open()
                Dim Sql As String
                Sql = "Insert into checkup (PatientID,Findings,Prescribe_Medicine,Treatment,Prescribed_by,Schedule_of_Checkup,Consultation_Fee,Amount_Payment,Change_Amount,Status,Process_by,Time,Date) values ('" & Label11.Text & "','" & BunifuCustomTextbox1.Text & "','" & BunifuCustomTextbox3.Text & "','" & BunifuCustomTextbox2.Text & "','" & MaterialSingleLineTextField1.Text & "','" & BunifuDatepicker1.Value & "','" & Label3.Text & "','" & Amount_Payment.Text & "','" & Change_Amount.Text & "','" & Status.Text & "','" & Processby.Text & "','" & Time.Text & "','" & Label1.Text & "')"
                command1 = New MySqlCommand(Sql, MysqlConn)
                READER = command1.ExecuteReader

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            checkup1()
            checkup2()
            checkupdatabase()
            MysqlConn.Close()
            Me.Hide()
            MetroFramework.MetroMessageBox.Show(Me, "Successfully Saved.", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Doctor_Checkup.TextBox1.Clear()
            BunifuCustomTextbox1.Clear()
            BunifuCustomTextbox2.Clear()
            BunifuCustomTextbox3.Clear()

        End If

    End Sub
    Sub checkupdatabase()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "select * from patient_tbl"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "id")
        Doctor_Checkup.BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        MysqlConn.Close()
    End Sub

    Sub checkup2()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "select * from checkup"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "id")
        BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        MysqlConn.Close()
    End Sub
    Sub checkup1()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "select * from checkup"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "id")
        Nurse_Billing.BunifuCustomDataGrid2.DataSource = ds.Tables(0)
        MysqlConn.Close()
    End Sub

    Private Sub MaterialRadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        type = "New Patient"
    End Sub


    Private Sub MaterialSingleLineTextField10_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub MaterialSingleLineTextField9_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub MaterialSingleLineTextField1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub MaterialSingleLineTextField2_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
    Private Sub MaterialSingleLineTextField3_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub MaterialSingleLineTextField5_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub BunifuMetroTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub MaterialSingleLineTextField1_KeyPress1(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
        Doctor_Checkup.Show()
        Doctor_Checkup.TextBox1.Clear()
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



    Private Sub BunifuCustomTextbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuCustomTextbox3.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz 1234567890/-"
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

    Private Sub BunifuCustomTextbox4_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuCustomTextbox3_TextChanged(sender As Object, e As EventArgs) Handles BunifuCustomTextbox3.TextChanged

    End Sub
End Class