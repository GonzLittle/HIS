<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Confineform
    Inherits MetroFramework.Forms.MetroForm


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Confineform))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.timeout = New System.Windows.Forms.Label()
        Me.dateee = New System.Windows.Forms.Label()
        Me.Remarks = New System.Windows.Forms.Label()
        Me.timein = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Dateout = New System.Windows.Forms.Label()
        Me.Change = New System.Windows.Forms.Label()
        Me.discount = New System.Windows.Forms.Label()
        Me.Tendered = New System.Windows.Forms.Label()
        Me.TotalAmount = New System.Windows.Forms.Label()
        Me.Datemoto = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuCustomDataGrid1 = New ns1.BunifuCustomDataGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton1 = New ns1.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaterialSingleLineTextField3 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuCustomTextbox1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuCustomTextbox2 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MaterialSingleLineTextField2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Unavailable = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuCustomTextbox3 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Panel1.Controls.Add(Me.timeout)
        Me.Panel1.Controls.Add(Me.dateee)
        Me.Panel1.Controls.Add(Me.Remarks)
        Me.Panel1.Controls.Add(Me.timein)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Dateout)
        Me.Panel1.Controls.Add(Me.Change)
        Me.Panel1.Controls.Add(Me.discount)
        Me.Panel1.Controls.Add(Me.Tendered)
        Me.Panel1.Controls.Add(Me.TotalAmount)
        Me.Panel1.Controls.Add(Me.Datemoto)
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(101, 500)
        Me.Panel1.TabIndex = 0
        '
        'timeout
        '
        Me.timeout.AutoSize = True
        Me.timeout.Location = New System.Drawing.Point(33, 323)
        Me.timeout.Name = "timeout"
        Me.timeout.Size = New System.Drawing.Size(0, 13)
        Me.timeout.TabIndex = 109
        Me.timeout.Visible = False
        '
        'dateee
        '
        Me.dateee.AutoSize = True
        Me.dateee.Location = New System.Drawing.Point(29, 284)
        Me.dateee.Name = "dateee"
        Me.dateee.Size = New System.Drawing.Size(30, 13)
        Me.dateee.TabIndex = 108
        Me.dateee.Text = "Date"
        Me.dateee.Visible = False
        '
        'Remarks
        '
        Me.Remarks.AutoSize = True
        Me.Remarks.Location = New System.Drawing.Point(29, 256)
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Size = New System.Drawing.Size(46, 13)
        Me.Remarks.TabIndex = 107
        Me.Remarks.Text = "Pending"
        Me.Remarks.Visible = False
        '
        'timein
        '
        Me.timein.AutoSize = True
        Me.timein.Location = New System.Drawing.Point(31, 232)
        Me.timein.Name = "timein"
        Me.timein.Size = New System.Drawing.Size(26, 13)
        Me.timein.TabIndex = 106
        Me.timein.Text = "time"
        Me.timein.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 197)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(71, 20)
        Me.TextBox1.TabIndex = 105
        Me.TextBox1.Visible = False
        '
        'Dateout
        '
        Me.Dateout.AutoSize = True
        Me.Dateout.Location = New System.Drawing.Point(44, 220)
        Me.Dateout.Name = "Dateout"
        Me.Dateout.Size = New System.Drawing.Size(0, 13)
        Me.Dateout.TabIndex = 104
        '
        'Change
        '
        Me.Change.AutoSize = True
        Me.Change.Location = New System.Drawing.Point(40, 146)
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(13, 13)
        Me.Change.TabIndex = 103
        Me.Change.Text = "0"
        Me.Change.Visible = False
        '
        'discount
        '
        Me.discount.AutoSize = True
        Me.discount.Location = New System.Drawing.Point(29, 121)
        Me.discount.Name = "discount"
        Me.discount.Size = New System.Drawing.Size(13, 13)
        Me.discount.TabIndex = 102
        Me.discount.Text = "0"
        Me.discount.Visible = False
        '
        'Tendered
        '
        Me.Tendered.AutoSize = True
        Me.Tendered.Location = New System.Drawing.Point(6, 72)
        Me.Tendered.Name = "Tendered"
        Me.Tendered.Size = New System.Drawing.Size(13, 13)
        Me.Tendered.TabIndex = 101
        Me.Tendered.Text = "0"
        Me.Tendered.Visible = False
        '
        'TotalAmount
        '
        Me.TotalAmount.AutoSize = True
        Me.TotalAmount.Location = New System.Drawing.Point(25, 46)
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.Size = New System.Drawing.Size(13, 13)
        Me.TotalAmount.TabIndex = 100
        Me.TotalAmount.Text = "0"
        Me.TotalAmount.Visible = False
        '
        'Datemoto
        '
        Me.Datemoto.AutoSize = True
        Me.Datemoto.Location = New System.Drawing.Point(3, 15)
        Me.Datemoto.Name = "Datemoto"
        Me.Datemoto.Size = New System.Drawing.Size(39, 13)
        Me.Datemoto.TabIndex = 99
        Me.Datemoto.Text = "Label3"
        Me.Datemoto.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(126, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 23)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Admit Patient"
        '
        'BunifuCustomDataGrid1
        '
        Me.BunifuCustomDataGrid1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuCustomDataGrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.GridColor = System.Drawing.Color.Gray
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(130, 108)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.BunifuCustomDataGrid1.RowHeadersWidth = 46
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(547, 158)
        Me.BunifuCustomDataGrid1.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(126, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 22)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "List of Rooms"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 7
        Me.BunifuFlatButton1.ButtonText = "Save"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 15
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0.0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 60.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(732, 433)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(117, 35)
        Me.BunifuFlatButton1.TabIndex = 94
        Me.BunifuFlatButton1.Text = "Save"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(696, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 21)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Room ID"
        '
        'MaterialSingleLineTextField1
        '
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Hint = ""
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(700, 132)
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(149, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 88
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(696, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 21)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Price"
        '
        'MaterialSingleLineTextField3
        '
        Me.MaterialSingleLineTextField3.Depth = 0
        Me.MaterialSingleLineTextField3.Hint = ""
        Me.MaterialSingleLineTextField3.Location = New System.Drawing.Point(700, 244)
        Me.MaterialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField3.Name = "MaterialSingleLineTextField3"
        Me.MaterialSingleLineTextField3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField3.SelectedText = ""
        Me.MaterialSingleLineTextField3.SelectionLength = 0
        Me.MaterialSingleLineTextField3.SelectionStart = 0
        Me.MaterialSingleLineTextField3.Size = New System.Drawing.Size(149, 23)
        Me.MaterialSingleLineTextField3.TabIndex = 93
        Me.MaterialSingleLineTextField3.UseSystemPasswordChar = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(622, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 21)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "10124"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(532, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 21)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "Patient ID:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(256, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 97
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(862, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 20)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "X"
        '
        'BunifuCustomTextbox1
        '
        Me.BunifuCustomTextbox1.BorderColor = System.Drawing.Color.Gray
        Me.BunifuCustomTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuCustomTextbox1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomTextbox1.Location = New System.Drawing.Point(130, 321)
        Me.BunifuCustomTextbox1.Multiline = True
        Me.BunifuCustomTextbox1.Name = "BunifuCustomTextbox1"
        Me.BunifuCustomTextbox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.BunifuCustomTextbox1.Size = New System.Drawing.Size(324, 78)
        Me.BunifuCustomTextbox1.TabIndex = 108
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(126, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 21)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Findings"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(500, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 21)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "Status of Disease"
        '
        'BunifuCustomTextbox2
        '
        Me.BunifuCustomTextbox2.BorderColor = System.Drawing.Color.Gray
        Me.BunifuCustomTextbox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuCustomTextbox2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomTextbox2.Location = New System.Drawing.Point(504, 321)
        Me.BunifuCustomTextbox2.Multiline = True
        Me.BunifuCustomTextbox2.Name = "BunifuCustomTextbox2"
        Me.BunifuCustomTextbox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.BunifuCustomTextbox2.Size = New System.Drawing.Size(347, 78)
        Me.BunifuCustomTextbox2.TabIndex = 112
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(696, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 21)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Room #"
        '
        'MaterialSingleLineTextField2
        '
        Me.MaterialSingleLineTextField2.Depth = 0
        Me.MaterialSingleLineTextField2.Hint = ""
        Me.MaterialSingleLineTextField2.Location = New System.Drawing.Point(700, 189)
        Me.MaterialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField2.Name = "MaterialSingleLineTextField2"
        Me.MaterialSingleLineTextField2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField2.SelectedText = ""
        Me.MaterialSingleLineTextField2.SelectionLength = 0
        Me.MaterialSingleLineTextField2.SelectionStart = 0
        Me.MaterialSingleLineTextField2.Size = New System.Drawing.Size(149, 23)
        Me.MaterialSingleLineTextField2.TabIndex = 114
        Me.MaterialSingleLineTextField2.UseSystemPasswordChar = False
        '
        'Unavailable
        '
        Me.Unavailable.AutoSize = True
        Me.Unavailable.Location = New System.Drawing.Point(561, 442)
        Me.Unavailable.Name = "Unavailable"
        Me.Unavailable.Size = New System.Drawing.Size(63, 13)
        Me.Unavailable.TabIndex = 115
        Me.Unavailable.Text = "Unavailable"
        Me.Unavailable.Visible = False
        '
        'Timer1
        '
        '
        'BunifuCustomTextbox3
        '
        Me.BunifuCustomTextbox3.BorderColor = System.Drawing.Color.Gray
        Me.BunifuCustomTextbox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuCustomTextbox3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomTextbox3.Location = New System.Drawing.Point(130, 441)
        Me.BunifuCustomTextbox3.Multiline = True
        Me.BunifuCustomTextbox3.Name = "BunifuCustomTextbox3"
        Me.BunifuCustomTextbox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.BunifuCustomTextbox3.Size = New System.Drawing.Size(324, 27)
        Me.BunifuCustomTextbox3.TabIndex = 116
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(126, 415)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 21)
        Me.Label11.TabIndex = 117
        Me.Label11.Text = "Process by"
        '
        'Confineform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 491)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BunifuCustomTextbox3)
        Me.Controls.Add(Me.Unavailable)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.MaterialSingleLineTextField2)
        Me.Controls.Add(Me.BunifuCustomTextbox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BunifuCustomTextbox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MaterialSingleLineTextField3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Confineform"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BunifuCustomDataGrid1 As ns1.BunifuCustomDataGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BunifuFlatButton1 As ns1.BunifuFlatButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MaterialSingleLineTextField3 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Datemoto As System.Windows.Forms.Label
    Friend WithEvents TotalAmount As System.Windows.Forms.Label
    Friend WithEvents Tendered As System.Windows.Forms.Label
    Friend WithEvents discount As System.Windows.Forms.Label
    Friend WithEvents Change As System.Windows.Forms.Label
    Friend WithEvents Dateout As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BunifuCustomTextbox1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BunifuCustomTextbox2 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MaterialSingleLineTextField2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Unavailable As System.Windows.Forms.Label
    Friend WithEvents timein As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Remarks As System.Windows.Forms.Label
    Friend WithEvents dateee As System.Windows.Forms.Label
    Friend WithEvents BunifuCustomTextbox3 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents timeout As System.Windows.Forms.Label
End Class
