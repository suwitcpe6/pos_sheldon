Imports MD
Public Class CardModels

    Public Class value
        'Public Result As Boolean
        'Public ErrorMessage As String
        'Public SystemErrorMessage As String
        Public Respon As New ResponseModels
        Public Data As List(Of Model)

    End Class
    Public Class Model
        Private _CID As Integer
        Public Property CID() As Integer
            Get
                Return _CID
            End Get
            Set(value As Integer)
                _CID = value
            End Set
        End Property

        Private _CUSED As Integer
        Public Property CUSED() As Integer
            Get
                Return _CUSED
            End Get
            Set(value As Integer)
                _CUSED = value
            End Set
        End Property

        Private _BARCODE As String
        Public Property BARCODE() As String
            Get
                Return _BARCODE
            End Get
            Set(value As String)
                _BARCODE = value
            End Set
        End Property

        Private _TYPEID As Integer
        Public Property TYPEID() As Integer
            Get
                Return _TYPEID
            End Get
            Set(value As Integer)
                _TYPEID = value
            End Set
        End Property

        Private _CADDITEM As String
        Public Property CADDITEM() As String
            Get
                Return _CADDITEM
            End Get
            Set(value As String)
                _CADDITEM = value
            End Set
        End Property



        Private _CEXPIRED As DateTime
        Public Property CEXPIRED() As DateTime
            Get
                Return _CEXPIRED
            End Get
            Set(value As DateTime)
                _CEXPIRED = value
            End Set
        End Property

        Private _CSTATUS As String
        Public Property CSTATUS() As String
            Get
                Return _CSTATUS
            End Get
            Set(value As String)
                _CSTATUS = value
            End Set
        End Property

        Private _CBALANCE As Integer
        Public Property CBALANCE() As Integer
            Get
                Return _CBALANCE
            End Get
            Set(value As Integer)
                _CBALANCE = value
            End Set
        End Property

        Private _CLUPDATE As DateTime
        Public Property CLUPDATE() As DateTime
            Get
                Return _CLUPDATE
            End Get
            Set(value As DateTime)
                _CLUPDATE = value
            End Set
        End Property

        Private _BACKUPFLG As Boolean
        Public Property BACKUPFLG() As Boolean
            Get
                Return _BACKUPFLG
            End Get
            Set(value As Boolean)
                _BACKUPFLG = value
            End Set
        End Property

        Private _CUSED1 As Short
        Public Property CUSED1() As Short
            Get
                Return _CUSED1
            End Get
            Set(value As Short)
                _CUSED1 = value
            End Set
        End Property

        Private _PROCESSDATE As DateTime
        Public Property PROCESSDATE() As DateTime
            Get
                Return _PROCESSDATE
            End Get
            Set(value As DateTime)
                _PROCESSDATE = value
            End Set
        End Property
    End Class
End Class
