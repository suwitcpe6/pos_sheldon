Imports MD
Public Class MenuModel

    Public Class value
        Public Respon As New ResponseModels
        Public Data As List(Of Model)

    End Class
    Public Class Model
        Public Property ID As String
        Public Property MNU_CODE As String
        Public Property MNU_HSEQ As String
        Public Property MNU_HNAME_1 As String
        Public Property MNU_HNAME_2 As String
        Public Property MNU_SSEQ As String
        Public Property MNU_SNAME_1 As String
        Public Property MNU_SNAME_2 As String
        Public Property MNU_TAG As String
        Public Property MNU_OBJ1 As String
        Public Property MNU_OBJ2 As String
        Public Property MNU_ICO As String
        Public Property MNU_DEFAULT_DOCTYPE As String
        Public Property U_DATE As String
        Public Property U_ID As String
        Public Property ISTAT As String

    End Class
End Class
