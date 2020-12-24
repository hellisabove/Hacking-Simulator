Public Class Terrier
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisableAlarm.Show()
        Hide()
        DisableAlarm.Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HackPC.Show()
        Hide()
        HackPC.Timer1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ControlCCTV.Show()
        Hide()
        ControlCCTV.Timer1.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        About.Show()
        Hide()
    End Sub
End Class