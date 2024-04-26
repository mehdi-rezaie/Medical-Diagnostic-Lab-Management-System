Public Class frmFeeCharges
    Dim errmsg As String
    Dim errmsg2 As String
    Dim index As Integer
    Dim feebiochem As Double = 0, feeblood As Double = 0, feestool As Double = 0, feeurine As Double = 0
    Dim feexray As Double = 0, feesono As Double = 0, feeCTscan As Double = 0, feeEyeExm As Double = 0
    Dim feelab As Double = 0, feemisc As Double = 0
    Dim totfees As Double = 0

    Dim amt1 As Double

    Private Sub frmFeeCharges_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call incrRecieptNo()
        Call InitialisationLoad()
        Call disableAll()
    End Sub

    Private Sub cmbPatID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPatID.SelectedIndexChanged
        cmbfname.SelectedIndex = cmbPatID.SelectedIndex
        cmblname.SelectedIndex = cmbPatID.SelectedIndex
        index = cmbPatID.SelectedIndex
        Call disableAll()
        Call clearAll()
        Call loadDocDetails()
        Call enableTestsDone()
    End Sub

    Private Sub cmbfname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfname.SelectedIndexChanged
        cmbPatID.SelectedIndex = cmbfname.SelectedIndex
    End Sub

    Private Sub cmblname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblname.SelectedIndexChanged
        cmbPatID.SelectedIndex = cmblname.SelectedIndex
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If exitForm() = True Then
            con.Close()
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub dtpRecpDt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpRecpDt.ValueChanged
        If dtpRecpDt.Value.Date < Date.Now Then
            dtpRecpDt.Value = Date.Now
        End If
        If dtpRecpDt.Value.Date > Date.Now Then
            dtpRecpDt.Value = Date.Now
        End If
    End Sub

    Private Sub incrRecieptNo()
        Dim x As Integer
        Dim max As Integer
        sqlstr = "SELECT * FROM Patient_Receipt"
        Dim dt As DataTable = getDataTable(sqlstr)

        max = dt.Rows.Count
        If max = 0 Then
            x = 1
        Else
            x = max + 1
        End If
        txtrcpno.Text = x
        txtrcpno.Enabled = False
    End Sub

    Private Sub InitialisationLoad()
        cmbPatID.DropDownHeight = cmbPatID.ItemHeight * 8
        cmbfname.DropDownHeight = cmbfname.ItemHeight * 8
        cmblname.DropDownHeight = cmblname.ItemHeight * 8

        Dim max1 As Integer
        sqlstr1 = "SELECT A.Pat_ID,A.Pat_FName,A.Pat_LName,B.Diag_ID,B.Doc_ID,C.Doc_FName,B.BC_Test_Status,B.B_Test_Status,B.O_Test_Status,B.ST_Test_Status,B.S_Test_Status,B.U_Test_Status,B.X_Test_Status,B.CT_Test_Status FROM Patient_Info A, Diagnosis_Tests B,Doctor_Info C WHERE A.Pat_ID=B.Pat_ID AND B.Doc_ID=C.Doc_ID AND A.Pat_Status='Reg'"

        Dim dt1 As DataTable = getDataTable(sqlstr1)
        max1 = dt1.Rows.Count
        For y = 0 To max1 - 1
            cmbPatID.Items.Add(dt1.Rows(y).Item(0))
            cmbfname.Items.Add(dt1.Rows(y).Item(1))
            cmblname.Items.Add(dt1.Rows(y).Item(2))
        Next

        Try
            Dim dt2 As DataTable = getDataTable(sqlstr1)
            Dim r As DataRow

            cmbfname.AutoCompleteCustomSource.Clear()

            For Each r In dt2.Rows
                cmbfname.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub loadDocDetails()
        Dim dt2 As DataTable = getDataTable(sqlstr1)
        txtdiagID.Text = dt2.Rows(index).Item(3)
        txtrefdocID.Text = dt2.Rows(index).Item(4)
        txtrefdoc.Text = dt2.Rows(index).Item(5)
    End Sub

    Private Sub enableTestsDone()
        Dim dt3 As DataTable = getDataTable(sqlstr1)
        If dt3.Rows.Count > 0 Then
            If (dt3.Rows(index).Item(6)) = "Done" Then
                txtfeebiochem.Clear()
                txtfeebiochem.Enabled = True
                txtfeebiochem.Text = 800
                Call enableFees()
            ElseIf (dt3.Rows(index).Item(6)) = "Pending" Then
                txtfeebiochem.Clear()
                txtfeebiochem.Enabled = False
                MsgBox("Biochemistry Tests not completed!")
                txtfeebiochem.BackColor = Color.Red
                txtfeebiochem.Text = "Pending"
            End If

            If (dt3.Rows(index).Item(7)) = "Done" Then
                txtfeeblood.Clear()
                txtfeeblood.Enabled = True
                txtfeeblood.Text = 700
                Call enableFees()
            ElseIf (dt3.Rows(index).Item(7)) = "Pending" Then
                txtfeeblood.Clear()
                txtfeeblood.Enabled = False
                MsgBox("Blood Tests not completed!")
                txtfeeblood.BackColor = Color.Red
                txtfeeblood.Text = "Pending"
            End If

            If (dt3.Rows(index).Item(8)) = "Done" Then
                txtfeeEyeExm.Clear()
                txtfeeEyeExm.Enabled = True
                txtfeeEyeExm.Text = 500
                Call enableFees()
            ElseIf (dt3.Rows(index).Item(8)) = "Pending" Then
                txtfeeEyeExm.Clear()
                txtfeeEyeExm.Enabled = False
                MsgBox("Eye Examination Tests not completed!")
                txtfeeEyeExm.BackColor = Color.Red
                txtfeeEyeExm.Text = "Pending"
            End If

            If (dt3.Rows(index).Item(9)) = "Done" Then
                txtfeestool.Clear()
                txtfeestool.Enabled = True
                txtfeestool.Text = 600
                Call enableFees()
            ElseIf (dt3.Rows(index).Item(9)) = "Pending" Then
                txtfeestool.Clear()
                txtfeestool.Enabled = False
                MsgBox("Stool Tests not completed!")
                txtfeestool.BackColor = Color.Red
                txtfeestool.Text = "Pending"
            End If

            If (dt3.Rows(index).Item(10)) = "Done" Then
                txtfeesono.Clear()
                txtfeesono.Enabled = True
                txtfeesono.Text = 1000
                Call enableFees()
            ElseIf (dt3.Rows(index).Item(10)) = "Pending" Then
                txtfeesono.Clear()
                txtfeesono.Enabled = False
                MsgBox("Sonography Tests not completed!")
                txtfeesono.BackColor = Color.Red
                txtfeesono.Text = "Pending"
            End If

            If (dt3.Rows(index).Item(11)) = "Done" Then
                txtfeeurine.Clear()
                txtfeeurine.Enabled = True
                txtfeeurine.Text = 700
                Call enableFees()
            ElseIf (dt3.Rows(index).Item(11)) = "Pending" Then
                txtfeeurine.Clear()
                txtfeeurine.Enabled = False
                MsgBox("Urine Tests not completed!")
                txtfeeurine.BackColor = Color.Red
                txtfeeurine.Text = "Pending"
            End If

            If (dt3.Rows(index).Item(12)) = "Done" Then
                txtfeexray.Clear()
                txtfeexray.Enabled = True
                txtfeexray.Text = 900
                Call enableFees()
            ElseIf (dt3.Rows(index).Item(12)) = "Pending" Then
                txtfeexray.Clear()
                txtfeexray.Enabled = False
                MsgBox("XRay Tests not completed!")
                txtfeexray.BackColor = Color.Red
                txtfeexray.Text = "Pending"
            End If

            If (dt3.Rows(index).Item(13)) = "Done" Then
                txtfeeCTScan.Clear()
                txtfeeCTScan.Enabled = True
                txtfeeCTScan.Text = 1500
                Call enableFees()
            ElseIf (dt3.Rows(index).Item(13)) = "Pending" Then
                txtfeeCTScan.Clear()
                txtfeeCTScan.Enabled = False
                MsgBox("CT Scan Tests not completed!")
                txtfeeCTScan.BackColor = Color.Red
                txtfeeCTScan.Text = "Pending"
            End If
        End If
    End Sub

    Private Sub enableFees()
        txtfeelab.Enabled = True
        txtfeemisc.Enabled = True
        txtfeechargesNo.Enabled = True
    End Sub


    Private Sub feeCalculate()
        feebiochem = Val(txtfeebiochem.Text)
        feeblood = Val(txtfeeblood.Text)
        feestool = Val(txtfeestool.Text)
        feeurine = Val(txtfeeurine.Text)
        feexray = Val(txtfeexray.Text)
        feesono = Val(txtfeesono.Text)
        feeCTscan = Val(txtfeeCTScan.Text)
        feeEyeExm = Val(txtfeeEyeExm.Text)
        feelab = Val(txtfeelab.Text)
        feemisc = Val(txtfeemisc.Text)

        totfees = feebiochem + feeblood + feestool + feeurine + feexray + feesono + feeCTscan + feeEyeExm + feelab + feemisc
        txtfeechargesNo.Text = Val(totfees)
    End Sub

    Private Sub insertFeeValues()
        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        ElseIf saveDialog() = True Then

            Dim cmd As New OleDb.OleDbCommand
            Try
                cmd.CommandText = "INSERT INTO Patient_Receipt(Receipt_No,Pat_ID,Doc_ID,Receipt_Date,Lab_Fees,Misc_Tax,TotalFees_InNo)VALUES(@Receipt_No,@Pat_ID,@Doc_ID,@Receipt_Date,@Lab_Fees,@Misc_Tax,@TotalFees_InNo)"

                cmd.Parameters.AddWithValue("@Receipt_No", Val(txtrcpno.Text))
                cmd.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
                cmd.Parameters.AddWithValue("@Doc_ID", txtrefdocID.Text)
                cmd.Parameters.AddWithValue("@Receipt_Date", dtpRecpDt.Value.ToString)
                cmd.Parameters.AddWithValue("@Lab_Fees", feelab)
                cmd.Parameters.AddWithValue("@Misc_Tax", feemisc)
                cmd.Parameters.AddWithValue("@TotalFees_InNo", totfees)


                cmd.Connection = makeConnection()
                Dim res As Integer = cmd.ExecuteNonQuery()
                If res > 0 Then
                    MessageBox.Show("Receipt Saved Successfully", "Receipt Status")


                    'To update the Diagnosis_Tests table for test Paid
                    Dim cmd1 As New OleDb.OleDbCommand
                    Try
                        cmd1.CommandText = "UPDATE Patient_Info SET Pat_ID=@Pat_ID,Pat_Status=@Pat_Status WHERE Pat_ID=@Pat_ID"
                        cmd1.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
                        cmd1.Parameters.AddWithValue("@Pat_Status", "Out")

                        cmd1.Connection = makeConnection()

                        Dim res1 As Integer = cmd1.ExecuteNonQuery()
                        If res1 > 0 Then
                            MessageBox.Show("Patient Transaction Successfull!", "Transaction Status")
                            cmbPatID.Items.RemoveAt(index)
                            cmbfname.Items.RemoveAt(index)
                            cmbfname.AutoCompleteCustomSource.Clear()
                            cmblname.Items.RemoveAt(index)
                            Call clearPatDetails()
                            Call clearAll()
                            Call incrRecieptNo()
                        Else
                            MessageBox.Show("Transaction Failed", "Transaction Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Not Connected: " + ex.Message)
                    End Try

                Else
                    MessageBox.Show("Failed to Save Receipt!!", "Receipt Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                cmd.Dispose()
            Catch ex As Exception
                MessageBox.Show("Not Connected! " + ex.Message)
            End Try
        End If

    End Sub

    Private Sub disableAll()
        txtfeebiochem.Enabled = False
        txtfeeblood.Enabled = False
        txtfeestool.Enabled = False
        txtfeeurine.Enabled = False
        txtfeexray.Enabled = False
        txtfeesono.Enabled = False
        txtfeeCTScan.Enabled = False
        txtfeeEyeExm.Enabled = False
        txtfeelab.Enabled = False
        txtfeemisc.Enabled = False
        txtfeechargesNo.Enabled = False
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        If txtfeechargesNo.Enabled = False Then
            MsgBox("Failed to calculate Total Amount")
        Else
            Call feeCalculate()
        End If
    End Sub

    Private Sub clearAll()
        txtfeebiochem.Clear()
        txtfeebiochem.BackColor = Color.White
        txtfeeblood.Clear()
        txtfeeblood.BackColor = Color.White
        txtfeestool.Clear()
        txtfeestool.BackColor = Color.White
        txtfeeurine.Clear()
        txtfeeurine.BackColor = Color.White
        txtfeexray.Clear()
        txtfeexray.BackColor = Color.White
        txtfeesono.Clear()
        txtfeesono.BackColor = Color.White
        txtfeeCTScan.Clear()
        txtfeeCTScan.BackColor = Color.White
        txtfeeEyeExm.Clear()
        txtfeeEyeExm.BackColor = Color.White
        txtfeelab.Clear()
        txtfeelab.BackColor = Color.White
        txtfeemisc.Clear()
        txtfeemisc.BackColor = Color.White
        txtfeechargesNo.Clear()
        txtfeechargesNo.BackColor = Color.White
    End Sub

    Private Sub clearPatDetails()
        cmbPatID.SelectedIndex = -1
        cmbfname.SelectedIndex = -1
        cmblname.SelectedIndex = -1
        txtrefdoc.Clear()
        txtrefdocID.Clear()
        txtdiagID.Clear()
    End Sub

    Public Function chkData() As Boolean
        errmsg = ""
        If cmbfname.Text = "" Then
            errmsg = errmsg & "Patient ID cannot be blank!"
            chkData = True
        ElseIf txtfeebiochem.Enabled = True And
            txtfeebiochem.Text = "" Then
            errmsg = errmsg & "Biochem fees cannot be null!"
            chkData = True
        ElseIf txtfeeblood.Enabled = True And
                txtfeeblood.Text = "" Then
            errmsg = errmsg & "Blood fees cannot be null!"
            chkData = True
        ElseIf txtfeestool.Enabled = True And
                txtfeestool.Text = "" Then
            errmsg = errmsg & "Stool fees cannot be null!"
            chkData = True
        ElseIf txtfeeurine.Enabled = True And
                txtfeeurine.Text = "" Then
            errmsg = errmsg & "Urine fees cannot be null!"
            chkData = True
        ElseIf txtfeexray.Enabled = True And
                txtfeexray.Text = "" Then
            errmsg = errmsg & "Xray fees cannot be null!"
            chkData = True
        ElseIf txtfeesono.Enabled = True And
                txtfeesono.Text = "" Then
            errmsg = errmsg & "Sonography fees cannot be null!"
            chkData = True
        ElseIf txtfeeCTScan.Enabled = True And
                txtfeeCTScan.Text = "" Then
            errmsg = errmsg & "CT Scan fees cannot be null!"
            chkData = True
        ElseIf txtfeeEyeExm.Enabled = True And
                txtfeeEyeExm.Text = "" Then
            errmsg = errmsg & "Eye Exam fees cannot be null!"
            chkData = True
        ElseIf txtfeelab.Text = "" Then
            errmsg = errmsg & "Lab fees cannot be null!"
            chkData = True
        ElseIf txtfeemisc.Text = "" Then
            errmsg = errmsg & "Misc. fees cannot be null!"
            chkData = True
        ElseIf txtfeechargesNo.Text = "" Then
            errmsg = errmsg & "Calculate fees amount first!"
            chkData = True
        Else
            chkData = False
        End If
    End Function

    Private Function chkPending() As Boolean
        errmsg2 = ""
        If txtfeebiochem.Text = "Pending" Or
            txtfeeblood.Text = "Pending" Or
            txtfeeEyeExm.Text = "Pending" Or
            txtfeestool.Text = "Pending" Or
            txtfeesono.Text = "Pending" Or
            txtfeeurine.Text = "Pending" Or
            txtfeexray.Text = "Pending" Or
            txtfeeCTScan.Text = "Pending" Then
            errmsg2 = errmsg2 & "Complete all the tests!"
            chkPending = True
        Else
            chkPending = False
        End If
    End Function

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If chkPending() = True Then
            MsgBox("Warning:- " & errmsg2, vbCritical + vbOKOnly)
            Exit Sub
        Else
            Call insertFeeValues()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If chkPending() = True Then
            MsgBox("Warning:- " & errmsg2, vbCritical + vbOKOnly)
            Exit Sub
        Else
            Call clearAll()
        End If
    End Sub

    Private Sub txtfeebiochem_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfeebiochem.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtfeeblood_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfeeblood.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtfeestool_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfeestool.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtfeeurine_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfeeurine.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtfeexray_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfeexray.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtfeesono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfeesono.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtfeeCTScan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfeeCTScan.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtfeeEyeExm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfeeEyeExm.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtfeelab_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfeelab.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtfeemisc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfeemisc.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtfeechargesNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfeechargesNo.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSummary.Click
        BillPrint.ShowDialog()
        BillPrint.TopMost = True
    End Sub
End Class