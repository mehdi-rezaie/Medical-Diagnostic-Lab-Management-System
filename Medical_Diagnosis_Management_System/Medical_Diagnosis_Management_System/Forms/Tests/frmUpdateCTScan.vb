Public Class frmUpdateCTScan
    Dim index As Integer
    Dim errmsg As String

    Private Sub frmUpdateCTScan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        txtage.Text = dt1.Rows(index).Item(16)
        txtgender.Text = dt1.Rows(index).Item(17)
        txtrefdoc.Text = dt1.Rows(index).Item(19)
        txtdocID.Text = dt1.Rows(index).Item(4)
        txtrefRadioID.Text = dt1.Rows(index).Item(5)
        txtrefRadio.Text = dt1.Rows(index).Item(18)
    End Sub

    Public Sub loadTestValues()
        Dim dt2 As DataTable = getDataTable(sqlstr)
        txtexamname.Text = dt2.Rows(index).Item(7)
        txtremark1.Text = dt2.Rows(index).Item(8)
        txtremark2.Text = dt2.Rows(index).Item(9)
        txtremark3.Text = dt2.Rows(index).Item(10)
        txtremark4.Text = dt2.Rows(index).Item(11)
        txtremark5.Text = dt2.Rows(index).Item(12)
        txtremark6.Text = dt2.Rows(index).Item(13)
        txtopinion.Text = dt2.Rows(index).Item(14)

        txtctscantest.Text = dt2.Rows(index).Item(0)
    End Sub

    Public Sub initialisationLoad()
        cmbPatID.DropDownHeight = cmbPatID.ItemHeight * 8
        cmbfname.DropDownHeight = cmbfname.ItemHeight * 8

        Dim y As Integer
        Dim max As Integer

        sqlstr = "SELECT B.*,C.Pat_FName,C.Pat_Age,C.Pat_Gender,D.Staff_FName,E.Doc_FName FROM Diagnosis_Tests AS A,CTScan_Tests AS B,Patient_Info AS C, Staff_Info D,Doctor_Info E WHERE B.Pat_ID=A.Pat_ID AND A.Pat_ID=C.Pat_ID AND B.Ref_RadioID=D.Staff_ID AND B.Ref_DocID=E.Doc_ID AND C.Pat_Status='Reg' AND CTScanTest='Yes' AND A.CT_Test_Status='Done' ORDER BY B.CTScanTest_ID ASC"

        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count
        For y = 0 To max - 1
            txtDeptID.Text = dt.Rows(y).Item(1)
            txtTestID.Text = dt.Rows(y).Item(2)

            cmbPatID.Items.Add(dt.Rows(y).Item(3))
            cmbfname.Items.Add(dt.Rows(y).Item(15))
        Next

        txtDeptName.Text = "Imaging"
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim cmd As New OleDb.OleDbCommand
        Dim cmd1 As New OleDb.OleDbCommand

        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        End If
        If updateDialog() = True Then
            Try
                cmd.CommandText = "UPDATE CTScan_Tests SET Pat_ID=@Pat_ID,CTScanTest_Date=@CTScanTest_Date,CTScanTest_Name=@CTScanTest_Name,Remark_1=@Remark_1,Remark_2=@Remark_2,Remark_3=@Remark_3,Remark_4=@Remark_4,Remark_5=@Remark_5,Remark_6=@Remark_6,Opinion=@Opinion WHERE Pat_ID=@Pat_ID"
                cmd.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
                cmd.Parameters.AddWithValue("@CTScanTest_Date", dtpDiagDt.Value.Date)
                cmd.Parameters.AddWithValue("@CTScanTest_Name", txtexamname.Text)
                cmd.Parameters.AddWithValue("@Remark_1", txtremark1.Text)
                cmd.Parameters.AddWithValue("@Remark_2", txtremark2.Text)
                cmd.Parameters.AddWithValue("@Remark_3", txtremark3.Text)
                cmd.Parameters.AddWithValue("@Remark_4", txtremark4.Text)
                cmd.Parameters.AddWithValue("@Remark_5", txtremark5.Text)
                cmd.Parameters.AddWithValue("@Remark_6", txtremark6.Text)
                cmd.Parameters.AddWithValue("@Opinion", txtopinion.Text)

                cmd.Connection = makeConnection()
                Dim res As Integer = cmd.ExecuteNonQuery()

                If res > 0 Then
                    MessageBox.Show("Patient Test Values Updated Successfully", "Update Status")
                Else
                    MessageBox.Show("Failed to Update Patient test Values!!", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Not Connected: " + ex.Message)
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
        ElseIf txtexamname.Text = "" Then
            errmsg = errmsg & "Examination Name cannot be blank!"
            chkData = True
        ElseIf txtremark1.Text = "" And
        txtremark2.Text = "" And
        txtremark3.Text = "" And
        txtremark4.Text = "" And
        txtremark5.Text = "" And
        txtremark6.Text = "" Then
            errmsg = errmsg & "Enter atleast 1 remark!"
            chkData = True
        ElseIf txtopinion.Text = "" Then
            errmsg = errmsg & "Opinion cannot be blank!"
            chkData = True
        Else
            chkData = False
        End If
    End Function

    Private Sub clearAll()
        txtexamname.Clear()
        txtremark1.Clear()
        txtremark2.Clear()
        txtremark3.Clear()
        txtremark4.Clear()
        txtremark5.Clear()
        txtremark6.Clear()
        txtopinion.Clear()
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