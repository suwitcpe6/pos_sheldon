Imports MD
Imports Newtonsoft.Json
Imports Control_us
Public Class F_Approver
    Private Sub F_Approver_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.txt_barcode.Text = ""
        Me.txt_barcode.Focus()
        Timer1.Enabled = True
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Dispose()
    End Sub



    Private Function appover(barcode As String) As Boolean
        Try

            'Dim ret2 As New VoidModels.value
            'Dim json2 = New API(Center.Data_Config.API).GETSON(String.Format(Center.Link_API.Get_API.Sel_Void_EWALLET, Me.voidtype, Center.data_profile.SHOPID, barcode))
            'ret2 = (JsonConvert.DeserializeObject(Of VoidModels.value)(json2))
            'If ret2.Respon.Result Then
            '    Me.DGV_items.DataSource = ret2.Data
            '    If Me.DGV_items.RowCount > 0 Then
            '        If (Me.voidtype = CL_constan.Void_TYPE.CANCEL) Or (Me.voidtype = CL_constan.Void_TYPE.Verify_slip) Then
            '            For i As Integer = 0 To DGV_items.RowCount - 1
            '                DGV_items.Rows(i).Cells("select").Value = True
            '            Next
            '            DGV_items.ReadOnly = True
            '            txt_Amount.Text = ret2.Data.Sum(Function(s) s.MRTAMOUNT).ToString("#,###.00")
            '        End If
            'Return True
            '    Else
            '        Messages.Texts(Me.Text, "ไม่พบข้อมูล หรือ มีการทำรายการแล้ว", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
            '        Return False
            '    End If
            'Else
            '    If ret2.Respon.SystemErrorMessage <> "" Then
            '        Throw New Exception(ret2.Respon.SystemErrorMessage.ToString)
            '    Else
            '        Messages.Texts(Me.Text, ret2.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
            '    End If
            '    Return False
            'End If



            Dim a = New MD.Barcode().BarcodeChkDigit(txt_barcode.Text, txt_barcode.Text.Length - 1)
            Dim b = Microsoft.VisualBasic.Right(txt_barcode.Text, 1)
            If b <> a Then
                'Messages.Texts("การแจ้งเตือน", "รหัสอนุมัติไม่ถูกต้อง", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                display("รหัสอนุมัติไม่ถูกต้อง")
                Return False
            End If

            Dim bcode As String = barcode.Substring(0, 2)
            Dim void As String = barcode.Substring(2, 4)
            Dim runnumner As String = barcode.Substring(6, 4)
            Dim chk As String = barcode.Substring(10, 1)

            If CInt(runnumner) >= 1 And CInt(runnumner) < 10000 Then
                If bcode = Center.data_profile.BRNID And void = "VOID" Then
                    Return True
                Else
                    'Messages.Texts("การแจ้งเตือน", "รหัสอนุมัติไม่ถูกต้อง", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                    display("รหัสอนุมัติไม่ถูกต้อง")
                    Return False
                End If

            Else
                'Messages.Texts("การแจ้งเตือน", "รหัสอนุมัติไม่ถูกต้อง", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                display("รหัสอนุมัติไม่ถูกต้อง")
                Return False
            End If
        Catch ex As Exception
            display("รหัสอนุมัติไม่ถูกต้อง")
            Return False
        End Try
    End Function
    Private Function display(val As String)
        txt_display.Text = val
        txt_display.BackColor = Color.Red
        txt_display.ForeColor = Color.White
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txt_barcode.Focus()
        txt_barcode.Text = ""
    End Sub


    Private Sub txt_barcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_barcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Timer1.Enabled = False
            If appover(Me.txt_barcode.Text) Then
                Me.DialogResult = DialogResult.OK
                Me.Dispose()
            Else
                txt_barcode.Text = ""
            End If
            Timer1.Enabled = True
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub
End Class