Imports MySql.Data.MySqlClient
Public Class AppCommand
    Dim Conn As MySqlConnection
    Dim comm As MySqlCommand
    Dim sql As String
    Dim ConnString As String
    Dim tampil As MySqlDataAdapter
    Dim ds As DataSet = New DataSet
    Dim reader As MySqlDataReader
    Dim tbl As DataTable
    Dim tgl, tahun, digit, kodebr As String
    Dim subtotal, hargabr As Double
    Dim kdbrg As String

    Public Sub TampilData(ByVal dgv As DataGridView, ByVal perintah As String)
        ConnString = My.Settings.sigConnectionString
        Conn = New MySqlConnection(ConnString)
        sql = perintah
        Try
            Conn.Open()
            comm = New MySqlCommand(sql, Conn)
            tampil = New MySqlDataAdapter(comm)
            ds.Clear()
            tampil.Fill(ds)
            dgv.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()
        End Try

    End Sub
    Public Function TampilDataItems(ByVal perintah As String)
        ConnString = My.Settings.sigConnectionString
        Conn = New MySqlConnection(ConnString)
        Conn.Open()
        comm = New MySqlCommand(perintah, Conn)
        reader = comm.ExecuteReader
        Return reader
        Conn.Close()
    End Function

    Public Sub TampilCombo(ByVal cb As ComboBox, ByVal perintah As String, ByVal member As String, ByVal value As String)
        ConnString = My.Settings.sigConnectionString
        Conn = New MySqlConnection(ConnString)
        sql = perintah
        Try
            Conn.Open()
            comm = New MySqlCommand(sql, Conn)
            tbl = New DataTable
            reader = comm.ExecuteReader
            tbl.Load(reader)
            cb.ValueMember = value
            cb.DisplayMember = member
            cb.DataSource = tbl
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub


    Sub kode_otomatis(ByVal adap As DataTable, ByVal lb As TextBox, ByVal kolom As String)
        tgl = "NS"
        tahun = Date.Now.Year
        digit = Microsoft.VisualBasic.Right(tahun, 2)
        tbl = adap
        If tbl.Rows.Count = 0 Then
            kdbrg = tgl + digit + "0001"
        Else
            With tbl.Rows(0)
                kdbrg = .Item(kolom)
            End With
            kdbrg = Val(Microsoft.VisualBasic.Mid(kdbrg, 5, 4)) + 1
            If Len(kdbrg) = 1 Then
                kdbrg = tgl + digit + "000" & kdbrg & ""
            ElseIf Len(kdbrg) = 2 Then
                kdbrg = tgl + digit + "00" & kdbrg & ""
            ElseIf Len(kdbrg) = 3 Then
                kdbrg = tgl + digit + "0" & kdbrg & ""
            ElseIf Len(kdbrg) = 4 Then
                kdbrg = tgl + digit + kdbrg
            End If

        End If
        lb.Text = kdbrg
    End Sub

    Public Function tampilScalar(ByVal perintah As String)
        Dim con As MySqlConnection = New MySqlConnection(My.Settings.sigConnectionString)
        Dim sql = perintah
        Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
        Dim total As Double
        Try
            con.Open()
            total = cmd.ExecuteScalar()
        Catch ex As Exception
            total = 0
        Finally
            con.Close()
        End Try
        Return total
    End Function

    Public Sub simpanOrUbahData(ByVal perintah As String, ByVal pesan As String)
        Try
            Dim con As MySqlConnection = New MySqlConnection(My.Settings.sigConnectionString)
            Dim sql = perintah
            Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Data telah " & pesan & ".", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub simpanOrUbahData(ByVal perintah As String)
        Try
            Dim con As MySqlConnection = New MySqlConnection(My.Settings.sigConnectionString)
            Dim sql = perintah
            Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
            con.Open()

            If cmd.ExecuteNonQuery() Then
                MsgBox("Data berhasil disimpan.", MsgBoxStyle.Information, "Informasi")
            Else
                MsgBox("Data gagal disimpan.", MsgBoxStyle.Information, "Informasi")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub hapusData(ByVal perintah As String, ByVal pesan As String)
        Try
            If MessageBox.Show("Apakah akan dihapus ?", "Pertanyaaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                Dim con As MySqlConnection = New MySqlConnection(My.Settings.sigConnectionString)
                Dim sql = perintah
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("data telah " & pesan & ".", MsgBoxStyle.Information, "Informasi")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
