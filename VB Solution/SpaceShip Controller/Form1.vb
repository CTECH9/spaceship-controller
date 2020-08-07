Public Class Form1
    Dim Hyperspace As Integer = 0
    Dim Porthatch As Integer = 0
    Dim Starboardhatch As Integer = 0
    Dim Innerairlock As Integer = 0
    Dim Outerairlock As Integer = 0
    Dim Pressurization As Integer = 1
    Dim Afterburners As Integer = 0
    Dim Autopilot As Integer = 0
    Dim Engine As Integer = 0

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Form2.Hide()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Engine = 0 Then
            MsgBox("You must start the engine!", 16, "Error")
        Else
            If Hyperspace = 0 Then
                If Afterburners = 1 Then
                    MsgBox("Error- You cannot activate hyperspace if the afterburners are on.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                Else
                    Hyperspace = 1
                    MsgBox("Activating Hyperspace. Prepare for intense gravity.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
                End If
            Else
                Hyperspace = 0
                MsgBox("Deactivating hyperspace", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Porthatch = 0 Then
            MsgBox("Opening port hatch.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
            Porthatch = 1
        Else
            MsgBox("Closing port hatch.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
            Porthatch = 0
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If Starboardhatch = 0 Then
            MsgBox("Opening starboard hatch.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
            Starboardhatch = 1
        Else
            MsgBox("Closing starboard hatch.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
            Starboardhatch = 0
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If Innerairlock = 0 Then
            If Outerairlock = 1 Then
                Dim Result As Integer = MsgBox("You are about to open bolth airlock doors. Doing so will expose the ship to the vacumm of space, thus sucking all air (including oxygen) from the spacecraft. Are you sure you want to proceed?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Warning!")
                If Result = DialogResult.Yes Then
                    Dim Result2 As Integer = MsgBox("This is your final desicion. Are you sure you want to depressurize the entire vessel?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Warning!!")
                    If Result2 = DialogResult.Yes Then
                        Innerairlock = 1
                        MsgBox("Bolth airlock doors openned. Cabin depressurized.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Information")
                    End If
                End If
            Else
                Innerairlock = 1
                MsgBox("Opening inner airlock door.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
            End If
        Else
            Innerairlock = 0
            MsgBox("Closing inner airlock door.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If Outerairlock = 0 Then
            If Innerairlock = 1 Then
                Dim Result As Integer = MsgBox("You are about to open bolth airlock doors. Doing so will expose the ship to the vacumm of space, thus sucking all air (including oxygen) from the spacecraft. Are you sure you want to proceed?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Warning!")
                If Result = DialogResult.Yes Then
                    Dim Result2 As Integer = MsgBox("This is your final desicion. Are you sure you want to depressurize the entire vessel?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Warning!!")
                    If Result2 = DialogResult.Yes Then
                        Outerairlock = 1
                        MsgBox("Bolth airlock doors openned. Cabin depressurized.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
                    End If
                End If
            Else
                Outerairlock = 1
                MsgBox("Opening outer airlock door.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
            End If
        Else
            Outerairlock = 0
            MsgBox("Closing outer airlock door.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
        End If
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Form2.Close()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If Pressurization = 1 Then
            If Innerairlock = 1 Then
                MsgBox("Error- You cannot depressurize the airlock with the inner door open! If you need to depressurize the cabin, open bolth airlock doors at once.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            Else
                Pressurization = 0
                MsgBox("Airlock depressurized. You may now open the outer airlock door.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
            End If
        Else
            If Outerairlock = 1 Then
                MsgBox("Error- You cannot pressurize the airlock with the outer airlock door open. You must close the outer door, then pressurize the airlock.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            Else
                Pressurization = 1
                MsgBox("Airlock pressurized. You may now open the inner airlock door.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
            End If
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click

        If Engine = 0 Then
            MsgBox("You must start the engine!", 16, "Error")
        Else
            If Afterburners = 0 Then
                If Hyperspace = 1 Then
                    MsgBox("Error- You cannot turn on the afterburners with hyperspace on.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                Else
                    Afterburners = 1
                    MsgBox("Activating afterburners.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
                End If
            Else
                Afterburners = 0
                MsgBox("Deactivating afterburners.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
            End If
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If Engine = 0 Then
            MsgBox("You must start the engine!", 16, "Error")
        Else
            If Autopilot = 0 Then
                Dim input As String = InputBox("What course should the ship take?", "Autopilot course")
                Autopilot = 1
                MsgBox("Set course for " & input & ".", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Course set")
            Else
                Autopilot = 0
                MsgBox("Autopilot off.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
            End If
        End If
    End Sub

    Private Sub Button11_Click_1(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Dim Result2 As Integer = MsgBox("Self destruct ship. Are you sure?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Warning")
        If Result2 = DialogResult.Yes Then
            Dim Result3 As Integer = MsgBox("Self Destruct SpaceShip. Are you really sure??", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Warning!!")
            If Result3 = MsgBoxResult.Yes Then
                MsgBox("Self-Destructing vessel. Evacuate immediately.")
                Form2.Close()
                Me.Close()
            Else
                MsgBox("Okay.")
            End If
        Else
            MsgBox("Okay.")
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Engine = 0 Then
            Engine = 1
            My.Computer.Audio.Play("enginestart.wav", AudioPlayMode.Background)
            MsgBox("Engine starting.")
        Else
            Engine = 0
            My.Computer.Audio.Play("enginestop.wav", AudioPlayMode.Background)
            MsgBox("Engine stopping.")
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form4.Show()
    End Sub
End Class

