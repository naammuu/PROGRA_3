Public Class frmInicio
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            frmMenu.Show()
        End If

        If ProgressBar1.Value <= 90 Then
            ProgressBar1.Value = ProgressBar1.Value + 10
        End If

    End Sub

    Private Sub pnIntro_Paint(sender As Object, e As PaintEventArgs) Handles pnIntro.Paint

    End Sub
End Class