Public Class F_pass
    Dim default_pass = "9753"
    Private Sub F_pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = F_Main_Sale.Icon
    End Sub

    Private Sub Txt_api_TextChanged(sender As Object, e As EventArgs) Handles txt_api.TextChanged
        If txt_api.Text = default_pass Then
            Me.DialogResult = DialogResult.OK
            Me.Dispose()
        End If
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_0.Click, btn_1.Click, btn_2.Click, btn_3.Click, btn_4.Click, btn_5.Click, btn_6.Click, btn_7.Click, btn_8.Click, btn_9.Click
        Me.txt_api.Text &= sender.Text
    End Sub

    Private Sub btn_C_Click(sender As Object, e As EventArgs) Handles btn_C.Click
        Me.Close()
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Me.txt_api.Text = ""
    End Sub
End Class