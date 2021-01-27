

Public Class confirmpay
    Public payment As New ConfirmpayModels
    Public SALE_INT As New SALE_Models.SALE_INT

End Class

Public Class ConfirmpayModels

    Public payment_id As String
    Public mrt_slip As String
    Public SHOPID As String


    Public typeid As String
    Public cused As String
    Public barcode As String
    Public cused1 As String
    Public clstatus As String
    Public clamount As String
    Public clreceive As String
    Public cpromotion As String
    Public tid As String
    Public uid As String
    Public tendor As String
    Public clupdate As String
    Public processdate As String
    Public remark As String
End Class
Public Class ConfirmpayModels_log
    Property pid As String
    Property typeid As String
    Property barcode As String
    Property clstatus As String
    Property clamount As String
    Property clreceive As String
    Property cpromotion As String
    Property tid As String
    Property uid As String
    Property tendor As String
    Property clupdate As String
    Property processdate As String
    Property Remark As String
    Property LOG_TYPE As String
    Property MRTSLIPNO As String
    Property SHOPID As String
    Property POSID As String
    Property MERCHAND_ID As String
    Property APP_ID As String
    Property PAYMENT_CODE As String
    Property PAY_AMOUNT As String
    Property PAY_STATE As String
    Property PAY_DESCRIPTION As String
    Property PAY_Remark As String
    Property result_code As String
End Class
