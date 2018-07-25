Public Class consultationprint

    Private Sub consultationprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialSingleLineTextField1.Enabled = False
        Nurse_Recordss.TextBox1.Clear()
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        BunifuFlatButton7.Visible = False
        Panel2.Visible = False
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()
        Nurse_Recordss.TextBox1.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label13.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Me.Hide()
        Nurse_Recordss.TextBox1.Clear()
    End Sub
End Class