Imports MD
Public Class RPT_BalanceModels
    Public Class value
        Public Respon As New ResponseModels
        Public Data As List(Of Balance_data)
    End Class

    Public Class Balance_data

        Public Property STCODE As String
        Public Property STNAME As String
        Public Property PCODE As String
        Public Property PNAME As String
        Public Property PGCODE As String
        Public Property PGNAME As String

        Public Property ST_QTY As Double
        Public Property ST_UNITCODE As String
        Public Property ST_UNITNAME As String

        Public Property ST_COST As Double
    End Class

    Public Class Fillter_Balance
        Public Property STCODE As String = ""
        Public Property PCODE1 As String = ""
        Public Property PCODE2 As Object = ""

    End Class
End Class
