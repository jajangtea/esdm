Public Class komoditas_tambah
    Public Function namaTable()
        Dim nama As String
        nama = "esdm_bahan_galian"
        Return nama
    End Function
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim appcommand As New AppCommand
        appcommand.simpanOrUbahData("insert into " & namaTable() & "(namaBahanGalian) values('" & txtNama.Text & "')")
        komoditas_table.tampil_komoditas()
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim appcommand As New AppCommand
        appcommand.simpanOrUbahData("update  " & namaTable() & " set namaBahanGalian='" & txtNama.Text & "' where idBahanGalian='" & My.Settings._idLokasi & "'")
        komoditas_table.tampil_komoditas()
        Me.Close()
    End Sub
End Class