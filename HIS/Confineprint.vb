Imports System.Drawing.Printing
Imports System.IO

Public Class Confineprint

    Private Sub BunifuFlatButton7_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        BunifuFlatButton7.Visible = False
        Panel2.Visible = False
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        Nurse_Billing.TextBox5.Clear()
        Me.Hide()
    End Sub
End Class