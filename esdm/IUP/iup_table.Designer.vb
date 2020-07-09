<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iup_table
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtCari = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgv_iup = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbbTahapan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idIzinPerusahaan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaPerusahaan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomorSK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglBerlaku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglKadaluwarsa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.masaBerlaku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamatLokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.luasWilayahTambang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.luasWilayahPenunjang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaBahanGalian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_iup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.Crimson
        Me.BtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnRefresh.FlatAppearance.BorderSize = 0
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.Location = New System.Drawing.Point(326, 5)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(64, 27)
        Me.BtnRefresh.TabIndex = 4
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTambah.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(733, 6)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(64, 27)
        Me.btnTambah.TabIndex = 3
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtCari.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCari.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtCari.BorderThickness = 3
        Me.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCari.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCari.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCari.isPassword = False
        Me.txtCari.Location = New System.Drawing.Point(4, 5)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(256, 28)
        Me.txtCari.TabIndex = 2
        Me.txtCari.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cbbTahapan)
        Me.Panel2.Controls.Add(Me.BtnRefresh)
        Me.Panel2.Controls.Add(Me.btnTambah)
        Me.Panel2.Controls.Add(Me.txtCari)
        Me.Panel2.Controls.Add(Me.BtnCari)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(809, 38)
        Me.Panel2.TabIndex = 1
        '
        'BtnCari
        '
        Me.BtnCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCari.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCari.FlatAppearance.BorderSize = 0
        Me.BtnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCari.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCari.ForeColor = System.Drawing.Color.White
        Me.BtnCari.Location = New System.Drawing.Point(259, 6)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(64, 27)
        Me.BtnCari.TabIndex = 0
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgv_iup)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(809, 450)
        Me.Panel3.TabIndex = 2
        '
        'dgv_iup
        '
        Me.dgv_iup.AllowUserToAddRows = False
        Me.dgv_iup.AllowUserToDeleteRows = False
        Me.dgv_iup.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_iup.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_iup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_iup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_iup.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgv_iup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_iup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_iup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_iup.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_iup.ColumnHeadersHeight = 45
        Me.dgv_iup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idIzinPerusahaan, Me.namaPerusahaan, Me.nomorSK, Me.tglBerlaku, Me.tglKadaluwarsa, Me.masaBerlaku, Me.cnc, Me.alamatLokasi, Me.luasWilayahTambang, Me.luasWilayahPenunjang, Me.namaBahanGalian, Me.edit, Me.delete})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_iup.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_iup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_iup.DoubleBuffered = True
        Me.dgv_iup.EnableHeadersVisualStyles = False
        Me.dgv_iup.GridColor = System.Drawing.Color.Gray
        Me.dgv_iup.HeaderBgColor = System.Drawing.Color.Crimson
        Me.dgv_iup.HeaderForeColor = System.Drawing.Color.White
        Me.dgv_iup.Location = New System.Drawing.Point(0, 38)
        Me.dgv_iup.Name = "dgv_iup"
        Me.dgv_iup.ReadOnly = True
        Me.dgv_iup.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_iup.RowHeadersWidth = 40
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_iup.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_iup.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgv_iup.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_iup.RowTemplate.Height = 50
        Me.dgv_iup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_iup.Size = New System.Drawing.Size(809, 412)
        Me.dgv_iup.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 450)
        Me.Panel1.TabIndex = 3
        '
        'cbbTahapan
        '
        Me.cbbTahapan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbbTahapan.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cbbTahapan.DropDownHeight = 150
        Me.cbbTahapan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTahapan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbTahapan.ForeColor = System.Drawing.Color.White
        Me.cbbTahapan.FormattingEnabled = True
        Me.cbbTahapan.IntegralHeight = False
        Me.cbbTahapan.Location = New System.Drawing.Point(454, 7)
        Me.cbbTahapan.Name = "cbbTahapan"
        Me.cbbTahapan.Size = New System.Drawing.Size(231, 25)
        Me.cbbTahapan.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(397, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tahapan :"
        '
        'idIzinPerusahaan
        '
        Me.idIzinPerusahaan.DataPropertyName = "idIzinPerusahaan"
        Me.idIzinPerusahaan.HeaderText = "id"
        Me.idIzinPerusahaan.Name = "idIzinPerusahaan"
        Me.idIzinPerusahaan.ReadOnly = True
        Me.idIzinPerusahaan.Visible = False
        Me.idIzinPerusahaan.Width = 42
        '
        'namaPerusahaan
        '
        Me.namaPerusahaan.DataPropertyName = "namaPerusahaan"
        Me.namaPerusahaan.FillWeight = 14.01869!
        Me.namaPerusahaan.HeaderText = "Perusahaan"
        Me.namaPerusahaan.Name = "namaPerusahaan"
        Me.namaPerusahaan.ReadOnly = True
        '
        'nomorSK
        '
        Me.nomorSK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nomorSK.DataPropertyName = "nomorSK"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nomorSK.DefaultCellStyle = DataGridViewCellStyle3
        Me.nomorSK.HeaderText = "Nomor SK"
        Me.nomorSK.Name = "nomorSK"
        Me.nomorSK.ReadOnly = True
        Me.nomorSK.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nomorSK.Width = 120
        '
        'tglBerlaku
        '
        Me.tglBerlaku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tglBerlaku.DataPropertyName = "tglBerlaku"
        Me.tglBerlaku.HeaderText = "Tgl.Berlaku"
        Me.tglBerlaku.Name = "tglBerlaku"
        Me.tglBerlaku.ReadOnly = True
        Me.tglBerlaku.Width = 95
        '
        'tglKadaluwarsa
        '
        Me.tglKadaluwarsa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tglKadaluwarsa.DataPropertyName = "tglKadaluwarsa"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tglKadaluwarsa.DefaultCellStyle = DataGridViewCellStyle4
        Me.tglKadaluwarsa.HeaderText = "Tgl.Kadaluarsa"
        Me.tglKadaluwarsa.Name = "tglKadaluwarsa"
        Me.tglKadaluwarsa.ReadOnly = True
        Me.tglKadaluwarsa.Width = 117
        '
        'masaBerlaku
        '
        Me.masaBerlaku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.masaBerlaku.DataPropertyName = "masaBerlaku"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.masaBerlaku.DefaultCellStyle = DataGridViewCellStyle5
        Me.masaBerlaku.HeaderText = "Berlaku (Hari)"
        Me.masaBerlaku.Name = "masaBerlaku"
        Me.masaBerlaku.ReadOnly = True
        Me.masaBerlaku.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.masaBerlaku.Width = 60
        '
        'cnc
        '
        Me.cnc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.cnc.DataPropertyName = "cnc"
        Me.cnc.HeaderText = "CNC"
        Me.cnc.Name = "cnc"
        Me.cnc.ReadOnly = True
        Me.cnc.Width = 35
        '
        'alamatLokasi
        '
        Me.alamatLokasi.DataPropertyName = "alamatLokasi"
        Me.alamatLokasi.HeaderText = "Lokasi"
        Me.alamatLokasi.Name = "alamatLokasi"
        Me.alamatLokasi.ReadOnly = True
        Me.alamatLokasi.Width = 67
        '
        'luasWilayahTambang
        '
        Me.luasWilayahTambang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.luasWilayahTambang.DataPropertyName = "luasWilayahTambang"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.luasWilayahTambang.DefaultCellStyle = DataGridViewCellStyle6
        Me.luasWilayahTambang.HeaderText = "LWT (ha)"
        Me.luasWilayahTambang.Name = "luasWilayahTambang"
        Me.luasWilayahTambang.ReadOnly = True
        Me.luasWilayahTambang.Width = 75
        '
        'luasWilayahPenunjang
        '
        Me.luasWilayahPenunjang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.luasWilayahPenunjang.DataPropertyName = "luasWilayahPenunjang"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.luasWilayahPenunjang.DefaultCellStyle = DataGridViewCellStyle7
        Me.luasWilayahPenunjang.HeaderText = "LWP (ha)"
        Me.luasWilayahPenunjang.Name = "luasWilayahPenunjang"
        Me.luasWilayahPenunjang.ReadOnly = True
        Me.luasWilayahPenunjang.Width = 76
        '
        'namaBahanGalian
        '
        Me.namaBahanGalian.DataPropertyName = "namaBahanGalian"
        Me.namaBahanGalian.HeaderText = "Komoditi"
        Me.namaBahanGalian.Name = "namaBahanGalian"
        Me.namaBahanGalian.ReadOnly = True
        Me.namaBahanGalian.Width = 82
        '
        'edit
        '
        Me.edit.DataPropertyName = "edit"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        Me.edit.DefaultCellStyle = DataGridViewCellStyle8
        Me.edit.HeaderText = ""
        Me.edit.Name = "edit"
        Me.edit.ReadOnly = True
        Me.edit.Text = "Edit"
        Me.edit.UseColumnTextForButtonValue = True
        Me.edit.Width = 5
        '
        'delete
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        Me.delete.DefaultCellStyle = DataGridViewCellStyle9
        Me.delete.HeaderText = ""
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        Me.delete.Text = "Delete"
        Me.delete.UseColumnTextForButtonValue = True
        Me.delete.Width = 5
        '
        'iup_table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "iup_table"
        Me.Text = "iup_table"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgv_iup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnRefresh As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtCari As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnCari As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgv_iup As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbbTahapan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents idIzinPerusahaan As DataGridViewTextBoxColumn
    Friend WithEvents namaPerusahaan As DataGridViewTextBoxColumn
    Friend WithEvents nomorSK As DataGridViewTextBoxColumn
    Friend WithEvents tglBerlaku As DataGridViewTextBoxColumn
    Friend WithEvents tglKadaluwarsa As DataGridViewTextBoxColumn
    Friend WithEvents masaBerlaku As DataGridViewTextBoxColumn
    Friend WithEvents cnc As DataGridViewTextBoxColumn
    Friend WithEvents alamatLokasi As DataGridViewTextBoxColumn
    Friend WithEvents luasWilayahTambang As DataGridViewTextBoxColumn
    Friend WithEvents luasWilayahPenunjang As DataGridViewTextBoxColumn
    Friend WithEvents namaBahanGalian As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents delete As DataGridViewButtonColumn
End Class
