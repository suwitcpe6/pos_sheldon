Public Class TrueRequestModel
    Public isv_payment_ref As String
    Public merchant_id As String
    Public currency As String
    Public request_amount As String
    Public payment_method As String
    Public payment_code As String
    Public description As String
    Public metadata As New MetaData


End Class
Public Class MetaData
    Public shop_id As String ' ของทรู
    Public partner_shop_id As String
    Public partner_shop_name As String
End Class

