Public Class frmUpdateBlood
    Dim index As Integer
    Dim errmsg As String

    Private Sub frmUpdateBlood_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initialisationLoad()
    End Sub

    Private Sub cmbPatID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPatID.SelectedIndexChanged
        index = cmbPatID.SelectedIndex
        cmbfname.SelectedIndex = cmbPatID.SelectedIndex
        Call loadPatDocDetails()
        Call loadTestValues()
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
        txtage.Text = dt1.Rows(index).Item(24)
        txtgender.Text = dt1.Rows(index).Item(25)
        txtrefdoc.Text = dt1.Rows(index).Item(27)
        txtdocID.Text = dt1.Rows(index).Item(4)
        txtrefPathoID.Text = dt1.Rows(index).Item(5)
        txtrefPatho.Text = dt1.Rows(index).Item(26)
    End Sub

    Public Sub loadTestValues()
        Dim dt2 As DataTable = getDataTable(sqlstr)

        txtleucocytes.Text = dt2.Rows(index).Item(7)
        txterythrocytes.Text = dt2.Rows(index).Item(8)
        txthaemog.Text = dt2.Rows(index).Item(9)
        txtPCV.Text = dt2.Rows(index).Item(10)
        txtMCV.Text = dt2.Rows(index).Item(11)
        txtMCH.Text = dt2.Rows(index).Item(12)
        txtMCHC.Text = dt2.Rows(index).Item(13)
        txtRDW.Text = dt2.Rows(index).Item(14)
        txtMPV.Text = dt2.Rows(index).Item(15)
        txtPlatelets.Text = dt2.Rows(index).Item(16)
        txtTotRBC.Text = dt2.Rows(index).Item(17)
        txtNeutrop.Text = dt2.Rows(index).Item(18)
        txtLympho.Text = dt2.Rows(index).Item(19)
        txtMonocytes.Text = dt2.Rows(index).Item(20)
        txtEosinophils.Text = dt2.Rows(index).Item(21)
        txtBasophils.Text = dt2.Rows(index).Item(22)

        txtbloodtest.Text = dt2.Rows(index).Item(0)
    End Sub

    Public Sub initialisationLoad()

        cmbPatID.DropDownHeight = cmbPatID.ItemHeight * 8
        cmbfname.DropDownHeight = cmbfname.ItemHeight * 8

        Dim y As Integer
        Dim max As Integer

        sqlstr = "SELECT B.*,C.Pat_FName,C.Pat_Age,C.Pat_Gender,D.Staff_FName,E.Doc_FName FROM Diagnosis_Tests AS A,Blood_Tests AS B,Patient_Info AS C, Staff_Info D,Doctor_Info E WHERE B.Pat_ID=A.Pat_ID AND A.Pat_ID=C.Pat_ID AND B.Ref_PathoID=D.Staff_ID AND B.Ref_DocID=E.Doc_ID AND C.Pat_Status='Reg' AND BloodTest='Yes' AND A.B_Test_Status='Done' ORDER BY B.BloodTest_ID ASC"

        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count
        For y = 0 To max - 1
            txtDeptID.Text = dt.Rows(y).Item(1)
            txtTestID.Text = dt.Rows(y).Item(2)

            cmbPatID.Items.Add(dt.Rows(y).Item(3))
            cmbfname.Items.Add(dt.Rows(y).Item(23))
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
                cmd.CommandText = "UPDATE Blood_Tests SET Pat_ID=@Pat_ID,BloodTest_Date=@BloodTest_Date,Leucocytes=@Leucocytes,Erythrocytes=@Erythrocytes,Haemoglobin=@Haemoglobin,Packed_Cell_Volume=@Packed_Cell_Volume,MCV=@MCV,MCH=@MCH,MCHC=@MCHC,RDW=@RDW,MPV=@MPV,Platelets=@Platelets,Total_RBC=@Total_RBC,Neutrophils=@Neutrophils,Lymphocytes=@Lymphocytes,Monocytes=@Monocytes,Eosinophils=@Eosinophils,Basophils=@Basophils WHERE Pat_ID=@Pat_ID"

                cmd.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
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
                    MessageBox.Show("Patient Test Values Updated Successfully", "Update Status")
                Else
                    MessageBox.Show("Failed to Update Patient test Values!!", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Not Connected! " + ex.Message)
            End Try
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

    Private Sub dtpDiagDt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDiagDt.ValueChanged
        If dtpDiagDt.Value.Date < Date.Now Then
            dtpDiagDt.Value = Date.Now
        End If
        If dtpDiagDt.Value.Date > Date.Now Then
            dtpDiagDt.Value = Date.Now
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