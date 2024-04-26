<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStoolReport
    Inherits System.Windows.Forms.Form

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbPatName = New System.Windows.Forms.ComboBox()
        Me.cmbPatID = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnGenReport = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.lblReprtDate = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.lblRrptNo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBlood = New System.Windows.Forms.Label()
        Me.lblMucus = New System.Windows.Forms.Label()
        Me.lblCons = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblTrop = New System.Windows.Forms.Label()
        Me.lblEColi = New System.Windows.Forms.Label()
        Me.lblMacro = New System.Windows.Forms.Label()
        Me.lblpH = New System.Windows.Forms.Label()
        Me.lblOccult = New System.Windows.Forms.Label()
        Me.lblRefMicro = New System.Windows.Forms.Label()
        Me.lblRefDoc = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbPatName)
        Me.GroupBox1.Controls.Add(Me.cmbPatID)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnGenReport)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox1.Location = New System.Drawing.Point(23, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 137)
        Me.GroupBox1.TabIndex = 32465
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stool Test Report"
        '
        'cmbPatName
        '
        Me.cmbPatName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmbPatName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPatName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatName.FormattingEnabled = True
        Me.cmbPatName.Location = New System.Drawing.Point(302, 84)
        Me.cmbPatName.MaxLength = 20
        Me.cmbPatName.Name = "cmbPatName"
        Me.cmbPatName.Size = New System.Drawing.Size(152, 24)
        Me.cmbPatName.TabIndex = 2
        '
        'cmbPatID
        '
        Me.cmbPatID.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmbPatID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPatID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatID.FormattingEnabled = True
        Me.cmbPatID.Location = New System.Drawing.Point(302, 47)
        Me.cmbPatID.MaxLength = 20
        Me.cmbPatID.Name = "cmbPatID"
        Me.cmbPatID.Size = New System.Drawing.Size(89, 24)
        Me.cmbPatID.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.BackColor = System.Drawing.Color.Gainsboro
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Image = Global.Medical_Diagnosis_Management_System.My.Resources.Resources.gnome_application_exit__3_
        Me.btnExit.Location = New System.Drawing.Point(508, 81)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(131, 38)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnGenReport
        '
        Me.btnGenReport.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGenReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGenReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGenReport.Location = New System.Drawing.Point(508, 37)
        Me.btnGenReport.Name = "btnGenReport"
        Me.btnGenReport.Size = New System.Drawing.Size(131, 38)
        Me.btnGenReport.TabIndex = 3
        Me.btnGenReport.Text = "Generate"
        Me.btnGenReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGenReport.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(113, 84)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(188, 18)
        Me.Label20.TabIndex = 100
        Me.Label20.Text = "Select by Patient Name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Medical_Diagnosis_Management_System.My.Resources.Resources.search_patient
        Me.PictureBox1.Location = New System.Drawing.Point(44, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 74)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(113, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 18)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Select by Patient ID:"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.BackColor = System.Drawing.Color.Transparent
        Me.lblSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.Location = New System.Drawing.Point(771, 221)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(17, 18)
        Me.lblSex.TabIndex = 32490
        Me.lblSex.Text = "_"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(724, 221)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(41, 18)
        Me.Label59.TabIndex = 32489
        Me.Label59.Text = "Sex:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.Transparent
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(771, 191)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(17, 18)
        Me.lblAge.TabIndex = 32488
        Me.lblAge.Text = "_"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(724, 191)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(41, 18)
        Me.Label54.TabIndex = 32487
        Me.Label54.Text = "Age:"
        '
        'lblReprtDate
        '
        Me.lblReprtDate.AutoSize = True
        Me.lblReprtDate.BackColor = System.Drawing.Color.Transparent
        Me.lblReprtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReprtDate.Location = New System.Drawing.Point(134, 214)
        Me.lblReprtDate.Name = "lblReprtDate"
        Me.lblReprtDate.Size = New System.Drawing.Size(17, 18)
        Me.lblReprtDate.TabIndex = 32486
        Me.lblReprtDate.Text = "_"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(33, 214)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(104, 18)
        Me.Label52.TabIndex = 32485
        Me.Label52.Text = "Report Date:"
        '
        'lblRrptNo
        '
        Me.lblRrptNo.AutoSize = True
        Me.lblRrptNo.BackColor = System.Drawing.Color.Transparent
        Me.lblRrptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRrptNo.Location = New System.Drawing.Point(127, 182)
        Me.lblRrptNo.Name = "lblRrptNo"
        Me.lblRrptNo.Size = New System.Drawing.Size(17, 18)
        Me.lblRrptNo.TabIndex = 32484
        Me.lblRrptNo.Text = "_"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 18)
        Me.Label6.TabIndex = 32483
        Me.Label6.Text = "Report No."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(395, 219)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 20)
        Me.Label12.TabIndex = 32482
        Me.Label12.Text = "Stool Report"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(27, 319)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(45, 15)
        Me.Label69.TabIndex = 32491
        Me.Label69.Text = "Color:"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(27, 397)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(48, 15)
        Me.Label71.TabIndex = 32494
        Me.Label71.Text = "Blood:"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.Color.Transparent
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(26, 344)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(87, 15)
        Me.Label72.TabIndex = 32492
        Me.Label72.Text = "Consistency:"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.BackColor = System.Drawing.Color.Transparent
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(27, 370)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(53, 15)
        Me.Label74.TabIndex = 32493
        Me.Label74.Text = "Mucus:"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.BackColor = System.Drawing.Color.Transparent
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(26, 276)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(104, 18)
        Me.Label63.TabIndex = 32495
        Me.Label63.Text = "Physical test"
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 24
        Me.LineShape1.X2 = 181
        Me.LineShape1.Y1 = 305
        Me.LineShape1.Y2 = 305
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape6, Me.LineShape5, Me.LineShape3, Me.LineShape2, Me.LineShape4, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(914, 669)
        Me.ShapeContainer1.TabIndex = 32496
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 486
        Me.LineShape3.X2 = 643
        Me.LineShape3.Y1 = 305
        Me.LineShape3.Y2 = 305
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 17
        Me.LineShape2.X2 = 183
        Me.LineShape2.Y1 = 481
        Me.LineShape2.Y2 = 481
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 11
        Me.LineShape4.X2 = 904
        Me.LineShape4.Y1 = 250
        Me.LineShape4.Y2 = 250
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 495)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 32497
        Me.Label3.Text = "Macrophages:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 520)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 15)
        Me.Label8.TabIndex = 32498
        Me.Label8.Text = "E. Coli:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 545)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 15)
        Me.Label10.TabIndex = 32499
        Me.Label10.Text = "Trophozoite:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(494, 319)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(92, 15)
        Me.Label21.TabIndex = 32500
        Me.Label21.Text = "Occult Blood:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(494, 344)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(29, 15)
        Me.Label24.TabIndex = 32501
        Me.Label24.Text = "pH:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 450)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 18)
        Me.Label1.TabIndex = 32502
        Me.Label1.Text = "Microscopic test"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(494, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 32503
        Me.Label2.Text = "Other test"
        '
        'lblBlood
        '
        Me.lblBlood.AutoSize = True
        Me.lblBlood.BackColor = System.Drawing.Color.Transparent
        Me.lblBlood.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlood.Location = New System.Drawing.Point(127, 399)
        Me.lblBlood.Name = "lblBlood"
        Me.lblBlood.Size = New System.Drawing.Size(15, 15)
        Me.lblBlood.TabIndex = 32507
        Me.lblBlood.Text = "_"
        '
        'lblMucus
        '
        Me.lblMucus.AutoSize = True
        Me.lblMucus.BackColor = System.Drawing.Color.Transparent
        Me.lblMucus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMucus.Location = New System.Drawing.Point(127, 372)
        Me.lblMucus.Name = "lblMucus"
        Me.lblMucus.Size = New System.Drawing.Size(15, 15)
        Me.lblMucus.TabIndex = 32506
        Me.lblMucus.Text = "_"
        '
        'lblCons
        '
        Me.lblCons.AutoSize = True
        Me.lblCons.BackColor = System.Drawing.Color.Transparent
        Me.lblCons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCons.Location = New System.Drawing.Point(127, 344)
        Me.lblCons.Name = "lblCons"
        Me.lblCons.Size = New System.Drawing.Size(15, 15)
        Me.lblCons.TabIndex = 32505
        Me.lblCons.Text = "_"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.BackColor = System.Drawing.Color.Transparent
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(127, 316)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(15, 15)
        Me.lblColor.TabIndex = 32504
        Me.lblColor.Text = "_"
        '
        'lblTrop
        '
        Me.lblTrop.AutoSize = True
        Me.lblTrop.BackColor = System.Drawing.Color.Transparent
        Me.lblTrop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrop.Location = New System.Drawing.Point(127, 547)
        Me.lblTrop.Name = "lblTrop"
        Me.lblTrop.Size = New System.Drawing.Size(15, 15)
        Me.lblTrop.TabIndex = 32510
        Me.lblTrop.Text = "_"
        '
        'lblEColi
        '
        Me.lblEColi.AutoSize = True
        Me.lblEColi.BackColor = System.Drawing.Color.Transparent
        Me.lblEColi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEColi.Location = New System.Drawing.Point(127, 520)
        Me.lblEColi.Name = "lblEColi"
        Me.lblEColi.Size = New System.Drawing.Size(15, 15)
        Me.lblEColi.TabIndex = 32509
        Me.lblEColi.Text = "_"
        '
        'lblMacro
        '
        Me.lblMacro.AutoSize = True
        Me.lblMacro.BackColor = System.Drawing.Color.Transparent
        Me.lblMacro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMacro.Location = New System.Drawing.Point(127, 492)
        Me.lblMacro.Name = "lblMacro"
        Me.lblMacro.Size = New System.Drawing.Size(15, 15)
        Me.lblMacro.TabIndex = 32508
        Me.lblMacro.Text = "_"
        '
        'lblpH
        '
        Me.lblpH.AutoSize = True
        Me.lblpH.BackColor = System.Drawing.Color.Transparent
        Me.lblpH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpH.Location = New System.Drawing.Point(592, 349)
        Me.lblpH.Name = "lblpH"
        Me.lblpH.Size = New System.Drawing.Size(15, 15)
        Me.lblpH.TabIndex = 32512
        Me.lblpH.Text = "_"
        '
        'lblOccult
        '
        Me.lblOccult.AutoSize = True
        Me.lblOccult.BackColor = System.Drawing.Color.Transparent
        Me.lblOccult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccult.Location = New System.Drawing.Point(592, 321)
        Me.lblOccult.Name = "lblOccult"
        Me.lblOccult.Size = New System.Drawing.Size(15, 15)
        Me.lblOccult.TabIndex = 32511
        Me.lblOccult.Text = "_"
        '
        'lblRefMicro
        '
        Me.lblRefMicro.AutoSize = True
        Me.lblRefMicro.BackColor = System.Drawing.Color.Transparent
        Me.lblRefMicro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefMicro.Location = New System.Drawing.Point(702, 636)
        Me.lblRefMicro.Name = "lblRefMicro"
        Me.lblRefMicro.Size = New System.Drawing.Size(15, 15)
        Me.lblRefMicro.TabIndex = 32559
        Me.lblRefMicro.Text = "_"
        '
        'lblRefDoc
        '
        Me.lblRefDoc.AutoSize = True
        Me.lblRefDoc.BackColor = System.Drawing.Color.Transparent
        Me.lblRefDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefDoc.Location = New System.Drawing.Point(144, 636)
        Me.lblRefDoc.Name = "lblRefDoc"
        Me.lblRefDoc.Size = New System.Drawing.Size(15, 15)
        Me.lblRefDoc.TabIndex = 32558
        Me.lblRefDoc.Text = "_"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(660, 608)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(151, 18)
        Me.Label58.TabIndex = 32557
        Me.Label58.Text = "Ref. Microbiologist"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(119, 608)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(96, 18)
        Me.Label53.TabIndex = 32556
        Me.Label53.Text = "Ref. Doctor"
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 115
        Me.LineShape5.X2 = 218
        Me.LineShape5.Y1 = 629
        Me.LineShape5.Y2 = 629
        '
        'LineShape6
        '
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 661
        Me.LineShape6.X2 = 807
        Me.LineShape6.Y1 = 630
        Me.LineShape6.Y2 = 630
        '
        'frmStoolReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(914, 669)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblRefMicro)
        Me.Controls.Add(Me.lblRefDoc)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.lblpH)
        Me.Controls.Add(Me.lblOccult)
        Me.Controls.Add(Me.lblTrop)
        Me.Controls.Add(Me.lblEColi)
        Me.Controls.Add(Me.lblMacro)
        Me.Controls.Add(Me.lblBlood)
        Me.Controls.Add(Me.lblMucus)
        Me.Controls.Add(Me.lblCons)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.Label71)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.Label74)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.Label59)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.lblReprtDate)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.lblRrptNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmStoolReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stool Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPatName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPatID As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnGenReport As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents lblReprtDate As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents lblRrptNo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblBlood As System.Windows.Forms.Label
    Friend WithEvents lblMucus As System.Windows.Forms.Label
    Friend WithEvents lblCons As System.Windows.Forms.Label
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents lblTrop As System.Windows.Forms.Label
    Friend WithEvents lblEColi As System.Windows.Forms.Label
    Friend WithEvents lblMacro As System.Windows.Forms.Label
    Friend WithEvents lblpH As System.Windows.Forms.Label
    Friend WithEvents lblOccult As System.Windows.Forms.Label
    Friend WithEvents lblRefMicro As System.Windows.Forms.Label
    Friend WithEvents lblRefDoc As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
