Public Class frmPatientAdd
    Dim d As Date
    Dim max As String
    Dim errmsg As String

    Private Sub frmPatientAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InitialisationLoad()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        ElseIf saveDialog() = True Then


            Dim cmd As New OleDb.OleDbCommand
            Try
                cmd.CommandText = "INSERT INTO Patient_Info(Pat_ID,Pat_FName,Pat_LName,Pat_DOB,Pat_Age,Pat_Gender,Pat_Contact,Pat_Address,Pat_City,Pat_Pincode,Pat_Email,Pat_BGrp,Pat_Allergies,Pat_Weight,Pat_Diabetic_Info,Pat_Status,Pat_Marital_Status)VALUES(@Pat_ID,@Pat_FName,@Pat_LName,@Pat_DOB,@Pat_Age,@Pat_Gender,@Pat_Contact,@Pat_Address,@Pat_City,@Pat_Pincode,@Pat_Email,@Pat_BGrp,@Pat_Allergies,@Pat_Weight,@Pat_Diabetic_Info,@Pat_Status,@Pat_Marital_Status)"

                cmd.Parameters.AddWithValue("@Pat_ID", Val(txtPatID.Text))
                cmd.Parameters.AddWithValue("@Pat_FName", txtfname.Text)
                cmd.Parameters.AddWithValue("@Pat_LName", txtlname.Text)
                cmd.Parameters.AddWithValue("@Pat_DOB", dtpBirthDt.Value.Date)
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
                cmd.Parameters.AddWithValue("@Pat_BGrp", cmbBGrp.Text)
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
                    MessageBox.Show("Patient Added Successfully", "Add status")
                    Call clearAll()
                    Call InitialisationLoad()
                Else
                    MessageBox.Show("Failed to add patient!!", "Add status", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Not Connected! " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If exitForm() = True Then
            con.Close()
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub clearAll()
        txtfname.Clear()
        txtlname.Clear()
        dtpBirthDt.Value = Now
        txtage.Clear()
        RBtnMale.Checked = False
        RBtnFemale.Checked = False
        txtadd.Clear()
        txtcontact.Clear()
        txtcity.Clear()
        txtage.Clear()
        txtpincode.Clear()
        cmbBGrp.SelectedIndex = -1
        txtweight.Clear()
        txtemail.Clear()
        txtallergies.Clear()
        chkDiabetic.Checked = False
        chkmarital.Checked = False
    End Sub

    Private Sub dtpBirthDt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpBirthDt.ValueChanged
        txtage.Text = Fix((DateDiff(DateInterval.Day, dtpBirthDt.Value, Now.Date)) / 365)
    End Sub

    Public Function chkData() As Boolean
        errmsg = ""
        If txtfname.Text = "" Then
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
            errmsg = errmsg & "Please select a gender!"
            chkData = True
        ElseIf txtadd.Text = "" Then
            errmsg = errmsg & "Address cannot be blank!"
            chkData = True
        ElseIf cmbBGrp.SelectedIndex = -1 Then
            errmsg = errmsg & "Select a Blood Group!"
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

    Private Sub InitialisationLoad()
        clearAll()
        Dim x As Integer
        sqlstr = "SELECT * FROM Patient_Info"
        Dim dt As DataTable = getDataTable(sqlstr)

        max = dt.Rows.Count
        If max = 0 Then
            x = 1
        Else
            x = max + 1
        End If
        txtPatID.Text = x
        txtPatID.Enabled = False

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call clearAll()
    End Sub

    Private Sub txtfname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfname.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsLetter(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtlname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlname.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsLetter(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtage_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtage.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
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
End Class