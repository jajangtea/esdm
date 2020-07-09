<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wiup_table
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
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_wiup = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.idLokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_perusahaan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomor_izin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.luas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.komoditi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtCari = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        CType(Me.dgv_wiup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_wiup
        '
        Me.dgv_wiup.AllowUserToAddRows = False
        Me.dgv_wiup.AllowUserToDeleteRows = False
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_wiup.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.dgv_wiup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_wiup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_wiup.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgv_wiup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_wiup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_wiup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_wiup.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.dgv_wiup.ColumnHeadersHeight = 35
        Me.dgv_wiup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idLokasi, Me.nama_perusahaan, Me.nomor_izin, Me.tanggal, Me.lokasi, Me.luas, Me.komoditi, Me.edit, Me.hapus})
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_wiup.DefaultCellStyle = DataGridViewCellStyle27
        Me.dgv_wiup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_wiup.DoubleBuffered = True
        Me.dgv_wiup.EnableHeadersVisualStyles = False
        Me.dgv_wiup.GridColor = System.Drawing.Color.Gray
        Me.dgv_wiup.HeaderBgColor = System.Drawing.Color.Crimson
        Me.dgv_wiup.HeaderForeColor = System.Drawing.Color.White
        Me.dgv_wiup.Location = New System.Drawing.Point(0, 38)
        Me.dgv_wiup.Name = "dgv_wiup"
        Me.dgv_wiup.ReadOnly = True
        Me.dgv_wiup.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_wiup.RowHeadersWidth = 40
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_wiup.RowsDefaultCellStyle = DataGridViewCellStyle28
        Me.dgv_wiup.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgv_wiup.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_wiup.RowTemplate.Height = 50
        Me.dgv_wiup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_wiup.Size = New System.Drawing.Size(800, 412)
        Me.dgv_wiup.TabIndex = 0
        '
        'idLokasi
        '
        Me.idLokasi.DataPropertyName = "idWiup"
        Me.idLokasi.HeaderText = "id"
        Me.idLokasi.Name = "idLokasi"
        Me.idLokasi.ReadOnly = True
        Me.idLokasi.Visible = False
        Me.idLokasi.Width = 44
        '
        'nama_perusahaan
        '
        Me.nama_perusahaan.DataPropertyName = "namaPerusahaan"
        Me.nama_perusahaan.FillWeight = 14.01869!
        Me.nama_perusahaan.HeaderText = "Perusahaan"
        Me.nama_perusahaan.Name = "nama_perusahaan"
        Me.nama_perusahaan.ReadOnly = True
        Me.nama_perusahaan.Width = 108
        '
        'nomor_izin
        '
        Me.nomor_izin.DataPropertyName = "noIzin"
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black
        Me.nomor_izin.DefaultCellStyle = DataGridViewCellStyle24
        Me.nomor_izin.HeaderText = "Nomor Izin"
        Me.nomor_izin.Name = "nomor_izin"
        Me.nomor_izin.ReadOnly = True
        Me.nomor_izin.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nomor_izin.Width = 92
        '
        'tanggal
        '
        Me.tanggal.DataPropertyName = "tglIzin"
        Me.tanggal.HeaderText = "Tanggal"
        Me.tanggal.Name = "tanggal"
        Me.tanggal.ReadOnly = True
        Me.tanggal.Width = 85
        '
        'lokasi
        '
        Me.lokasi.DataPropertyName = "alamatLokasi"
        Me.lokasi.HeaderText = "Lokasi"
        Me.lokasi.Name = "lokasi"
        Me.lokasi.ReadOnly = True
        Me.lokasi.Width = 72
        '
        'luas
        '
        Me.luas.DataPropertyName = "luas"
        Me.luas.HeaderText = "Luas"
        Me.luas.Name = "luas"
        Me.luas.ReadOnly = True
        Me.luas.Width = 60
        '
        'komoditi
        '
        Me.komoditi.DataPropertyName = "namaBahanGalian"
        Me.komoditi.HeaderText = "Komoditi"
        Me.komoditi.Name = "komoditi"
        Me.komoditi.ReadOnly = True
        Me.komoditi.Width = 88
        '
        'edit
        '
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White
        Me.edit.DefaultCellStyle = DataGridViewCellStyle25
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit.HeaderText = ""
        Me.edit.Name = "edit"
        Me.edit.ReadOnly = True
        Me.edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.edit.Text = "Edit"
        Me.edit.UseColumnTextForButtonValue = True
        Me.edit.Width = 17
        '
        'hapus
        '
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White
        Me.hapus.DefaultCellStyle = DataGridViewCellStyle26
        Me.hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hapus.HeaderText = ""
        Me.hapus.Name = "hapus"
        Me.hapus.ReadOnly = True
        Me.hapus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.hapus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.hapus.Text = "Hapus"
        Me.hapus.UseColumnTextForButtonValue = True
        Me.hapus.Width = 17
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgv_wiup)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 450)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.BtnRefresh)
        Me.Panel2.Controls.Add(Me.btnTambah)
        Me.Panel2.Controls.Add(Me.txtCari)
        Me.Panel2.Controls.Add(Me.BtnCari)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 38)
        Me.Panel2.TabIndex = 1
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
        Me.btnTambah.Location = New System.Drawing.Point(724, 6)
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
        'wiup_table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "wiup_table"
        Me.Text = "Data WIUP"
        CType(Me.dgv_wiup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_wiup As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtCari As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BtnCari As Button
    Friend WithEvents idLokasi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_perusahaan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomor_izin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lokasi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents luas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents komoditi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents edit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents hapus As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents BtnRefresh As Button
End Class
