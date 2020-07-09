Public Class lokasi_tambah

    Public Function namaTable()
        Dim nama As String
        nama = "esdm_lokasi"
        Return nama
    End Function
    Private Sub Form_tambah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim appcommand As New AppCommand
        appcommand.TampilCombo(cbbKota, "select * from esdm_kab_kota", "namaKabKota", "idKabKota")
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim appcommand As New AppCommand
        appcommand.simpanOrUbahData("insert into " & namaTable() & "(idKabKota,alamatLokasi) values(" & cbbKota.SelectedValue & ",'" & txtAlamat.Text & "')")
        lokasi_table.tampilLokasi()
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim appcommand As New AppCommand
        appcommand.simpanOrUbahData("update esdm_lokasi set idKabKota='" & cbbKota.SelectedValue & "', alamatLokasi='" & txtAlamat.Text & "' where idLokasi='" & My.Settings._idLokasi & "'")
        lokasi_table.tampilLokasi()
        Me.Close()
    End Sub
End Class