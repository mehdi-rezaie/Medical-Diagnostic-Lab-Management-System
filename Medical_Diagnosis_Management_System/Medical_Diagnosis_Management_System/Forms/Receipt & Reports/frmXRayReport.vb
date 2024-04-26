Public Class frmXRayReport
    Dim errmsg As String
    Dim index As Integer

    Private Sub frmXRayReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initialisationLoad()
    End Sub

    Private Sub btnGenReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenReport.Click
        Call loadTestValuesReport()
    End Sub

    Private Sub cmbPatID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPatID.SelectedIndexChanged
        cmbPatName.SelectedIndex = cmbPatID.SelectedIndex
        index = cmbPatID.SelectedIndex
        Call clearAll()
    End Sub

    Private Sub cmbPatName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPatName.SelectedIndexChanged
        cmbPatID.SelectedIndex = cmbPatName.SelectedIndex
    End Sub

    Private Sub initialisationLoad()
        Dim y As Integer
        Dim maX As Integer

        sqlstr = "SELECT A.*,B.Doc_FName,C.Staff_FName,E.Pat_FName,E.Pat_Age,E.Pat_Gender FROM XRay_Tests A,Doctor_Info B,Staff_Info C, Diagnosis_Tests D,Patient_Info E WHERE A.Ref_DocID=B.Doc_ID AND A.Ref_RadioID=C.Staff_ID AND D.Pat_ID=A.Pat_ID AND A.Pat_ID=E.Pat_ID AND E.Pat_Status='Reg' AND D.X_Test_Status='Done'"
        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count
        For y = 0 To max - 1
            cmbPatID.Items.Add(dt.Rows(y).Item(3))
            cmbPatName.Items.Add(dt.Rows(y).Item(17))
        Next
    End Sub

    Private Sub loadTestValuesReport()
        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        End If

        sqlstr1 = "SELECT A.*,B.Doc_FName,C.Staff_FName,E.Pat_FName,E.Pat_Age,E.Pat_Gender FROM XRay_Tests A,Doctor_Info B,Staff_Info C, Diagnosis_Tests D,Patient_Info E WHERE A.Ref_DocID=B.Doc_ID AND A.Ref_RadioID=C.Staff_ID AND D.Pat_ID=A.Pat_ID AND A.Pat_ID=E.Pat_ID AND E.Pat_Status='Reg' AND D.X_Test_Status='Done'"
        Dim dt As DataTable = getDataTable(sqlstr1)
        lblAge.Text = dt.Rows(index).Item(18)
        lblSex.Text = dt.Rows(index).Item(19)

        lblRrptNo.Text = dt.Rows(index).Item(0)
        lblReprtDate.Text = DateAndTime.Today.ToShortDateString
        lblRefDoc.Text = dt.Rows(index).Item(15)
        lblRefRadio.Text = dt.Rows(index).Item(16)
        lblExamName.Text = dt.Rows(index).Item(7)
        lblRemark1.Text = dt.Rows(index).Item(8)
        lblRemark2.Text = dt.Rows(index).Item(9)
        lblRemark3.Text = dt.Rows(index).Item(10)
        lblRemark4.Text = dt.Rows(index).Item(11)
        lblRemark5.Text = dt.Rows(index).Item(12)
        lblRemark6.Text = dt.Rows(index).Item(13)
        lblOpinion.Text = dt.Rows(index).Item(14)
    End Sub

    Private Sub clearAll()
        lblRrptNo.Text = "_"
        lblReprtDate.Text = "_"
        lblRefDoc.Text = "_"
        lblRefRadio.Text = "_"
        lblAge.Text = "_"
        lblSex.Text = "_"
        lblExamName.Text = "_"
        lblRemark1.Text = "_"
        lblRemark2.Text = "_"
        lblRemark3.Text = "_"
        lblRemark4.Text = "_"
        lblRemark5.Text = "_"
        lblRemark6.Text = "_"
        lblOpinion.Text = "_"
    End Sub

    Public Function chkData() As Boolean
        errmsg = ""
        If cmbPatID.Text = "" Then
            errmsg = errmsg & "Select a Patient ID!"
            chkData = True
        ElseIf cmbPatName.Text = "" Then
            errmsg = errmsg & "Select a Patient Name!"
            chkData = True
        Else
            chkData = False
        End If
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If exitForm() = True Then
            con.Close()
            Me.Dispose()
            Me.Close()
        End If
    End Sub
End Class