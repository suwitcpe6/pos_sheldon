Imports System.Reflection
Public Class DataGridView_US
    Inherits DataGridView

    Sub New()
        US_Default()
    End Sub
    Private Sub US_Default()
        'Me.Font = Center.Us_font

        Dim HeaderStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        HeaderStyle.Font = Center.Us_font
        HeaderStyle.BackColor = Color.SteelBlue 'Color.LightSteelBlue    
        HeaderStyle.ForeColor = Color.White
        HeaderStyle.SelectionBackColor = Color.DodgerBlue
        HeaderStyle.SelectionForeColor = Color.White



        Dim DefaultCellStyle_ As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        DefaultCellStyle_.Font = Center.Us_font
        DefaultCellStyle_.BackColor = Color.WhiteSmoke
        DefaultCellStyle_.ForeColor = Color.Blue  ' Color.CadetBlue
        DefaultCellStyle_.SelectionBackColor = Color.LightSkyBlue
        DefaultCellStyle_.SelectionForeColor = Color.Black


        With Me
            .BorderStyle = BorderStyle.None
            .BackgroundColor = Color.White
            .AllowUserToAddRows = True
            .AllowUserToDeleteRows = True
            '.AlternatingRowsDefaultCellStyle = AlternateStyle
            .RowHeadersVisible = False
            .ColumnHeadersDefaultCellStyle = HeaderStyle
            .EnableHeadersVisualStyles = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .DefaultCellStyle = DefaultCellStyle_


            .SelectionMode = DataGridViewSelectionMode.CellSelect
            '.AutoSizeColumnsMode = 

            .GridColor = Color.WhiteSmoke 'LightSteelBlue
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 35
            .RowTemplate.Height = 30
            .EditMode = DataGridViewEditMode.EditOnEnter

        End With
        EnableDoubleBuffered(Me)
    End Sub
    Public Sub me_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles Me.CurrentCellDirtyStateChanged
        If sender.IsCurrentCellDirty Then
            sender.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Public Shared Sub EnableDoubleBuffered(ByVal dgv As DataGridView)
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered",
                                                     BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, True, Nothing)
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
