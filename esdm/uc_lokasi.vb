Public Class uc_lokasi

    Private Sub Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        Dim app As New AppCommand
        ' app.TampilData(dgv, "select ek.namaKabKota as kota,el.alamatLokasi as alamat from esdm_lokasi el inner join esdm_kab_kota ek on el.idKabKota=ek.idKabKota")
        app.TampilData(dgv, "select idKabKota,namaKabKota  from esdm_kab_kota")

    End Sub

    Private Sub dgv_RowPostPaint(sender As System.Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgv.RowPostPaint
        Dim grid As DataGridView = CType(sender, DataGridView)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As New System.Drawing.Font("Century Gothic", 11.0!,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Far
        centerFormat.LineAlignment = StringAlignment.Near

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top,
        grid.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText,
            headerBounds, centerFormat)

        Dim rowIdxn As String = (e.RowIndex).ToString()
        '  dgv.Rows(rowIdx).Cells(1).Value = 11
        dgv.Rows(rowIdxn).Cells("jumlahLokasi").Value = dgv.Rows(rowIdxn).Cells("idKabKota").Value.ToString
    End Sub

    Private Sub dgv_CellValuePushed(sender As System.Object, e As System.Windows.Forms.DataGridViewCellValueEventArgs) Handles dgv.CellValuePushed

    End Sub
End Class
