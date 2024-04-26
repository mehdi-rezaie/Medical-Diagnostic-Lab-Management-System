Public Class frmDeptView
    Private Sub dataGridDisplay(ByVal str As String)
        sqlstr = "SELECT A.Staff_FName,A.Staff_LName,A.Staff_City,A.Staff_Contact,A.Staff_Hiredate,A.Staff_Salary,A.Staff_Desc FROM Staff_Info A, Department B WHERE A.Depart_ID=B.Dept_ID AND B.Dept_Name='" & str & "'"
        Try
            Dim dt1 As DataTable = getDataTable(sqlstr)
            dgrdViewDept.DataSource = dt1
            With dgrdViewDept
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "First Name"
                .Columns(1).HeaderCell.Value = "Last Name"
                .Columns(2).HeaderCell.Value = "City"
                .Columns(3).HeaderCell.Value = "Contact No."
                .Columns(4).HeaderCell.Value = "Hire Date"
                .Columns(5).HeaderCell.Value = "Salary"
                .Columns(6).HeaderCell.Value = "Description"
            End With
            dgrdViewDept.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show("Not connected! " + ex.Message)
        End Try
    End Sub

    Private Sub frmDeptView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x, max As Integer
        sqlstr = "SELECT * FROM Department"
        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count
        For x = 0 To max - 1
            cmbDeptName.Items.Add(dt.Rows(x).Item(1))
        Next
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If exitForm() = True Then
            con.Close()
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub cmbDeptName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDeptName.SelectedIndexChanged
        Call dataGridDisplay(cmbDeptName.Text)
    End Sub
End Class