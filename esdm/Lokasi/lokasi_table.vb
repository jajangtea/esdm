Imports MySql.Data.MySqlClient

Public Class lokasi_table

    Public Sub tampilLokasi(Optional cari = "")
        Dim app As New AppCommand
        Dim sql As String = "select el.idLokasi as idLokasi,ek.namaKabKota as namaKabKota,el.alamatLokasi as alamatLokasi from esdm_lokasi el inner join esdm_kab_kota ek on el.idKabKota=ek.idKabKota where ek.namaKabKota like '%" & cari & "%' order by  el.idLokasi desc"
        Debug.Print(sql)
        app.TampilData(Dgv, sql)
        'app.TampilData(Dgv, "select idKabKota,namaKabKota  from esdm_kab_kota")
    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        lokasi_tambah.txtAlamat.Text = ""
        lokasi_tambah.txtAlamat.Focus()
        lokasi_tambah.btnSimpan.Visible = True
        lokasi_tambah.btnEdit.Visible = False
        lokasi_tambah.ShowDialog()
    End Sub

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellClick
        Dim app As New AppCommand
        If e.ColumnIndex = 0 Then 'Edit
            Dim idLokasi = Dgv.Rows(e.RowIndex).Cells(2).Value
            Dim reader As MySqlDataReader
            reader = app.TampilDataItems("select * from esdm_lokasi where idLokasi=" & idLokasi & "")
            While reader.Read
                lokasi_tambah.cbbKota.SelectedValue = reader("idLokasi").ToString
                lokasi_tambah.txtAlamat.Text = reader("alamatLokasi").ToString
            End While
            lokasi_tambah.btnEdit.Visible = True
            lokasi_tambah.btnSimpan.Visible = False
            My.Settings._idLokasi = idLokasi.ToString
            lokasi_tambah.ShowDialog()
            tampilLokasi()
        ElseIf e.ColumnIndex = 1 Then 'Hapus
            Dim idLokasi = Dgv.Rows(e.RowIndex).Cells(2).Value
            Dim sqlhapus = "delete from esdm_lokasi where idLokasi='" & idLokasi & "'"
            Debug.Print(sqlhapus)
            app.hapusData(sqlhapus, "dihapus")
            tampilLokasi()
        End If

    End Sub

    Private Sub lokasi_table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilLokasi()
    End Sub

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

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        'Dim app As New AppCommand
        'Dim sql As String = "select el.idLokasi as idLokasi,ek.namaKabKota as namaKabKota,el.alamatLokasi as alamatLokasi from esdm_lokasi el inner join esdm_kab_kota ek on el.idKabKota=ek.idKabKota where ek.namaKabKota like '%" & txtcari.Text & "%' order by  el.idLokasi desc"
        'Debug.Print(sql)
        'app.TampilData(Dgv, sql)
        tampilLokasi(txtcari.Text)
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        tampilLokasi()
    End Sub
End Class