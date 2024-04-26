Public Class frmUpdateEyeExam
    Dim index As Integer
    Dim errmsg As String

    Private Sub frmUpdateEyeExam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        txtage.Text = dt1.Rows(index).Item(15)
        txtgender.Text = dt1.Rows(index).Item(16)
        txtrefdoc.Text = dt1.Rows(index).Item(18)
        txtdocID.Text = dt1.Rows(index).Item(4)
        txtrefOpthalID.Text = dt1.Rows(index).Item(5)
        txtrefOpthal.Text = dt1.Rows(index).Item(17)
    End Sub

    Public Sub loadTestValues()
        Dim dt2 As DataTable = getDataTable(sqlstr)
        txtexamname.Text = dt2.Rows(index).Item(7)
        If dt2.Rows(index).Item(8) = "Left" Then
            RbtnLeft.Checked = True
        ElseIf dt2.Rows(index).Item(8) = "Right" Then
            RbtnRight.Checked = True
        ElseIf dt2.Rows(index).Item(8) = "Both" Then
            RbtnBoth.Checked = True
        End If
        txtremark.Text = dt2.Rows(index).Item(9)
        txtmyopia.Text = dt2.Rows(index).Item(10)
        txthyperopia.Text = dt2.Rows(index).Item(11)
        txtradius.Text = dt2.Rows(index).Item(12)
        txtarea.Text = dt2.Rows(index).Item(13)

        txtopthaltest.Text = dt2.Rows(index).Item(0)
    End Sub

    Public Sub initialisationLoad()
        cmbPatID.DropDownHeight = cmbPatID.ItemHeight * 8
        cmbfname.DropDownHeight = cmbfname.ItemHeight * 8

        Dim y As Integer
        Dim max As Integer

        sqlstr = "SELECT B.*,C.Pat_FName,C.Pat_Age,C.Pat_Gender,D.Staff_FName,E.Doc_FName FROM Diagnosis_Tests AS A,EyeExam_Tests AS B,Patient_Info AS C, Staff_Info D,Doctor_Info E WHERE B.Pat_ID=A.Pat_ID AND A.Pat_ID=C.Pat_ID AND B.Ref_OpthalID=D.Staff_ID AND B.Ref_DocID=E.Doc_ID AND C.Pat_Status='Reg' AND OpthalTest='Yes' AND A.O_Test_Status='Done' ORDER BY B.Opthal_ID ASC"

        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count
        For y = 0 To max - 1
            txtDeptID.Text = dt.Rows(y).Item(1)
            txtTestID.Text = dt.Rows(y).Item(2)

            cmbPatID.Items.Add(dt.Rows(y).Item(3))
            cmbfname.Items.Add(dt.Rows(y).Item(14))
        Next

        txtDeptName.Text = "Opthalmology"
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        End If

        If updateDialog() = True Then
            Try
                Dim cmd As New OleDb.OleDbCommand
                cmd.CommandText = "UPDATE EyeExam_Tests SET Pat_ID=@Pat_ID,EyeTest_Date=@EyeTest_Date,EyeTest_Name=@EyeTest_Name,Eye=@Eye,Remark=@Remark,Myopia=@Myopia,Hyperopia=@Hyperopia,Radius=@Radius,Area=@Area WHERE Pat_ID=@Pat_ID"
                cmd.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
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
                    MessageBox.Show("Patient Test Values Updated Successfully", "Update Status")
                Else
                    MessageBox.Show("Failed to Update Patient test Values!!", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Not Connected: " + ex.Message)
            End Try
        End If
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

    Private Sub txtmyopia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub txtarea_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtradius.KeyPress, txtmyopia.KeyPress, txthyperopia.KeyPress, txtarea.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) And (Not Char.IsPunctuation(keyChar)) Then
            e.Handled = True
        End If
    End Sub
End Class