Public Class FileDialog
    Public Shared Function FileDialog_img() As Image
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog
        openFileDialog1.Filter = "(*.bmp, *.jpg,*png)|*.bmp;*.jpg;*.png|All Files (.*)|*.*"
        openFileDialog1.FilterIndex = 1
        If openFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Return Image.FromFile(openFileDialog1.FileName)
        Else
            Return My.Resources._1024px_No_image_available_svg
        End If
    End Function
End Class
