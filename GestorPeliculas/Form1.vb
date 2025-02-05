Public Class Form1
    Private progressValue As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 50
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If progressValue < 100 Then
            progressValue += 1
            ProgressBar1.Value = progressValue

        Else
            Timer1.Stop()

            Login.Show()
            Me.Hide()

        End If
    End Sub
End Class
