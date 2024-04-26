Imports System.Data.OleDb

Public Class frmStaffAdd
    Dim cmd As New OleDb.OleDbCommand
    Dim errmsg As String

    Private Sub frmStaffAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initialisationLoad()
        Call incrStaffID()
    End Sub

    Private Sub cmbDeptName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDeptName.SelectedIndexChanged
        cmbDeptID.SelectedIndex = cmbDeptName.SelectedIndex
    End Sub

    Private Sub cmbDeptID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDeptID.SelectedIndexChanged
        cmbDeptName.SelectedIndex = cmbDeptID.SelectedIndex
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

    Private Sub initialisationLoad()
        clearAll()
        Dim y As Integer
        Dim max1 As Integer

        sqlstr = "SELECT * FROM Department"
        Dim dt1 As DataTable = getDataTable(sqlstr)
        max1 = dt1.Rows.Count
        For y = 0 To max1 - 1
            cmbDeptID.Items.Add(dt1.Rows(y).Item(0))
            cmbDeptName.Items.Add(dt1.Rows(y).Item(1))
        Next
    End Sub

    Private Sub incrStaffID()
        Dim x As Integer
        Dim max As Integer

        sqlstr = "SELECT * FROM Staff_Info"
        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count
        If max = 0 Then
            x = 1
        Else
            x = max + 1
        End If
        txtStaffID.Text = x
        txtStaffID.Enabled = False
    End Sub

    Private Sub btnAddStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStaff.Click

        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        ElseIf saveDialog() = True Then
            cmd.CommandText = "INSERT INTO Staff_Info(Staff_ID,Depart_ID,Staff_FName,Staff_LName,Staff_DOB,Staff_Age,Staff_Gender,Staff_Country,Staff_City,Staff_State,Staff_Address1,Staff_Address2,Staff_Pincode,Staff_Contact,Staff_Status,Staff_Hiredate,Staff_Salary,Staff_Aadhar,Staff_Email,Staff_Desc,Staff_Org)VALUES(@Staff_ID,@Depart_ID,@Staff_FName,@Staff_LName,@Staff_DOB,@Staff_Age,@Staff_Gender,@Staff_Country,@Staff_City,@Staff_State,@Staff_Address1,@Staff_Address2,@Staff_Pincode,@Staff_Contact,@Staff_Status,@Staff_Hiredate,@Staff_Salary,@Staff_Aadhar,@Staff_Email,@Staff_Desc,@Staff_Org)"
            cmd.Parameters.AddWithValue("@Staff_ID", Val(txtStaffID.Text))
            cmd.Parameters.AddWithValue("@Depart_ID", Val(cmbDeptID.Text))
            cmd.Parameters.AddWithValue("@Staff_FName", txtfname.Text)
            cmd.Parameters.AddWithValue("@Staff_LName", txtlname.Text)
            cmd.Parameters.AddWithValue("@Staff_DOB", dtpBirthDt.Text)
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
            cmd.Parameters.AddWithValue("@Staff_Status", txtStatus.Text)
            cmd.Parameters.AddWithValue("@Staff_Hiredate", dtpHireDate)
            cmd.Parameters.AddWithValue("@Staff_Salary", Val(txtsal.Text))
            cmd.Parameters.AddWithValue("@Staff_Aadhar", Val(txtaad.Text))
            cmd.Parameters.AddWithValue("@Staff_Email", txtemail.Text)
            cmd.Parameters.AddWithValue("@Staff_Desc", cmbDesc.Text)
            cmd.Parameters.AddWithValue("@Staff_Org", txtorg.Text)

            cmd.Connection = makeConnection()

            Try
                Dim res As Integer = cmd.ExecuteNonQuery()
                If (res > 0) Then
                    MessageBox.Show("Staff added successfully", "Add status")
                    Call clearAll()
                    Call incrStaffID()
                Else
                    MessageBox.Show("Failed to add staff!", "Add status")
                End If
            Catch ex As Exception
                MessageBox.Show("Not connected!! " + ex.Message)
            End Try
        End If
        cmd.Dispose()

    End Sub

    Private Sub clearAll()
        txtfname.Clear()
        txtlname.Clear()
        cmbDeptName.SelectedIndex = -1
        cmbDeptID.SelectedIndex = -1
        RBtnMale.Checked = False
        RBtnFemale.Checked = False
        txtage.Clear()
        txtctry.Clear()
        txtcity.Clear()
        txtState.Clear()
        txtadd1.Clear()
        txtadd2.Clear()
        txtpincode.Clear()
        txtcontact.Clear()
        txtsal.Clear()
        txtaad.Clear()
        txtemail.Clear()
        cmbDesc.SelectedIndex = -1
        txtorg.Clear()
    End Sub

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

    Private Sub dtpHireDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHireDate.ValueChanged
        If dtpHireDate.Value.Date < Date.Now Then
            dtpHireDate.Value = Date.Now
        End If

        If dtpHireDate.Value.Date > Date.Now Then
            dtpHireDate.Value = Date.Now
        End If
    End Sub

    Private Sub dtpBirthDt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpBirthDt.ValueChanged
        If dtpBirthDt.Value.Date > Date.Now Then
            dtpBirthDt.Value = Date.Now
        End If
        txtage.Text = Fix((DateDiff(DateInterval.Day, dtpBirthDt.Value, Now.Date)) / 365)
    End Sub

    Private Sub txtsal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsal.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Public Function chkData() As Boolean
        errmsg = ""
        If cmbDeptName.Text = "" Then
            errmsg = errmsg & "Department Name cannot be blank!"
            chkData = True
        ElseIf txtfname.Text = "" Then
            errmsg = errmsg & "First Name cannot be blank!"
            chkData = True
        ElseIf txtlname.Text = "" Then
            errmsg = errmsg & "Last Name cannot be blank!"
            chkData = True
        ElseIf txtage.Text = "" Then
            errmsg = errmsg & "Age cannot be blank!"
            chkData = True
        ElseIf txtage.Text < 18 Then
            errmsg = errmsg & "Age cannot be less than 18!"
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
End Class