Public Class wiup_table
    Dim tblPrefik As String = "esdm_"
    Dim selectedId As String
    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        'lokasi_tambah.txtAlamat.Text = ""
        'lokasi_tambah.txtAlamat.Focus()
        'lokasi_tambah.btnSimpan.Visible = True
        'lokasi_tambah.btnEdit.Visible = False
        wiup_tambah.ShowDialog()
    End Sub
    Public Sub tampil_wiup(Optional cari = "")
        Dim appcommand As New AppCommand
        Dim sqlTampil As String = "select w.idWiup,p.namaPerusahaan,w.noIzin,w.tglIzin,l.alamatLokasi,w.luas,bg.namaBahanGalian from " & tblPrefik & "wiup w inner join " & tblPrefik & "perusahaan p on w.idPerusahaan=p.idPerusahaan "
        sqlTampil &= "inner join " & tblPrefik & "lokasi l on w.idLokasi=l.idLokasi "
        sqlTampil &= "inner join " & tblPrefik & "bahan_galian bg on w.idBahanGalian=bg.idBahanGalian where p.namaPerusahaan like '%" & cari & "%' or w.noIzin like '%" & cari & "%'  order by w.idWiup desc"
        appcommand.TampilData(dgv_wiup, sqlTampil)
        Debug.WriteLine(sqlTampil)
    End Sub
    Private Sub wiup_table_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil_wiup()
    End Sub

    Private Sub dgv_wiup_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgv_wiup.RowPostPaint
        Dim grid As DataGridView = CType(sender, DataGridView)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Far
        centerFormat.LineAlignment = StringAlignment.Near
        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub

    Private Sub dgv_wiup_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv_wiup.CellMouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Left AndAlso e.ColumnIndex = 0 Then
            dgv_wiup.CurrentCell = dgv_wiup.Rows(e.RowIndex).Cells(e.ColumnIndex)
            dgv_wiup.Rows(e.RowIndex).Selected = True
            dgv_wiup.Focus()
            selectedId = dgv_wiup.Rows(e.RowIndex).Cells(2).Value
            My.Settings._idLokasi = selectedId
            wiup_tambah.selected_id.Text = selectedId
            wiup_tambah.btnSimpan.Text = "Edit"
            wiup_tambah.Show()
        ElseIf e.Button = System.Windows.Forms.MouseButtons.Left AndAlso e.ColumnIndex = 1 Then
            Try
                Dim appcommand As New AppCommand
                Dim sql As String
                sql = "delete from esdm_wiup where idWiup=" & dgv_wiup.Rows(e.RowIndex).Cells(2).Value & ""
                Debug.Print(sql)
                appcommand.hapusData(sql, "Data berhasil dihapus.")
                tampil_wiup()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        tampil_wiup(txtCari.Text)
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        tampil_wiup()
    End Sub
End Class