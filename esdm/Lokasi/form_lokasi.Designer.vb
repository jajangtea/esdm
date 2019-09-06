<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_lokasi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Uc_lokasi1 = New esdm.uc_lokasi()
        Me.SuspendLayout()
        '
        'Uc_lokasi1
        '
        Me.Uc_lokasi1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Uc_lokasi1.Location = New System.Drawing.Point(0, 0)
        Me.Uc_lokasi1.Name = "Uc_lokasi1"
        Me.Uc_lokasi1.Size = New System.Drawing.Size(631, 424)
        Me.Uc_lokasi1.TabIndex = 0
        '
        'form_lokasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(631, 424)
        Me.Controls.Add(Me.Uc_lokasi1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form_lokasi"
        Me.Text = "form_lokasi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Uc_lokasi1 As uc_lokasi
End Class
