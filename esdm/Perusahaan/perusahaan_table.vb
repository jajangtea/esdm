Imports MySql.Data.MySqlClient

Public Class perusahaan_table
    Private Sub Form_perusahaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_perusahaan()
    End Sub

    Public Sub tampil_perusahaan(Optional cari = "")
        Dim app As New AppCommand
        Dim sqlperusahaan = "select * from esdm_perusahaan where namaPerusahaan like '%" & cari & "%' order by idPerusahaan desc"
        Debug.Print(sqlperusahaan)
        app.TampilData(dgv, sqlperusahaan)
    End Sub
    Private Sub dgv_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgv.RowPostPaint
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        perusahaan_tambah.txtNama.Focus()
        perusahaan_tambah.btnSimpan.Visible = True
        perusahaan_tambah.btnEdit.Visible = False
        perusahaan_tambah.ShowDialog()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim app As New AppCommand
        If e.ColumnIndex = 0 Then 'Edit
            Dim idLokasi = dgv.Rows(e.RowIndex).Cells(2).Value
            Dim reader As MySqlDataReader
            reader = app.TampilDataItems("select * from esdm_perusahaan where idPerusahaan=" & idLokasi & "")
            While reader.Read
                perusahaan_tambah.txtTlp.Text = reader("tlp").ToString
                perusahaan_tambah.txtNama.Text = reader("namaPerusahaan").ToString
                perusahaan_tambah.txtAlamat.Text = reader("alamat").ToString
            End While
            perusahaan_tambah.btnEdit.Visible = True
            perusahaan_tambah.btnSimpan.Visible = False
            My.Settings._idLokasi = idLokasi.ToString
            perusahaan_tambah.ShowDialog()
            tampil_perusahaan()
        ElseIf e.ColumnIndex = 1 Then 'Hapus
            Dim idLokasi = dgv.Rows(e.RowIndex).Cells(2).Value
            Dim sqlhapus = "delete from esdm_perusahaan where idPerusahaan='" & idLokasi & "'"
            Debug.Print(sqlhapus)
            app.hapusData(sqlhapus, "dihapus")
            tampil_perusahaan()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tampil_perusahaan(txtCari.Text)
    End Sub
    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        tampil_perusahaan()
    End Sub
End Class