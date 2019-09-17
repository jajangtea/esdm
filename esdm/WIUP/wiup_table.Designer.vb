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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Dgv = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.idLokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaKabKota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamatLokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.Dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv.ColumnHeadersHeight = 35
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idLokasi, Me.namaKabKota, Me.alamatLokasi, Me.edit, Me.hapus})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.DefaultCellStyle = DataGridViewCellStyle6
        Me.Dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv.DoubleBuffered = True
        Me.Dgv.EnableHeadersVisualStyles = False
        Me.Dgv.GridColor = System.Drawing.Color.Gray
        Me.Dgv.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv.HeaderForeColor = System.Drawing.Color.White
        Me.Dgv.Location = New System.Drawing.Point(0, 38)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        Me.Dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dgv.RowHeadersWidth = 40
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Dgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Dgv.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgv.RowTemplate.Height = 50
        Me.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.Dgv.Size = New System.Drawing.Size(800, 412)
        Me.Dgv.TabIndex = 0
        '
        'idLokasi
        '
        Me.idLokasi.DataPropertyName = "idLokasi"
        Me.idLokasi.HeaderText = "id"
        Me.idLokasi.Name = "idLokasi"
        Me.idLokasi.ReadOnly = True
        Me.idLokasi.Visible = False
        Me.idLokasi.Width = 44
        '
        'namaKabKota
        '
        Me.namaKabKota.DataPropertyName = "namaKabKota"
        Me.namaKabKota.FillWeight = 14.01869!
        Me.namaKabKota.HeaderText = "Kota/Kabupaten"
        Me.namaKabKota.Name = "namaKabKota"
        Me.namaKabKota.ReadOnly = True
        Me.namaKabKota.Width = 138
        '
        'alamatLokasi
        '
        Me.alamatLokasi.DataPropertyName = "alamatLokasi"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.alamatLokasi.DefaultCellStyle = DataGridViewCellStyle3
        Me.alamatLokasi.HeaderText = "Lokasi"
        Me.alamatLokasi.Name = "alamatLokasi"
        Me.alamatLokasi.ReadOnly = True
        Me.alamatLokasi.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.alamatLokasi.Width = 72
        '
        'edit
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.edit.DefaultCellStyle = DataGridViewCellStyle4
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit.HeaderText = ""
        Me.edit.Name = "edit"
        Me.edit.ReadOnly = True
        Me.edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.edit.Text = "Edit"
        Me.edit.UseColumnTextForButtonValue = True
        Me.edit.Width = 17
        '
        'hapus
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.hapus.DefaultCellStyle = DataGridViewCellStyle5
        Me.hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hapus.HeaderText = ""
        Me.hapus.Name = "hapus"
        Me.hapus.ReadOnly = True
        Me.hapus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.hapus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
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
        Me.Panel3.Controls.Add(Me.Dgv)
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
        Me.Panel2.Controls.Add(Me.btnTambah)
        Me.Panel2.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Panel2.Controls.Add(Me.Button2)
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
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox1.BorderThickness = 3
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(4, 5)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(256, 28)
        Me.BunifuMetroTextbox1.TabIndex = 2
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(259, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 27)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Cari"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'wiup_table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "wiup_table"
        Me.Text = "Data WIUP"
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Dgv As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents idLokasi As DataGridViewTextBoxColumn
    Friend WithEvents namaKabKota As DataGridViewTextBoxColumn
    Friend WithEvents alamatLokasi As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents hapus As DataGridViewButtonColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTambah As Button
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Button2 As Button
End Class
