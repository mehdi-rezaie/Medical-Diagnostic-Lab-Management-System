Public Class frmStaffView
    Dim max As String

    Private Sub viewbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewbtn.Click
        sqlstr = "SELECT Staff_FName,Staff_LName,Staff_Hiredate,Staff_Address1,Staff_Salary,Staff_Status FROM Staff_Info"
        Try
            Dim dt1 As DataTable = getDataTable(sqlstr)
            DataGridView1.DataSource = dt1
            With DataGridView1
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "First Name"
                .Columns(1).HeaderCell.Value = "Last Name"
                .Columns(2).HeaderCell.Value = "Hire Date"
                .Columns(3).HeaderCell.Value = "Address"
                .Columns(4).HeaderCell.Value = "Salary"
                .Columns(5).HeaderCell.Value = "Status"
            End With
            DataGridView1.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show("Not Connected! " + ex.Message)
        End Try
        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If exitForm() = True Then
            con.Close()
            Me.Dispose()
            Me.Close()
        End If
    End Sub
End Class