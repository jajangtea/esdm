Public Class menu_utama
    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        If Panel1.Width = 50 Then
            PictureBox3.Visible = False
            Panel1.Width = 250
            Label1.ImageAlign = ContentAlignment.MiddleRight
            BunifuTransitionPanel.ShowSync(Panel1)
            BunifuTransitionLogo.ShowSync(PictureBox1)
        Else
            Panel1.Width = 50
            Panel1.Visible = False
            Label1.ImageAlign = ContentAlignment.MiddleCenter
            BunifuTransitionPanel.ShowSync(Panel1)
            BunifuTransitionLogo.Hide(PictureBox1)
            PictureBox3.Visible = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox3.Visible = False
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        '  Me.MinimizeBox = True
        Me.Close()
    End Sub

    Private Sub btn_perusahaan_Click(sender As System.Object, e As System.EventArgs) Handles btn_perusahaan.Click
        'PanelContainer.Controls.Add(Uc_perusahaan1)
        'Uc_perusahaan1.BringToFront()
        'Uc_perusahaan1.Show()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton2.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        form_lokasi.TopLevel = False
        PanelContainer.Controls.Add(form_lokasi)
        form_lokasi.BringToFront()
        form_lokasi.Show()
    End Sub

   
    Private Sub maksimal_Click(sender As System.Object, e As System.EventArgs) Handles maksimal.Click
        If Me.Width = 885 Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub kecilkan_Click(sender As System.Object, e As System.EventArgs) Handles kecilkan.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Uc_lokasi1_Load(sender As Object, e As EventArgs)

    End Sub
End Class
