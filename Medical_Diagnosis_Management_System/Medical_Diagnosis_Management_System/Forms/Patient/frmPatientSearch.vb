Public Class frmPatientSearch

    Private Sub frmPatientSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sqlstr = "SELECT Pat_FName FROM Patient_Info"
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

    Private Sub btnFindPat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindPat.Click
        sqlstr = "SELECT A.*,B.Registration_Date FROM Patient_Info A,Diagnosis_Tests B WHERE A.Pat_ID=B.Pat_ID"
        Dim dt As DataTable = getDataTable(sqlstr)
        Dim fnd As Boolean

        For Each drw As DataRow In dt.Rows
            If (drw("Pat_FName").ToString).ToUpper = (txtsrchname.Text).ToUpper Then
                fnd = True
                txtPatID.Text = drw("Pat_ID")
                txtregdate.Text = drw("Registration_Date")
                txtfname.Text = drw("Pat_FName")
                txtlname.Text = drw("Pat_LName")
                txtcontact.Text = drw("Pat_Contact")
                txtadd.Text = drw("Pat_Address")
                txtcity.Text = drw("Pat_City")
                txtpincode.Text = drw("Pat_Pincode")
                txtemail.Text = drw("Pat_Email")
                txtage.Text = drw("Pat_Age")
                txtgender.Text = drw("Pat_Gender")
                txtbrthdt.Text = drw("Pat_DOB")
                txtweight.Text = drw("Pat_Weight")
                txtBGrp.Text = drw("Pat_BGrp")
                txtallergies.Text = drw("Pat_Allergies")
                txtdiabeticinfo.Text = drw("Pat_Diabetic_Info")
                txtStatus.Text = drw("Pat_Status")
                txtmaritalstat.Text = drw("Pat_Marital_Status")
            End If
        Next
        If fnd = False Then
            MessageBox.Show("Failed to find Registered Patient!", "Search Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtsrchname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsrchname.KeyPress
        Dim keyChar As Char
        keyChar = e.KeyChar
        If ((Not Char.IsLetter(keyChar)) And (AscW(keyChar) <> 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtsrchname_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsrchname.MouseHover
        ToolTip1.SetToolTip(Me.txtsrchname, "Enter First Name Only!")
    End Sub

    Private Sub txtStatus_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatus.MouseHover
        ToolTip2.SetToolTip(Me.txtStatus, "Patient status if In, Out or Registered for tests")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If exitForm() = True Then
            Me.Dispose()
            con.Close()
        End If
    End Sub
End Class