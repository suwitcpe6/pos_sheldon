Public Class TrueQueryResponseModel
    Public Status As New Status_
    Public Data As New Data_



    Public Class Status_
        Public code As String
        Public message As String
    End Class

    Public Class Data_
        Public payment_id As String
        Public isv_payment_ref As String
        Public isv As String
        Public merchant As String
        Public amount As String
        Public currency As String
        Public customer As String
        Public status As String
        Public response_code As String
        Public response_message As String
        Public refunded As String
        Public created As String
        Public updated As String
        Public MetaData As New MetaData
        Public refunds As New List(Of Refunds)
    End Class



    Public Class Refunds
        Public refund_id As String
        Public isv_refund_ref As String
        Public amount As String
        Public created As String
        Public status As String
        Public response_code As String
        Public response_message As String
    End Class

    Public Class MetaData
        Public description As String
        Public user_mobile As String
        Public shop_id As String
        Public client_id As String
        Public partner_shop_id As String
        Public orion_channel As String
        Public terminal_id As String
        Public payment_code As String
    End Class
End Class

