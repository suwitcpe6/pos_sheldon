Imports MD
Public Class MAS_Menu_Permis_Models
    Public Class value_menu
        Public Respon As New ResponseModels
        Public Data As List(Of Data_Menu)
    End Class
    Public Class value_List
        Public Respon As New ResponseModels
        Public Data As List(Of Data_List)
    End Class
    Public Class value_List_CBO
        Public Respon As New ResponseModels
        Public Data As List(Of Data_List_CBO)
    End Class
    Public Class value_SAVE
        Public Respon As New ResponseModels
        Public Data As New Data_SAVE

    End Class
    Public Class Data_SAVE
        Public Data_H As New Data_PER_MIS
        Public Data_ITEMS As New List(Of Data_PER_MIS_D)

    End Class
    Public Class Data_Menu

        Public Property ID As Integer
        Public Property MNU_CODE As String
        Public Property MNU_HSEQ As Integer
        Public Property MNU_HNAME_1 As String
        Public Property MNU_HNAME_2 As String
        Public Property MNU_SSEQ As Integer
        Public Property MNU_SNAME_1 As String
        Public Property MNU_SNAME_2 As String
        Public Property MNU_TAG As String
        Public Property MNU_OBJ1 As String
        Public Property MNU_OBJ2 As String
        Public Property MNU_ICO As String
        Public Property MNU_DEFAULT_DOCTYPE As String
        Public Property U_DATE As DateTime
        Public Property U_ID As String
        Public Property ISTAT As String

    End Class
    Public Class Data_List_CBO

        Public Property TR_ID As String
        Public Property PERMIS_CODE As String
        Public Property PERMIS_NAME As String


    End Class
    Public Class Data_List

        Public Property TR_ID As String
        Public Property PERMIS_CODE As String
        Public Property PERMIS_NAME As String
        Public Property UID As String
        Public Property ACTIVEFLAG As String
        Public Property MDATE As DateTime
        Public Property MUSE As String


    End Class
    Public Class Data_PER_MIS
        Public Property ID As Integer
        Public Property TR_ID As String
        Public Property PERMIS_CODE As String
        Public Property PERMIS_NAME As String
        Public Property UID As String
        Public Property DESCRIPTION As String
        Public Property REMARK As String
        Public Property ACTIVEFLAG As String
        Public Property [CDATE] As DateTime
        Public Property CUSE As String
        Public Property MDATE As DateTime
        Public Property MUSE As String
        Public Property ISTAT As String


    End Class
    Public Class Data_PER_MIS_D
        Public Property TR_ID As String
        Public Property PERMIS_CODE As String
        Public Property SEQ As Integer
        Public Property MNU_CODE As String
        Public Property MNU_HNAME_1 As String
        Public Property MNU_SNAME_1 As String
        Public Property M_AT As Boolean
        Public Property BTN_ADD As Boolean
        Public Property BTN_EDIT As Boolean
        Public Property BTN_VIEW As Boolean
        Public Property BTN_DEL As Boolean
        Public Property REMARK As String

    End Class
End Class
