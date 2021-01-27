Imports Control_us
Imports Newtonsoft.Json
Imports System.IO
Imports MD

Public Class F_payment
    'Enum UIPAYMENT
    '    narmal = 0
    '    Ewallet = 1
    'End Enum
    'Public uipay_ As UIPAYMENT
    Dim obj_main As New F_Main_Sale

    Public PAYTYPE As String = "NOSELECT"
    Public PAYTYPE_value As New TenderModels.Sel_Tender
    Dim dt_card As New DataTable
    'Dim cur_docno As String = ""
    'Dim cur_SALE_INT As New SALE_Models.SALE_INT
    Dim SALE_INT As SALE_Models.SALE_INT
    Dim pay_success As Boolean = False
    Dim confirmpay_success As Boolean = False

    Public IS_CASHcard As Boolean = False
    Public sale_barcode As String = ""
    Dim inquriry As Integer = 1
    Dim save_count As Integer = 1
    Dim api_respon As Boolean = False
    Sub New(ByRef Val As F_Main_Sale)
        obj_main = Val
        ' This call is required by the designer.
        InitializeComponent()
        'Me.uipay_ = uipay_
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub setEvent()
        'text KeyDown
        AddHandler Me.txt_barcode_Normal.KeyDown, AddressOf Ev_Text_KeyDown

        ''text Text_Changed
        AddHandler Me.txt_amount_remain.TextChanged, AddressOf Ev_Text_Changed
        AddHandler Me.txt_pay_Amount.TextChanged, AddressOf Ev_Text_Changed

        'btn Click
        AddHandler Me.btn_narmal.Click, AddressOf Ev_Btn_Click

        AddHandler Me.btn_TMW.Click, AddressOf Ev_Btn_Click
        AddHandler Me.btn_QYthai.Click, AddressOf Ev_Btn_Click
        AddHandler Me.btn_REQUEST_QR_CODE.Click, AddressOf Ev_Btn_Click

        AddHandler Me.btn_Alipay.Click, AddressOf Ev_Btn_Click
        AddHandler Me.btn_Wechat.Click, AddressOf Ev_Btn_Click
        AddHandler Me.btn_Dolfin.Click, AddressOf Ev_Btn_Click
        AddHandler Me.btn_rabbit.Click, AddressOf Ev_Btn_Click


        AddHandler Me.btn_ok.Click, AddressOf Ev_Btn_Click
        AddHandler Me.btn_del.Click, AddressOf Ev_Btn_Click
        AddHandler Me.btn_close.Click, AddressOf Ev_Btn_Click
        AddHandler Me.btn_Inquiry.Click, AddressOf Ev_Btn_Click
        AddHandler Me.btn_Verify_slip.Click, AddressOf Ev_Btn_Click
        AddHandler Me.btn_cancel.Click, AddressOf Ev_Btn_Click
        AddHandler Me.btn_TMW_EDC.Click, AddressOf Ev_Btn_Click
        AddHandler Me.btn_LINEPAY.Click, AddressOf Ev_Btn_Click
        AddHandler Me.Btn_QRCS.Click, AddressOf Ev_Btn_Click



    End Sub
    Private Sub display(val As String)
        If RT_display.Text = "" Then
            RT_display.Text = "- " & val
        Else
            RT_display.Text += vbNewLine & "- " & val
        End If
        RT_display.SelectionStart = RT_display.TextLength
        RT_display.ScrollToCaret()
        Timer_blink.Enabled = True
    End Sub
    Private Sub F_payment_Load(sender As Object, e As EventArgs) Handles Me.Load
        RT_display.Text = ""
        setEvent()
        lbl_confirm.Text = "ยืนยันการชำระอัตโนมัติ" : lbl_confirm.Tag = True

        Timer1.Enabled = True
        ShowControl()
        ClearControl()
        Load_pay_ment()
        Me.txt_barcode_Normal.Enabled = True
        Me.txt_barcode_Normal.Focus()


        If IS_CASHcard Then
            cardtype_Click(btn_narmal)

            btn_narmal.Visible = True
            Me.txt_barcode_Normal.Text = Me.sale_barcode
            For Each c As Button_US In fl_cardtype_api.Controls
                If c.Name = btn_narmal.Name Then
                    c.Visible = True
                Else
                    c.Visible = False
                End If
            Next
            pay_Scan()
            Try
                If CDbl(txt_pay_Amount.Text) <= 0 Then
                    Me.Close()
                End If
            Catch ex As Exception
                Me.Close()
            End Try

        Else
            If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_EDC Then
                Timer1.Enabled = False
                Me.txt_barcode_Normal.Visible = False
                Me.tab_payment.SelectTab(B_TO_C)
            ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_API Then
                cardtype_Click(btn_TMW)
                Me.tab_payment.SelectTab(B_TO_C)
            ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.APIHUBCPN Then
                Me.tab_payment.SelectTab(B_TO_C)
                display("เลือก E-WALLET")
                btn_ok.Visible = False
                'cardtype_Click(btn_TMW)
            Else
                Messages.Texts("การแจ้งเตือน", Cl_massage.EDC_msg_wallet_Notconfig, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                Me.Close()
            End If



            btn_narmal.Visible = False
            btn_del.Visible = False



        End If
    End Sub
    Private Sub Load_pay_ment()
        Try

            Select Case Center.SYS_Config.WALLET_TYPE
                Case CL_constan.WALLET_TYPE.APIHUBCPN
                    fl_paymenthub_cpn.Controls.Clear()
                    If obj_main.dt_Tender.Rows.Count > 0 Then
                        Dim btn As Button_US
                        For Each val As DataRow In obj_main.dt_Tender.Rows
                            btn = New Button_US

                            btn.Name = val("CODE")
                            btn.Tag = val("CODE")
                            btn.Text = val("NAME")
                            btn.ForeColor = CL_Flowlayout.payment_ForeColor
                            btn.Width = CL_Flowlayout.payment_Width
                            btn.Height = CL_Flowlayout.payment_Height
                            btn.FlatAppearance.BorderColor = CL_Flowlayout.payment_BorderColor
                            btn.BackColor = CL_Flowlayout.payment_backcolor
                            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                            btn.Font = CL_Flowlayout.payment_Font
                            'btn.Size = New System.Drawing.Size(154, 72)
                            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                            btn.UseVisualStyleBackColor = False
                            'btn.Tag = val
                            btn.TextAlign = ContentAlignment.MiddleLeft
                            btn.TextImageRelation = TextImageRelation.ImageBeforeText
                            Select Case val("CODE")
                                Case "RBLP" 'Rabbitline
                                    btn.Image = My.Resources.Rabbitline
                                Case "RBCD" 'Rabbitcard
                                    btn.Image = My.Resources.Rabbitcard50
                                Case "DOLF" 'Dolfin
                                    btn.Image = My.Resources.dolfin80x80
                                Case "ALIP" 'ALIPAY
                                    btn.Image = My.Resources.Alipay50x50
                                Case "WECH" 'WECHAT
                                    btn.Image = My.Resources.Wechat80x80
                                Case "THQR" 'THAI QR
                                    btn.Image = My.Resources.Thai_QR40x40
                                Case "TMNP" 'Truemoney
                                    btn.Image = My.Resources.Truemoney250x50
                                Case "AIRP" 'Airpay
                                    btn.Image = My.Resources.Airpay50
                                Case Else
                                    btn.Image = My.Resources.No_image_available50_svg
                            End Select


                            AddHandler btn.Click, AddressOf cardtype_Click
                            fl_paymenthub_cpn.Controls.Add(btn)
                        Next
                    Else
                        Messages.Texts(Me.Text, "ไม่พบการตั้งค่า E-WALLET", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                        Me.Close()
                    End If


                Case CL_constan.WALLET_TYPE.WALLET_TYPE_API
A:
                    For Each c As Control In fl_cardtype_api.Controls
                        If c.Tag = btn_narmal.Tag Then Continue For
                        Dim crow() As DataRow
                        crow = obj_main.dt_Tender.Select("CODE = '" & c.Tag & "'")
                        If crow.Length > 0 Then
                            c.Visible = True
                        Else
                            c.Visible = False
                        End If
                    Next
                Case CL_constan.WALLET_TYPE.WALLET_TYPE_EDC
                    GoTo A
                Case Else

            End Select
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try

    End Sub


#Region "Event"
    Private Sub Ev_Text_Changed(sender As Object, e As EventArgs)
        If sender.name = txt_amount_remain.Name Or sender.name = txt_Amount.Name Then
            If CInt(txt_amount_remain.Text) > 0 Then
                txt_amount_remain.BackColor = Color.Red
                txt_pay_Amount.BackColor = Color.Red
            Else
                txt_amount_remain.BackColor = Color.DimGray
                txt_pay_Amount.BackColor = Color.DimGray
            End If
        End If
    End Sub
    Private Sub Ev_Text_KeyDown(sender As Object, e As KeyEventArgs)

        Select Case sender.name
            Case txt_barcode_Normal.Name
                If e.KeyCode = Keys.Enter Then
                    Try
                        txt_barcode_Normal.US_Enable = False
                        If txt_barcode_Normal.Text = "" Then
                            Exit Sub
                        End If

                        Me.Timer1.Enabled = False
                        If lbl_confirm.Tag Then
                            inquriry_Reset()
                            pay_Scan()
                        End If

                        'Me.Timer1.Enabled = True


                    Catch ex As Exception
                        'Msg_err.Show_Err(ex, Me.Text)
                        txt_barcode_Normal.Clear()
                    Finally

                        'Dim aa = Me.DGV_Card_Normal.RowCount
                        'Console.WriteLine(txt_barcode_Normal.Text & " : " & aa)
                    End Try
                End If
        End Select

    End Sub
    Private Sub inquriry_Reset()
        If Me.PAYTYPE <> "" Then
            inquriry = 0
            save_count = 0
        End If
    End Sub

    Private Sub Ev_Btn_Click(sender As Object, e As EventArgs)
        Timer1.Enabled = False
        ProgressBar1.Value = 0
        If (sender.name <> btn_ok.Name) And (sender.name <> btn_del.Name) Then
            Me.ClearControl()
            Me.ClearControl()
            'dt_card.Rows.Clear()
            'dt_card.AcceptChanges()
        End If

        Select Case sender.name
            Case btn_narmal.Name
                lbl_confirm.Text = "ยืนยันการชำระอัตโนมัติ" : lbl_confirm.Tag = True
                cardtype_Click(btn_narmal)
                Me.tab_payment.SelectTab(TNormal)
            Case btn_TMW.Name
                cardtype_Click(btn_TMW)
                Me.tab_payment.SelectTab(B_TO_C)

                If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_EDC Then
                    pay_EDC(sender)
                ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_API Then
                    Messages.Texts(Me.Text, "ชำระได้กับเครื่อง EDC เท่านั้น ", Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Stopp)
                End If
            Case btn_TMW_EDC.Name
                'บังคับให้สำเร็จเนื่องจากไม่ได้แสกนบัตรจริง การสแกนอยู่ที่เครื่อง EDC
                cardtype_Click(btn_TMW_EDC)
                Me.tab_payment.SelectTab(B_TO_C)
                If Messages.Texts(Me.Text, "คุณต้องการบันทึกรายการหรือไม่ ", Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Question) = DialogResult.Yes Then
                    If DGV_Product_Add2("EDC") Then
                        Me.FSave()
                    End If
                End If
            Case btn_QYthai.Name


                If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_EDC Then
                    cardtype_Click(btn_TMW)
                    Me.tab_payment.SelectTab(B_TO_C)
                    pay_EDC(sender)
                ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_API Then
                    lbl_confirm.Text = "ยืนยันการชำระอัตโนมัติ" : lbl_confirm.Tag = True
                    cardtype_Click(btn_QYthai)
                    Me.tab_payment.SelectTab(C_TO_B)
                End If
            Case btn_REQUEST_QR_CODE.Name
                '
                If DGV_Product_Add2("") Then
                    Me.FSave()
                End If
            Case btn_Alipay.Name
                cardtype_Click(btn_Alipay)
                Me.tab_payment.SelectTab(B_TO_C)


                If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_EDC Then
                    pay_EDC(sender)
                ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_API Then
                    Messages.Texts(Me.Text, "ชำระได้กับเครื่อง EDC เท่านั้น ", Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Stopp)
                End If
            Case btn_Wechat.Name
                cardtype_Click(sender)
                Me.tab_payment.SelectTab(B_TO_C)
                If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_EDC Then
                    pay_EDC(sender)
                ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_API Then
                    Messages.Texts(Me.Text, "ชำระได้กับเครื่อง EDC เท่านั้น ", Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Stopp)
                End If
            Case btn_Dolfin.Name
                If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_EDC Then
                    cardtype_Click(sender)
                    Me.tab_payment.SelectTab(B_TO_C)
                    pay_EDC(sender)
                ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_API Then
                    lbl_confirm.Text = "ยืนยันการชำระโดยผู้ใช้งาน" : lbl_confirm.Tag = True
                    cardtype_Click(btn_Dolfin)
                    Me.tab_payment.SelectTab(B_TO_C)
                End If

            Case btn_rabbit.Name
                cardtype_Click(btn_rabbit)
                Me.tab_payment.SelectTab(B_TO_C)

                If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_EDC Then
                    pay_EDC(sender)
                ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_API Then
                    Messages.Texts(Me.Text, "ชำระได้กับเครื่อง EDC เท่านั้น ", Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Stopp)
                End If
            Case btn_LINEPAY.Name
                cardtype_Click(btn_rabbit)
                Me.tab_payment.SelectTab(B_TO_C)

                If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_EDC Then
                    pay_EDC(sender)
                ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_API Then
                    Messages.Texts(Me.Text, "ชำระได้กับเครื่อง EDC เท่านั้น ", Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Stopp)
                End If


            Case Btn_QRCS.Name

                cardtype_Click(Btn_QRCS)
                Me.tab_payment.SelectTab(B_TO_C)

                If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_EDC Then
                    pay_EDC(sender)
                ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_API Then
                    Messages.Texts(Me.Text, "ชำระได้กับเครื่อง EDC เท่านั้น ", Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Stopp)
                End If

            Case btn_ok.Name
                If cur_docno.Text = "" Then
                    'จ่ายครั้งแรก
                    'If DGV_Product_Add2(Me.txt_barcode_Normal.Text) Then
                    Me.FSave()
                    'End If
                Else
                    'จ่ายครั้งที่ 2 กรณีจ่ายไม่สำเร็จ
                    pay_call("print", False)
                End If


                'If Me.cur_docno <> "" Then
                '    pay_call("print", False)
                'Else
                '    Timer1.Enabled = False
                '    FSave()
                'End If

                Me.save_count += 1

                If Me.save_count >= 3 Then
                    btn_close.Visible = True
                End If
            Case btn_del.Name
                del_last()
            Case btn_close.Name
                close_form()
            Case btn_Inquiry.Name
                Pay_Inquiry()
                Me.inquriry += 1
                If Me.inquriry >= 3 Then
                    btn_close.Visible = True
                    btn_cancel.Visible = True
                    txt_barcode_Normal.US_Enable = True
                    Me.Timer1.Enabled = True

                    If api_respon = False Then
                        Messages.Texts("การแจ้งเตือน", " ทำรายการไม่สำเร็จ " & vbNewLine & " กรุณาตรวจสอบรายการค้างจ่ายหน้าหลัก", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                        Me.Close()
                    End If
                End If
            Case btn_Verify_slip.Name
                'Dim f As New F_Void(CL_constan.Void_TYPE.Verify_slip, True, SALE_INT.Saleitems_card(0).BARCODE)
                'If f.ShowDialog() = DialogResult.OK Then
                '     Me.Close()
                'End If
                Pay_Verify_slip()
            Case btn_cancel.Name
                'If txt_B_TO_C_payment_code.Text = "" Then
                'If Cancel_pending() Then 'ใใช้ที่นี้ไม่ได้ เนื่องจากจำเข้าหน้า void ไม่สำเร็จเพราะหาไม่เจอ ไปใช้เหตุการปิดแทน
                'Else




                'Dim f As New F_Void(CL_constan.Void_TYPE.CANCEL, True, SALE_INT.Saleitems_card(0).BARCODE)
                'f.txt_barcode.Text = SALE_INT.Saleitems_card(0).BARCODE
                'If f.ShowDialog() = DialogResult.OK Then
                '    Messages.Texts("การแจ้งเตือน", "ทำรายการยกเลิกสำเร็จ : " & cur_docno.Text, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                '     Me.Close()
                '    'End If
                'End If
                ''End If
                'Cancel_pending()
                If pay_Cancel() Then
                    Me.Close()
                End If



        End Select

        Timer1.Enabled = True
    End Sub


#End Region
    ''' <summary>
    ''' ทำงานทันทีที่แสกนบาร์โค๊ด
    ''' </summary>
    Private Sub pay_Scan()
        Try
            If Me.cur_docno.Text <> "" Then
                btn_close.Visible = False
                Panel3.Enabled = False
            Else
                btn_close.Visible = True
                Panel3.Enabled = False
            End If

            If Me.PAYTYPE = "NOSELECT" Then
                Messages.Texts("การแจ้งเตือน", "กรุณาเลือกประเภทบัตร", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                btn_close.Visible = True
                Panel3.Enabled = True
                Exit Sub
            End If

            If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.APIHUBCPN Then
                If IS_CASHcard Then
                    Cashcard()
                Else
                    If cur_docno.Text = "" Then
                        'จ่ายครั้งแรก
                        If DGV_Product_Add2(Me.txt_barcode_Normal.Text) Then
                            Me.FSave()
                        End If
                    Else
                        'จ่ายครั้งที่ 2 กรณีจ่ายไม่สำเร็จ
                        pay_call("print", False)
                    End If
                End If
            Else

                Select Case Me.PAYTYPE
                    Case Me.btn_narmal.Tag
                        Cashcard()
                    Case Me.btn_TMW.Tag
                        If cur_docno.Text = "" Then
                            'จ่ายครั้งแรก
                            If DGV_Product_Add2(Me.txt_barcode_Normal.Text) Then
                                Me.FSave()
                            End If
                        Else
                            'จ่ายครั้งที่ 2 กรณีจ่ายไม่สำเร็จ
                            pay_call("print", False)
                        End If
                    Case Me.btn_QYthai.Tag
                        ' c scan b requst qr ทันที
                        pay_call("print", False)

                    Case Me.btn_Alipay.Tag
                    Case Me.btn_Wechat.Tag
                    Case Me.btn_Dolfin.Tag

                        'กดจ่ายด้วยมือ
                        If cur_docno.Text = "" Then
                            'จ่ายครั้งแรก
                            If DGV_Product_Add2(Me.txt_barcode_Normal.Text) Then
                                Me.FSave()
                            End If
                        Else
                            'จ่ายครั้งที่ 2 กรณีจ่ายไม่สำเร็จ
                            pay_call("print", False)
                        End If

                    Case Me.btn_rabbit.Tag

                End Select
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        Finally
            txt_barcode_Normal.Text = ""
            'txt_barcode_Normal.Enabled = True
            'txt_barcode_Normal.Focus()

            If IS_CASHcard Then
                txt_barcode_Normal.US_Enable = True
                Me.Timer1.Enabled = True
            Else


                If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.APIHUBCPN Then
                    If api_respon Then
                        txt_barcode_Normal.US_Enable = True
                        Me.Timer1.Enabled = True
                    Else
                        txt_barcode_Normal.US_Enable = False
                    End If
                Else
                    txt_barcode_Normal.US_Enable = True
                    Me.Timer1.Enabled = True
                End If
            End If


            If Me.cur_docno.Text <> "" Then
                btn_Inquiry.Enabled = True
            Else
                btn_Inquiry.Enabled = False
            End If
        End Try
    End Sub
    Private Sub Cashcard()
        Dim brnid = txt_barcode_Normal.Text.Substring(1, Center.data_profile.BRNID.Length)
        If Center.SYS_Config.CUSGROUP = CL_constan.CUSGROUP.ATR Then

            If brnid.ToUpper <> Center.data_profile.BRNID.ToUpper Then
                Messages.Texts("การแจ้งเตือน", "บาร์โค๊ด : " & txt_barcode_Normal.Text & " ไม่ถูกต้อง", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                Exit Sub
            End If
        End If
        Dim a = New MD.Barcode().BarcodeChkDigit(txt_barcode_Normal.Text, txt_barcode_Normal.Text.Length - 1)
        Dim b = Microsoft.VisualBasic.Right(txt_barcode_Normal.Text, 1)
        If b <> a Then
            Messages.Texts("การแจ้งเตือน", "บาร์โค๊ด : " & txt_barcode_Normal.Text & " ไม่ถูกต้อง", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
            Exit Sub
        End If




        scan_barcode_Normal(brnid)

        txt_barcode_Normal.Text = ""
    End Sub
    Private Function pay_EDC(sender As Object)
        Try


            If Messages.Texts(Me.Text, "คุณต้องการจ่ายด้วย  " & sender.text, Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Question) = DialogResult.No Then
                Return False
            End If
            inquriry_Reset()
            btn_close.Visible = False


            cardtype_Click(sender)
            Me.tab_payment.SelectTab(T_Waitpament)
            Me.Refresh()






            Dim ret As Boolean
            Select Case Center.SYS_Config.VENDOR_GETWAY
                Case "GHL"
                    ret = New GHL_EDC_Payment(Me.PAYTYPE, Me.PAYTYPE_value, Center.data_profile.EDC_IP).Test_LINK()
                Case Else
                    Messages.Texts(Me.Text, "Vendor Getway EDC ไม่ถูกต้อง", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                    Return False
            End Select


            If cur_docno.Text = "" Then
                If DGV_Product_Add2("EDC") Then
                    Me.FSave()
                End If
            Else
                'จ่ายครั้งที่ 2 กรณีจ่ายไม่สำเร็จ
                pay_call("print", False)
            End If
        Catch ex As Exception
            Messages.Texts(Me.Text, ex.Message, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
        Finally
            Me.tab_payment.SelectTab(B_TO_C)
        End Try
    End Function
    Private Sub cardtype_Click(sender As Object, Optional e As EventArgs = Nothing)
        Try
            Dim crow() As DataRow
            Select Case sender.Name

                Case "DOLF"
                Case "THQR"
                    'btn_Verify_slip.Visible = True
                Case Else
                    btn_Verify_slip.Visible = False
            End Select

            crow = obj_main.dt_Tender.Select("CODE = '" & sender.Tag & "'")

            If crow.Length > 0 Then
                PAYTYPE_value = New TenderModels.Sel_Tender With {
                 .TID = crow(0)("TID"),
                 .TERMINALID = crow(0)("TERMINALID"),
                 .CODE = crow(0)("CODE"),
                 .NAME = crow(0)("NAME"),
                 .MERCHAND_ID = crow(0)("MERCHAND_ID"),
                 .VENDERCODE = crow(0)("VENDERCODE"),
                 .VENDERNAME = crow(0)("VENDERNAME"),
                 .TYPE = crow(0)("TYPE"),
                 .SEQ = crow(0)("SEQ"),
                 .CERRENCY = crow(0)("CERRENCY"),
                 .PAYMENT_METHOD = crow(0)("PAYMENT_METHOD"),
                 .VALUE_CONVERT = crow(0)("VALUE_CONVERT"),
                 .APP_ID = crow(0)("APP_ID"),
                 .CLIENT_KEY = crow(0)("CLIENT_KEY"),
                 .CLIENT_SECRET = crow(0)("CLIENT_SECRET"),
                 .Server = crow(0)("Server"),
                 .PREFIX_BARCODE = crow(0)("PREFIX_BARCODE"),
                 .REMARK1 = crow(0)("REMARK1"),
                 .REMARK2 = crow(0)("REMARK2"),
                 .REMARK3 = crow(0)("REMARK3"),
                 .SCAN_TYPE = crow(0)("SCAN_TYPE"),
                 .VENDER_SHOP_ID = crow(0)("VENDER_SHOP_ID")
                }
                txt_PAYTYPE.Text = crow(0)("NAME")
            Else
                Me.PAYTYPE = sender.tag
                PAYTYPE_value.CODE = sender.tag 'Me.PAYTYPE

            End If
            If IS_CASHcard Then
                For Each c As Button_US In fl_cardtype_api.Controls
                    If c.Name = sender.Name Then
                        c.BackColor = Color.DodgerBlue
                        c.ForeColor = Color.White
                        c.FlatAppearance.MouseOverBackColor = Color.SkyBlue
                        Me.PAYTYPE = sender.tag
                    Else
                        c.BackColor = Color.Transparent
                        c.ForeColor = Color.SaddleBrown
                        c.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
                    End If
                Next
            Else
                Select Case Center.SYS_Config.WALLET_TYPE
                    Case CL_constan.WALLET_TYPE.APIHUBCPN
                        For Each c As Button_US In fl_paymenthub_cpn.Controls

                            If c.Name = sender.Name Then
                                c.BackColor = Color.DodgerBlue
                                c.ForeColor = Color.White
                                c.FlatAppearance.MouseOverBackColor = Color.DodgerBlue
                                Me.PAYTYPE = sender.tag
                            Else
                                c.BackColor = CL_Flowlayout.payment_backcolor
                                c.ForeColor = CL_Flowlayout.payment_ForeColor
                                c.FlatAppearance.MouseOverBackColor = Color.DodgerBlue
                            End If
                        Next
                    Case Else
                        For Each c As Button_US In fl_cardtype_api.Controls
                            If c.Name = sender.Name Then
                                c.BackColor = Color.DodgerBlue
                                c.ForeColor = Color.White
                                c.FlatAppearance.MouseOverBackColor = Color.SkyBlue
                                Me.PAYTYPE = sender.tag
                            Else
                                c.BackColor = Color.Transparent
                                c.ForeColor = Color.SaddleBrown
                                c.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
                            End If
                        Next
                End Select
            End If
            display("แสกน QRCODE")



        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

#Region "save"

    Public Function FSave(Optional ByVal obj As Object = Nothing) As Boolean
        'Dim F_Lod As New F_loading
        'F_Lod.BringToFront()
        ProgressBar1.Value = 0
        Try
            If DGV_Card_Normal.Rows.Count <= 0 Then
                Messages.Texts(Me.Text, "ไม่พบบาร์โค๊ดจ่ายเงิน กรุณาแสกนใหม่", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                Return False
            End If
            If CInt(Me.txt_amount_remain.Text) > 0 And Me.PAYTYPE = Me.btn_narmal.Tag Then
                If Messages.Texts(Me.Text, "คุณยังจ่ายเงินไม่ครบจำนวน " & txt_Amount.Text & " บาท กรุณาจ่ายเพิ่มอีก " & Me.txt_amount_remain.Text & " บาท", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp) = DialogResult.Cancel Then
                    Me.ClearControl()
                    Return False
                Else
                    Return False
                End If

            End If
            'Me.Invoke(Sub() F_Lod.Show())

            SALE_INT = New SALE_Models.SALE_INT

            Dim Saleitems As New List(Of SALE_Models.SALE_ITEMS)
            Dim Saleitems_card As New List(Of SALE_Models.Saleitems_card)
            Dim Cardtran As New List(Of SALE_Models.Cardtran)
            'Dim CARDTRANS_muti As New List(Of CARDTRANS_Models.MultiCards)

            Dim MRTSTATUS = ""
            'พี่อ้วนบอกให้ลง S ไปเลย ถ้าการจ่ายเงินจาก getway ไม่สำเร็จให้ลง log error
            ' ลง เป็น w แล้วค่อยอัพเป้น s ถ้าจ่ายไม่สำเร็จหรือยกเลิกให้ลบไปเลย
            If Me.PAYTYPE = Me.btn_narmal.Tag Or Me.PAYTYPE = "TRUEEDC" Then
                MRTSTATUS = "S" 'ขาย
            Else
                MRTSTATUS = "W" 'รอการจ่าย หรือจ่ายไม่สำเร็จ
            End If
            SALE_INT.Multicard = If(Me.dt_card.Rows.Count > 1, True, False)
            SALE_INT.MRTSLIPNO = ""
            SALE_INT.SHOPID = Center.data_profile.SHOPID
            SALE_INT.POSID = Center.data_profile.POSID

            SALE_INT.DOCDATE = Center.DATEWORKING
            SALE_INT.DOCMONT = Center.DATEWORKING.Year
            SALE_INT.DOCMONT = Center.DATEWORKING.Month
            SALE_INT.TAXINVOICE = ""
            SALE_INT.CREDITNOTES = ""
            SALE_INT.CARDTENDOR = Me.PAYTYPE
            SALE_INT.CARDREF = ""
            SALE_INT.CARDPURSE = If(Me.PAYTYPE = btn_narmal.Tag, 0, CDbl(Me.txt_Amount.Text.Trim))
            SALE_INT.taxPrint = ""
            SALE_INT.CUS_ID = ""
            SALE_INT.PAYTYPE = Me.PAYTYPE
            SALE_INT.PAYAMOUNT = CDbl(Me.txt_pay_Amount.Text.Trim)
            SALE_INT.AMOUNT = CDbl(Me.txt_Amount.Text.Trim)
            SALE_INT.DISTP = 0
            SALE_INT.DISVALUE = 0
            SALE_INT.AFTERDIS = CDbl(Me.txt_Amount.Text.Trim)
            SALE_INT.VATTP = ""
            SALE_INT.VATVALUE = 0
            SALE_INT.AFTERVAT = CDbl(Me.txt_Amount.Text.Trim)
            SALE_INT.NETAMOUNT = CDbl(Me.txt_Amount.Text.Trim)
            SALE_INT.QTY_TOTAL = CDbl(obj_main.txt_qty_totel.Text.Trim)
            SALE_INT.CBY = Center.data_profile.Emp_id
            SALE_INT.MBY = Center.data_profile.Emp_id
            SALE_INT.DC_STATE = MRTSTATUS

            SALE_INT.Remark1 = ""
            SALE_INT.Remark2 = ""
            SALE_INT.Remark3 = ""
            If Me.PAYTYPE = btn_narmal.Tag Then
                SALE_INT.merchant_id = ""
                SALE_INT.VALUE_CONVERT = 0
            Else
                SALE_INT.merchant_id = PAYTYPE_value.MERCHAND_ID
                SALE_INT.VALUE_CONVERT = PAYTYPE_value.VALUE_CONVERT
            End If
            SALE_INT.CorpBRNID = Center.data_profile.BRNID
            SALE_INT.STCODE = Center.data_profile.STCODE


            Dim val_SALE_ITEMS As SALE_Models.SALE_ITEMS
            For Each Item As DataRow In obj_main.dt_paroduct.Rows
                val_SALE_ITEMS = New SALE_Models.SALE_ITEMS
                val_SALE_ITEMS.SEQ = Item("SEQ")
                val_SALE_ITEMS.FOODID = Item("FOODID")
                val_SALE_ITEMS.FOODNAME = Item("FOODNAME")
                val_SALE_ITEMS.PCODE = Item("PCODE")
                val_SALE_ITEMS.PNAME = Item("PNAME")
                val_SALE_ITEMS.UNITCODE = Item("UNITCODE")
                val_SALE_ITEMS.UNITNAME = Item("UNITNAME")
                val_SALE_ITEMS.GP = Item("GP")
                val_SALE_ITEMS.GPAMOUNT = Item("GPAMOUNT")
                val_SALE_ITEMS.GPRULE = Item("GPRULE")
                val_SALE_ITEMS.ITEMS_PRICE = Item("MRTAMOUNT")
                val_SALE_ITEMS.DISTP = 0
                val_SALE_ITEMS.DISVALUE = 0
                val_SALE_ITEMS.AFTERDIS = Item("MRTAMOUNT")
                val_SALE_ITEMS.VATTP = ""
                val_SALE_ITEMS.VATVALUE = 0
                val_SALE_ITEMS.AFTERVAT = Item("MRTAMOUNT")
                val_SALE_ITEMS.NETAMOUNT = Item("MRTAMOUNT")
                val_SALE_ITEMS.QTY = Item("QTY")
                val_SALE_ITEMS.PRO_ID = 0
                val_SALE_ITEMS.PRO_NAME = ""
                val_SALE_ITEMS.PRO_TEXT = ""

                Saleitems.Add(val_SALE_ITEMS)
            Next

            If Center.Data_Config.MultiCards = F_Setting.rd_multicard_E.Tag Then
                If Me.dt_card.Rows.Count > 0 Then
                    Dim vAL_SALE_CARD As SALE_Models.Saleitems_card
                    For Each Item As DataRow In Me.dt_card.Rows
                        vAL_SALE_CARD = New SALE_Models.Saleitems_card

                        vAL_SALE_CARD.SEQ = Item("SEQ")
                        vAL_SALE_CARD.BARCODE = PAYTYPE_value.PREFIX_BARCODE & Item("BARCODE")
                        vAL_SALE_CARD.PAYTYPE = Item("PAYTYPE")
                        vAL_SALE_CARD.CUSED = Item("CUSED")
                        vAL_SALE_CARD.CUSED1 = Item("CUSED1")
                        vAL_SALE_CARD.MRTAMOUNT = Item("MRTAMOUNT")
                        vAL_SALE_CARD.CBALANCE = Item("CBALANCE")
                        vAL_SALE_CARD.CBALANCEREMAIN = Item("CBALANCEREMAIN")
                        vAL_SALE_CARD.GP = 0
                        vAL_SALE_CARD.GPAMOUNT = 0
                        vAL_SALE_CARD.PRO_ID = 0
                        vAL_SALE_CARD.PRO_NAME = ""
                        vAL_SALE_CARD.PRO_TEXT = ""
                        Saleitems_card.Add(vAL_SALE_CARD)

                    Next
                End If
            End If


            Dim val_Cardtran As SALE_Models.Cardtran
            For Each Item As DataRow In obj_main.dt_paroduct.Rows
                val_Cardtran = New SALE_Models.Cardtran
                val_Cardtran.CUSED = 0 ''Item("CUSED")
                val_Cardtran.BARCODE = PAYTYPE_value.PREFIX_BARCODE & Me.dt_card.Rows(0)("BARCODE")
                val_Cardtran.SHOPID = Center.data_profile.SHOPID
                val_Cardtran.POSID = Center.data_profile.POSID
                val_Cardtran.MRTAMOUNT = Item("MRTAMOUNT")
                val_Cardtran.MRTSTATUS = "S"
                val_Cardtran.MRTSLIPNO = ""
                val_Cardtran.MRTLUPDATE = Nothing
                val_Cardtran.TID = If(Me.PAYTYPE = btn_narmal.Tag, "", Center.data_profile.TERMINAL_TID)
                val_Cardtran.UID = If(Me.PAYTYPE = btn_narmal.Tag, "", Center.data_profile.TERMINAL_TID)
                val_Cardtran.LUPDATE = Nothing
                val_Cardtran.BACKUPFLG = False
                val_Cardtran.CHKFLG = False
                val_Cardtran.VOIDNO = ""
                val_Cardtran.CUSED1 = 0
                val_Cardtran.FOODID = Item("FOODID")
                val_Cardtran.FOODNAME = Item("FOODNAME")
                val_Cardtran.PCODE = Item("PCODE")
                val_Cardtran.PNAME = Item("PNAME")
                val_Cardtran.UNITCODE = Item("UNITCODE")
                val_Cardtran.UNITNAME = Item("UNITNAME")
                val_Cardtran.SHOPENDFLG = 0
                val_Cardtran.GP = Item("GP")
                val_Cardtran.GPAMOUNT = Item("GPAMOUNT")
                val_Cardtran.GPRULE = Item("GPRULE")
                val_Cardtran.STOCKID = ""
                val_Cardtran.TAXINVOICE = ""
                val_Cardtran.CREDITNOTES = ""
                val_Cardtran.CARDTENDOR = Me.PAYTYPE
                val_Cardtran.CARDREF = ""
                val_Cardtran.CARDPURSE = If(Me.PAYTYPE = btn_narmal.Tag, 0, CDbl(Me.txt_Amount.Text.Trim))
                val_Cardtran.taxPrint = 0
                val_Cardtran.SEQ = Item("SEQ")
                val_Cardtran.ITEMS_PRICE = Item("MRTAMOUNT")
                val_Cardtran.QTY = Item("QTY")
                Cardtran.Add(val_Cardtran)
            Next
            ProgressBar1.Value = 30



            If Cardtran.Count <= 0 Then
                Messages.Texts(Me.Text, "ไม่พบรายการสินค้า", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                Exit Function
            End If

            SALE_INT.Saleitems = Saleitems
            SALE_INT.Saleitems_card = Saleitems_card
            SALE_INT.Cardtran = Cardtran
            'SALE_INT.Items_MultiCard = CARDTRANS_muti
            ProgressBar1.Value = 50
            Dim json As String = JsonConvert.SerializeObject(SALE_INT)
            Dim siteUri As New Uri(Center.Data_Config.API + Center.Link_API.Post_API.CARDTRANS_save)
            Dim ret = New API(Center.Data_Config.API).POSTResponse(siteUri, json, "POST", "")
            Dim retValue As SALE_Models.value = JsonConvert.DeserializeObject(Of SALE_Models.value)(ret)

            If retValue.Respon.Result Then

                obj_main.lbl_docno.Text = retValue.Respon.Result_value2
                cur_docno.Text = retValue.Respon.Result_value2
                Me.SALE_INT.MRTSLIPNO = retValue.Respon.Result_value2
                If Me.IS_CASHcard Then

                    If obj_main.chk_Print.CheckState = CheckState.Unchecked Then
                        If Me.PAYTYPE = btn_narmal.Tag Then
                            obj_main.FPrint(SALE_INT.Multicard)
                            'Else
                            '    obj_main.FPrint_inv(Me.PAYTYPE)
                        End If

                    End If

                    If retValue.Respon.ErrorMessage = "NOBALANCE" Then
                        Dim f As New F_card_alert
                        f.lbl_barcode.Text = retValue.Respon.Result_value
                        f.ShowDialog()
                    End If

                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    Select Case Me.PAYTYPE
                        Case btn_TMW_EDC.Tag
                            'บังคับให้สำเร็จเนื่องจากไม่ได้แสกนบัตรจริง การสแกนอยู่ที่เครื่อง EDC
                            obj_main.FPrint(SALE_INT.Multicard)
                        Case Else
                            If pay_call("print", True) = False Then 'payment
                                Return False
                            End If

                    End Select
                End If
                ProgressBar1.Value = 90

            Else


                If retValue.Respon.SystemErrorMessage <> "" Then
                    'จากระบบ
                    Throw New Exception(retValue.Respon.SystemErrorMessage)
                Else
                    If retValue.Respon.Result_value = "BROKE" Then 'มีการส่งค่ามา
                        If Center.Data_Config.MultiCards = F_Setting.rd_multicard_D.Tag Then
                            Messages.Texts(Me.Text, "ยอดเงินคงเหลือ " & retValue.Respon.Result_value3 & " บาท ไม่พอจ่ายสินค้ามูลค่า " & Me.txt_Amount.Text & " บาท", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                            Me.ClearControl()
                            Return False
                        End If
                        'If (Messages.Texts(Me.Text, retValue.Respon.ErrorMessage, Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Question)) = DialogResult.Yes Then
                        '    Multicard(retValue.Respon.Result_value2, Me.txt_barcode.Text.Trim)
                        'Else
                        '    Me.ClearControl()
                        'End If

                    Else
                        Messages.Texts(Me.Text, retValue.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                        If is_CASHcard Then
                            Me.Close()
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
            Me.Close()
        Finally

            'F_Lod.Dispose()
            ProgressBar1.Value = 100
        End Try


    End Function





    'Public Function FSavetesssss(Optional ByVal obj As Object = Nothing) As Boolean

    '    Try
    '        SALE_INT = New SALE_Models.SALE_INT

    '        Dim Saleitems As New List(Of SALE_Models.SALE_ITEMS)
    '        Dim Saleitems_card As New List(Of SALE_Models.Saleitems_card)
    '        Dim Cardtran As New List(Of SALE_Models.Cardtran)
    '        Dim MRTSTATUS = ""
    '        MRTSTATUS = "S" 'ขาย

    '        SALE_INT.Multicard = If(Me.dt_card.Rows.Count > 1, True, False)
    '        SALE_INT.MRTSLIPNO = ""
    '        SALE_INT.SHOPID = Center.data_profile.SHOPID
    '        SALE_INT.POSID = Center.data_profile.POSID

    '        SALE_INT.DOCDATE = Center.DATEWORKING
    '        SALE_INT.DOCMONT = Center.DATEWORKING.Year
    '        SALE_INT.DOCMONT = Center.DATEWORKING.Month
    '        SALE_INT.TAXINVOICE = ""
    '        SALE_INT.CREDITNOTES = ""
    '        SALE_INT.CARDTENDOR = Me.PAYTYPE
    '        SALE_INT.CARDREF = ""
    '        SALE_INT.CARDPURSE = If(Me.PAYTYPE = btn_narmal.Tag, 0, CDbl(Me.txt_Amount.Text.Trim))
    '        SALE_INT.taxPrint = ""
    '        SALE_INT.CUS_ID = ""
    '        SALE_INT.PAYTYPE = Me.PAYTYPE
    '        SALE_INT.PAYAMOUNT = CDbl(Me.txt_pay_Amount.Text.Trim)
    '        SALE_INT.AMOUNT = CDbl(Me.txt_Amount.Text.Trim)
    '        SALE_INT.DISTP = 0
    '        SALE_INT.DISVALUE = 0
    '        SALE_INT.AFTERDIS = CDbl(Me.txt_Amount.Text.Trim)
    '        SALE_INT.VATTP = ""
    '        SALE_INT.VATVALUE = 0
    '        SALE_INT.AFTERVAT = CDbl(Me.txt_Amount.Text.Trim)
    '        SALE_INT.NETAMOUNT = CDbl(Me.txt_Amount.Text.Trim)
    '        SALE_INT.QTY_TOTAL = CDbl(obj_main.txt_qty_totel.Text.Trim)
    '        SALE_INT.CBY = Center.data_profile.Emp_id
    '        SALE_INT.MBY = Center.data_profile.Emp_id
    '        SALE_INT.DC_STATE = MRTSTATUS

    '        SALE_INT.Remark1 = ""
    '        SALE_INT.Remark2 = ""
    '        SALE_INT.Remark3 = ""
    '        If Me.PAYTYPE = btn_narmal.Tag Then
    '            SALE_INT.merchant_id = ""
    '            SALE_INT.VALUE_CONVERT = 0
    '        Else
    '            SALE_INT.merchant_id = PAYTYPE_value.MERCHAND_ID
    '            SALE_INT.VALUE_CONVERT = PAYTYPE_value.VALUE_CONVERT
    '        End If
    '        SALE_INT.CorpBRNID = Center.data_profile.BRNID
    '        SALE_INT.STCODE = Center.data_profile.STCODE


    '        Dim val_SALE_ITEMS As SALE_Models.SALE_ITEMS
    '        For Each Item As DataRow In obj_main.dt_paroduct.Rows
    '            val_SALE_ITEMS = New SALE_Models.SALE_ITEMS
    '            val_SALE_ITEMS.SEQ = Item("SEQ")
    '            val_SALE_ITEMS.FOODID = Item("FOODID")
    '            val_SALE_ITEMS.FOODNAME = Item("FOODNAME")
    '            val_SALE_ITEMS.PCODE = Item("PCODE")
    '            val_SALE_ITEMS.PNAME = Item("PNAME")
    '            val_SALE_ITEMS.UNITCODE = Item("UNITCODE")
    '            val_SALE_ITEMS.UNITNAME = Item("UNITNAME")
    '            val_SALE_ITEMS.GP = Item("GP")
    '            val_SALE_ITEMS.GPAMOUNT = Item("GPAMOUNT")
    '            val_SALE_ITEMS.GPRULE = Item("GPRULE")
    '            val_SALE_ITEMS.ITEMS_PRICE = Item("MRTAMOUNT")
    '            val_SALE_ITEMS.DISTP = 0
    '            val_SALE_ITEMS.DISVALUE = 0
    '            val_SALE_ITEMS.AFTERDIS = Item("MRTAMOUNT")
    '            val_SALE_ITEMS.VATTP = ""
    '            val_SALE_ITEMS.VATVALUE = 0
    '            val_SALE_ITEMS.AFTERVAT = Item("MRTAMOUNT")
    '            val_SALE_ITEMS.NETAMOUNT = Item("MRTAMOUNT")
    '            val_SALE_ITEMS.QTY = Item("QTY")
    '            val_SALE_ITEMS.PRO_ID = 0
    '            val_SALE_ITEMS.PRO_NAME = ""
    '            val_SALE_ITEMS.PRO_TEXT = ""

    '            Saleitems.Add(val_SALE_ITEMS)
    '        Next

    '        If Center.Data_Config.MultiCards = F_Setting.rd_multicard_E.Tag Then
    '            If Me.dt_card.Rows.Count > 0 Then
    '                Dim vAL_SALE_CARD As SALE_Models.Saleitems_card
    '                For Each Item As DataRow In Me.dt_card.Rows
    '                    vAL_SALE_CARD = New SALE_Models.Saleitems_card

    '                    vAL_SALE_CARD.SEQ = Item("SEQ")
    '                    vAL_SALE_CARD.BARCODE = PAYTYPE_value.PREFIX_BARCODE & Item("BARCODE")
    '                    vAL_SALE_CARD.PAYTYPE = Item("PAYTYPE")
    '                    vAL_SALE_CARD.CUSED = Item("CUSED")
    '                    vAL_SALE_CARD.CUSED1 = Item("CUSED1")
    '                    vAL_SALE_CARD.MRTAMOUNT = Item("MRTAMOUNT")
    '                    vAL_SALE_CARD.CBALANCE = Item("CBALANCE")
    '                    vAL_SALE_CARD.CBALANCEREMAIN = Item("CBALANCEREMAIN")
    '                    vAL_SALE_CARD.GP = 0
    '                    vAL_SALE_CARD.GPAMOUNT = 0
    '                    vAL_SALE_CARD.PRO_ID = 0
    '                    vAL_SALE_CARD.PRO_NAME = ""
    '                    vAL_SALE_CARD.PRO_TEXT = ""
    '                    Saleitems_card.Add(vAL_SALE_CARD)

    '                Next
    '            End If
    '        End If

    '        If Saleitems_card.Count <= 0 Then
    '            Messages.Texts(Me.Text, "ไม่พบรายการสินค้า", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
    '            Exit Function
    '        End If

    '        SALE_INT.Saleitems = Saleitems
    '        SALE_INT.Saleitems_card = Saleitems_card
    '        SALE_INT.Cardtran = Cardtran

    '        Dim json As String = JsonConvert.SerializeObject(SALE_INT)
    '        Dim siteUri As New Uri(Center.Data_Config.API + Center.Link_API.Post_API.CARDTRANS_save)
    '        Dim ret = New API(Center.Data_Config.API).POSTResponse(siteUri, json, "POST", "")
    '        Dim retValue As SALE_Models.value = JsonConvert.DeserializeObject(Of SALE_Models.value)(ret)

    '        If retValue.Respon.Result Then

    '            obj_main.lbl_docno.Text = retValue.Respon.Result_value2
    '            cur_docno.Text = retValue.Respon.Result_value2
    '            Me.SALE_INT.MRTSLIPNO = retValue.Respon.Result_value2

    '        Else
    '            If retValue.Respon.SystemErrorMessage <> "" Then
    '                'จากระบบ
    '                Throw New Exception(retValue.Respon.SystemErrorMessage)
    '            Else
    '                Messages.Texts(Me.Text, retValue.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
    '                If IS_CASHcard Then
    '                    Me.Close()
    '                End If
    '            End If
    '        End If

    '    Catch ex As Exception
    '        Msg_err.Show_Err(ex, Me.Text)
    '        Me.Close()
    '    Finally
    '    End Try
    'End Function




    ''' <summary>
    ''' ยืนยันการจ่ายเงินจาก tender
    ''' </summary>
    ''' <param name="ff"></param>
    ''' <returns></returns>
    ''' 
    Dim result_Payment_call As New ConfirmpayModels_log
    Public Function pay_call(print As String, ByVal type As String) As Boolean
        Try
            'Me.tab_payment.SelectTab(T_Waitpament)
            btn_cancel.Visible = False

            If Me.PAYTYPE = btn_narmal.Tag Then
                Return True
            End If

            Dim log_value As New ConfirmpayModels_log

            Dim PAYMENT_CODE As String = ""
            If Me.PAYTYPE_value.SCAN_TYPE = "B&C" Then
                PAYMENT_CODE = txt_B_TO_C_payment_code.Text.Trim
            ElseIf Me.PAYTYPE_value.SCAN_TYPE = "C&B" Then
                PAYMENT_CODE = txt_C_TO_B_payment_code.Text.Trim
            Else
                Messages.Texts(Me.Text, "ไม่พบ Scan type !!!", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                Return False
            End If



            If PAYMENT_CODE = "" Then

                If txt_barcode_Normal.Text <> "" Then
                    'บางเคสมีการเปลี่ยนบาร์โค๊ตต้องส่งไปอัพ tr  ที่บันทึกไปแล้วด้วย
                    For Each val As SALE_Models.Saleitems_card In SALE_INT.Saleitems_card
                        val.BARCODE = txt_barcode_Normal.Text
                    Next
                    For Each val As SALE_Models.Cardtran In SALE_INT.Cardtran
                        val.BARCODE = txt_barcode_Normal.Text
                    Next
                End If
                If IsNothing(result_Payment_call) Then
                    result_Payment_call = New ConfirmpayModels_log
                End If



                If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_EDC Then

                    Select Case Center.SYS_Config.VENDOR_GETWAY
                        Case "GHL"
                            result_Payment_call = New GHL_EDC_Payment(Me.PAYTYPE, Me.PAYTYPE_value, Center.data_profile.EDC_IP).Conn_EDC(Center.SYS_Config.CONN_LINK, SALE_INT)
                            If IsNothing(result_Payment_call) Then Return False

                            Select Case result_Payment_call.PAY_STATE
                                Case "00"
                                    Me.txt_B_TO_C_payment_code.Text = result_Payment_call.PAYMENT_CODE
                                Case "01"
                                    Messages.Texts(Me.Text, "ไม่สามารถชำระได้เนื่องจากเงินไม่พอจ่าย กรุณาเติมเงิน !!!", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                                    'btn_close.Visible = True
                                    Return False
                                Case Else
                                    Messages.Texts(Me.Text, result_Payment_call.PAY_DESCRIPTION, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                                    Return False
                            End Select

                        Case Else
                            Messages.Texts(Me.Text, "Vendor Getway EDC ไม่ถูกต้อง", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                            Return False
                    End Select

                ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_API Then

                    Dim paycall As New Payment_center(Me.PAYTYPE, Me.PAYTYPE_value)
                    result_Payment_call = paycall.Payment_call(Me.cur_docno.Text, SALE_INT)
                    If Not IsNothing(result_Payment_call) Then
                        api_respon = True
                        Select Case Me.PAYTYPE.ToUpper
                            Case "THAIQR"
                                pbox_qtcode.Image = QR.Gen_QRcode(result_Payment_call.barcode)
                                Return False
                            Case "DOLFIN"
                                If result_Payment_call.PAY_DESCRIPTION = "200091" Then
                                    Me.txt_B_TO_C_payment_code.Text = result_Payment_call.PAYMENT_CODE
                                    Messages.Texts("เงินไม่พอจ่าย", " เงินในบัญชีไม่พอจ่ายหรือถูกจำกัดยอดจ่าย " & vbNewLine & " กรุณากด บันทึกเพื่อยืนยันเมื่อลูกค้าดำเนินการเติมเงินเรียบร้อยแล้ว " & vbNewLine & " หรือ กดยกเลิกเพื่อเริ่มรายการใหม่ ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                                    Return False
                                End If
                            Case "TRUEWALLET"
                                If result_Payment_call.PAY_DESCRIPTION = "success" Then
                                    Dim a = 1
                                    'Success 
                                ElseIf result_Payment_call.PAY_DESCRIPTION = "invalid_payment_code" Then
                                    Me.txt_B_TO_C_payment_code.Text = result_Payment_call.PAYMENT_CODE
                                    Messages.Texts("การแจ้งเตือน", " QR CODE ไม่ถูกต้องหรือซ้ำ กรุณาสแกนใหม่อีกครั้ง", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                                    Return False
                                ElseIf result_Payment_call.PAY_DESCRIPTION = "insufficient_fund" Then
                                    Me.txt_B_TO_C_payment_code.Text = ""
                                    Messages.Texts("การแจ้งเตือน", " ยอดเงินไม่พอจ่ายกรุณาเติมเงิน", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                                    Return False
                                ElseIf result_Payment_call.PAY_STATE = "failed" Then
                                    Me.txt_B_TO_C_payment_code.Text = ""
                                    Messages.Texts("การแจ้งเตือน", " ทำรายการจ่ายไม่สำเร็จ กรุณากดตรวจสอบ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                                    btn_Inquiry.Focus()
                                    Return False
                                Else
                                    Messages.Texts("การแจ้งเตือน", " ทำรายการจ่ายไม่สำเร็จ กรุณากดตรวจสอบ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                                    btn_Inquiry.Focus()
                                    Return False
                                End If
                        End Select
                    Else
                        api_respon = False
                        Return False
                    End If

                ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.APIHUBCPN Then

                    Dim cph As New CPN_Payment_Hub()
                    Dim val As New CPN_Payment_Hub.value_Models

                    val.barcode = SALE_INT.Saleitems_card(0).BARCODE
                    val.MRTSLIPNO = Me.cur_docno.Text
                    val.Payment_code = Me.PAYTYPE_value.CODE
                    val.totalPrice = SALE_INT.NETAMOUNT


                    cph.Repay = ""
                    result_Payment_call = cph.payment(cph.case_payment.Payment, val)
                    If Not IsNothing(result_Payment_call) Then
                        api_respon = True
                        If result_Payment_call.result_code = "0000" Then
                            If result_Payment_call.PAY_STATE = "SUCCESS" Then

                                txt_B_TO_C_payment_code.Text = result_Payment_call.PAYMENT_CODE
                                txt_B_TO_C_payment_code.BackColor = Color.DimGray
                                Me.save_count = 10 'เปิดเลย
                                Me.inquriry = 10 'เปิดเลย
                                'Success 
                            ElseIf result_Payment_call.PAY_STATE = "PENDING" Then
                                txt_B_TO_C_payment_code.Text = ""
                                txt_B_TO_C_payment_code.BackColor = Color.Red
                                'If (Messages.Texts("การแจ้งเตือน", "1. รอลูกค้ายืนยันการจ่ายเงิน " & vbNewLine & "2. กด Inquiry/ตรวจสอบ จนกว่าเลขที่จ่ายเงินจะขึ้น", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)) = DialogResult.OK Then
                                'End If
                                display("1. รอลูกค้ายืนยันการจ่ายเงิน " & vbNewLine & "  2. กด ยืนยันการชำระเงิน จนกว่าจะทำรายการสำเร็จ")
                                Return False
                            Else

                                Messages.Texts("การแจ้งเตือนจาก Payment Hub", "เอกสาร " & result_Payment_call.PAY_STATE, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                                display("เอกสาร " & result_Payment_call.PAY_STATE)
                                Return False
                            End If


                        Else
                            txt_B_TO_C_payment_code.Text = ""
                            txt_B_TO_C_payment_code.BackColor = Color.Red
                            'Messages.Texts("การแจ้งเตือนจาก Payment Hub", result_Payment_call.PAY_Remark, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                            display("การแจ้งเตือนจาก Payment Hub : " & result_Payment_call.PAY_Remark)
                            Return False
                        End If
                    Else
                        api_respon = False
                        txt_B_TO_C_payment_code.Text = ""
                        txt_B_TO_C_payment_code.US_Color_Didable = Color.Red
                        'Messages.Texts("การแจ้งเตือน", "ทำรายการจ่ายเงินไม่สำเร็จ กรุณาจ่ายใหม่อีกครั้ง หรือกด Inquiry เพื่อตรวจสอบ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                        display("ทำรายการจ่ายเงินไม่สำเร็จ กรุณากด ยืนยันการชำระเงิน เพื่อตรวจสอบ ถ้าไม่พบรายการจ่ายให้ทำการสแกนใหม่อีกครั้ง")
                        Return False
                    End If
                Else
                    Messages.Texts(Me.Text, "ไม่ได้กำหนดประเภท Getway Payment", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                    Return False
                End If
            End If


            If result_Payment_call.PAYMENT_CODE <> "" Then
                Me.txt_B_TO_C_payment_code.Text = result_Payment_call.PAYMENT_CODE

                ''log_value = New ConfirmpayModels_log
                'log_value.LOG_TYPE = "AFTER"
                'log_value.MRTSLIPNO = Me.cur_docno.Text
                'log_value.MERCHAND_ID = PAYTYPE_value.MERCHAND_ID
                'log_value.APP_ID = PAYTYPE_value.APP_ID
                'log_value.PAYMENT_CODE = result_Payment_call.PAYMENT_CODE
                'log_value.PAY_AMOUNT = result_Payment_call.PAY_AMOUNT
                'log_value.PAY_STATE = "SUCESS"
                'log_value.PAY_DESCRIPTION = result_Payment_call.PAY_DESCRIPTION
                'log_value.PAY_Remark = result_Payment_call.PAY_Remark
                'Pay_log(log_value)

                pay_success = True
                If Me.payconfirm_save(result_Payment_call.PAYMENT_CODE, Me.cur_docno.Text) Then
                    confirmpay_success = True
                Else
                    Messages.Texts(Me.Text, "ทำรายการจ่ายเงินออนไลน์สำเร็จ แต่บันทึกยืนยันการจ่ายในระบบ POS ไม่สำเร็จ " & vbNewLine & " กรุณากดบันทึกอีกครั้ง ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                    btn_ok.Focus()
                    Return False
                End If
            Else
                'log_value = New ConfirmpayModels_log
                log_value.LOG_TYPE = "AFTER"
                log_value.MRTSLIPNO = Me.cur_docno.Text
                log_value.MERCHAND_ID = PAYTYPE_value.MERCHAND_ID
                log_value.APP_ID = PAYTYPE_value.APP_ID
                log_value.PAYMENT_CODE = result_Payment_call.PAYMENT_CODE
                log_value.PAY_AMOUNT = result_Payment_call.PAY_AMOUNT
                log_value.PAY_STATE = "FALSE"
                log_value.PAY_DESCRIPTION = ""
                log_value.PAY_Remark = ""
                Pay_log(log_value)

                Messages.Texts(Me.Text, " ทำรายการจ่ายเงินไม่สำเร็จ กรุณาตรวจสอบรายการจ่ายเงินถ้าเลขที่จ่ายขึ้นให้กดบันทึกยืนยันการจ่าย " & vbNewLine & " หากไม่พบให้ดำเนินการจ่ายเงินอีกครั้ง ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                Return False
            End If


            If Me.confirmpay_success = False Then
                If Me.payconfirm_save(result_Payment_call.PAYMENT_CODE, Me.cur_docno.Text) Then
                    confirmpay_success = True
                Else
                    Messages.Texts(Me.Text, "ทำรายการจ่ายเงินออนไลน์สำเร็จ แต่บันทึกยืนยันการจ่ายในระบบ POS ไม่สำเร็จ " & vbNewLine & " กรุณากดบันทึกอีกครั้ง ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                    Return False
                End If
            End If

            If print = "print" And confirmpay_success = True Then
                If obj_main.chk_Print.CheckState = CheckState.Unchecked Then
                    obj_main.FPrint_inv(SALE_INT.Multicard)
                End If

                If Me.PAYTYPE_value.CODE = "THQR" Then
                    'If (Messages.Texts("การแจ้งเตือน", "คุณต้องการ Verify slip หรือไม่ ", Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Question) = DialogResult.Yes) Then

                    'Else
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                    'End If

                Else
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If



            End If
            Return True

        Catch ex As Exception
            Throw ex
        Finally
            Me.tab_payment.SelectTab(B_TO_C)
        End Try
    End Function
    Private Function Pay_Inquiry()
        Try
            If Me.cur_docno.Text = "" Then
                Messages.Texts(Me.Text, "ไม่พบรายการจ่ายกรุณาแสกนใหม่", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                Return False
            End If

            If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_EDC Then
                Messages.Texts(Me.Text, "รอ EDC ทำ Inquiry ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
            ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_API Then


                Dim paycall As New Payment_center(Me.PAYTYPE, Me.PAYTYPE_value)
                result_Payment_call = paycall.Inquiry_call(Me.cur_docno.Text)

                If result_Payment_call Is Nothing Then
                    Throw New Exception("Value Is Nothing")
                ElseIf Me.PAYTYPE_value.SCAN_TYPE = "B&C" Then
                    txt_B_TO_C_payment_code.Text = result_Payment_call.PAYMENT_CODE
                    Messages.Texts(Me.Text, "รายการเงินจ่ายออนไลน์สำเร็จ กรุณากดบันทึก", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                Else
                    txt_C_TO_B_payment_code.Text = ""
                End If
            ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.APIHUBCPN Then




                Dim cph As New CPN_Payment_Hub()
                Dim val As New CPN_Payment_Hub.value_Models

                val.barcode = SALE_INT.Saleitems_card(0).BARCODE
                val.MRTSLIPNO = Me.cur_docno.Text
                val.Payment_code = Me.PAYTYPE_value.CODE
                val.totalPrice = SALE_INT.NETAMOUNT



                result_Payment_call = cph.payment(cph.case_payment.Inquiry, val)
                If Not IsNothing(result_Payment_call) Then

                    If result_Payment_call.result_code = "0000" Then
                        If result_Payment_call.PAY_STATE = "SUCCESS" Then

                            txt_B_TO_C_payment_code.Text = result_Payment_call.PAYMENT_CODE
                            txt_B_TO_C_payment_code.BackColor = Color.DimGray
                            Me.save_count = 10 'เปิดเลย
                            Me.inquriry = 10 'เปิดเลย
                            'Success 

                            pay_call("print", False)



                        ElseIf result_Payment_call.PAY_STATE = "PENDING" Then
                            txt_B_TO_C_payment_code.Text = ""
                            txt_B_TO_C_payment_code.BackColor = Color.Red
                            'Messages.Texts("การแจ้งเตือน", "รอลูกค้ายืนยันการจ่ายเงิน", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                            display("รอลูกค้ายืนยันการจ่ายเงิน")
                            Return False
                        Else
                            'Messages.Texts("การแจ้งเตือนจาก Payment Hub", "เอกสาร " & result_Payment_call.PAY_STATE & " กรุณาลองใหม่อีกครั้ง", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                            display("การแจ้งเตือนจาก Payment Hub : " & "เอกสาร " & result_Payment_call.PAY_STATE & " กรุณาลองใหม่อีกครั้ง")
                            Return False
                        End If

                        'Messages.Texts("การแจ้งเตือน", "ตรวจสอบรายการจ่ายสำเร็จเลขที่ : " & result_Payment_call.PAYMENT_CODE, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)

                        'Success 

                    Else
                        If result_Payment_call.result_code = "4001" Then
                            Me.save_count = 10 'เปิดเลย
                            Me.inquriry = 10 'เปิดเลย
                        End If
                        txt_B_TO_C_payment_code.Text = ""
                        txt_B_TO_C_payment_code.BackColor = Color.Red
                        'Messages.Texts("การแจ้งเตือนจาก Payment Hub", result_Payment_call.PAY_Remark, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                        display("การแจ้งเตือนจาก Payment Hub : " & result_Payment_call.PAY_Remark)
                        Return False
                    End If
                Else
                    txt_B_TO_C_payment_code.Text = ""
                    txt_B_TO_C_payment_code.US_Color_Didable = Color.Red
                    Messages.Texts("การแจ้งเตือน", "ทำการตรวจสอบไม่สำเร็จ กรุณาลองใหม่อีกครั้ง ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    display("ทำการตรวจสอบไม่สำเร็จ กรุณาลองใหม่อีกครั้ง ")
                    Return False
                End If
            Else
                Messages.Texts(Me.Text, Cl_massage.EDC_msg_wallet_Notconfig, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            If ex.Message = "ยังไม่พบรายการจ่ายเงิน" Then
                Messages.Texts("การแจ้งเตือน", ex.Message, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
            Else
                Msg_err.Show_Err(ex, "Payment_center.Inquiry_call")
            End If
        End Try
    End Function
    Private Function Pay_Verify_slip()
        Try

            If Me.cur_docno.Text = "" Then
                Messages.Texts(Me.Text, "ไม่พบรายการจ่ายกรุณาแสกนใหม่", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                Return False
            End If

            If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_EDC Then
                Messages.Texts(Me.Text, "รอ EDC ทำ Inquiry ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
            ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_API Then


                Dim paycall As New Payment_center(Me.PAYTYPE, Me.PAYTYPE_value)
                result_Payment_call = paycall.Inquiry_call(Me.cur_docno.Text)

                If result_Payment_call Is Nothing Then
                    Throw New Exception("Value Is Nothing")
                ElseIf Me.PAYTYPE_value.SCAN_TYPE = "B&C" Then
                    txt_B_TO_C_payment_code.Text = result_Payment_call.PAYMENT_CODE
                    Messages.Texts(Me.Text, "รายการเงินจ่ายออนไลน์สำเร็จ กรุณากดบันทึก", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                Else
                    txt_C_TO_B_payment_code.Text = ""
                End If
            ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.APIHUBCPN Then

                Dim cph As New CPN_Payment_Hub()
                Dim val As New CPN_Payment_Hub.value_Models

                val.barcode = SALE_INT.Saleitems_card(0).BARCODE
                val.MRTSLIPNO = Me.cur_docno.Text
                val.Payment_code = Me.PAYTYPE_value.CODE
                val.totalPrice = SALE_INT.NETAMOUNT



                result_Payment_call = cph.payment(cph.case_payment.Verify_slip, val)
                If Not IsNothing(result_Payment_call) Then

                    If result_Payment_call.result_code = "0000" Then
                        'txt_B_TO_C_payment_code.Text = result_Payment_call.PAYMENT_CODE
                        'txt_B_TO_C_payment_code.BackColor = Color.DimGray
                        'Me.save_count = 10 'เปิดเลย
                        'Me.inquriry = 10 'เปิดเลย
                        Messages.Texts("การแจ้งเตือน", "ตรวจสอบรายการจ่ายสำเร็จเลขที่ : " & result_Payment_call.PAYMENT_CODE, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                        Me.Close()


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
                Messages.Texts(Me.Text, Cl_massage.EDC_msg_wallet_Notconfig, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            If ex.Message = "ยังไม่พบรายการจ่ายเงิน" Then
                Messages.Texts("การแจ้งเตือน", ex.Message, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
            Else
                Msg_err.Show_Err(ex, "Payment_center.Inquiry_call")
            End If
        End Try
    End Function
    Private Function Cancel_pending() As Boolean
        Try

            If Me.cur_docno.Text = "" Then
                'Messages.Texts(Me.Text, "ไม่พบเลขที่บิลขาย", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                display("ไม่พบเลขที่บิลขาย")
                Return False
            End If
            'Me.tab_payment.SelectTab(T_Waitpament)
            Dim Confirm As New ConfirmpayModels
            Confirm.mrt_slip = Me.cur_docno.Text
            Confirm.payment_id = ""
            Confirm.SHOPID = SALE_INT.SHOPID
            Confirm.typeid = ""
            Confirm.cused = 0
            Confirm.barcode = ""
            Confirm.cused1 = 0
            Confirm.clstatus = ""
            Confirm.clamount = ""
            Confirm.clreceive = 0
            Confirm.cpromotion = ""
            Confirm.tid = ""
            Confirm.uid = ""
            Confirm.tendor = ""
            Confirm.clupdate = ""
            Confirm.processdate = ""
            Confirm.remark = ""


            Dim json As String = JsonConvert.SerializeObject(Confirm)
            Dim siteUri As New Uri(Center.Data_Config.API + Center.Link_API.Post_API.CARDTRANS_confirm_Sale_cancel)
            Dim ret = New API(Center.Data_Config.API).POSTResponse(siteUri, json, "POST", "")
            Dim retValue As SALE_Models.value = JsonConvert.DeserializeObject(Of SALE_Models.value)(ret)
            If retValue.Respon.Result Then
                'แสดงผลที่ referrent แทน
                'Messages.Texts("การแจ้งเตือน", "ทำรายการยกเลิกสำเร็จ : " & result_Payment_call.PAYMENT_CODE, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                'Me.DialogResult = DialogResult.Cancel
                ' Me.Close()
                Return True
            Else
                If retValue.Respon.SystemErrorMessage <> "" Then
                    'จากระบบ
                    Throw New Exception(retValue.Respon.SystemErrorMessage)
                Else
                    Messages.Texts(Me.Text, retValue.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                    Return False
                End If
            End If
        Catch ex As Exception
            If ex.Message = "ยังไม่พบรายการจ่ายเงิน" Then
                Messages.Texts("การแจ้งเตือน", ex.Message, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
            Else
                Msg_err.Show_Err(ex, "Payment_center.Inquiry_call")
            End If
            Return False
        Finally
            Me.tab_payment.SelectTab(B_TO_C)
        End Try
    End Function
    Private Function pay_Cancel() As Boolean
        Try
            'If Me.txt_B_TO_C_payment_code.Text = "" Then
            '    'Messages.Texts(Me.Text, "ไม่พบรายการจ่ายกรุณาแสกนใหม่", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
            '    display("ไม่พบรายการจ่ายกรุณาแสกนใหม่")
            '    Return False
            'End If

            If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_EDC Then
                Messages.Texts(Me.Text, "รอ EDC ทำ Inquiry ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
            ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_API Then


                Dim paycall As New Payment_center(Me.PAYTYPE, Me.PAYTYPE_value)
                result_Payment_call = paycall.Inquiry_call(Me.cur_docno.Text)

                If result_Payment_call Is Nothing Then
                    Throw New Exception("Value Is Nothing")
                ElseIf Me.PAYTYPE_value.SCAN_TYPE = "B&C" Then
                    txt_B_TO_C_payment_code.Text = result_Payment_call.PAYMENT_CODE
                    Messages.Texts(Me.Text, "รายการเงินจ่ายออนไลน์สำเร็จ กรุณากดบันทึก", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                Else
                    txt_C_TO_B_payment_code.Text = ""
                End If
            ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.APIHUBCPN Then




                Dim cph As New CPN_Payment_Hub()
                Dim val As New CPN_Payment_Hub.value_Models

                val.barcode = SALE_INT.Saleitems_card(0).BARCODE
                val.MRTSLIPNO = Me.cur_docno.Text
                val.Payment_code = Me.PAYTYPE_value.CODE
                val.totalPrice = SALE_INT.NETAMOUNT



                result_Payment_call = cph.payment(cph.case_payment.Cancel, val)
                If Not IsNothing(result_Payment_call) Then

                    If result_Payment_call.result_code = "0000" Or result_Payment_call.result_code = "4003" Then
                        Cancel_pending()
                        Return True
                    Else
                        txt_B_TO_C_payment_code.Text = ""
                        txt_B_TO_C_payment_code.US_Color_Didable = Color.Red
                        'Messages.Texts("การแจ้งเตือนจาก Payment Hub", result_Payment_call.PAY_Remark, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                        display("การแจ้งเตือนจาก Payment Hub : " & result_Payment_call.PAY_Remark)
                        Return False
                    End If
                Else
                    txt_B_TO_C_payment_code.Text = ""
                    txt_B_TO_C_payment_code.US_Color_Didable = Color.Red
                    'Messages.Texts("การแจ้งเตือน", "ทำรายการยกเลิกไม่สำเร็จ กรุณาลองใหม่อีกครั้ง ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    display("ทำรายการยกเลิกไม่สำเร็จ กรุณาลองใหม่อีกครั้ง ")
                    Return False
                End If
            Else
                Messages.Texts(Me.Text, Cl_massage.EDC_msg_wallet_Notconfig, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            If ex.Message = "ยังไม่พบรายการจ่ายเงิน" Then
                Messages.Texts("การแจ้งเตือน", ex.Message, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
            Else
                Msg_err.Show_Err(ex, "Payment_center.Inquiry_call")
            End If
        End Try
    End Function
    Public Function payconfirm_save(payment_id As String, mrt_slip As String) As Boolean
        Try
            'Dim drow As DataRow = Get_tender(Me.PAYTYPE)
            For i As Integer = 1 To 2

                Dim Confirm As New ConfirmpayModels
                Confirm.mrt_slip = mrt_slip
                Confirm.payment_id = payment_id
                Confirm.SHOPID = Center.data_profile.SHOPID



                Confirm.typeid = ""
                Confirm.cused = 1
                Confirm.barcode = Me.SALE_INT.Cardtran(0).BARCODE
                Confirm.cused1 = 1
                Confirm.clstatus = "S"
                Confirm.clamount = Me.SALE_INT.NETAMOUNT
                Confirm.clreceive = Me.SALE_INT.NETAMOUNT
                Confirm.cpromotion = "0"
                Confirm.tid = Center.data_profile.TERMINAL_TID
                Confirm.uid = Center.data_profile.TERMINAL_TID
                Confirm.tendor = PAYTYPE_value.CODE
                Confirm.clupdate = ""
                Confirm.processdate = ""
                Confirm.remark = ""

                Dim payment As New confirmpay
                payment.payment = Confirm
                payment.SALE_INT = Me.SALE_INT
                'ไม่ต้องส่งให้เปลือง 
                payment.SALE_INT.Saleitems = Nothing
                payment.SALE_INT.Saleitems_card = Nothing

                Dim json As String = JsonConvert.SerializeObject(payment)
                Dim siteUri As New Uri(Center.Data_Config.API + Center.Link_API.Post_API.CARDTRANS_confirmpay)
                Dim ret = New API(Center.Data_Config.API).POSTResponse(siteUri, json, "POST", "")
                Dim retValue As SALE_Models.value = JsonConvert.DeserializeObject(Of SALE_Models.value)(ret)
                If retValue.Respon.Result Then
                    Return True
                Else
                    If i >= 2 Then
                        If retValue.Respon.SystemErrorMessage <> "" Then
                            'จากระบบ
                            Throw New Exception(retValue.Respon.SystemErrorMessage)
                        Else
                            Messages.Texts(Me.Text, retValue.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                            Return False
                        End If
                    End If
                End If
                System.Threading.Thread.Sleep(3000)
            Next
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
            Return False
        End Try

    End Function

    Public Function Pay_log(value As ConfirmpayModels_log) As Boolean
        Try

            'Dim Confirm As New ConfirmpayModels_log

            'Confirm.pid = 0
            'Confirm.typeid = PAYTYPE_value.TID
            'Confirm.barcode = Me.SALE_INT.Saleitems_card(0).BARCODE
            'Confirm.clstatus = "S"
            'Confirm.clamount = Me.SALE_INT.NETAMOUNT
            'Confirm.clreceive = 0
            'Confirm.cpromotion = 0
            'Confirm.tid = Center.data_profile.TERMINAL_TID
            'Confirm.uid = Center.data_profile.POSID
            'Confirm.tendor = PAYTYPE_value.CODE
            'Confirm.clupdate = ""
            'Confirm.processdate = ""
            'Confirm.Remark = ""

            'Confirm.SHOPID = Center.data_profile.SHOPID
            'Confirm.POSID = Center.data_profile.POSID

            'Confirm.LOG_TYPE = value.LOG_TYPE
            'Confirm.MRTSLIPNO = value.MRTSLIPNO
            'Confirm.MERCHAND_ID = value.MERCHAND_ID
            'Confirm.APP_ID = value.APP_ID
            'Confirm.PAYMENT_CODE = value.PAYMENT_CODE
            'Confirm.PAY_AMOUNT = value.PAY_AMOUNT
            'Confirm.PAY_STATE = value.PAY_STATE
            'Confirm.PAY_DESCRIPTION = value.PAY_DESCRIPTION
            'Confirm.PAY_Remark = value.PAY_Remark



            'Dim json As String = JsonConvert.SerializeObject(Confirm)
            'Dim siteUri As New Uri(Center.Data_Config.API + Center.Link_API.Post_API.CARDTRANS_confirmpay_log)
            'Dim ret = New API(Center.Data_Config.API).POSTResponse(siteUri, json, "POST", "")
            'Dim retValue As SALE_Models.value = JsonConvert.DeserializeObject(Of SALE_Models.value)(ret)

            Return True
            'If retValue.Respon.Result Then
            '    Return True
            'Else
            '    If retValue.Respon.SystemErrorMessage <> "" Then
            '        'จากระบบ
            '        Throw New Exception(retValue.Respon.SystemErrorMessage)
            '    Else
            '        Messages.Texts(Me.Text, retValue.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
            '        Return False
            '    End If
            'End If

        Catch ex As Exception
            'Msg_err.Show_Err(ex, Me.Text)
            Return True
        End Try
    End Function


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.PAYTYPE <> "NOSELECT" Then
            'txt_barcode_Normal.Enabled = True
            txt_barcode_Normal.Focus()

        End If
    End Sub
#End Region
    Private Sub ShowControl()
        If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.APIHUBCPN Then

            If IS_CASHcard Then
                fl_cardtype_api.Dock = DockStyle.Fill
                fl_cardtype_api.BringToFront()
                fl_paymenthub_cpn.Visible = False

                btn_Inquiry.Visible = True
                'btn_Verify_slip.Visible = True
                'btn_Cancel.Visible = True
            Else

                fl_paymenthub_cpn.Dock = DockStyle.Fill
                fl_paymenthub_cpn.BringToFront()
                fl_cardtype_api.Visible = False

                btn_Inquiry.Visible = True
                'btn_Verify_slip.Visible = True
                'btn_Cancel.Visible = True
            End If

        Else
            fl_cardtype_api.Dock = DockStyle.Fill
            fl_cardtype_api.BringToFront()
            fl_paymenthub_cpn.Visible = False

            btn_Inquiry.Visible = True
            'btn_Verify_slip.Visible = True
            'btn_Cancel.Visible = True
        End If
    End Sub

    Private Sub ClearControl()
        Gencolumn_Normal()
        txt_barcode_Normal.Text = ""
        txt_Amount.Text = obj_main.txt_Amount.Text
        txt_pay_Amount.Text = 0
        txt_amount_remain.Text = obj_main.txt_Amount.Text

        txt_TrueAmount.Text = obj_main.txt_Amount.Text
        txt_QrthaiAmount.Text = obj_main.txt_Amount.Text
        Me.txt_B_TO_C_payment_code.Text = ""
    End Sub
#Region "card Normal"
    Public Sub Gencolumn_Normal()
        Try
            Me.DGV_Card_Normal.AutoGenerateColumns = False
            Me.DGV_Card_Normal.Columns.Clear()
            Dim Col As New DataGridViewTextBoxColumn
            'Dim btn As New DataGridViewButtonColumn
            'Dim Chk As New DataGridViewCheckBoxColumn
            Dim read As Boolean = True

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "รายการที่"
            Col.Width = 100
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "SEQ"
            Col.Name = "SEQ"
            Me.DGV_Card_Normal.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "บาร์โค๊ด"
            'Col.Width = 300
            Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "BARCODE"
            Col.Name = "BARCODE"
            Me.DGV_Card_Normal.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "CARDTYPE"
            Col.Width = 80
            'Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "CARDTYPE"
            Col.Name = "CARDTYPE"
            Me.DGV_Card_Normal.Columns.Add(Col)




            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "รอบที่"
            Col.Width = 80
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "CUSED"
            Col.Name = "CUSED"
            Me.DGV_Card_Normal.Columns.Add(Col)
            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "รอบที่"
            Col.Width = 100
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "CUSED1"
            Col.Name = "CUSED1"
            Me.DGV_Card_Normal.Columns.Add(Col)


            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "จำนวนเงิน"
            Col.Width = 100
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "MRTAMOUNT"
            Col.Name = "MRTAMOUNT"
            Me.DGV_Card_Normal.Columns.Add(Col)
            'Me.DGV_Product.AutoResizeColumns()

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "จำนวนเงินปัจจุบัน"
            Col.Width = 80
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "CBALANCE"
            Col.Name = "CBALANCE"
            Me.DGV_Card_Normal.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "CBALANCEREMAIN"
            Col.Width = 80
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "CBALANCEREMAIN"
            Col.Name = "CBALANCEREMAIN"
            Me.DGV_Card_Normal.Columns.Add(Col)




            Me.dt_card.Rows.Clear()
            Me.dt_card.Columns.Clear()
            With Me.dt_card.Columns
                .Add("SEQ")
                .Add("BARCODE")
                .Add("PAYTYPE")
                .Add("CUSED")
                .Add("CUSED1")
                .Add("MRTAMOUNT", GetType(Decimal))
                .Add("CBALANCE", GetType(Decimal))
                .Add("CBALANCEREMAIN", GetType(Decimal))
            End With
            DGV_Card_Normal.DataSource = Me.dt_card

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try

    End Sub

    '#Region "Promotion"
    '    ''' <summary>
    '    ''' call fixed pro 19 
    '    ''' </summary>
    '    ''' <param name="barcode"></param>
    '    ''' <returns></returns>
    '    Private Function Chk_pro(barcode As String) As Boolean
    '        Try

    '            Dim CHKcard_Pro As New CHKcard_MultiModels
    '            Dim ret As New Card_pro.value

    '            CHKcard_Pro.BARCODE = Me.txt_barcode_Normal.Text
    '            CHKcard_Pro.Nettotel = 0

    '            Dim json As String = JsonConvert.SerializeObject(CHKcard_Pro)
    '            Dim siteUri As New Uri(Center.Data_Config.API + Center.Link_API.Post_API.CardsCL_card_pro)
    '            Dim retValue = New API(Center.Data_Config.API).POSTResponse(siteUri, json, "POST", "")
    '            ret = (JsonConvert.DeserializeObject(Of Card_pro.value)(retValue))
    '            If ret.Respon.Result Then
    '                If ret.Data.Count > 0 Then
    '                    If obj_main.dt_paroduct.Rows.Count > 1 Then
    '                        Throw New Exception("บัตร โปร 19 ทรูพอยท์ ฟรีน้ำคริสตัล 1 ขวด  " & vbNewLine & " สามารถทำรายการขายได้ 1 รายการเท่านั้น ")
    '                    End If
    '                    If obj_main.dt_paroduct.Rows(0)("FOODID") = "14" Then
    '                        Return True
    '                    Else
    '                        Throw New Exception("บัตร โปร 19 ทรูพอยท์ ฟรีน้ำคริสตัล 1 ขวด  " & vbNewLine & " สามารถทำรายการขายได้ กับสินค้า น้ำเปล่า ไม่เย็น  เท่านั้น ")
    '                        Return False
    '                    End If
    '                Else
    '                    Return True
    '                    'Throw New Exception("ไม่พบโปรโมชั่น  โปร 19 ทรูพอยท์ ฟรีน้ำคริสตัล 1 ขวด   " & vbNewLine & " บัตร " & barcode)
    '                End If
    '            Else

    '                If ret.Respon.SystemErrorMessage <> "" Then
    '                    Throw New Exception(ret.Respon.SystemErrorMessage)
    '                Else
    '                    Messages.Texts(Me.Text, ret.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
    '                End If

    '            End If

    '        Catch ex As Exception
    '            Msg_err.Show_Err(ex, Me.Text)
    '            Return False
    '        End Try
    '    End Function



    '#End Region


    Private Sub scan_barcode_Normal(ByVal brnid As String)
        Try

            If Not chkbarcode() Then
                Exit Sub
            End If


            Dim CHKcard_MultiModels As New CHKcard_MultiModels
            Dim ret As New CHK_cardsModels.value

            CHKcard_MultiModels.BARCODE = Me.txt_barcode_Normal.Text
            CHKcard_MultiModels.BRNID = brnid
            CHKcard_MultiModels.Nettotel = CInt(txt_amount_remain.Text)
            CHKcard_MultiModels.SHOPID = Center.data_profile.SHOPID
            CHKcard_MultiModels.workdate = New CL_date().Condate(Center.date_now, "yyyy/MM/dd HH:mm:ss", "TH")
            Dim Link_API As String
            If Center.SYS_Config.POSTYPE = F_Setting.RB_postpaid.Tag Then
                Link_API = Center.Link_API.Get_API.CARDTRANS_Sel_CHKcard_Postpaid
            Else
                Link_API = Center.Link_API.Get_API.CARDTRANS_CHKcard_Multi
            End If

            Dim json As String = JsonConvert.SerializeObject(CHKcard_MultiModels)
            Dim siteUri As New Uri(Center.Data_Config.API + Link_API)
            Dim retValue = New API(Center.Data_Config.API).POSTResponse(siteUri, json, "POST", "")
            ret = (JsonConvert.DeserializeObject(Of CHK_cardsModels.value)(retValue))



            If ret.Respon.Result Then
                If ret.Data.Count > 0 Then

a:
                    If Me.txt_barcode_Normal.Text.Substring(0, 1) = "P" Then
                        Dim promotion As New Sale_Promotion
                        If Not promotion.Chk_promotion(Me.txt_barcode_Normal.Text, obj_main.dt_paroduct) Then
                            Exit Sub
                        End If
                    End If
                    DGV_Product_Add(ret.Data(0))
                    calTotel()
                    If CInt(Me.txt_amount_remain.Text) = 0 Then
                        Me.FSave()
                    End If
                End If
            Else
                If ret.Respon.Result_value = "BROKE" Then
                    If Center.SYS_Config.CUSGROUP = CL_constan.CUSGROUP.ATR Then
                        Messages.Texts(Me.Text, ret.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                        Me.Close()
                    Else
                        GoTo a
                    End If
                Else
                    If ret.Respon.SystemErrorMessage <> "" Then
                        Throw New Exception(ret.Respon.SystemErrorMessage)
                    Else
                        Messages.Texts(Me.Text, ret.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                    End If
                End If

            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
            'Return "0"
        End Try
    End Sub

    Private Function chkbarcode() As Boolean
        Dim drow() As DataRow
        If Me.dt_card.Rows.Count > 1 Then
            If Center.Data_Config.MultiCards = F_Setting.rd_multicard_D.Tag Then
                Messages.Texts(Me.Text, "ขออภัย!!! ร้านค้านี้ไม่ได้ตั้งค่าให้มีการต่อบัตร", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                Return False
            End If
        End If
        drow = Me.dt_card.Select("BARCODE = '" & Me.txt_barcode_Normal.Text & "'")
        If drow.Length > 0 Then
            Messages.Texts(Me.Text, "บาร์โค๊ด " & Me.txt_barcode_Normal.Text & " ถูกใช้แล้ว", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
            Return False
        End If
        If dt_card.Rows.Count > (5 - 1) Then
            Messages.Texts(Me.Text, "ขออภัย ต่อบัตรได้ไม่เกิน 5 ใบ !!! ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
            Return False
        End If
        Return True
    End Function
    Private Sub calTotel()
        Try
            If Me.dt_card.Rows.Count <= 0 Then
                Me.ClearControl()
                Exit Sub
            End If
            txt_pay_Amount.Text = Me.dt_card.Compute("sum(MRTAMOUNT)", "")
            txt_amount_remain.Text = CInt(txt_Amount.Text) - CInt(txt_pay_Amount.Text)
            If CInt(txt_amount_remain.Text) > 0 Then
                Me.txt_barcode_Normal.US_Enable = True
                Me.txt_barcode_Normal.ForeColor = Color.DimGray
                'Me.Timer1.Enabled = True
            Else
                Me.txt_barcode_Normal.US_Enable = False
                Me.txt_barcode_Normal.ForeColor = Color.White
                'Me.Timer1.Enabled = False
            End If
        Catch ex As Exception
            txt_pay_Amount.Text = 0
            txt_amount_remain.Text = 0
        End Try
    End Sub

    Private Sub DGV_Product_Add(val As CHK_cardsModels.Model)
        Try

            Dim drow As DataRow
            drow = dt_card.NewRow
            drow("SEQ") = dt_card.Rows.Count + 1
            drow("BARCODE") = val.BARCODE
            drow("PAYTYPE") = Me.PAYTYPE
            drow("CUSED") = val.CUSED
            drow("CUSED1") = val.CUSED1
            Dim cbal As Double = 0
            If (val.CBALANCE >= Int(txt_amount_remain.Text)) Then
                cbal = txt_amount_remain.Text
            Else
                cbal = val.CBALANCE
            End If
            drow("MRTAMOUNT") = cbal
            drow("CBALANCE") = val.CBALANCE
            drow("CBALANCEREMAIN") = IIf(val.CBALANCE - Int(txt_amount_remain.Text) <= 0, 0, val.CBALANCE - Int(txt_amount_remain.Text))
            Me.dt_card.Rows.Add(drow)
            DGV_Card_Normal.DataSource = Me.dt_card
            Me.dt_card.AcceptChanges()

            row_focus()

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
#End Region
    Private Function DGV_Product_Add2(val As String) As Boolean
        Try
            dt_card.Rows.Clear()
            dt_card.AcceptChanges()
            Dim drow As DataRow
            drow = dt_card.NewRow
            drow("SEQ") = dt_card.Rows.Count + 1
            drow("BARCODE") = val
            drow("PAYTYPE") = Me.PAYTYPE
            drow("CUSED") = 1
            drow("CUSED1") = 1

            drow("MRTAMOUNT") = 0
            drow("CBALANCE") = 0
            drow("CBALANCEREMAIN") = 0
            Me.dt_card.Rows.Add(drow)
            DGV_Card_Normal.DataSource = Me.dt_card
            Me.dt_card.AcceptChanges()

            row_focus()

            Return True
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
            Return False
        End Try
    End Function
    Private Sub close_form()
        Try

            If Me.pay_success = False Or Me.confirmpay_success = False Then
                If Messages.Texts(Me.Text, "การบันทึกจ่ายเงินยังไม่สำเร็จ คุณแน่ใจหรือไม่ว่าต้องการปิดการทำงาน ", Messages.ButtonType.OKCancel, Messages.MessageBoxIcon.Stopp) = DialogResult.OK Then
                    If IsNothing(result_Payment_call) Then
                        result_Payment_call = New ConfirmpayModels_log
                    End If
                    If Me.cur_docno.Text = "" Then
                        Me.DialogResult = DialogResult.Cancel
                        Me.Close()
                    Else
                        'If api_respon = False Then
                        'ถ้าไม่มีการตอบกลับให้ถามก่อน

                        If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.APIHUBCPN Then

                            If result_Payment_call.PAY_STATE = "PENDING" Then

                                If Messages.Texts(Me.Text, "พบรายการรอลูกค้ายืนยันการจ่ายเงิน " & vbNewLine &
                                      " ตอบ Yes เพื่อยืนยันการชำระเงิน " & vbNewLine &
                                      " ตอบ NO เพื่อออกและทำรายการค้างชำระภายหลัง", Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Stopp) = DialogResult.Yes Then
                                    Exit Sub
                                Else
                                    Me.Close()
                                End If

                            Else
                                If Me.api_respon Then 'ถ้ามีการตอบกลับเคสนี้คือยังไม่เกิดเอกสาร ที่ e-wallet
                                    Me.Cancel_pending()
                                    Me.Close()

                                Else 'ถ้าไม่มีการตอบกลับให้แจ้งเตือนก่อน เผื่อมีการตอบกลับไม่สำเร็จ
                                    If Messages.Texts(Me.Text, "พบรายการค้างจ่ายในระบบ food ที่ไม่ได้รับการตอบกลับจาก E-WALLET " & vbNewLine &
                                          " ตอบ Yes เพื่อยืนยันการชำระเงิน " & vbNewLine &
                                          " ตอบ NO เพื่อออกและทำรายการค้างชำระภายหลัง", Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Stopp) = DialogResult.Yes Then
                                        Exit Sub
                                    Else
                                        Me.Close()
                                    End If

                                End If
                            End If

                        Else
                            Dim paycall As New Payment_center(Me.PAYTYPE, Me.PAYTYPE_value)
                            result_Payment_call = paycall.Cancel_call(Me.cur_docno.Text, SALE_INT)
                            If result_Payment_call.PAY_STATE = False Then
                                If Messages.Texts(Me.Text, "ยกเลิกรายการ " & Me.PAYTYPE & " ไม่สำเร็จ กด YES เพื่อดำเนินการยกเลิกใหม่ หรือกด NO เพื่อทำรายการค้างชำระภายหลัง", Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Stopp) = DialogResult.No Then
                                    Exit Sub
                                End If
                            End If
                            Me.Close()
                        End If




                        'Else
                        '    'ถ้ามีการตอบกลับให้ยกเลิกไม่ได้เลย
                        '    Cancel_pending()
                        '     Me.Close()
                        'End If
                    End If
                Else
                    'If Me.PAYTYPE_value.CODE = "THQR" Then
                    '    If (Messages.Texts("การแจ้งเตือน", "คุณต้องการ Verify slip หรือไม่ ", Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Question) = DialogResult.Yes) Then
                    '        Exit Sub
                    '    End If
                    'End If
                End If

            End If

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
    Private Sub del_last()
        Try
            If Me.DGV_Card_Normal.RowCount > 0 Then
                Me.DGV_Card_Normal.Rows.Remove(Me.DGV_Card_Normal.CurrentRow)
                Me.dt_card.AcceptChanges()
                calTotel()
                If Me.DGV_Card_Normal.RowCount > 0 Then
                    Me.DGV_Card_Normal.CurrentRow.Selected = True
                End If
                Dim i As Integer = 1
                For Each row As DataGridViewRow In Me.DGV_Card_Normal.Rows
                    row.Cells("SEQ").Value = i
                    i += 1
                Next
                row_focus()
            Else
                ClearControl()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub row_focus()
        If Me.DGV_Card_Normal.RowCount <= 0 Then Exit Sub
        Me.DGV_Card_Normal.Rows.Item(0).Selected = False
        Dim row As Integer = Me.DGV_Card_Normal.RowCount - 1
        Me.DGV_Card_Normal.FirstDisplayedScrollingRowIndex = row
        Me.DGV_Card_Normal.Rows.Item(row).Selected = True
    End Sub

    Private Sub F_payment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.obj_main = Nothing
        Me.PAYTYPE = Nothing
        Me.PAYTYPE_value = Nothing
        Me.dt_card = Nothing
        Me.SALE_INT = Nothing
    End Sub
    Dim display_blink = 0
    Private Sub Timer_blink_Tick(sender As Object, e As EventArgs) Handles Timer_blink.Tick
        Try

            If display_blink < 3 Then
                If RT_display.BackColor = Color.Gold Then
                    RT_display.BackColor = Color.Red
                Else
                    RT_display.BackColor = Color.Gold
                End If
                display_blink += 1
            Else '
                Timer_blink.Enabled = False
                RT_display.BackColor = Color.Gold
                display_blink = 0
            End If


        Catch ex As Exception

        End Try
    End Sub
End Class