
Imports MD

Public Class API_VersionModels
    Public Class value
        'Public Result As Boolean
        'Public ErrorMessage As String
        'Public SystemErrorMessage As String
        Public Respon As New ResponseModels
        'Public Data As Model
        Public Data As List(Of Model)
    End Class

    Public Class Model

        Private _API_Version As String
        Public Property API_Version() As String
            Get
                Return _API_Version
            End Get
            Set(value As String)
                _API_Version = value
            End Set
        End Property
    End Class
End Class