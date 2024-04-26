Public Class frmUpdateStaff
    Dim index As Integer
    Dim errmsg As String

    Private Sub frmUpdateStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initialisationLoad()
    End Sub

    Private Sub cmbStaffID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStaffID.SelectedIndexChanged
        index = cmbStaffID.SelectedIndex
        Call enableAll()
        Call loadPatientDetails()
    End Sub

    Private Sub cmbfname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfname.SelectedIndexChanged
        cmbStaffID.SelectedIndex = cmbfname.SelectedIndex
        index = cmbfname.SelectedIndex
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

    Private Sub initialisationLoad()
        Call disableAll()
        cmbStaffID.DropDownHeight = cmbStaffID.ItemHeight * 5
        cmbfname.DropDownHeight = cmbfname.ItemHeight * 5

        Dim y As Integer
        Dim max As Integer
        sqlstr = "SELECT * FROM Staff_Info WHERE Staff_Status='In' OR Staff_Status='Out'"
        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count

        For y = 0 To max - 1
            cmbStaffID.Items.Add(dt.Rows(y).Item(0))
            cmbfname.Items.Add(dt.Rows(y).Item(2))
        Next

        Try
            Dim dt1 As DataTable = getDataTable(sqlstr)
            Dim r As DataRow

            cmbfname.AutoCompleteCustomSource.Clear()

            For Each r In dt1.Rows
                cmbfname.AutoCompleteCustomSource.Add(r.Item(2).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub loadPatientDetails()
        sqlstr = "SELECT A.*, B.Dept_ID, B.Dept_Name FROM Staff_Info AS A LEFT JOIN Department AS B ON A.Depart_ID=B.Dept_ID WHERE A.Staff_Status='In' OR Staff_Status='Out'"

        Dim dt As DataTable = getDataTable(sqlstr)

        If dt.Rows.Count > 0 Then
            txtdeptname.Text = dt.Rows(index).Item(22)
            txtdeptid.Text = dt.Rows(index).Item(21)
            cmbfname.Text = dt.Rows(index).Item(2)
            txtlname.Text = dt.Rows(index).Item(3)
            txtDOB.Text = dt.Rows(index).Item(4)
            txtage.Text = dt.Rows(index).Item(5)
            If dt.Rows(index).Item(6) = "Male" Then
                RBtnMale.Checked = True
            ElseIf dt.Rows(index).Item(6) = "Female" Then
                RBtnFemale.Checked = True
            End If
            txtctry.Text = dt.Rows(index).Item(7)
            txtcity.Text = dt.Rows(index).Item(8)
            txtState.Text = dt.Rows(index).Item(9)
            txtadd1.Text = dt.Rows(index).Item(10)
            txtadd2.Text = dt.Rows(index).Item(11)
            txtpincode.Text = dt.Rows(index).Item(12)
            txtcontact.Text = dt.Rows(index).Item(13)
            cmbStatus.Text = dt.Rows(index).Item(14)
            txtsal.Text = dt.Rows(index).Item(16)
            txtaad.Text = dt.Rows(index).Item(17)
            txtemail.Text = dt.Rows(index).Item(18)
            cmbDesc.Text = dt.Rows(index).Item(19)
            txtorg.Text = dt.Rows(index).Item(20)
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
                cmd.CommandText = "UPDATE Staff_Info SET Staff_ID=@Staff_ID,Depart_ID=@Depart_ID,Staff_FName=@Staff_FName,Staff_LName=@Staff_LName,Staff_DOB=@Staff_DOB,Staff_Age=@Staff_Age,Staff_Gender=@Staff_Gender,Staff_Country=@Staff_Country,Staff_City=@Staff_City,Staff_State=@Staff_State,Staff_Address1=@Staff_Address1,Staff_Address2=@Staff_Address2,Staff_Pincode=@Staff_Pincode,Staff_Contact=@Staff_Contact,Staff_Status=@Staff_Status,Staff_Salary=@Staff_Salary,Staff_Aadhar=@Staff_Aadhar,Staff_Email=@Staff_Email,Staff_Desc=@Staff_Desc,Staff_Org=@Staff_Org WHERE Staff_ID=@Staff_ID"

                cmd.Parameters.AddWithValue("@Staff_ID", Val(cmbStaffID.Text))
                cmd.Parameters.AddWithValue("@Depart_ID", Val(txtdeptid.Text))
                cmd.Parameters.AddWithValue("@Staff_FName", cmbfname.Text)
                cmd.Parameters.AddWithValue("@Staff_LName", txtlname.Text)
                cmd.Parameters.AddWithValue("@Staff_DOB", txtDOB.Text)
                cmd.Parameters.AddWithValue("@Staff_Age", Val(txtage.Text))
                If RBtnMale.Checked Then
                    cmd.Parameters.AddWithValue("@Staff_Gender", RBtnMale.Text)
                ElseIf RBtnFemale.Checked Then
                    cmd.Parameters.AddWithValue("@Staff_Gender", RBtnFemale.Text)
                End If
                cmd.Parameters.AddWithValue("@Staff_Country", txtctry.Text)
                cmd.Parameters.AddWithValue("@Staff_City", txtcity.Text)
                cmd.Parameters.AddWithValue("@Staff_State", txtState.Text)
                cmd.Parameters.AddWithValue("@Staff_Address1", txtadd1.Text)
                cmd.Parameters.AddWithValue("@Staff_Address2", txtadd2.Text)
                cmd.Parameters.AddWithValue("@Staff_Pincode", Val(txtpincode.Text))
                cmd.Parameters.AddWithValue("@Staff_Contact", Val(txtcontact.Text))
                cmd.Parameters.AddWithValue("@Staff_Status", cmbStatus.Text)
                cmd.Parameters.AddWithValue("@Staff_Salary", Val(txtsal.Text))
                cmd.Parameters.AddWithValue("@Staff_Aadhar", txtaad.Text)
                cmd.Parameters.AddWithValue("@Staff_Email", txtemail.Text)
                cmd.Parameters.AddWithValue("@Staff_Desc", cmbDesc.Text)
                cmd.Parameters.AddWithValue("@Staff_Org", txtorg.Text)

                cmd.Connection = makeConnection()


                Dim res As Integer = cmd.ExecuteNonQuery()
                If (res > 0) Then
                    MessageBox.Show("Staff Updated successfully", "Update Status")
                Else
                    MessageBox.Show("Failed to update staff!", "Update Status")
                End If
            Catch ex As Exception
                MessageBox.Show("Not connected!! " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub clearAll()
        txtlname.Clear()
        txtctry.Clear()
        txtcity.Clear()
        txtState.Clear()
        txtadd1.Clear()
        txtadd2.Clear()
        txtpincode.Clear()
        txtcontact.Clear()
        cmbStatus.Text = ""
        txtsal.Clear()
        txtaad.Clear()
        txtemail.Clear()
        txtorg.Clear()
    End Sub

    Private Sub enableAll()
        txtlname.Enabled = True
        txtctry.Enabled = True
        txtcity.Enabled = True
        txtState.Enabled = True
        txtadd1.Enabled = True
        txtadd2.Enabled = True
        txtpincode.Enabled = True
        txtcontact.Enabled = True
        cmbStatus.Enabled = True
        txtsal.Enabled = True
        txtaad.Enabled = True
        txtemail.Enabled = True
        txtorg.Enabled = True
    End Sub

    Private Sub disableAll()
        txtdeptname.Enabled = False
        txtdeptid.Enabled = False
        txtlname.Enabled = False
        txtDOB.Enabled = False
        txtctry.Enabled = False
        txtcity.Enabled = False
        txtState.Enabled = False
        txtadd1.Enabled = False
        txtadd2.Enabled = False
        txtpincode.Enabled = False
        txtcontact.Enabled = False
        cmbStatus.Enabled = False
        txtsal.Enabled = False
        txtaad.Enabled = False
        txtemail.Enabled = False
        cmbDesc.Enabled = False
        txtorg.Enabled = False
    End Sub

    Public Function chkData() As Boolean
        errmsg = ""
        If cmbStaffID.Text = "" Then
            errmsg = errmsg & "Select a Staff!"
            chkData = True
        ElseIf cmbfname.Text = "" Then
            errmsg = errmsg & "First Name cannot be blank!"
            chkData = True
        ElseIf txtlname.Text = "" Then
            errmsg = errmsg & "Last Name cannot be blank!"
            chkData = True
        ElseIf txtage.Text = "" Then
            errmsg = errmsg & "Age cannot be blank!"
            chkData = True
        ElseIf RBtnMale.Checked = False And
            RBtnFemale.Checked = False Then
            errmsg = errmsg & "Choose a gender!"
            chkData = True
        ElseIf txtctry.Text = "" Then
            errmsg = errmsg & "Country cannot be blank!"
            chkData = True
        ElseIf txtcity.Text = "" Then
            errmsg = errmsg & "City cannot be blank!"
            chkData = True
        ElseIf txtState.Text = "" Then
            errmsg = errmsg & "State cannot be blank!"
            chkData = True
        ElseIf txtadd1.Text = "" Then
            errmsg = errmsg & "Address line 1 cannot be blank!"
            chkData = True
        ElseIf txtadd2.Text = "" Then
            errmsg = errmsg & "Address line 2 cannot be blank!"
            chkData = True
        ElseIf txtpincode.Text = "" Then
            errmsg = errmsg & "Pincode cannot be blank!"
            chkData = True
        ElseIf txtcontact.Text = "" Then
            errmsg = errmsg & "Contact cannot be blank!"
            chkData = True
        ElseIf cmbStatus.Text = "" Then
            errmsg = errmsg & "Status cannot be blank!"
            chkData = True
        ElseIf txtsal.Text = "" Then
            errmsg = errmsg & "Salary cannot be blank!"
            chkData = True
        ElseIf txtaad.Text = "" Then
            errmsg = errmsg & "Aadhar card no. cannot be blank!"
            chkData = True
        ElseIf txtemail.Text = "" Then
            errmsg = errmsg & "Email cannot be blank!"
            chkData = True
        ElseIf cmbDesc.Text = "" Then
            errmsg = errmsg & "Description cannot be blank!"
            chkData = True
        ElseIf txtorg.Text = "" Then
            errmsg = errmsg & "Organisation cannot be blank!"
            chkData = True
        Else
            chkData = False
        End If
    End Function


    Private Sub txtage_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtage.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpincode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpincode.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
            MessageBox.Show("Please enter numbers only!")
        End If
    End Sub

    Private Sub txtcontact_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontact.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
            MessageBox.Show("Please enter numbers only!")
        End If
    End Sub

    Private Sub txtlname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlname.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsLetter(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtctry_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtctry.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsLetter(keyChar)) And (AscW(keyChar) <> 8)) Then
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

    Private Sub txtsal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsal.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtState_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtState.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsLetter(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtaad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaad.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub
End Class