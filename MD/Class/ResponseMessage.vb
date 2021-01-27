Public Class ResponseMessage
    'Public Result As Boolean
    'Public ErrorMessage As String
    'Public SystemErrorMessage As String
    Public Respon As New ResponseModels
    Public Data As Object

End Class
Public Class ResponseModels



    'Public Data As List(Of SHOP_ModelS)

    'Public Data(Of T) As T

    Private _Result As Boolean
    Public Property Result() As Boolean
        Get
            Return _Result
        End Get
        Set(value As Boolean)
            _Result = value
        End Set
    End Property
    Private _Result_value As String
    Public Property Result_value() As String
        Get
            Return _Result_value
        End Get
        Set(value As String)
            _Result_value = value
        End Set
    End Property
    Private _Result_value2 As String
    Public Property Result_value2() As String
        Get
            Return _Result_value2
        End Get
        Set(value As String)
            _Result_value2 = value
        End Set
    End Property
    Private _Result_value3 As String
    Public Property Result_value3() As String
        Get
            Return _Result_value3
        End Get
        Set(value As String)
            _Result_value3 = value
        End Set
    End Property

    Private _ErrorMessage As String
    Public Property ErrorMessage() As String
        Get
            Return _ErrorMessage
        End Get
        Set(value As String)
            _ErrorMessage = value
        End Set
    End Property
    Private _SystemErrorMessage As String
    Public Property SystemErrorMessage() As String
        Get
            Return _SystemErrorMessage
        End Get
        Set(value As String)
            _SystemErrorMessage = value
        End Set
    End Property
    Private _Data As String
    Public Property Data() As String
        Get
            Return _Data
        End Get
        Set(value As String)

            _Data = value
        End Set
    End Property
    'Private _Data As List(Of SHOP_ModelS)
    'Public Property Data() As List(Of SHOP_ModelS)
    '    Get
    '        Return _Data
    '    End Get
    '    Set(value As List(Of SHOP_ModelS))

    '        _Data = value
    '    End Set
    'End Property













End Class
