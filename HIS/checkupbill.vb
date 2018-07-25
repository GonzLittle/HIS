Imports MySql.Data.MySqlClient

Public Class checkupbill
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Public Property stringpass As String
    Public Property stringpass1 As String
    Public Property reference As String
    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        If MaterialSingleLineTextField1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Input Amount", "Fill all the fields.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MaterialSingleLineTextField3.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Input Process by", "Fill all the fields.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Val(MaterialSingleLineTextField1.Text) <= Val(MaterialSingleLineTextField6.Text) Then
            MetroFramework.MetroMessageBox.Show(Me, "Invalid Amount!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=HIS"
            Dim Reader As MySqlDataReader

            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Update checkup set Reference_ID='" & Label5.Text & "',Additional_Charges='" & MaterialSingleLineTextField4.Text & "',Total_Due='" & MaterialSingleLineTextField6.Text & "',Amount_Payment='" & MaterialSingleLineTextField1.Text & "',Change_Amount='" & MaterialSingleLineTextField2.Text & "' ,Status='" & Label6.Text & "' ,Process_by='" & MaterialSingleLineTextField3.Text & "' where Reference_ID = '" & Label5.Text & "'"
                Command = New MySqlCommand(Query, MysqlConn)
                Reader = Command.ExecuteReader
                MysqlConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MysqlConn.Dispose()
                Me.Hide()
                dbcallbilling()
                MysqlConn.Close()
                MetroFramework.MetroMessageBox.Show(Me, "Successfully Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub
    Sub dbcallbilling()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from checkup"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        Nurse_Billing.BunifuCustomDataGrid2.DataSource = dsa.Tables(0)
        MysqlConn.Close()
    End Sub

    Private Sub checkupbill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = reference
        MaterialSingleLineTextField3.Text = stringpass
        MaterialSingleLineTextField5.Text = stringpass1
        MaterialSingleLineTextField3.Enabled = False
        MaterialSingleLineTextField2.Enabled = False
        MaterialSingleLineTextField5.Enabled = False
        MaterialSingleLineTextField6.Enabled = False
        Nurse_Billing.TextBox2.Clear()
    End Sub

    Private Sub MaterialSingleLineTextField1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField1.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MaterialSingleLineTextField1_TextChanged(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField1.TextChanged
        MaterialSingleLineTextField2.Text = Val(MaterialSingleLineTextField1.Text) - Val(MaterialSingleLineTextField6.Text)
    End Sub




    Private Sub MaterialSingleLineTextField3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField3.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MaterialSingleLineTextField4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField4.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub MaterialSingleLineTextField4_TextChanged(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField4.TextChanged
        MaterialSingleLineTextField6.Text = Val(MaterialSingleLineTextField4.Text) + Val(MaterialSingleLineTextField5.Text)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub
End Class