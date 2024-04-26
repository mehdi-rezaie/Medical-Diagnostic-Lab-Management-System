Imports Microsoft.VisualBasic.PowerPacks
Public Class frmBiochemReport
    Dim errmsg As String
    Dim index As Integer
    Private Sub frmBiochemReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim max As Integer

        sqlstr = "SELECT A.*,B.Doc_FName,C.Staff_FName,E.Pat_FName,E.Pat_Age,E.Pat_Gender FROM Biochemistry_Tests A,Doctor_Info B,Staff_Info C, Diagnosis_Tests D,Patient_Info E WHERE A.Ref_DocID=B.Doc_ID AND A.Ref_PathoID=C.Staff_ID AND D.Pat_ID=A.Pat_ID AND A.Pat_ID=E.Pat_ID AND E.Pat_Status='Reg' AND D.BC_Test_Status='Done'"

        Dim dt1 As DataTable = getDataTable(sqlstr)
        max = dt1.Rows.Count
        For y = 0 To max - 1
            cmbPatID.Items.Add(dt1.Rows(y).Item(3))
            cmbPatName.Items.Add(dt1.Rows(y).Item(27))
        Next
    End Sub

    Private Sub loadTestValuesReport()
        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        End If

        sqlstr = "SELECT A.*,B.Doc_FName,C.Staff_FName,E.Pat_FName,E.Pat_Age,E.Pat_Gender FROM Biochemistry_Tests A,Doctor_Info B,Staff_Info C, Diagnosis_Tests D,Patient_Info E WHERE A.Ref_DocID=B.Doc_ID AND A.Ref_PathoID=C.Staff_ID AND D.Pat_ID=A.Pat_ID AND A.Pat_ID=E.Pat_ID AND E.Pat_Status='Reg' AND D.BC_Test_Status='Done'"
        Dim dt As DataTable = getDataTable(sqlstr)
        lblAge.Text = dt.Rows(index).Item(28)
        lblSex.Text = dt.Rows(index).Item(29)

        lblRrptNo.Text = dt.Rows(index).Item(0)
        lblReprtDate.Text = DateAndTime.Today.ToShortDateString
        lblRefDoc.Text = dt.Rows(index).Item(25)
        lblRefPatho.Text = dt.Rows(index).Item(26)

        If dt.Rows(index).Item(7) > 40 Or dt.Rows(index).Item(7) < 10 Then
            BU.Text = dt.Rows(index).Item(7)
            BU.ForeColor = Color.Red
        Else
            BU.Text = dt.Rows(index).Item(7)
        End If

        If dt.Rows(index).Item(8) > 1.5 Or dt.Rows(index).Item(8) < 0.6 Then
            CR.Text = dt.Rows(index).Item(8)
            CR.ForeColor = Color.Red
        Else
            CR.Text = dt.Rows(index).Item(8)
        End If

        If dt.Rows(index).Item(9) > 8.0 Or dt.Rows(index).Item(9) < 6.0 Then
            TP.Text = dt.Rows(index).Item(9)
            TP.ForeColor = Color.Red
        Else
            TP.Text = dt.Rows(index).Item(9)
        End If

        If dt.Rows(index).Item(10) > 5.0 Or dt.Rows(index).Item(10) < 3.5 Then
            AL.Text = dt.Rows(index).Item(10)
            AL.ForeColor = Color.Red
        Else
            AL.Text = dt.Rows(index).Item(10)
        End If

        If dt.Rows(index).Item(11) > 3.6 Or dt.Rows(index).Item(11) < 2.3 Then
            GL.Text = dt.Rows(index).Item(11)
            GL.ForeColor = Color.Red
        Else
            GL.Text = dt.Rows(index).Item(11)
        End If

        If dt.Rows(index).Item(12) > 1.0 Or dt.Rows(index).Item(12) < 0.2 Then
            BT.Text = dt.Rows(index).Item(12)
            BT.ForeColor = Color.Red
        Else
            BT.Text = dt.Rows(index).Item(12)
        End If

        If dt.Rows(index).Item(13) > 60.0 Or dt.Rows(index).Item(13) < 0 Then
            TR.Text = dt.Rows(index).Item(13)
            TR.ForeColor = Color.Red
        Else
            TR.Text = dt.Rows(index).Item(13)
        End If

        If dt.Rows(index).Item(14) > 700 Or dt.Rows(index).Item(14) < 400 Then
            TL.Text = dt.Rows(index).Item(14)
            TL.ForeColor = Color.Red
        Else
            TL.Text = dt.Rows(index).Item(14)
        End If

        If dt.Rows(index).Item(15) > 335.8 Or dt.Rows(index).Item(15) < 312.8 Then
            SO.Text = dt.Rows(index).Item(15)
            SO.ForeColor = Color.Red
        Else
            SO.Text = dt.Rows(index).Item(15)
        End If

        If dt.Rows(index).Item(16) > 11.5 Or dt.Rows(index).Item(16) < 8.05 Then
            PO.Text = dt.Rows(index).Item(16)
            PO.ForeColor = Color.Red
        Else
            PO.Text = dt.Rows(index).Item(16)
        End If

        If dt.Rows(index).Item(17) > 111 Or dt.Rows(index).Item(17) < 97 Then
            CL.Text = dt.Rows(index).Item(17)
            CL.ForeColor = Color.Red
        Else
            CL.Text = dt.Rows(index).Item(17)
        End If

        If dt.Rows(index).Item(18) > 11.0 Or dt.Rows(index).Item(18) < 8.5 Then
            CA.Text = dt.Rows(index).Item(18)
            CA.ForeColor = Color.Red
        Else
            CA.Text = dt.Rows(index).Item(18)
        End If

        If dt.Rows(index).Item(19) > 2.2 Or dt.Rows(index).Item(19) < 1.7 Then
            MG.Text = dt.Rows(index).Item(19)
            MG.ForeColor = Color.Red
        Else
            MG.Text = dt.Rows(index).Item(19)
        End If

        If dt.Rows(index).Item(20) > 6.0 Or dt.Rows(index).Item(20) < 4.0 Then
            UA.Text = dt.Rows(index).Item(20)
            UA.ForeColor = Color.Red
        Else
            UA.Text = dt.Rows(index).Item(20)
        End If

        If dt.Rows(index).Item(21) > 2.5 Or dt.Rows(index).Item(21) < 0.3 Then
            T3.Text = dt.Rows(index).Item(21)
            T3.ForeColor = Color.Red
        Else
            T3.Text = dt.Rows(index).Item(21)
        End If

        If dt.Rows(index).Item(22) > 12.0 Or dt.Rows(index).Item(22) < 4.5 Then
            T4.Text = dt.Rows(index).Item(22)
            T4.ForeColor = Color.Red
        Else
            T4.Text = dt.Rows(index).Item(22)
        End If

        If dt.Rows(index).Item(23) > 4.0 Or dt.Rows(index).Item(23) < 0.4 Then
            TSH.Text = dt.Rows(index).Item(23)
            TSH.ForeColor = Color.Red
        Else
            TSH.Text = dt.Rows(index).Item(23)
        End If

        If dt.Rows(index).Item(24) > 225 Then
            CH.Text = dt.Rows(index).Item(24)
            CH.ForeColor = Color.Red
        Else
            CH.Text = dt.Rows(index).Item(24)
        End If
    End Sub

    Private Sub clearAll()
        lblRrptNo.Text = "_"
        lblReprtDate.Text = "_"
        lblRefDoc.Text = "_"
        lblRefPatho.Text = "_"
        lblAge.Text = "_"
        lblSex.Text = "_"
        BU.Text = "_"
        CR.Text = "_"
        TP.Text = "_"
        AL.Text = "_"
        GL.Text = "_"
        BT.Text = "_"
        TR.Text = "_"
        TL.Text = "_"
        SO.Text = "_"
        PO.Text = "_"
        CL.Text = "_"
        CA.Text = "_"
        MG.Text = "_"
        UA.Text = "_"
        T3.Text = "_"
        T4.Text = "_"
        TSH.Text = "_"
        CH.Text = "_"
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