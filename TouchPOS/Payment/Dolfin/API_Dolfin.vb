Imports MD
Imports Newtonsoft.Json
Imports System.Threading
Public Class API_Dolfin
    Public API_address As String = "" ' "https://localhost:44377/" 'System.Configuration.ConfigurationSettings.AppSettings.Get("API_true") + "/"
    'Public API_THAI_QR As String = "http://api.sahatarasst.com:8028/"
    Public API_Url As New API_link
    Public Const stringformat As String = "yyyy-MM-ddTHH:mm:ss+07:00"
    Public Const Sleep As Integer = 2000
    Public Const timeout As Integer = 10
    Public Class API_link
        Public GetDolfinPayment = "dolfinapi/payment"
        Public inquiry = "dolfinapi/inquiry"
        Public cancel = "dolfinapi/cancel"
        'Public void = "dolfinapi/void"
    End Class
    Sub New(link As String)
        API_address = link
    End Sub
    Public Function GetDolfinPayment(model As DolfinModel.DolfinPaymentRequestModel) As DolfinModel.DolfinPaymentResponseModel
        Try
            'If first_call = False Then
            '    Try


            '        Dim inq_val As New DolfinModel.DolfinInquiryRequestModel
            '        inq_val.merchantNo = model.merchantNo
            '        inq_val.merchantOrderNo = model.merchantOrderNo
            '        Dim inq_ret As New DolfinModel.DolfinInquiryResponseModel
            '        inq_ret = GetDolfinInquiry(inq_val)
            '        If inq_ret.resultFlag Then
            '            Dim ret_isval As New DolfinModel.DolfinPaymentResponseModel
            '            ret_isval.transactionNo = inq_ret.transactionNo
            '            ret_isval.resultCode = inq_ret.resultCode
            '            ret_isval.totalAmount = inq_ret.orderAmount
            '            ret_isval.resultInfo = inq_ret.resultInfo
            '            ret_isval.deviceInfo = ""
            '            Return ret_isval

            '        End If
            '    Catch ex As Exception

            '    End Try
            'End If
            'For i As Integer = 1 To 3
            Dim json As String = JsonConvert.SerializeObject(model)
            Dim siteUri As New Uri(API_address & API_Url.GetDolfinPayment)
            Dim ret = New API(Center.Data_Config.API, timeout).POSTResponse(siteUri, json, "POST", "")
            Dim retValue As New DolfinModel.DolfinPaymentResponseModel
            retValue = JsonConvert.DeserializeObject(Of DolfinModel.DolfinPaymentResponseModel)(ret)
            If retValue.resultFlag Then
                Return retValue

            Else
                If retValue.resultCode = "200021" Then
                    Throw New Exception("Dolfin : QR CODE หมดอายุ กรุณาลองใหม่")
                Else
                    Throw New Exception("Dolfin : " & retValue.resultCode & ":: " & retValue.resultInfo)
                End If
            End If

            'Next

        Catch ex As Exception
            Try
                Thread.Sleep(Sleep)
                Dim inq_val As New DolfinModel.DolfinInquiryRequestModel
                inq_val.merchantNo = model.merchantNo
                inq_val.merchantOrderNo = model.merchantOrderNo
                Dim inq_ret As New DolfinModel.DolfinInquiryResponseModel
                inq_ret = GetDolfinInquiry(inq_val)
                If inq_ret.resultFlag Then
                    Dim ret_isval As New DolfinModel.DolfinPaymentResponseModel
                    ret_isval.transactionNo = inq_ret.transactionNo
                    ret_isval.resultCode = inq_ret.resultCode
                    ret_isval.totalAmount = inq_ret.orderAmount
                    ret_isval.resultInfo = inq_ret.resultInfo
                    ret_isval.deviceInfo = ""
                    Return ret_isval

                End If
            Catch ex2 As Exception
                Try
                    Thread.Sleep(Sleep)
                    Dim inq_val As New DolfinModel.DolfinInquiryRequestModel
                    inq_val.merchantNo = model.merchantNo
                    inq_val.merchantOrderNo = model.merchantOrderNo
                    Dim inq_ret As New DolfinModel.DolfinInquiryResponseModel
                    inq_ret = GetDolfinInquiry(inq_val)
                    If inq_ret.resultFlag Then
                        Dim ret_isval As New DolfinModel.DolfinPaymentResponseModel
                        ret_isval.transactionNo = inq_ret.transactionNo
                        ret_isval.resultCode = inq_ret.resultCode
                        ret_isval.totalAmount = inq_ret.orderAmount
                        ret_isval.resultInfo = inq_ret.resultInfo
                        ret_isval.deviceInfo = ""
                        Return ret_isval

                    End If
                Catch ex3 As Exception
                    Throw ex3
                End Try
            End Try

        End Try
    End Function

    Public Function GetDolfinInquiry(model As DolfinModel.DolfinInquiryRequestModel) As DolfinModel.DolfinInquiryResponseModel
        Try
            Dim json As String = JsonConvert.SerializeObject(model)
            Dim siteUri As New Uri(API_address & API_Url.inquiry)
            Dim ret = New API(Center.Data_Config.API, timeout).POSTResponse(siteUri, json, "POST", "")
            Dim retValue As New DolfinModel.DolfinInquiryResponseModel
            retValue = JsonConvert.DeserializeObject(Of DolfinModel.DolfinInquiryResponseModel)(ret)
            If retValue.resultFlag Then
                Return retValue
            Else
                Throw New Exception("Dolfin : " + retValue.resultCode & ":: " & retValue.resultInfo)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetDolfinCancel(model As DolfinModel.DolfinCancelRequestModel) As DolfinModel.DolfinCancelResponseModel
        Try
            Dim json As String = JsonConvert.SerializeObject(model)
            Dim siteUri As New Uri(API_address & API_Url.cancel)
            Dim ret = New API(Center.Data_Config.API, timeout).POSTResponse(siteUri, json, "POST", "")
            Dim retValue As New DolfinModel.DolfinCancelResponseModel
            retValue = JsonConvert.DeserializeObject(Of DolfinModel.DolfinCancelResponseModel)(ret)
            If Not IsNothing(retValue.resultCode) Then
                Return retValue
            Else
                Throw New Exception("Dolfin : " + retValue.resultCode & ":: " & retValue.resultInfo)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
