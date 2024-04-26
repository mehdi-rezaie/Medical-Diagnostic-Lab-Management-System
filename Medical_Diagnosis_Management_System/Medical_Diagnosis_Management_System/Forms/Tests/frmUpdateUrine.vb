Public Class frmUpdateUrine
    Dim index As Integer
    Dim errmsg As String
    Private Sub frmUpdateUrine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnUpdateUrine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateUrine.Click


        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        End If
        If updateDialog() = True Then
            Try
                Dim cmd As New OleDb.OleDbCommand
                cmd.CommandText = "UPDATE Urine_Tests SET Pat_ID=@Pat_ID,UrineTest_Date=@UrineTest_Date,Appearance=@Appearance,Reaction=@Reaction,Albumin=@Albumin,Sugar=@Sugar,Spermatozoa=@Spermatozoa,Amorphous_Sediments=@Amorphous_Sediments,Others=@Others,Bile_Pigment=@Bile_Pigment,Bile_Salt=@Bile_Salt,Occult_Blood=@Occult_Blood,Amino_Acid=@Amino_Acid,pH=@pH,Nitrate=@Nitrate WHERE Pat_ID=@Pat_ID"

                cmd.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
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
                    MessageBox.Show("Patient Test Values Updated Successfully", "Update Status")
                Else
                    MessageBox.Show("Failed to Update Patient test Values!!", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Not Connected! " + ex.Message)
            End Try
        End If
    End Sub

    Public Sub loadPatDocDetails()
        Dim dt1 As DataTable = getDataTable(sqlstr)
        txtage.Text = dt1.Rows(index).Item(21)
        txtgender.Text = dt1.Rows(index).Item(22)
        txtrefdoc.Text = dt1.Rows(index).Item(24)
        txtdocID.Text = dt1.Rows(index).Item(4)
        txtrefmicroID.Text = dt1.Rows(index).Item(5)
        txtrefmicro.Text = dt1.Rows(index).Item(23)
    End Sub

    Public Sub loadTestValues()
        Dim dt2 As DataTable = getDataTable(sqlstr)
        txtappear.Text = dt2.Rows(index).Item(7)
        txtreaction.Text = dt2.Rows(index).Item(8)
        txtalbumin.Text = dt2.Rows(index).Item(9)
        txtsugar.Text = dt2.Rows(index).Item(10)
        txtsperm.Text = dt2.Rows(index).Item(11)
        txtampsed.Text = dt2.Rows(index).Item(12)
        txtothers.Text = dt2.Rows(index).Item(13)
        txtbilepig.Text = dt2.Rows(index).Item(14)
        txtbilesalt.Text = dt2.Rows(index).Item(15)
        txtoccultbld.Text = dt2.Rows(index).Item(16)
        txtaminoacid.Text = dt2.Rows(index).Item(17)
        txtpH.Text = dt2.Rows(index).Item(18)
        txtnitrate.Text = dt2.Rows(index).Item(19)

        txturinetest.Text = dt2.Rows(index).Item(0)
    End Sub

    Public Sub initialisationLoad()
        cmbPatID.DropDownHeight = cmbPatID.ItemHeight * 8
        cmbfname.DropDownHeight = cmbfname.ItemHeight * 8

        Dim y As Integer
        Dim max As Integer

        sqlstr = "SELECT B.*,C.Pat_FName,C.Pat_Age,C.Pat_Gender,D.Staff_FName,E.Doc_FName FROM Diagnosis_Tests AS A,Urine_Tests AS B,Patient_Info AS C, Staff_Info D,Doctor_Info E WHERE B.Pat_ID=A.Pat_ID AND A.Pat_ID=C.Pat_ID AND B.Ref_MicroID=D.Staff_ID AND B.Ref_DocID=E.Doc_ID AND C.Pat_Status='Reg' AND UrineTest='Yes' AND A.U_Test_Status='Done' ORDER BY B.UrineTest_ID ASC"

        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count
        For y = 0 To max - 1
            txtDeptID.Text = dt.Rows(y).Item(1)
            txtTestID.Text = dt.Rows(y).Item(2)

            cmbPatID.Items.Add(dt.Rows(y).Item(3))
            cmbfname.Items.Add(dt.Rows(y).Item(20))
        Next
        txtDeptName.Text = "Microbiology"
    End Sub



    Public Function chkData() As Boolean
        errmsg = ""
        If cmbPatID.Text = "" Then
            errmsg = errmsg & "Patient ID cannot be blank!"
            chkData = True
        ElseIf cmbfname.Text = "" Then
            errmsg = errmsg & "Name of patient cannot be blank!"
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
            errmsg = errmsg & "Amorphous Sediments cannot be left blank!"
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
            errmsg = errmsg & "Amino Acid cannot be left blank!"
            chkData = True
        ElseIf txtpH.Text = "" Then
            errmsg = errmsg & "Ph value cannot be left blank!"
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
        txtreaction.Clear()
        txtalbumin.Clear()
        txtsugar.Clear()
        txtsperm.Clear()
        txtampsed.Clear()
        txtothers.Clear()
        txtbilepig.Clear()
        txtbilesalt.Clear()
        txtoccultbld.Clear()
        txtaminoacid.Clear()
        txtpH.Clear()
        txtnitrate.Clear()
    End Sub

    Private Sub dtpDiagDt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDiagDt.ValueChanged
        If dtpDiagDt.Value.Date < Date.Now Then
            dtpDiagDt.Value = Date.Now
        End If
        If dtpDiagDt.Value.Date > Date.Now Then
            dtpDiagDt.Value = Date.Now
        End If
    End Sub
End Class