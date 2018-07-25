Imports MetroFramework
Imports MySql.Data.MySqlClient
Public Class Login
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim cn As New MySqlConnection("Server=127.0.0.1; User ID=root;Password=; Database=HIS")
    Public Property stringpass As String
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label8.Visible = False
        Label8.Text = DateTime.Now.ToLongDateString()
        Timer1.Start()
        MaterialSingleLineTextField2.UseSystemPasswordChar = True
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If MaterialSingleLineTextField2.UseSystemPasswordChar = True Then

            MaterialSingleLineTextField2.UseSystemPasswordChar = False
            BunifuImageButton1.Text = "Hide"
        Else
            MaterialSingleLineTextField2.UseSystemPasswordChar = True
            BunifuImageButton1.Text = "Show"
        End If
    End Sub
    Public cntAttempts = 0
    Private Async Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        If MaterialSingleLineTextField1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write your Username!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField2.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please write your Password!", "Fill All The Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim cmd As New MySqlCommand
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            Dim sql As String

            sql = "select * from user_accounts where Username ='" & MaterialSingleLineTextField1.Text & "' and Password = '" & MaterialSingleLineTextField2.Text & "'"
            With cmd
                .Connection = cn
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim username, password, usertype, status As String
                username = dt.Rows(0).Item(6)
                password = dt.Rows(0).Item(7)
                usertype = dt.Rows(0).Item(8)
                status = dt.Rows(0).Item(9)
                If usertype = "ADMIN" Then
                    If status = "ONLINE" Then
                        MetroFramework.MetroMessageBox.Show(Me, "Cannot be Access!", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        MetroFramework.MetroMessageBox.Show(Me, "Successfully Login! as " & usertype, "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        userlogs()
                        updatestatus()
                        MysqlConn = New MySqlConnection
                        MysqlConn.ConnectionString =
                            "server=localhost;userid=root;password=;database=HIS"
                        Dim READER As MySqlDataReader

                        Try

                            MysqlConn.Open()

                            Dim Sql2 As String
                            Sql2 = "Insert into userlogs (User_type,Time_in,Date) values ('" & MaterialSingleLineTextField1.Text & "','" & Label7.Text & "','" & Label8.Text & "')"
                            Command = New MySqlCommand(Sql2, MysqlConn)
                            READER = Command.ExecuteReader
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End If
                    Mainform.Show()
                    Me.Hide()
                ElseIf usertype = "NURSE" Then
                    MetroFramework.MetroMessageBox.Show(Me, "Successfully Login! as " & usertype, "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    userlogs()
                    MysqlConn = New MySqlConnection
                    MysqlConn.ConnectionString =
                        "server=localhost;userid=root;password=;database=HIS"
                    Dim READER As MySqlDataReader

                    Try

                        MysqlConn.Open()

                        Dim Sql1 As String
                        Sql1 = "Insert into userlogs (User_type,Time_in,Date) values ('" & MaterialSingleLineTextField1.Text & "','" & Label7.Text & "','" & Label8.Text & "')"

                        Command = New MySqlCommand(Sql1, MysqlConn)
                        READER = Command.ExecuteReader
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    Dim obj As New Nurse_Patient
                    obj.stringpass = MaterialSingleLineTextField1.Text
                    obj.Show()

                    Me.Hide()
                ElseIf usertype = "DOCTOR" Then


                    MetroFramework.MetroMessageBox.Show(Me, "Successfully Login! as " & usertype, "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    userlogs()
                    MysqlConn = New MySqlConnection
                    MysqlConn.ConnectionString =
                        "server=localhost;userid=root;password=;database=HIS"
                    Dim READER As MySqlDataReader

                    Try

                        MysqlConn.Open()

                        Dim Sql1 As String
                        Sql1 = "Insert into userlogs (User_type,Time_in,Date) values ('" & MaterialSingleLineTextField1.Text & "','" & Label7.Text & "','" & Label8.Text & "')"

                        Command = New MySqlCommand(Sql1, MysqlConn)
                        READER = Command.ExecuteReader
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    Dim obj As New Doctor_Patient
                    obj.stringpass = MaterialSingleLineTextField1.Text
                    obj.Show()

                    Me.Hide()
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Password or Username are Incorrect!", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cntAttempts += 1
                    If cntAttempts = 3 Then
                        MetroFramework.MetroMessageBox.Show(Me, "Please check your account!", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        BunifuThinButton21.Enabled = False

                        ' ... do something ...

                        Await Task.Delay(5000)

                        BunifuThinButton21.Enabled = True
                        cntAttempts = 0
                    End If
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Password or Username are Incorrect!", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cntAttempts += 1
                If cntAttempts = 3 Then
                    MetroFramework.MetroMessageBox.Show(Me, "Please check your account!", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    BunifuThinButton21.Enabled = False

                    ' ... do something ...

                    Await Task.Delay(5000)


                    BunifuThinButton21.Enabled = True
                    cntAttempts = 0
                End If

            End If
            da.Dispose()
        End If
    End Sub
    Sub userlogs()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "select * from userlogs"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "app_id")
        Admin_Userlog.BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        MysqlConn.Close()
    End Sub
    Sub adminlogin()
        Mainform.Show()
        Dim total As String = 0
        For i As Integer = 0 To Nurse_Billing.BunifuCustomDataGrid1.RowCount - 1
            total += Nurse_Billing.BunifuCustomDataGrid1.Rows(i).Cells(8).Value
            'Change the number 2 to your column index number (The first column has a 0 index column)
            'In this example the column index of Price is 2
        Next
        Mainform.Label18.Text = total
    End Sub
    Sub userlogin()
        Nurse_Patient.Show()
    End Sub
    Private Sub MaterialSingleLineTextField1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField1.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            BunifuThinButton21_Click(Me, EventArgs.Empty)
        End If
    End Sub
    Private Sub MaterialSingleLineTextField2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField2.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            BunifuThinButton21_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Select Case MetroMessageBox.Show(Me, "Are you sure to exit the application?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Case MsgBoxResult.Ok
                Application.Exit()
            Case MsgBoxResult.Cancel
        End Select
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub
    Sub updatestatus()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=HIS"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update user_accounts set id='" & Label10.Text & "',Status='" & Label9.Text & "'  where id = '" & Label10.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
            Me.Hide()
            MysqlConn.Close()
            MetroFramework.MetroMessageBox.Show(Me, "Successfully Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class