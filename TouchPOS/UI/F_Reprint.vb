Public Class F_Reprint
    Private Sub Btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub F_Reprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txt_docno.Text = ""
    End Sub
End Class