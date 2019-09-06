<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_lokasi
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Dgv = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.idKabKota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaKabKota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlahLokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lokasi = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 296)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Dgv)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(615, 296)
        Me.Panel3.TabIndex = 2
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
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idKabKota, Me.namaKabKota, Me.jumlahLokasi, Me.edit, Me.hapus, Me.lokasi})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.DefaultCellStyle = DataGridViewCellStyle7
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
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.Dgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Dgv.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgv.RowTemplate.Height = 50
        Me.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv.Size = New System.Drawing.Size(615, 258)
        Me.Dgv.TabIndex = 0
        '
        'idKabKota
        '
        Me.idKabKota.DataPropertyName = "idKabKota"
        Me.idKabKota.HeaderText = "id"
        Me.idKabKota.Name = "idKabKota"
        Me.idKabKota.ReadOnly = True
        Me.idKabKota.Visible = False
        Me.idKabKota.Width = 44
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
        'jumlahLokasi
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.jumlahLokasi.DefaultCellStyle = DataGridViewCellStyle3
        Me.jumlahLokasi.HeaderText = "Jumlah Lokasi"
        Me.jumlahLokasi.Name = "jumlahLokasi"
        Me.jumlahLokasi.ReadOnly = True
        Me.jumlahLokasi.Width = 112
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
        Me.edit.HeaderText = "Edit"
        Me.edit.Name = "edit"
        Me.edit.ReadOnly = True
        Me.edit.Text = "Edit"
        Me.edit.UseColumnTextForButtonValue = True
        Me.edit.Width = 36
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
        Me.hapus.HeaderText = "Hapus"
        Me.hapus.Name = "hapus"
        Me.hapus.ReadOnly = True
        Me.hapus.Text = "Hapus"
        Me.hapus.UseColumnTextForButtonValue = True
        Me.hapus.Width = 53
        '
        'lokasi
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.lokasi.DefaultCellStyle = DataGridViewCellStyle6
        Me.lokasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lokasi.HeaderText = "Lokasi"
        Me.lokasi.Name = "lokasi"
        Me.lokasi.ReadOnly = True
        Me.lokasi.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.lokasi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.lokasi.Text = "Lokasi"
        Me.lokasi.UseColumnTextForButtonValue = True
        Me.lokasi.Width = 72
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.btnTambah)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(615, 38)
        Me.Panel2.TabIndex = 1
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
        Me.Button2.FlatAppearance.BorderSize = 3
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
        'btnTambah
        '
        Me.btnTambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTambah.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(547, 6)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(64, 27)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'uc_lokasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_lokasi"
        Me.Size = New System.Drawing.Size(615, 296)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Dgv As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents idKabKota As DataGridViewTextBoxColumn
    Friend WithEvents namaKabKota As DataGridViewTextBoxColumn
    Friend WithEvents jumlahLokasi As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents hapus As DataGridViewButtonColumn
    Friend WithEvents lokasi As DataGridViewButtonColumn
End Class
