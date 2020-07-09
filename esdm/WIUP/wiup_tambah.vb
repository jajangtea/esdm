
Imports MySql.Data.MySqlClient
Public Class wiup_tambah
    Public selected_id As New Label
    Private Sub wiup_tambah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim appcommand As New AppCommand
        appcommand.TampilCombo(cbb_perusahaan, "select * from esdm_perusahaan", "namaPerusahaan", "idPerusahaan")
        appcommand.TampilCombo(cbb_lokasi, "select * from esdm_lokasi order by alamatLokasi", "alamatLokasi", "idLokasi")
        appcommand.TampilCombo(cbb_komoditi, "select * from esdm_bahan_galian order by namaBahanGalian", "namaBahanGalian", "idBahanGalian")

        If selected_id.Text <> "" Then
            Dim reader As MySqlDataReader
            reader = appcommand.TampilDataItems("select * from esdm_wiup where idWiup='" & selected_id.Text & "'")
            While reader.Read
                cbb_perusahaan.SelectedValue = reader("idPerusahaan").ToString
                txt_no_izin.Text = reader("noIzin").ToString
                cbb_lokasi.SelectedValue = reader("idLokasi").ToString
                dt_tanggal.Value = reader("tglIzin")
                cbb_komoditi.SelectedValue = reader("idBahanGalian")
                txt_luas.Text = reader("luas")
            End While
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim appcommand As New AppCommand
        Try
            If (btnSimpan.Text = "Simpan") Then
                Dim sqlsimpan As String = "insert into  esdm_wiup (idPerusahaan,idLokasi,idBahanGalian,noIzin,tglIzin,luas) values" & "('" & cbb_perusahaan.SelectedValue & "','" & cbb_lokasi.SelectedValue & "','" & cbb_komoditi.SelectedValue & "','" & txt_no_izin.Text.Trim() & "','" & dt_tanggal.Value.ToString("yyyy-MM-dd") & "','" & txt_luas.Text.Trim() & "')"
                appcommand.simpanOrUbahData(sqlsimpan)
                wiup_table.tampil_wiup()
                Me.Close()
            Else
                Dim sqlwiup = "update esdm_wiup set idPerusahaan='" & cbb_perusahaan.SelectedValue & "',idLokasi='" & cbb_lokasi.SelectedValue & "',idBahanGalian='" & cbb_komoditi.SelectedValue & "',noIzin='" & txt_no_izin.Text.Trim() & "',tglIzin='" & dt_tanggal.Value.ToString("yyyy-MM-dd") & "',luas='" & txt_luas.Text.Trim() & "' where idWiup='" & My.Settings._idLokasi & "'"
                Debug.Print(sqlwiup)
                appcommand.simpanOrUbahData(sqlwiup)
                wiup_table.tampil_wiup()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class