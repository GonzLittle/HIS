Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Public Class Add_Account
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim reEmail As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." + _
")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})", _
RegexOptions.IgnoreCase _
Or RegexOptions.CultureInvariant _
Or RegexOptions.IgnorePatternWhitespace _
Or RegexOptions.Compiled _
)

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        If MaterialSingleLineTextField1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write your Firstname!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField2.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write your Lastname!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField3.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write your Address!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField4.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write your Contact Number!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField5.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write your Email!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Not MaterialSingleLineTextField5.Text.Equals(reEmail.Match(MaterialSingleLineTextField5.Text).ToString) Then
            MetroFramework.MetroMessageBox.Show(Me, "Invalid Email!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField6.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write your Username!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField7.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write your Password!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MetroComboBox1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please select User Type!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField7.Text <> MaterialSingleLineTextField8.Text Then
            MetroFramework.MetroMessageBox.Show(Me, "Your Password is not Match!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MysqlConn.Open()
            Dim theQuery As String = "SELECT * FROM user_accounts WHERE Username=@Username"
            Dim cmd1 As MySqlCommand = New MySqlCommand(theQuery, MysqlConn)
            cmd1.Parameters.AddWithValue("@Username", MaterialSingleLineTextField6.Text)

            Using reader As MySqlDataReader = cmd1.ExecuteReader()
                If reader.HasRows Then
                    ' User already exists
                    MetroFramework.MetroMessageBox.Show(Me, "User is already Exist!", "Try Another User Account", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    MaterialSingleLineTextField6.Clear()
                Else
                    MysqlConn = New MySqlConnection
                    MysqlConn.ConnectionString =
                        "server=localhost;userid=root;password=;database=HIS"
                    Dim READER1 As MySqlDataReader

                    Try

                        MysqlConn.Open()

                        Dim Sql As String
                        Sql = "Insert into user_accounts (Firstname,Lastname,Address,Phone_Number,Email,Username,Password,User_type) values ('" & MaterialSingleLineTextField1.Text & "','" & MaterialSingleLineTextField2.Text & "','" & MaterialSingleLineTextField3.Text & "','" & MaterialSingleLineTextField4.Text & "','" & MaterialSingleLineTextField5.Text & "','" & MaterialSingleLineTextField6.Text & "','" & MaterialSingleLineTextField7.Text & "','" & MetroComboBox1.Text & "')"
                        Command = New MySqlCommand(Sql, MysqlConn)
                        READER1 = Command.ExecuteReader

                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    Me.Hide()
                    doctordatabase()
                    MysqlConn.Close()
                    MetroFramework.MetroMessageBox.Show(Me, "Successfully Added.", "Registered.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MaterialSingleLineTextField1.Clear()
                    MaterialSingleLineTextField2.Clear()
                    MaterialSingleLineTextField3.Clear()
                    MaterialSingleLineTextField4.Clear()
                    MaterialSingleLineTextField5.Clear()
                    MaterialSingleLineTextField6.Clear()
                    MaterialSingleLineTextField7.Clear()
                    MaterialSingleLineTextField8.Clear()
                End If
            End Using
        End If
    End Sub

    Sub doctordatabase()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "select * from user_accounts"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "id")
        Admin_Add_Accounts.BunifuCustomDataGrid1.DataSource = ds.Tables(0)
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
    Private Sub MaterialSingleLineTextField2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField2.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub MaterialSingleLineTextField4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField4.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
        If MaterialSingleLineTextField4.Text.Length >= 12 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MetroFramework.MetroMessageBox.Show(Me, "12 Digits Only!", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub MaterialSingleLineTextField1_Click(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField1.Click

    End Sub

    Private Sub MaterialSingleLineTextField4_Click(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField4.Click

    End Sub

    Private Sub MaterialSingleLineTextField5_Click(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField5.Click

    End Sub

    Private Sub MaterialSingleLineTextField5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField5.KeyPress

    End Sub

    Private Sub Add_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class