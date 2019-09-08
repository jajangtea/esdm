Public Class uc_lokasi
    Dim app As New AppCommand
    Private Sub Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        ' app.TampilData(dgv, "select ek.namaKabKota as kota,el.alamatLokasi as alamat from esdm_lokasi el inner join esdm_kab_kota ek on el.idKabKota=ek.idKabKota")
        app.TampilData(Dgv, "select idKabKota,namaKabKota  from esdm_kab_kota")
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs)
        Dim uctambahlokasi As New uc_tambah_lokasi

        ' FormPeramalan.TopLevel = False
        form_lokasi.Controls.Add(uctambahlokasi)
        uctambahlokasi.Show()
        uctambahlokasi.BringToFront()
        uctambahlokasi.Dock = DockStyle.Fill
    End Sub

    Private Sub Dgv_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles Dgv.RowPostPaint
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
        Dgv.Rows(rowIdxn).Cells("jumlahLokasi").Value = Dgv.Rows(rowIdxn).Cells("idKabKota").Value.ToString
    End Sub

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub
End Class
