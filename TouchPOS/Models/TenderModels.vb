Imports MD
Public Class TenderModels
    Public Class value
        Public Respon As New ResponseModels
        Public Data As List(Of Sel_Tender)

    End Class
    Public Class Sel_Tender

        Private _TID As Integer
        Public Property TID() As Integer
            Get
                Return _TID
            End Get
            Set(value As Integer)
                _TID = value
            End Set
        End Property
        Private _CODE As String
        Public Property CODE() As String
            Get
                Return _CODE
            End Get
            Set(value As String)
                _CODE = value
            End Set
        End Property

        Private _NAME As String
        Public Property NAME() As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property
        Private _VENDERCODE As String
        Public Property VENDERCODE() As String
            Get
                Return _VENDERCODE
            End Get
            Set(value As String)
                _VENDERCODE = value
            End Set
        End Property
        Private _VENDERNAME As String
        Public Property VENDERNAME() As String
            Get
                Return _VENDERNAME
            End Get
            Set(value As String)
                _VENDERNAME = value
            End Set
        End Property
        Private _TYPE As String
        Public Property TYPE() As String
            Get
                Return _TYPE
            End Get
            Set(value As String)
                _TYPE = value
            End Set
        End Property

        Private _CERRENCY As String
        Public Property CERRENCY() As String
            Get
                Return _CERRENCY
            End Get
            Set(value As String)
                _CERRENCY = value
            End Set
        End Property

        Private _PAYMENT_METHOD As String
        Public Property PAYMENT_METHOD() As String
            Get
                Return _PAYMENT_METHOD
            End Get
            Set(value As String)
                _PAYMENT_METHOD = value
            End Set
        End Property


        Private _VALUE_CONVERT As Decimal
        Public Property VALUE_CONVERT() As Decimal
            Get
                Return _VALUE_CONVERT
            End Get
            Set(value As Decimal)
                _VALUE_CONVERT = value
            End Set
        End Property
        Private _Server As String
        Public Property Server() As String
            Get
                Return _Server
            End Get
            Set(value As String)
                _Server = value
            End Set
        End Property

        Private _SEQ As Integer
        Public Property SEQ() As Integer
            Get
                Return _SEQ
            End Get
            Set(value As Integer)
                _SEQ = value
            End Set
        End Property

        Private _TERMINALID As String
        Public Property TERMINALID() As String
            Get
                Return _TERMINALID
            End Get
            Set(value As String)
                _TERMINALID = value
            End Set
        End Property

        Private _POSID As String
        Public Property POSID() As String
            Get
                Return _POSID
            End Get
            Set(value As String)
                _POSID = value
            End Set
        End Property

        Private _MERCHAND_ID As String
        Public Property MERCHAND_ID() As String
            Get
                Return _MERCHAND_ID
            End Get
            Set(value As String)
                _MERCHAND_ID = value
            End Set
        End Property


        Private _APP_ID As String
        Public Property APP_ID() As String
            Get
                Return _APP_ID
            End Get
            Set(value As String)
                _APP_ID = value
            End Set
        End Property

        Private _CLIENT_KEY As String
        Public Property CLIENT_KEY() As String
            Get
                Return _CLIENT_KEY
            End Get
            Set(value As String)
                _CLIENT_KEY = value
            End Set
        End Property
        Private _CLIENT_SECRET As String
        Public Property CLIENT_SECRET() As String
            Get
                Return _CLIENT_SECRET
            End Get
            Set(value As String)
                _CLIENT_SECRET = value
            End Set
        End Property

        Private _PREFIX_BARCODE As String
        Public Property PREFIX_BARCODE() As String
            Get
                Return _PREFIX_BARCODE
            End Get
            Set(value As String)
                _PREFIX_BARCODE = value
            End Set
        End Property
        Private _REMARK1 As String
        Public Property REMARK1() As String
            Get
                Return _REMARK1
            End Get
            Set(value As String)
                _REMARK1 = value
            End Set
        End Property
        Private _REMARK2 As String
        Public Property REMARK2() As String
            Get
                Return _REMARK2
            End Get
            Set(value As String)
                _REMARK2 = value
            End Set
        End Property
        Private _REMARK3 As String
        Public Property REMARK3() As String
            Get
                Return _REMARK3
            End Get
            Set(value As String)
                _REMARK3 = value
            End Set
        End Property
        Private _SCAN_TYPE As String
        Public Property SCAN_TYPE() As String
            Get
                Return _SCAN_TYPE
            End Get
            Set(value As String)
                _SCAN_TYPE = value
            End Set
        End Property

        Private _VENDER_SHOP_ID As String
        Public Property VENDER_SHOP_ID() As String
            Get
                Return _VENDER_SHOP_ID
            End Get
            Set(value As String)
                _VENDER_SHOP_ID = value
            End Set
        End Property

    End Class
End Class
