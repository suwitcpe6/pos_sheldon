
Imports MD
Namespace SHOP_ModelS

    Public Class value
        'Public Result As Boolean
        'Public ErrorMessage As String
        'Public SystemErrorMessage As String
        Public Respon As New ResponseModels
        Public Data As List(Of Model)

    End Class
    Public Class Model

        Private _SHOPID As Integer
        Public Property SHOPID() As Integer
            Get
                Return _SHOPID
            End Get
            Set(value As Integer)
                _SHOPID = value
            End Set
        End Property

        Private _MRIP As String
        Public Property MRIP() As String
            Get
                Return _MRIP
            End Get
            Set(value As String)
                _MRIP = value
            End Set
        End Property

        Private _MRID As String
        Public Property MRID() As String
            Get
                Return _MRID
            End Get
            Set(value As String)
                _MRID = value
            End Set
        End Property

        Private _POSID As String
        Public Property POSID() As String
            Get
                Return _POSID
            End Get
            Set(value As String)
                _POSID = value
            End Set
        End Property

        Private _SHOPNAME As String
        Public Property SHOPNAME() As String
            Get
                Return _SHOPNAME
            End Get
            Set(value As String)
                _SHOPNAME = value
            End Set
        End Property

        Private _OWNER As String
        Public Property OWNER() As String
            Get
                Return _OWNER
            End Get
            Set(value As String)
                _OWNER = value
            End Set
        End Property

        Private _SLIPNO As String
        Public Property SLIPNO() As String
            Get
                Return _SLIPNO
            End Get
            Set(value As String)
                _SLIPNO = value
            End Set
        End Property

        Private _FOODTYPE As String
        Public Property FOODTYPE() As String
            Get
                Return _FOODTYPE
            End Get
            Set(value As String)
                _FOODTYPE = value
            End Set
        End Property

        Private _SHAREPERCENT As Decimal
        Public Property SHAREPERCENT() As Decimal
            Get
                Return _SHAREPERCENT
            End Get
            Set(value As Decimal)
                _SHAREPERCENT = value
            End Set
        End Property

        Private _VAT As Boolean
        Public Property VAT() As Boolean
            Get
                Return _VAT
            End Get
            Set(value As Boolean)
                _VAT = value
            End Set
        End Property

        Private _CONTACT As String
        Public Property CONTACT() As String
            Get
                Return _CONTACT
            End Get
            Set(value As String)
                _CONTACT = value
            End Set
        End Property

        Private _CONTSTATUS As String
        Public Property CONTSTATUS() As String
            Get
                Return _CONTSTATUS
            End Get
            Set(value As String)
                _CONTSTATUS = value
            End Set
        End Property

        Private _STARTDATE As DateTime
        Public Property STARTDATE() As DateTime
            Get
                Return _STARTDATE
            End Get
            Set(value As DateTime)
                _STARTDATE = value
            End Set
        End Property

        Private _ENDDATE As DateTime
        Public Property ENDDATE() As DateTime
            Get
                Return _ENDDATE
            End Get
            Set(value As DateTime)
                _ENDDATE = value
            End Set
        End Property

        Private _UID As String
        Public Property UID() As String
            Get
                Return _UID
            End Get
            Set(value As String)
                _UID = value
            End Set
        End Property

        Private _LUPDATE As DateTime
        Public Property LUPDATE() As DateTime
            Get
                Return _LUPDATE
            End Get
            Set(value As DateTime)
                _LUPDATE = value
            End Set
        End Property

        Private _KEY01 As Short
        Public Property KEY01() As Short
            Get
                Return _KEY01
            End Get
            Set(value As Short)
                _KEY01 = value
            End Set
        End Property

        Private _KEY02 As Short
        Public Property KEY02() As Short
            Get
                Return _KEY02
            End Get
            Set(value As Short)
                _KEY02 = value
            End Set
        End Property

        Private _KEY03 As Short
        Public Property KEY03() As Short
            Get
                Return _KEY03
            End Get
            Set(value As Short)
                _KEY03 = value
            End Set
        End Property

        Private _KEY04 As Short
        Public Property KEY04() As Short
            Get
                Return _KEY04
            End Get
            Set(value As Short)
                _KEY04 = value
            End Set
        End Property

        Private _KEY05 As Short
        Public Property KEY05() As Short
            Get
                Return _KEY05
            End Get
            Set(value As Short)
                _KEY05 = value
            End Set
        End Property

        Private _KEY06 As Short
        Public Property KEY06() As Short
            Get
                Return _KEY06
            End Get
            Set(value As Short)
                _KEY06 = value
            End Set
        End Property

        Private _KEY07 As Short
        Public Property KEY07() As Short
            Get
                Return _KEY07
            End Get
            Set(value As Short)
                _KEY07 = value
            End Set
        End Property

        Private _KEY08 As Short
        Public Property KEY08() As Short
            Get
                Return _KEY08
            End Get
            Set(value As Short)
                _KEY08 = value
            End Set
        End Property

        Private _KEY09 As Short
        Public Property KEY09() As Short
            Get
                Return _KEY09
            End Get
            Set(value As Short)
                _KEY09 = value
            End Set
        End Property

        Private _ACTIVEFLAG As Boolean
        Public Property ACTIVEFLAG() As Boolean
            Get
                Return _ACTIVEFLAG
            End Get
            Set(value As Boolean)
                _ACTIVEFLAG = value
            End Set
        End Property

        Private _ACCPAID As Decimal
        Public Property ACCPAID() As Decimal
            Get
                Return _ACCPAID
            End Get
            Set(value As Decimal)
                _ACCPAID = value
            End Set
        End Property

        Private _VOIDNO As String
        Public Property VOIDNO() As String
            Get
                Return _VOIDNO
            End Get
            Set(value As String)
                _VOIDNO = value
            End Set
        End Property

        Private _SHOPTYPE As String
        Public Property SHOPTYPE() As String
            Get
                Return _SHOPTYPE
            End Get
            Set(value As String)
                _SHOPTYPE = value
            End Set
        End Property

        Private _SLIPTYPE As String
        Public Property SLIPTYPE() As String
            Get
                Return _SLIPTYPE
            End Get
            Set(value As String)
                _SLIPTYPE = value
            End Set
        End Property

        Private _CPNSHOPTYPE As String
        Public Property CPNSHOPTYPE() As String
            Get
                Return _CPNSHOPTYPE
            End Get
            Set(value As String)
                _CPNSHOPTYPE = value
            End Set
        End Property

        Private _BUDGETPERMONTH As Short
        Public Property BUDGETPERMONTH() As Short
            Get
                Return _BUDGETPERMONTH
            End Get
            Set(value As Short)
                _BUDGETPERMONTH = value
            End Set
        End Property

        Private _MINIMUM As Short
        Public Property MINIMUM() As Short
            Get
                Return _MINIMUM
            End Get
            Set(value As Short)
                _MINIMUM = value
            End Set
        End Property

        Private _SHAREPERCENTFLAG As String
        Public Property SHAREPERCENTFLAG() As String
            Get
                Return _SHAREPERCENTFLAG
            End Get
            Set(value As String)
                _SHAREPERCENTFLAG = value
            End Set
        End Property

        Private _GPRULE As String
        Public Property GPRULE() As String
            Get
                Return _GPRULE
            End Get
            Set(value As String)
                _GPRULE = value
            End Set
        End Property

        Private _STOCK As String
        Public Property STOCK() As String
            Get
                Return _STOCK
            End Get
            Set(value As String)
                _STOCK = value
            End Set
        End Property

        Private _MAINMENU As String
        Public Property MAINMENU() As String
            Get
                Return _MAINMENU
            End Get
            Set(value As String)
                _MAINMENU = value
            End Set
        End Property

        Private _RONAME As String
        Public Property RONAME() As String
            Get
                Return _RONAME
            End Get
            Set(value As String)
                _RONAME = value
            End Set
        End Property

        Private _SOURCE As String
        Public Property SOURCE() As String
            Get
                Return _SOURCE
            End Get
            Set(value As String)
                _SOURCE = value
            End Set
        End Property

        Private _MSGLINE1 As String
        Public Property MSGLINE1() As String
            Get
                Return _MSGLINE1
            End Get
            Set(value As String)
                _MSGLINE1 = value
            End Set
        End Property

        Private _MSGLINE2 As String
        Public Property MSGLINE2() As String
            Get
                Return _MSGLINE2
            End Get
            Set(value As String)
                _MSGLINE2 = value
            End Set
        End Property

        Private _MSGLINE3 As String
        Public Property MSGLINE3() As String
            Get
                Return _MSGLINE3
            End Get
            Set(value As String)
                _MSGLINE3 = value
            End Set
        End Property



        Private _TERMINAL_ID As String
        Public Property TERMINAL_ID() As String
            Get
                Return _TERMINAL_ID
            End Get
            Set(value As String)
                _TERMINAL_ID = value
            End Set
        End Property
        Private _TERMINAL_TID As String
        Public Property TERMINAL_TID() As String
            Get
                Return _TERMINAL_TID
            End Get
            Set(value As String)
                _TERMINAL_TID = value
            End Set
        End Property

        Private _TERMINAL_DESCRIPTION As String
        Public Property TERMINAL_DESCRIPTION() As String
            Get
                Return _TERMINAL_DESCRIPTION
            End Get
            Set(value As String)
                _TERMINAL_DESCRIPTION = value
            End Set
        End Property

        Private _TERMINAL_TTAXID As String
        Public Property TERMINAL_TTAXID() As String
            Get
                Return _TERMINAL_TTAXID
            End Get
            Set(value As String)
                _TERMINAL_TTAXID = value
            End Set
        End Property


        Private _BRNID As String
        Public Property BRNID() As String
            Get
                Return _BRNID
            End Get
            Set(value As String)
                _BRNID = value
            End Set
        End Property

        Private _BRNNAMETHAI As String
        Public Property BRNNAMETHAI() As String
            Get
                Return _BRNNAMETHAI
            End Get
            Set(value As String)
                _BRNNAMETHAI = value
            End Set
        End Property

        Private _BRNNAMEENG As String
        Public Property BRNNAMEENG() As String
            Get
                Return _BRNNAMEENG
            End Get
            Set(value As String)
                _BRNNAMEENG = value
            End Set
        End Property
        Private _BRNTAXID As String
        Public Property BRNTAXID() As String
            Get
                Return _BRNTAXID
            End Get
            Set(value As String)
                _BRNTAXID = value
            End Set
        End Property

        Private _BRNVAT As Double
        Public Property BRNVAT() As Double
            Get
                Return _BRNVAT
            End Get
            Set(value As Double)
                _BRNVAT = value
            End Set
        End Property


        Private _COMPNAME As String
        Public Property COMPNAME() As String
            Get
                Return _COMPNAME
            End Get
            Set(value As String)
                _COMPNAME = value
            End Set
        End Property

        Private _BRNCODE As String
        Public Property BRNCODE() As String
            Get
                Return _BRNCODE
            End Get
            Set(value As String)
                _BRNCODE = value
            End Set
        End Property

        Private _EDC_IP As String
        Public Property EDC_IP() As String
            Get
                Return _EDC_IP
            End Get
            Set(value As String)
                _EDC_IP = value
            End Set
        End Property
        Private _STCODE As String
        Public Property STCODE() As String
            Get
                Return _STCODE
            End Get
            Set(value As String)
                _STCODE = value
            End Set
        End Property


        Private _Merchant_ID As String
        Public Property Merchant_ID() As String
            Get
                Return _Merchant_ID
            End Get
            Set(value As String)
                _Merchant_ID = value
            End Set
        End Property
        Private _Profit_N As String
        Public Property Profit_N() As String
            Get
                Return _Profit_N
            End Get
            Set(value As String)
                _Profit_N = value
            End Set
        End Property

    End Class
End Namespace