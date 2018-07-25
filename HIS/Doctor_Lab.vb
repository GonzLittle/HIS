Imports MySql.Data.MySqlClient
Imports MetroFramework
Public Class Doctor_Lab

    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Public Property stringpass As String
    Private Sub Employee_Bed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label9.Text = stringpass
        BunifuFlatButton4.selected = True
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Query As String = "select * from patient_tbl"
        Dim adpt As New MySqlDataAdapter(Query, MysqlConn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "app_id")
        BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        BunifuCustomDataGrid1.Columns("Address").Width = 200
        BunifuCustomDataGrid1.Columns("Dateofbirth").Width = 150
        BunifuCustomDataGrid1.Columns("Phonenumber").Width = 150
        BunifuCustomDataGrid1.Columns("Blood_Pressure").Width = 150
        BunifuCustomDataGrid1.Columns("Marital_Status").Width = 150
        BunifuCustomDataGrid1.Columns("Temperature").Width = 150
        MysqlConn.Close()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from userlogs"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        DataGridView1.DataSource = dsa.Tables(0)
        Label5.Text = dsa.Tables(0).Rows.Count.ToString()
        MysqlConn.Close()
        Timer1.Start()

        BunifuImageButton4.Visible = False
        Timer1.Start()
        Label4.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        If TextBox1.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please choose record to add laboratory test", "Choose Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim obj As New Laboratory
            obj.stringpass = Login.MaterialSingleLineTextField1.Text
            obj.stringpass1 = TextBox1.Text
            obj.Show()

        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)
        Nurse_Billing.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Hide()
        Dim obj As New Doctor_Checkup
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()

    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Me.Hide()
        Dim obj As New Doctor_Patient
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        BunifuFlatButton4.selected = True
        Panel3.Location = New Point(200, 132)
        Panel.Width = 52
        Panel.Visible = False
        PictureBox2.Visible = False
        panelanimator1.Show(Panel)
        BunifuImageButton4.Visible = True
        BunifuImageButton3.Visible = False
        Label1.Visible = False
        logoanimator.Hide(PictureBox2)
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        BunifuFlatButton4.selected = True
        Panel3.Location = New Point(270, 132)
        Panel.Width = 222
        Panel.Visible = False
        animator1.Show(Panel)
        BunifuImageButton4.Visible = False
        BunifuImageButton3.Visible = True
        Label1.Visible = True
        logoanimator.ShowSync(PictureBox2)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay.ToString("h:mm:ss tt")
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
            Query = "Update userlogs set id='" & Label5.Text & "',Time_out= '" & Label3.Text & "' where id = '" & Label5.Text & "'"
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

    Private Sub BunifuFlatButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Me.Hide()
        Dim obj As New Doctor_Records
        obj.stringpass = Login.MaterialSingleLineTextField1.Text
        obj.Show()

    End Sub
    Private Sub BunifuCustomDataGrid1_CellClick1(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = BunifuCustomDataGrid1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("Patient_ID").Value.ToString
            Laboratory.Label7.Text = row.Cells("Patient_ID").Value.ToString
        End If
    End Sub

    Private Sub BunifuMetroTextbox4_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox4.OnValueChanged
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

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs)
        Nurse_Admission.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click

    End Sub
End Class