Imports System.ComponentModel
Imports System.Threading
Public Class F_loading
    'Dim thead1 As Thread
    'Public Property close As Boolean = False
    'Private Sub F_load_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    Try
    '        Module1.close_loding = False
    '        Me.CheckForIllegalCrossThreadCalls = False
    '        Me.thead1 = New Thread(AddressOf Load_progress)
    '        Me.thead1.Start()
    '    Catch ex As Exception

    '    End Try
    'End Sub
    'Private Sub Load_progress()
    '    Try
    '        While (1 = 1)
    '            If Module1.close_loding Then
    '                'ปิดตอน message ขึ้น 
    '                Me.Dispose()
    '                Thread.Sleep(2000)
    '            End If
    '        End While
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub F_loading_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    '    Module1.close_loding = True
    'End Sub
End Class
'Public Class loadding
'    Dim thead2 As Thread
'    Dim f As New F_loading
'    Public Sub load()

'        thead2 = New Thread(AddressOf loadding_show)
'        thead2.Start()
'    End Sub
'    Private Sub loadding_show()
'        f.ShowDialog()
'    End Sub
'    Public Sub loadding_close()
'        f.Dispose()
'    End Sub
'End Class
