Public Class Form2

    Dim Misslecount As Integer = 15

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Misslecount > 0 Then
            MsgBox("Firing missile.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Missile information")
            Misslecount = Misslecount - 1
            Label4.Text = Misslecount
        Else
            MsgBox("Error: No missles remaining!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Missle Information")
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MsgBox("Firing Phasers.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Phaser Information")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class