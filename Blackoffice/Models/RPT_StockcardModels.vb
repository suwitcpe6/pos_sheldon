Imports MD
Public Class RPT_StockcardModels



    Public Class value
        Public Respon As New ResponseModels
        Public Data As List(Of Stockcard_data)
    End Class

    Public Class Stockcard_data
        Private _SEQ As Integer
        Public Property SEQ() As Integer
            Get
                Return _SEQ
            End Get
            Set(value As Integer)
                _SEQ = value
            End Set
        End Property

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
        Public Property MOV_TYPE As String
        Public Property STCODE As String
        Public Property STNAME As String
        Public Property PERCODE As String
        Public Property PERNAME As String
        Public Property PCODE As String
        Public Property PNAME As String
        Public Property BEG_ST_QTY As Integer
        Public Property ST_QTY As Integer
        Public Property IDC As Integer

        Private _QTY_IN As Integer
        Public Property QTY_IN() As Integer
            Get
                Return _QTY_IN
            End Get
            Set(value As Integer)
                _QTY_IN = value
            End Set
        End Property
        Private _QTY_OUT As Integer
        Public Property QTY_OUT() As Integer
            Get
                Return _QTY_OUT
            End Get
            Set(value As Integer)
                _QTY_OUT = value
            End Set
        End Property

        Private _QTY_remain As Integer
        Public Property QTY_remain() As Integer
            Get
                Return _QTY_remain
            End Get
            Set(value As Integer)
                _QTY_remain = value
            End Set
        End Property

        Public Property ST_UNITCODE As String
        Public Property ST_UNITNAME As String
    End Class

    Public Class Fillter_Stockcard


        Public Property Date_Start As String = ""
        Public Property Date_End As String = ""
        Public Property STCODE As String = ""
        Public Property PCODE1 As String = ""
        Public Property PCODE2 As Object = ""

    End Class
End Class
