Public Class frmUpdateBiochem
    Dim index As Integer
    Dim errmsg As String

    Private Sub frmUpdateBiochem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initialisationLoad()
    End Sub

    Private Sub cmbPatID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPatID.SelectedIndexChanged
        index = cmbPatID.SelectedIndex
        Call loadPatDocDetails()
        Call loadTestValues()
        cmbfname.SelectedIndex = cmbPatID.SelectedIndex
    End Sub

    Private Sub cmbfname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfname.SelectedIndexChanged
        cmbPatID.SelectedIndex = cmbfname.SelectedIndex
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call clearAll()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If exitForm() = True Then
            con.Close()
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Public Sub loadPatDocDetails()
        Dim dt1 As DataTable = getDataTable(sqlstr)
        txtage.Text = dt1.Rows(index).Item(26)
        txtgender.Text = dt1.Rows(index).Item(27)
        txtrefdoc.Text = dt1.Rows(index).Item(29)
        txtdocID.Text = dt1.Rows(index).Item(4)
        txtrefPathoID.Text = dt1.Rows(index).Item(5)
        txtrefPatho.Text = dt1.Rows(index).Item(28)
    End Sub

    Public Sub loadTestValues()

        Dim dt2 As DataTable = getDataTable(sqlstr)
        txtBloodUrea.Text = dt2.Rows(index).Item(7)
        txtCreatinine.Text = dt2.Rows(index).Item(8)
        txtTProtein.Text = dt2.Rows(index).Item(9)
        txtAlbumin.Text = dt2.Rows(index).Item(10)
        txtGlobwlin.Text = dt2.Rows(index).Item(11)
        txtBiliTotal.Text = dt2.Rows(index).Item(12)
        txtTriglyc.Text = dt2.Rows(index).Item(13)
        txtTLipids.Text = dt2.Rows(index).Item(14)

        txtSodium.Text = dt2.Rows(index).Item(15)
        txtPotassium.Text = dt2.Rows(index).Item(16)
        txtChloride.Text = dt2.Rows(index).Item(17)
        txtCalcium.Text = dt2.Rows(index).Item(18)
        txtMagnesium.Text = dt2.Rows(index).Item(19)
        txtUricAcid.Text = dt2.Rows(index).Item(20)

        txtT3.Text = dt2.Rows(index).Item(21)
        txtT4.Text = dt2.Rows(index).Item(22)
        txtTSH.Text = dt2.Rows(index).Item(23)
        txtCholestrl.Text = dt2.Rows(index).Item(24)

        txtbiochemtest.Text = dt2.Rows(index).Item(0)
    End Sub

    Public Sub initialisationLoad()
        cmbPatID.DropDownHeight = cmbPatID.ItemHeight * 8
        cmbfname.DropDownHeight = cmbfname.ItemHeight * 8

        Dim y As Integer
        Dim max As Integer
        sqlstr = "SELECT B.*,C.Pat_FName,C.Pat_Age,C.Pat_Gender,D.Staff_FName,E.Doc_FName FROM Diagnosis_Tests AS A,Biochemistry_Tests AS B,Patient_Info AS C, Staff_Info D,Doctor_Info E WHERE B.Pat_ID=A.Pat_ID AND A.Pat_ID=C.Pat_ID AND B.Ref_PathoID=D.Staff_ID AND B.Ref_DocID=E.Doc_ID AND C.Pat_Status='Reg' AND BiochemTest='Yes' AND A.BC_Test_Status='Done' ORDER BY B.Biochem_ID ASC"
        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count
        For y = 0 To max - 1
            txtDeptID.Text = dt.Rows(y).Item(1)
            txtTestID.Text = dt.Rows(y).Item(2)

            cmbPatID.Items.Add(dt.Rows(y).Item(3))
            cmbfname.Items.Add(dt.Rows(y).Item(25))

        Next
        txtDeptName.Text = "Pathology"
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        End If

        If updateDialog() = True Then
            Try
                Dim cmd As New OleDb.OleDbCommand
                cmd.CommandText = "UPDATE Biochemistry_Tests SET Pat_ID=@Pat_ID,BiochemTest_Date=@Biochem_Test_Date,Blood_Urea=@Blood_Urea,Creatinine=@Creatinine,Total_Protein=@Total_Protein,Albumin=@Albumin,Globwlin=@Globwlin,Bilirubin_Total=@Bilirubin_Total,Triglycerides=@Triglycerides,Total_Lipids=@Total_Lipids,Sodium=@Sodium,Potassium=@Potassium,Chloride=@Chloride,Calcium=@Calcium,Magnesium=@Magnesium,Uric_Acid=@Uric_Acid,Cholesterol=@Cholesterol,T3=@T3,T4=@T4,TSH=@TSH WHERE Pat_ID=@Pat_ID"

                cmd.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
                cmd.Parameters.AddWithValue("@BiochemTest_Date", dtpDiagDt.Value.Date)
                cmd.Parameters.AddWithValue("@Blood_Urea", Val(txtBloodUrea.Text))
                cmd.Parameters.AddWithValue("@Creatinine", Val(txtCreatinine.Text))
                cmd.Parameters.AddWithValue("@Total_Protein", Val(txtTProtein.Text))
                cmd.Parameters.AddWithValue("@Albumin", Val(txtAlbumin.Text))
                cmd.Parameters.AddWithValue("@Globwlin", Val(txtGlobwlin.Text))
                cmd.Parameters.AddWithValue("@Bilirubin_Total", Val(txtBiliTotal.Text))
                cmd.Parameters.AddWithValue("@Triglycerides", Val(txtTriglyc.Text))
                cmd.Parameters.AddWithValue("@Total_Lipids", Val(txtTLipids.Text))
                cmd.Parameters.AddWithValue("@Sodium", Val(txtSodium.Text))
                cmd.Parameters.AddWithValue("@Potassium", Val(txtPotassium.Text))
                cmd.Parameters.AddWithValue("@Chloride", Val(txtChloride.Text))
                cmd.Parameters.AddWithValue("@Calcium", Val(txtCalcium.Text))
                cmd.Parameters.AddWithValue("@Magnesium", Val(txtMagnesium.Text))
                cmd.Parameters.AddWithValue("@Uric_Acid", Val(txtUricAcid.Text))
                cmd.Parameters.AddWithValue("@Cholesterol", Val(txtCholestrl.Text))
                cmd.Parameters.AddWithValue("@T3", Val(txtT3.Text))
                cmd.Parameters.AddWithValue("@T4", Val(txtT4.Text))
                cmd.Parameters.AddWithValue("@TSH", Val(txtTSH.Text))

                cmd.Connection = makeConnection()
                Dim res As Integer = cmd.ExecuteNonQuery()

                If res > 0 Then
                    MessageBox.Show("Patient Test Values Updated Successfully", "Update Status")
                Else
                    MessageBox.Show("Failed to Update Patient test Values!!", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Not Connected! " + ex.Message)
            End Try
        End If
    End Sub

    Private Function updateDialog() As Boolean
        Dim reply As DialogResult
        Dim mult As Integer = 0
        Do
            reply = MessageBox.Show("Do you wish to Update?", "Update Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Call Reset()
            mult += 1
        Loop While (reply > vbNo)
        If reply = vbYes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function chkData() As Boolean
        errmsg = ""
        If cmbPatID.Text = "" Then
            errmsg = errmsg & "Patient ID cannot be blank!"
            chkData = True
        ElseIf cmbfname.Text = "" Then
            errmsg = errmsg & "Name of patient cannot be blank!"
            chkData = True
        ElseIf txtBloodUrea.Text = "" Then
            errmsg = errmsg & "Blood Urea value cannot be blank!"
            chkData = True
        ElseIf txtCreatinine.Text = "" Then
            errmsg = errmsg & "Creatinine value cannot be blank!"
            chkData = True
        ElseIf txtTProtein.Text = "" Then
            errmsg = errmsg & "Total Protein value cannot be blank!"
            chkData = True
        ElseIf txtAlbumin.Text = "" Then
            errmsg = errmsg & "Albumin value cannot be blank!"
            chkData = True
        ElseIf txtGlobwlin.Text = "" Then
            errmsg = errmsg & "Globwlin value cannot be blank!"
            chkData = True
        ElseIf txtBiliTotal.Text = "" Then
            errmsg = errmsg & "Bilirubin value cannot be blank!"
            chkData = True
        ElseIf txtTLipids.Text = "" Then
            errmsg = errmsg & "Total Lipids value cannot be blank!"
            chkData = True
        ElseIf txtUricAcid.Text = "" Then
            errmsg = errmsg & "Uric Acid value cannot be blank!"
            chkData = True
        ElseIf txtCholestrl.Text = "" Then
            errmsg = errmsg & "Cholesterol value cannot be blank!"
            chkData = True
        ElseIf txtSodium.Text = "" Then
            errmsg = errmsg & "Sodium value cannot be blank!"
            chkData = True
        ElseIf txtPotassium.Text = "" Then
            errmsg = errmsg & "Potassium value cannot be blank!"
            chkData = True
        ElseIf txtChloride.Text = "" Then
            errmsg = errmsg & "Chloride value cannot be blank!"
            chkData = True
        ElseIf txtMagnesium.Text = "" Then
            errmsg = errmsg & "Magnesium value cannot be blank!"
            chkData = True
        ElseIf txtCalcium.Text = "" Then
            errmsg = errmsg & "Calcium value cannot be blank!"
            chkData = True
        ElseIf txtTProtein.Text = "" Then
            errmsg = errmsg & "Total Protein value cannot be blank!"
            chkData = True
        ElseIf txtT3.Text = "" Then
            errmsg = errmsg & "T3 value cannot be blank!"
            chkData = True
        ElseIf txtT4.Text = "" Then
            errmsg = errmsg & "T4 value cannot be blank!"
            chkData = True
        ElseIf txtTSH.Text = "" Then
            errmsg = errmsg & "Tsh value cannot be blank!"
            chkData = True
        Else
            chkData = False
        End If
    End Function

    Private Sub clearAll()
        txtBloodUrea.Clear()
        txtCreatinine.Clear()
        txtTProtein.Clear()
        txtAlbumin.Clear()
        txtGlobwlin.Clear()
        txtBiliTotal.Clear()
        txtTriglyc.Clear()
        txtTLipids.Clear()
        txtUricAcid.Clear()
        txtCholestrl.Clear()
        txtSodium.Clear()
        txtPotassium.Clear()
        txtChloride.Clear()
        txtMagnesium.Clear()
        txtCalcium.Clear()
        txtT3.Clear()
        txtT4.Clear()
        txtTSH.Clear()
    End Sub

    Private Sub dtpDiagDt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDiagDt.ValueChanged
        If dtpDiagDt.Value.Date < Date.Now Then
            dtpDiagDt.Value = Date.Now
        End If
        If dtpDiagDt.Value.Date > Date.Now Then
            dtpDiagDt.Value = Date.Now
        End If
    End Sub

    Private Sub txtCholestrl_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUricAcid.KeyPress, txtTSH.KeyPress, txtTriglyc.KeyPress, txtTProtein.KeyPress, txtTLipids.KeyPress, txtT4.KeyPress, txtT3.KeyPress, txtSodium.KeyPress, txtPotassium.KeyPress, txtMagnesium.KeyPress, txtGlobwlin.KeyPress, txtCreatinine.KeyPress, txtCholestrl.KeyPress, txtChloride.KeyPress, txtCalcium.KeyPress, txtBloodUrea.KeyPress, txtBiliTotal.KeyPress, txtAlbumin.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) And (Not Char.IsPunctuation(keyChar)) Then
            e.Handled = True
        End If
    End Sub
End Class