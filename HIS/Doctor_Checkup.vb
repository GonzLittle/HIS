Imports MySql.Data.MySqlClient
Imports MetroFramework
Public Class Doctor_Checkup
    Dim MysqlConn As MySqlConnection
    Dim Conn As MySqlConnection
    Dim Command As MySqlCommand
    Dim cmd As MySqlCommand
    Public Property stringpass As String
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)
        Nurse_Billing.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs)
        Add_Treatment.Show()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        BunifuFlatButton1.selected = True
        Panel3.Location = New Point(200, 134)
        Panel.Width = 52
        Panel.Visible = False
        PictureBox2.Visible = False
        panelanimator1.Show(Panel)
        BunifuImageButton4.Visible = True
        BunifuImageButton3.Visible = False
        Label1.Visible = False
        logoanimator.Hide(PictureBox2)
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs)
        BunifuFlatButton1.selected = True
        Panel3.Location = New Point(270, 132)
        Panel.Width = 222
        Panel.Visible = False
        animator1.Show(Panel)
        BunifuImageButton4.Visible = False
        BunifuImageButton3.Visible = True
        Label1.Visible = True
        logoanimator.ShowSync(PictureBox2)
    End Sub
    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs)
        Nurse_Patient.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click_1(sender As Object, e As EventArgs)
        Nurse_Billing.Show()
        Me.Hide()
    End Sub

    Private Sub Employee_Medical_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label9.Text = stringpass
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from userlogs"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        DataGridView1.DataSource = dsa.Tables(0)
        Label8.Text = dsa.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()


        Timer1.Start()
        BunifuImageButton4.Visible = False
        BunifuFlatButton1.selected = True
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query1 As String = "select * from patient_tbl"
        Dim adpter As New MySqlDataAdapter(Query1, MysqlConn)
        Dim dss As New DataSet()
        adpter.Fill(dss, "app_id")
        BunifuCustomDataGrid1.DataSource = dss.Tables(0)
        BunifuCustomDataGrid1.Columns("Address").Width = 200
        BunifuCustomDataGrid1.Columns("Dateofbirth").Width = 150
        BunifuCustomDataGrid1.Columns("Phonenumber").Width = 150
        BunifuCustomDataGrid1.Columns("Blood_Pressure").Width = 150
        BunifuCustomDataGrid1.Columns("Marital_Status").Width = 150
        BunifuCustomDataGrid1.Columns("Temperature").Width = 150
        MysqlConn.Close()

        Label4.Text = DateTime.Now.ToLongDateString()
        Timer1.Start()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Me.Hide()
        Dim obj As New Doctor_Lab
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()
    End Sub


    Private Sub BunifuFlatButton5_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Me.Hide()
        Dim obj As New Doctor_Patient
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()

    End Sub


    Private Sub BunifuImageButton4_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        BunifuFlatButton1.selected = True
        Panel3.Location = New Point(270, 134)
        Panel.Width = 222
        Panel.Visible = False
        animator1.Show(Panel)
        BunifuImageButton4.Visible = False
        BunifuImageButton3.Visible = True
        Label1.Visible = True
        logoanimator.ShowSync(PictureBox2)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Select Case MetroMessageBox.Show(Me, "Are you sure to exit the application?", "LOG OUT.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            Case MsgBoxResult.Ok
                Login.Show()
                Login.MaterialSingleLineTextField1.Clear()
                Login.MaterialSingleLineTextField2.Clear()
                Me.Hide()
            Case MsgBoxResult.Cancel
        End Select
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=HIS"
        Dim Reader As MySqlDataReader


        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Update userlogs set id='" & Label8.Text & "',Time_out= '" & Label3.Text & "' where id = '" & Label8.Text & "'"
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
    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Me.Hide()
        Dim obj As New Doctor_Records
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()

    End Sub

    Private Sub BunifuFlatButton6_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("Patient_ID").Value.ToString
            TextBox2.Text = row.Cells("Firstname").Value.ToString
            TextBox3.Text = row.Cells("Lastname").Value.ToString
        End If
    End Sub

    Private Sub BunifuMetroTextbox4_OnValueChanged_1(sender As Object, e As EventArgs) Handles BunifuMetroTextbox4.OnValueChanged
        Dim Santie As New MySqlDataAdapter
        Dim Pelayo As New DataTable
        Dim binding As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * from patient_tbl where CONCAT(Firstname,Lastname,Middleinitial,Dateofbirth,Age,Address,Phonenumber,Blood_Type,Height,Weight,Temperature,Blood_Pressure,Pulse_rate,Marital_Status,Gender) LIKE '%" & BunifuMetroTextbox4.Text & "%'"
            Command = New MySqlCommand(Query, MysqlConn)
            Santie.SelectCommand = Command
            Santie.Fill(Pelayo)
            binding.DataSource = Pelayo
            BunifuCustomDataGrid1.DataSource = binding
            Santie.Update(Pelayo)
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        If TextBox1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please choose patient record to be prescribe", "Select", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim obj As New Add_Treatment
            obj.stringpass = Login.MaterialSingleLineTextField1.Text

            obj.stringpass1 = TextBox1.Text
            obj.stringpass2 = TextBox2.Text
            obj.stringpass3 = TextBox3.Text

            obj.Show()

        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

    End Sub
End Class