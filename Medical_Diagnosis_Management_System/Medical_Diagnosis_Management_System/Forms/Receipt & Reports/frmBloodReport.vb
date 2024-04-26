Public Class frmBloodReport
    Dim errmsg As String
    Dim index As Integer

    Private Sub frmBloodReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        sqlstr = "SELECT A.*,B.Doc_FName,C.Staff_FName,E.Pat_FName,E.Pat_Age,E.Pat_Gender FROM Blood_Tests A,Doctor_Info B,Staff_Info C, Diagnosis_Tests D,Patient_Info E WHERE A.Ref_DocID=B.Doc_ID AND A.Ref_PathoID=C.Staff_ID AND D.Pat_ID=A.Pat_ID AND A.Pat_ID=E.Pat_ID AND E.Pat_Status='Reg' AND D.B_Test_Status='Done'"
        Dim dt1 As DataTable = getDataTable(sqlstr)
        maX = dt1.Rows.Count
        For y = 0 To max - 1
            cmbPatID.Items.Add(dt1.Rows(y).Item(3))
            cmbPatName.Items.Add(dt1.Rows(y).Item(25))
        Next
    End Sub

    Private Sub loadTestValuesReport()
        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        End If

        sqlstr1 = "SELECT A.*,B.Doc_FName,C.Staff_FName,E.Pat_FName,E.Pat_Age,E.Pat_Gender FROM Blood_Tests A,Doctor_Info B,Staff_Info C, Diagnosis_Tests D,Patient_Info E WHERE A.Ref_DocID=B.Doc_ID AND A.Ref_PathoID=C.Staff_ID AND D.Pat_ID=A.Pat_ID AND A.Pat_ID=E.Pat_ID AND E.Pat_Status='Reg' AND D.B_Test_Status='Done'"
        Dim dt As DataTable = getDataTable(sqlstr1)
        lblAge.Text = dt.Rows(index).Item(26)
        lblSex.Text = dt.Rows(index).Item(27)

        lblRrptNo.Text = dt.Rows(index).Item(0)
        lblReprtDate.Text = DateAndTime.Today.ToShortDateString
        lblRefDoc.Text = dt.Rows(index).Item(23)
        lblRefPatho.Text = dt.Rows(index).Item(24)

        If dt.Rows(index).Item(7) > 10000 Or dt.Rows(index).Item(7) < 4000 Then
            LE.Text = dt.Rows(index).Item(7)
            LE.ForeColor = Color.Red
        Else
            LE.Text = dt.Rows(index).Item(7)
        End If

        If dt.Rows(index).Item(8) > 4.8 Or dt.Rows(index).Item(8) < 3.8 Then
            ER.Text = dt.Rows(index).Item(8)
            ER.ForeColor = Color.Red
        Else
            ER.Text = dt.Rows(index).Item(8)
        End If

        If dt.Rows(index).Item(9) > 15 Or dt.Rows(index).Item(9) < 12 Then
            HA.Text = dt.Rows(index).Item(9)
            HA.ForeColor = Color.Red
        Else
            HA.Text = dt.Rows(index).Item(9)
        End If

        If dt.Rows(index).Item(10) > 46.0 Or dt.Rows(index).Item(10) < 36.0 Then
            PCV.Text = dt.Rows(index).Item(10)
            PCV.ForeColor = Color.Red
        Else
            PCV.Text = dt.Rows(index).Item(10)
        End If

        If dt.Rows(index).Item(11) > 101.0 Or dt.Rows(index).Item(11) < 83.0 Then
            MCV.Text = dt.Rows(index).Item(11)
            MCV.ForeColor = Color.Red
        Else
            MCV.Text = dt.Rows(index).Item(11)
        End If

        If dt.Rows(index).Item(12) > 32 Or dt.Rows(index).Item(12) < 27 Then
            MCH.Text = dt.Rows(index).Item(12)
            MCH.ForeColor = Color.Red
        Else
            MCH.Text = dt.Rows(index).Item(12)
        End If

        If dt.Rows(index).Item(13) > 34.5 Or dt.Rows(index).Item(13) < 31.5 Then
            MCHC.Text = dt.Rows(index).Item(13)
            MCHC.ForeColor = Color.Red
        Else
            MCHC.Text = dt.Rows(index).Item(13)
        End If

        If dt.Rows(index).Item(14) > 14 Or dt.Rows(index).Item(14) < 11.6 Then
            RDW.Text = dt.Rows(index).Item(14)
            RDW.ForeColor = Color.Red
        Else
            RDW.Text = dt.Rows(index).Item(14)
        End If

        If dt.Rows(index).Item(15) > 13 Or dt.Rows(index).Item(15) < 9 Then
            MPV.Text = dt.Rows(index).Item(15)
            MPV.ForeColor = Color.Red
        Else
            MPV.Text = dt.Rows(index).Item(15)
        End If

        If dt.Rows(index).Item(16) > 400.0 Or dt.Rows(index).Item(16) < 150.0 Then
            PL.Text = dt.Rows(index).Item(16)
            PL.ForeColor = Color.Red
        Else
            PL.Text = dt.Rows(index).Item(16)
        End If

        If dt.Rows(index).Item(17) > 5.1 Or dt.Rows(index).Item(17) < 3.8 Then
            TRBC.Text = dt.Rows(index).Item(17)
            TRBC.ForeColor = Color.Red
        Else
            TRBC.Text = dt.Rows(index).Item(17)
        End If

        If dt.Rows(index).Item(18) > 80 Or dt.Rows(index).Item(18) < 40 Then
            NE.Text = dt.Rows(index).Item(18)
            NE.ForeColor = Color.Red
        Else
            NE.Text = dt.Rows(index).Item(18)
        End If

        If dt.Rows(index).Item(19) > 40.0 Or dt.Rows(index).Item(19) < 20.0 Then
            LY.Text = dt.Rows(index).Item(19)
            LY.ForeColor = Color.Red
        Else
            LY.Text = dt.Rows(index).Item(19)
        End If

        If dt.Rows(index).Item(20) > 10.0 Or dt.Rows(index).Item(20) < 2.0 Then
            MO.Text = dt.Rows(index).Item(20)
            MO.ForeColor = Color.Red
        Else
            MO.Text = dt.Rows(index).Item(20)
        End If

        If dt.Rows(index).Item(21) > 6.0 Or dt.Rows(index).Item(21) < 1.0 Then
            EO.Text = dt.Rows(index).Item(21)
            EO.ForeColor = Color.Red
        Else
            EO.Text = dt.Rows(index).Item(21)
        End If

        If dt.Rows(index).Item(22) > 1.0 Or dt.Rows(index).Item(22) < 0.0 Then
            BA.Text = dt.Rows(index).Item(22)
            BA.ForeColor = Color.Red
        Else
            BA.Text = dt.Rows(index).Item(22)
        End If
    End Sub

    Private Sub clearAll()
        lblRrptNo.Text = "_"
        lblReprtDate.Text = "_"
        lblRefDoc.Text = "_"
        lblRefPatho.Text = "_"
        lblAge.Text = "_"
        lblSex.Text = "_"
        LE.Text = "_"
        ER.Text = "_"
        HA.Text = "_"
        PCV.Text = "_"
        MCV.Text = "_"
        MCH.Text = "_"
        MCHC.Text = "_"
        RDW.Text = "_"
        MPV.Text = "_"
        PL.Text = "_"
        TRBC.Text = "_"
        NE.Text = "_"
        LY.Text = "_"
        MO.Text = "_"
        EO.Text = "_"
        BA.Text = "_"
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