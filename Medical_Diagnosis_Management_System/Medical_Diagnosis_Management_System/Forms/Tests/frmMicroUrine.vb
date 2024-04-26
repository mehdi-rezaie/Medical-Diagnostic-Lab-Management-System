Public Class frmMicroUrine
    Dim index As Integer
    Dim errmsg As String

    Private Sub frmMicroUrine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub cmbrefMicroID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbrefMicroID.SelectedIndexChanged
        cmbrefMicro.SelectedIndex = cmbrefMicroID.SelectedIndex
    End Sub

    Private Sub cmbrefMicro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbrefMicro.SelectedIndexChanged
        cmbrefMicroID.SelectedIndex = cmbrefMicro.SelectedIndex
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

    'To load patient details
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
        sqlstr1 = "SELECT Test_ID, Dept_ID FROM Test_Details WHERE Test_Name='Urine'"
        Dim dt1 As DataTable = getDataTable(sqlstr1)

        max2 = dt1.Rows.Count
        For y2 = 0 To max2 - 1
            txtTestID.Text = dt1.Rows(y2).Item(0)
            txtDeptID.Text = dt1.Rows(y2).Item(1)
        Next

        sqlstr = "SELECT B.Pat_ID,B.Doc_ID,C.Doc_FName,A.Pat_FName,A.Pat_Age,A.Pat_Gender FROM Patient_Info A, Diagnosis_Tests B ,Doctor_Info C WHERE B.Pat_ID=A.Pat_ID AND C.Doc_ID=B.Doc_ID AND B.UrineTest='Yes' AND B.U_Test_Status='Pending'"

        Dim dt As DataTable = getDataTable(sqlstr)

        max = dt.Rows.Count
        For y = 0 To max - 1
            cmbPatID.Items.Add(dt.Rows(y).Item(0))
            cmbfname.Items.Add(dt.Rows(y).Item(3))
        Next

        sqlstr3 = "SELECT Staff_ID,Staff_FName FROM Staff_Info WHERE Staff_Status='In' AND Staff_Desc='Microbiologist'"
        Dim dt3 As DataTable = getDataTable(sqlstr3)
        max3 = dt3.Rows.Count
        For y1 = 0 To max3 - 1
            cmbrefMicroID.Items.Add(dt3.Rows(y1).Item(0))
            cmbrefMicro.Items.Add(dt3.Rows(y1).Item(1))
        Next
        txtDeptName.Text = "Microbiology"

        Call incrUrineTest()
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
                cmd.CommandText = "INSERT INTO Urine_Tests(UrineTest_ID,Dept_ID,Test_ID,Pat_ID,Ref_DocID,Ref_MicroID,UrineTest_Date,Appearance,Reaction,Albumin,Sugar,Spermatozoa,Amorphous_Sediments,Others,Bile_Pigment,Bile_Salt,Occult_Blood,Amino_Acid,pH,Nitrate)VALUES(@UrineTest_ID,@Dept_ID,@Test_ID,@Pat_ID,@Ref_DocID,@Ref_MicroID,@UrineTest_Date,@Appearance,@Reaction,@Albumin,@Sugar,@Spermatozoa,@Amorphous_Sediments,@Others,@Bile_Pigment,@Bile_Salt,@Occult_Blood,@Amino_Acid,@pH,@Nitrate)"

                cmd.Parameters.AddWithValue("@UrineTest_ID", Val(txturinetest.Text))

                cmd.Parameters.AddWithValue("@Dept_ID", Val(txtDeptID.Text))
                cmd.Parameters.AddWithValue("@Test_ID", Val(txtTestID.Text))

                cmd.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
                cmd.Parameters.AddWithValue("@Ref_DocID", Val(txtdocID.Text))
                cmd.Parameters.AddWithValue("@Ref_MicroID", Val(cmbrefMicroID.Text))
                cmd.Parameters.AddWithValue("@UrineTest_Date", dtpDiagDt.Value.Date)
                cmd.Parameters.AddWithValue("@Appearance", txtappear.Text)
                cmd.Parameters.AddWithValue("@Reaction", txtreaction.Text)
                cmd.Parameters.AddWithValue("@Albumin", txtalbumin.Text)
                cmd.Parameters.AddWithValue("@Sugar", txtsugar.Text)
                cmd.Parameters.AddWithValue("@Spermatozoa", txtsperm.Text)
                cmd.Parameters.AddWithValue("@Amorphous_Sediments", txtampsed.Text)
                cmd.Parameters.AddWithValue("@Others", txtothers.Text)
                cmd.Parameters.AddWithValue("@Bile_Pigment", txtbilepig.Text)
                cmd.Parameters.AddWithValue("@Bile_Salt", txtbilesalt.Text)
                cmd.Parameters.AddWithValue("@Occult_Blood", txtoccultbld.Text)
                cmd.Parameters.AddWithValue("@Amino_Acid", txtaminoacid.Text)
                cmd.Parameters.AddWithValue("@pH", txtpH.Text)
                cmd.Parameters.AddWithValue("@Nitrate", txtnitrate.Text)

                cmd.Connection = makeConnection()

                Dim res As Integer = cmd.ExecuteNonQuery()
                If res > 0 Then
                    MessageBox.Show("Patient Tests Records Registered Successfully", "Registration Status")

                    'To update the Diagnosis_Tests table for test done
                    Try
                        cmd1.CommandText = "UPDATE Diagnosis_Tests SET Pat_ID=@Pat_ID,U_Test_Status=@U_Test_Status WHERE Pat_ID=@Pat_ID"
                        cmd1.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
                        cmd1.Parameters.AddWithValue("@U_Test_Status", "Done")

                        cmd1.Connection = makeConnection()

                        Dim res1 As Integer = cmd1.ExecuteNonQuery()
                        If res1 > 0 Then
                            MessageBox.Show("Tests Done", "Test Status")
                            cmbPatID.Items.RemoveAt(index)
                            cmbfname.Items.RemoveAt(index)
                            Call clearPatDetails()
                            Call clearAll()
                            Call incrUrineTest()
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


    Private Sub incrUrineTest()
        Dim x As Integer
        Dim max2 As Integer
        sqlstr2 = "SELECT UrineTest_ID FROM Urine_Tests"
        Dim dt2 As DataTable = getDataTable(sqlstr2)
        max2 = dt2.Rows.Count
        If max2 = 0 Then
            x = 1
        Else
            x = max2 + 1
        End If
        txturinetest.Text = x
        txturinetest.Enabled = False
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
        ElseIf cmbrefMicro.Text = "" Then
            errmsg = errmsg & "Ref. Micrologist name cannot be blank!"
            chkData = True
        ElseIf txtappear.Text = "" Then
            errmsg = errmsg & "Appearance cannot be left blank!"
            chkData = True
        ElseIf txtreaction.Text = "" Then
            errmsg = errmsg & "Reaction cannot be left blank!"
            chkData = True
        ElseIf txtalbumin.Text = "" Then
            errmsg = errmsg & "Albumin cannot be left blank!"
            chkData = True
        ElseIf txtsugar.Text = "" Then
            errmsg = errmsg & "Sugar cannot be left blank!"
            chkData = True
        ElseIf txtsperm.Text = "" Then
            errmsg = errmsg & "Spermatozoa cannot be left blank!"
            chkData = True
        ElseIf txtampsed.Text = "" Then
            errmsg = errmsg & "Amorphous Sedimants cannot be left blank!"
            chkData = True
        ElseIf txtothers.Text = "" Then
            errmsg = errmsg & "Others cannot be left blank!"
            chkData = True
        ElseIf txtbilepig.Text = "" Then
            errmsg = errmsg & "Bile Pigment cannot be left blank!"
            chkData = True
        ElseIf txtbilesalt.Text = "" Then
            errmsg = errmsg & "Bile Salt cannot be left blank!"
            chkData = True
        ElseIf txtoccultbld.Text = "" Then
            errmsg = errmsg & "Occult Blood cannot be left blank!"
            chkData = True
        ElseIf txtaminoacid.Text = "" Then
            errmsg = errmsg & "Amino Acids cannot be left blank!"
            chkData = True
        ElseIf txtpH.Text = "" Then
            errmsg = errmsg & "pH cannot be left blank!"
            chkData = True
        ElseIf txtnitrate.Text = "" Then
            errmsg = errmsg & "Nitrate cannot be left blank!"
            chkData = True
        Else
            chkData = False
        End If
    End Function

    Private Sub clearAll()
        txtappear.Clear()
        txtalbumin.Clear()
        txtsugar.Clear()
        txtreaction.Clear()
        txtsperm.Clear()
        txtampsed.Clear()
        txtothers.Clear()
        txtbilepig.Clear()
        txtbilesalt.Clear()
        txtoccultbld.Clear()
        txtbilesalt.Clear()
        txtoccultbld.Clear()
        txtaminoacid.Clear()
        txtpH.Clear()
        txtnitrate.Clear()
    End Sub

    Private Sub clearPatDetails()
        cmbPatID.SelectedIndex = -1
        cmbfname.SelectedIndex = -1
        cmbrefMicroID.SelectedIndex = -1
        cmbrefMicro.SelectedIndex = -1
        txtage.Text = ""
        txtgender.Text = ""
        txtrefdoc.Text = ""
        txtdocID.Text = ""
    End Sub
End Class