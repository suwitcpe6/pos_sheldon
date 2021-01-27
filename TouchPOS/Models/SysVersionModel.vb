Imports MD
Public Class SysVersionModel
    Public Class value
        Public Respon As New ResponseModels
        Public Data As List(Of Sel_SysVersion)

    End Class
    Public Class Sel_SysVersion

        Private _path As String
        Public Property path() As String
            Get
                Return _path
            End Get
            Set(value As String)
                _path = value
            End Set
        End Property


    End Class
End Class
