﻿Imports MD
Public Class Mas_Product_Group_Models
    Public Class value_List
        Public Respon As New ResponseModels
        Public Data As List(Of PRODUCT_Group_List)
    End Class
    Public Class value_data
        Public Respon As New ResponseModels
        Public Data As List(Of PRODUCT_Group)
    End Class
    Public Class PRODUCT_Group_List


        Private _ID As String
        Public Property ID() As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
            End Set
        End Property

        Private _PGCODE As String
        Public Property PGCODE() As String
            Get
                Return _PGCODE
            End Get
            Set(value As String)
                _PGCODE = value
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
        Private _MDATE As Date
        Public Property MDATE() As Date
            Get
                Return _MDATE
            End Get
            Set(value As Date)
                _MDATE = value
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



    End Class
    Public Class PRODUCT_Group

        Private _ID As Integer
        Public Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(value As Integer)
                _ID = value
            End Set
        End Property

        Private _TR_ID As String
        Public Property TR_ID() As String
            Get
                Return _TR_ID
            End Get
            Set(value As String)
                _TR_ID = value
            End Set
        End Property

        Private _PGCODE As String
        Public Property PGCODE() As String
            Get
                Return _PGCODE
            End Get
            Set(value As String)
                _PGCODE = value
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
