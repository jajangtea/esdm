Imports MySql.Data.MySqlClient

Public Class iup_tambah
    Private Sub iup_tambah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim appcommand As New AppCommand
        appcommand.TampilCombo(cbb_perusahaan, "select * from esdm_perusahaan", "namaPerusahaan", "idPerusahaan")
        appcommand.TampilCombo(cbb_lokasi, "select * from esdm_lokasi order by alamatLokasi", "alamatLokasi", "idLokasi")
        appcommand.TampilCombo(cbb_komoditi, "select * from esdm_bahan_galian order by namaBahanGalian", "namaBahanGalian", "idBahanGalian")
        appcommand.TampilCombo(cbbTahapan, "select * from esdm_tahap_kegiatan order by namaTahapKegiatan", "namaTahapKegiatan", "idTahapKegiatan")
        appcommand.TampilCombo(cbbJenis, "select * from esdm_jenis_perizinan order by namaPerizinan", "namaPerizinan", "idJenisPerizinan")

        If My.Settings._idLokasi <> "" Then
            Dim reader As MySqlDataReader
            reader = appcommand.TampilDataItems("select * from esdm_izin_perusahaan where idIzinPerusahaan='" & My.Settings._idLokasi & "'")
            While reader.Read
                cbb_perusahaan.SelectedValue = reader("idPerusahaan").ToString
                txt_no_izin.Text = reader("nomorSK").ToString
                cbb_lokasi.SelectedValue = reader("idLokasi").ToString
                cbbTahapan.SelectedValue = reader("idTahapKegiatan").ToString
                cbbJenis.SelectedValue = reader("idJenisPerizinan").ToString
                dateBerlaku.Value = reader("tglBerlaku")
                dateKadaluarsa.Value = reader("tglKadaluwarsa")
                txtLuasPenunjang.Text = reader("luasWilayahPenunjang")
                txt_luas.Text = reader("luasWilayahTambang")
                cbb_komoditi.SelectedValue = reader("idBahanGalian")
                txtcnc.Text = reader("cnc")

            End While
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim appcommand As New AppCommand
        Try
            If (btnSimpan.Text = "Simpan") Then
                Dim sqlsimpan As String = "insert into  esdm_izin_perusahaan (idJenisPerizinan, idTahapKegiatan, idLokasi, idBahanGalian, idPerusahaan, nomorSK, tglBerlaku, tglKadaluwarsa, luasWilayahTambang, luasWilayahPenunjang, cnc,status) values" & "('" & cbbJenis.SelectedValue & "','" & cbbTahapan.SelectedValue & "','" & cbb_lokasi.SelectedValue & "','" & cbb_komoditi.SelectedValue & "','" & cbb_perusahaan.SelectedValue & "','" & txt_no_izin.Text.Trim() & "','" & dateBerlaku.Value.ToString("yyyy-MM-dd") & "','" & dateKadaluarsa.Text.Trim() & "','" & txt_luas.Text.Trim() & "','" & txtLuasPenunjang.Text.Trim() & "','" & txtcnc.Text.Trim() & "','OK')"
                Debug.Print(sqlsimpan)
                appcommand.simpanOrUbahData(sqlsimpan)
                iup_table.tampilkan()
                Me.Close()
            Else
                Dim sqliup = "update esdm_izin_perusahaan set idJenisPerizinan='" & cbbJenis.SelectedValue & "',idTahapKegiatan='" & cbbTahapan.SelectedValue & "',idLokasi='" & cbb_lokasi.SelectedValue & "',idBahanGalian='" & cbb_komoditi.SelectedValue & "',idPerusahaan='" & cbb_perusahaan.SelectedValue & "',nomorSK='" & txt_no_izin.Text.Trim() & "',tglBerlaku='" & dateBerlaku.Value.ToString("yyyy-MM-dd") & "',tglKadaluwarsa='" & dateKadaluarsa.Value.ToString("yyyy-MM-dd") & "',luasWilayahTambang='" & txt_luas.Text.Trim() & "',luasWilayahPenunjang='" & txtLuasPenunjang.Text.Trim() & "',cnc='" & txtcnc.Text.Trim() & "' where idIzinPerusahaan='" & My.Settings._idLokasi & "'"
                Debug.Print(sqliup)
                appcommand.simpanOrUbahData(sqliup)
                iup_table.tampilkan(iup_table.cbbTahapan.SelectedValue.ToString)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class