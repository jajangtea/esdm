Public Class form_perusahaan
    Dim ucperusahaan As New uc_perusahaan
    Private Sub Form_perusahaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        PanelContainer.Controls.Add(ucperusahaan)
        ucperusahaan.BringToFront()
        ucperusahaan.Show()
    End Sub

    Private Sub PanelContainer_Paint(sender As Object, e As PaintEventArgs) Handles PanelContainer.Paint

    End Sub
End Class