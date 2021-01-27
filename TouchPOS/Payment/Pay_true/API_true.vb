Imports MD
Imports Newtonsoft.Json
Imports System.Threading
Public Class API_true
    Public API_SRV_True As String = "" ' "https://localhost:44377/" 'System.Configuration.ConfigurationSettings.AppSettings.Get("API_true") + "/"

    'Public API_SRV_True As String = "http://api.sahatarasst.com:8028/"
    Public API_Url As New API_link
    Public Const stringformat As String = "yyyy-MM-ddTHH:mm:ss+07:00"
    Public Const Sleep As Integer = 5000
    Public Const timeout As Integer = 60
    Dim Payment_Log As New CL_Payment_Log
    Dim TENDER_CODE As String
    Public Class API_link
        Public PaymentRequest = "trueapi/request"
        Public QueryIsrRequest = "trueapi/queryisr"
        Public querypaymentid = "trueapi/querypaymentid"
        Public test = "trueapi/test?val1={0}&val2={1}"
    End Class
    Sub New(link As String, TENDERCODE As String)
        Me.TENDER_CODE = TENDERCODE
        API_SRV_True = link
        'API_SRV_True = "https://localhost:44377/" 'link
    End Sub
    ''' <summary>
    ''' สำหรับเรียกจ่ายเงิน
    ''' </summary>
    ''' <param name="model"></param>
    ''' <returns></returns>
    Public Function TruePaymentRequest(model As TrueRequestModel) As ConfirmpayModels_log
        Dim CL_date As New CL_date
        Try
            Dim ret As New TrueQueryResponseModel

            'For i As Integer = 1 To 3


            Dim json As String = JsonConvert.SerializeObject(model)
            Dim siteUri As New Uri(API_SRV_True & API_Url.PaymentRequest)
            Dim ret_r = New API(Center.Data_Config.API, timeout).POSTResponse(siteUri, json, "POST", "")
            Dim retValue As New TrueResponseModel


            If (ret_r Is Nothing) Then
                retValue = Nothing
            Else
                retValue = JsonConvert.DeserializeObject(Of TrueResponseModel)(ret_r)
            End If


            Payment_Log = New CL_Payment_Log
            Dim data_log As New CL_Payment_Log.MD_data

            data_log.TENDERCODE = Me.TENDER_CODE
            data_log.DOCNO = model.isv_payment_ref
            Try
                If IsNothing(retValue) Then
                    data_log.TENDERDOCNO = ""
                Else
                    If IsNothing(retValue.Data) Then
                        data_log.TENDERDOCNO = ""
                    Else
                        data_log.TENDERDOCNO = If(IsNothing(retValue.Data.payment_id), "", retValue.Data.payment_id)
                    End If
                End If
            Catch ex As Exception
                data_log.TENDERDOCNO = ""
            End Try
            data_log.MERCHAND_ID = model.merchant_id
            data_log.LOG_TYPE = CL_Payment_Log.Request
            data_log.DATA_TYPE = "JSON"
            data_log.DATA1 = json
            data_log.DATA2 = ret_r
            Payment_Log.Payment_Log(data_log)

            If (retValue Is Nothing) Then

                'Throw New Exception("True : TrueMoney Service Return Nothing.")
                Thread.Sleep(Sleep)
                Dim val As New TrueQueryRequestModel
                val.isv_payment_ref = model.isv_payment_ref
                val.transaction_date = CL_date.Condate((New CL_getdate().Getdate), stringformat)
                Dim retQ As New TrueQueryResponseModel
                retQ = TrueQueryIsrRequest(val)
                If Not IsNothing(retQ) Then
                    'Return ret.Data.payment_id
                    Dim ret_confirm As New ConfirmpayModels_log
                    ret_confirm.PAYMENT_CODE = retQ.Data.payment_id
                    ret_confirm.PAY_AMOUNT = retQ.Data.amount
                    ret_confirm.PAY_DESCRIPTION = retQ.Data.response_code
                    ret_confirm.PAY_Remark = retQ.Data.response_message
                    ret_confirm.PAY_STATE = retQ.Data.status
                    Return ret_confirm
                Else
                    Throw New Exception(ret.Status.code & " : " & ret.Status.message)
                End If

            ElseIf (retValue.Status Is Nothing) And (retValue.Data Is Nothing) Then

                'Throw New Exception("True : TrueMoney Service Return Nothing.")
                Thread.Sleep(Sleep)
                Dim val As New TrueQueryRequestModel
                val.isv_payment_ref = model.isv_payment_ref
                val.transaction_date = CL_date.Condate((New CL_getdate().Getdate), stringformat)
                Dim retQ As New TrueQueryResponseModel
                retQ = TrueQueryIsrRequest(val)
                If Not IsNothing(retQ) Then
                    'Return ret.Data.payment_id
                    Dim ret_confirm As New ConfirmpayModels_log
                    ret_confirm.PAYMENT_CODE = retQ.Data.payment_id
                    ret_confirm.PAY_AMOUNT = retQ.Data.amount
                    ret_confirm.PAY_DESCRIPTION = retQ.Data.response_code
                    ret_confirm.PAY_Remark = retQ.Data.response_message
                    ret_confirm.PAY_STATE = retQ.Data.status
                    Return ret_confirm
                Else
                    Throw New Exception(ret.Status.code & " : " & ret.Status.message)
                End If
            ElseIf (retValue.Status.code Is Nothing) And (retValue.Status.messasge Is Nothing) Then

                'Throw New Exception("True : TrueMoney Service Return Nothing.")
                Thread.Sleep(Sleep)
                Dim val As New TrueQueryRequestModel
                val.isv_payment_ref = model.isv_payment_ref
                val.transaction_date = CL_date.Condate((New CL_getdate().Getdate), stringformat)
                Dim retQ As New TrueQueryResponseModel
                retQ = TrueQueryIsrRequest(val)
                If Not IsNothing(retQ) Then
                    'Return ret.Data.payment_id
                    Dim ret_confirm As New ConfirmpayModels_log
                    ret_confirm.PAYMENT_CODE = retQ.Data.payment_id
                    ret_confirm.PAY_AMOUNT = retQ.Data.amount
                    ret_confirm.PAY_DESCRIPTION = retQ.Data.response_code
                    ret_confirm.PAY_Remark = retQ.Data.response_message
                    ret_confirm.PAY_STATE = retQ.Data.status
                    Return ret_confirm
                Else
                    Throw New Exception(ret.Status.code & " : " & ret.Status.message)
                End If

            ElseIf (retValue.Status.code) = "success" Then
                'insert log sucess
                'insert log sucess
                'insert log sucess
                'insert log sucess
                'insert log sucess
                'Return retValue.Data.payment_id
                Dim ret_confirm As New ConfirmpayModels_log
                ret_confirm.PAYMENT_CODE = retValue.Data.payment_id
                ret_confirm.PAY_AMOUNT = model.request_amount / 100
                ret_confirm.PAY_DESCRIPTION = "success"
                ret_confirm.PAY_Remark = "first_call"
                ret_confirm.PAY_STATE = "success"
                Return ret_confirm

            Else
                'If retValue.Status.code = "invalid_payment_code" Then
                Dim ret_confirm As New ConfirmpayModels_log
                ret_confirm.PAYMENT_CODE = ""
                ret_confirm.PAY_AMOUNT = 0
                ret_confirm.PAY_DESCRIPTION = retValue.Status.code ' "Payment ID ไม่ถูกต้อง"
                ret_confirm.PAY_Remark = retValue.Status.messasge
                ret_confirm.PAY_STATE = "failed"
                Return ret_confirm

                'Else
                '    Throw New Exception("True : " + retValue.Status.code + "  " + retValue.Status.messasge)
                'End If

                'insert log false
                'insert log false
                'insert log false
                'insert log false
                'insert log false
                'insert log false
                'insert log false

            End If

            'Next

        Catch ex As Exception
            'Try
            'Thread.Sleep(Sleep)
            'Dim val As New TrueQueryRequestModel
            'val.isv_payment_ref = model.isv_payment_ref
            'val.transaction_date = CL_date.Condate((CL_date.Getdate), stringformat)
            'Dim ret As New TrueQueryResponseModel
            'ret = TrueQueryIsrRequest(val)
            'If Not IsNothing(ret) Then
            '    'Return ret.Data.payment_id
            '    Dim ret_confirm As New ConfirmpayModels_log
            '    ret_confirm.PAYMENT_CODE = ret.Data.payment_id
            '    ret_confirm.PAY_AMOUNT = ret.Data.amount
            '    ret_confirm.PAY_DESCRIPTION = ret.Data.response_code
            '    ret_confirm.PAY_Remark = ret.Data.response_message
            '    ret_confirm.PAY_STATE = True
            '    Return ret_confirm
            'Else

            '    Throw New Exception(ret.Status.code & " : " & ret.Status.message)
            'End If
            'Catch ex2 As Exception
            '        Throw ex2
            '    End Try
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' สำรับตรวจสอบ ด้วยเลยบิล
    ''' </summary>
    ''' <param name="model"></param>
    ''' <returns></returns>
    Public Function TrueQueryIsrRequest(model As TrueQueryRequestModel) As TrueQueryResponseModel
        Try
            For i = 1 To 2


                Dim json As String = JsonConvert.SerializeObject(model)
                Dim siteUri As New Uri(API_SRV_True & API_Url.QueryIsrRequest)
                Dim ret = New API(Center.Data_Config.API, timeout).POSTResponse(siteUri, json, "POST", "")

                Dim retValue As TrueQueryResponseModel
                If (ret Is Nothing) Then
                    retValue = Nothing
                Else
                    retValue = JsonConvert.DeserializeObject(Of TrueQueryResponseModel)(ret)
                End If


                Payment_Log = New CL_Payment_Log
                Dim data_log As New CL_Payment_Log.MD_data

                data_log.TENDERCODE = Me.TENDER_CODE
                data_log.DOCNO = model.isv_payment_ref
                Try
                    If IsNothing(retValue) Then
                        data_log.TENDERDOCNO = ""
                    Else
                        If IsNothing(retValue.Data) Then
                            data_log.TENDERDOCNO = ""
                        Else
                            data_log.TENDERDOCNO = If(IsNothing(retValue.Data.payment_id), "", retValue.Data.payment_id)
                        End If
                    End If
                Catch ex As Exception
                    data_log.TENDERDOCNO = ""
                End Try
                data_log.MERCHAND_ID = ""
                data_log.LOG_TYPE = CL_Payment_Log.Query
                data_log.DATA_TYPE = "JSON"
                data_log.DATA1 = json
                data_log.DATA2 = ret
                Payment_Log.Payment_Log(data_log)


                If retValue Is Nothing Then
                    Thread.Sleep(Sleep)
                    'Dim json2 As String = JsonConvert.SerializeObject(model)
                    'Dim siteUri2 As New Uri(API_SRV_True & API_Url.QueryIsrRequest)
                    'Dim ret2 = New API(Center.Data_Config.API, timeout).POSTResponse(siteUri2, json2, "POST", "")
                    'Dim retValue2 As TrueQueryResponseModel = JsonConvert.DeserializeObject(Of TrueQueryResponseModel)(ret2)

                    'If retValue2 Is Nothing Then
                    '    Throw New Exception("The operation has timed out.")
                    'Else
                    '    If retValue2.Status.code = "success" Then
                    '        Return retValue2
                    '    Else
                    '        Throw New Exception("True : " + retValue2.Status.code)
                    '    End If
                    'End If
                Else
                    If retValue.Status Is Nothing Then
                        Throw New Exception("ยังไม่พบรายการจ่ายเงิน")
                    End If
                    If retValue.Status.code = "success" Then
                        'ต้องแบบนี้เท่านั้นเผื่อทรูมีเพิ่มสถานะ
                        If retValue.Data.status = "succeeded" Then
                            Return retValue
                        ElseIf retValue.Data.status = "failed" Then
                            'If retValue.Data.response_code = "insufficient_fund" Then
                            '    Throw New Exception("ยอดเงินไม่พอจ่ายกรุณาเติมเงิน")
                            'Else
                            Throw New Exception("ทำรายการจ่ายเงินไม่สำเร็จ กรุณาลองอีกครั้ง")
                            'End If
                        Else
                            Throw New Exception("True Status: " + retValue.Data.status)
                        End If
                    Else
                        Throw New Exception("True : " & retValue.Status.code & " " & retValue.Status.message)
                    End If
                End If
            Next

        Catch ex As Net.WebException
            'Try




            'Thread.Sleep(Sleep)
            'Dim json As String = JsonConvert.SerializeObject(model)
            'Dim siteUri As New Uri(API_SRV_True & API_Url.QueryIsrRequest)
            'Dim ret = New API(Center.Data_Config.API, timeout).POSTResponse(siteUri, json, "POST", "")
            'Dim retValue As TrueQueryResponseModel = JsonConvert.DeserializeObject(Of TrueQueryResponseModel)(ret)

            'If retValue Is Nothing Then
            '    Throw New Exception("True : TrueMoney Service Return Nothing.")
            'Else
            '    If retValue.Status.code = "success" Then
            '        Return retValue
            '    Else
            '        Throw New Exception("True : " + retValue.Status.code)
            '    End If
            'End If




            'Catch ex2 As Exception

            '    Throw ex2

            'End Try
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' สำหรับตรวจสอบ ด้วยเลข payid จากtrue
    ''' </summary>
    ''' <param name="model"></param>
    ''' <returns></returns>
    Public Function TrueQueryPaymentRequest(model As TrueQueryPaymentRequestModel) As TrueQueryPaymentResponseModel

        Try
            Dim json As String = JsonConvert.SerializeObject(model)
            Dim siteUri As New Uri(API_SRV_True & API_Url.QueryIsrRequest)
            Dim ret = New API(Center.Data_Config.API).POSTResponse(siteUri, json, "POST", "")
            Dim retValue As TrueQueryPaymentResponseModel = JsonConvert.DeserializeObject(Of TrueQueryPaymentResponseModel)(ret)

            If Not IsNothing(retValue.Data) Then
                Return retValue
            Else
                Throw New Exception("True : " + retValue.Status.code + " : ไม่พบข้อมูลบัตร กรุณาลองอีกครั้ง")
            End If


            'Catch (WebException wex)
            '{
            '    StreamReader sr = New StreamReader(wex.Response.GetResponseStream());
            '    ret.Respon.SystemErrorMessage = sr.ReadToEnd();
            '    ret.Respon.Result = False;
            '    Debug.WriteLine(ret.Respon.SystemErrorMessage);
            '    //throw wex;
            '    Return ret;
            '}
            'Catch (Exception ex)
            '{
            '    Debug.WriteLine(ex.Message);
            '    ret.Respon.SystemErrorMessage = "API : " + ex.Message.ToString();
            '    //ret.SystemErrorMessage = e.StackTrace;
            '    ret.Respon.Result = False;
            '    Return ret;
            '    //throw ex;
            '}
        Catch ex As Exception

        End Try
    End Function
End Class
