Public Class perusahaan_tambah
    Public Function namaTable()
        Dim nama As String
        nama = "esdm_perusahaan"
        Return nama
    End Function
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim appcommand As New AppCommand
        Dim sqlsimpan = "insert into " & namaTable() & "(namaPerusahaan, tlp, alamat) values('" & txtNama.Text & "','" & txtTlp.Text & "','" & txtAlamat.Text & "')"
        Debug.Print(sqlsimpan)
        appcommand.simpanOrUbahData(sqlsimpan)
        perusahaan_table.tampil_perusahaan()
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim appcommand As New AppCommand
        Dim sqlsimpan = "update esdm_perusahaan set namaPerusahaan='" & txtNama.Text & "', tlp='" & txtTlp.Text & "',alamat='" & txtAlamat.Text & "' where idPerusahaan='" & My.Settings._idLokasi & "'"
        Debug.Print(sqlsimpan)
        appcommand.simpanOrUbahData(sqlsimpan)
        perusahaan_table.tampil_perusahaan()
        Me.Close()
    End Sub
End Class