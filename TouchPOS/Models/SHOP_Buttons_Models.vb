Imports MD
Namespace SHOP_Buttons_Model
    Public Class value_button

        Public Respon As New ResponseModels
        Public Data As New value
    End Class
    Public Class value

        Public Shopbuttons As New List(Of ShopbuttonsModels)
        'Public happyhour As New List(Of happyhourModels)


    End Class
    Public Class ShopbuttonsModels

        Private _SHOPID As Integer
        Public Property SHOPID() As Integer
            Get
                Return _SHOPID
            End Get
            Set(value As Integer)
                _SHOPID = value
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

        Private _BTNID As String
        Public Property BTNID() As String
            Get
                Return _BTNID
            End Get
            Set(value As String)
                _BTNID = value
            End Set
        End Property

        Private _BTNGROUP As String
        Public Property BTNGROUP() As String
            Get
                Return _BTNGROUP
            End Get
            Set(value As String)
                _BTNGROUP = value
            End Set
        End Property

        Private _BTNNAME As String
        Public Property BTNNAME() As String
            Get
                Return _BTNNAME
            End Get
            Set(value As String)
                _BTNNAME = value
            End Set
        End Property

        Private _BTNPRICE As Short
        Public Property BTNPRICE() As Short
            Get
                Return _BTNPRICE
            End Get
            Set(value As Short)
                _BTNPRICE = value
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

        Private _BTNGP As Double
        Public Property BTNGP() As Double
            Get
                Return _BTNGP
            End Get
            Set(value As Double)
                _BTNGP = value
            End Set
        End Property

        Private _BTNGPRULE As String
        Public Property BTNGPRULE() As String
            Get
                Return _BTNGPRULE
            End Get
            Set(value As String)
                _BTNGPRULE = value
            End Set
        End Property

        Private _BTNPRICE2 As Short
        Public Property BTNPRICE2() As Short
            Get
                Return _BTNPRICE2
            End Get
            Set(value As Short)
                _BTNPRICE2 = value
            End Set
        End Property

        Private _BTNGP2 As Double
        Public Property BTNGP2() As Double
            Get
                Return _BTNGP2
            End Get
            Set(value As Double)
                _BTNGP2 = value
            End Set
        End Property

        Private _BTNGPRULE2 As String
        Public Property BTNGPRULE2() As String
            Get
                Return _BTNGPRULE2
            End Get
            Set(value As String)
                _BTNGPRULE2 = value
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

        Private _STOCKID As String
        Public Property STOCKID() As String
            Get
                Return _STOCKID
            End Get
            Set(value As String)
                _STOCKID = value
            End Set
        End Property

        Private _promotion As String
        Public Property promotion() As String
            Get
                Return _promotion
            End Get
            Set(value As String)
                _promotion = value
            End Set
        End Property

        Private _proid As String
        Public Property proid() As String
            Get
                Return _proid
            End Get
            Set(value As String)
                _proid = value
            End Set
        End Property






        Public Property happyhour_id As Integer
        Public Property happyhour_desc As String
        Public Property datestart As DateTime
        Public Property dateend As DateTime
        Public Property timestart_ As DateTime
        Public Property timestart() As DateTime
            Get
                Return timestart_
            End Get
            Set(value As DateTime)
                timestart_ = value.ToString("HH:mm")
            End Set
        End Property
        Public Property timeend_ As DateTime
        Public Property timeend() As DateTime
            Get
                Return timeend_
            End Get
            Set(value As DateTime)
                timeend_ = value.ToString("HH:mm")
            End Set
        End Property
        Public Property btnflg As String
        Public Property PCODE As String = ""
        Public Property PNAME As String = ""
        Public Property UNITCODE As String = ""
        Public Property UNITNAME As String = ""





    End Class









    'Public Class happyhourModels
    '    Public Property happyhour_id As Integer
    '    Public Property happyhour_desc As String
    '    Public Property datestart As DateTime
    '    Public Property dateend As DateTime
    '    Public Property timestart_ As DateTime
    '    Public Property timestart() As DateTime
    '        Get
    '            Return timestart_
    '        End Get
    '        Set(value As DateTime)
    '            timestart_ = value.ToString("hh:mm")
    '        End Set
    '    End Property
    '    Public Property timeend_ As DateTime
    '    Public Property timeend() As DateTime
    '        Get
    '            Return timeend_
    '        End Get
    '        Set(value As DateTime)
    '            timeend_ = value.ToString("hh:mm")
    '        End Set
    '    End Property
    '    Public Property shopid As String
    '    Public Property btnid As String
    '    Public Property btnflg As String
    'End Class
End Namespace
