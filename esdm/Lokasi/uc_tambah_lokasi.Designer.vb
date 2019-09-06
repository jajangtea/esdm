<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_tambah_lokasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uc_tambah_lokasi))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnSimpan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbbKota = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kabupaten/Kota"
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
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(43, 101)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(256, 28)
        Me.BunifuMetroTextbox1.TabIndex = 3
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSimpan
        '
        Me.btnSimpan.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSimpan.BorderRadius = 0
        Me.btnSimpan.ButtonText = "Simpan"
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.DisabledColor = System.Drawing.Color.Gray
        Me.btnSimpan.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSimpan.Iconimage = CType(resources.GetObject("btnSimpan.Iconimage"), System.Drawing.Image)
        Me.btnSimpan.Iconimage_right = Nothing
        Me.btnSimpan.Iconimage_right_Selected = Nothing
        Me.btnSimpan.Iconimage_Selected = Nothing
        Me.btnSimpan.IconMarginLeft = 0
        Me.btnSimpan.IconMarginRight = 0
        Me.btnSimpan.IconRightVisible = True
        Me.btnSimpan.IconRightZoom = 0R
        Me.btnSimpan.IconVisible = True
        Me.btnSimpan.IconZoom = 90.0R
        Me.btnSimpan.IsTab = False
        Me.btnSimpan.Location = New System.Drawing.Point(198, 136)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSimpan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnSimpan.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSimpan.selected = False
        Me.btnSimpan.Size = New System.Drawing.Size(101, 31)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Textcolor = System.Drawing.Color.White
        Me.btnSimpan.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Alamat"
        '
        'cbbKota
        '
        Me.cbbKota.DropDownHeight = 150
        Me.cbbKota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbKota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbKota.FormattingEnabled = True
        Me.cbbKota.IntegralHeight = False
        Me.cbbKota.Location = New System.Drawing.Point(43, 51)
        Me.cbbKota.Name = "cbbKota"
        Me.cbbKota.Size = New System.Drawing.Size(256, 21)
        Me.cbbKota.TabIndex = 8
        '
        'uc_tambah_lokasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cbbKota)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uc_tambah_lokasi"
        Me.Size = New System.Drawing.Size(629, 269)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnSimpan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents cbbKota As ComboBox
End Class
