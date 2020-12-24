Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Walker" Then
            Form2.Show()
            Hide()
        Else
            If TextBox1.Text = "Terrier" Then
                Terrier.Show()
                Hide()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
