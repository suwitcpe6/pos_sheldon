Imports aPI_cPN
Imports MD
Imports Newtonsoft.Json

Public Class CPN_Payment_Hub
    Public Const stringformat As String = "yyyy-MM-dd" & "T" & "HH:mm:ss"
    Dim Payment_Log As New CL_Payment_Log
    Public Repay As String = ""
    Public Class value_Models
        Public barcode As String
        Public MRTSLIPNO As String
        Public voidid As String
        Public Payment_code As String
        Public totalPrice As Double
    End Class
    Public Enum case_payment
        PAYMENT = 1
        INQUIRY = 2
        CANCEL = 3 '
        REFUND = 4 'dolfin
        VERIFY_SLIP = 5 'thaiqr
    End Enum
    Public Function payment(case_payment As case_payment, val As value_Models) As ConfirmpayModels_log
        Dim d_start As DateTime
        Dim d_end As DateTime
        Dim Cls_API As New cLS_CT
        Dim RetValJson
        Dim _Success As Boolean = False
        Dim Arry(13) As String
        Arry(0) = CL_date.Condate(Center.date_now, "yyyyMMdd")
        Arry(1) = Center.data_profile.Merchant_ID  'CompanyID.Text
        Arry(2) = Center.data_profile.BRNCODE 'bRanch.Text
        Arry(3) = Center.data_profile.Profit_N 'Profitcenter
        Arry(4) = Center.data_profile.POSID  ' ShopNo
        Arry(5) = Center.data_profile.SHOPNAME  ' Shopname



        If case_payment = case_payment.Payment Then
            Arry(6) = val.MRTSLIPNO ' rEfno.Text
            Arry(7) = Center.data_profile.TERMINAL_TID  ' TerminalID.Text
            Arry(8) = Center.data_profile.RONAME   'StaffNo
            Arry(9) = val.Payment_code 'PaymentCh
            Arry(10) = Replace(val.barcode, vbCrLf, "")
            Arry(11) = CL_date.Condate(Center.date_now, stringformat)
            Arry(12) = val.totalPrice
            Arry(13) = ""
        ElseIf case_payment = case_payment.Inquiry Then
            Arry(6) = val.MRTSLIPNO ' rEfno.Text
            Arry(7) = Center.data_profile.TERMINAL_TID  ' TerminalID.Text
            Arry(8) = Center.data_profile.RONAME   'StaffNo
            Arry(9) = val.Payment_code 'PaymentCh
            Arry(10) = ""
            Arry(11) = ""
            Arry(12) = ""
            Arry(13) = ""
        ElseIf case_payment = case_payment.Cancel Then
            Arry(6) = val.MRTSLIPNO ' rEfno.Text
            Arry(7) = Center.data_profile.TERMINAL_TID  ' TerminalID.Text
            Arry(8) = Center.data_profile.RONAME   'StaffNo
            Arry(9) = val.Payment_code 'PaymentCh
            Arry(10) = CL_date.Condate(Center.date_now, stringformat)
            Arry(11) = val.totalPrice
            Arry(12) = ""
            Arry(13) = ""
        ElseIf case_payment = case_payment.Refund Then

            Arry(6) = val.voidid ' rEfno.Text
            Arry(7) = CL_date.Condate(Center.date_now, "yyyyMMdd")
            Arry(8) = val.MRTSLIPNO ' 
            Arry(9) = Center.data_profile.TERMINAL_TID
            Arry(10) = Center.data_profile.RONAME
            Arry(11) = val.Payment_code
            Arry(12) = CL_date.Condate(Center.date_now, stringformat)
            Arry(13) = val.totalPrice
        ElseIf case_payment = case_payment.Verify_slip Then
            Arry(6) = val.MRTSLIPNO ' rEfno.Text
            Arry(7) = Center.data_profile.TERMINAL_TID  ' TerminalID.Text
            Arry(8) = Center.data_profile.RONAME   'StaffNo
            Arry(9) = val.Payment_code 'PaymentCh
            Arry(10) = val.barcode
            Arry(11) = ""
            Arry(12) = ""
            Arry(13) = ""
        End If




        d_start = Center.date_now
        Dim Msg As String = Cls_API.api_cpn(case_payment, Arry, RetValJson, _Success, Nothing, False)
        d_end = Center.date_now



        Dim ret_confirm As New ConfirmpayModels_log

        'LOG  'LOG  'LOG  'LOG  'LOG  'LOG  'LOG

        'LOG  'LOG  'LOG  'LOG  'LOG  'LOG  'LOG
        Dim data_log As New CL_Payment_Log.MD_data
        Dim data1 As String = ""
        Dim modelpay
        If case_payment = case_payment.Payment Then
            modelpay = New cLS_cPNaPI.CPNPaymentRequestModel

            modelpay.bus_date = Arry(0)
            modelpay.company_id = Arry(1)
            modelpay.branch_code = Arry(2)
            modelpay.profit_center = Arry(3)
            modelpay.shop_no = Arry(4)
            modelpay.shop_name = Arry(5)
            modelpay.ref_no = Arry(6)
            modelpay.terminal_no = Arry(7)
            modelpay.staff_no = Arry(8)
            modelpay.payment_channel = Arry(9)
            modelpay.payment_code = Arry(10)
            modelpay.txn_date = Arry(11)
            modelpay.txn_amount = Arry(12)

        ElseIf case_payment = case_payment.Inquiry Then
            modelpay = New cLS_cPNaPI.CPNInquiryRequestModel
            modelpay.bus_date = Arry(0)
            modelpay.company_id = Arry(1)
            modelpay.branch_code = Arry(2)
            modelpay.profit_center = Arry(3)
            modelpay.shop_no = Arry(4)
            modelpay.shop_name = Arry(5)
            modelpay.ref_no = Arry(6)
            modelpay.terminal_no = Arry(7)
            modelpay.staff_no = Arry(8)
            modelpay.payment_channel = Arry(9)
        ElseIf case_payment = case_payment.Cancel Then
            modelpay = New cLS_cPNaPI.CPNCancelRequestModel
            modelpay.bus_date = Arry(0)
            modelpay.company_id = Arry(1)
            modelpay.branch_code = Arry(2)
            modelpay.profit_center = Arry(3)
            modelpay.shop_no = Arry(4)
            modelpay.shop_name = Arry(5)
            modelpay.ref_no = Arry(6)
            modelpay.terminal_no = Arry(7)
            modelpay.staff_no = Arry(8)
            modelpay.payment_channel = Arry(9)
            modelpay.txn_date = Arry(10)
        ElseIf case_payment = case_payment.Refund Then
            modelpay = New cLS_cPNaPI.CPNRefundRequestModel
            modelpay.bus_date = Arry(0)
            modelpay.company_id = Arry(1)
            modelpay.branch_code = Arry(2)
            modelpay.profit_center = Arry(3)
            modelpay.shop_no = Arry(4)
            modelpay.shop_name = Arry(5)
            modelpay.ref_no = Arry(6)
            modelpay.refer_bus_date = Arry(7)
            modelpay.refer_ref_no = Arry(8)
            modelpay.terminal_no = Arry(9)
            modelpay.staff_no = Arry(10)
            modelpay.payment_channel = Arry(11)
            modelpay.txn_date = Arry(12)
            modelpay.txn_amount = Arry(13)
        ElseIf case_payment = case_payment.Verify_slip Then
            modelpay = New cLS_cPNaPI.CPNVerifyRequestModel
            modelpay.bus_date = Arry(0)
            modelpay.company_id = Arry(1)
            modelpay.branch_code = Arry(2)
            modelpay.profit_center = Arry(3)
            modelpay.shop_no = Arry(4)
            modelpay.shop_name = Arry(5)
            modelpay.ref_no = Arry(6)
            modelpay.terminal_no = Arry(7)
            modelpay.staff_no = Arry(8)
            modelpay.payment_channel = Arry(9)
            modelpay.slip_code = Arry(10)
        End If






        data_log.TENDERCODE = val.Payment_code
        data_log.DOCNO = val.MRTSLIPNO
        Try
            If Not IsNothing(RetValJson) Then
                data_log.DATA2 = JsonConvert.SerializeObject(RetValJson)
                If RetValJson.result_code = "0000" Then
                    data_log.STATUS = "S"
                Else
                    data_log.STATUS = "F"
                End If
                data_log.TENDERDOCNO = RetValJson.txn_id
            Else
                data_log.STATUS = "F"
                data_log.DATA2 = ""
                data_log.TENDERDOCNO = ""
            End If
        Catch ex As Exception
            data_log.TENDERDOCNO = ""
        End Try
        data_log.MERCHAND_ID = Center.data_profile.Merchant_ID
        data_log.LOG_TYPE = [Enum].GetName(GetType(case_payment), case_payment)

        data_log.DATA_TYPE = "JSON"
        data_log.REMARK1 = "SHOP"
        data_log.REMARK3 = Me.Repay
        data_log.DATA1 = JsonConvert.SerializeObject(modelpay)

        data_log.CDATE = d_start
        data_log.MODATE = d_end

        Payment_Log.Payment_Log(data_log)

        'LOG  'LOG  'LOG  'LOG  'LOG  'LOG  'LOG

        'LOG  'LOG  'LOG  'LOG  'LOG  'LOG  'LOG


        If RetValJson IsNot Nothing Then

            ret_confirm.PAYMENT_CODE = RetValJson.txn_id
            ret_confirm.PAY_AMOUNT = RetValJson.txn_amount
            ret_confirm.result_code = RetValJson.result_code
            ret_confirm.PAY_DESCRIPTION = RetValJson.result_msg_en
            ret_confirm.PAY_Remark = RetValJson.result_msg_th
            'If val.Payment_code = "THQR" Then
            '    If RetValJson.txn_status = "SUCCESS" Then
            '        ret_confirm.PAY_STATE = RetValJson.txn_status
            '    ElseIf RetValJson.txn_status = "PENDING" Then
            '        ret_confirm.PAY_STATE = "0"
            '    Else
            '        ret_confirm.PAY_STATE = "0"
            '    End If
            'Else
            '    ret_confirm.PAY_STATE = "1"
            'End If
            If case_payment = case_payment.Verify_slip Then
                ret_confirm.PAY_STATE = RetValJson.result_code
            Else
                ret_confirm.PAY_STATE = RetValJson.txn_status
            End If

            Return ret_confirm
        Else
            ret_confirm.PAY_DESCRIPTION = Msg
            ret_confirm.PAY_Remark = Msg
            ret_confirm.PAY_STATE = "0"
            Return ret_confirm
        End If


    End Function

End Class
