Public Class BillPrint

    Private Sub BillPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New Billds
        Dim adp As New BilldsTableAdapters.Patient_ReceiptTableAdapter
        adp.Fill(ds.Patient_Receipt)
        Dim rpt As New BillReportPrint
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class