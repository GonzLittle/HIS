Public Class consultationbilling

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Nurse_Billing.TextBox2.Clear()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        BunifuFlatButton7.Visible = False
        Panel2.Visible = False
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()
    End Sub
End Class