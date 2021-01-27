Public Class CHKcard_MultiModels

    Private _BARCODE As String
    Public Property BARCODE() As String
        Get
            Return _BARCODE
        End Get
        Set(value As String)
            _BARCODE = value
        End Set
    End Property
    Private _BRNID As String
    Public Property BRNID() As String
        Get
            Return _BRNID
        End Get
        Set(value As String)
            _BRNID = value
        End Set
    End Property
    Private _Nettotel As Integer
    Public Property Nettotel() As Integer
        Get
            Return _Nettotel
        End Get
        Set(value As Integer)
            _Nettotel = value
        End Set
    End Property
    Private _SHOPID As Integer
    Public Property SHOPID() As Integer
        Get
            Return _SHOPID
        End Get
        Set(value As Integer)
            _SHOPID = value
        End Set
    End Property
    Private _workdate As String
    Public Property workdate() As String
        Get
            Return _workdate
        End Get
        Set(value As String)
            _workdate = value
        End Set
    End Property
End Class
