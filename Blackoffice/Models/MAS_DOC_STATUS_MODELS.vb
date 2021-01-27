Imports MD
Public Class MAS_DOC_STATUS_MODELS
    Public Class value
        Public Respon As New ResponseModels
        Public Data As List(Of DOC_STATUS_SEL)
    End Class
    Public Class DOC_STATUS_SEL
        Public _ID As Integer
        Public Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(value As Integer)
                _ID = value
            End Set
        End Property

        Public _DOS_ID As String
        Public Property DOS_ID() As String
            Get
                Return _DOS_ID
            End Get
            Set(value As String)
                _DOS_ID = value
            End Set
        End Property
        Public _DOS_NAME As String
        Public Property DOS_NAME() As String
            Get
                Return _DOS_NAME
            End Get
            Set(value As String)
                _DOS_NAME = value
            End Set
        End Property
        Public _DOS_DESC As String
        Public Property DOS_DESC() As String
            Get
                Return _DOS_DESC
            End Get
            Set(value As String)
                _DOS_DESC = value
            End Set
        End Property
        Public _DOS_GROUP As String
        Public Property DOS_GROUP() As String
            Get
                Return _DOS_GROUP
            End Get
            Set(value As String)
                _DOS_GROUP = value
            End Set
        End Property
        Public _CDate As DateTime
        Public Property [CDate]() As DateTime
            Get
                Return _CDate
            End Get
            Set(value As DateTime)
                _CDate = value
            End Set
        End Property
        Public _ISTAT As String
        Public Property ISTAT() As String
            Get
                Return _ISTAT
            End Get
            Set(value As String)
                _ISTAT = value
            End Set
        End Property


    End Class
End Class
