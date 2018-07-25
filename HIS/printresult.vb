Public Class printresult

    Private Sub print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        total()
        Label9.Text = Val(Label2.Text) - Val(Label6.Text)
    End Sub
    Sub total()
        Dim total As String = 0
        For i As Double = 0 To printdatagrid.RowCount - 1
            total += printdatagrid.Rows(i).Cells(2).Value()
            'Change the number 2 to your column index number (The first column has a 0 index column)
            'In this example the column index of Price is 2
        Next
        Label2.Text = total
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Laboratory.DeleteTable()
    End Sub
End Class