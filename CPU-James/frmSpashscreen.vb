Public Class frmSplashScreen
    Private Sub FrmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrStart.Start()
    End Sub

    Private Sub TmrStart_Tick(sender As Object, e As EventArgs) Handles tmrStart.Tick
        If ProgressBar1.Value >= 100 And GV.Load = True Then
            tmrStart.Stop()
            Me.Close()
        Else
            ProgressBar1.Value += 1
        End If
    End Sub

End Class