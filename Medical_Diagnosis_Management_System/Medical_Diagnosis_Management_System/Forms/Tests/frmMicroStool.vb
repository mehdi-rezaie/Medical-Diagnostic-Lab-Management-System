Public Class frmMicroStool
    Dim index As Integer
    Dim errmsg As String

    Private Sub frmMicroStool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Public Sub loadPatDocDetails()
        Dim dt1 As DataTable = getDataTable(sqlstr)
        txtage.Text = dt1.Rows(index).Item(4)
        txtgender.Text = dt1.Rows(index).Item(5)
        txtrefdoc.Text = dt1.Rows(index).Item(2)
        txtdocID.Text = dt1.Rows(index).Item(1)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If exitForm() = True Then
            con.Close()
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Public Sub initialisationLoad()
        cmbPatID.DropDownHeight = cmbPatID.ItemHeight * 5
        cmbfname.DropDownHeight = cmbfname.ItemHeight * 5

        Dim y, y1 As Integer
        Dim max, max2, max3 As Integer

        'To retrieve test relation with department
        sqlstr1 = "SELECT Test_ID, Dept_ID FROM Test_Details WHERE Test_Name='Stool'"
        Dim dt1 As DataTable = getDataTable(sqlstr1)

        max2 = dt1.Rows.Count
        For y2 = 0 To max2 - 1
            txtTestID.Text = dt1.Rows(y2).Item(0)
            txtDeptID.Text = dt1.Rows(y2).Item(1)
        Next

        sqlstr = "SELECT B.Pat_ID,B.Doc_ID,C.Doc_FName,A.Pat_FName,A.Pat_Age,A.Pat_Gender FROM Patient_Info A, Diagnosis_Tests B ,Doctor_Info C WHERE B.Pat_ID=A.Pat_ID AND C.Doc_ID=B.Doc_ID AND B.StoolTest='Yes' AND B.ST_Test_Status='Pending'"

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

        Call incrStoolTest()
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
                cmd.CommandText = "INSERT INTO Stool_Tests(Stool_ID,Dept_ID,Test_ID,Pat_ID,Ref_DocID,Ref_MicroID,StoolTest_Date,Color,Consistency,Mucus,Blood,Macrophages,EColi,Trophozoite,Occult_Blood,Ph)VALUES(@Stool_ID,@Dept_ID,@Test_ID,@Pat_ID,@Ref_DocID,@Ref_MicroID,@StoolTest_Date,@Color,@Consistency,@Mucus,@Blood,@Macrophages,@EColi,@Trophozoite,@Occult_Blood,@Ph)"

                cmd.Parameters.AddWithValue("@Stool_ID", Val(txtstooltest.Text))

                cmd.Parameters.AddWithValue("@Dept_ID", Val(txtDeptID.Text))
                cmd.Parameters.AddWithValue("@Test_ID", Val(txtTestID.Text))

                cmd.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
                cmd.Parameters.AddWithValue("@Ref_DocID", Val(txtdocID.Text))
                cmd.Parameters.AddWithValue("@Ref_MicroID", Val(cmbrefMicroID.Text))
                cmd.Parameters.AddWithValue("@StoolTest_Date", dtpDiagDt.Value.Date)
                cmd.Parameters.AddWithValue("@Color", txtcolor.Text)
                cmd.Parameters.AddWithValue("@Consistency", txtconsist.Text)
                cmd.Parameters.AddWithValue("@Mucus", txtmucus.Text)
                cmd.Parameters.AddWithValue("@Blood", txtblood.Text)
                cmd.Parameters.AddWithValue("@Macrophages", txtmacro.Text)
                cmd.Parameters.AddWithValue("@EColi", txtecoli.Text)
                cmd.Parameters.AddWithValue("@Trophozoite", txttropho.Text)
                cmd.Parameters.AddWithValue("@Occult_Blood", txtoccultbld.Text)
                cmd.Parameters.AddWithValue("@Ph", txtph.Text)

                cmd.Connection = makeConnection()

                Dim res As Integer = cmd.ExecuteNonQuery()
                If res > 0 Then
                    MessageBox.Show("Patient Tests Records Registered Successfully", "Registration Status")

                    'To update the Diagnosis_Tests table for test done
                    Try
                        cmd1.CommandText = "UPDATE Diagnosis_Tests SET Pat_ID=@Pat_ID,ST_Test_Status=@ST_Test_Status WHERE Pat_ID=@Pat_ID"
                        cmd1.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
                        cmd1.Parameters.AddWithValue("@ST_Test_Status", "Done")

                        cmd1.Connection = makeConnection()

                        Dim res1 As Integer = cmd1.ExecuteNonQuery()
                        If res1 > 0 Then
                            MessageBox.Show("Tests Done", "Test Status")
                            cmbPatID.Items.RemoveAt(index)
                            cmbfname.Items.RemoveAt(index)
                            Call clearPatDetails()
                            Call clearAll()
                            Call incrStoolTest()
                        Else
                            MessageBox.Show("Failed", "Test Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Not Connected! " + ex.Message)
                    End Try

                    Call clearPatDetails()
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

    Private Sub incrStoolTest()
        Dim x As Integer
        Dim max2 As Integer
        sqlstr2 = "SELECT Stool_ID FROM Stool_Tests"
        Dim dt2 As DataTable = getDataTable(sqlstr2)
        max2 = dt2.Rows.Count
        If max2 = 0 Then
            x = 1
        Else
            x = max2 + 1
        End If
        txtstooltest.Text = x
        txtstooltest.Enabled = False
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
            errmsg = errmsg & "Ref. Microbiologist name cannot be blank!"
            chkData = True
        ElseIf txtcolor.Text = "" Then
            errmsg = errmsg & "Color cannot be left blank!"
            chkData = True
        ElseIf txtconsist.Text = "" Then
            errmsg = errmsg & "Consistency cannot be left blank!"
            chkData = True
        ElseIf txtmucus.Text = "" Then
            errmsg = errmsg & "Mucus cannot be left blank!"
            chkData = True
        ElseIf txtblood.Text = "" Then
            errmsg = errmsg & "Blood cannot be left blank!"
            chkData = True
        ElseIf txtmacro.Text = "" Then
            errmsg = errmsg & "Macrophages cannot be left blank!"
            chkData = True
        ElseIf txtecoli.Text = "" Then
            errmsg = errmsg & "E. Coli cannot be left blank!"
            chkData = True
        ElseIf txttropho.Text = "" Then
            errmsg = errmsg & "Trophozoite cannot be left blank!"
            chkData = True
        ElseIf txtoccultbld.Text = "" Then
            errmsg = errmsg & "Occult Blood cannot be left blank!"
            chkData = True
        ElseIf txtph.Text = "" Then
            errmsg = errmsg & "Ph value cannot be left blank!"
            chkData = True
        Else
            chkData = False
        End If
    End Function

    Private Sub clearAll()
        txtcolor.Clear()
        txtmucus.Clear()
        txtblood.Clear()
        txtconsist.Clear()
        txtmacro.Clear()
        txtecoli.Clear()
        txttropho.Clear()
        txtoccultbld.Clear()
        txtph.Clear()
    End Sub

    Private Sub clearPatDetails()
        Call clearAll()
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