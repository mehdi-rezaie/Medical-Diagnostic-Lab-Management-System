Public Class frmDoctorAdd
    Dim cmd As New OleDb.OleDbCommand
    Dim errmsg As String

    Private Sub frmDoctorAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initialisationLoad()
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
        Dim x As Integer
        Dim max As Integer
        sqlstr = "SELECT * FROM Doctor_Info"
        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count
        If max = 0 Then
            x = 1
        Else
            x = max + 1
        End If
        txtdocID.Text = x
        txtdocID.Enabled = False
    End Sub

    Private Sub btnAddDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDoc.Click
        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        End If
        If SaveDialog() = True Then
            cmd.CommandText = "INSERT INTO Doctor_Info(Doc_ID,Doc_FName,Doc_LName,Doc_Organisation,Doc_Gender,Doc_Specialisation,Doc_DOB,Doc_Age,Doc_Address,Doc_Contact,Doc_Status,Doc_Pincode,Doc_Salary,Doc_Email,Doc_Join_Date)VALUES(@Doc_ID,@Doc_FName,@Doc_LName,@Doc_Organisation,@Doc_Gender,@Doc_Specialisation,@Doc_DOB,@Doc_Age,@Doc_Address,@Doc_Contact,@Doc_Status,@Doc_Pincode,@Doc_Salary,@Doc_Email,@Doc_Join_Date)"

            cmd.Parameters.AddWithValue("@Doc_ID", Val(txtdocID.Text))

            Dim docFName As String = "Dr. " & txtfname.Text
            cmd.Parameters.AddWithValue("@Doc_FName", docFName)
            cmd.Parameters.AddWithValue("@Doc_LName", txtlname.Text)
            cmd.Parameters.AddWithValue("@Doc_Organisation", txtorg.Text)
            If RBtnMale.Checked Then
                cmd.Parameters.AddWithValue("@Doc_Gender", RBtnMale.Text)
            ElseIf RBtnFemale.Checked Then
                cmd.Parameters.AddWithValue("@Doc_Gender", RBtnFemale.Text)
            End If
            cmd.Parameters.AddWithValue("@Doc_Specialisation", txtspecial.Text)
            cmd.Parameters.AddWithValue("@Doc_DOB", dtpBirthDt.Text)
            cmd.Parameters.AddWithValue("@Doc_Age", Val(txtage.Text))
            cmd.Parameters.AddWithValue("@Doc_Address", txtaddr.Text)
            cmd.Parameters.AddWithValue("@Doc_Contact", Val(txtcontact.Text))
            cmd.Parameters.AddWithValue("@Doc_Status", txtStatus.Text)
            cmd.Parameters.AddWithValue("@Doc_Pincode", Val(txtpincode.Text))
            cmd.Parameters.AddWithValue("@Doc_Salary", Val(txtsal.Text))
            cmd.Parameters.AddWithValue("@Doc_Email", txtemail.Text)
            cmd.Parameters.AddWithValue("@Doc_Join_Date", dtpJoinDate.Text)

            cmd.Connection = makeConnection()
            Try
                Dim res As Integer = cmd.ExecuteNonQuery()
                If (res > 0) Then
                    MessageBox.Show("Doctor added successfully", "Add Status")
                    clearAll()
                Else
                    MessageBox.Show("Failed to add Doctor!", "Add Status")
                End If
            Catch ex As Exception
                MessageBox.Show("Not connected!! " + ex.Message)
            End Try
        End If
        cmd.Dispose()
        Call initialisationLoad()
        Call clearAll()
    End Sub

    Private Sub clearAll()
        txtfname.Clear()
        txtlname.Clear()
        txtorg.Clear()
        RBtnMale.Checked = False
        RBtnFemale.Checked = False
        txtspecial.Clear()
        dtpBirthDt.Value = Date.Now.ToShortDateString
        txtage.Clear()
        txtaddr.Clear()
        txtcontact.Clear()
        txtpincode.Clear()
        txtsal.Clear()
        txtemail.Clear()
        dtpJoinDate.Value = Date.Now.ToShortDateString
    End Sub

    Public Function chkData() As Boolean
        errmsg = ""
        If txtfname.Text = "" Then
            errmsg = errmsg & "First Name cannot be blank!"
            chkData = True
        ElseIf txtlname.Text = "" Then
            errmsg = errmsg & "Last Name cannot be blank!"
            chkData = True
        ElseIf RBtnMale.Checked = False And
            RBtnFemale.Checked = False Then
            errmsg = errmsg & "Choose a gender!"
            chkData = True
        ElseIf txtspecial.Text = "" Then
            errmsg = errmsg & "Specialisation cannot be blank!"
            chkData = True
        ElseIf txtage.Text = "" Then
            errmsg = errmsg & "Age cannot be blank!"
            chkData = True
        ElseIf txtage.Text < 18 Then
            errmsg = errmsg & "Age cannot be less than 18!"
            chkData = True
        ElseIf txtaddr.Text = "" Then
            errmsg = errmsg & "Address cannot be blank!"
            chkData = True
        ElseIf txtcontact.Text = "" Then
            errmsg = errmsg & "Contact cannot be blank!"
            chkData = True
        ElseIf txtStatus.Text = "" Then
            errmsg = errmsg & "Status cannot be blank!"
            chkData = True
        ElseIf txtpincode.Text = "" Then
            errmsg = errmsg & "Pincode cannot be blank!"
            chkData = True
        ElseIf txtsal.Text = "" Then
            errmsg = errmsg & "Salary cannot be blank!"
            chkData = True
        ElseIf txtemail.Text = "" Then
            errmsg = errmsg & "Email cannot be blank!"
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

    Private Sub txtcontact_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontact.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpJoinDate.ValueChanged
        If dtpJoinDate.Value.Date < Date.Now Then
            dtpJoinDate.Value = Date.Now
        End If

        If dtpJoinDate.Value.Date > Date.Now Then
            dtpJoinDate.Value = Date.Now
        End If
    End Sub
End Class