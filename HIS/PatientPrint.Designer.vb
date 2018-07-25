<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientPrint))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton7 = New ns1.BunifuFlatButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Middle = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.Label()
        Me.Marital = New System.Windows.Forms.Label()
        Me.Bloodtype = New System.Windows.Forms.Label()
        Me.Phonenumber = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.Label()
        Me.age = New System.Windows.Forms.Label()
        Me.dob = New System.Windows.Forms.Label()
        Me.Firstname = New System.Windows.Forms.Label()
        Me.Lastname = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Weight = New System.Windows.Forms.Label()
        Me.Height = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.bloodpressure = New System.Windows.Forms.Label()
        Me.Temperature = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.pulserate = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label36 = New System.Windows.Forms.Label()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DimGray
        Me.Label25.Location = New System.Drawing.Point(159, 13)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(348, 40)
        Me.Label25.TabIndex = 64
        Me.Label25.Text = "917 Quirino Highway , Brgy. Gulod Novaliches ," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Quezon City"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.DimGray
        Me.Label26.Location = New System.Drawing.Point(159, 55)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(269, 20)
        Me.Label26.TabIndex = 65
        Me.Label26.Text = "TEL: 533-3706/788-7870 / 09989835272" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BunifuFlatButton7)
        Me.Panel2.Location = New System.Drawing.Point(464, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 46)
        Me.Panel2.TabIndex = 66
        '
        'BunifuFlatButton7
        '
        Me.BunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.BunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton7.BorderRadius = 7
        Me.BunifuFlatButton7.ButtonText = " Print"
        Me.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Iconimage = CType(resources.GetObject("BunifuFlatButton7.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton7.Iconimage_right = Nothing
        Me.BunifuFlatButton7.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton7.Iconimage_Selected = Nothing
        Me.BunifuFlatButton7.IconMarginLeft = 10
        Me.BunifuFlatButton7.IconMarginRight = 0
        Me.BunifuFlatButton7.IconRightVisible = True
        Me.BunifuFlatButton7.IconRightZoom = 0.0R
        Me.BunifuFlatButton7.IconVisible = True
        Me.BunifuFlatButton7.IconZoom = 55.0R
        Me.BunifuFlatButton7.IsTab = False
        Me.BunifuFlatButton7.Location = New System.Drawing.Point(49, 12)
        Me.BunifuFlatButton7.Name = "BunifuFlatButton7"
        Me.BunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton7.selected = False
        Me.BunifuFlatButton7.Size = New System.Drawing.Size(101, 31)
        Me.BunifuFlatButton7.TabIndex = 15
        Me.BunifuFlatButton7.Text = " Print"
        Me.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton7.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton7.TextFont = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(23, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 25)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Patient Information"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-3, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(661, 25)
        Me.Panel1.TabIndex = 68
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Middle
        '
        Me.Middle.AutoSize = True
        Me.Middle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle.ForeColor = System.Drawing.Color.Black
        Me.Middle.Location = New System.Drawing.Point(194, 287)
        Me.Middle.Name = "Middle"
        Me.Middle.Size = New System.Drawing.Size(0, 20)
        Me.Middle.TabIndex = 92
        '
        'Gender
        '
        Me.Gender.AutoSize = True
        Me.Gender.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.ForeColor = System.Drawing.Color.Black
        Me.Gender.Location = New System.Drawing.Point(466, 290)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(0, 20)
        Me.Gender.TabIndex = 91
        '
        'Marital
        '
        Me.Marital.AutoSize = True
        Me.Marital.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Marital.ForeColor = System.Drawing.Color.Black
        Me.Marital.Location = New System.Drawing.Point(505, 259)
        Me.Marital.Name = "Marital"
        Me.Marital.Size = New System.Drawing.Size(0, 20)
        Me.Marital.TabIndex = 90
        '
        'Bloodtype
        '
        Me.Bloodtype.AutoSize = True
        Me.Bloodtype.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bloodtype.ForeColor = System.Drawing.Color.Black
        Me.Bloodtype.Location = New System.Drawing.Point(492, 229)
        Me.Bloodtype.Name = "Bloodtype"
        Me.Bloodtype.Size = New System.Drawing.Size(0, 20)
        Me.Bloodtype.TabIndex = 89
        '
        'Phonenumber
        '
        Me.Phonenumber.AutoSize = True
        Me.Phonenumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phonenumber.ForeColor = System.Drawing.Color.Black
        Me.Phonenumber.Location = New System.Drawing.Point(207, 383)
        Me.Phonenumber.Name = "Phonenumber"
        Me.Phonenumber.Size = New System.Drawing.Size(0, 20)
        Me.Phonenumber.TabIndex = 88
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.ForeColor = System.Drawing.Color.Black
        Me.Address.Location = New System.Drawing.Point(156, 415)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(0, 20)
        Me.Address.TabIndex = 87
        '
        'age
        '
        Me.age.AutoSize = True
        Me.age.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age.ForeColor = System.Drawing.Color.Black
        Me.age.Location = New System.Drawing.Point(125, 350)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(0, 20)
        Me.age.TabIndex = 86
        '
        'dob
        '
        Me.dob.AutoSize = True
        Me.dob.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dob.ForeColor = System.Drawing.Color.Black
        Me.dob.Location = New System.Drawing.Point(191, 320)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(0, 20)
        Me.dob.TabIndex = 85
        '
        'Firstname
        '
        Me.Firstname.AutoSize = True
        Me.Firstname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Firstname.ForeColor = System.Drawing.Color.Black
        Me.Firstname.Location = New System.Drawing.Point(164, 229)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Size = New System.Drawing.Size(0, 20)
        Me.Firstname.TabIndex = 84
        '
        'Lastname
        '
        Me.Lastname.AutoSize = True
        Me.Lastname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lastname.ForeColor = System.Drawing.Color.Black
        Me.Lastname.Location = New System.Drawing.Point(164, 259)
        Me.Lastname.Name = "Lastname"
        Me.Lastname.Size = New System.Drawing.Size(0, 20)
        Me.Lastname.TabIndex = 83
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(393, 289)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 20)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Gender :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(393, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 20)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Marital Status :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(393, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 20)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Blood Type :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(80, 381)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 20)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Phone Number :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(80, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Address :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(80, 349)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Age :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(80, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Date of Birth :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(82, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Firstname :"
        '
        'Weight
        '
        Me.Weight.AutoSize = True
        Me.Weight.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Weight.ForeColor = System.Drawing.Color.Black
        Me.Weight.Location = New System.Drawing.Point(178, 504)
        Me.Weight.Name = "Weight"
        Me.Weight.Size = New System.Drawing.Size(0, 20)
        Me.Weight.TabIndex = 96
        '
        'Height
        '
        Me.Height.AutoSize = True
        Me.Height.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Height.ForeColor = System.Drawing.Color.Black
        Me.Height.Location = New System.Drawing.Point(178, 476)
        Me.Height.Name = "Height"
        Me.Height.Size = New System.Drawing.Size(0, 20)
        Me.Height.TabIndex = 95
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(79, 503)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 20)
        Me.Label21.TabIndex = 94
        Me.Label21.Text = "Weight (lbs)"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(81, 475)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(93, 20)
        Me.Label23.TabIndex = 93
        Me.Label23.Text = "Height (cm)"
        '
        'bloodpressure
        '
        Me.bloodpressure.AutoSize = True
        Me.bloodpressure.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bloodpressure.ForeColor = System.Drawing.Color.Black
        Me.bloodpressure.Location = New System.Drawing.Point(407, 504)
        Me.bloodpressure.Name = "bloodpressure"
        Me.bloodpressure.Size = New System.Drawing.Size(0, 20)
        Me.bloodpressure.TabIndex = 100
        '
        'Temperature
        '
        Me.Temperature.AutoSize = True
        Me.Temperature.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Temperature.ForeColor = System.Drawing.Color.Black
        Me.Temperature.Location = New System.Drawing.Point(394, 474)
        Me.Temperature.Name = "Temperature"
        Me.Temperature.Size = New System.Drawing.Size(0, 20)
        Me.Temperature.TabIndex = 99
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(284, 503)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(123, 20)
        Me.Label28.TabIndex = 98
        Me.Label28.Text = "Blood Pressure :"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(284, 473)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(109, 20)
        Me.Label29.TabIndex = 97
        Me.Label29.Text = "Temperature :"
        '
        'pulserate
        '
        Me.pulserate.AutoSize = True
        Me.pulserate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pulserate.ForeColor = System.Drawing.Color.Black
        Me.pulserate.Location = New System.Drawing.Point(376, 536)
        Me.pulserate.Name = "pulserate"
        Me.pulserate.Size = New System.Drawing.Size(0, 20)
        Me.pulserate.TabIndex = 102
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(284, 535)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(92, 20)
        Me.Label31.TabIndex = 101
        Me.Label31.Text = "Pulse Rate :"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(493, 616)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(84, 17)
        Me.Label54.TabIndex = 103
        Me.Label54.Text = "Prepared By"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.DimGray
        Me.Label50.Location = New System.Drawing.Point(366, 111)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(53, 20)
        Me.Label50.TabIndex = 106
        Me.Label50.Text = "Date :"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.DimGray
        Me.Label49.Location = New System.Drawing.Point(314, 111)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(53, 20)
        Me.Label49.TabIndex = 105
        Me.Label49.Text = "Date :"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.DimGray
        Me.Label52.Location = New System.Drawing.Point(509, 111)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(48, 20)
        Me.Label52.TabIndex = 107
        Me.Label52.Text = "Time :"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.DimGray
        Me.Label32.Location = New System.Drawing.Point(151, 174)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(22, 21)
        Me.Label32.TabIndex = 109
        Me.Label32.Text = "#"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.DimGray
        Me.Label33.Location = New System.Drawing.Point(56, 174)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(96, 21)
        Me.Label33.TabIndex = 108
        Me.Label33.Text = "Patient ID :"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(80, 257)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(87, 20)
        Me.Label34.TabIndex = 110
        Me.Label34.Text = "Lastname :"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(80, 287)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(110, 20)
        Me.Label35.TabIndex = 111
        Me.Label35.Text = "Middle Initial :"
        '
        'Timer1
        '
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.DimGray
        Me.Label36.Location = New System.Drawing.Point(560, 111)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(48, 20)
        Me.Label36.TabIndex = 112
        Me.Label36.Text = "Time :"
        '
        'MaterialSingleLineTextField1
        '
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Hint = ""
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(449, 590)
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(163, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 113
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'PatientPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 668)
        Me.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.pulserate)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.bloodpressure)
        Me.Controls.Add(Me.Temperature)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Weight)
        Me.Controls.Add(Me.Height)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Middle)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.Marital)
        Me.Controls.Add(Me.Bloodtype)
        Me.Controls.Add(Me.Phonenumber)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.dob)
        Me.Controls.Add(Me.Firstname)
        Me.Controls.Add(Me.Lastname)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "PatientPrint"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.White
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BunifuFlatButton7 As ns1.BunifuFlatButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents pulserate As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents bloodpressure As System.Windows.Forms.Label
    Friend WithEvents Temperature As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Weight As System.Windows.Forms.Label
    Friend WithEvents Height As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Middle As System.Windows.Forms.Label
    Friend WithEvents Gender As System.Windows.Forms.Label
    Friend WithEvents Marital As System.Windows.Forms.Label
    Friend WithEvents Bloodtype As System.Windows.Forms.Label
    Friend WithEvents Phonenumber As System.Windows.Forms.Label
    Friend WithEvents Address As System.Windows.Forms.Label
    Friend WithEvents age As System.Windows.Forms.Label
    Friend WithEvents dob As System.Windows.Forms.Label
    Friend WithEvents Firstname As System.Windows.Forms.Label
    Friend WithEvents Lastname As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
