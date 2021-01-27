Imports MD

Public Class MAS_DOCTYPE_Models
    Public Class value
        Public Respon As New ResponseModels
        Public Data As List(Of DOCTYPE_Models)
    End Class
    Public Class DOCTYPE_Models
        Public Property DocTypeGroupCode As String
        Public Property DOCTYPECODE As String
        Public Property DOCTYPENAME As String
    End Class
End Class
