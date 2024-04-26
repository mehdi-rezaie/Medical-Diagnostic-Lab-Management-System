Public Class frmDepartmentAdd
    Dim errmsg As String

    Private Sub frmDepartmentAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call getDeptNames()
        btnAdd.Focus()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        cmbDeptName.DropDownStyle = ComboBoxStyle.Simple
        Call incrNewDepartment()
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Call insertNewDepartment()

    End Sub

    Private Sub cmbDeptID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDeptID.SelectedIndexChanged
        cmbDeptName.SelectedIndex = cmbDeptID.SelectedIndex
    End Sub


    Private Sub cmbDeptName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDeptName.SelectedIndexChanged
        cmbDeptID.SelectedIndex = cmbDeptName.SelectedIndex
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If exitForm() = True Then
            Me.Close()
            Me.Dispose()
            con.Close()
        End If
    End Sub

    'To get the different department names
    Private Sub getDeptNames()
        cmbDeptName.DropDownHeight = cmbDeptName.ItemHeight * 5
        Dim x, max As Integer
        sqlstr = "select * from Department"
        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count
        For x = 0 To max - 1
            cmbDeptID.Items.Add(dt.Rows(x).Item(0))
            cmbDeptName.Items.Add(dt.Rows(x).Item(1))
        Next
        btnCommit.Enabled = False
    End Sub

    'To insert new department
    Private Sub insertNewDepartment()
        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        End If

        Dim cmd As New OleDb.OleDbCommand

        cmd.CommandText = "INSERT INTO Department(Dept_ID,Dept_Name,Dept_Initials)VALUES(@Dept_ID,@Dept_Name,@Dept_Initials)"
        cmd.Parameters.AddWithValue("@Dept_ID", cmbDeptID.Text)
        cmd.Parameters.AddWithValue("@Dept_Name", cmbDeptName.Text)
        cmd.Parameters.AddWithValue("@Dept_Intials", txtInitials.Text)
        cmd.Connection = makeConnection()
        Try
            Dim res As Integer = cmd.ExecuteNonQuery()
            If (res > 0) Then
                MessageBox.Show("Department added successfully!", "Inserting Dept.")
                Call clear()
                btnAdd.Enabled = True
                cmbDeptName.DropDownStyle = ComboBoxStyle.DropDown
                btnCommit.Enabled = False
            Else
                MessageBox.Show("Failed to add Department!", "Error!")
            End If
        Catch ex As Exception
            MessageBox.Show("Not connected! ", ex.Message)
        End Try
    End Sub

    'To check data entry
    Public Function chkData() As Boolean
        errmsg = ""
        If cmbDeptName.Text = "" Then
            errmsg = errmsg & "Please Enter Department Name!"
            chkData = True
        ElseIf txtInitials.Text = "" Then
            errmsg = errmsg & "Initials cannot be blank!"
            chkData = True
        Else
            chkData = False
        End If
    End Function

    'To increment new department
    Private Sub incrNewDepartment()
        cmbDeptID.Text = ""
        cmbDeptName.Text = ""
        btnCommit.Enabled = True
        btnAdd.Enabled = False
        sqlstr = "select * from Department"
        Dim dt As DataTable = getDataTable(sqlstr)

        Dim max, x As Integer
        max = dt.Rows.Count
        If max = 0 Then
            x = 1
        Else
            x = max + 1
        End If
        cmbDeptID.Text = x
        cmbDeptID.Enabled = False
        cmbDeptName.Focus()
    End Sub

    Private Sub clear()
        cmbDeptName.SelectedIndex = -1
        txtInitials.Clear()
    End Sub
End Class