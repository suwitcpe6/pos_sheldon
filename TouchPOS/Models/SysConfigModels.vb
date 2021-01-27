

Imports MD
Public Class SysConfig
    Public Class value
        Public Respon As New ResponseModels
        Public Data As List(Of SysConfigModels)

    End Class
    Public Class SysConfigModels
        Public Property ITEMSNO As String = ""
        Public Property CUSGROUP As String = ""
        Public Property VENDOR_GETWAY As String = ""
        Public Property CONN_LINK As String = ""

        Public Property WALLET_TYPE As String = ""
        Public Property USESTOCK As String = ""
        Public Property POSTYPE As String = ""
    End Class
End Class
