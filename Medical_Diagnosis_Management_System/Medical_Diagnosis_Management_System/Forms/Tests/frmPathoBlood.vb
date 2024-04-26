Public Class frmPathoBlood
    Dim index As Integer
    Dim errmsg As String

    Private Sub frmPathoBlood_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    'To load the patient and ref. doctor details
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

        Dim y, y1 As Integer
        Dim max, max2, max3 As Integer

        'To retrieve test relation with department
        sqlstr1 = "SELECT Test_ID, Dept_ID FROM Test_Details WHERE Test_Name='Blood'"
        Dim dt1 As DataTable = getDataTable(sqlstr1)

        max2 = dt1.Rows.Count
        For y2 = 0 To max2 - 1
            txtTestID.Text = dt1.Rows(y2).Item(0)
            txtDeptID.Text = dt1.Rows(y2).Item(1)
        Next

        'To display all the pending patients to be tested
        sqlstr = "SELECT B.Pat_ID,B.Doc_ID,C.Doc_FName,A.Pat_FName,A.Pat_Age,A.Pat_Gender FROM Patient_Info A, Diagnosis_Tests B ,Doctor_Info C WHERE B.Pat_ID=A.Pat_ID AND C.Doc_ID=B.Doc_ID AND B.BloodTest='Yes' AND B.B_Test_Status='Pending'"

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
        Call incrBloodTest()
    End Sub

    Private Sub insertNewTestRecords()
        Dim cmd As New OleDb.OleDbCommand
        Dim cmd1 As New OleDb.OleDbCommand

        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        End If

        If saveDialog() = True Then
            'To enter the new test values for the patient
            Try
                cmd.CommandText = "INSERT INTO Blood_Tests(BloodTest_ID,Dept_ID,Test_ID,Pat_ID,Ref_DocID,Ref_PathoID,BloodTest_Date,Leucocytes,Erythrocytes,Haemoglobin,Packed_Cell_Volume,MCV,MCH,MCHC,RDW,MPV,Platelets,Total_RBC,Neutrophils,Lymphocytes,Monocytes,Eosinophils,Basophils)VALUES(@BloodTest_ID,@Dept_ID,@Test_ID,@Pat_ID,@Ref_DocID,@Ref_PathoID,@BloodTest_Date,@Leucocytes,@Erythrocytes,@Haemoglobin,@Packed_Cell_Volume,@MCV,@MCH,@MCHC,@RDW,@MPV,@Platelets,@Total_RBC,@Neutrophils,@Lymphocytes,@Monocytes,@Eosinophils,@Basophils)"

                cmd.Parameters.AddWithValue("@BloodTest_ID", Val(txtbloodtest.Text))

                cmd.Parameters.AddWithValue("@Dept_ID", Val(txtDeptID.Text))
                cmd.Parameters.AddWithValue("@Test_ID", Val(txtTestID.Text))

                cmd.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
                cmd.Parameters.AddWithValue("@Ref_DocID", Val(txtdocID.Text))
                cmd.Parameters.AddWithValue("@Ref_PathoID", Val(cmbrefPathID.Text))
                cmd.Parameters.AddWithValue("@BloodTest_Date", dtpDiagDt.Value.Date)
                cmd.Parameters.AddWithValue("@Leucocytes", Val(txtleucocytes.Text))
                cmd.Parameters.AddWithValue("@Erythrocytes", Val(txterythrocytes.Text))
                cmd.Parameters.AddWithValue("@Haemoglobin", Val(txthaemog.Text))
                cmd.Parameters.AddWithValue("@Packed_Cell_Volume", Val(txtPCV.Text))
                cmd.Parameters.AddWithValue("@MCV", Val(txtMCV.Text))
                cmd.Parameters.AddWithValue("@MCH", Val(txtMCH.Text))
                cmd.Parameters.AddWithValue("@MCHC", Val(txtMCHC.Text))
                cmd.Parameters.AddWithValue("@RDW", Val(txtRDW.Text))
                cmd.Parameters.AddWithValue("@MPV", Val(txtMPV.Text))
                cmd.Parameters.AddWithValue("@Platelets", Val(txtPlatelets.Text))
                cmd.Parameters.AddWithValue("@Total_RBC", Val(txtTotRBC.Text))
                cmd.Parameters.AddWithValue("@Neutrophils", Val(txtNeutrop.Text))
                cmd.Parameters.AddWithValue("@Lymphocytes", Val(txtLympho.Text))
                cmd.Parameters.AddWithValue("@Monocytes", Val(txtMonocytes.Text))
                cmd.Parameters.AddWithValue("@Eosinophils", Val(txtEosinophils.Text))
                cmd.Parameters.AddWithValue("@Basophils", Val(txtBasophils.Text))

                cmd.Connection = makeConnection()

                Dim res As Integer = cmd.ExecuteNonQuery()
                If res > 0 Then
                    MessageBox.Show("Patient Tests Records Registered Successfully", "Inserted data")

                    'To update the Diagnosis_Tests table for test done
                    Try
                        cmd1.CommandText = "UPDATE Diagnosis_Tests SET Pat_ID=@Pat_ID,B_Test_Status=@B_Test_Status WHERE Pat_ID=@Pat_ID"
                        cmd1.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
                        cmd1.Parameters.AddWithValue("@B_Test_Status", "Done")

                        cmd1.Connection = makeConnection()

                        Dim res1 As Integer = cmd1.ExecuteNonQuery()
                        If res1 > 0 Then
                            MessageBox.Show("Tests Done!", "Test Status")
                            cmbPatID.Items.RemoveAt(index)
                            cmbfname.Items.RemoveAt(index)
                            Call clearPatDetails()
                            Call clearAll()
                            Call incrBloodTest()
                        Else
                            MessageBox.Show("Failed", "Test Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Not Connected: " + ex.Message)
                    End Try

                Else
                    MessageBox.Show("Failed to add patient tests!!", "Inserted data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Not Connected! " + ex.Message)
            End Try
        End If
        cmd.Dispose()
        cmd1.Dispose()
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
            errmsg = errmsg & "Name of Ref. Pathologist cannot be blank!"
            chkData = True
        ElseIf txtleucocytes.Text = "" Then
            errmsg = errmsg & "Leucocytes value cannot be blank!"
            chkData = True
        ElseIf txterythrocytes.Text = "" Then
            errmsg = errmsg & "Erythrocytes value cannot be blank!"
            chkData = True
        ElseIf txthaemog.Text = "" Then
            errmsg = errmsg & "Haemoglobin value cannot be blank!"
            chkData = True
        ElseIf txtPCV.Text = "" Then
            errmsg = errmsg & "Packed Cell Volume cannot be blank!"
            chkData = True
        ElseIf txtMCV.Text = "" Then
            errmsg = errmsg & "MCV value cannot be blank!"
            chkData = True
        ElseIf txtMCH.Text = "" Then
            errmsg = errmsg & "MCH value cannot be blank!"
            chkData = True
        ElseIf txtMCHC.Text = "" Then
            errmsg = errmsg & "MCHC value cannot be blank!"
            chkData = True
        ElseIf txtRDW.Text = "" Then
            errmsg = errmsg & "RDW value cannot be blank!"
            chkData = True
        ElseIf txtMPV.Text = "" Then
            errmsg = errmsg & "MPV value cannot be blank!"
            chkData = True
        ElseIf txtPlatelets.Text = "" Then
            errmsg = errmsg & "Platelets value cannot be blank!"
            chkData = True
        ElseIf txtTotRBC.Text = "" Then
            errmsg = errmsg & "Total RBC value cannot be blank!"
            chkData = True
        ElseIf txtNeutrop.Text = "" Then
            errmsg = errmsg & "Neutrophils value cannot be blank!"
            chkData = True
        ElseIf txtLympho.Text = "" Then
            errmsg = errmsg & "Lymphocytes value cannot be blank!"
            chkData = True
        ElseIf txtMonocytes.Text = "" Then
            errmsg = errmsg & "Monocytes value cannot be blank!"
            chkData = True
        ElseIf txtEosinophils.Text = "" Then
            errmsg = errmsg & "Eodinophils value cannot be blank!"
            chkData = True
        ElseIf txtBasophils.Text = "" Then
            errmsg = errmsg & "Basophils value cannot be blank!"
            chkData = True
        Else
            chkData = False
        End If
    End Function

    Private Sub clearAll()
        txtleucocytes.Clear()
        txterythrocytes.Clear()
        txthaemog.Clear()
        txtPCV.Clear()
        txtMCV.Clear()
        txtMCH.Clear()
        txtMCHC.Clear()
        txtRDW.Clear()
        txtMPV.Clear()
        txtPlatelets.Clear()
        txtTotRBC.Clear()
        txtNeutrop.Clear()
        txtLympho.Clear()
        txtMonocytes.Clear()
        txtEosinophils.Clear()
        txtBasophils.Clear()
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

    Private Sub incrBloodTest()
        Dim x As Integer
        Dim max2 As Integer
        sqlstr2 = "SELECT BloodTest_ID FROM Blood_Tests"
        Dim dt2 As DataTable = getDataTable(sqlstr2)
        max2 = dt2.Rows.Count
        If max2 = 0 Then
            x = 1
        Else
            x = max2 + 1
        End If
        txtbloodtest.Text = x
    End Sub

    Private Sub txtleucocytes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txterythrocytes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMCH_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotRBC.KeyPress, txtRDW.KeyPress, txtPlatelets.KeyPress, txtPCV.KeyPress, txtNeutrop.KeyPress, txtMPV.KeyPress, txtMonocytes.KeyPress, txtMCV.KeyPress, txtMCHC.KeyPress, txtMCH.KeyPress, txtLympho.KeyPress, txtleucocytes.KeyPress, txthaemog.KeyPress, txterythrocytes.KeyPress, txtEosinophils.KeyPress, txtBasophils.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) And (Not Char.IsPunctuation(keyChar)) Then
            e.Handled = True
        End If
    End Sub
End Class