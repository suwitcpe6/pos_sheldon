Imports Newtonsoft.Json
Imports Control_us
Imports MD

Public Class F_Repay
    Public data_repay As New List(Of SALE_Models.RepayModel)
    Dim obj_main As New F_Main_Sale
    Sub New(ByRef Val As F_Main_Sale)
        obj_main = Val
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub F_Repay_Load(sender As Object, e As EventArgs) Handles Me.Load
        setEvent()
        Loaddata_Repay()
        Gencolumn_Normal()
        Load_grid()
    End Sub

    Private Sub setEvent()
        'text KeyDown
        'AddHandler Me.txt_barcode_Normal.KeyDown, AddressOf Ev_Text_KeyDown

        ''text Text_Changed
        'AddHandler Me.txt_amount_remain.TextChanged, AddressOf Ev_Text_Changed
        'AddHandler Me.txt_pay_Amount.TextChanged, AddressOf Ev_Text_Changed

        'btn Click


        AddHandler Me.btn_Start.Click, AddressOf Ev_Btn_Click
        AddHandler Me.btn_del.Click, AddressOf Ev_Btn_Click
        AddHandler Me.btn_close.Click, AddressOf Ev_Btn_Click

    End Sub
#Region "Event"
    Private Sub Ev_Text_Changed(sender As Object, e As EventArgs)
        'If sender.name = txt_amount_remain.Name Or sender.name = txt_Amount.Name Then
        '    If CInt(txt_amount_remain.Text) > 0 Then
        '        txt_amount_remain.BackColor = Color.Red
        '        txt_pay_Amount.BackColor = Color.Red
        '    Else
        '        txt_amount_remain.BackColor = Color.DimGray
        '        txt_pay_Amount.BackColor = Color.DimGray
        '    End If
        'End If
    End Sub
    Private Sub Ev_Text_KeyDown(sender As Object, e As KeyEventArgs)

        'Select Case sender.name
        '    Case txt_barcode_Normal.Name
        '        If e.KeyCode = Keys.Enter Then
        '            Try
        '                txt_barcode_Normal.US_Enable = False
        '                If txt_barcode_Normal.Text = "" Then
        '                    Exit Sub
        '                End If

        '                Me.Timer1.Enabled = False
        '                If lbl_confirm.Tag Then
        '                    pay_Scan()
        '                End If


        '                txt_barcode_Normal.US_Enable = True
        '                Me.Timer1.Enabled = True

        '            Catch ex As Exception
        '                'Msg_err.Show_Err(ex, Me.Text)
        '                txt_barcode_Normal.Clear()
        '            Finally
        '                txt_barcode_Normal.US_Enable = True
        '                Me.Timer1.Enabled = True
        '                'Dim aa = Me.DGV_Card_Normal.RowCount
        '                'Console.WriteLine(txt_barcode_Normal.Text & " : " & aa)
        '            End Try
        '        End If
        'End Select

    End Sub

    Private Sub Ev_Btn_Click(sender As Object, e As EventArgs)

        Select Case sender.name

            Case btn_Start.Name
                Repay_SAVE()
            Case btn_del.Name
                If Me.DGV_Card_Normal.Rows.Count <= 0 Then
                    Exit Sub
                End If
                If Me.DGV_Card_Normal.CurrentRow.Cells("MRTSLIPNO").Value IsNot Nothing Then
                    Me.cancel(Me.DGV_Card_Normal.CurrentRow.Cells("MRTSLIPNO").Value, Center.data_profile.SHOPID)
                Else
                    Messages.Texts("ยกเลิกรายการค้างจ่าย", "กรุณาเลือกรายการที่ต้องการยกเลิก", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                End If

            Case btn_close.Name
                Me.Dispose()
        End Select

    End Sub

#End Region
    Public Sub Gencolumn_Normal()
        Try
            DGV_Card_Normal.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))

            DGV_Card_Normal.DefaultCellStyle.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))


            Me.DGV_Card_Normal.AutoGenerateColumns = False
            Me.DGV_Card_Normal.Columns.Clear()
            Dim Col As New DataGridViewTextBoxColumn
            'Dim btn As New DataGridViewButtonColumn
            'Dim Chk As New DataGridViewCheckBoxColumn
            Dim read As Boolean = True

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ลำดับที่"
            Col.Width = 60
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "SEQ"
            Col.Name = "SEQ"
            Me.DGV_Card_Normal.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "เลขที่ใบขาย"
            Col.Width = 200
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "MRTSLIPNO"
            Col.Name = "MRTSLIPNO"
            Me.DGV_Card_Normal.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "วันที่/เวลา"
            Col.Width = 150
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "MRTLUPDATE"
            Col.Name = "MRTLUPDATE"
            Me.DGV_Card_Normal.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ประเภทบัตร"
            Col.Width = 150
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "CARDTENDOR_Name"
            Col.Name = "CARDTENDOR_Name"
            Me.DGV_Card_Normal.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "จำนวนเงิน"
            Col.Width = 100
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "MRTAMOUNT"
            Col.Name = "MRTAMOUNT"
            Me.DGV_Card_Normal.Columns.Add(Col)


            'Col = New DataGridViewTextBoxColumn
            'Col.HeaderText = "หลายเหตุ"
            ''Col.Width = 300
            'Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            'Col.Visible = True
            'Col.ReadOnly = read
            'Col.DataPropertyName = "remark"
            'Col.Name = "remark"
            'Me.DGV_Card_Normal.Columns.Add(Col)





        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try

    End Sub

    Public Function Loaddata_Repay() As Boolean
        Try
            If data_repay.Count > 0 Then Return False
            Dim ret2 As New SALE_Models.value_Repay
            Dim json2 = New API(Center.Data_Config.API, 10).GETSON(String.Format(Center.Link_API.Get_API.Sel_Repay, Center.data_profile.POSID))
            ret2 = (JsonConvert.DeserializeObject(Of SALE_Models.value_Repay)(json2))
            If ret2.Respon.Result Then
                data_repay = ret2.Data
                Return True
            Else
                If ret2.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret2.Respon.SystemErrorMessage.ToString)
                    Return False
                Else
                    Messages.Texts(Me.Text, ret2.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                    Return False
                End If
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
            Return False
        End Try
    End Function
    Private Sub Load_grid()
        Try
            Dim data = (From tmp In Me.data_repay Group tmp By keys = New With {
                                                 Key tmp.MRTSLIPNO,
                                                 Key tmp.CARDTENDOR_Name,
                                                 Key tmp.MRTLUPDATE
                                                 }
                      Into Group
                        Select New With
                {
                     .MRTSLIPNO = keys.MRTSLIPNO,
                     .CARDTENDOR_Name = keys.CARDTENDOR_Name,
                     .MRTLUPDATE = keys.MRTLUPDATE,
                     .MRTAMOUNT = Group.Sum(Function(x) x.MRTAMOUNT)
                }
                 ).OrderBy(Function(x) x.MRTSLIPNO).ToList()

            'Me.DGV_Card_Normal.DataSource = data
            DGV_Card_Normal.Rows.Clear()
            If data.Count > 0 Then


                For i As Integer = 0 To data.Count - 1
                    DGV_Card_Normal.Rows.Add()

                    DGV_Card_Normal.Rows(i).Cells("SEQ").Value = i + 1

                    DGV_Card_Normal.Rows(i).Cells("MRTSLIPNO").Value = data(i).MRTSLIPNO
                    DGV_Card_Normal.Rows(i).Cells("MRTLUPDATE").Value = data(i).MRTLUPDATE
                    DGV_Card_Normal.Rows(i).Cells("CARDTENDOR_Name").Value = data(i).CARDTENDOR_Name
                    DGV_Card_Normal.Rows(i).Cells("MRTAMOUNT").Value = data(i).MRTAMOUNT
                Next

            End If



            'For i As Integer = 0 To Me.DGV_Card_Normal.RowCount - 1
            '    Me.DGV_Card_Normal.Rows(i).Cells("SEQ").Value = i + 1
            'Next
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub


    Private Function cardtype_select(CODE As String) As TenderModels.Sel_Tender
        Try
            Dim PAYTYPE_value As TenderModels.Sel_Tender
            Dim crow() As DataRow
            crow = obj_main.dt_Tender.Select("CODE = '" & CODE & "'")
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
                 .SCAN_TYPE = crow(0)("SCAN_TYPE")}

            Else

                Throw New Exception("Tender Not found !!")

            End If

            Return PAYTYPE_value

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Function

    Private Sub Repay_SAVE()
        Try
            Dim SALE_INT As SALE_Models.SALE_INT
            ProgressBar1.Maximum = Me.DGV_Card_Normal.RowCount
            ProgressBar1.Value = 0
            If Me.DGV_Card_Normal.RowCount <= 0 Then
                Messages.Texts(Me.Text, "ไม่พบรายการค้างจ่าย", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                Me.Dispose()
                Exit Sub
            End If
            Dim mess_remark As String = ""

            Dim Cardtran As New List(Of SALE_Models.Cardtran)
            Dim items_success As Integer = 0
            For Each grow As DataGridViewRow In Me.DGV_Card_Normal.Rows
                'gen sale data
                Dim data = Me.data_repay.Where(Function(x) x.MRTSLIPNO = grow.Cells("MRTSLIPNO").Value).ToList
                SALE_INT = New SALE_Models.SALE_INT
                SALE_INT = save_PR(data)



                ' get tender
                Dim PAYTYPE_value As New TenderModels.Sel_Tender
                PAYTYPE_value = cardtype_select(data(0).CARDTENDOR)

                'inquiry payment
                Dim result_Payment_call As New ConfirmpayModels_log
                Dim paycall As New Payment_center(data(0).CARDTENDOR, PAYTYPE_value)



                If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_EDC Then
                    Messages.Texts(Me.Text, "รอ EDC ทำ Inquiry ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                    Exit Sub
                ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.WALLET_TYPE_API Then
                    Try
                        result_Payment_call = paycall.Inquiry_call(data(0).MRTSLIPNO)
                        If IsNothing(result_Payment_call) Then
                            Throw New Exception("inquiry payment not found !. Slip " & data(0).MRTSLIPNO)
                        End If
                    Catch ex As Exception
                        'If ex.Message = "ยังไม่พบรายการจ่ายเงิน" Then
                        '    Messages.Texts("การแจ้งเตือน", "บิลขายเลขที่ " & data(0).MRTSLIPNO & " " & ex.Message, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                        'Else
                        '    Msg_err.Show_Err(ex, "Payment_center.Inquiry_call")
                        'End If
                        Continue For
                    End Try
                ElseIf Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.APIHUBCPN Then

                    Dim cph As New CPN_Payment_Hub()
                    Dim val As New CPN_Payment_Hub.value_Models

                    val.barcode = data(0).BARCODE
                    val.MRTSLIPNO = data(0).MRTSLIPNO
                    val.Payment_code = data(0).CARDTENDOR
                    val.totalPrice = SALE_INT.NETAMOUNT


                    cph.Repay = "Repay"
                    result_Payment_call = cph.payment(cph.case_payment.Inquiry, val)
                    If Not IsNothing(result_Payment_call) Then

                        If result_Payment_call.result_code = "0000" Then
                            If result_Payment_call.PAY_STATE <> "SUCCESS" Then
                                Continue For
                            End If
                            'txt_B_TO_C_payment_code.Text = result_Payment_call.PAYMENT_CODE
                            'txt_B_TO_C_payment_code.BackColor = Color.DimGray

                            'Messages.Texts("การแจ้งเตือน", "ตรวจสอบรายการจ่ายสำเร็จเลขที่ : " & result_Payment_call.PAYMENT_CODE, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)

                            'Success 
                        Else
                            mess_remark &= data(0).MRTSLIPNO & " : " & result_Payment_call.PAY_Remark & vbNewLine
                            'txt_B_TO_C_payment_code.Text = ""
                            'txt_B_TO_C_payment_code.BackColor = Color.Red
                            'Messages.Texts("การแจ้งเตือนจาก Payment Hub", result_Payment_call.PAY_Remark, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                            'Exit Sub
                            Continue For
                        End If
                    Else
                        'txt_B_TO_C_payment_code.Text = ""
                        'txt_B_TO_C_payment_code.US_Color_Didable = Color.Red
                        Messages.Texts("การแจ้งเตือน", "ทำการตรวจสอบไม่สำเร็จ กรุณาลองใหม่อีกครั้ง ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                        Exit Sub
                    End If



                Else
                    Messages.Texts(Me.Text, Cl_massage.EDC_msg_wallet_Notconfig, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    Exit For
                End If






                Dim Confirm As New ConfirmpayModels
                Confirm.mrt_slip = data(0).MRTSLIPNO
                Confirm.payment_id = result_Payment_call.PAYMENT_CODE
                Confirm.SHOPID = Center.data_profile.SHOPID
                Confirm.typeid = ""
                Confirm.cused = 1
                Confirm.barcode = data(0).BARCODE
                Confirm.cused1 = 1
                Confirm.clstatus = "S"
                Confirm.clamount = data(0).MRTAMOUNT
                Confirm.clreceive = data(0).MRTAMOUNT
                Confirm.cpromotion = "0"
                Confirm.tid = Center.data_profile.TERMINAL_TID
                Confirm.uid = Center.data_profile.TERMINAL_TID
                Confirm.tendor = PAYTYPE_value.CODE
                Confirm.clupdate = ""
                Confirm.processdate = ""
                Confirm.remark = ""

                Dim payment As New confirmpay
                payment.payment = Confirm
                payment.SALE_INT = SALE_INT
                'ไม่ต้องส่งให้เปลือง 
                Try
                    payment.SALE_INT.Saleitems.Clear()
                    payment.SALE_INT.Saleitems_card.Clear()
                Catch ex As Exception

                End Try


                Dim json As String = JsonConvert.SerializeObject(payment)
                Dim siteUri As New Uri(Center.Data_Config.API + Center.Link_API.Post_API.CARDTRANS_confirmpay)
                Dim ret = New API(Center.Data_Config.API).POSTResponse(siteUri, json, "POST", "")
                Dim retValue As SALE_Models.value = JsonConvert.DeserializeObject(Of SALE_Models.value)(ret)
                If retValue.Respon.Result Then
                    'Me.DGV_Card_Normal.Rows.Remove(grow)
                    FPrint_inv(data(0).MRTSLIPNO)
                    items_success += 1
                Else
                    If retValue.Respon.SystemErrorMessage <> "" Then
                        'จากระบบ
                        Throw New Exception(retValue.Respon.SystemErrorMessage)
                    Else
                        Messages.Texts(Me.Text, retValue.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                    End If

                End If


                ProgressBar1.Value += 1
            Next
            Messages.Texts(Me.Text, "สำเร็จ " & items_success & " รายการ " & vbNewLine & "ไม่สำเร็จ " & (DGV_Card_Normal.RowCount) - items_success & " รายการ" & vbNewLine & mess_remark, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
            'If (DGV_Card_Normal.RowCount) = 0 Then
            '    Me.Dispose()
            'End If
            Me.data_repay.Clear()
            Loaddata_Repay()
            Gencolumn_Normal()
            Load_grid()
            If DGV_Card_Normal.RowCount <= 0 Then
                Me.Dispose()
            End If

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        Finally

        End Try
    End Sub

    Private Function save_PR(data As List(Of SALE_Models.RepayModel)) As SALE_Models.SALE_INT
        Dim SALE_INT As New SALE_Models.SALE_INT


        SALE_INT.Multicard = False
        SALE_INT.MRTSLIPNO = ""
        SALE_INT.SHOPID = Center.data_profile.SHOPID
        SALE_INT.POSID = Center.data_profile.POSID

        SALE_INT.DOCDATE = Center.DATEWORKING
        SALE_INT.DOCMONT = Center.DATEWORKING.Year
        SALE_INT.DOCMONT = Center.DATEWORKING.Month
        SALE_INT.TAXINVOICE = ""
        SALE_INT.CREDITNOTES = ""
        SALE_INT.CARDTENDOR = data(0).CARDTENDOR
        SALE_INT.CARDREF = ""
        SALE_INT.CARDPURSE = data(0).CARDPURSE
        SALE_INT.taxPrint = ""
        SALE_INT.CUS_ID = ""
        SALE_INT.PAYTYPE = data(0).CARDTENDOR
        SALE_INT.PAYAMOUNT = data(0).MRTAMOUNT
        SALE_INT.AMOUNT = data(0).MRTAMOUNT
        SALE_INT.DISTP = 0
        SALE_INT.DISVALUE = 0
        SALE_INT.AFTERDIS = data(0).MRTAMOUNT
        SALE_INT.VATTP = ""
        SALE_INT.VATVALUE = 0
        SALE_INT.AFTERVAT = data(0).MRTAMOUNT
        SALE_INT.NETAMOUNT = data(0).MRTAMOUNT
        SALE_INT.QTY_TOTAL = data(0).MRTAMOUNT
        SALE_INT.CBY = Center.data_profile.Emp_id
        SALE_INT.MBY = Center.data_profile.Emp_id
        SALE_INT.DC_STATE = "S"

        SALE_INT.Remark1 = ""
        SALE_INT.Remark2 = ""
        SALE_INT.Remark3 = ""

        SALE_INT.merchant_id = ""
        SALE_INT.VALUE_CONVERT = 0



        SALE_INT.CorpBRNID = Center.data_profile.BRNID

        For Each val As SALE_Models.RepayModel In data
            Dim val_Cardtran As New SALE_Models.Cardtran

            val_Cardtran.CUSED = 0
            val_Cardtran.BARCODE = val.BARCODE
            val_Cardtran.SHOPID = Center.data_profile.SHOPID
            val_Cardtran.POSID = Center.data_profile.POSID
            val_Cardtran.MRTAMOUNT = val.MRTAMOUNT
            val_Cardtran.MRTSTATUS = "S"
            val_Cardtran.MRTSLIPNO = ""
            val_Cardtran.MRTLUPDATE = Nothing
            val_Cardtran.TID = Center.data_profile.TERMINAL_TID
            val_Cardtran.UID = Center.data_profile.TERMINAL_TID
            val_Cardtran.LUPDATE = Nothing
            val_Cardtran.BACKUPFLG = False
            val_Cardtran.CHKFLG = False
            val_Cardtran.VOIDNO = ""
            val_Cardtran.CUSED1 = 0
            val_Cardtran.FOODID = val.FOODID
            val_Cardtran.FOODNAME = val.FOODNAME
            val_Cardtran.SHOPENDFLG = 0
            val_Cardtran.GP = val.GP
            val_Cardtran.GPAMOUNT = val.GPAMOUNT
            val_Cardtran.GPRULE = val.GPRULE
            val_Cardtran.STOCKID = ""
            val_Cardtran.TAXINVOICE = ""
            val_Cardtran.CREDITNOTES = ""
            val_Cardtran.CARDTENDOR = val.CARDTENDOR
            val_Cardtran.CARDREF = ""
            val_Cardtran.CARDPURSE = val.CARDPURSE
            val_Cardtran.taxPrint = 0
            val_Cardtran.SEQ = val.SEQ
            val_Cardtran.ITEMS_PRICE = val.ITEMS_PRICE
            val_Cardtran.QTY = val.QTY
            SALE_INT.Cardtran.Add(val_Cardtran)

        Next
        Return SALE_INT
    End Function
    Private Sub cancel(docno As String, SHOPID As String)

        Try

            Dim Confirm As New ConfirmpayModels
            Confirm.mrt_slip = docno
            Confirm.payment_id = ""
            Confirm.SHOPID = SHOPID
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
                Me.DGV_Card_Normal.Rows.Remove(Me.DGV_Card_Normal.CurrentRow)

            Else
                If retValue.Respon.SystemErrorMessage <> "" Then
                    'จากระบบ
                    Throw New Exception(retValue.Respon.SystemErrorMessage)
                Else
                    Messages.Texts(Me.Text, retValue.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                End If
            End If


        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub


    Public Function FPrint_inv(docno As String)
        Dim dataslip As List(Of SALE_Models.slipModel)
        Try

            Dim ret As New SALE_Models.print_slip
            Dim json = New API(Center.Data_Config.API).GETSON(Center.Link_API.Get_API.CARDTRANS_PrintSlip_INV & docno)

            ret = (JsonConvert.DeserializeObject(Of SALE_Models.print_slip)(json))
            If ret.Respon.Result Then
                If ret.Data.Count <= 0 Then
                    Messages.Texts("การแจ้งเตือน", "ไม่พบรายการขาย", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
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
                Print.Print_to_printter("slip")

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
End Class