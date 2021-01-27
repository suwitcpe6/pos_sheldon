Imports MD
Public Class Data_Config_Model

    Public Class value
        Public Respon As New ResponseModels
        Public Data As Data_Config

    End Class
    Public Class Data_Config

        Public SysVersion As SysVersion = New SysVersion
        Public SysConfig As SysConfig = New SysConfig
    End Class

    Public Class SysVersion

        Public sysNo As String
        Public sysName As String
        Public path As String

    End Class

    Public Class SysConfig

        Public Property ITEMSNO As String
        Public Property CUSGROUP As String
        Public Property VENDOR_GETWAY As String
        Public Property CONN_LINK As String
        Public Property WALLET_TYPE As String

        Public Property USESTOCK As Boolean
        Public Property POSTYPE As String

    End Class
End Class
