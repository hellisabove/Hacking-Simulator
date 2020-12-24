Public Class DisableAlarm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MsgBox("Alarms disabled!")
            Close()
        End If
    End Sub

    Private Sub DisableAlarm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class