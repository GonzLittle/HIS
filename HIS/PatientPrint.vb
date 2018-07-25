Public Class PatientPrint

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        BunifuFlatButton7.Visible = False
        Panel2.Visible = False
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()
        Admin_Patient.TextBox1.Clear()
        Nurse_Patient.TextBox2.Clear()
    End Sub
    Private Sub PatientPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialSingleLineTextField1.Enabled = False
        Label50.Text = DateTime.Now.ToLongDateString()
        Timer1.Start()
        Admin_Patient.TextBox1.Clear()
        Nurse_Patient.TextBox2.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label36.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub
End Class