Imports MD
Public Class Mas_Stock_Models

    Public Class value_List
        Public Respon As New ResponseModels
        Public Data As List(Of Stock_List)
    End Class
    Public Class value_data
        Public Respon As New ResponseModels
        Public Data As List(Of Stock)
    End Class

    Public Class Stock_List



        Public Property ID As String

        Public Property STCODE As String

        Public Property STNAME As String
        Public Property MDATE As DateTime

        Public Property ACTIVEFLAG As String




    End Class
    Public Class Stock

        Private _ID As Integer
        Public Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(value As Integer)
                _ID = value
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

        Private _STNAME As String
        Public Property STNAME() As String
            Get
                Return _STNAME
            End Get
            Set(value As String)
                _STNAME = value
            End Set
        End Property

        Private _DESCRIPTION As String
        Public Property DESCRIPTION() As String
            Get
                Return _DESCRIPTION
            End Get
            Set(value As String)
                _DESCRIPTION = value
            End Set
        End Property

        Private _REMARK As String
        Public Property REMARK() As String
            Get
                Return _REMARK
            End Get
            Set(value As String)
                _REMARK = value
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

        Private _CDATE As DateTime
        Public Property [CDATE]() As DateTime
            Get
                Return _CDATE
            End Get
            Set(value As DateTime)
                _CDATE = value
            End Set
        End Property

        Private _CUSE As String
        Public Property CUSE() As String
            Get
                Return _CUSE
            End Get
            Set(value As String)
                _CUSE = value
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

        Private _MUSE As String
        Public Property MUSE() As String
            Get
                Return _MUSE
            End Get
            Set(value As String)
                _MUSE = value
            End Set
        End Property

        Private _ISTAT As String
        Public Property ISTAT() As String
            Get
                Return _ISTAT
            End Get
            Set(value As String)
                _ISTAT = value
            End Set
        End Property

    End Class
End Class
