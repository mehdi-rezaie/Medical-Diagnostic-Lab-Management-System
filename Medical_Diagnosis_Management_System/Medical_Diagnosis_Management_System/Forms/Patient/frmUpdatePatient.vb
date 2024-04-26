Public Class frmUpdatePatient
    Dim index As Integer
    Dim errmsg As String

    Private Sub frmUpdatePatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initialisationLoad()
    End Sub

    Private Sub cmbPatID_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPatID.SelectedIndexChanged
        cmbPatFname.SelectedIndex = cmbPatID.SelectedIndex
        index = cmbPatID.SelectedIndex
        Call enableAll()
        Call loadPatientDetails()
    End Sub

    Private Sub cmbPatFname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPatFname.SelectedIndexChanged
        cmbPatID.SelectedIndex = cmbPatFname.SelectedIndex
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If exitForm() = True Then
            con.Close()
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call clearAll()
    End Sub

    Private Sub loadPatientDetails()
        Dim dt As DataTable = getDataTable(sqlstr)

        If dt.Rows.Count > 0 Then
            txtlname.Text = dt.Rows(index).Item(2)
            txtcontact.Text = dt.Rows(index).Item(3)
            txtadd.Text = dt.Rows(index).Item(4)
            txtcity.Text = dt.Rows(index).Item(5)
            txtpincode.Text = dt.Rows(index).Item(6)
            txtemail.Text = dt.Rows(index).Item(7)
            txtage.Text = dt.Rows(index).Item(8)
            If dt.Rows(index).Item(9) = "Male" Then
                RBtnMale.Checked = True
            ElseIf dt.Rows(index).Item(9) = "Female" Then
                RBtnFemale.Checked = True
            End If
            txtDOB.Text = dt.Rows(index).Item(10)
            txtweight.Text = dt.Rows(index).Item(11)
            txtBGrp.Text = dt.Rows(index).Item(12)
            txtallergies.Text = dt.Rows(index).Item(13)
            txtStatus.Text = dt.Rows(index).Item(15)
            If dt.Rows(index).Item(14) = "Yes" Then
                chkDiabetic.Checked = True
            ElseIf dt.Rows(index).Item(14) = "No" Then
                chkDiabetic.Checked = False
            End If
            If dt.Rows(index).Item(16) = "Married" Then
                chkmarital.Checked = True
            ElseIf dt.Rows(index).Item(16) = "Single" Then
                chkmarital.Checked = False
            End If
        End If
    End Sub

    Public Sub initialisationLoad()
        Call disableAll()
        cmbPatID.DropDownHeight = cmbPatID.ItemHeight * 8
        cmbPatFname.DropDownHeight = cmbPatFname.ItemHeight * 8

        Dim y As Integer
        Dim max As Integer

        sqlstr = "SELECT * FROM Patient_Info WHERE Pat_Status='Reg' OR Pat_Status='In'"
        Dim dt1 As DataTable = getDataTable(sqlstr)
        max = dt1.Rows.Count
        For y = 0 To max - 1
            cmbPatID.Items.Add(dt1.Rows(y).Item(0))
            cmbPatFname.Items.Add(dt1.Rows(y).Item(1))
        Next

        'To suggest name in combo box
        Try
            Dim dt2 As DataTable = getDataTable(sqlstr)
            Dim r As DataRow

            cmbPatFname.AutoCompleteCustomSource.Clear()

            For Each r In dt2.Rows
                cmbPatFname.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        End If

        If updateDialog() = True Then
            Try
                Dim cmd As New OleDb.OleDbCommand
                cmd.CommandText = "UPDATE Patient_Info SET Pat_ID=@Pat_ID,Pat_FName=@Pat_FName,Pat_LName=@Pat_LName,Pat_DOB=@Pat_DOB,Pat_Age=@Pat_Age,Pat_Gender=@Pat_Gender,Pat_Contact=@Pat_Contact,Pat_Address=@Pat_Address,Pat_City=@Pat_City,Pat_Pincode=@Pat_Pincode,Pat_Email=@Pat_Email,Pat_BGrp=@Pat_BGrp,Pat_Allergies=@Pat_Allergies,Pat_Weight=@Pat_Weight,Pat_Diabetic_Info=@Pat_Diabetic_Info,Pat_Status=@Pat_Status,Pat_Marital_Status=@Pat_Marital_Status WHERE Pat_ID=@Pat_ID"

                cmd.Parameters.AddWithValue("@Pat_ID", Val(cmbPatID.Text))
                cmd.Parameters.AddWithValue("@Pat_FName", cmbPatFname.Text)
                cmd.Parameters.AddWithValue("@Pat_LName", txtlname.Text)
                cmd.Parameters.AddWithValue("@Pat_DOB", txtDOB.Text)
                cmd.Parameters.AddWithValue("@Pat_Age", Val(txtage.Text))
                If RBtnMale.Checked Then
                    cmd.Parameters.AddWithValue("@Pat_Gender", RBtnMale.Text)
                Else
                    cmd.Parameters.AddWithValue("@Pat_Gender", RBtnFemale.Text)
                End If
                cmd.Parameters.AddWithValue("@Pat_Contact", Val(txtcontact.Text))
                cmd.Parameters.AddWithValue("@Pat_Address", txtadd.Text)
                cmd.Parameters.AddWithValue("@Pat_City", txtcity.Text)
                cmd.Parameters.AddWithValue("@Pat_Pincode", Val(txtpincode.Text))
                cmd.Parameters.AddWithValue("@Pat_Email", txtemail.Text)
                cmd.Parameters.AddWithValue("@Pat_BGrp", txtBGrp.Text)
                cmd.Parameters.AddWithValue("@Pat_Allergies", txtallergies.Text)
                cmd.Parameters.AddWithValue("@Pat_Weight", Val(txtweight.Text))
                If chkDiabetic.Checked Then
                    cmd.Parameters.AddWithValue("@Pat_Diabetic_Info", "Yes")
                Else
                    cmd.Parameters.AddWithValue("@Pat_Diabetic_Info", "No")
                End If

                cmd.Parameters.AddWithValue("@Pat_Status", txtStatus.Text)

                If chkmarital.Checked Then
                    cmd.Parameters.AddWithValue("@Pat_Marital_Status", "Married")
                Else
                    cmd.Parameters.AddWithValue("@Pat_Marital_Status", "Single")
                End If

                cmd.Connection = makeConnection()
                Dim res As Integer = cmd.ExecuteNonQuery()
                If res > 0 Then
                    MessageBox.Show("Patient Updated Successfully", "Update Status")
                Else
                    MessageBox.Show("Failed to Update patient!!", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                cmd.Dispose()
            Catch ex As Exception
                MessageBox.Show("Not Connected! " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub clearAll()
        txtlname.Clear()
        txtadd.Clear()
        txtcontact.Clear()
        txtcity.Clear()
        txtpincode.Clear()
        txtweight.Clear()
        txtemail.Clear()
        txtallergies.Clear()
        chkDiabetic.Checked = False
        chkmarital.Checked = False
    End Sub

    Private Sub enableAll()
        txtlname.Enabled = True
        txtadd.Enabled = True
        txtcontact.Enabled = True
        txtcity.Enabled = True
        txtpincode.Enabled = True
        txtweight.Enabled = True
        txtemail.Enabled = True
        txtallergies.Enabled = True
        chkDiabetic.Enabled = True
        chkmarital.Enabled = True
    End Sub

    Private Sub disableAll()
        txtlname.Enabled = False
        txtDOB.Enabled = False
        txtage.Enabled = False
        txtadd.Enabled = False
        txtcontact.Enabled = False
        txtcity.Enabled = False
        txtage.Enabled = False
        txtpincode.Enabled = False
        txtBGrp.Enabled = False
        txtweight.Enabled = False
        txtemail.Enabled = False
        txtallergies.Enabled = False
        txtStatus.Enabled = False
        chkDiabetic.Enabled = False
        chkmarital.Enabled = False
    End Sub

    Public Function chkData() As Boolean
        errmsg = ""
        If cmbPatID.SelectedIndex = -1 Then
            errmsg = errmsg & "Select a Patient!"
            chkData = True
        ElseIf cmbPatFname.SelectedIndex = -1 Then
            errmsg = errmsg & "Select a Patient!"
            chkData = True
        ElseIf txtlname.Text = "" Then
            errmsg = errmsg & "Last Name cannot be blank!"
            chkData = True
        ElseIf txtage.Text = "" Then
            errmsg = errmsg & "Age cannot be blank!"
            chkData = True
        ElseIf txtadd.Text = "" Then
            errmsg = errmsg & "Address cannot be blank!"
            chkData = True
        ElseIf txtBGrp.Text = "" Then
            errmsg = errmsg & "Blood Grp cannot be blank!"
            chkData = True
        ElseIf txtpincode.Text = "" Then
            errmsg = errmsg & "Pincode cannot be blank!"
            chkData = True
        ElseIf txtcontact.Text = "" Then
            errmsg = errmsg & "Contact cannot be blank!"
            chkData = True
        ElseIf txtcity.Text = "" Then
            errmsg = errmsg & "City cannot be blank!"
            chkData = True
        ElseIf txtStatus.Text = "" Then
            errmsg = errmsg & "Status cannot be blank!"
            chkData = True
        ElseIf txtemail.Text = "" Then
            errmsg = errmsg & "Email cannot be blank!"
            chkData = True
        ElseIf txtweight.Text = "" Then
            errmsg = errmsg & "Weight cannot be blank!"
            chkData = True
        ElseIf txtallergies.Text = "" Then
            errmsg = errmsg & "Allergies info cannot be blank!"
            chkData = True
        Else
            chkData = False
        End If
    End Function

    Private Sub txtweight_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtweight.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) And (Not Char.IsPunctuation(keyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpincode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpincode.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcity.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsLetter(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcontact_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontact.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub
End Class