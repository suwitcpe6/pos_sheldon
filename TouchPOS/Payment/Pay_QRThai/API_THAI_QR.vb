Imports MD
Imports Newtonsoft.Json
Public Class API_THAI_QR
    Public API_THAI_QR As String = "" '"http://localhost:59929/" 'System.Configuration.ConfigurationSettings.AppSettings.Get("API_true") + "/"
    'Public API_THAI_QR As String = "http://api.sahatarasst.com:8028/"
    Public API_Url As New API_link
    Public Const stringformat As String = "yyyy-MM-ddTHH:mm:ss+07:00"
    Public Const Sleep As Integer = 3000
    Public Class API_link
        Public PaymentRequest = "api/request"
        'Public QueryIsrRequest = "trueapi/queryisr"
        'Public querypaymentid = "trueapi/querypaymentid"
        'Public test = "trueapi/test?val1={0}&val2={1}"
    End Class
    Sub New(link As String)
        API_THAI_QR = link
    End Sub
    Public Function PaymentRequest(model As THAI_QRModel.KasikornRequestQRCodeModel) As THAI_QRModel.KasikornResponseQRCodeModel
        Try
            Dim json As String = JsonConvert.SerializeObject(model)
            Dim siteUri As New Uri(API_THAI_QR & API_Url.PaymentRequest)
            Dim ret = New API(Center.Data_Config.API,).POSTResponse(siteUri, json, "POST", "")
            Dim retValue As New THAI_QRModel.KasikornResponseQRCodeModel
            retValue = JsonConvert.DeserializeObject(Of THAI_QRModel.KasikornResponseQRCodeModel)(ret)
            If Not IsNothing(retValue.statusCode) Then
                Return retValue
            Else
                Throw New Exception("True : " + retValue.statusCode)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function QueryPaymentRequest(ByVal first_call As Boolean, model As TrueQueryPaymentRequestModel) As TrueQueryPaymentResponseModel
        Try
            'Dim json As String = JsonConvert.SerializeObject(model)
            'Dim siteUri As New Uri(API_THAI_QR & API_Url.QueryIsrRequest)
            'Dim ret = New API(Center.Data_Config.API,).POSTResponse(siteUri, json, "POST", "")
            'Dim retValue As TrueQueryPaymentResponseModel = JsonConvert.DeserializeObject(Of TrueQueryPaymentResponseModel)(ret)

            'If Not IsNothing(retValue.Data) Then
            '    Return retValue
            'Else
            '    Throw New Exception("True : " + retValue.Status.code + " : ไม่พบข้อมูลบัตร กรุณาลองอีกครั้ง")
            'End If

        Catch ex As Exception

        End Try
    End Function
End Class
