Imports MD
Imports Newtonsoft.Json
Imports Control_us
Public Class F_Void
    Dim voidtype As String
    Dim from_payment = False
    Dim barcode As String = ""
    Sub New(voidtype As String, from_payment As Boolean, Optional ByVal barcode As String = "")

        ' This call is required by the designer.
        InitializeComponent()
        Me.voidtype = voidtype
        Me.from_payment = from_payment
        Me.barcode = barcode
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub F_Refund_Load(sender As Object, e As EventArgs) Handles Me.Load

        setEvent()

        Timer1.Enabled = True
        Gencolumn_Normal()
        If (Me.voidtype = CL_constan.Void_TYPE.CANCEL) Then
            Label_US1.Text = "Cancel"
        ElseIf (Me.voidtype = CL_constan.Void_TYPE.REFUND) Then
            Label_US1.Text = "Refund"
        ElseIf (Me.voidtype = CL_constan.Void_TYPE.Verify_slip) Then
            Label_US1.Text = "Verify slip"
            btn_ok.Text = "ยืนยัน"
        End If


        If Me.from_payment Then
            If Not Loaddatata(Me.barcode) Then
                Me.DialogResult = DialogResult.No
                Me.Dispose()

            Else
                If Savedata() Then
                    Me.DialogResult = DialogResult.OK
                    Me.Dispose()
                Else '
                    Me.DialogResult = DialogResult.No
                    Me.Dispose()
                End If
            End If

        End If
        txt_barcode.Clear()
    End Sub
    Private Sub setEvent()
        'text KeyDown
        AddHandler Me.txt_barcode.KeyDown, AddressOf Ev_Text_KeyDown

        '''text Text_Changed
        'AddHandler Me.txt_amount_remain.TextChanged, AddressOf Ev_Text_Changed
        'AddHandler Me.txt_pay_Amount.TextChanged, AddressOf Ev_Text_Changed

        'btn Click
        AddHandler Me.btn_ok.Click, AddressOf Ev_Btn_Click
        AddHandler Me.btn_close.Click, AddressOf Ev_Btn_Click


        'dgv
        AddHandler Me.DGV_items.CellClick, AddressOf DGV_CellClick

    End Sub
#Region "Event"
    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            If (Me.voidtype = CL_constan.Void_TYPE.REFUND) Then
                If DGV_items.Rows(e.RowIndex).Cells("select").Value = True Then
                    DGV_items.Rows(e.RowIndex).Cells("select").Value = False
                Else
                    DGV_items.Rows(e.RowIndex).Cells("select").Value = True
                End If
                Dim MRTAMOUNT As Double
                For i As Integer = 0 To Me.DGV_items.RowCount - 1
                    If DGV_items.Rows(i).Cells("select").Value = True Then
                        MRTAMOUNT += DGV_items.Rows(i).Cells("MRTAMOUNT").Value
                    End If
                Next
                txt_Amount.Text = MRTAMOUNT.ToString("#,###.00")
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Ev_Text_KeyDown(sender As Object, e As KeyEventArgs)
        Try



            Select Case sender.name
                Case txt_barcode.Name


                    If e.KeyCode = Keys.Enter Then
                        Timer1.Enabled = False
                        sender.Enabled = False
                        Loaddatata(sender.text)
                        If Me.DGV_items.Rows.Count > 0 Then
                            Savedata()
                        End If

                        sender.Enabled = True
                        sender.text = ""
                        Timer1.Enabled = True
                    End If



            End Select
        Catch ex As Exception
        Finally

        End Try
    End Sub

    Private Sub Ev_Btn_Click(sender As Object, e As EventArgs)


        Select Case sender.name
            Case btn_ok.Name
                If Me.voidtype = CL_constan.Void_TYPE.Verify_slip Then
                    verrify()
                Else
                    Savedata()
                End If

            Case btn_close.Name

                Me.Dispose()
                Me.Close()
        End Select

        Timer1.Enabled = True
    End Sub

#End Region
    Public Sub Gencolumn_Normal()
        Try
            DGV_items.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))

            DGV_items.DefaultCellStyle.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))

            Me.DGV_items.AutoGenerateColumns = False
            Me.DGV_items.Columns.Clear()
            Dim Col As New DataGridViewTextBoxColumn
            'Dim btn As New DataGridViewButtonColumn
            Dim Chk As New DataGridViewCheckBoxColumn
            Dim read As Boolean = True

            Dim colvis As Boolean = False
            If (Me.voidtype = CL_constan.Void_TYPE.CANCEL) Or (Me.voidtype = CL_constan.Void_TYPE.Verify_slip) Then
                colvis = False
            Else
                colvis = True
            End If

            Chk = New DataGridViewCheckBoxColumn
            Chk.HeaderText = "  เลือก"
            Chk.Width = 60
            Chk.Visible = True
            Chk.ReadOnly = read
            Chk.DataPropertyName = "select"
            Chk.Name = "select"
            Me.DGV_items.Columns.Add(Chk)


            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "บาร์โค๊ด"
            Col.Width = 160
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "BARCODE"
            Col.Name = "BARCODE"
            Me.DGV_items.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "เลขที่ใบขาย"
            'Col.Width = 200
            Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "MRTSLIPNO"
            Col.Name = "MRTSLIPNO"
            Me.DGV_items.Columns.Add(Col)



            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ลำดับ"
            Col.Width = 50
            Col.Visible = colvis
            Col.ReadOnly = read
            Col.DataPropertyName = "SEQ"
            Col.Name = "SEQ"
            Me.DGV_items.Columns.Add(Col)


            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "foodid"
            Col.Width = 100
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "foodid"
            Col.Name = "foodid"
            Me.DGV_items.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "รายการอาหาร"
            'Col.Width = 200
            Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Col.Visible = colvis
            Col.ReadOnly = read
            Col.DataPropertyName = "FOODNAME"
            Col.Name = "FOODNAME"
            Me.DGV_items.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ราคา"
            Col.Width = 70
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "MRTAMOUNT"
            Col.Name = "MRTAMOUNT"
            Me.DGV_items.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "CARDTENDOR"
            Col.Width = 100
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "CARDTENDOR"
            Col.Name = "CARDTENDOR"
            Me.DGV_items.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ประเภทการจ่าย"
            Col.Width = 130
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "CARDTENDOR_NAME"
            Col.Name = "CARDTENDOR_NAME"
            Me.DGV_items.Columns.Add(Col)



            'Me.dt_card.Rows.Clear()
            'Me.dt_card.Columns.Clear()
            'With Me.dt_card.Columns
            '    .Add("SEQ")
            '    .Add("BARCODE")
            '    .Add("PAYTYPE")
            '    .Add("CUSED")
            '    .Add("CUSED1")
            '    .Add("MRTAMOUNT", GetType(Decimal))
            '    .Add("CBALANCE", GetType(Decimal))
            '    .Add("CBALANCEREMAIN", GetType(Decimal))
            'End With
            'DGV_Card_Normal.DataSource = Me.dt_card

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try

    End Sub
    Private Function Loaddatata(barcode As String) As Boolean
        Try

            If voidtype = CL_constan.Void_TYPE.Verify_slip Then


                'Dim val_payment As New CPN_Payment_Hub.value_Models
                'Dim cph As New CPN_Payment_Hub()
                'val_payment.barcode = val_SALE_void(0).BARCODE
                'val_payment.MRTSLIPNO = val_SALE_void(0).MRTSLIPNO
                'val_payment.Payment_code = val_SALE_void(0).CARDTENDOR
                'val_payment.totalPrice = txt_Amount.Text

                'Dim result_Payment_call As New ConfirmpayModels_log

                'result_Payment_call = cph.payment(cph.case_payment.Cancel, val_payment)




            Else

                Dim ret2 As New VoidModels.value
                Dim json2 = New API(Center.Data_Config.API).GETSON(String.Format(Center.Link_API.Get_API.Sel_Void_EWALLET, Me.voidtype, Center.data_profile.SHOPID, barcode))
                ret2 = (JsonConvert.DeserializeObject(Of VoidModels.value)(json2))
                If ret2.Respon.Result Then
                    Me.DGV_items.DataSource = ret2.Data
                    If Me.DGV_items.RowCount > 0 Then
                        If (Me.voidtype = CL_constan.Void_TYPE.CANCEL) Or (Me.voidtype = CL_constan.Void_TYPE.Verify_slip) Then
                            For i As Integer = 0 To DGV_items.RowCount - 1
                                DGV_items.Rows(i).Cells("select").Value = True
                            Next
                            DGV_items.ReadOnly = True
                            txt_Amount.Text = ret2.Data.Sum(Function(s) s.MRTAMOUNT).ToString("#,###.00")
                        End If
                        Return True
                    Else
                        Messages.Texts(Me.Text, "ไม่พบข้อมูล หรือ มีการทำรายการแล้ว", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                        Return False
                    End If
                Else
                    If ret2.Respon.SystemErrorMessage <> "" Then
                        Throw New Exception(ret2.Respon.SystemErrorMessage.ToString)
                    Else
                        Messages.Texts(Me.Text, ret2.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                    End If
                    Return False
                End If
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
            Return False
        End Try
    End Function
    Private Function Savedata() As Boolean
        Try

            Dim cph As New CPN_Payment_Hub()
            Dim val_SALE_void As New List(Of VoidModels.SALE_void)
            Dim valadd As VoidModels.SALE_void

            For Each grow As DataGridViewRow In Me.DGV_items.Rows
                If grow.Cells("select").Value Then
                    valadd = New VoidModels.SALE_void
                    valadd.SHOPID = Center.data_profile.SHOPID
                    valadd.BARCODE = grow.Cells("BARCODE").Value
                    valadd.MRTSLIPNO = grow.Cells("MRTSLIPNO").Value
                    valadd.SEQ = grow.Cells("SEQ").Value
                    valadd.foodid = grow.Cells("foodid").Value
                    valadd.FOODNAME = grow.Cells("FOODNAME").Value
                    valadd.CARDTENDOR = grow.Cells("CARDTENDOR").Value
                    valadd.Voidtype = Me.voidtype

                    val_SALE_void.Add(valadd)
                End If
            Next

            If val_SALE_void.Count <= 0 Then
                'Messages.Texts(Me.Text, "กรุณาเลือกรายการ Void", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Return False
            End If


            Dim chkdata = val_SALE_void.Select(Function(s) s.MRTSLIPNO).Distinct()
            If chkdata.Count > 1 Then
                Messages.Texts(Me.Text, "ข้อมูลทำรายการไม่ถูกต้องพบ " & chkdata.Count & " บิลขายในรหัสชำระเงิน " & val_SALE_void(0).BARCODE, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                Return False
            End If


            Dim f_app As New F_Approver
            If f_app.ShowDialog <> DialogResult.OK Then
                Return False
            End If

            ' Gen voidno    ' Gen voidno     ' Gen voidno     ' Gen voidno     ' Gen voidno     ' Gen voidno  
            ' Gen voidno    ' Gen voidno     ' Gen voidno     ' Gen voidno     ' Gen voidno     ' Gen voidno  
            ' Gen voidno    ' Gen voidno     ' Gen voidno     ' Gen voidno     ' Gen voidno     ' Gen voidno  

            Dim void_id As String = ""
            Dim ret2 As New VoidModels.value
            Dim json2 = New API(Center.Data_Config.API).GETSON(String.Format(Center.Link_API.Get_API.GetVOIDNO, Center.data_profile.SHOPID))
            ret2 = (JsonConvert.DeserializeObject(Of VoidModels.value)(json2))
            If ret2.Respon.Result Then
                void_id = ret2.Respon.Result_value
            Else
                If ret2.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret2.Respon.SystemErrorMessage.ToString)
                Else
                    Messages.Texts(Me.Text, ret2.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                    Return False
                End If
            End If


            ' Gen voidno    ' Gen voidno     ' Gen voidno     ' Gen voidno     ' Gen voidno     ' Gen voidno  
            ' Gen voidno    ' Gen voidno     ' Gen voidno     ' Gen voidno     ' Gen voidno     ' Gen voidno  
            ' Gen voidno    ' Gen voidno     ' Gen voidno     ' Gen voidno     ' Gen voidno     ' Gen voidno  
            ' Gen voidno    ' Gen voidno     ' Gen voidno     ' Gen voidno     ' Gen voidno     ' Gen voidno  




            Dim val_payment As New CPN_Payment_Hub.value_Models

            val_payment.barcode = val_SALE_void(0).BARCODE
            val_payment.MRTSLIPNO = val_SALE_void(0).MRTSLIPNO
            val_payment.Payment_code = val_SALE_void(0).CARDTENDOR
            val_payment.totalPrice = txt_Amount.Text
            val_payment.voidid = void_id

            Dim result_Payment_call As New ConfirmpayModels_log
            If voidtype = CL_constan.Void_TYPE.CANCEL Then
                result_Payment_call = cph.payment(cph.case_payment.Cancel, val_payment)
            Else
                result_Payment_call = cph.payment(cph.case_payment.Refund, val_payment)
            End If



            If Not IsNothing(result_Payment_call) Then

                If result_Payment_call.result_code = "0000" Then

                    For Each val As VoidModels.SALE_void In val_SALE_void
                        val.CN_DOCNO = result_Payment_call.PAYMENT_CODE
                        val.VOIDNO = void_id
                    Next
                    'For i As Integer = 1 To 3

                    Dim json As String = JsonConvert.SerializeObject(val_SALE_void)
                    Dim siteUri As New Uri(Center.Data_Config.API + Center.Link_API.Post_API.Sale_VOID)
                    Dim ret = New API(Center.Data_Config.API).POSTResponse(siteUri, json, "POST", "")
                    Dim retValue As VoidModels.value = JsonConvert.DeserializeObject(Of VoidModels.value)(ret)
                    If retValue.Respon.Result Then
                        FPrint_CN(void_id)
                        'Messages.Texts("การแจ้งเตือน", "ทำรายการสำเร็จ : " & result_Payment_call.PAYMENT_CODE, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)

                        Me.DialogResult = DialogResult.Cancel
                        Me.Dispose()
                        'Exit For
                    Else
                        'If i >= 3 Then
                        If retValue.Respon.SystemErrorMessage <> "" Then
                            'จากระบบ
                            Throw New Exception(retValue.Respon.SystemErrorMessage)
                        Else
                            Messages.Texts(Me.Text, retValue.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                        End If
                        'End If
                    End If
                    'System.Threading.Thread.Sleep(3000)
                    'Next
                Else

                    Messages.Texts("การแจ้งเตือนจาก Payment Hub", result_Payment_call.PAY_Remark, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                    Return False
                End If
            Else
                Messages.Texts("การแจ้งเตือน", "ทำรายการจ่ายเงินไม่สำเร็จ กรุณาจ่ายใหม่อีกครั้ง หรือกด Inquiry เพื่อตรวจสอบ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Return False
            End If

            Return True
        Catch ex As Exception
            If ex.Message = "ยังไม่พบรายการจ่ายเงิน" Then
                Messages.Texts("การแจ้งเตือน", ex.Message, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
            Else
                Msg_err.Show_Err(ex, "Payment_center.Inquiry_call")
            End If
        End Try
    End Function
    Private Function verrify()
        Try

            Dim cph As New CPN_Payment_Hub()
            Dim val_SALE_void As New List(Of VoidModels.SALE_void)
            Dim valadd As VoidModels.SALE_void

            For Each grow As DataGridViewRow In Me.DGV_items.Rows
                If grow.Cells("select").Value Then
                    valadd = New VoidModels.SALE_void
                    valadd.SHOPID = Center.data_profile.SHOPID
                    valadd.BARCODE = grow.Cells("BARCODE").Value
                    valadd.MRTSLIPNO = grow.Cells("MRTSLIPNO").Value
                    valadd.SEQ = grow.Cells("SEQ").Value
                    valadd.foodid = grow.Cells("foodid").Value
                    valadd.FOODNAME = grow.Cells("FOODNAME").Value
                    valadd.CARDTENDOR = grow.Cells("CARDTENDOR").Value
                    valadd.Voidtype = Me.voidtype
                    val_SALE_void.Add(valadd)
                End If
            Next

            If val_SALE_void.Count <= 0 Then
                Messages.Texts(Me.Text, "ไม่พบรายการที่เลือกกรุณาแสกนใหม่", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Return False
            End If


            'Dim chkdata = val_SALE_void.Select(Function(s) s.MRTSLIPNO).Distinct()
            'If chkdata.Count > 1 Then
            '    Messages.Texts(Me.Text, "ข้อมูลทำรายการไม่ถูกต้องพบ " & chkdata.Count & " บิลขายในรหัสชำระเงิน " & val_SALE_void(0).BARCODE, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
            '    Return False
            'End If



            Dim val_payment As New CPN_Payment_Hub.value_Models

            val_payment.barcode = val_SALE_void(0).BARCODE
            val_payment.MRTSLIPNO = val_SALE_void(0).MRTSLIPNO
            val_payment.Payment_code = val_SALE_void(0).CARDTENDOR
            val_payment.totalPrice = txt_Amount.Text

            Dim result_Payment_call As New ConfirmpayModels_log

            result_Payment_call = cph.payment(cph.case_payment.Verify_slip, val_payment)




            If Not IsNothing(result_Payment_call) Then

                If Not IsNothing(result_Payment_call) Then

                    If result_Payment_call.result_code = "0000" Then
                        'txt_B_TO_C_payment_code.Text = result_Payment_call.PAYMENT_CODE
                        'txt_B_TO_C_payment_code.BackColor = Color.DimGray
                        'Me.save_count = 10 'เปิดเลย
                        'Me.inquriry = 10 'เปิดเลย
                        Messages.Texts("การแจ้งเตือน", "ตรวจสอบรายการจ่ายสำเร็จเลขที่ : " & result_Payment_call.PAYMENT_CODE, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                        Me.Dispose()


                    Else
                        'If result_Payment_call.result_code = "4001" Then
                        '    Me.save_count = 10 'เปิดเลย
                        '    Me.inquriry = 10 'เปิดเลย
                        'End If
                        'txt_B_TO_C_payment_code.Text = ""
                        'txt_B_TO_C_payment_code.BackColor = Color.Red
                        Messages.Texts("การแจ้งเตือนจาก Payment Hub", result_Payment_call.PAY_Remark, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)

                        Return False
                    End If
                Else
                    'txt_B_TO_C_payment_code.Text = ""
                    'txt_B_TO_C_payment_code.US_Color_Didable = Color.Red
                    Messages.Texts("การแจ้งเตือน", "ทำการตรวจสอบไม่สำเร็จ กรุณาลองใหม่อีกครั้ง ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)

                    Return False
                End If
            Else
                Messages.Texts("การแจ้งเตือน", "ทำรายการจ่ายเงินไม่สำเร็จ กรุณาจ่ายใหม่อีกครั้ง หรือกด Inquiry เพื่อตรวจสอบ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Return False
            End If


        Catch ex As Exception
            If ex.Message = "ยังไม่พบรายการจ่ายเงิน" Then
                Messages.Texts("การแจ้งเตือน", ex.Message, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
            Else
                Msg_err.Show_Err(ex, "Payment_center.Inquiry_call")
            End If
        End Try
    End Function



    Public Function FPrint_CN(docno As String)
        Dim dataslip As List(Of SALE_Models.slipModel)
        Try

            Dim ret As New SALE_Models.print_slip
            Dim json = New API(Center.Data_Config.API).GETSON(String.Format(Center.Link_API.Get_API.CARDTRANS_PrintSlip_CN, docno))

            ret = (JsonConvert.DeserializeObject(Of SALE_Models.print_slip)(json))
            If ret.Respon.Result Then
                If ret.Data.Count <= 0 Then
                    Messages.Texts("การแจ้งเตือน", "ไม่พบใบลดหนี้", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    Return CL_interface.Answer.No
                End If

                dataslip = New List(Of SALE_Models.slipModel)
                dataslip = ret.Data

                Dim Print As New CL_PrintDocument(New CL_PrintDocument.print_model With {
                    .multicard = False,
                    .docno = docno,
                    .shopname = Center.data_profile.SHOPNAME,
                    .dataslip = dataslip
                    })
                Print.Print_to_printter("CN")

            Else
                If ret.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret.Respon.SystemErrorMessage)
                Else
                    Messages.Texts(Me.Text, ret.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                End If
            End If

            Return CL_interface.Answer.Yes
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
            Return CL_interface.Answer.No
        Finally
            dataslip = Nothing

        End Try
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'txt_barcode.Clear()
        txt_barcode.Focus()
    End Sub

    Private Sub Button_US1_Click(sender As Object, e As EventArgs) Handles Button_US1.Click
        FPrint_CN(txt_barcode.Text)
    End Sub
End Class