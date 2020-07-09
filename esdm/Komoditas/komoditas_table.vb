Imports MySql.Data.MySqlClient

Public Class komoditas_table
    Public Function namaTable()
        Dim nama As String
        nama = "esdm_bahan_galian"
        Return nama
    End Function
    Private Sub Dgv_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles Dgv.RowPostPaint
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

    Private Sub komoditas_table_Load(sender As Object, e As EventArgs) Handles Me.Load
        tampil_komoditas()
    End Sub
    Public Sub tampil_komoditas(Optional cari = "")
        Dim app As New AppCommand
        Dim sqlkomoditi = "select * from esdm_bahan_galian where namaBahanGalian like '%" & cari & "%' order by namaBahanGalian asc"
        Debug.Print(sqlkomoditi)
        app.TampilData(Dgv, sqlkomoditi)
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        tampil_komoditas(txtcari.Text)
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        tampil_komoditas()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        komoditas_tambah.txtNama.Text = ""
        komoditas_tambah.txtNama.Focus()
        komoditas_tambah.btnSimpan.Visible = True
        komoditas_tambah.btnEdit.Visible = False
        komoditas_tambah.ShowDialog()
    End Sub

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellClick
        Dim app As New AppCommand
        If e.ColumnIndex = 0 Then 'Edit
            Dim idLokasi = Dgv.Rows(e.RowIndex).Cells(2).Value
            Dim reader As MySqlDataReader
            reader = app.TampilDataItems("select * from " & namaTable() & " where idBahanGalian=" & idLokasi & "")
            While reader.Read
                komoditas_tambah.txtNama.Text = reader("namaBahanGalian").ToString
            End While
            komoditas_tambah.btnEdit.Visible = True
            komoditas_tambah.btnSimpan.Visible = False
            My.Settings._idLokasi = idLokasi.ToString
            komoditas_tambah.ShowDialog()
            tampil_komoditas()
        ElseIf e.ColumnIndex = 1 Then 'Hapus
            Dim idLokasi = Dgv.Rows(e.RowIndex).Cells(2).Value
            Dim sqlhapus = "delete from " & namaTable() & " where idBahanGalian='" & idLokasi & "'"
            Debug.Print(sqlhapus)
            app.hapusData(sqlhapus, "dihapus")
            tampil_komoditas()
        End If
    End Sub
End Class