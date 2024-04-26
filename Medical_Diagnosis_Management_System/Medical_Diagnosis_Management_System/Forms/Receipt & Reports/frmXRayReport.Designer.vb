<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXRayReport
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
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblExamName = New System.Windows.Forms.Label()
        Me.lblOpinion = New System.Windows.Forms.Label()
        Me.lblRemark6 = New System.Windows.Forms.Label()
        Me.lblRemark5 = New System.Windows.Forms.Label()
        Me.lblRemark4 = New System.Windows.Forms.Label()
        Me.lblRemark3 = New System.Windows.Forms.Label()
        Me.lblRemark2 = New System.Windows.Forms.Label()
        Me.lblRemark1 = New System.Windows.Forms.Label()
        Me.lblRefRadio = New System.Windows.Forms.Label()
        Me.lblRefDoc = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Location = New System.Drawing.Point(26, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 137)
        Me.GroupBox1.TabIndex = 32466
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Xray Test Report"
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
        Me.lblSex.Location = New System.Drawing.Point(734, 199)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(17, 18)
        Me.lblSex.TabIndex = 32499
        Me.lblSex.Text = "_"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(687, 199)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(41, 18)
        Me.Label59.TabIndex = 32498
        Me.Label59.Text = "Sex:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.Transparent
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(734, 169)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(17, 18)
        Me.lblAge.TabIndex = 32497
        Me.lblAge.Text = "_"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(687, 169)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(41, 18)
        Me.Label54.TabIndex = 32496
        Me.Label54.Text = "Age:"
        '
        'lblReprtDate
        '
        Me.lblReprtDate.AutoSize = True
        Me.lblReprtDate.BackColor = System.Drawing.Color.Transparent
        Me.lblReprtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReprtDate.Location = New System.Drawing.Point(138, 199)
        Me.lblReprtDate.Name = "lblReprtDate"
        Me.lblReprtDate.Size = New System.Drawing.Size(17, 18)
        Me.lblReprtDate.TabIndex = 32495
        Me.lblReprtDate.Text = "_"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(37, 199)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(104, 18)
        Me.Label52.TabIndex = 32494
        Me.Label52.Text = "Report Date:"
        '
        'lblRrptNo
        '
        Me.lblRrptNo.AutoSize = True
        Me.lblRrptNo.BackColor = System.Drawing.Color.Transparent
        Me.lblRrptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRrptNo.Location = New System.Drawing.Point(131, 167)
        Me.lblRrptNo.Name = "lblRrptNo"
        Me.lblRrptNo.Size = New System.Drawing.Size(17, 18)
        Me.lblRrptNo.TabIndex = 32493
        Me.lblRrptNo.Text = "_"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 18)
        Me.Label6.TabIndex = 32492
        Me.Label6.Text = "Report No."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(366, 199)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 20)
        Me.Label12.TabIndex = 32491
        Me.Label12.Text = "Xray Report"
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 14
        Me.LineShape4.X2 = 821
        Me.LineShape4.Y1 = 233
        Me.LineShape4.Y2 = 233
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape4})
        Me.ShapeContainer1.Size = New System.Drawing.Size(839, 703)
        Me.ShapeContainer1.TabIndex = 32500
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 325
        Me.LineShape1.X2 = 527
        Me.LineShape1.Y1 = 270
        Me.LineShape1.Y2 = 270
        '
        'lblExamName
        '
        Me.lblExamName.AutoSize = True
        Me.lblExamName.BackColor = System.Drawing.Color.Transparent
        Me.lblExamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamName.Location = New System.Drawing.Point(322, 243)
        Me.lblExamName.Name = "lblExamName"
        Me.lblExamName.Size = New System.Drawing.Size(149, 18)
        Me.lblExamName.TabIndex = 32508
        Me.lblExamName.Text = "Examination Name"
        '
        'lblOpinion
        '
        Me.lblOpinion.AutoSize = True
        Me.lblOpinion.BackColor = System.Drawing.Color.Transparent
        Me.lblOpinion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpinion.Location = New System.Drawing.Point(73, 574)
        Me.lblOpinion.Name = "lblOpinion"
        Me.lblOpinion.Size = New System.Drawing.Size(66, 18)
        Me.lblOpinion.TabIndex = 32507
        Me.lblOpinion.Text = "Opinion"
        '
        'lblRemark6
        '
        Me.lblRemark6.AutoSize = True
        Me.lblRemark6.BackColor = System.Drawing.Color.Transparent
        Me.lblRemark6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemark6.Location = New System.Drawing.Point(74, 530)
        Me.lblRemark6.Name = "lblRemark6"
        Me.lblRemark6.Size = New System.Drawing.Size(81, 18)
        Me.lblRemark6.TabIndex = 32506
        Me.lblRemark6.Text = "Remark 6"
        '
        'lblRemark5
        '
        Me.lblRemark5.AutoSize = True
        Me.lblRemark5.BackColor = System.Drawing.Color.Transparent
        Me.lblRemark5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemark5.Location = New System.Drawing.Point(74, 484)
        Me.lblRemark5.Name = "lblRemark5"
        Me.lblRemark5.Size = New System.Drawing.Size(81, 18)
        Me.lblRemark5.TabIndex = 32505
        Me.lblRemark5.Text = "Remark 5"
        '
        'lblRemark4
        '
        Me.lblRemark4.AutoSize = True
        Me.lblRemark4.BackColor = System.Drawing.Color.Transparent
        Me.lblRemark4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemark4.Location = New System.Drawing.Point(74, 438)
        Me.lblRemark4.Name = "lblRemark4"
        Me.lblRemark4.Size = New System.Drawing.Size(81, 18)
        Me.lblRemark4.TabIndex = 32504
        Me.lblRemark4.Text = "Remark 4"
        '
        'lblRemark3
        '
        Me.lblRemark3.AutoSize = True
        Me.lblRemark3.BackColor = System.Drawing.Color.Transparent
        Me.lblRemark3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemark3.Location = New System.Drawing.Point(74, 391)
        Me.lblRemark3.Name = "lblRemark3"
        Me.lblRemark3.Size = New System.Drawing.Size(81, 18)
        Me.lblRemark3.TabIndex = 32503
        Me.lblRemark3.Text = "Remark 3"
        '
        'lblRemark2
        '
        Me.lblRemark2.AutoSize = True
        Me.lblRemark2.BackColor = System.Drawing.Color.Transparent
        Me.lblRemark2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemark2.Location = New System.Drawing.Point(74, 343)
        Me.lblRemark2.Name = "lblRemark2"
        Me.lblRemark2.Size = New System.Drawing.Size(81, 18)
        Me.lblRemark2.TabIndex = 32502
        Me.lblRemark2.Text = "Remark 2"
        '
        'lblRemark1
        '
        Me.lblRemark1.AutoSize = True
        Me.lblRemark1.BackColor = System.Drawing.Color.Transparent
        Me.lblRemark1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemark1.Location = New System.Drawing.Point(74, 296)
        Me.lblRemark1.Name = "lblRemark1"
        Me.lblRemark1.Size = New System.Drawing.Size(81, 18)
        Me.lblRemark1.TabIndex = 32501
        Me.lblRemark1.Text = "Remark 1"
        '
        'lblRefRadio
        '
        Me.lblRefRadio.AutoSize = True
        Me.lblRefRadio.BackColor = System.Drawing.Color.Transparent
        Me.lblRefRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefRadio.Location = New System.Drawing.Point(685, 672)
        Me.lblRefRadio.Name = "lblRefRadio"
        Me.lblRefRadio.Size = New System.Drawing.Size(15, 15)
        Me.lblRefRadio.TabIndex = 32551
        Me.lblRefRadio.Text = "_"
        '
        'lblRefDoc
        '
        Me.lblRefDoc.AutoSize = True
        Me.lblRefDoc.BackColor = System.Drawing.Color.Transparent
        Me.lblRefDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefDoc.Location = New System.Drawing.Point(125, 672)
        Me.lblRefDoc.Name = "lblRefDoc"
        Me.lblRefDoc.Size = New System.Drawing.Size(15, 15)
        Me.lblRefDoc.TabIndex = 32550
        Me.lblRefDoc.Text = "_"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(643, 644)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(129, 18)
        Me.Label58.TabIndex = 32549
        Me.Label58.Text = "Ref. Radiologist"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(102, 644)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(96, 18)
        Me.Label53.TabIndex = 32548
        Me.Label53.Text = "Ref. Doctor"
        '
        'frmXRayReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(839, 703)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblRefRadio)
        Me.Controls.Add(Me.lblRefDoc)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.lblExamName)
        Me.Controls.Add(Me.lblOpinion)
        Me.Controls.Add(Me.lblRemark6)
        Me.Controls.Add(Me.lblRemark5)
        Me.Controls.Add(Me.lblRemark4)
        Me.Controls.Add(Me.lblRemark3)
        Me.Controls.Add(Me.lblRemark2)
        Me.Controls.Add(Me.lblRemark1)
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
        Me.Name = "frmXRayReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xray Report"
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
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lblExamName As System.Windows.Forms.Label
    Friend WithEvents lblOpinion As System.Windows.Forms.Label
    Friend WithEvents lblRemark6 As System.Windows.Forms.Label
    Friend WithEvents lblRemark5 As System.Windows.Forms.Label
    Friend WithEvents lblRemark4 As System.Windows.Forms.Label
    Friend WithEvents lblRemark3 As System.Windows.Forms.Label
    Friend WithEvents lblRemark2 As System.Windows.Forms.Label
    Friend WithEvents lblRemark1 As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblRefRadio As System.Windows.Forms.Label
    Friend WithEvents lblRefDoc As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
End Class
