Imports Control_us
Imports MD
Public Class Payment_center
    Dim PAYTYPE As String = ""
    Dim PAYTYPE_value As New TenderModels.Sel_Tender
    Sub New(val1 As String, val2 As TenderModels.Sel_Tender)
        Me.PAYTYPE = val1
        Me.PAYTYPE_value = val2
    End Sub
    Public Function Payment_call(docno As String, val As SALE_Models.SALE_INT) As ConfirmpayModels_log
        Try
            Dim ret As New ConfirmpayModels_log
            Dim CL_date As New CL_date
            Dim payment_id As String = ""
            Select Case Me.PAYTYPE.ToUpper
                Case "THAIQR"
                    Dim model = New THAI_QRModel.KasikornRequestQRCodeModel()
                    Dim API As New API_THAI_QR(PAYTYPE_value.Server)
                    '///////////////////////////////////////////
                    'กำหนดให้
                    'partnerId = APP_ID
                    'partnerSecret = CLIENT_SECRET
                    '////////////////////////////////

                    model.refer2 = ""
                    model.partnerTxnUid = docno
                    model.partnerId = PAYTYPE_value.APP_ID
                    model.partnerSecret = PAYTYPE_value.CLIENT_SECRET
                    model.requestDt = CL_date.Condate((New CL_getdate().Getdate), API.stringformat)
                    model.merchantId = PAYTYPE_value.MERCHAND_ID
                    model.terminalId = PAYTYPE_value.TERMINALID
                    model.qrType = "3"
                    model.txnAmount = val.NETAMOUNT
                    model.txnCurrencyCode = PAYTYPE_value.CERRENCY
                    model.reference1 = Center.data_profile.POSID
                    model.reference2 = ""
                    model.reference3 = ""
                    model.reference4 = ""
                    model.metadata = ""

                    Dim ret_QRTHAI As New THAI_QRModel.KasikornResponseQRCodeModel()
                    ret_QRTHAI = API.PaymentRequest(model)

                    ret = New ConfirmpayModels_log
                    ret.barcode = ret_QRTHAI.qrCode
                    ret.PAY_AMOUNT = 0
                    ret.PAY_DESCRIPTION = ret_QRTHAI.errorCode
                    ret.PAY_Remark = ret_QRTHAI.errorDesc
                    ret.PAY_STATE = ret_QRTHAI.statusCode

                    Return ret

                Case "DOLFIN"
                    Dim model = New DolfinModel.DolfinPaymentRequestModel()
                    Dim API As New API_Dolfin(PAYTYPE_value.Server)
                    model.authCode = val.Saleitems_card(0).BARCODE
                    model.currency = PAYTYPE_value.CERRENCY
                    model.merchantNo = PAYTYPE_value.MERCHAND_ID
                    model.merchantOrderNo = docno
                    model.totalAmount = val.NETAMOUNT
                    model.storecode = val.SHOPID
                    Dim ret_Dolfin As New DolfinModel.DolfinPaymentResponseModel
                    ret_Dolfin = API.GetDolfinPayment(model)

                    ret = New ConfirmpayModels_log
                    If ret_Dolfin.resultCode = "000000" Then
                        ret.PAYMENT_CODE = ret_Dolfin.transactionNo
                        ret.PAY_AMOUNT = ret_Dolfin.totalAmount
                        ret.PAY_DESCRIPTION = ret_Dolfin.resultInfo
                        ret.PAY_Remark = If("first_call", ret_Dolfin.timeEnd)
                        ret.PAY_STATE = True
                    ElseIf ret_Dolfin.resultCode = "200091" Then
                        ret.PAYMENT_CODE = ret_Dolfin.transactionNo
                        ret.PAY_AMOUNT = ret_Dolfin.totalAmount
                        ret.PAY_DESCRIPTION = "200091"
                        ret.PAY_Remark = "200091"
                        ret.PAY_STATE = False

                    Else
                        Throw New Exception("Dolfin : " & ret_Dolfin.resultCode & ":: " & ret_Dolfin.resultInfo)
                    End If


                    Return ret
                Case "TRUEWALLET"
                    Dim model = New TrueRequestModel()
                    Dim API As New API_true(PAYTYPE_value.Server, PAYTYPE_value.CODE)
                    model.isv_payment_ref = docno
                    model.merchant_id = val.merchant_id
                    model.currency = "THB"
                    model.request_amount = ((CInt(val.NETAMOUNT)) * 100)
                    model.payment_method = "BALANCE"
                    model.payment_code = val.Saleitems_card(0).BARCODE
                    model.description = Center.data_profile.BRNCODE & "  " & Center.data_profile.SHOPNAME
                    model.metadata.shop_id = PAYTYPE_value.VENDER_SHOP_ID
                    model.metadata.partner_shop_id = Center.data_profile.POSID.ToString()
                    model.metadata.partner_shop_name = Center.data_profile.SHOPNAME.ToString()

                    Return API.TruePaymentRequest(model)
            End Select
        Catch ex As Exception
            Msg_err.Show_Err(ex, "Payment_center.Payment_call")
            Return Nothing
        End Try

    End Function
    Public Function Inquiry_call(docno As String) As ConfirmpayModels_log
        Try
            Dim ret As New ConfirmpayModels_log
            Dim CL_date As New CL_date
            Dim payment_id As String = ""
            Select Case Me.PAYTYPE.ToUpper
                Case "THAIQR"


                Case "DOLFIN"

                Case "TRUEWALLET"

                    ''ตรวจสอบก่อนว่ามีการจ่ายหรือยยัง
                    Dim API_true As New API_true(PAYTYPE_value.Server, PAYTYPE_value.CODE)
                    Dim val As New TrueQueryRequestModel
                    val.isv_payment_ref = docno
                    val.transaction_date = CL_date.Condate((New CL_getdate().Getdate), API_true.stringformat)
                    Dim ret_true As New TrueQueryResponseModel
                    ret_true = API_true.TrueQueryIsrRequest(val)

                    If Not IsNothing(ret) Then
                        'Return ret.Data.payment_id
                        Dim ret_confirm As New ConfirmpayModels_log
                        ret_confirm.PAYMENT_CODE = ret_true.Data.payment_id
                        ret_confirm.PAY_AMOUNT = ret_true.Data.amount / 100
                        ret_confirm.PAY_DESCRIPTION = ret_true.Data.response_code
                        ret_confirm.PAY_Remark = ret_true.Data.response_message
                        ret_confirm.PAY_STATE = ret_true.Data.status
                        Return ret_confirm
                    Else
                        Throw New Exception(ret_true.Status.code & " : " & ret_true.Status.message)
                    End If

            End Select
        Catch ex As Exception


            Throw ex


            Return Nothing
        End Try
    End Function
    Public Function Cancel_call(slipno As String, val As SALE_Models.SALE_INT) As ConfirmpayModels_log
        Try
            Dim CL_date As New CL_getdate
            Dim payment_id As String = ""
            Dim ret As New ConfirmpayModels_log
            Select Case Me.PAYTYPE.ToUpper
                Case "THAIQR"
                    ret.PAYMENT_CODE = ""
                    ret.PAY_AMOUNT = 0
                    ret.PAY_DESCRIPTION = ""
                    ret.PAY_Remark = ""
                    ret.PAY_STATE = True
                    Return ret
                Case "DOLFIN"

                    Dim inq_val As New DolfinModel.DolfinCancelRequestModel
                    inq_val.merchantNo = val.merchant_id
                    inq_val.merchantOrderNo = slipno
                    Dim inq_ret As New DolfinModel.DolfinCancelResponseModel
                    inq_ret = New API_Dolfin(PAYTYPE_value.Server).GetDolfinCancel(inq_val)

                    If inq_ret.resultFlag Then
                        If inq_ret.resultCode = "000000" Then
                            ret.PAYMENT_CODE = inq_ret.transactionNo
                            ret.PAY_AMOUNT = 0
                            ret.PAY_DESCRIPTION = inq_ret.resultCode
                            ret.PAY_Remark = inq_ret.resultInfo
                            ret.PAY_STATE = inq_ret.resultFlag

                        Else
                            ret.PAYMENT_CODE = inq_ret.transactionNo
                            ret.PAY_AMOUNT = 0
                            ret.PAY_DESCRIPTION = inq_ret.resultCode
                            ret.PAY_Remark = inq_ret.resultInfo
                            ret.PAY_STATE = False
                        End If
                        Return ret
                    Else

                        ret.PAYMENT_CODE = inq_ret.transactionNo
                        ret.PAY_AMOUNT = 0
                        ret.PAY_DESCRIPTION = inq_ret.resultCode
                        ret.PAY_Remark = inq_ret.resultInfo
                        ret.PAY_STATE = inq_ret.resultFlag
                        Return ret
                    End If

                Case "TRUEWALLET"
                    ret.PAYMENT_CODE = ""
                    ret.PAY_AMOUNT = 0
                    ret.PAY_DESCRIPTION = ""
                    ret.PAY_Remark = ""
                    ret.PAY_STATE = True
                    Return ret
                Case Else
                    ret.PAYMENT_CODE = ""
                    ret.PAY_AMOUNT = 0
                    ret.PAY_DESCRIPTION = ""
                    ret.PAY_Remark = ""
                    ret.PAY_STATE = True
                    Return ret
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
