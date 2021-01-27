Public Class THAI_QRModel
    Public Class KasikornRequestQRCodeModel
        Public refer2 As String
        Public partnerTxnUid As String

        Public partnerId As String

        Public partnerSecret As String

        Public requestDt As String

        Public merchantId As String

        Public terminalId As String

        Public qrType As String

        Public txnAmount As String

        Public txnCurrencyCode As String

        Public reference1 As String
        Dim _reference2 As String
        Public Property reference2() As String

            Get
                Return _reference2
            End Get
            Set(value As String)
                _reference2 = "Admin" 'value
            End Set
            'Get
            '    { return refer2; }
            '    Set
            '    { this.refer2 = "Admin"; }
        End Property

        Public reference3 As String

        Public reference4 As String

        Public metadata As String
    End Class
    Public Class KasikornResponseQRCodeModel

        Public partnerTxnUid As String
        Public partnerId As String
        Public statusCode As String
        Public errorCode As String
        Public errorDesc As String
        Public accountName As String
        Public qrCode As String

    End Class
End Class
