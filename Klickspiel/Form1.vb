Public Class Form1

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim rnd As New Random
        Button1.Location = New Point(rnd.Next(1, 270), rnd.Next(1, 270))
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Timer1.Interval = 50 Then
            MsgBox("Glückwunsch, Sie haben es geschafft")
        End If
        MsgBox("Level up. SCHNELLER!")
        Timer1.Interval -= 50 : ToolStripLabel1.Text += 50
    End Sub
End Class
