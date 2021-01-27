﻿Public Class Combobox_US
    Inherits ComboBox
    Sub New()
        US_Default()
    End Sub
    Private Sub US_Default()
        Me.Font = Center.Us_font
        'Me.BackColor = Color.Green ' Color.Orange
        'Me.ForeColor = Color.White
        'Me.Width = 120
        'Me.Height = 40
        'Me.FlatStyle = FlatStyle.Flat
        'Me.FlatAppearance.BorderColor = Color.White
    End Sub
    Private Sub US_Reconfig()
        'Me.Font = New System.Drawing.Font(""Leelawadee UI"", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        'Me.BackColor = Color.Green ' Color.Orange
        'Me.ForeColor = Color.White
        'Me.Width = 120
        'Me.Height = 40
        'Me.FlatStyle = FlatStyle.Flat
        'Me.FlatAppearance.BorderColor = Color.White
    End Sub
    Dim Err As New ErrorProvider
    Public Sub UCSet_err(value As String)
        Me.Err.SetError(Me, value)
    End Sub
    Public Sub UCClear_err()
        Me.Err.Clear()
    End Sub


    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Try
            MyBase.WndProc(m)

            'MsgBox(m.Msg)

            Dim a = Me.Tag
            Select Case m.Msg

                Case 129
                    US_Reconfig()
                Case &H7, &H8, &H200, &H2A3
                    'US_Reconfig()
            End Select
        Catch ex As Exception

        End Try
    End Sub
End Class
