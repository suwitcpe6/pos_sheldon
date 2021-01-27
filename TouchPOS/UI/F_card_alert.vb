Public Class F_card_alert
    Private Sub Button_US3_Click(sender As Object, e As EventArgs) Handles Button_US3.Click
        Me.Dispose()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.BackColor = Color.FromArgb(255, 0, 0) Then
            Me.BackColor = Color.FromArgb(254, 240, 255)
            Label_US1.ForeColor = Color.DimGray
            Label_US2.ForeColor = Color.DimGray
            lbl_barcode.ForeColor = Color.DimGray

        Else
            Me.BackColor = Color.FromArgb(255, 0, 0)
            Label_US1.ForeColor = Color.White
            Label_US2.ForeColor = Color.White
            lbl_barcode.ForeColor = Color.White
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
        End If

    End Sub

    Private Sub F_card_alert_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Interval = 500

        Timer1.Enabled = True
        System.Media.SystemSounds.Asterisk.Play()
        'System.Media.SystemSounds.Beep.Play()
        'System.Media.SystemSounds.Hand.Play()
        'System.Media.SystemSounds.Question.Play()
    End Sub
End Class