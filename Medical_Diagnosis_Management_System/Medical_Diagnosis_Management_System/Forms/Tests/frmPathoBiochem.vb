Public Class frmPathoBiochem
    Dim index As Integer
    Dim errmsg As String

    Private Sub frmPathoBiochem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initialisationLoad()
    End Sub

    Private Sub cmbPatID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPatID.SelectedIndexChanged
        index = cmbPatID.SelectedIndex
        cmbfname.SelectedIndex = cmbPatID.SelectedIndex
        loadPatDocDetails()
    End Sub

    Private Sub cmbfname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfname.SelectedIndexChanged
        cmbPatID.SelectedIndex = cmbfname.SelectedIndex
    End Sub

    Private Sub cmbrefPatho_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbrefPatho.SelectedIndexChanged
        cmbrefPathID.SelectedIndex = cmbrefPatho.SelectedIndex
    End Sub

    Private Sub cmbrefPathID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbrefPathID.SelectedIndexChanged
        cmbrefPatho.SelectedIndex = cmbrefPathID.SelectedIndex
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call clearAll()
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Call insertNewTestRecords()
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
        txtage.Text = dt1.Rows(index).Item(4)
        txtgender.Text = dt1.Rows(index).Item(5)
        txtrefdoc.Text = dt1.Rows(index).Item(2)
        txtdocID.Text = dt1.Rows(index).Item(1)
    End Sub

    Public Sub initialisationLoad()
        cmbPatID.DropDownHeight = cmbPatID.ItemHeight * 5
        cmbfname.DropDownHeight = cmbfname.ItemHeight * 5

        Dim y, y1, y2 As Integer
        Dim max, max2, max3 As Integer

        'To retrieve test relation with department
        sqlstr1 = "SELECT Test_ID, Dept_ID FROM Test_Details WHERE Test_Name='Biochemistry'"
        Dim dt1 As DataTable = getDataTable(sqlstr1)

        max2 = dt1.Rows.Count
        For y2 = 0 To max2 - 1
            txtTestID.Text = dt1.Rows(y2).Item(0)
            txtDeptID.Text = dt1.Rows(y2).Item(1)
        Next

        sqlstr = "SELECT B.Pat_ID,B.Doc_ID,C.Doc_FName,A.Pat_FName,A.Pat_Age,A.Pat_Gender FROM Patient_Info A, Diagnosis_Tests B ,Doctor_Info C WHERE B.Pat_ID=A.Pat_ID AND C.Doc_ID=B.Doc_ID AND B.BiochemTest='Yes' AND B.BC_Test_Status='Pending'"
        Dim dt As DataTable = getDataTable(sqlstr)

        max = dt.Rows.Count
        For y = 0 To max - 1
            cmbPatID.Items.Add(dt.Rows(y).Item(0))
            cmbfname.Items.Add(dt.Rows(y).Item(3))
        Next

        sqlstr3 = "SELECT Staff_ID,Staff_FName FROM Staff_Info WHERE Staff_Status='In' AND Staff_Desc='Pathologist'"
        Dim dt3 As DataTable = getDataTable(sqlstr3)
        max3 = dt3.Rows.Count
        For y1 = 0 To max3 - 1
            cmbrefPathID.Items.Add(dt3.Rows(y1).Item(0))
            cmbrefPatho.Items.Add(dt3.Rows(y1).Item(1))
        Next
        txtDeptName.Text = "Pathology"

        Call incrBiochemTest()
    End Sub


    Private Sub insertNewTestRecords()
        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        End If

        Dim cmd As New OleDb.OleDbCommand
        Dim cmd1 As New OleDb.OleDbCommand

        If saveDialog() = True Then
            Try
                cmd.CommandText = "INSERT INTO Biochemistry_Tests(Biochem_ID,Dept_ID,Test_ID,Pat_ID,Ref_DocID,Ref_PathoID,BiochemTest_Date,Blood_Urea,Creatinine,Total_Protein,Albumin,Globwlin,Bilirubin_Total,Triglycerides,Total_Lipids,Sodium,Potassium,Chloride,Calcium,Magnesium,Uric_Acid,Cholesterol,T3,T4,TSH)VALUES(@Biochem_ID,@Dept_ID,@Test_ID,@Pat_ID,@Ref_DocID,@Ref_PathoID,@BiochemTest_Date,@Blood_Urea,@Creatinine,@Total_Protein,@Albumin,@Globwlin,@Bilirubin_Total,@Triglycerides,@Total_Lipids,@Sodium,@Potassium,@Chloride,@Calcium,@Magnesium,@Uric_Acid,@Cholesterol,@T3,@T4,@TSH)"

                cmd.Parameters.AddWithValue("@Biochem_ID", Val(txtbiochemtest.Text))
                cmd.Parameters.AddWithValue("@Dept_ID", Val(txtDeptID.Text))
                cmd.Parameters.AddWithValue("@Test_ID", Val(txtTestID.Text))
                cmd.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
                cmd.Parameters.AddWithValue("@Ref_DocID", Val(txtdocID.Text))
                cmd.Parameters.AddWithValue("@Ref_PathoID", Val(cmbrefPathID.Text))
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
                    MessageBox.Show("Patient Tests Records Registered Successfully", "Registration Status")
                    'To update the Diagnosis_Tests table for test done
                    Try
                        cmd1.CommandText = "UPDATE Diagnosis_Tests SET Pat_ID=@Pat_ID,BC_Test_Status=@BC_Test_Status WHERE Pat_ID=@Pat_ID"
                        cmd1.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
                        cmd1.Parameters.AddWithValue("@BC_Test_Status", "Done")

                        cmd1.Connection = makeConnection()

                        Dim res1 As Integer = cmd1.ExecuteNonQuery()
                        If res1 > 0 Then
                            MessageBox.Show("Tests Done", "Test Status")
                            cmbPatID.Items.RemoveAt(index)
                            cmbfname.Items.RemoveAt(index)
                            Call clearPatDetails()
                            Call clearAll()
                            Call incrBiochemTest()
                        Else
                            MessageBox.Show("Failed", "Test Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Not Connected! " + ex.Message)
                    End Try
                Else
                    MessageBox.Show("Failed to add patient tests!!", "Registration Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Not Connected! " + ex.Message)
            End Try
        End If
        cmd.Dispose()
        cmd1.Dispose()
    End Sub

    Private Sub incrBiochemTest()
        Dim x As Integer
        Dim max2 As Integer
        sqlstr2 = "SELECT Biochem_ID FROM Biochemistry_Tests"
        Dim dt2 As DataTable = getDataTable(sqlstr2)
        max2 = dt2.Rows.Count
        If max2 = 0 Then
            x = 1
        Else
            x = max2 + 1
        End If
        txtbiochemtest.Text = x
        txtbiochemtest.Enabled = False
    End Sub

    Private Sub dtpDiagDt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDiagDt.ValueChanged
        If dtpDiagDt.Value.Date < Date.Now Then
            dtpDiagDt.Value = Date.Now
        End If
        If dtpDiagDt.Value.Date > Date.Now Then
            dtpDiagDt.Value = Date.Now
        End If
    End Sub


    Public Function chkData() As Boolean
        errmsg = ""
        If cmbPatID.Text = "" Then
            errmsg = errmsg & "Patient ID cannot be blank!"
            chkData = True
        ElseIf cmbfname.Text = "" Then
            errmsg = errmsg & "Name of patient cannot be blank!"
            chkData = True
        ElseIf cmbrefPatho.Text = "" Then
            errmsg = errmsg & "Ref. Pathologist name cannot be blank!"
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


    Private Sub clearPatDetails()
        cmbPatID.SelectedIndex = -1
        cmbfname.SelectedIndex = -1
        cmbrefPathID.SelectedIndex = -1
        cmbrefPatho.SelectedIndex = -1
        txtage.Text = ""
        txtgender.Text = ""
        txtrefdoc.Text = ""
        txtdocID.Text = ""
    End Sub

    Private Sub txtBloodUrea_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBloodUrea.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) And (Not Char.IsPunctuation(keyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCreatinine_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCreatinine.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) And (Not Char.IsPunctuation(keyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTProtein_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUricAcid.KeyPress, txtTriglyc.KeyPress, txtTProtein.KeyPress, txtTLipids.KeyPress, txtGlobwlin.KeyPress, txtCholestrl.KeyPress, txtBiliTotal.KeyPress, txtAlbumin.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) And (Not Char.IsPunctuation(keyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSodium_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTSH.KeyPress, txtT4.KeyPress, txtT3.KeyPress, txtSodium.KeyPress, txtPotassium.KeyPress, txtMagnesium.KeyPress, txtChloride.KeyPress, txtCalcium.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) And (Not Char.IsPunctuation(keyChar)) Then
            e.Handled = True
        End If
    End Sub
End Class