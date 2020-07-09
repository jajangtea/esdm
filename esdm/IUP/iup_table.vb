Public Class iup_table
    Public Const tblPrefik = "esdm_"
    Dim sqlTampil As String
    Dim appcommand As New AppCommand
    Dim __idtahapKegiatan As String
    Public Sub tampilkan(Optional tahap = "", Optional namaPerusahaan = "")
        sqlTampil = "select w.idIzinPerusahaan as idIzinPerusahaan,w.tglBerlaku as tglBerlaku,w.tglKadaluwarsa as tglKadaluwarsa,TIMESTAMPDIFF(DAY,CURDATE(),w.tglKadaluwarsa) AS masaBerlaku,w.cnc as cnc, "
        sqlTampil &= "p.namaPerusahaan as namaPerusahaan,w.nomorSK as nomorSK ,l.alamatLokasi as alamatLokasi ,w.luasWilayahTambang as luasWilayahTambang,w.luasWilayahPenunjang as luasWilayahPenunjang,bg.namaBahanGalian as namaBahanGalian "
        sqlTampil &= "from " + tblPrefik + "izin_perusahaan w inner join " + tblPrefik + "perusahaan p on w.idPerusahaan=p.idPerusahaan "
        sqlTampil &= " inner join " + tblPrefik + "lokasi l on w.idLokasi=l.idLokasi "
        sqlTampil &= " inner join " + tblPrefik + "bahan_galian bg on w.idBahanGalian=bg.idBahanGalian"
        sqlTampil &= " where w.idJenisPerizinan='1' and w.idTahapKegiatan='" + tahap + "' and p.namaPerusahaan like'%" & txtCari.Text & "%' order by w.idIzinPerusahaan desc"
        appcommand.TampilData(dgv_iup, sqlTampil)
        Debug.WriteLine(sqlTampil)

    End Sub
    Private Sub iup_table_Load(sender As Object, e As EventArgs) Handles Me.Load

        appcommand.TampilCombo(cbbTahapan, "select * from esdm_tahap_kegiatan order by namaTahapKegiatan", "namaTahapKegiatan", "idTahapKegiatan")
        menu_utama.bntMenu.PerformClick()
        tampilkan(cbbTahapan.SelectedValue.ToString, txtCari.Text)


    End Sub
    Private Sub dgv_iup_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgv_iup.RowPostPaint
        Dim grid As DataGridView = CType(sender, DataGridView)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As New System.Drawing.Font("Century Gothic", 8.0!,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Far
        centerFormat.LineAlignment = StringAlignment.Near

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top,
        grid.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText,
            headerBounds, centerFormat)
    End Sub

    Private Sub dgv_iup_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_iup.CellFormatting
        Dim row As DataGridViewRow = dgv_iup.Rows(e.RowIndex)
        Dim obj As Object = row.Cells("masaBerlaku").Value
        If Not IsDBNull(row.Cells("masaBerlaku").Value) Then
            If row.Cells("masaBerlaku").Value < 0 Then
                row.DefaultCellStyle.BackColor = Color.Red

            ElseIf row.Cells("masaBerlaku").Value > 0 Then
                row.DefaultCellStyle.BackColor = Color.White
            End If
        End If
        dgv_iup.Columns("edit").DisplayIndex = 11
        dgv_iup.Columns("delete").DisplayIndex = 12
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        iup_tambah.txt_no_izin.Text = ""
        iup_tambah.txt_no_izin.Focus()
        iup_tambah.txt_luas.Text = ""
        iup_tambah.txtLuasPenunjang.Text = ""
        iup_tambah.btnSimpan.Text = "Simpan"
        iup_tambah.ShowDialog()
    End Sub

    Private Sub cbbTahapan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbTahapan.SelectedIndexChanged
        tampilkan(cbbTahapan.SelectedValue.ToString, txtCari.Text)
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        tampilkan(cbbTahapan.SelectedValue.ToString, txtCari.Text)
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        sqlTampil = "select w.idIzinPerusahaan,w.tglBerlaku,w.tglKadaluwarsa,TIMESTAMPDIFF(DAY,CURDATE(),w.tglKadaluwarsa) AS masaBerlaku,w.cnc, "
        sqlTampil &= "p.namaPerusahaan,w.nomorSK,l.alamatLokasi,w.luasWilayahTambang,w.luasWilayahPenunjang,bg.namaBahanGalian "
        sqlTampil &= "from " & tblPrefik & "izin_perusahaan w inner join " & tblPrefik & "perusahaan p on w.idPerusahaan=p.idPerusahaan "
        sqlTampil &= " inner join " & tblPrefik & "lokasi l on w.idLokasi=l.idLokasi "
        sqlTampil &= " inner join " & tblPrefik & "bahan_galian bg on w.idBahanGalian=bg.idBahanGalian"
        sqlTampil &= " order by w.idIzinPerusahaan desc"
        appcommand.TampilData(dgv_iup, sqlTampil)
        Debug.WriteLine(sqlTampil)
    End Sub

    Private Sub dgv_iup_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_iup.CellMouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Left AndAlso e.ColumnIndex = 0 Then
            dgv_iup.CurrentCell = dgv_iup.Rows(e.RowIndex).Cells(e.ColumnIndex)
            dgv_iup.Rows(e.RowIndex).Selected = True
            dgv_iup.Focus()
            Dim selectedId As String = dgv_iup.Rows(e.RowIndex).Cells(2).Value

            My.Settings._idLokasi = selectedId
            iup_tambah.btnSimpan.Text = "Edit"
            iup_tambah.Show()
        ElseIf e.Button = System.Windows.Forms.MouseButtons.Left AndAlso e.ColumnIndex = 1 Then
            Try
                Dim appcommand As New AppCommand
                Dim sql As String
                sql = "delete from esdm_izin_perusahaan  where idIzinPerusahaan=" & dgv_iup.Rows(e.RowIndex).Cells(2).Value & ""
                Debug.Print(sql)
                appcommand.hapusData(sql, "Data berhasil dihapus")
                tampilkan(cbbTahapan.SelectedValue.ToString, txtCari.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class