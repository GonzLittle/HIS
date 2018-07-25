Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class Add_New_Physician
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim reEmail As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." + _
")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})", _
RegexOptions.IgnoreCase _
Or RegexOptions.CultureInvariant _
Or RegexOptions.IgnorePatternWhitespace _
Or RegexOptions.Compiled _
)

    Sub doctordatabase()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "select * from doctor_tbl"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "id")
        Admin_Physician.BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        MysqlConn.Close()
    End Sub


    Private Sub MaterialSingleLineTextField1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField1.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MaterialSingleLineTextField3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField3.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
        If MaterialSingleLineTextField3.Text.Length >= 11 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MetroFramework.MetroMessageBox.Show(Me, "11 Digits Only!", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub BunifuFlatButton5_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click

        If MaterialSingleLineTextField1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write your Name!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField2.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write your Address!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField3.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write your Phone Number!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField4.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write your Email!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Not MaterialSingleLineTextField4.Text.Equals(reEmail.Match(MaterialSingleLineTextField4.Text).ToString) Then
            MetroFramework.MetroMessageBox.Show(Me, "Invalid Email!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MetroComboBox1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please Choose Department!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else



            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString =
                "server=localhost;userid=root;password=;database=HIS"
            Dim READER As MySqlDataReader

            Try

                MysqlConn.Open()

                Dim Sql As String
                Sql = "Insert into doctor_tbl (Doctor_Name,Address,Phonenumber,Email,Department) values ('" & MaterialSingleLineTextField1.Text & "','" & MaterialSingleLineTextField2.Text & "','" & MaterialSingleLineTextField3.Text & "','" & MaterialSingleLineTextField4.Text & "','" & MetroComboBox1.Text & "')"
                Command = New MySqlCommand(Sql, MysqlConn)
                READER = Command.ExecuteReader
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Hide()
            doctordatabase()
            MysqlConn.Close()
            MetroFramework.MetroMessageBox.Show(Me, "Successfully Register.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class