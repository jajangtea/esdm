<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iup_tambah
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
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbb_perusahaan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_no_izin = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cbb_lokasi = New System.Windows.Forms.ComboBox()
        Me.txt_luas = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cbb_komoditi = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbbJenis = New System.Windows.Forms.ComboBox()
        Me.cbbTahapan = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dateBerlaku = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dateKadaluarsa = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtLuasPenunjang = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtcnc = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Crimson
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(200, 345)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(529, 33)
        Me.btnSimpan.TabIndex = 43
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(200, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 17)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "No.SK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(200, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Komoditi"
        '
        'cbb_perusahaan
        '
        Me.cbb_perusahaan.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cbb_perusahaan.DropDownHeight = 150
        Me.cbb_perusahaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_perusahaan.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbb_perusahaan.ForeColor = System.Drawing.Color.White
        Me.cbb_perusahaan.FormattingEnabled = True
        Me.cbb_perusahaan.IntegralHeight = False
        Me.cbb_perusahaan.Location = New System.Drawing.Point(200, 79)
        Me.cbb_perusahaan.Name = "cbb_perusahaan"
        Me.cbb_perusahaan.Size = New System.Drawing.Size(256, 25)
        Me.cbb_perusahaan.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(200, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Perusahaan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(200, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 25)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "INPUT DATA IUP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(475, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 17)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Luas Wilayah Tambang (ha)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(200, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Lokasi"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(181, 388)
        Me.Panel1.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(28, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 25)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "DATA IUP"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.esdm.My.Resources.Resources.Department_96px
        Me.PictureBox1.Location = New System.Drawing.Point(44, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 90)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txt_no_izin
        '
        Me.txt_no_izin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_no_izin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no_izin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_no_izin.HintForeColor = System.Drawing.Color.Empty
        Me.txt_no_izin.HintText = ""
        Me.txt_no_izin.isPassword = False
        Me.txt_no_izin.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_no_izin.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txt_no_izin.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_no_izin.LineThickness = 4
        Me.txt_no_izin.Location = New System.Drawing.Point(200, 171)
        Me.txt_no_izin.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_no_izin.Name = "txt_no_izin"
        Me.txt_no_izin.Size = New System.Drawing.Size(251, 33)
        Me.txt_no_izin.TabIndex = 2
        Me.txt_no_izin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cbb_lokasi
        '
        Me.cbb_lokasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cbb_lokasi.DropDownHeight = 150
        Me.cbb_lokasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_lokasi.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbb_lokasi.ForeColor = System.Drawing.Color.White
        Me.cbb_lokasi.FormattingEnabled = True
        Me.cbb_lokasi.IntegralHeight = False
        Me.cbb_lokasi.Location = New System.Drawing.Point(200, 241)
        Me.cbb_lokasi.Name = "cbb_lokasi"
        Me.cbb_lokasi.Size = New System.Drawing.Size(256, 25)
        Me.cbb_lokasi.TabIndex = 3
        '
        'txt_luas
        '
        Me.txt_luas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_luas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_luas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_luas.HintForeColor = System.Drawing.Color.Empty
        Me.txt_luas.HintText = ""
        Me.txt_luas.isPassword = False
        Me.txt_luas.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_luas.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txt_luas.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_luas.LineThickness = 4
        Me.txt_luas.Location = New System.Drawing.Point(474, 236)
        Me.txt_luas.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_luas.Name = "txt_luas"
        Me.txt_luas.Size = New System.Drawing.Size(255, 34)
        Me.txt_luas.TabIndex = 9
        Me.txt_luas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cbb_komoditi
        '
        Me.cbb_komoditi.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cbb_komoditi.DropDownHeight = 150
        Me.cbb_komoditi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_komoditi.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbb_komoditi.ForeColor = System.Drawing.Color.White
        Me.cbb_komoditi.FormattingEnabled = True
        Me.cbb_komoditi.IntegralHeight = False
        Me.cbb_komoditi.Location = New System.Drawing.Point(200, 301)
        Me.cbb_komoditi.Name = "cbb_komoditi"
        Me.cbb_komoditi.Size = New System.Drawing.Size(255, 25)
        Me.cbb_komoditi.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(200, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 17)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Jenis Izin"
        '
        'cbbJenis
        '
        Me.cbbJenis.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cbbJenis.DropDownHeight = 150
        Me.cbbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbJenis.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbbJenis.ForeColor = System.Drawing.Color.White
        Me.cbbJenis.FormattingEnabled = True
        Me.cbbJenis.IntegralHeight = False
        Me.cbbJenis.Location = New System.Drawing.Point(200, 131)
        Me.cbbJenis.Name = "cbbJenis"
        Me.cbbJenis.Size = New System.Drawing.Size(256, 25)
        Me.cbbJenis.TabIndex = 1
        '
        'cbbTahapan
        '
        Me.cbbTahapan.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cbbTahapan.DropDownHeight = 150
        Me.cbbTahapan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTahapan.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbbTahapan.ForeColor = System.Drawing.Color.White
        Me.cbbTahapan.FormattingEnabled = True
        Me.cbbTahapan.IntegralHeight = False
        Me.cbbTahapan.Location = New System.Drawing.Point(474, 79)
        Me.cbbTahapan.Name = "cbbTahapan"
        Me.cbbTahapan.Size = New System.Drawing.Size(161, 25)
        Me.cbbTahapan.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(471, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 17)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Tahapan Kegiatan"
        '
        'dateBerlaku
        '
        Me.dateBerlaku.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dateBerlaku.BorderRadius = 0
        Me.dateBerlaku.ForeColor = System.Drawing.Color.White
        Me.dateBerlaku.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateBerlaku.FormatCustom = Nothing
        Me.dateBerlaku.Location = New System.Drawing.Point(474, 131)
        Me.dateBerlaku.Name = "dateBerlaku"
        Me.dateBerlaku.Size = New System.Drawing.Size(255, 25)
        Me.dateBerlaku.TabIndex = 7
        Me.dateBerlaku.Value = New Date(2020, 7, 9, 9, 12, 22, 738)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(471, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 17)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Tanggal Berlaku"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(471, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 17)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Tanggal Kadaluarsa"
        '
        'dateKadaluarsa
        '
        Me.dateKadaluarsa.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dateKadaluarsa.BorderRadius = 0
        Me.dateKadaluarsa.ForeColor = System.Drawing.Color.White
        Me.dateKadaluarsa.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateKadaluarsa.FormatCustom = Nothing
        Me.dateKadaluarsa.Location = New System.Drawing.Point(474, 179)
        Me.dateKadaluarsa.Name = "dateKadaluarsa"
        Me.dateKadaluarsa.Size = New System.Drawing.Size(255, 25)
        Me.dateKadaluarsa.TabIndex = 8
        Me.dateKadaluarsa.Value = New Date(2020, 7, 9, 9, 12, 22, 738)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(475, 271)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(194, 17)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Luas Wilayah Penunjang (ha)"
        '
        'txtLuasPenunjang
        '
        Me.txtLuasPenunjang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLuasPenunjang.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuasPenunjang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLuasPenunjang.HintForeColor = System.Drawing.Color.Empty
        Me.txtLuasPenunjang.HintText = ""
        Me.txtLuasPenunjang.isPassword = False
        Me.txtLuasPenunjang.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtLuasPenunjang.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtLuasPenunjang.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtLuasPenunjang.LineThickness = 4
        Me.txtLuasPenunjang.Location = New System.Drawing.Point(474, 296)
        Me.txtLuasPenunjang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLuasPenunjang.Name = "txtLuasPenunjang"
        Me.txtLuasPenunjang.Size = New System.Drawing.Size(255, 34)
        Me.txtLuasPenunjang.TabIndex = 10
        Me.txtLuasPenunjang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(639, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 17)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "CNC"
        '
        'txtcnc
        '
        Me.txtcnc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcnc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcnc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcnc.HintForeColor = System.Drawing.Color.Empty
        Me.txtcnc.HintText = ""
        Me.txtcnc.isPassword = False
        Me.txtcnc.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtcnc.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtcnc.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtcnc.LineThickness = 4
        Me.txtcnc.Location = New System.Drawing.Point(642, 73)
        Me.txtcnc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcnc.Name = "txtcnc"
        Me.txtcnc.Size = New System.Drawing.Size(88, 37)
        Me.txtcnc.TabIndex = 6
        Me.txtcnc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'iup_tambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(743, 388)
        Me.Controls.Add(Me.dateKadaluarsa)
        Me.Controls.Add(Me.dateBerlaku)
        Me.Controls.Add(Me.txtLuasPenunjang)
        Me.Controls.Add(Me.txt_luas)
        Me.Controls.Add(Me.txtcnc)
        Me.Controls.Add(Me.txt_no_izin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbb_lokasi)
        Me.Controls.Add(Me.cbbTahapan)
        Me.Controls.Add(Me.cbb_komoditi)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbbJenis)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbb_perusahaan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "iup_tambah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah IUP"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbb_perusahaan As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_no_izin As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cbb_lokasi As ComboBox
    Friend WithEvents txt_luas As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cbb_komoditi As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbbJenis As ComboBox
    Friend WithEvents cbbTahapan As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dateBerlaku As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dateKadaluarsa As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label12 As Label
    Friend WithEvents txtLuasPenunjang As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtcnc As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
