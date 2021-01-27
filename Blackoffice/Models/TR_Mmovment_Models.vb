Imports MD
Public Class TR_Mmovment_Models

    Public Class value_SAVE
        Public Respon As New ResponseModels
        Public Data As New Data_SAVE

    End Class
    Public Class value_Year_end
        Public Respon As New ResponseModels
        Public Data As New List(Of Year_end)

    End Class
    Public Class value_Data_Yearend
        Public Respon As New ResponseModels
        Public Data As New List(Of Data_MOVT_D)

    End Class
    Public Class value_List
        Public Respon As New ResponseModels
        Public Data As List(Of Data_List)
    End Class
    Public Class value_Cancel
        Public Respon As New ResponseModels
        Public Data As Object
    End Class
    Public Class value_Location_DATA
        Public Respon As New ResponseModels
        Public Data As List(Of Location_DATA)
    End Class
    Public Class value_MOV_BALANCE
        Public Respon As New ResponseModels
        Public Data As List(Of MOV_BALANCE)
    End Class
    Public Class value_MOV_SCR_TO
        Public Respon As New ResponseModels
        Public Data As List(Of MOV_SCR_TO)
    End Class
    Public Class value_MOV_SCR_RP
        Public Respon As New ResponseModels
        Public Data As List(Of MOV_SCR_RP)
    End Class
    Public Class value_PRODUCT_TAGID
        Public Respon As New ResponseModels
        Public Data As List(Of PRODUCT_TAGID)
    End Class
    Public Class value_PERSON_DATA
        Public Respon As New ResponseModels
        Public Data As List(Of PERSON_DATA)
    End Class
    Public Class Year_end
        Public Property DOCYEAR As String

    End Class

    Public Class Location_DATA
        Public Property TR_ID As String
        Public Property BUILD_TRID As String
        Public Property BDCODE As String
        Public Property BDNAME As String
        Public Property FCODE As String
        Public Property FNAME As String
        Public Property RCODE As String
        Public Property RNAME As String
        Public Property LOCID As String

    End Class
    Public Class Data_List
        Public Property TR_ID As String
        Public Property DOCTYPE As String
        Public Property DOCNO As String
        Public Property DOCDATE As DateTime
        Public Property DCSTAT As String
        Public Property REF_DOCNO As String
        Public Property STNAME As String
        Public Property TOTAL_QTY As Decimal
        Public Property pername As String
        Public Property MDATE As DateTime
    End Class
    Public Class Data_SAVE
        Public Data_H As New Data_MOVT
        Public Data_ITEMS As New List(Of Data_MOVT_D)
        Public Data_BALANCE As New List(Of MOV_BALANCE)
    End Class
    Public Class Data_MOVT

        Public Property ID As Integer
        Public Property TR_ID As String
        Public Property DOCTYPE As String
        Public Property DOCNO As String
        Public Property DOCDATE As DateTime
        Public Property DOCYEAR As String
        Public Property DOCMONTH As String
        Public Property CORP_CODE As String
        Public Property Branch_CODE As String
        Public Property MOV_TYPE As String
        Private _TOTAL_QTY As Integer
        Public Property TOTAL_QTY As Double
            Get
                Return CInt(_TOTAL_QTY)
            End Get
            Set(value As Double)
                _TOTAL_QTY = CInt(value)
            End Set
        End Property
        Public Property TOTAL_AMOUNT As Decimal
        Public Property REF_DOCNO As String
        Public Property REF_DOCTYPE As String
        Public Property LOT_ID As String
        Public Property STCODE As String
        Public Property REMARK1 As String
        Public Property REMARK2 As String
        Public Property REMARK3 As String
        Public Property REMARK4 As String
        Public Property REMARK5 As String
        Public Property DESCRIPTION As String
        Public Property DCSTAT As String
        Public Property [CDATE] As DateTime
        Public Property CUSE As String
        Public Property MDATE As DateTime
        Public Property MUSE As String
        Public Property ISTAT As String
        Public Property PERCODE As String
        Public Property PERNAME As String
        Public Property DAY_END As String
        Public Property YEAR As String = ""


    End Class
    Public Class Data_MOVT_D
        Public Property TR_ID As String
        Public Property DOCTYPE As String
        Public Property DOCNO As String
        Public Property SEQ As Integer
        Public Property PCODE As String
        Public Property PNAME As String
        Private _QTY As Decimal
        Public Property QTY As Double
            Get
                Return CInt(_QTY)
            End Get
            Set(value As Double)
                _QTY = CInt(value)
            End Set
        End Property
        Public Property IDC As Integer
        Public Property UNIT_COST As Decimal
        Public Property UNITCODE As String
        Public Property UNITNAME As String
        Public Property ST_QTY As Decimal
        Public Property ST_QTY2 As Decimal
        Public Property ST_COST As Decimal
        Public Property ST_UNITCODE As String
        Public Property ST_UNITNAME As String
        Public Property TOTAL_COST As Decimal
        Public Property REMARK1 As String
        Public Property REMARK2 As String
        Public Property REMARK3 As String
        Public Property REMARK4 As String
        Public Property REMARK5 As String
    End Class
    Public Class MOV_BALANCE

        Public Property ID As Integer
        Public Property MOV_ID As String
        Public Property MOV_DOCNO As String
        Public Property MOV_DOCTYPE As String
        Public Property CORP_CODE As String
        Public Property Branch_CODE As String
        Public Property STCODE As String
        Public Property LOT_ID As String
        Public Property PCODE As String
        Public Property QTY As Decimal
        Public Property IDC As Integer
        Public Property COST As Decimal
        Public Property UNITCODE As String
        Public Property ST_QTY As Decimal
        Public Property ST_COST As Decimal
        Public Property ST_UNITCODE As String
        Public Property REMARK As String
        Public Property [CDATE] As DateTime
        Public Property CUSE As String
        Public Property MDATE As DateTime
        Public Property MUSE As String
        Public Property DCSTAT As String
        Public Property ISTAT As String


    End Class
    Public Class MOV_SCR_TO

        Public Property TR_ID As String
        Public Property DOCNO As String
        Public Property DOCTYPE As String
        Public Property SEQ As Integer
        Public Property PID As String
        Public Property PCODE As String
        Public Property PNAME As String
        Public Property TAGID As String
        Public Property LOCID As String
        Public Property UNIT_PRICE As Decimal
        Public Property UNIT_ID As String
        Public Property UNITCODE As String
        Public Property UNITNAME As String

    End Class
    Public Class MOV_SCR_RP

        Public Property TR_ID As String
        Public Property DOCNO As String
        Public Property DOCTYPE As String
        Public Property SEQ As Integer
        Public Property PID As String
        Public Property PCODE As String
        Public Property PNAME As String
        Public Property TAGID As String
        Public Property LOCID As String
        Public Property UNIT_PRICE As Decimal
        Public Property UNIT_ID As String
        Public Property UNITCODE As String
        Public Property UNITNAME As String
        Public Property LOC_OUTSIDE As String


    End Class
    Public Class PRODUCT_TAGID

        Public Property TR_ID As String
        Public Property TAGID As String
        Public Property PCODE As String
        Public Property PNAME As String
        Public Property BARCODE As String
        Public Property TYPEID As String
        Public Property PTCODE As String
        Public Property PTNAME As String
        Public Property GROUPID As String
        Public Property PGCODE As String
        Public Property PGNAME As String
        Public Property SUBGROUPID As String
        Public Property PGSCODE As String
        Public Property PGSNAME As String
        Public Property BRANDCODE As String
        Public Property BRANDNAME As String
        Public Property MODELCODE As String
        Public Property COLORCODE As String
        Public Property COLORNAME As String
        Public Property UNIT_ID As String
        Public Property UNITCODE As String
        Public Property UNITNAME As String
        Public Property PACKCODE As String
        Public Property PACKNAME As String
        Public Property PRICESTD As Integer
        Public Property ACTIVEFLAG As String

    End Class

    Public Class PERSON_DATA
        Public Property PER_ID As String
        Public Property PERCODE As String
        Public Property PERNAME As String
    End Class
End Class
