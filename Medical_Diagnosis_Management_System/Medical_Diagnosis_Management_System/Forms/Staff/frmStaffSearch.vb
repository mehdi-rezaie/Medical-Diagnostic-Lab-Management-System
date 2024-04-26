Public Class frmStaffSearch

    Private Sub frmStaffSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sqlstr = "SELECT Staff_FName FROM Staff_Info"
            Dim dt1 As DataTable = getDataTable(sqlstr)
            Dim r As DataRow

            txtsrchname.AutoCompleteCustomSource.Clear()

            For Each r In dt1.Rows
                txtsrchname.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnFindStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindStaff.Click
        sqlstr = "SELECT A.*,B.* FROM Staff_Info A,Department B WHERE A.Depart_ID=B.Dept_ID"
        Dim dt As DataTable = getDataTable(sqlstr)
        Dim fnd As Boolean

        For Each drw As DataRow In dt.Rows
            If (drw("Staff_FName").ToString).ToUpper = (txtsrchname.Text).ToUpper Then
                fnd = True
                txtStaffID.Text = drw("Staff_ID")
                txtfname.Text = drw("Staff_FName")
                txtlname.Text = drw("Staff_LName")
                txtbrthdt.Text = drw("Staff_DOB")
                txtage.Text = drw("Staff_Age")
                txtgender.Text = drw("Staff_Gender")
                txtctry.Text = drw("Staff_Country")
                txtcity.Text = drw("Staff_City")
                txtState.Text = drw("Staff_State")
                txtadd1.Text = drw("Staff_Address1")
                txtadd2.Text = drw("Staff_Address2")
                txtpincode.Text = drw("Staff_Pincode")
                txtcontact.Text = drw("Staff_Contact")
                txtStatus.Text = drw("Staff_Status")
                txthiredate.Text = drw("Staff_Hiredate")
                txtsal.Text = drw("Staff_Salary")
                txtaad.Text = drw("Staff_Aadhar")
                txtemail.Text = drw("Staff_Email")
                txtdesc.Text = drw("Staff_Desc")
                txtorg.Text = drw("Staff_Org")
                txtdeptname.Text = drw("Dept_Name")
                txtdeptID.Text = drw("Dept_ID")
                txtdeptini.Text = drw("Dept_Initials")
            End If
        Next
        If fnd = False Then
            MessageBox.Show("Failed to find Staff!", "Search Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtsrchname_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsrchname.MouseHover
        ToolTip1.SetToolTip(Me.txtsrchname, "Enter First Name Only!")
    End Sub

    Private Sub txtStatus_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatus.MouseHover
        ToolTip2.SetToolTip(Me.txtStatus, "Staff status if In or Out of the Diagnosis Center")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If exitForm() = True Then
            con.Close()
            Me.Dispose()
            Me.Close()
        End If
    End Sub
End Class