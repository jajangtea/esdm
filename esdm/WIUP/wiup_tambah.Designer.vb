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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wiup_tambah))
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.cbbKota = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(34, 107)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(390, 83)
        Me.txtAlamat.TabIndex = 27
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(325, 196)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(99, 36)
        Me.btnSimpan.TabIndex = 26
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = False
        Me.btnSimpan.Visible = False
        '
        'cbbKota
        '
        Me.cbbKota.BackColor = System.Drawing.SystemColors.Info
        Me.cbbKota.DropDownHeight = 150
        Me.cbbKota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbKota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbKota.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbKota.FormattingEnabled = True
        Me.cbbKota.IntegralHeight = False
        Me.cbbKota.Location = New System.Drawing.Point(34, 48)
        Me.cbbKota.Name = "cbbKota"
        Me.cbbKota.Size = New System.Drawing.Size(390, 25)
        Me.cbbKota.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(53, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Alamat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(53, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Kabupaten/Kota"
        '
        'wiup_tambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 255)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.cbbKota)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "wiup_tambah"
        Me.Text = "wiup_tambah"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents cbbKota As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
