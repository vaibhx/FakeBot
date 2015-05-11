Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()


    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If (ProgressBar1.Value = 100) Then
            Timer1.Stop()
            MsgBox("The requested balance has been added to your account")

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class
