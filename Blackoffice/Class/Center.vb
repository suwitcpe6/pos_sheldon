Imports Control_us
Imports Newtonsoft.Json
Imports WeifenLuo.WinFormsUI
Public Class Center
    Public Shared version As String = System.Configuration.ConfigurationManager.AppSettings("Version").ToString
    Public Shared dt_menu As New DataTable
    Public Shared icon As Icon
    'Public Shared f_main As F_Main
    Public Shared DockPanel As DockPanel

    Public Const Auto_Search_Interval As Int16 = 500
    Public Const Limit_Search As Int16 = 200

    Public Shared Default_Path_RPT As String = Application.StartupPath & "\Report\RDLC\"
    'Public Shared Default_Path_RPT As String = "D:\SOR\POS_new\TouchPOS\Blackoffice\Report\RDLC\"


    Public Shared date_now As DateTime
    Public Shared data_profile As New data_profile
    Public Shared Data_Config As New data_config
    Public Shared DATEWORKING As Date
    'Public Shared Link_API As New Link_API_MOdel





#Region "Link Api"

    'Public Class Link_API_Model
    '    Public Get_API As New Get_API
    '    Public Post_API As New Post_API
    'End Class
    Public Class Get_API
        Public Const Test_Connect = "api/User/Test_connect?Val="
        Public Const SEL_SysVersion = "api/System_POS/SEL_SysVersion?val1="
        Public Const UpdateStructure = "api/UpdateStructure/Update"
        Public Const API_Version = "api/System_POS/API_Version"
        Public Const Select_Config = "api/System_POS/Select_Config?Val={0}"
        Public Const DownloadFiles = "api/FileAPI/DownloadFiles?fileName={0}"
        Public Const Checkfile_update = "api/FileAPI/Checkfile_update?fileName={0}"

        Public Const COMPANYPROFILE_Select As String = "api/Master/COMPANYPROFILE_Select"

        Public Const MAS_DOC_STATUS_Select As String = "api/Master/MAS_DOC_STATUS_Select?DOS_GROUP={0}&UI_STATE={1}"
        Public Const MAS_DOCTYPE_Select As String = "api/Master/MAS_DOCTYPE_Select?VAL={0}"
        Public Const USERPROFILE_Select As String = "api/Master/USERPROFILE_Select?UID={0}"


        Public Const MAS_Select_Menu As String = "api/Master/MAS_Select_Menu?val={0}"
        Public Const MAS_PRODUCT_Unit_List As String = "api/Master/MAS_PRODUCT_Unit_List?CODE={0}&NAME={1}"
        Public Const MAS_PRODUCT_Unit_List_CBO As String = "api/Master/MAS_PRODUCT_Unit_List_CBO?val={0}"
        Public Const MAS_PRODUCT_UNIT_Select As String = "api/Master/MAS_PRODUCT_UNIT_Select?ID={0}"

        Public Const MAS_PRODUCT_Group_List As String = "api/Master/MAS_PRODUCT_Group_List?CODE={0}&NAME={1}"
        Public Const MAS_PRODUCT_Group_List_CBO As String = "api/Master/MAS_PRODUCT_Group_List_CBO?val={0}"
        Public Const MAS_PRODUCT_Group_Select As String = "api/Master/MAS_PRODUCT_Group_Select?ID={0}"



        Public Const MAS_PRODUCT_List As String = "api/Master/MAS_PRODUCT_List?PCODE={0}&PNAME={1}&PGNAME={2}&PTNAME={3}&Limit={4}"
        Public Const MAS_PRODUCT_Select As String = "api/Master/MAS_PRODUCT_Select?ID={0}"

        Public Const PRODUCT_TYPE_List As String = "api/Master/PRODUCT_TYPE_List?PTCODE={0}&PTNAME={1}&Limit={2}"
        Public Const MAS_PRODUCT_Type_List_CBO As String = "api/Master/MAS_PRODUCT_Type_List_CBO?val={0}"
        Public Const PRODUCT_TYPE_Select As String = "api/Master/PRODUCT_TYPE_Select?ID={0}"

        Public Const MAS_STOCK_List_CBO As String = "api/Master/MAS_STOCK_List_CBO?val={0}"
        Public Const MAS_STOCK_List As String = "api/Master/MAS_STOCK_List?CODE={0}&NAME={1}"
        Public Const MAS_STOCK_Select As String = "api/Master/MAS_STOCK_Select?ID={0}"

        Public Const REASON_List As String = "api/Master/REASON_List?RSCODE={0}&RSNAME={1}&Limit={2}"
        Public Const REASON_List_CBO As String = "api/Master/REASON_List_CBO?val={0}"
        Public Const REASON_Select As String = "api/Master/REASON_Select?ID={0}"

        Public Const Load_Menus_permis As String = "api/Master/Load_Menus_permis?UID={0}"
        Public Const MAS_Load_Menus As String = "api/Master/MAS_Load_Menus?val={0}"
        Public Const MAS_Permis_List_Data As String = "api/Master/MAS_Permis_List_Data?CODE={0}&NAME={1}&UID={2}&Limit={3}"
        Public Const MAS_Permis_Select_Data As String = "api/Master/Permis_Select_Data?TR_ID={0}"


        Public Const Search_MAS As String = "api/Master/Search_MAS?SCR_TYPE={0}&fixvalue={1}&CODE={2}&NAME={3}"

        Public Const TR_MOV_List_Data As String = "api/TR/TR_MOV_List_Data?DOCTYPE={0}&DOCNO={1}&DOCDATE={2}&PERNAME={3}&STNAME={4}&Limit={5}"
        Public Const TR_MOV_Select_Data As String = "api/TR/TR_MOV_Select_Data?TR_ID={0}"

        Public Const Load_Data_YearEnd As String = "api/TR/Load_Data_YearEnd?YEAR={0}"



    End Class
    Public Class Post_API

        Public Const MAS_Save_Config As String = "api/System_POS/Save_Config"


        Public Const Mas_Product_Unit_Save As String = "api/Master/Mas_Product_UNIT_Save?UI_STATE={0}"
        Public Const Mas_PRODUCT_UNIT_DELETE As String = "api/Master/Mas_PRODUCT_UNIT_DELETE?ID={0}"
        Public Const Mas_Product_Group_Save As String = "api/Master/Mas_Product_Group_Save?UI_STATE={0}"
        Public Const Mas_PRODUCT_Group_DELETE As String = "api/Master/Mas_PRODUCT_Group_DELETE?ID={0}"
        Public Const Mas_Product_Type_Save As String = "api/Master/Mas_Product_Type_Save?UI_STATE={0}"
        Public Const Mas_PRODUCT_TYPE_DELETE As String = "api/Master/Mas_PRODUCT_TYPE_DELETE?ID={0}"
        Public Const Mas_Product_Save As String = "api/Master/Mas_Product_Save?UI_STATE={0}"
        Public Const Mas_PRODUCT_DELETE As String = "api/Master/Mas_PRODUCT_DELETE?PCODE={0}"
        Public Const Mas_STOCK_Save As String = "api/Master/Mas_STOCK_Save?UI_STATE={0}"
        Public Const MAS_Stock_DELETE As String = "api/Master/MAS_Stock_DELETE?ID={0}"


        Public Const MAS_REASON_Save As String = "api/Master/MAS_REASON_Save?UI_STATE={0}"
        Public Const MAS_REASON_DELETE As String = "api/Master/MAS_REASON_DELETE?ID={0}"

        Public Const MAS_Permis_Save As String = "api/Master/MAS_Permis_Save?UI_STATE={0}"
        Public Const MAS_Permis_DELETE As String = "api/Master/MAS_Permis_DELETE?ID={0}"



        Public Const SCR_PRODUCT_chk_stock As String = "api/TR/SCR_PRODUCT_chk_stock?Limit={0}"

        Public Const TR_Movment_Save As String = "api/TR/TR_Movment_Save?UI_STATE={0}"
        Public Const TR_Movment_Cancel As String = "api/TR/TR_Movment_Cancel?UI_STATE={0}"
        Public Const Save_Data_YearEnd As String = "api/TR/Save_Data_YearEnd?UI_STATE={0}"











        Public Const RPT_Receive As String = "api/Report/Receive?UI_STATE={0}"
        Public Const RPT_Balance As String = "api/Report/Balance?UI_STATE={0}"
        Public Const RPT_Stockcard As String = "api/Report/Stockcard?UI_STATE={0}"

    End Class



#End Region
End Class
Public Class data_profile
    'Public SHOPID As String
    'Public MRID As String
    'Public MRIP As String
    'Public POSID As String
    'Public SHOPNAME As String
    Public user_id As String
    Public Emp_id As String
    Public Emp_code As String
    Public Emp_name As String
    'Public GP As Double
    'Public GP_FLAG As String

    'Public TERMINAL_TID As String
    'Public TERMINAL_ID As String
    'Public TERMINAL_DESCRIPTION As String
    'Public TERMINAL_TTAXID As String

    'Public BRNID As String
    'Public BRNNAMETHAI As String
    'Public BRNNAMEENG As String
    'Public BRNTAXID As String
    'Public BRNVAT As Double
    'Public COMPNAME As String
    'Public BRNCODE As String

    Public Corp As New COMPANYPROFILE_Models.COMPANYPROFILE_Data
End Class
Public Class data_config
    Public API_SRV As String = ""

    Public CUSDISPLAY As String
    Public COMPORT As String
    Public dafault_display As String
    Public SLIDESHOW As String
    Public SHOWNETSALE As String
    Public MultiCards As String
    Public Auto_update As Boolean
    Public IP As String
    Public SHOP_list(4) As Shop_list
    Public GroupmenuQTY As Integer
    Public menuQTY As Integer
    Public refresh_screen As Integer
End Class
Public Class Shop_list
    Public SHOP_ID As Integer = 0
    Public SHOP_Name As String = ""
End Class


Public Class T_Color
    Public Shared Grid_btn_DEL As Color = Color.OrangeRed
    Public Shared Grid_btn_SCR As Color = Color.DodgerBlue

    Public Shared Grid_Cell_Edit As Color = Color.Gold

    Public Shared Grid_Cell_UP As Color = Color.Green
    Public Shared Grid_Cell_Down As Color = Color.Red
End Class



