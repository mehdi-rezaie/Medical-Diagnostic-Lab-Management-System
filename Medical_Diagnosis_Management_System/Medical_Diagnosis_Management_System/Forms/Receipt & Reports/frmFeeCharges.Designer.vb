<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFeeCharges
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmblname = New System.Windows.Forms.ComboBox()
        Me.cmbfname = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtfeelab = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtfeemisc = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfeechargesNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtfeeEyeExm = New System.Windows.Forms.TextBox()
        Me.txtfeeCTScan = New System.Windows.Forms.TextBox()
        Me.txtfeesono = New System.Windows.Forms.TextBox()
        Me.txtfeexray = New System.Windows.Forms.TextBox()
        Me.txtfeeurine = New System.Windows.Forms.TextBox()
        Me.txtfeestool = New System.Windows.Forms.TextBox()
        Me.txtfeeblood = New System.Windows.Forms.TextBox()
        Me.txtfeebiochem = New System.Windows.Forms.TextBox()
        Me.txtdiagID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpRecpDt = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbPatID = New System.Windows.Forms.ComboBox()
        Me.txtrefdocID = New System.Windows.Forms.TextBox()
        Me.txtrefdoc = New System.Windows.Forms.TextBox()
        Me.txtrcpno = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(418, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 18)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Doctor's Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(225, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 18)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Doctor's ID:"
        '
        'cmblname
        '
        Me.cmblname.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmblname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmblname.FormattingEnabled = True
        Me.cmblname.Location = New System.Drawing.Point(431, 70)
        Me.cmblname.MaxLength = 20
        Me.cmblname.Name = "cmblname"
        Me.cmblname.Size = New System.Drawing.Size(108, 24)
        Me.cmblname.TabIndex = 3
        '
        'cmbfname
        '
        Me.cmbfname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbfname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbfname.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmbfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfname.FormattingEnabled = True
        Me.cmbfname.ItemHeight = 16
        Me.cmbfname.Location = New System.Drawing.Point(167, 69)
        Me.cmbfname.MaxLength = 20
        Me.cmbfname.Name = "cmbfname"
        Me.cmbfname.Size = New System.Drawing.Size(108, 24)
        Me.cmbfname.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(293, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 18)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Patient's LName:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSummary)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.btnCalculate)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.txtfeelab)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.txtfeemisc)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtfeechargesNo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtfeeEyeExm)
        Me.GroupBox1.Controls.Add(Me.txtfeeCTScan)
        Me.GroupBox1.Controls.Add(Me.txtfeesono)
        Me.GroupBox1.Controls.Add(Me.txtfeexray)
        Me.GroupBox1.Controls.Add(Me.txtfeeurine)
        Me.GroupBox1.Controls.Add(Me.txtfeestool)
        Me.GroupBox1.Controls.Add(Me.txtfeeblood)
        Me.GroupBox1.Controls.Add(Me.txtfeebiochem)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(669, 404)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tests Fees"
        '
        'btnSummary
        '
        Me.btnSummary.Location = New System.Drawing.Point(526, 341)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(105, 36)
        Me.btnSummary.TabIndex = 70
        Me.btnSummary.Text = "Summary"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(136, 293)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(31, 18)
        Me.Label30.TabIndex = 69
        Me.Label30.Text = "Rs."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(136, 260)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 18)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "Rs."
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(396, 341)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(105, 36)
        Me.btnCalculate.TabIndex = 16
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(40, 258)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(77, 18)
        Me.Label29.TabIndex = 67
        Me.Label29.Text = "Lab fees:"
        '
        'txtfeelab
        '
        Me.txtfeelab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfeelab.Location = New System.Drawing.Point(168, 258)
        Me.txtfeelab.MaxLength = 15
        Me.txtfeelab.Name = "txtfeelab"
        Me.txtfeelab.Size = New System.Drawing.Size(157, 22)
        Me.txtfeelab.TabIndex = 13
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(39, 291)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(91, 18)
        Me.Label28.TabIndex = 65
        Me.Label28.Text = "Misc. fees:"
        '
        'txtfeemisc
        '
        Me.txtfeemisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfeemisc.Location = New System.Drawing.Point(168, 291)
        Me.txtfeemisc.MaxLength = 15
        Me.txtfeemisc.Name = "txtfeemisc"
        Me.txtfeemisc.Size = New System.Drawing.Size(157, 22)
        Me.txtfeemisc.TabIndex = 14
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(340, 189)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(138, 18)
        Me.Label24.TabIndex = 63
        Me.Label24.Text = "Eye Examination:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(340, 148)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 18)
        Me.Label25.TabIndex = 62
        Me.Label25.Text = "CT Scan:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(340, 108)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(103, 18)
        Me.Label26.TabIndex = 61
        Me.Label26.Text = "Sonography:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(340, 67)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(47, 18)
        Me.Label27.TabIndex = 60
        Me.Label27.Text = "Xray:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(42, 187)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 18)
        Me.Label23.TabIndex = 59
        Me.Label23.Text = "Urine:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(42, 148)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 18)
        Me.Label22.TabIndex = 58
        Me.Label22.Text = "Stool:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(42, 108)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 18)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "Blood:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(42, 67)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(111, 18)
        Me.Label20.TabIndex = 56
        Me.Label20.Text = "Biochemistry:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(486, 190)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 18)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Rs."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(486, 154)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 18)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Rs."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(486, 113)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 18)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Rs."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(486, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 18)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "Rs."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(164, 190)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 18)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Rs."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(164, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 18)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Rs."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(164, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 18)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Rs."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(164, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 18)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Rs."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 18)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Total fee charges:"
        '
        'txtfeechargesNo
        '
        Me.txtfeechargesNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfeechargesNo.Location = New System.Drawing.Point(195, 349)
        Me.txtfeechargesNo.MaxLength = 20
        Me.txtfeechargesNo.Name = "txtfeechargesNo"
        Me.txtfeechargesNo.Size = New System.Drawing.Size(176, 22)
        Me.txtfeechargesNo.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(534, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 18)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Charges"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(210, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 18)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Charges"
        '
        'txtfeeEyeExm
        '
        Me.txtfeeEyeExm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfeeEyeExm.Location = New System.Drawing.Point(519, 190)
        Me.txtfeeEyeExm.MaxLength = 15
        Me.txtfeeEyeExm.Name = "txtfeeEyeExm"
        Me.txtfeeEyeExm.Size = New System.Drawing.Size(103, 22)
        Me.txtfeeEyeExm.TabIndex = 12
        '
        'txtfeeCTScan
        '
        Me.txtfeeCTScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfeeCTScan.Location = New System.Drawing.Point(519, 151)
        Me.txtfeeCTScan.MaxLength = 15
        Me.txtfeeCTScan.Name = "txtfeeCTScan"
        Me.txtfeeCTScan.Size = New System.Drawing.Size(103, 22)
        Me.txtfeeCTScan.TabIndex = 11
        '
        'txtfeesono
        '
        Me.txtfeesono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfeesono.Location = New System.Drawing.Point(519, 111)
        Me.txtfeesono.MaxLength = 15
        Me.txtfeesono.Name = "txtfeesono"
        Me.txtfeesono.Size = New System.Drawing.Size(103, 22)
        Me.txtfeesono.TabIndex = 10
        '
        'txtfeexray
        '
        Me.txtfeexray.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfeexray.Location = New System.Drawing.Point(519, 68)
        Me.txtfeexray.MaxLength = 15
        Me.txtfeexray.Name = "txtfeexray"
        Me.txtfeexray.Size = New System.Drawing.Size(103, 22)
        Me.txtfeexray.TabIndex = 9
        '
        'txtfeeurine
        '
        Me.txtfeeurine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfeeurine.Location = New System.Drawing.Point(195, 189)
        Me.txtfeeurine.MaxLength = 15
        Me.txtfeeurine.Name = "txtfeeurine"
        Me.txtfeeurine.Size = New System.Drawing.Size(104, 22)
        Me.txtfeeurine.TabIndex = 8
        '
        'txtfeestool
        '
        Me.txtfeestool.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfeestool.Location = New System.Drawing.Point(195, 150)
        Me.txtfeestool.MaxLength = 15
        Me.txtfeestool.Name = "txtfeestool"
        Me.txtfeestool.Size = New System.Drawing.Size(104, 22)
        Me.txtfeestool.TabIndex = 7
        '
        'txtfeeblood
        '
        Me.txtfeeblood.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfeeblood.Location = New System.Drawing.Point(195, 110)
        Me.txtfeeblood.MaxLength = 15
        Me.txtfeeblood.Name = "txtfeeblood"
        Me.txtfeeblood.Size = New System.Drawing.Size(104, 22)
        Me.txtfeeblood.TabIndex = 6
        '
        'txtfeebiochem
        '
        Me.txtfeebiochem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfeebiochem.Location = New System.Drawing.Point(195, 67)
        Me.txtfeebiochem.MaxLength = 15
        Me.txtfeebiochem.Name = "txtfeebiochem"
        Me.txtfeebiochem.Size = New System.Drawing.Size(104, 22)
        Me.txtfeebiochem.TabIndex = 5
        '
        'txtdiagID
        '
        Me.txtdiagID.BackColor = System.Drawing.SystemColors.Control
        Me.txtdiagID.Enabled = False
        Me.txtdiagID.Location = New System.Drawing.Point(597, 110)
        Me.txtdiagID.Name = "txtdiagID"
        Me.txtdiagID.Size = New System.Drawing.Size(81, 20)
        Me.txtdiagID.TabIndex = 0
        Me.txtdiagID.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(482, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 18)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Diagnosis ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 18)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Patient's FName:"
        '
        'dtpRecpDt
        '
        Me.dtpRecpDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRecpDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRecpDt.Location = New System.Drawing.Point(350, 110)
        Me.dtpRecpDt.Name = "dtpRecpDt"
        Me.dtpRecpDt.Size = New System.Drawing.Size(110, 22)
        Me.dtpRecpDt.TabIndex = 0
        Me.dtpRecpDt.TabStop = False
        Me.dtpRecpDt.Value = New Date(1970, 12, 18, 0, 50, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(234, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 18)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Receipt Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Patient ID:"
        '
        'cmbPatID
        '
        Me.cmbPatID.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmbPatID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPatID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatID.FormattingEnabled = True
        Me.cmbPatID.Location = New System.Drawing.Point(116, 24)
        Me.cmbPatID.MaxLength = 20
        Me.cmbPatID.Name = "cmbPatID"
        Me.cmbPatID.Size = New System.Drawing.Size(77, 24)
        Me.cmbPatID.TabIndex = 1
        '
        'txtrefdocID
        '
        Me.txtrefdocID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrefdocID.Location = New System.Drawing.Point(330, 28)
        Me.txtrefdocID.MaxLength = 2
        Me.txtrefdocID.Name = "txtrefdocID"
        Me.txtrefdocID.ReadOnly = True
        Me.txtrefdocID.Size = New System.Drawing.Size(66, 22)
        Me.txtrefdocID.TabIndex = 0
        Me.txtrefdocID.TabStop = False
        '
        'txtrefdoc
        '
        Me.txtrefdoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrefdoc.Location = New System.Drawing.Point(551, 28)
        Me.txtrefdoc.MaxLength = 2
        Me.txtrefdoc.Name = "txtrefdoc"
        Me.txtrefdoc.ReadOnly = True
        Me.txtrefdoc.Size = New System.Drawing.Size(85, 22)
        Me.txtrefdoc.TabIndex = 0
        Me.txtrefdoc.TabStop = False
        '
        'txtrcpno
        '
        Me.txtrcpno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrcpno.Location = New System.Drawing.Point(127, 110)
        Me.txtrcpno.MaxLength = 2
        Me.txtrcpno.Name = "txtrcpno"
        Me.txtrcpno.ReadOnly = True
        Me.txtrcpno.Size = New System.Drawing.Size(83, 22)
        Me.txtrcpno.TabIndex = 0
        Me.txtrcpno.TabStop = False
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.BackColor = System.Drawing.Color.Transparent
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(22, 110)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(102, 18)
        Me.label.TabIndex = 172
        Me.label.Text = "Receipt No.:"
        '
        'btnCommit
        '
        Me.btnCommit.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCommit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCommit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCommit.Image = Global.Medical_Diagnosis_Management_System.My.Resources.Resources.db_comit
        Me.btnCommit.Location = New System.Drawing.Point(108, 583)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(150, 46)
        Me.btnCommit.TabIndex = 17
        Me.btnCommit.Text = "Save"
        Me.btnCommit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCommit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.Image = Global.Medical_Diagnosis_Management_System.My.Resources.Resources.edit_clear
        Me.btnClear.Location = New System.Drawing.Point(264, 583)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(161, 46)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear fees"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.BackColor = System.Drawing.Color.Gainsboro
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Image = Global.Medical_Diagnosis_Management_System.My.Resources.Resources.gnome_application_exit__3_
        Me.btnExit.Location = New System.Drawing.Point(431, 584)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(161, 45)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmFeeCharges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(722, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.txtrcpno)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.txtrefdocID)
        Me.Controls.Add(Me.txtrefdoc)
        Me.Controls.Add(Me.txtdiagID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmblname)
        Me.Controls.Add(Me.cmbfname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpRecpDt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbPatID)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmFeeCharges"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fee Charges"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmblname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbfname As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdiagID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpRecpDt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbPatID As System.Windows.Forms.ComboBox
    Friend WithEvents txtfeeurine As System.Windows.Forms.TextBox
    Friend WithEvents txtfeestool As System.Windows.Forms.TextBox
    Friend WithEvents txtfeeblood As System.Windows.Forms.TextBox
    Friend WithEvents txtfeebiochem As System.Windows.Forms.TextBox
    Friend WithEvents txtrefdocID As System.Windows.Forms.TextBox
    Friend WithEvents txtrefdoc As System.Windows.Forms.TextBox
    Friend WithEvents txtfeeEyeExm As System.Windows.Forms.TextBox
    Friend WithEvents txtfeeCTScan As System.Windows.Forms.TextBox
    Friend WithEvents txtfeesono As System.Windows.Forms.TextBox
    Friend WithEvents txtfeexray As System.Windows.Forms.TextBox
    Friend WithEvents txtrcpno As System.Windows.Forms.TextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfeechargesNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtfeelab As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtfeemisc As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnSummary As System.Windows.Forms.Button
End Class
