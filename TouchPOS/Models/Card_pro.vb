Imports MD
Public Class Card_pro

    Public Class value
        'Public Result As Boolean
        'Public ErrorMessage As String
        'Public SystemErrorMessage As String
        Public Respon As New ResponseModels
        Public Data As List(Of Model)

    End Class
    Public Class Model

        Private _BARCODE As String
        Public Property BARCODE() As String
            Get
                Return _BARCODE
            End Get
            Set(value As String)
                _BARCODE = value
            End Set
        End Property
        Private _CARDTYPE As String
        Public Property CARDTYPE() As String
            Get
                Return _CARDTYPE
            End Get
            Set(value As String)
                _CARDTYPE = value
            End Set
        End Property

        Private _TYPEDESCRIPTION As String
        Public Property TYPEDESCRIPTION() As String
            Get
                Return _TYPEDESCRIPTION
            End Get
            Set(value As String)
                _TYPEDESCRIPTION = value
            End Set
        End Property


        Private _maxvalue As Double
        Public Property maxvalue() As Double
            Get
                Return _maxvalue
            End Get
            Set(value As Double)
                _maxvalue = value
            End Set
        End Property
        Private _MINVALUE As Double
        Public Property MINVALUE() As Double
            Get
                Return _MINVALUE
            End Get
            Set(value As Double)
                _MINVALUE = value
            End Set
        End Property
    End Class
End Class
