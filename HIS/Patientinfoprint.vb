Imports MySql.Data.MySqlClient
Public Class Patientinfoprint
    Dim mysqlconn As MySqlConnection
    Dim command As MySqlCommand


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Century Gothic", 16, FontStyle.Regular)
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        BunifuFlatButton7.Visible = False
        Panel2.Visible = False
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Patientinfoprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString =
            "server=localhost;userid=root;password=;database=HIS"
        Timer1.Start()
        Dim Query As String = "select * from patient_tbl"
        Dim adpt As New MySqlDataAdapter(Query, mysqlconn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "id")
        Nurse_Patient.BunifuCustomDataGrid1.DataSource = ds.Tables(0)
        mysqlconn.Close()

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        Nurse_Billing.TextBox1.Clear()
        Me.Hide()
    End Sub
End Class