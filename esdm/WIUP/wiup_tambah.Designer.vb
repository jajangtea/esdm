<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wiup_tambah
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
        Me.txt_luas = New System.Windows.Forms.TextBox()
        Me.cbb_lokasi = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbb_perusahaan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbb_komoditi = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_no_izin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dt_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_luas
        '
        Me.txt_luas.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_luas.Location = New System.Drawing.Point(202, 268)
        Me.txt_luas.Name = "txt_luas"
        Me.txt_luas.Size = New System.Drawing.Size(327, 23)
        Me.txt_luas.TabIndex = 4
        '
        'cbb_lokasi
        '
        Me.cbb_lokasi.BackColor = System.Drawing.SystemColors.Info
        Me.cbb_lokasi.DropDownHeight = 150
        Me.cbb_lokasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_lokasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbb_lokasi.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbb_lokasi.FormattingEnabled = True
        Me.cbb_lokasi.IntegralHeight = False
        Me.cbb_lokasi.Location = New System.Drawing.Point(202, 215)
        Me.cbb_lokasi.Name = "cbb_lokasi"
        Me.cbb_lokasi.Size = New System.Drawing.Size(327, 25)
        Me.cbb_lokasi.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(199, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Luas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(199, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 22
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
        Me.Panel1.Size = New System.Drawing.Size(181, 406)
        Me.Panel1.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(28, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 25)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "DATA WIUP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(197, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 25)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "INPUT DATA WIUP"
        '
        'cbb_perusahaan
        '
        Me.cbb_perusahaan.BackColor = System.Drawing.SystemColors.Info
        Me.cbb_perusahaan.DropDownHeight = 150
        Me.cbb_perusahaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_perusahaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbb_perusahaan.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbb_perusahaan.FormattingEnabled = True
        Me.cbb_perusahaan.IntegralHeight = False
        Me.cbb_perusahaan.Location = New System.Drawing.Point(202, 66)
        Me.cbb_perusahaan.Name = "cbb_perusahaan"
        Me.cbb_perusahaan.Size = New System.Drawing.Size(327, 25)
        Me.cbb_perusahaan.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(199, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Perusahaan"
        '
        'cbb_komoditi
        '
        Me.cbb_komoditi.BackColor = System.Drawing.SystemColors.Info
        Me.cbb_komoditi.DropDownHeight = 150
        Me.cbb_komoditi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_komoditi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbb_komoditi.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbb_komoditi.FormattingEnabled = True
        Me.cbb_komoditi.IntegralHeight = False
        Me.cbb_komoditi.Location = New System.Drawing.Point(202, 317)
        Me.cbb_komoditi.Name = "cbb_komoditi"
        Me.cbb_komoditi.Size = New System.Drawing.Size(327, 25)
        Me.cbb_komoditi.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(199, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Komoditi"
        '
        'txt_no_izin
        '
        Me.txt_no_izin.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_no_izin.Location = New System.Drawing.Point(202, 116)
        Me.txt_no_izin.Name = "txt_no_izin"
        Me.txt_no_izin.Size = New System.Drawing.Size(327, 23)
        Me.txt_no_izin.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(199, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "No.Izin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(199, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Tanggal"
        '
        'dt_tanggal
        '
        Me.dt_tanggal.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dt_tanggal.Location = New System.Drawing.Point(202, 162)
        Me.dt_tanggal.Name = "dt_tanggal"
        Me.dt_tanggal.Size = New System.Drawing.Size(327, 23)
        Me.dt_tanggal.TabIndex = 2
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Crimson
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(202, 348)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(327, 32)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
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
        'wiup_tambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(555, 406)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.dt_tanggal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_no_izin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbb_komoditi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbb_perusahaan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_luas)
        Me.Controls.Add(Me.cbb_lokasi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "wiup_tambah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wilayah Izin Usaha Pertambangan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_luas As TextBox
    Friend WithEvents cbb_lokasi As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbb_perusahaan As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbb_komoditi As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_no_izin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dt_tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
End Class
