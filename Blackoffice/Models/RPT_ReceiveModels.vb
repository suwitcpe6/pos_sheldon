Imports MD

Public Class RPT_ReceiveModels
    Public Class value
        Public Respon As New ResponseModels
        Public Data As List(Of Rceive_data)
    End Class

    Public Class Rceive_data
        Public Property TR_ID As String
        Public Property DOCTYPE As String
        Public Property DOCNO As String
        Private _DOCDATE As String
        Public Property DOCDATE() As String
            Get
                Return _DOCDATE
            End Get
            Set(value As String)
                Dim d1 As DateTime
                d1 = CDate(value)
                _DOCDATE = CL_date.Condate(d1, "dd/MM/yyyy", "TH")
            End Set
        End Property
        Public Property STCODE As String
        Public Property PERCODE As String
        Public Property PERNAME As String
        Public Property REF_DOCNO As String
        Public Property SEQ As Double
        Public Property PCODE As String
        Public Property PNAME As String
        Public Property qty As Double
        Public Property IDC As Integer
        Public Property UNITCODE As String
        Public Property UNITNAME As String
        Public Property ST_QTY As Double
        Public Property ST_UNITCODE As String
        Public Property ST_UNITNAME As String
        Public Property PGCODE As String
        Public Property PGNAME As String

        Public Property UNIT_COST As Double
        Public Property ST_COST As Double
        Public Property TOTAL_COST As Double
    End Class

    Public Class Fillter_Receive
        Public Property DOCTYPE As String = ""
        Public Property DCDATE As String = ""
        Public Property DOCNO As String = ""
        Public Property REFDOCNO As Object = ""
        Public Property PERCODE As Object = ""

    End Class

End Class
