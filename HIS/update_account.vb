Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class update_account
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim reEmail As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." + _
")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})", _
RegexOptions.IgnoreCase _
Or RegexOptions.CultureInvariant _
Or RegexOptions.IgnorePatternWhitespace _
Or RegexOptions.Compiled _
)
    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
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
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=HIS"
            Dim Reader As MySqlDataReader


            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Update user_accounts set id='" & TextBox1.Text & "',Firstname='" & MaterialSingleLineTextField1.Text & "',Lastname='" & MaterialSingleLineTextField2.Text & "',Address='" & MaterialSingleLineTextField3.Text & "',Phone_Number='" & MaterialSingleLineTextField4.Text & "',Email='" & MaterialSingleLineTextField5.Text & "',Username='" & MaterialSingleLineTextField6.Text & "',Password='" & MaterialSingleLineTextField7.Text & "',User_Type='" & MetroComboBox1.Text & "' where id = '" & TextBox1.Text & "'"
                Command = New MySqlCommand(Query, MysqlConn)
                MaterialSingleLineTextField1.Clear()
                MaterialSingleLineTextField2.Clear()
                MaterialSingleLineTextField3.Clear()
                MaterialSingleLineTextField4.Clear()
                MaterialSingleLineTextField5.Clear()
                MaterialSingleLineTextField6.Clear()

                Reader = Command.ExecuteReader

                MysqlConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MysqlConn.Dispose()
                Me.Hide()
                database()
                MetroFramework.MetroMessageBox.Show(Me, "Successfully Updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub
    Sub database()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "select * from user_accounts"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "id")
        Admin_Add_Accounts.BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        MysqlConn.Close()
        TextBox1.Clear()
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

    Private Sub MaterialSingleLineTextField4_Click(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField4.Click

    End Sub

    Private Sub update_account_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class