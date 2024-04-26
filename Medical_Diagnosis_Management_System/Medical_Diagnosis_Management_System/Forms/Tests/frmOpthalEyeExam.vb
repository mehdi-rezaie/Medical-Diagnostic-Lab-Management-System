Public Class frmOpthalEyeExam
    Dim index As Integer
    Dim errmsg As String

    Private Sub frmOpthalEyeExam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub cmbrefOpthal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbrefOpthal.SelectedIndexChanged
        cmbrefOpthalID.SelectedIndex = cmbrefOpthal.SelectedIndex
    End Sub

    Private Sub cmbrefOpthalID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbrefOpthalID.SelectedIndexChanged
        cmbrefOpthal.SelectedIndex = cmbrefOpthalID.SelectedIndex
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
        sqlstr1 = "SELECT Test_ID, Dept_ID FROM Test_Details WHERE Test_Name='Eye Examination'"
        Dim dt1 As DataTable = getDataTable(sqlstr1)

        max2 = dt1.Rows.Count
        For y2 = 0 To max2 - 1
            txtTestID.Text = dt1.Rows(y2).Item(0)
            txtDeptID.Text = dt1.Rows(y2).Item(1)
        Next

        'To display all the pending patients to be tested
        sqlstr = "SELECT B.Pat_ID,B.Doc_ID,C.Doc_FName,A.Pat_FName,A.Pat_Age,A.Pat_Gender FROM Patient_Info A, Diagnosis_Tests B ,Doctor_Info C WHERE B.Pat_ID=A.Pat_ID AND C.Doc_ID=B.Doc_ID AND B.OpthalTest='Yes' AND B.O_Test_Status='Pending'"

        Dim dt As DataTable = getDataTable(sqlstr)

        max = dt.Rows.Count
        For y = 0 To max - 1
            cmbPatID.Items.Add(dt.Rows(y).Item(0))
            cmbfname.Items.Add(dt.Rows(y).Item(3))
        Next

        sqlstr3 = "SELECT Staff_ID,Staff_FName FROM Staff_Info WHERE Staff_Status='In' AND Staff_Desc='Opthalmologist'"
        Dim dt3 As DataTable = getDataTable(sqlstr3)
        max3 = dt3.Rows.Count
        For y1 = 0 To max3 - 1
            cmbrefOpthalID.Items.Add(dt3.Rows(y1).Item(0))
            cmbrefOpthal.Items.Add(dt3.Rows(y1).Item(1))
        Next

        txtDeptName.Text = "Opthalmology"
        Call incrOpthalTest()
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
                cmd.CommandText = "INSERT INTO EyeExam_Tests(Opthal_ID,Dept_ID,Test_ID,Pat_ID,Ref_DocID,Ref_OpthalID,EyeTest_Date,EyeTest_Name,Eye,Remark,Myopia,Hyperopia,Radius,Area)VALUES(@Opthal_ID,@Dept_ID,@Test_ID,@Pat_ID,@Ref_DocID,@Ref_OpthalID,@EyeTest_Date,@EyeTest_Name,@Eye,@Remark,@Myopia,@Hyperopia,@Radius,@Area)"

                cmd.Parameters.AddWithValue("@Opthal_ID", Val(txtopthaltest.Text))

                cmd.Parameters.AddWithValue("@Dept_ID", Val(txtDeptID.Text))
                cmd.Parameters.AddWithValue("@Test_ID", Val(txtTestID.Text))
                cmd.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
                cmd.Parameters.AddWithValue("@Ref_DocID", Val(txtdocID.Text))
                cmd.Parameters.AddWithValue("@Ref_OpthalID", Val(cmbrefOpthalID.Text))
                cmd.Parameters.AddWithValue("@EyeTest_Date", dtpDiagDt.Value.Date)
                cmd.Parameters.AddWithValue("@EyeTest_Name", txtexamname.Text)
                If RbtnLeft.Checked Then
                    cmd.Parameters.AddWithValue("@Eye", RbtnLeft.Text)
                ElseIf RbtnRight.Checked Then
                    cmd.Parameters.AddWithValue("@Eye", RbtnRight.Text)
                ElseIf RbtnBoth.Checked Then
                    cmd.Parameters.AddWithValue("@Eye", RbtnBoth.Text)
                End If
                cmd.Parameters.AddWithValue("@Remark", txtremark.Text)
                cmd.Parameters.AddWithValue("@Myopia", Val(txtmyopia.Text))
                cmd.Parameters.AddWithValue("@Hyperopia", Val(txthyperopia.Text))
                cmd.Parameters.AddWithValue("@Radius", Val(txtradius.Text))
                cmd.Parameters.AddWithValue("@Area", Val(txtarea.Text))

                cmd.Connection = makeConnection()

                Dim res As Integer = cmd.ExecuteNonQuery()
                If res > 0 Then
                    MessageBox.Show("Patient Tests Records Registered Successfully", "Registration Status")

                    'To update the Diagnosis_Tests table for test done
                    Try
                        cmd1.CommandText = "UPDATE Diagnosis_Tests SET Pat_ID=@Pat_ID,O_Test_Status=@O_Test_Status WHERE Pat_ID=@Pat_ID"
                        cmd1.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
                        cmd1.Parameters.AddWithValue("@O_Test_Status", "Done")

                        cmd1.Connection = makeConnection()
                        Dim res1 As Integer = cmd1.ExecuteNonQuery()
                        If res1 > 0 Then
                            MessageBox.Show("Tests Done!", "Test Status")
                            cmbPatID.Items.RemoveAt(index)
                            cmbfname.Items.RemoveAt(index)
                            Call clearPatDetails()
                            Call clearAll()
                            Call incrOpthalTest()
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
        cmd1.Dispose()
        cmd.Dispose()
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
        ElseIf cmbrefOpthal.Text = "" Then
            errmsg = errmsg & "Name of Ref. Radiologist cannot be blank!"
            chkData = True
        ElseIf txtexamname.Text = "" Then
            errmsg = errmsg & "Examination Name cannot be blank!"
            chkData = True
        ElseIf RbtnLeft.Checked = False And
        RbtnRight.Checked = False And
        RbtnBoth.Checked = False And
            errmsg = errmsg & "Choose Eye!" Then
            chkData = True
        ElseIf txtmyopia.Text = "" Then
            errmsg = errmsg & "Myopia cannot be blank!"
            chkData = True
        ElseIf txthyperopia.Text = "" Then
            errmsg = errmsg & "Hyperopia cannot be blank!"
            chkData = True
        ElseIf txtradius.Text = "" Then
            errmsg = errmsg & "Radius cannot be blank!"
            chkData = True
        ElseIf txtarea.Text = "" Then
            errmsg = errmsg & "Area cannot be blank!"
            chkData = True
        Else
            chkData = False
        End If
    End Function

    Private Sub clearPatDetails()
        cmbPatID.SelectedIndex = -1
        cmbfname.SelectedIndex = -1
        cmbrefOpthalID.SelectedIndex = -1
        cmbrefOpthal.SelectedIndex = -1
        txtage.Text = ""
        txtgender.Text = ""
        txtrefdoc.Text = ""
        txtdocID.Text = ""
    End Sub

    Private Sub clearAll()
        txtexamname.Clear()
        RbtnLeft.Checked = False
        RbtnRight.Checked = False
        RbtnBoth.Checked = False
        txtremark.Clear()
        txtmyopia.Clear()
        txthyperopia.Clear()
        txtradius.Clear()
        txtarea.Clear()
    End Sub

    Private Sub incrOpthalTest()
        Dim x As Integer
        Dim max2 As Integer
        sqlstr2 = "SELECT Opthal_ID FROM EyeExam_Tests"
        Dim dt2 As DataTable = getDataTable(sqlstr2)
        max2 = dt2.Rows.Count
        If max2 = 0 Then
            x = 1
        Else
            x = max2 + 1
        End If
        txtopthaltest.Text = x
    End Sub

    Private Sub txtmyopia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmyopia.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) And (Not Char.IsPunctuation(keyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txthyperopia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthyperopia.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) And (Not Char.IsPunctuation(keyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtradius_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtradius.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) And (Not Char.IsPunctuation(keyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtarea_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtarea.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) And (Not Char.IsPunctuation(keyChar)) Then
            e.Handled = True
        End If
    End Sub
End Class