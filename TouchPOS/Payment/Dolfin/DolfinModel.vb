Public Class DolfinModel
#Region "Payment"
    Public Class DolfinPaymentRequestModel
        Public authCode As String
        Public currency As String
        Public merchantNo As String
        Public merchantOrderNo As String
        Public totalAmount As String
        Public storecode As String
    End Class
    Public Class DolfinPaymentResponseModel
        Public resultFlag As Boolean
        Public resultCode As String
        Public resultInfo As String
        Public merchantNo As String
        Public merchantOrderNo As String
        Public merchantUserId As String
        Public finCustomerId As String
        Public deviceInfo As String
        Public currency As String
        Public totalAmount As Double
        Public transactionNo As String
        Public timeEnd As String
        Public attach As String
    End Class


#End Region
#Region "Inquiry"
    Public Class DolfinInquiryRequestModel
        Public merchantNo As String
        Public merchantOrderNo As String
    End Class
    Public Class DolfinInquiryResponseModel
        Public resultFlag As Boolean
        Public resultCode As String
        Public resultInfo As String
        Public merchantNo As String
        Public merchantOrderNo As String
        Public merchantUserId As String
        Public finCustomerId As String
        Public transactionType As Integer
        Public transactionNo As String
        Public orderAmount As Double
        Public orderCurrency As String
        Public orderCountry As String
        Public orderType As String
        Public productType As String
    End Class
#End Region
#Region "Cancel"
    Public Class DolfinCancelRequestModel

        Public merchantNo As String
        Public merchantOrderNo As String
    End Class
    Public Class DolfinCancelResponseModel

        Public resultFlag As Boolean
        Public resultCode As String
        Public resultInfo As String
        Public merchantNo As String
        Public merchantOrderNo As String
        Public transactionNo As String
    End Class
#End Region
End Class
