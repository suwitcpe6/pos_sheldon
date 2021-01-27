Imports MD
Public Class VoidModels
    Public Class value
        Public Respon As New ResponseModels
		Public Data As List(Of Void_EWALLET_List)
	End Class

	Public Class Void_EWALLET_List


		Public Property BARCODE As String
		Public Property MRTSLIPNO As String
		Public Property SEQ As Integer
		Public Property foodid As String
		Public Property FOODNAME As String
		Public Property MRTAMOUNT As Double
		Public Property CARDTENDOR As String
		Public Property CARDTENDOR_NAME As String


	End Class
	Public Class SALE_void

		Public Property SHOPID As String
		Public Property BARCODE As String
		Public Property MRTSLIPNO As String
		Public Property SEQ As Integer
		Public Property foodid As String
		Public Property FOODNAME As String
		Public Property CARDTENDOR As String
		Public Property CARDTENDOR_NAME As String
		Public Property Voidtype As String
		Public Property CN_DOCNO As String
		Public Property VOIDNO As String

	End Class

End Class
