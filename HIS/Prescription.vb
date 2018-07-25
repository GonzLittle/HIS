Imports MySql.Data.MySqlClient
Imports MetroFramework
Public Class Prescription
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim cmd As MySqlCommand
    Dim finaltotal As Double
    Private Sub Prescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Doctor_Lab.TextBox1.Clear()
        Timer1.Start()
        TextBox1.Visible = False
        Label12.Text = DateTime.Now.ToLongDateString()
        Label6.Text = 0
    End Sub
    Sub dbcall()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Dim Querya As String = "select * from Billing"
        Dim adpta As New MySqlDataAdapter(Querya, MysqlConn)
        Dim dsa As New DataSet()
        adpta.Fill(dsa, "app_id")
        Nurse_Billing.BunifuCustomDataGrid1.DataSource = dsa.Tables(0)
        MysqlConn.Close()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
                MysqlConn = New MySqlConnection
                MysqlConn.ConnectionString =
                    "server=localhost;userid=root;password=;database=HIS"
                Dim reader As MySqlDataReader
                Dim strListitem As String = Nothing
                strListitem = ControlChars.CrLf
                For Each item In ListBox1.Items
                    strListitem &= item.ToString & ControlChars.CrLf
                Next
                Try
                    MysqlConn.Open()
                    Dim Sql As String
            Sql = "Insert into invoice_tbl (Patient_ID,Lab_ID,Amount_Tendered,Discount,Amount_Change,Date,Processby) values ( '" & Label7.Text & "','" & strListitem & "','" & Label31.Text & "','" & Label43.Text & "','" & Laboratory.Label14.Text & "','" & Label12.Text & "','" & Label3.Text & "')"
                    cmd = New MySqlCommand(Sql, MysqlConn)
                    reader = cmd.ExecuteReader
                    Me.Hide()
                    MetroFramework.MetroMessageBox.Show(Me, "Successfully Saved.", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dbcall()

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                MysqlConn.Close()
      
       
    End Sub

    Private Sub MaterialCheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox2.CheckedChanged
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        Dim dd As Double
        Dim ee As Double
        Dim cc As Double
        Dim bb As Double
        Dim total As Double
        If MaterialCheckBox2.Checked Then

            TextBox3.Text = "ECG - P100"
            BunifuMetroTextbox2.Text = 100
            a = Val(BunifuMetroTextbox1.Text)
            b = Val(BunifuMetroTextbox2.Text)
            c = Val(BunifuMetroTextbox3.Text)
            d = Val(BunifuMetroTextbox5.Text)
            dd = Val(BunifuMetroTextbox5.Text)
            ee = Val(BunifuMetroTextbox7.Text)
            cc = Val(BunifuMetroTextbox8.Text)
            bb = Val(BunifuMetroTextbox9.Text)
            total = a + b + c + d + dd + ee + cc + bb
            Label6.Text = total
            ListBox1.Items.Add(TextBox3.Text)
        ElseIf MaterialCheckBox2.CheckState = CheckState.Unchecked Then
            BunifuMetroTextbox2.Text = ""
            TextBox3.Text = " "
        End If
    End Sub

    Private Sub MaterialCheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox12.CheckedChanged
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        Dim dd As Double
        Dim ee As Double
        Dim cc As Double
        Dim bb As Double
        Dim total As Double
        If MaterialCheckBox12.Checked Then
            TextBox4.Text = "CBC - P75"
            BunifuMetroTextbox3.Text = 75
            a = Val(BunifuMetroTextbox1.Text)
            b = Val(BunifuMetroTextbox2.Text)
            c = Val(BunifuMetroTextbox3.Text)
            d = Val(BunifuMetroTextbox5.Text)
            dd = Val(BunifuMetroTextbox6.Text)
            ee = Val(BunifuMetroTextbox7.Text)
            cc = Val(BunifuMetroTextbox8.Text)
            bb = Val(BunifuMetroTextbox9.Text)
            total = a + b + c + d + dd + ee + cc + bb
            Label6.Text = total
            ListBox1.Items.Add(TextBox4.Text)
        ElseIf MaterialCheckBox12.CheckState = CheckState.Unchecked Then
            BunifuMetroTextbox3.Text = ""
            TextBox4.Text = " "
        End If
    End Sub

    Private Sub MaterialCheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox4.CheckedChanged
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        Dim dd As Double
        Dim ee As Double
        Dim cc As Double
        Dim bb As Double
        Dim total As Double
        If MaterialCheckBox4.Checked Then
            TextBox5.Text = "Platelet Count - P75"
            BunifuMetroTextbox5.Text = 75
            a = Val(BunifuMetroTextbox1.Text)
            b = Val(BunifuMetroTextbox2.Text)
            c = Val(BunifuMetroTextbox3.Text)
            d = Val(BunifuMetroTextbox5.Text)
            dd = Val(BunifuMetroTextbox6.Text)
            ee = Val(BunifuMetroTextbox7.Text)
            cc = Val(BunifuMetroTextbox8.Text)
            bb = Val(BunifuMetroTextbox9.Text)
            total = a + b + c + d + dd + ee + cc + bb
            Label6.Text = total
            ListBox1.Items.Add(TextBox5.Text)
        ElseIf MaterialCheckBox4.CheckState = CheckState.Unchecked Then
            BunifuMetroTextbox5.Text = ""
            TextBox5.Text = " "
        End If
    End Sub

    Private Sub MaterialCheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox5.CheckedChanged
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        Dim dd As Double
        Dim ee As Double
        Dim bb As Double
        Dim cc As Double
        Dim total As Double

        If MaterialCheckBox5.Checked Then
            TextBox6.Text = "Urinalysis - P50"
            BunifuMetroTextbox6.Text = 50
            a = Val(BunifuMetroTextbox1.Text)
            b = Val(BunifuMetroTextbox2.Text)
            c = Val(BunifuMetroTextbox3.Text)
            d = Val(BunifuMetroTextbox5.Text)
            dd = Val(BunifuMetroTextbox6.Text)
            ee = Val(BunifuMetroTextbox7.Text)
            cc = Val(BunifuMetroTextbox8.Text)
            bb = Val(BunifuMetroTextbox9.Text)
            total = a + b + c + d + dd + ee + cc + bb
            Label6.Text = total
            ListBox1.Items.Add(TextBox6.Text)
        ElseIf MaterialCheckBox5.CheckState = CheckState.Unchecked Then
            BunifuMetroTextbox6.Text = ""
            TextBox6.Text = " "
        End If
    End Sub


    Private Sub MaterialCheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox7.CheckedChanged
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        Dim dd As Double
        Dim ee As Double
        Dim cc As Double
        Dim bb As Double
        Dim total As Double
        If MaterialCheckBox7.Checked Then
            TextBox7.Text = "Papsmear - P250"
            BunifuMetroTextbox7.Text = 250
            a = Val(BunifuMetroTextbox1.Text)
            b = Val(BunifuMetroTextbox2.Text)
            c = Val(BunifuMetroTextbox3.Text)
            d = Val(BunifuMetroTextbox5.Text)
            dd = Val(BunifuMetroTextbox6.Text)
            ee = Val(BunifuMetroTextbox7.Text)
            cc = Val(BunifuMetroTextbox8.Text)
            bb = Val(BunifuMetroTextbox9.Text)
            total = a + b + c + d + dd + ee + cc + bb
            Label6.Text = total
            ListBox1.Items.Add(TextBox7.Text)
        ElseIf MaterialCheckBox7.CheckState = CheckState.Unchecked Then
            BunifuMetroTextbox7.Text = " "
            TextBox7.Text = " "
        End If
    End Sub

    Private Sub MaterialCheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox9.CheckedChanged
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        Dim dd As Double
        Dim ee As Double
        Dim cc As Double
        Dim bb As Double
        Dim total As Double
        If MaterialCheckBox9.Checked Then
            TextBox8.Text = "X-ray - P180"
            BunifuMetroTextbox8.Text = 180
            a = Val(BunifuMetroTextbox1.Text)
            b = Val(BunifuMetroTextbox2.Text)
            c = Val(BunifuMetroTextbox3.Text)
            d = Val(BunifuMetroTextbox5.Text)
            dd = Val(BunifuMetroTextbox6.Text)
            ee = Val(BunifuMetroTextbox7.Text)
            cc = Val(BunifuMetroTextbox8.Text)
            bb = Val(BunifuMetroTextbox9.Text)
            total = a + b + c + d + dd + ee + cc + bb
            Label6.Text = total
            ListBox1.Items.Add(TextBox8.Text)
        ElseIf MaterialCheckBox9.CheckState = CheckState.Unchecked Then
            BunifuMetroTextbox8.Text = " "
            TextBox8.Text = " "
        End If
    End Sub

    Private Sub MaterialCheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox6.CheckedChanged
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        Dim dd As Double
        Dim ee As Double
        Dim cc As Double
        Dim bb As Double
        Dim total As Double
        If MaterialCheckBox6.Checked Then
            TextBox9.Text = "Bun - P250"
            BunifuMetroTextbox9.Text = 250
            a = Val(BunifuMetroTextbox1.Text)
            b = Val(BunifuMetroTextbox2.Text)
            c = Val(BunifuMetroTextbox3.Text)
            d = Val(BunifuMetroTextbox5.Text)
            dd = Val(BunifuMetroTextbox6.Text)
            ee = Val(BunifuMetroTextbox7.Text)
            cc = Val(BunifuMetroTextbox8.Text)
            bb = Val(BunifuMetroTextbox9.Text)
            total = a + b + c + d + dd + ee + cc + bb
            Label6.Text = total
            ListBox1.Items.Add(TextBox9.Text)
        ElseIf MaterialCheckBox6.CheckState = CheckState.Unchecked Then
            BunifuMetroTextbox9.Text = " "
            TextBox9.Text = " "
        End If
    End Sub

    Private Sub MaterialCheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox14.CheckedChanged
        Dim aaa As Double
        Dim bbb As Double
        Dim ccc As Double
        Dim ddd As Double
        Dim eee As Double
        Dim fff As Double
        Dim total As Double
        If MaterialCheckBox14.Checked Then
            TextBox10.Text = "Pelvic - P150"
            BunifuMetroTextbox10.Text = 150
            aaa = Val(BunifuMetroTextbox10.Text)
            bbb = Val(BunifuMetroTextbox11.Text)
            ccc = Val(BunifuMetroTextbox12.Text)
            ddd = Val(BunifuMetroTextbox13.Text)
            eee = Val(BunifuMetroTextbox14.Text)
            fff = Val(BunifuMetroTextbox15.Text)
            total = aaa + bbb + ccc + ddd + eee + fff
            Label5.Text = total
            ListBox1.Items.Add(TextBox10.Text)
        ElseIf MaterialCheckBox14.CheckState = CheckState.Unchecked Then
            BunifuMetroTextbox10.Text = " "
            TextBox10.Text = " "
        End If
    End Sub

    Private Sub MaterialCheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox13.CheckedChanged
        Dim aaa As Double
        Dim bbb As Double
        Dim ccc As Double
        Dim ddd As Double
        Dim eee As Double
        Dim fff As Double
        Dim total As Double
        If MaterialCheckBox13.Checked Then
            TextBox11.Text = "KUB - P200"
            BunifuMetroTextbox11.Text = 200
            aaa = Val(BunifuMetroTextbox10.Text)
            bbb = Val(BunifuMetroTextbox11.Text)
            ccc = Val(BunifuMetroTextbox12.Text)
            ddd = Val(BunifuMetroTextbox13.Text)
            eee = Val(BunifuMetroTextbox14.Text)
            fff = Val(BunifuMetroTextbox15.Text)
            total = aaa + bbb + ccc + ddd + eee + fff
            Label5.Text = total
            ListBox1.Items.Add(TextBox11.Text)
        ElseIf MaterialCheckBox13.CheckState = CheckState.Unchecked Then
            BunifuMetroTextbox11.Text = " "
            TextBox11.Text = " "
        End If
    End Sub

    Private Sub MaterialCheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox3.CheckedChanged
        Dim aaa As Double
        Dim bbb As Double
        Dim ccc As Double
        Dim ddd As Double
        Dim eee As Double
        Dim fff As Double
        Dim total As Double
        If MaterialCheckBox3.Checked Then
            TextBox11.Text = "Trans-V - P250"
            BunifuMetroTextbox12.Text = 250
            aaa = Val(BunifuMetroTextbox10.Text)
            bbb = Val(BunifuMetroTextbox11.Text)
            ddd = Val(BunifuMetroTextbox13.Text)
            eee = Val(BunifuMetroTextbox14.Text)
            fff = Val(BunifuMetroTextbox15.Text)
            total = aaa + bbb + ccc + ddd + eee + fff
            Label5.Text = total
            ListBox1.Items.Add(TextBox11.Text)
        ElseIf MaterialCheckBox3.CheckState = CheckState.Unchecked Then
            BunifuMetroTextbox12.Text = " "
            TextBox11.Text = " "
        End If
    End Sub

    Private Sub MaterialCheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox11.CheckedChanged
        Dim aaa As Double
        Dim bbb As Double
        Dim ccc As Double
        Dim ddd As Double
        Dim fff As Double
        Dim eee As Double
        Dim total As Double
        If MaterialCheckBox11.Checked Then
            TextBox12.Text = "Whole Abdomen - P500"
            BunifuMetroTextbox13.Text = 500
            aaa = Val(BunifuMetroTextbox10.Text)
            bbb = Val(BunifuMetroTextbox11.Text)
            ccc = Val(BunifuMetroTextbox12.Text)
            ddd = Val(BunifuMetroTextbox13.Text)
            eee = Val(BunifuMetroTextbox14.Text)
            fff = Val(BunifuMetroTextbox15.Text)
            total = aaa + bbb + ccc + ddd + eee + fff
            Label5.Text = total
            ListBox1.Items.Add(TextBox12.Text)
        ElseIf MaterialCheckBox11.CheckState = CheckState.Unchecked Then
            BunifuMetroTextbox13.Text = " "
            TextBox12.Text = " "
        End If
    End Sub

    Private Sub MaterialCheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox10.CheckedChanged
        Dim aaa As Double
        Dim bbb As Double
        Dim ccc As Double
        Dim ddd As Double
        Dim eee As Double
        Dim fff As Double
        Dim total As Double
        If MaterialCheckBox10.Checked Then
            TextBox13.Text = "Prostate - P250"
            BunifuMetroTextbox14.Text = 250
            aaa = Val(BunifuMetroTextbox10.Text)
            bbb = Val(BunifuMetroTextbox11.Text)
            ccc = Val(BunifuMetroTextbox12.Text)
            ddd = Val(BunifuMetroTextbox13.Text)
            eee = Val(BunifuMetroTextbox14.Text)
            fff = Val(BunifuMetroTextbox15.Text)
            total = aaa + bbb + ccc + ddd + eee + fff
            Label5.Text = total
            ListBox1.Items.Add(TextBox13.Text)
        ElseIf MaterialCheckBox10.CheckState = CheckState.Unchecked Then
            BunifuMetroTextbox14.Text = " "
            TextBox13.Text = " "
        End If
    End Sub

    Private Sub MaterialCheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox8.CheckedChanged
        Dim aaa As Double
        Dim bbb As Double
        Dim ccc As Double
        Dim ddd As Double
        Dim eee As Double
        Dim fff As Double
        Dim total As Double
        If MaterialCheckBox8.Checked Then
            TextBox14.Text = "BPS - P300"
            BunifuMetroTextbox14.Text = 300
            aaa = Val(BunifuMetroTextbox10.Text)
            bbb = Val(BunifuMetroTextbox11.Text)
            ccc = Val(BunifuMetroTextbox12.Text)
            ddd = Val(BunifuMetroTextbox13.Text)
            eee = Val(BunifuMetroTextbox14.Text)
            fff = Val(BunifuMetroTextbox15.Text)
            total = aaa + bbb + ccc + ddd + eee + fff
            Label5.Text = total
            ListBox1.Items.Add(TextBox14.Text)
        ElseIf MaterialCheckBox8.CheckState = CheckState.Unchecked Then
            BunifuMetroTextbox14.Text = " "
            TextBox14.Text = " "
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label40.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        MaterialCheckBox2.CheckState = CheckState.Unchecked
        BunifuMetroTextbox3.Text = 0
        MaterialCheckBox3.CheckState = CheckState.Unchecked
        BunifuMetroTextbox5.Text = 0
        MaterialCheckBox4.CheckState = CheckState.Unchecked
        BunifuMetroTextbox6.Text = 0
        MaterialCheckBox5.CheckState = CheckState.Unchecked
        BunifuMetroTextbox7.Text = 0
        MaterialCheckBox6.CheckState = CheckState.Unchecked
        BunifuMetroTextbox8.Text = 0
        MaterialCheckBox7.CheckState = CheckState.Unchecked
        BunifuMetroTextbox9.Text = 0
        MaterialCheckBox8.CheckState = CheckState.Unchecked
        BunifuMetroTextbox10.Text = 0
        MaterialCheckBox9.CheckState = CheckState.Unchecked
        BunifuMetroTextbox11.Text = 0
        MaterialCheckBox10.CheckState = CheckState.Unchecked
        BunifuMetroTextbox12.Text = 0
        MaterialCheckBox11.CheckState = CheckState.Unchecked
        BunifuMetroTextbox13.Text = 0
        MaterialCheckBox12.CheckState = CheckState.Unchecked
        BunifuMetroTextbox14.Text = 0
        MaterialCheckBox13.CheckState = CheckState.Unchecked
        BunifuMetroTextbox15.Text = 0
        MaterialCheckBox14.CheckState = CheckState.Unchecked
        BunifuMetroTextbox16.Text = 0
        Label6.Text = 0
        Label5.Text = 0
        Label31.Text = 0

        Label43.Text = 0

        ListBox1.Items.Clear()
    End Sub
    Private Sub MaterialSingleLineTextField1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub


    Private Sub MaterialSingleLineTextField2_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Dim a As Double
        Dim b As Double
        Dim pinaka As Double
        a = Val(Label5.Text)
        b = Val(Label6.Text)
        finaltotal = a + b
        Label31.Text = finaltotal
        pinaka = finaltotal - Val(Label43.Text)
        Label31.Text = pinaka
    End Sub
    Private Sub MaterialCheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox15.CheckedChanged
        Dim a As Double = 0.2
        If MaterialCheckBox15.Checked Then
            Label43.Text = Val(Label31.Text) * a
        ElseIf MaterialCheckBox15.CheckState = CheckState.Unchecked Then
            Label43.Text = 0
        End If
    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs) Handles Label41.Click

    End Sub
End Class