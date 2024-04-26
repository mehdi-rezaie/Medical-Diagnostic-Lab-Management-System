Public Class frmUpdateDoctor
    Dim index As Integer
    Dim errmsg As String

    Private Sub frmUpdateDoctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initialisationLoad()
    End Sub

    Private Sub cmbDocID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDocID.SelectedIndexChanged
        cmbfname.SelectedIndex = cmbDocID.SelectedIndex
        index = cmbDocID.SelectedIndex
        Call enableAll()
        Call loadDoctorDetails()
    End Sub

    Private Sub cmbfname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfname.SelectedIndexChanged
        cmbDocID.SelectedIndex = cmbfname.SelectedIndex
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
        cmbDocID.DropDownHeight = cmbDocID.ItemHeight * 5
        cmbfname.DropDownHeight = cmbfname.ItemHeight * 5

        Dim y As Integer
        Dim max As Integer
        sqlstr = "SELECT Doc_ID,Doc_FName FROM Doctor_Info WHERE Doc_Status='In' OR Doc_Status='Out' ORDER BY Doc_ID ASC"
        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count

        For y = 0 To max - 1
            cmbDocID.Items.Add(dt.Rows(y).Item(0))
            cmbfname.Items.Add(dt.Rows(y).Item(1))
        Next

        Try
            Dim dt1 As DataTable = getDataTable(sqlstr)
            Dim r As DataRow

            cmbfname.AutoCompleteCustomSource.Clear()

            For Each r In dt1.Rows
                cmbfname.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub loadDoctorDetails()
        sqlstr = "SELECT * FROM Doctor_Info WHERE Doc_Status='In' OR Doc_Status='Out' ORDER BY Doc_ID ASC"
        Dim dt As DataTable = getDataTable(sqlstr)

        If dt.Rows.Count > 0 Then
            txtlname.Text = dt.Rows(index).Item(2)
            txtDOB.Text = dt.Rows(index).Item(6)
            txtage.Text = dt.Rows(index).Item(7)
            txtspecial.Text = dt.Rows(index).Item(5)
            If dt.Rows(index).Item(4) = "Male" Then
                RBtnMale.Checked = True
            ElseIf dt.Rows(index).Item(4) = "Female" Then
                RBtnFemale.Checked = True
            End If
            txtaddr.Text = dt.Rows(index).Item(8)
            txtpincode.Text = dt.Rows(index).Item(11)
            txtsal.Text = dt.Rows(index).Item(12)
            txtcontact.Text = dt.Rows(index).Item(9)
            cmbStatus.Text = dt.Rows(index).Item(10)
            txtemail.Text = dt.Rows(index).Item(13)
            txtorg.Text = dt.Rows(index).Item(3)
            dtpJoinDate.Text = dt.Rows(index).Item(14)
        End If
    End Sub

    Private Sub clearAll()
        cmbfname.Text = ""
        txtlname.Clear()
        txtorg.Clear()
        txtDOB.Clear()
        RBtnMale.Checked = False
        RBtnFemale.Checked = False
        txtspecial.Clear()
        txtage.Clear()
        cmbStatus.Text = ""
        txtaddr.Clear()
        txtcontact.Clear()
        txtpincode.Clear()
        txtsal.Clear()
        txtemail.Clear()
        dtpJoinDate.Value = Date.Now.ToShortDateString
    End Sub

    Private Sub enableAll()
        txtlname.Enabled = True
        txtorg.Enabled = True
        txtspecial.Enabled = True
        txtaddr.Enabled = True
        cmbStatus.Enabled = True
        txtcontact.Enabled = True
        txtpincode.Enabled = True
        txtsal.Enabled = True
        txtemail.Enabled = True
        dtpJoinDate.Enabled = True
    End Sub

    Private Sub disableAll()
        txtlname.Enabled = False
        txtorg.Enabled = False
        txtDOB.Enabled = False
        RBtnMale.Enabled = False
        RBtnFemale.Enabled = False
        txtspecial.Enabled = False
        txtage.Enabled = False
        txtaddr.Enabled = False
        cmbStatus.Enabled = False
        txtcontact.Enabled = False
        txtpincode.Enabled = False
        txtsal.Enabled = False
        txtemail.Enabled = False
    End Sub

    Public Function chkData() As Boolean
        errmsg = ""
        If cmbfname.Text = "" Then
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
        ElseIf txtaddr.Text = "" Then
            errmsg = errmsg & "Address cannot be blank!"
            chkData = True
        ElseIf txtcontact.Text = "" Then
            errmsg = errmsg & "Contact cannot be blank!"
            chkData = True
        ElseIf cmbStatus.Text = "" Then
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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        End If

        If updateDialog() = True Then
            Try
                Dim cmd As New OleDb.OleDbCommand
                cmd.CommandText = "UPDATE Doctor_Info SET Doc_ID=@Doc_ID,Doc_FName=@Doc_FName,Doc_LName=@Doc_LName,Doc_Organisation=@Doc_Organisation,Doc_Gender=@Doc_Gender,Doc_Specialisation=@Doc_Specialisation,Doc_DOB=@Doc_DOB,Doc_Age=@Doc_Age,Doc_Address=@Doc_Address,Doc_Contact=@Doc_Contact,Doc_Status=@Doc_Status,Doc_Pincode=@Doc_Pincode,Doc_Salary=@Doc_Salary,Doc_Email=@Doc_Email,Doc_Join_Date=@Doc_Join_Date WHERE Doc_ID=@Doc_ID"

                cmd.Parameters.AddWithValue("@Doc_ID", Val(cmbDocID.Text))
                cmd.Parameters.AddWithValue("@Doc_FName", cmbfname.Text)
                cmd.Parameters.AddWithValue("@Doc_LName", txtlname.Text)
                cmd.Parameters.AddWithValue("@Doc_Organisation", txtorg.Text)
                If RBtnMale.Checked Then
                    cmd.Parameters.AddWithValue("@Doc_Gender", RBtnMale.Text)
                ElseIf RBtnFemale.Checked Then
                    cmd.Parameters.AddWithValue("@Doc_Gender", RBtnFemale.Text)
                End If
                cmd.Parameters.AddWithValue("@Doc_Specialisation", txtspecial.Text)
                cmd.Parameters.AddWithValue("@Doc_DOB", txtDOB.Text)
                cmd.Parameters.AddWithValue("@Doc_Age", Val(txtage.Text))
                cmd.Parameters.AddWithValue("@Doc_Address", txtaddr.Text)
                cmd.Parameters.AddWithValue("@Doc_Contact", Val(txtcontact.Text))
                cmd.Parameters.AddWithValue("@Doc_Status", cmbStatus.Text)
                cmd.Parameters.AddWithValue("@Doc_Pincode", Val(txtpincode.Text))
                cmd.Parameters.AddWithValue("@Doc_Salary", Val(txtsal.Text))
                cmd.Parameters.AddWithValue("@Doc_Email", txtemail.Text)
                cmd.Parameters.AddWithValue("@Doc_Join_Date", dtpJoinDate.Value.Date)

                cmd.Connection = makeConnection()

                Dim res As Integer = cmd.ExecuteNonQuery()
                If (res > 0) Then
                    MessageBox.Show("Doctor Updated successfully", "Update Status")
                Else
                    MessageBox.Show("Failed to update staff!", "Update Status")
                End If
            Catch ex As Exception
                MessageBox.Show("Not connected!! " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtpincode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsDigit(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub
End Class