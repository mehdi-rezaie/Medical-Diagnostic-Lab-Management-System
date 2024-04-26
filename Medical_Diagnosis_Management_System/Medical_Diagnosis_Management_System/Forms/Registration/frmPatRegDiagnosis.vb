Imports System.Data.OleDb

Public Class frmPatRegDiagnosis
    Dim d As Date
    Dim max As String
    Dim errmsg As String
    Dim index As Integer

    Private Sub frmPatRegDiagnosis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ClearAll()
        Call initialisationLoad()
        Call incrDiagTest()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Call insertTestTypes()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ClearAll()
    End Sub

    Private Sub cmbPatID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPatID.SelectedIndexChanged

        index = cmbPatID.SelectedIndex
        cmbfname.SelectedIndex = cmbPatID.SelectedIndex
        cmblname.SelectedIndex = cmbPatID.SelectedIndex
    End Sub

    Private Sub cmbfname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfname.SelectedIndexChanged
        cmbPatID.SelectedIndex = cmbfname.SelectedIndex
    End Sub

    Private Sub cmblname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblname.SelectedIndexChanged
        cmbPatID.SelectedIndex = cmblname.SelectedIndex
    End Sub

    Private Sub cmbdocID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdocID.SelectedIndexChanged
        cmbdocfname.SelectedIndex = cmbdocID.SelectedIndex
    End Sub

    Private Sub cmbdocfname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdocfname.SelectedIndexChanged
        cmbdocID.SelectedIndex = cmbdocfname.SelectedIndex
    End Sub

    Private Sub dtpRegDt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpRegDt.ValueChanged
        Call regDateTimePicker()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If exitForm() = True Then
            con.Close()
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    'To update the Patient_Info table for test done
    Private Sub updatePatientRegInfo()
        Dim cmd1 As New OleDb.OleDbCommand
        Try
            cmd1.CommandText = "UPDATE Patient_Info SET Pat_ID=@Pat_ID,Pat_Status=@Pat_Status WHERE Pat_ID=@Pat_ID"
            cmd1.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
            cmd1.Parameters.AddWithValue("@Pat_Status", "Reg")

            cmd1.Connection = makeConnection()
            Dim res1 As Integer = cmd1.ExecuteNonQuery()
            If res1 > 0 Then
                MessageBox.Show("Tests Registered", "Notification")
                cmbPatID.Items.RemoveAt(index)
                cmbfname.Items.RemoveAt(index)
                cmbfname.AutoCompleteCustomSource.Clear()
                cmblname.Items.RemoveAt(index)
            Else
                MessageBox.Show("Failed", "Error Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Not Connected! " + ex.Message)
        End Try
        cmd1.Dispose()
    End Sub


    Private Sub insertTestTypes()
        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        ElseIf saveDialog() = True Then

            Dim cmd As New OleDb.OleDbCommand
            Try
                cmd.CommandText = "INSERT INTO Diagnosis_Tests(Diag_ID,Pat_ID,Doc_ID,Registration_Date,BiochemTest,BC_Test_Status,BloodTest,B_Test_Status,OpthalTest,O_Test_Status,StoolTest,ST_Test_Status,SonoTest,S_Test_Status,UrineTest,U_Test_Status,XrayTest,X_Test_Status,CTScanTest,CT_Test_Status,Remark)VALUES(@Diag_ID,@Pat_ID,@Doc_ID,@Registration_Date,@BiochemTest,@BC_Test_Status,@BloodTest,@B_Test_Status,@OpthalTest,@O_Test_Status,@StoolTest,@ST_Test_Status,@SonoTest,@S_Test_Status,@UrineTest,@U_Test_Status,@XrayTest,@X_Test_Status,@CTScanTest,@CT_Test_Status,@Remark)"
                cmd.Parameters.AddWithValue("@Diag_ID", Val(txtdiagID.Text))
                cmd.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
                cmd.Parameters.AddWithValue("@Doc_ID", Val(cmbdocID.Text))
                cmd.Parameters.AddWithValue("@Registration_Date", dtpRegDt.Value.Date)

                If chkbiochem.Checked = True Then
                    cmd.Parameters.AddWithValue("@BiochemTest", "Yes")
                    cmd.Parameters.AddWithValue("@BC_Test_Status", "Pending")
                Else
                    cmd.Parameters.AddWithValue("@BiochemTest", "No")
                    cmd.Parameters.AddWithValue("@BC_Test_Status", "NA")
                End If
                If chkblood.Checked = True Then
                    cmd.Parameters.AddWithValue("@BloodTest", "Yes")
                    cmd.Parameters.AddWithValue("@B_Test_Status", "Pending")
                Else
                    cmd.Parameters.AddWithValue("@BloodTest", "No")
                    cmd.Parameters.AddWithValue("@B_Test_Status", "NA")
                End If
                If chkeyeexam.Checked = True Then
                    cmd.Parameters.AddWithValue("@OpthalTest", "Yes")
                    cmd.Parameters.AddWithValue("@O_Test_Status", "Pending")
                Else
                    cmd.Parameters.AddWithValue("@OpthalTest", "No")
                    cmd.Parameters.AddWithValue("@O_Test_Status", "NA")
                End If
                If chkstool.Checked = True Then
                    cmd.Parameters.AddWithValue("@StoolTest", "Yes")
                    cmd.Parameters.AddWithValue("@ST_Test_Status", "Pending")
                Else
                    cmd.Parameters.AddWithValue("@StoolTest", "No")
                    cmd.Parameters.AddWithValue("@ST_Test_Status", "NA")
                End If
                If chksono.Checked = True Then
                    cmd.Parameters.AddWithValue("@SonoTest", "Yes")
                    cmd.Parameters.AddWithValue("@S_Test_Status", "Pending")
                Else
                    cmd.Parameters.AddWithValue("@SonoTest", "No")
                    cmd.Parameters.AddWithValue("@S_Test_Status", "NA")
                End If
                If chkurine.Checked = True Then
                    cmd.Parameters.AddWithValue("@UrineTest", "Yes")
                    cmd.Parameters.AddWithValue("@U_Test_Status", "Pending")
                Else
                    cmd.Parameters.AddWithValue("@UrineTest", "No")
                    cmd.Parameters.AddWithValue("@U_Test_Status", "NA")
                End If
                If chkxray.Checked = True Then
                    cmd.Parameters.AddWithValue("@XrayTest", "Yes")
                    cmd.Parameters.AddWithValue("@X_Test_Status", "Pending")
                Else
                    cmd.Parameters.AddWithValue("@XrayTest", "No")
                    cmd.Parameters.AddWithValue("@X_Test_Status", "NA")
                End If
                If chkCTScn.Checked = True Then
                    cmd.Parameters.AddWithValue("@CTScanTest", "Yes")
                    cmd.Parameters.AddWithValue("@CT_Test_Status", "Pending")
                Else
                    cmd.Parameters.AddWithValue("@CTScanTest", "No")
                    cmd.Parameters.AddWithValue("@CT_Test_Status", "NA")
                End If
                cmd.Parameters.AddWithValue("@Remark", txtremark.Text)

                cmd.Connection = makeConnection()
                Dim res As Integer = cmd.ExecuteNonQuery()
                If res > 0 Then
                    MessageBox.Show("Patient Tests Registered Successfully", "Alert!")
                    Call updatePatientRegInfo()
                    Call ClearAll()
                    Call incrDiagTest()
                Else
                    MessageBox.Show("Failed to add patient tests!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Not Connected! " + ex.Message)
            End Try
            cmd.Dispose()
        End If
    End Sub

    Private Sub initialisationLoad()
        Dim y, y1 As Integer
        Dim max, max1 As Integer

        cmbPatID.DropDownHeight = cmbPatID.ItemHeight * 8
        cmbfname.DropDownHeight = cmbfname.ItemHeight * 8
        cmblname.DropDownHeight = cmbPatID.ItemHeight * 8

        sqlstr = "SELECT Pat_ID,Pat_FName,Pat_LName FROM Patient_Info WHERE Pat_Status='In' ORDER BY Pat_ID ASC"
        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count
        For y = 0 To max - 1
            cmbPatID.Items.Add(dt.Rows(y).Item(0))
            cmbfname.Items.Add(dt.Rows(y).Item(1))
            cmblname.Items.Add(dt.Rows(y).Item(2))
        Next

        sqlstr1 = "SELECT Doc_ID,Doc_FName FROM Doctor_Info WHERE Doc_Status='In' ORDER BY Doc_ID ASC"
        Dim dt1 As DataTable = getDataTable(sqlstr1)
        max1 = dt1.Rows.Count
        For y1 = 0 To max1 - 1
            cmbdocID.Items.Add(dt1.Rows(y1).Item(0))
            cmbdocfname.Items.Add(dt1.Rows(y1).Item(1))
        Next

        Try
            Dim dt2 As DataTable = getDataTable(sqlstr)
            Dim r As DataRow

            cmbfname.AutoCompleteCustomSource.Clear()

            For Each r In dt2.Rows
                cmbfname.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub incrDiagTest()
        Dim x As Integer
        Dim max2 As Integer
        sqlstr1 = "SELECT Diag_ID FROM Diagnosis_Tests"
        Dim dt2 As DataTable = getDataTable(sqlstr1)
        max2 = dt2.Rows.Count
        If max2 = 0 Then
            x = 1
        Else
            x = max2 + 1
        End If
        txtdiagID.Text = x
        txtdiagID.Enabled = False

        dtpRegDt.Value = Date.Now.ToShortDateString
        dtpRegDt.Enabled = False
    End Sub

    Private Sub ClearAll()
        cmbPatID.SelectedIndex = -1
        cmbfname.SelectedIndex = -1
        cmblname.SelectedIndex = -1
        chkbiochem.Checked = False
        chkblood.Checked = False
        chkeyeexam.Checked = False
        chksono.Checked = False
        chkstool.Checked = False
        chkurine.Checked = False
        chkxray.Checked = False
        chkCTScn.Checked = False
        cmbdocID.SelectedIndex = -1
        cmbPatID.Text = ""
        cmbfname.Text = ""
        cmblname.Text = ""
        cmbdocfname.SelectedIndex = -1
        txtremark.Text = ""
        dtpRegDt.Value = Date.Now.ToShortDateString
    End Sub

    Public Function chkData() As Boolean
        errmsg = ""
        If cmbPatID.Text = "" Then
            errmsg = errmsg & "Patient ID cannot be blank!"
            chkData = True
        ElseIf cmbfname.Text = "" Then
            errmsg = errmsg & "Name of patient cannot be blank!"
            chkData = True
        ElseIf cmbdocID.Text = "" Then
            errmsg = errmsg & "Doctor ID cannot be blank!"
            chkData = True
        ElseIf cmbdocfname.Text = "" Then
            errmsg = errmsg & "Name of doctor cannot be blank!"
            chkData = True
        ElseIf chkbiochem.Checked = False And
            chkblood.Checked = False And
            chkstool.Checked = False And
            chkurine.Checked = False And
            chksono.Checked = False And
            chkeyeexam.Checked = False And
            chkxray.Checked = False And
            chkCTScn.Checked = False Then
            errmsg = errmsg & "Enter atleast 1 test!"
            chkData = True
        Else
            chkData = False
        End If
    End Function


    Private Sub regDateTimePicker()
        If dtpRegDt.Value.Date < Date.Now Then
            dtpRegDt.Value = Date.Now
        End If

        If dtpRegDt.Value.Date > Date.Now Then
            dtpRegDt.Value = Date.Now
        End If
    End Sub
End Class