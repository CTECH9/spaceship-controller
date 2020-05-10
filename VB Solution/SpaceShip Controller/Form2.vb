Public Class Form2
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MsgBox("Firing Missile.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Missile information")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MsgBox("Firing Phasers.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Phaser Information")
    End Sub
End Class