Imports MD
Public Class USERPROFILE_Mmodels

    Public Class value
        Public Respon As New ResponseModels
        Public Data As List(Of USERPROFILE_Data)
    End Class

    Public Class USERPROFILE_Data

        Public Property UID As String
        Public Property UFULLNAME As String
        Public Property UPASSWORD As String
        Public Property ULEVEL As String
        Public Property USTATUS As String
        Public Property UREMARK As String
        Public Property UUID As String
        Public Property date_now As DateTime
    End Class


End Class
