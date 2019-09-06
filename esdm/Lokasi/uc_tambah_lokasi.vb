Public Class uc_tambah_lokasi
    Dim app As New AppCommand

    Private Sub Uc_tambah_lokasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        app.TampilCombo(cbbKota, "select * from esdm_kab_kota", "namaKabKota", "idKabKota")

    End Sub
End Class
