
Imports MD
Namespace SALE_Models
    ''' <summary>
    ''' insert
    ''' </summary>
    ''' 
    Public Class SALE_INT
        'Public Nettotel As Int32
        Public Property CorpBRNID As String
        Public Multicard As Boolean

        Public Property MRTSLIPNO As String
        Public Property SHOPID As Integer
        Public Property POSID As String

        Public Property DOCDATE As DateTime
        Public Property DOCYEAR As Integer
        Public Property DOCMONT As Integer




        Public Property TAXINVOICE As String
        Public Property CREDITNOTES As String
        Public Property CARDTENDOR As String
        Public Property CARDREF As String
        Public Property CARDPURSE As Decimal
        Public Property taxPrint As String
        Public Property CUS_ID As String
        Public Property PAYTYPE As String
        Public Property PAYAMOUNT As Decimal
        Public Property AMOUNT As Decimal
        Public Property DISTP As String
        Public Property DISVALUE As Decimal
        Public Property AFTERDIS As Decimal
        Public Property VATTP As String
        Public Property VATVALUE As Decimal
        Public Property AFTERVAT As Decimal
        Public Property NETAMOUNT As Decimal
        Public Property QTY_TOTAL As Integer
        Public Property CBY As String
        Public Property MBY As String
        Public Property DC_STATE As String
        Public Property Remark1 As String
        Public Property Remark2 As String
        Public Property Remark3 As String
        Public Property merchant_id As String
        Public Property VALUE_CONVERT As Decimal
        Public Property STCODE As String




        Public Saleitems As New List(Of SALE_ITEMS)
        Public Saleitems_card As New List(Of Saleitems_card)
        Public Cardtran As New List(Of Cardtran)
        'Public Items_MultiCard As New List(Of MultiCards)
    End Class


    Public Class value
        'Public Result As Boolean
        'Public ErrorMessage As String
        'Public SystemErrorMessage As String
        Public Respon As New ResponseModels
        Public Data As List(Of Cardtran)

    End Class
    Public Class value_Repay

        Public Respon As New ResponseModels
        Public Data As List(Of RepayModel)

    End Class
    Public Class SALE_ITEMS

        Private _SEQ As Integer
        Public Property SEQ() As Integer
            Get
                Return _SEQ
            End Get
            Set(value As Integer)
                _SEQ = value
            End Set
        End Property


        Private _FOODID As Integer
        Public Property FOODID() As Integer
            Get
                Return _FOODID
            End Get
            Set(value As Integer)
                _FOODID = value
            End Set
        End Property

        Private _FOODNAME As String
        Public Property FOODNAME() As String
            Get
                Return _FOODNAME
            End Get
            Set(value As String)
                _FOODNAME = value
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

        Private _GP As Double
        Public Property GP() As Double
            Get
                Return _GP
            End Get
            Set(value As Double)
                _GP = value
            End Set
        End Property

        Private _GPRULET As String
        Public Property GPRULE() As String
            Get
                Return _GPRULET
            End Get
            Set(value As String)
                _GPRULET = value
            End Set
        End Property
        Private _GPAMOUNT As Double
        Public Property GPAMOUNT() As Double
            Get
                Return _GPAMOUNT
            End Get
            Set(value As Double)
                _GPAMOUNT = value
            End Set
        End Property

        Private _ITEMS_PRICE As Decimal
        Public Property ITEMS_PRICE() As Decimal
            Get
                Return _ITEMS_PRICE
            End Get
            Set(value As Decimal)
                _ITEMS_PRICE = value
            End Set
        End Property

        Private _DISTP As String
        Public Property DISTP() As String
            Get
                Return _DISTP
            End Get
            Set(value As String)
                _DISTP = value
            End Set
        End Property

        Private _DISVALUE As Decimal
        Public Property DISVALUE() As Decimal
            Get
                Return _DISVALUE
            End Get
            Set(value As Decimal)
                _DISVALUE = value
            End Set
        End Property

        Private _AFTERDIS As Decimal
        Public Property AFTERDIS() As Decimal
            Get
                Return _AFTERDIS
            End Get
            Set(value As Decimal)
                _AFTERDIS = value
            End Set
        End Property

        Private _VATTP As String
        Public Property VATTP() As String
            Get
                Return _VATTP
            End Get
            Set(value As String)
                _VATTP = value
            End Set
        End Property

        Private _VATVALUE As Decimal
        Public Property VATVALUE() As Decimal
            Get
                Return _VATVALUE
            End Get
            Set(value As Decimal)
                _VATVALUE = value
            End Set
        End Property

        Private _AFTERVAT As Decimal
        Public Property AFTERVAT() As Decimal
            Get
                Return _AFTERVAT
            End Get
            Set(value As Decimal)
                _AFTERVAT = value
            End Set
        End Property

        Private _NETAMOUNT As Decimal
        Public Property NETAMOUNT() As Decimal
            Get
                Return _NETAMOUNT
            End Get
            Set(value As Decimal)
                _NETAMOUNT = value
            End Set
        End Property

        Private _QTY As Integer
        Public Property QTY() As Integer
            Get
                Return _QTY
            End Get
            Set(value As Integer)
                _QTY = value
            End Set
        End Property



        Private _PRO_ID As Integer
        Public Property PRO_ID() As Integer
            Get
                Return _PRO_ID
            End Get
            Set(value As Integer)
                _PRO_ID = value
            End Set
        End Property

        Private _PRO_NAME As String
        Public Property PRO_NAME() As String
            Get
                Return _PRO_NAME
            End Get
            Set(value As String)
                _PRO_NAME = value
            End Set
        End Property

        Private _PRO_TEXT As String
        Public Property PRO_TEXT() As String
            Get
                Return _PRO_TEXT
            End Get
            Set(value As String)
                _PRO_TEXT = value
            End Set
        End Property

    End Class
    Public Class Saleitems_card

        Private _SEQ As Integer
        Public Property SEQ() As Integer
            Get
                Return _SEQ
            End Get
            Set(value As Integer)
                _SEQ = value
            End Set
        End Property

        Private _BARCODE As String
        Public Property BARCODE() As String
            Get
                Return _BARCODE
            End Get
            Set(value As String)
                _BARCODE = value
            End Set
        End Property

        Private _PAYTYPE As String
        Public Property PAYTYPE() As String
            Get
                Return _PAYTYPE
            End Get
            Set(value As String)
                _PAYTYPE = value
            End Set
        End Property

        Private _CUSED As Integer
        Public Property CUSED() As Integer
            Get
                Return _CUSED
            End Get
            Set(value As Integer)
                _CUSED = value
            End Set
        End Property

        Private _CUSED1 As Integer
        Public Property CUSED1() As Integer
            Get
                Return _CUSED1
            End Get
            Set(value As Integer)
                _CUSED1 = value
            End Set
        End Property

        Private _MRTAMOUNT As Integer
        Public Property MRTAMOUNT() As Integer
            Get
                Return _MRTAMOUNT
            End Get
            Set(value As Integer)
                _MRTAMOUNT = value
            End Set
        End Property

        Private _CBALANCE As Integer
        Public Property CBALANCE() As Integer
            Get
                Return _CBALANCE
            End Get
            Set(value As Integer)
                _CBALANCE = value
            End Set
        End Property

        Private _CBALANCEREMAIN As Integer
        Public Property CBALANCEREMAIN() As Integer
            Get
                Return _CBALANCEREMAIN
            End Get
            Set(value As Integer)
                _CBALANCEREMAIN = value
            End Set
        End Property

        Private _GP As Decimal
        Public Property GP() As Decimal
            Get
                Return _GP
            End Get
            Set(value As Decimal)
                _GP = value
            End Set
        End Property

        Private _GPAMOUNT As Decimal
        Public Property GPAMOUNT() As Decimal
            Get
                Return _GPAMOUNT
            End Get
            Set(value As Decimal)
                _GPAMOUNT = value
            End Set
        End Property

        Private _PRO_ID As Integer
        Public Property PRO_ID() As Integer
            Get
                Return _PRO_ID
            End Get
            Set(value As Integer)
                _PRO_ID = value
            End Set
        End Property

        Private _PRO_NAME As String
        Public Property PRO_NAME() As String
            Get
                Return _PRO_NAME
            End Get
            Set(value As String)
                _PRO_NAME = value
            End Set
        End Property

        Private _PRO_TEXT As String
        Public Property PRO_TEXT() As String
            Get
                Return _PRO_TEXT
            End Get
            Set(value As String)
                _PRO_TEXT = value
            End Set
        End Property

    End Class

    Public Class Cardtran


        Private _CTID As Integer
        Public Property CTID() As Integer
            Get
                Return _CTID
            End Get
            Set(value As Integer)
                _CTID = value
            End Set
        End Property

        Private _CUSED As Integer
        Public Property CUSED() As Integer
            Get
                Return _CUSED
            End Get
            Set(value As Integer)
                _CUSED = value
            End Set
        End Property

        Private _BARCODE As String
        Public Property BARCODE() As String
            Get
                Return _BARCODE
            End Get
            Set(value As String)
                _BARCODE = value
            End Set
        End Property

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

        Private _MRTAMOUNT As Integer
        Public Property MRTAMOUNT() As Integer
            Get
                Return _MRTAMOUNT
            End Get
            Set(value As Integer)
                _MRTAMOUNT = value
            End Set
        End Property

        Private _MRTSTATUS As String
        Public Property MRTSTATUS() As String
            Get
                Return _MRTSTATUS
            End Get
            Set(value As String)
                _MRTSTATUS = value
            End Set
        End Property

        Private _MRTSLIPNO As String
        Public Property MRTSLIPNO() As String
            Get
                Return _MRTSLIPNO
            End Get
            Set(value As String)
                _MRTSLIPNO = value
            End Set
        End Property

        Private _MRTLUPDATE As DateTime
        Public Property MRTLUPDATE() As DateTime
            Get
                Return _MRTLUPDATE
            End Get
            Set(value As DateTime)
                _MRTLUPDATE = value
            End Set
        End Property

        Private _TID As String
        Public Property TID() As String
            Get
                Return _TID
            End Get
            Set(value As String)
                _TID = value
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

        Private _BACKUPFLG As Boolean
        Public Property BACKUPFLG() As Boolean
            Get
                Return _BACKUPFLG
            End Get
            Set(value As Boolean)
                _BACKUPFLG = value
            End Set
        End Property

        Private _CHKFLG As Boolean
        Public Property CHKFLG() As Boolean
            Get
                Return _CHKFLG
            End Get
            Set(value As Boolean)
                _CHKFLG = value
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

        Private _CUSED1 As Short
        Public Property CUSED1() As Short
            Get
                Return _CUSED1
            End Get
            Set(value As Short)
                _CUSED1 = value
            End Set
        End Property
        Private _FOODID As Integer
        Public Property FOODID() As Integer
            Get
                Return _FOODID
            End Get
            Set(value As Integer)
                _FOODID = value
            End Set
        End Property
        Private _FOODNAME As String
        Public Property FOODNAME() As String
            Get
                Return _FOODNAME
            End Get
            Set(value As String)
                _FOODNAME = value
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


        Private _SHOPENDFLG As Boolean
        Public Property SHOPENDFLG() As Boolean
            Get
                Return _SHOPENDFLG
            End Get
            Set(value As Boolean)
                _SHOPENDFLG = value
            End Set
        End Property

        Private _GP As Double
        Public Property GP() As Double
            Get
                Return _GP
            End Get
            Set(value As Double)
                _GP = value
            End Set
        End Property

        Private _GPAMOUNT As Double
        Public Property GPAMOUNT() As Double
            Get
                Return _GPAMOUNT
            End Get
            Set(value As Double)
                _GPAMOUNT = value
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

        Private _STOCKID As String
        Public Property STOCKID() As String
            Get
                Return _STOCKID
            End Get
            Set(value As String)
                _STOCKID = value
            End Set
        End Property

        Private _TAXINVOICE As String
        Public Property TAXINVOICE() As String
            Get
                Return _TAXINVOICE
            End Get
            Set(value As String)
                _TAXINVOICE = value
            End Set
        End Property

        Private _CREDITNOTES As String
        Public Property CREDITNOTES() As String
            Get
                Return _CREDITNOTES
            End Get
            Set(value As String)
                _CREDITNOTES = value
            End Set
        End Property

        Private _CARDTENDOR As String
        Public Property CARDTENDOR() As String
            Get
                Return _CARDTENDOR
            End Get
            Set(value As String)
                _CARDTENDOR = value
            End Set
        End Property

        Private _CARDREF As String
        Public Property CARDREF() As String
            Get
                Return _CARDREF
            End Get
            Set(value As String)
                _CARDREF = value
            End Set
        End Property

        Private _CARDPURSE As Decimal
        Public Property CARDPURSE() As Decimal
            Get
                Return _CARDPURSE
            End Get
            Set(value As Decimal)
                _CARDPURSE = value
            End Set
        End Property

        Private _taxPrint As String
        Public Property taxPrint() As String
            Get
                Return _taxPrint
            End Get
            Set(value As String)
                _taxPrint = value
            End Set
        End Property

        'Private _status As String
        'Public Property status() As String
        '    Get
        '        Return _status
        '    End Get
        '    Set(value As String)
        '        _status = value
        '    End Set
        'End Property
        'Private _Qty As Integer
        'Public Property Qty() As Integer
        '    Get
        '        Return _Qty
        '    End Get
        '    Set(value As Integer)
        '        _Qty = value
        '    End Set
        'End Property
        Private _SEQ As Integer
        Public Property SEQ() As Integer
            Get
                Return _SEQ
            End Get
            Set(value As Integer)
                _SEQ = value
            End Set
        End Property
        Private _ITEMS_PRICE As Integer
        Public Property ITEMS_PRICE() As Integer
            Get
                Return _ITEMS_PRICE
            End Get
            Set(value As Integer)
                _ITEMS_PRICE = value
            End Set
        End Property
        Private _QTY As Integer
        Public Property QTY() As Integer
            Get
                Return _QTY
            End Get
            Set(value As Integer)
                _QTY = value
            End Set
        End Property



    End Class
    'Public Class MultiCards

    '    Private _SHOPID As String
    '    Public Property SHOPID() As String
    '        Get
    '            Return _SHOPID
    '        End Get
    '        Set(value As String)
    '            _SHOPID = value
    '        End Set
    '    End Property

    '    Private _POSID As String
    '    Public Property POSID() As String
    '        Get
    '            Return _POSID
    '        End Get
    '        Set(value As String)
    '            _POSID = value
    '        End Set
    '    End Property

    '    Private _BARCODE As String
    '    Public Property BARCODE() As String
    '        Get
    '            Return _BARCODE
    '        End Get
    '        Set(value As String)
    '            _BARCODE = value
    '        End Set
    '    End Property

    '    Private _CUSED As Integer
    '    Public Property CUSED() As Integer
    '        Get
    '            Return _CUSED
    '        End Get
    '        Set(value As Integer)
    '            _CUSED = value
    '        End Set
    '    End Property

    '    Private _CUSED1 As Integer
    '    Public Property CUSED1() As Integer
    '        Get
    '            Return _CUSED1
    '        End Get
    '        Set(value As Integer)
    '            _CUSED1 = value
    '        End Set
    '    End Property

    '    Private _MRTAMOUNT As Integer
    '    Public Property MRTAMOUNT() As Integer
    '        Get
    '            Return _MRTAMOUNT
    '        End Get
    '        Set(value As Integer)
    '            _MRTAMOUNT = value
    '        End Set
    '    End Property

    '    Private _STATUS As Boolean
    '    Public Property STATUS() As Boolean
    '        Get
    '            Return _STATUS
    '        End Get
    '        Set(value As Boolean)
    '            _STATUS = value
    '        End Set
    '    End Property
    '    Private _CBALANCE As Integer
    '    Public Property CBALANCE() As Integer
    '        Get
    '            Return _CBALANCE
    '        End Get
    '        Set(value As Integer)
    '            _CBALANCE = value
    '        End Set
    '    End Property
    'End Class





#Region "print_slip"
    ''' <summary>
    ''' print_slip
    ''' </summary>
    ''' 
    Public Class print_slip
        Public Respon As New ResponseModels
        Public Data As List(Of slipModel)

    End Class
    Public Class slipModel

        Private _BARCODE As String
        Public Property BARCODE() As String
            Get
                Return _BARCODE
            End Get
            Set(value As String)
                _BARCODE = value
            End Set
        End Property

        Private _MRTAMOUNT As Decimal
        Public Property MRTAMOUNT() As Decimal
            Get
                Return _MRTAMOUNT
            End Get
            Set(value As Decimal)
                _MRTAMOUNT = value
            End Set
        End Property

        Public _MRTSLIPNO As String
        Public Property MRTSLIPNO() As String
            Get
                Return _MRTSLIPNO
            End Get
            Set(value As String)
                _MRTSLIPNO = value
            End Set
        End Property
        Public _FOODNAME As String
        Public Property FOODNAME() As String
            Get
                Return _FOODNAME
            End Get
            Set(value As String)
                _FOODNAME = value
            End Set
        End Property
        Public _LUPDATE As DateTime
        Public Property LUPDATE() As DateTime
            Get
                Return _LUPDATE
            End Get
            Set(value As DateTime)
                _LUPDATE = value
            End Set
        End Property
        Public _CEXPIRED As DateTime
        Public Property CEXPIRED() As DateTime
            Get
                Return _CEXPIRED
            End Get
            Set(value As DateTime)
                _CEXPIRED = value
            End Set
        End Property
        Public _CBALANCE As String
        Public Property CBALANCE() As String
            Get
                Return _CBALANCE
            End Get
            Set(value As String)
                _CBALANCE = value
            End Set
        End Property
        Public _SEQ As Integer
        Public Property SEQ() As Integer
            Get
                Return _SEQ
            End Get
            Set(value As Integer)
                _SEQ = value
            End Set
        End Property
        Public _QTY As Integer
        Public Property QTY() As Integer
            Get
                Return _QTY
            End Get
            Set(value As Integer)
                _QTY = value
            End Set
        End Property
        Public _ITEMS_PRICE As Integer
        Public Property ITEMS_PRICE() As Integer
            Get
                Return _ITEMS_PRICE
            End Get
            Set(value As Integer)
                _ITEMS_PRICE = value
            End Set
        End Property
        Public _OLD_BALANCE As Integer
        Public Property OLD_BALANCE() As Integer
            Get
                Return _OLD_BALANCE
            End Get
            Set(value As Integer)
                _OLD_BALANCE = value
            End Set
        End Property

        Public _CARDTENDOR As String
        Public Property CARDTENDOR() As String
            Get
                Return _CARDTENDOR
            End Get
            Set(value As String)
                _CARDTENDOR = value
            End Set
        End Property
        Private _CARDREF As String
        Public Property CARDREF() As String
            Get
                Return _CARDREF
            End Get
            Set(value As String)
                _CARDREF = value
            End Set
        End Property
        Private _CARDREF_CN As String
        Public Property CARDREF_CN() As String
            Get
                Return _CARDREF_CN
            End Get
            Set(value As String)
                _CARDREF_CN = value
            End Set
        End Property


        Private _TAXINVOICE As String
        Public Property TAXINVOICE() As String
            Get
                Return _TAXINVOICE
            End Get
            Set(value As String)
                _TAXINVOICE = value
            End Set
        End Property

        Private _CREDITNOTES As String
        Public Property CREDITNOTES() As String
            Get
                Return _CREDITNOTES
            End Get
            Set(value As String)
                _CREDITNOTES = value
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
        Private _COMPNAME_remark As String
        Public Property COMPNAME_remark() As String
            Get
                Return _COMPNAME_remark
            End Get
            Set(value As String)
                _COMPNAME_remark = value
            End Set
        End Property
        Private _COMPBRNTAXID As String
        Public Property COMPBRNTAXID() As String
            Get
                Return _COMPBRNTAXID
            End Get
            Set(value As String)
                _COMPBRNTAXID = value
            End Set
        End Property


    End Class



#End Region

#Region "Sel_Rpt_dayend"
    ''' <summary>
    ''' dayend_Model
    ''' </summary>
    ''' 
    Public Class Sel_Rpt_dayend
        Public Respon As New ResponseModels
        Public Data As List(Of dayend_Model)

    End Class
    Public Class dayend_Model

        Private _CARDTENDOR As String
        Public Property CARDTENDOR() As String
            Get
                Return _CARDTENDOR
            End Get
            Set(value As String)
                _CARDTENDOR = value
            End Set
        End Property
        Private _MRTAMOUNT As Decimal
        Public Property MRTAMOUNT() As Decimal
            Get
                Return _MRTAMOUNT
            End Get
            Set(value As Decimal)
                _MRTAMOUNT = value
            End Set
        End Property

        Private _TOTALCARD As Decimal
        Public Property TOTALCARD() As Decimal
            Get
                Return _TOTALCARD
            End Get
            Set(value As Decimal)
                _TOTALCARD = value
            End Set
        End Property

        Private _TOTALCARD_QTY As Decimal
        Public Property TOTALCARD_QTY() As Decimal
            Get
                Return _TOTALCARD_QTY
            End Get
            Set(value As Decimal)
                _TOTALCARD_QTY = value
            End Set
        End Property

    End Class


#End Region


    Partial Public Class RepayModel


        Public Property CUSED As Integer
        Public Property BARCODE As String
        Public Property SHOPID As Integer
        Public Property POSID As String
        Public Property MRTAMOUNT As Integer
        Public Property MRTSLIPNO As String
        Public Property MRTLUPDATE As DateTime
        Public Property FOODID As Integer
        Public Property FOODNAME As String
        Public Property GP As Double
        Public Property GPAMOUNT As Double
        Public Property GPRULE As String
        Public Property CARDTENDOR As String
        Public Property CARDTENDOR_Name As String
        Public Property CARDPURSE As Double
        Public Property SEQ As Integer
        Public Property ITEMS_PRICE As Double
        Public Property QTY As Integer

    End Class
End Namespace

