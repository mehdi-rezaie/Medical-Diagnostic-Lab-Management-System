Public Class frmEyeExamReport
    Dim errmsg As String
    Dim index As Integer

    Private Sub frmEyeExamReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        sqlstr = "SELECT A.*,B.Doc_FName,C.Staff_FName,E.Pat_FName,E.Pat_Age,E.Pat_Gender FROM EyeExam_Tests A,Doctor_Info B,Staff_Info C, Diagnosis_Tests D,Patient_Info E WHERE A.Ref_DocID=B.Doc_ID AND A.Ref_OpthalID=C.Staff_ID AND D.Pat_ID=A.Pat_ID AND A.Pat_ID=E.Pat_ID AND E.Pat_Status='Reg' AND D.O_Test_Status='Done'"
        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count
        For y = 0 To max - 1
            cmbPatID.Items.Add(dt.Rows(y).Item(3))
            cmbPatName.Items.Add(dt.Rows(y).Item(16))
        Next
    End Sub

    Private Sub loadTestValuesReport()
        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        End If

        sqlstr1 = "SELECT A.*,B.Doc_FName,C.Staff_FName,E.Pat_FName,E.Pat_Age,E.Pat_Gender FROM EyeExam_Tests A,Doctor_Info B,Staff_Info C, Diagnosis_Tests D,Patient_Info E WHERE A.Ref_DocID=B.Doc_ID AND A.Ref_OpthalID=C.Staff_ID AND D.Pat_ID=A.Pat_ID AND A.Pat_ID=E.Pat_ID AND E.Pat_Status='Reg' AND D.O_Test_Status='Done'"
        Dim dt As DataTable = getDataTable(sqlstr1)
        lblAge.Text = dt.Rows(index).Item(17)
        lblSex.Text = dt.Rows(index).Item(18)

        lblRrptNo.Text = dt.Rows(index).Item(0)
        lblReprtDate.Text = DateAndTime.Today.ToShortDateString
        lblRefDoc.Text = dt.Rows(index).Item(14)
        lblRefOpthal.Text = dt.Rows(index).Item(15)
        lblEyeExamName.Text = dt.Rows(index).Item(7)
        lblEye.Text = dt.Rows(index).Item(8)
        lblRemark.Text = dt.Rows(index).Item(9)
        lblMyopia.Text = dt.Rows(index).Item(10)
        lblHyper.Text = dt.Rows(index).Item(11)
        lblRadius.Text = dt.Rows(index).Item(12)
        lblArea.Text = dt.Rows(index).Item(13)

    End Sub

    Private Sub clearAll()
        lblRrptNo.Text = "_"
        lblReprtDate.Text = "_"
        lblAge.Text = "_"
        lblSex.Text = "_"
        lblEyeExamName.Text = "_"
        lblRefDoc.Text = "_"
        lblRefOpthal.Text = "_"
        lblEye.Text = "_"
        lblMyopia.Text = "_"
        lblMyopia.Text = "_"
        lblHyper.Text = "_"
        lblRadius.Text = "_"
        lblArea.Text = "_"
        lblRemark.Text = "_"
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