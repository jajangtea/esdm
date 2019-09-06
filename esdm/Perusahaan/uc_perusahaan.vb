Public Class uc_perusahaan

    Private Sub uc_perusahaan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim app As New AppCommand
        app.TampilData(dgv, "select * from esdm_perusahaan")
    End Sub

    Private Sub dgv_RowPostPaint(sender As System.Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgv.RowPostPaint
        Dim grid As DataGridView = CType(sender, DataGridView)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As New System.Drawing.Font("Century Gothic", 8.0!, _
            System.Drawing.FontStyle.Regular, _
            System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Far
        centerFormat.LineAlignment = StringAlignment.Near

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, _
        grid.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, _
            headerBounds, centerFormat)
    End Sub
End Class
