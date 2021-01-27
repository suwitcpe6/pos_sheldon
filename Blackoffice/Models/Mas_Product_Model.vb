Imports MD
Public Class Mas_Product_Model
    Public Class value_SCR
        Public Respon As New ResponseModels
        Public Data As List(Of Product_SCR)
    End Class
    Public Class value_List
        Public Respon As New ResponseModels
        Public Data As List(Of Product_List)
    End Class
    Public Class value_data
        Public Respon As New ResponseModels
        Public Data As New Product_data
    End Class

    Public Class Product_data

        Public Product As Product = New Product()
        Public PRODUCT_SED_UNIT As List(Of MAS_PRODUCT_SED_UNIT) = New List(Of MAS_PRODUCT_SED_UNIT)

    End Class
    Public Class Product_List
        Private _ID As String
        Public Property ID() As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Private _PCODE As String
        Public Property PCODE() As String
            Get
                Return _PCODE
            End Get
            Set(value As String)
                _PCODE = value
            End Set
        End Property

        Private _PNAME As String
        Public Property PNAME() As String
            Get
                Return _PNAME
            End Get
            Set(value As String)
                _PNAME = value
            End Set
        End Property
        Private _PTNAME As String
        Public Property PTNAME() As String
            Get
                Return _PTNAME
            End Get
            Set(value As String)
                _PTNAME = value
            End Set
        End Property
        Private _PGNAME As String
        Public Property PGNAME() As String
            Get
                Return _PGNAME
            End Get
            Set(value As String)
                _PGNAME = value
            End Set
        End Property
        Private _ACTIVEFLAG As String
        Public Property ACTIVEFLAG() As String
            Get
                Return _ACTIVEFLAG
            End Get
            Set(value As String)
                _ACTIVEFLAG = value
            End Set
        End Property
        Private _MDATE As DateTime
        Public Property MDATE() As DateTime
            Get
                Return _MDATE
            End Get
            Set(value As DateTime)
                _MDATE = value
            End Set
        End Property
    End Class

    Public Class Product_SCR
        Private _PCODE As String
        Public Property PCODE() As String
            Get
                Return _PCODE
            End Get
            Set(value As String)
                _PCODE = value
            End Set
        End Property
        Private _PCODE2 As String
        Public Property PCODE2() As String
            Get
                Return _PCODE2
            End Get
            Set(value As String)
                _PCODE2 = value
            End Set
        End Property
        Private _PNAME As String
        Public Property PNAME() As String
            Get
                Return _PNAME
            End Get
            Set(value As String)
                _PNAME = value
            End Set
        End Property
        Private _PGNAME As String
        Public Property PGNAME() As String
            Get
                Return _PGNAME
            End Get
            Set(value As String)
                _PGNAME = value
            End Set
        End Property
        Private _PTNAME As String
        Public Property PTNAME() As String
            Get
                Return _PTNAME
            End Get
            Set(value As String)
                _PTNAME = value
            End Set
        End Property
        Private _COST_STD As String
        Public Property COST_STD() As Double
            Get
                Return _COST_STD
            End Get
            Set(value As Double)
                _COST_STD = value
            End Set
        End Property

        Private _UNITCODE As String
        Public Property UNITCODE() As String
            Get
                Return _UNITCODE
            End Get
            Set(value As String)
                _UNITCODE = value
            End Set
        End Property
        Private _UNITNAME As String
        Public Property UNITNAME() As String
            Get
                Return _UNITNAME
            End Get
            Set(value As String)
                _UNITNAME = value
            End Set
        End Property
    End Class
    Public Class Product
        Public Property ID As Integer
        Public Property PCODE As String
        Public Property PCODE2 As String
        Public Property PNAME As String
        Public Property PGCODE As String
        Public Property PGNAME As String

        Public Property UNITCODE As String
        Public Property IMGNAME1 As String
        Public Property COST_STD As Double

        Public Property ACTIVEFLAG As String
        Public Property DESCRIPTION As String
        Public Property REMARK As String
        Public Property [CDATE] As DateTime
        Public Property CUSE As String
        Public Property MDATE As DateTime
        Public Property MUSE As String
        Public Property ISTAT As String


        Public Property PTCODE As String
        Public Property PRICE_STD As Double

    End Class
    Public Class MAS_PRODUCT_SED_UNIT
        Public Property SEQ As Integer
        Public Property PCODE As String
        Public Property UNITCODE As String
        Public Property UNITNAME As String
        Public Property QTY_MAIN As Integer
        Public Property QTY_SED As Integer

    End Class
    Public Class TMP_IMP_PRODUCT

        Public Property SEQ As String
        Public Property RUN_ID As String
        Public Property PCODE As String
        Public Property PNAME As String
        Public Property DESCRIPTION As String
        Public Property IMG_NAME As String
        Public Property PTCODE As String
        Public Property PTNAME As String
        Public Property PGCODE As String
        Public Property PGNAME As String
        Public Property PGSCODE As String
        Public Property PGSNAME As String
        Public Property BRANDCODE As String
        Public Property BRANDNAME As String
        Public Property MODEL As String
        Public Property COLORCODE As String
        Public Property COLORNAME As String
        Public Property UNITCODE As String
        Public Property UNITNAME As String
        Public Property PACKCODE As String
        Public Property PACKNAME As String
        Public Property AGE As String
        Public Property NUM_OWD As String
        Public Property DEPCT As String
        Public Property PRICESTD As String
        Public Property WEIGHT As String
        Public Property Remark As String
        Public Property CUSE As String
    End Class

End Class
