Public Class Multidisplay
    Public Shared Function display2(frm As Object) As Boolean
        Try


            Dim screen As Screen
            'Show the form on second screen
            screen = Screen.AllScreens(1)
            frm.StartPosition = FormStartPosition.Manual
            frm.Location = screen.Bounds.Location + New Point(0, 0)
            frm.Show()
            Return True
        Catch ex As Exception
            Return False

        End Try
    End Function
End Class
