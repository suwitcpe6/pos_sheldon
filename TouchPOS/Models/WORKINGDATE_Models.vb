Imports MD
Public Class WORKINGDATE_Models
    Public Class value
        'Public Result As Boolean
        'Public ErrorMessage As String
        'Public SystemErrorMessage As String
        Public Respon As New ResponseModels
        Public Data As List(Of Model)

    End Class
    Public Class Date_now_Models

        Public Date_now As DateTime

    End Class
    Public Class Model

        Private _id As Integer
        Public Property id() As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Private _DATEWORKING As DateTime
        Public Property DATEWORKING() As DateTime
            Get
                Return _DATEWORKING
            End Get
            Set(value As DateTime)
                _DATEWORKING = value
            End Set
        End Property
    End Class
End Class
