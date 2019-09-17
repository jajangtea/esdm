Imports MySql.Data.MySqlClient

Public Class lokasi_table

    Public Sub tampilLokasi()
        Dim app As New AppCommand
        Dim sql As String = "select el.idLokasi as idLokasi,ek.namaKabKota as namaKabKota,el.alamatLokasi as alamatLokasi from esdm_lokasi el inner join esdm_kab_kota ek on el.idKabKota=ek.idKabKota order by  el.idLokasi desc"
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
            reader = app.TampilDataItems("select * from " & Wiup.namaTable & " where idLokasi=" & idLokasi & "")
            While reader.Read
                lokasi_tambah.cbbKota.SelectedValue = reader("idLokasi").ToString
                lokasi_tambah.txtAlamat.Text = reader("alamatLokasi").ToString
            End While
            lokasi_tambah.btnEdit.Visible = True
            lokasi_tambah.btnSimpan.Visible = False
            lokasi_tambah.ShowDialog()
        ElseIf e.ColumnIndex = 1 Then 'Hapus
            Dim idLokasi = Dgv.Rows(e.RowIndex).Cells(2).Value
            app.hapusData("delete from " & Wiup.namaTable & " where idLokasi='" & idLokasi & "'", "dihapus")
        End If
        tampilLokasi()
    End Sub

    Private Sub lokasi_table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilLokasi()
    End Sub
End Class