
Imports MD
Public Class COMPANYPROFILE_Models
    Public Class value
        Public Respon As New ResponseModels
        Public Data As List(Of COMPANYPROFILE_Data)
    End Class

    Public Class COMPANYPROFILE_Data
        Public Property COMID As Integer
        Public Property BRNID As String
        Public Property BRNNAMETHAI As String
        Public Property BRNNAMEENG As String
        Public Property BRNTAXID As String
        Public Property BRNVAT As Double
        Public Property COMPNAME As String
        Public Property ADDRESS1 As String
        Public Property ADDRESS2 As String
        Public Property REMARK As String
        Public Property GATEWAY As Boolean
        Public Property LOCATION As String
        Public Property DIVISION As String
        Public Property COMPANYCODE As String
        Public Property BRNID2 As String
        Public Property LOCATION2 As String
        Public Property SERVICECHARGE As Double
        Public Property FullTaxNo As String
        Public Property TCustCode As String
    End Class




End Class
