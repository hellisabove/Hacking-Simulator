Public Class ControlCCTV
    Private Sub ControlCCTV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MsgBox("Cameras Hacked!")
            CameraFootage.Show()
            Hide()
        End If
    End Sub
End Class