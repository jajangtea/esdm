Public Class FLaporan_wiup
    Private Sub Laporan_wiup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'sigDataSet.DataTableWiup' table. You can move, or remove it, as needed.
        Me.DataTableWiupTableAdapter.Fill(Me.sigDataSet.DataTableWiup)

        Me.ReportViewer3.RefreshReport()
    End Sub
End Class