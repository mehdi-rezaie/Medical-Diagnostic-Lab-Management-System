Public Class frmUpdateStool
    Dim index As Integer
    Dim errmsg As String

    Private Sub frmUpdateStool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click


        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        End If
        If updateDialog() = True Then
            Try
                Dim cmd As New OleDb.OleDbCommand
                cmd.CommandText = "UPDATE Stool_Tests SET Pat_ID=@Pat_ID,StoolTest_Date=@StoolTest_Date,Color=@Color,Consistency=@Consistency,Mucus=@Mucus,Blood=@Blood,Macrophages=@Macrophages,EColi=@EColi,Trophozoite=@Trophozoite,Occult_Blood=@Occult_Blood,Ph=@Ph WHERE Pat_ID=@Pat_ID"

                cmd.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
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
        txtage.Text = dt1.Rows(index).Item(17)
        txtgender.Text = dt1.Rows(index).Item(18)
        txtrefdoc.Text = dt1.Rows(index).Item(20)
        txtdocID.Text = dt1.Rows(index).Item(4)
        txtrefmicroID.Text = dt1.Rows(index).Item(5)
        txtrefmicro.Text = dt1.Rows(index).Item(19)
    End Sub

    Public Sub loadTestValues()

        Dim dt2 As DataTable = getDataTable(sqlstr)
        txtcolor.Text = dt2.Rows(index).Item(7)
        txtconsist.Text = dt2.Rows(index).Item(8)
        txtmucus.Text = dt2.Rows(index).Item(9)
        txtblood.Text = dt2.Rows(index).Item(10)
        txtmacro.Text = dt2.Rows(index).Item(11)
        txtecoli.Text = dt2.Rows(index).Item(12)
        txttropho.Text = dt2.Rows(index).Item(13)
        txtoccultbld.Text = dt2.Rows(index).Item(14)
        txtph.Text = dt2.Rows(index).Item(15)

        txtstooltest.Text = dt2.Rows(index).Item(0)
    End Sub

    Public Sub initialisationLoad()
        cmbPatID.DropDownHeight = cmbPatID.ItemHeight * 8
        cmbfname.DropDownHeight = cmbfname.ItemHeight * 8

        Dim y As Integer
        Dim max As Integer

        sqlstr = "SELECT B.*,C.Pat_FName,C.Pat_Age,C.Pat_Gender,D.Staff_FName,E.Doc_FName FROM Diagnosis_Tests AS A,Stool_Tests AS B,Patient_Info AS C, Staff_Info D,Doctor_Info E WHERE B.Pat_ID=A.Pat_ID AND A.Pat_ID=C.Pat_ID AND B.Ref_MicroID=D.Staff_ID AND B.Ref_DocID=E.Doc_ID AND C.Pat_Status='Reg' AND StoolTest='Yes' AND A.ST_Test_Status='Done' ORDER BY B.Stool_ID ASC"

        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count
        For y = 0 To max - 1
            txtDeptID.Text = dt.Rows(y).Item(1)
            txtTestID.Text = dt.Rows(y).Item(2)

            cmbPatID.Items.Add(dt.Rows(y).Item(3))
            cmbfname.Items.Add(dt.Rows(y).Item(16))
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

    Private Sub dtpDiagDt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDiagDt.ValueChanged
        If dtpDiagDt.Value.Date < Date.Now Then
            dtpDiagDt.Value = Date.Now
        End If
        If dtpDiagDt.Value.Date > Date.Now Then
            dtpDiagDt.Value = Date.Now
        End If
    End Sub
End Class