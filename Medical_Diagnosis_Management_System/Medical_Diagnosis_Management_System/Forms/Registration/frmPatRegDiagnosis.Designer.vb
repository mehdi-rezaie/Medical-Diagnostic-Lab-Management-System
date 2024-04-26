<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatRegDiagnosis
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
        Me.cmbPatID = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpRegDt = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkCTScn = New System.Windows.Forms.CheckBox()
        Me.chkxray = New System.Windows.Forms.CheckBox()
        Me.txtdiagID = New System.Windows.Forms.TextBox()
        Me.txtremark = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chksono = New System.Windows.Forms.CheckBox()
        Me.chkeyeexam = New System.Windows.Forms.CheckBox()
        Me.chkurine = New System.Windows.Forms.CheckBox()
        Me.chkbiochem = New System.Windows.Forms.CheckBox()
        Me.chkblood = New System.Windows.Forms.CheckBox()
        Me.chkstool = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbfname = New System.Windows.Forms.ComboBox()
        Me.cmblname = New System.Windows.Forms.ComboBox()
        Me.cmbdocID = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbdocfname = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbPatID
        '
        Me.cmbPatID.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmbPatID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPatID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatID.FormattingEnabled = True
        Me.cmbPatID.Location = New System.Drawing.Point(121, 34)
        Me.cmbPatID.MaxLength = 20
        Me.cmbPatID.Name = "cmbPatID"
        Me.cmbPatID.Size = New System.Drawing.Size(77, 24)
        Me.cmbPatID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(29, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Patient ID:"
        '
        'dtpRegDt
        '
        Me.dtpRegDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegDt.Location = New System.Drawing.Point(121, 123)
        Me.dtpRegDt.Name = "dtpRegDt"
        Me.dtpRegDt.Size = New System.Drawing.Size(110, 22)
        Me.dtpRegDt.TabIndex = 6
        Me.dtpRegDt.TabStop = False
        Me.dtpRegDt.Value = New Date(1970, 12, 18, 0, 50, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(28, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Reg. Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(27, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 18)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Patient's FName:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkCTScn)
        Me.GroupBox1.Controls.Add(Me.chkxray)
        Me.GroupBox1.Controls.Add(Me.txtdiagID)
        Me.GroupBox1.Controls.Add(Me.txtremark)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chksono)
        Me.GroupBox1.Controls.Add(Me.chkeyeexam)
        Me.GroupBox1.Controls.Add(Me.chkurine)
        Me.GroupBox1.Controls.Add(Me.chkbiochem)
        Me.GroupBox1.Controls.Add(Me.chkblood)
        Me.GroupBox1.Controls.Add(Me.chkstool)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox1.Location = New System.Drawing.Point(33, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 264)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient's Tests"
        '
        'chkCTScn
        '
        Me.chkCTScn.AutoSize = True
        Me.chkCTScn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.chkCTScn.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkCTScn.Location = New System.Drawing.Point(178, 176)
        Me.chkCTScn.Name = "chkCTScn"
        Me.chkCTScn.Size = New System.Drawing.Size(92, 22)
        Me.chkCTScn.TabIndex = 14
        Me.chkCTScn.Text = "CT Scan"
        Me.chkCTScn.UseVisualStyleBackColor = True
        '
        'chkxray
        '
        Me.chkxray.AutoSize = True
        Me.chkxray.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.chkxray.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkxray.Location = New System.Drawing.Point(178, 137)
        Me.chkxray.Name = "chkxray"
        Me.chkxray.Size = New System.Drawing.Size(67, 22)
        Me.chkxray.TabIndex = 13
        Me.chkxray.Text = "XRay"
        Me.chkxray.UseVisualStyleBackColor = True
        '
        'txtdiagID
        '
        Me.txtdiagID.Location = New System.Drawing.Point(496, 23)
        Me.txtdiagID.Name = "txtdiagID"
        Me.txtdiagID.Size = New System.Drawing.Size(81, 24)
        Me.txtdiagID.TabIndex = 31
        Me.txtdiagID.TabStop = False
        '
        'txtremark
        '
        Me.txtremark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremark.Location = New System.Drawing.Point(120, 217)
        Me.txtremark.Name = "txtremark"
        Me.txtremark.Size = New System.Drawing.Size(237, 22)
        Me.txtremark.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(381, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 18)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Diagnosis ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(33, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Remarks:"
        '
        'chksono
        '
        Me.chksono.AutoSize = True
        Me.chksono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.chksono.ForeColor = System.Drawing.Color.DarkBlue
        Me.chksono.Location = New System.Drawing.Point(178, 97)
        Me.chksono.Name = "chksono"
        Me.chksono.Size = New System.Drawing.Size(117, 22)
        Me.chksono.TabIndex = 12
        Me.chksono.Text = "Sonography"
        Me.chksono.UseVisualStyleBackColor = True
        '
        'chkeyeexam
        '
        Me.chkeyeexam.AutoSize = True
        Me.chkeyeexam.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.chkeyeexam.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkeyeexam.Location = New System.Drawing.Point(178, 54)
        Me.chkeyeexam.Name = "chkeyeexam"
        Me.chkeyeexam.Size = New System.Drawing.Size(152, 22)
        Me.chkeyeexam.TabIndex = 11
        Me.chkeyeexam.Text = "Eye Examination"
        Me.chkeyeexam.UseVisualStyleBackColor = True
        '
        'chkurine
        '
        Me.chkurine.AutoSize = True
        Me.chkurine.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.chkurine.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkurine.Location = New System.Drawing.Point(36, 176)
        Me.chkurine.Name = "chkurine"
        Me.chkurine.Size = New System.Drawing.Size(67, 22)
        Me.chkurine.TabIndex = 10
        Me.chkurine.Text = "Urine"
        Me.chkurine.UseVisualStyleBackColor = True
        '
        'chkbiochem
        '
        Me.chkbiochem.AutoSize = True
        Me.chkbiochem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.chkbiochem.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkbiochem.Location = New System.Drawing.Point(36, 54)
        Me.chkbiochem.Name = "chkbiochem"
        Me.chkbiochem.Size = New System.Drawing.Size(125, 22)
        Me.chkbiochem.TabIndex = 7
        Me.chkbiochem.Text = "Biochemistry"
        Me.chkbiochem.UseVisualStyleBackColor = True
        '
        'chkblood
        '
        Me.chkblood.AutoSize = True
        Me.chkblood.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.chkblood.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkblood.Location = New System.Drawing.Point(36, 97)
        Me.chkblood.Name = "chkblood"
        Me.chkblood.Size = New System.Drawing.Size(71, 22)
        Me.chkblood.TabIndex = 8
        Me.chkblood.Text = "Blood"
        Me.chkblood.UseVisualStyleBackColor = True
        '
        'chkstool
        '
        Me.chkstool.AutoSize = True
        Me.chkstool.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.chkstool.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkstool.Location = New System.Drawing.Point(36, 137)
        Me.chkstool.Name = "chkstool"
        Me.chkstool.Size = New System.Drawing.Size(67, 22)
        Me.chkstool.TabIndex = 9
        Me.chkstool.Text = "Stool"
        Me.chkstool.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(298, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Patient's LName:"
        '
        'cmbfname
        '
        Me.cmbfname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbfname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbfname.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmbfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfname.FormattingEnabled = True
        Me.cmbfname.ItemHeight = 16
        Me.cmbfname.Location = New System.Drawing.Point(172, 79)
        Me.cmbfname.MaxLength = 20
        Me.cmbfname.Name = "cmbfname"
        Me.cmbfname.Size = New System.Drawing.Size(108, 24)
        Me.cmbfname.TabIndex = 4
        '
        'cmblname
        '
        Me.cmblname.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmblname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmblname.FormattingEnabled = True
        Me.cmblname.ItemHeight = 16
        Me.cmblname.Location = New System.Drawing.Point(436, 80)
        Me.cmblname.MaxLength = 20
        Me.cmblname.Name = "cmblname"
        Me.cmblname.Size = New System.Drawing.Size(108, 24)
        Me.cmblname.TabIndex = 5
        '
        'cmbdocID
        '
        Me.cmbdocID.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmbdocID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdocID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdocID.FormattingEnabled = True
        Me.cmbdocID.Location = New System.Drawing.Point(318, 34)
        Me.cmbdocID.MaxLength = 20
        Me.cmbdocID.Name = "cmbdocID"
        Me.cmbdocID.Size = New System.Drawing.Size(69, 24)
        Me.cmbdocID.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(213, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 18)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Doctor's ID:"
        '
        'cmbdocfname
        '
        Me.cmbdocfname.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmbdocfname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdocfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdocfname.FormattingEnabled = True
        Me.cmbdocfname.Location = New System.Drawing.Point(539, 37)
        Me.cmbdocfname.MaxLength = 20
        Me.cmbdocfname.Name = "cmbdocfname"
        Me.cmbdocfname.Size = New System.Drawing.Size(110, 24)
        Me.cmbdocfname.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(406, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 18)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Doctor's Name:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.Image = Global.Medical_Diagnosis_Management_System.My.Resources.Resources.edit_clear
        Me.btnClear.Location = New System.Drawing.Point(243, 448)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(161, 46)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
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
        Me.btnExit.Location = New System.Drawing.Point(410, 449)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(161, 45)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Image = Global.Medical_Diagnosis_Management_System.My.Resources.Resources.Action_db_add_icon
        Me.btnAdd.Location = New System.Drawing.Point(76, 448)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(161, 46)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'frmPatRegDiagnosis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(672, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbdocfname)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbdocID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmblname)
        Me.Controls.Add(Me.cmbfname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpRegDt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbPatID)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "frmPatRegDiagnosis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  Patient Diagnosis Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbPatID As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpRegDt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtremark As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chksono As System.Windows.Forms.CheckBox
    Friend WithEvents chkeyeexam As System.Windows.Forms.CheckBox
    Friend WithEvents chkurine As System.Windows.Forms.CheckBox
    Friend WithEvents chkbiochem As System.Windows.Forms.CheckBox
    Friend WithEvents chkblood As System.Windows.Forms.CheckBox
    Friend WithEvents chkstool As System.Windows.Forms.CheckBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbfname As System.Windows.Forms.ComboBox
    Friend WithEvents cmblname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbdocID As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdiagID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkxray As System.Windows.Forms.CheckBox
    Friend WithEvents cmbdocfname As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkCTScn As System.Windows.Forms.CheckBox
End Class
