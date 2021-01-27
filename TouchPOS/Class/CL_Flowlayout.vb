Imports Control_us
Public Class CL_Flowlayout
    Public Shared Property SHOP_Width As Integer = 150
    Public Shared Property SHOP_Height As Integer = 50
    Public Shared Property SHOP_select As Color = Color.DodgerBlue
    Public Shared Property SHOP_Unselect As Color = Color.DarkGreen
    Public Shared Property SHOP_ForeColor As Color = Color.White
    Public Shared Property SHOP_Font As Font = New System.Drawing.Font("Leelawadee UI", 13.0!)




    Public Shared Property GROUP_Width As Integer = 150
    Public Shared Property GROUP_Height As Integer = 50
    Public Shared Property GROUP_select As Color = Color.DodgerBlue
    Public Shared Property GROUPB_Unselect As Color = Color.DarkSlateGray
    Public Shared Property GROUP_ForeColor As Color = Color.White
    Public Shared Property GROUP_Font As Font = New System.Drawing.Font("Leelawadee UI", 13.0!)



    Public Shared Property Items_width As Integer = 145
    Public Shared Property Items_Height As Integer = 45
    Public Shared Property Items_select As Color = Color.DodgerBlue
    Public Shared Property Items_unselect As Color = Color.FromArgb(125, 236, 219) ' Color.Beige
    Public Shared Property Items_ForeColor As Color = Color.Black
    Public Shared Property Items_Font As Font = New System.Drawing.Font("Leelawadee UI", 12.0!)








    Public Shared Property payment_Width As Integer = 225
    Public Shared Property payment_Height As Integer = 74
    Public Shared Property payment_ForeColor As Color = Color.DarkOrange
    Public Shared Property payment_BorderColor As Color = Color.DarkOrange
    Public Shared Property payment_backcolor As Color = Color.Azure

    Public Shared Property payment_Font As Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
    'Public Sub fill_BTN(ByVal value As List(Of SHOP_ModelS.Model), ByRef Flo As FlowLayoutPanel_US)
    '    Try
    '        Flo.Controls.Clear()
    '        Dim btn As Button
    '        For Each val As SHOP_ModelS.Model In value
    '            btn = New Button

    '            btn.Name = val.SHOPID
    '            btn.Text = val.SHOPNAME
    '            btn.BackColor = Me.BackColor
    '            btn.ForeColor = Me.ForeColor
    '            btn.FlatAppearance.BorderColor = System.Drawing.Color.White
    '            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    '            btn.Font = Me.Font
    '            btn.Size = New System.Drawing.Size(154, 72)
    '            btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '            btn.UseVisualStyleBackColor = False

    '            AddHandler btn.Click, Sub() btn_click(btn, Flo)
    '            Flo.Controls.Add(btn)
    '        Next
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    ''Private Sub btn_click(sender As Object, e As EventArgs)
    'Private Sub btn_click(btn As Button, Flo As FlowLayoutPanel_US)
    '    Try


    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub
End Class
