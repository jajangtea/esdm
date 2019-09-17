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
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        form_perusahaan.TopLevel = False
        PanelContainer.Controls.Add(form_perusahaan)
        form_perusahaan.BringToFront()

        form_perusahaan.Show()
        form_perusahaan.Dock = DockStyle.Fill
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton2.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        lokasi_table.TopLevel = False
        PanelContainer.Controls.Add(lokasi_table)
        lokasi_table.BringToFront()

        lokasi_table.Show()
        lokasi_table.Dock = DockStyle.Fill
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

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        wiup_table.TopLevel = False
        PanelContainer.Controls.Add(wiup_table)
        wiup_table.BringToFront()

        wiup_table.Show()
        wiup_table.Dock = DockStyle.Fill
    End Sub
End Class
