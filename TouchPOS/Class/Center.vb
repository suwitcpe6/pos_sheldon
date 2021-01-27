Imports Control_us
Imports Newtonsoft.Json
Public Class Center



    'Public Shared Config_Mode As String = ""  'POS,OFF
    Public Shared Config_use_stock As String = "" 'Y , N

    'Public Shared EDC_LINK As String = "WIFI"


    Public Shared date_now As DateTime

    Public Shared data_profile As New data_profile
    Public Shared Data_Config As New data_config

    Public Shared SYS_Config As New SysConfig.SysConfigModels
    Public Shared DATEWORKING As Date
    Public Shared Link_API As New Link_API With {
        .Get_API = New Get_API With {.Test_Connect = "api/User/Test_connect?Val=",
                                     .shop_loaddata = "api/Shop/Shop_Lode?Val=",
                                     .shop_loaddata_IP = "api/Shop/Shop_Lode_IP?IP={0}",
                                     .UpdateStructure = "api/UpdateStructure/Update",
                                     .Shop_Buttons = "api/Shop/Shop_Buttons?Val=",
                                     .API_Version = "api/System_POS/API_Version",
                                     .WORKINGDATE = "api/Workingdate/Workingdate_Load?Val=",
                                     .Getdate = "api/Workingdate/Getdate",
                                     .CARDTRANS_sum_net = "api/CARDTRANS/Sum_Net?Val=",
                                     .CARDTRANS_PrintSlip = "api/CARDTRANS/PrintSlip?CorpBRNID={0}&slipno={1}",
                                     .CARDTRANS_PrintSlip_INV = "api/CARDTRANS/Sel_PrintSlip_INV?slipno=",
                                     .CARDTRANS_PrintSlip_CN = "api/CARDTRANS/Sel_PrintSlip_CN?VOIDNO={0}",
                                     .CARDTRANS_PrintSlip_multi = "api/CARDTRANS/PrintSlip_multi?slipno=",
                                     .CARDTRANS_CHKcard_Multi = "api/CARDTRANS/CHKcard_Multi",'.CARDTRANS_CHKcard_Multi = "api/CARDTRANS/CHKcard_Multi?BARCODE={0}&Nettotel={1}",
                                     .CARDTRANS_Sel_CHKcard_Postpaid = "api/CARDTRANS/Sel_CHKcard_Postpaid",
                                     .SEL_TenderCL = "api/Tender/SEL_TenderCL?val1=",
                                     .Config_Load = "api/System_POS/Config_Load?val1={0}",
                                     .SEL_SysVersion = "api/System_POS/SEL_SysVersion?val1=",
                                     .Sel_Rpt_dayend = "api/CARDTRANS/Sel_Rpt_dayend?CorpBRNID={0}&shopid={1}&MRTLUPDATE={2}",
                                     .Sel_Repay = "api/CARDTRANS/Sel_Repay?POSID={0}",
                                     .Select_Config = "api/System_POS/Select_Config?Val={0}",
                                     .USERPROFILE_Select = "api/CARDTRANS/Sel_Void_EWALLET?UID={0}",
                                     .Sel_Void_EWALLET = "api/CARDTRANS/Sel_Void_EWALLET?Vtype={0}&shopid={1}&barcode={2}",
                                     .GetVOIDNO = "api/CARDTRANS/Get_VOID?SHOP_ID={0}"
                                    },
        .Post_API = New Post_API With {.CARDTRANS_save = "api/CARDTRANS/Save",
                                       .CARDTRANS_confirm_Sale_cancel = "api/CARDTRANS/confirm_Sale_cancel",
                                       .CARDTRANS_confirmpay = "api/CARDTRANS/confirmpay",
                                       .CARDTRANS_Sale_VOID = "api/CARDTRANS/Sale_VOID",
                                       .CARDTRANS_confirmpay_log = "api/CARDTRANS/confirmpay_log",
                                       .Tender_Log_SAVE_Tender_Log = "api/Tender_Log/SAVE_Tender_Log",
                                       .CardsCL_card_pro = "api/CardsCL/card_pro",
                                       .Save_Config = "api/System_POS/Save_Config",
                                       .Sale_VOID = "api/CARDTRANS/Sale_VOID"
                                      }
        }

    Public Shared Sub load_profile(ByVal val As SHOP_ModelS.Model)

        Try
            With data_profile
                .SHOPID = val.SHOPID
                .MRID = val.MRID
                .MRIP = val.MRIP
                .POSID = val.POSID
                .SHOPNAME = val.SHOPNAME
                .Emp_id = "" 'drow("SHOPID")
                .Emp_code = "" 'drow("SHOPID")
                .Emp_name = val.OWNER
                .GP = val.SHAREPERCENT
                .GP_FLAG = val.SHAREPERCENTFLAG

                .TERMINAL_ID = val.TERMINAL_ID
                .TERMINAL_TID = val.TERMINAL_TID
                .TERMINAL_DESCRIPTION = val.TERMINAL_DESCRIPTION
                .TERMINAL_TTAXID = val.TERMINAL_TTAXID

                .BRNID = val.BRNID
                .BRNNAMETHAI = val.BRNNAMETHAI
                .BRNNAMEENG = val.BRNNAMEENG
                .BRNTAXID = val.BRNTAXID
                .BRNVAT = val.BRNVAT
                .COMPNAME = val.COMPNAME
                .BRNCODE = val.BRNCODE
                .EDC_IP = val.EDC_IP
                .STCODE = val.STCODE

                .Merchant_ID = val.Merchant_ID
                .Profit_N = val.Profit_N
                .RONAME = val.RONAME
            End With

        Catch ex As Exception
            Throw ex
            'Msg_err.Show_Err(ex, "Center")
        End Try
    End Sub

End Class
Public Class data_profile
    Public SHOPID As String
    Public MRID As String
    Public MRIP As String
    Public POSID As String
    Public SHOPNAME As String
    Public user_id As String
    Public Emp_id As String
    Public Emp_code As String
    Public Emp_name As String
    Public GP As Double
    Public GP_FLAG As String

    Public TERMINAL_TID As String
    Public TERMINAL_ID As String
    Public TERMINAL_DESCRIPTION As String
    Public TERMINAL_TTAXID As String

    Public BRNID As String
    Public BRNNAMETHAI As String
    Public BRNNAMEENG As String
    Public BRNTAXID As String
    Public BRNVAT As Double
    Public COMPNAME As String
    Public BRNCODE As String
    Public STCODE As String

    Public Merchant_ID As String
    Public Profit_N As String
    Public RONAME As String

    Public EDC_IP As String = ""
End Class
Public Class data_config
    Public API As String = System.Configuration.ConfigurationManager.AppSettings("API")

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
    Public ProgramMode As String
End Class



#Region "Link Api"
Public Class Shop_list
    Public SHOP_ID As Integer = 0
    Public SHOP_Name As String = ""
End Class
Public Class Link_API
    Public Get_API As Get_API
    Public Post_API As Post_API
End Class
Public Class Get_API
    Public Test_Connect As String
    Public UpdateStructure As String
    Public shop_loaddata As String
    Public shop_loaddata_IP As String
    Public Shop_Buttons As String
    Public SEL_TenderCL As String

    Public API_Version As String
    Public WORKINGDATE As String
    Public Getdate As String
    Public CARDTRANS_sum_net As String
    Public CARDTRANS_PrintSlip As String
    Public CARDTRANS_PrintSlip_INV As String
    Public CARDTRANS_PrintSlip_CN As String
    Public CARDTRANS_PrintSlip_multi As String
    Public CARDTRANS_CHKcard_Multi As String
    Public CARDTRANS_Sel_CHKcard_Postpaid As String
    Public SEL_SysVersion As String
    Public Config_Load As String

    Public Sel_Rpt_dayend As String
    Public Sel_Repay As String

    Public Select_Config As String

    Public USERPROFILE_Select As String
    Public Sel_Void_EWALLET As String
    Public GetVOIDNO As String
End Class
Public Class Post_API
    Public CARDTRANS_save As String
    Public CARDTRANS_confirm_Sale_cancel As String
    Public CARDTRANS_confirmpay As String
    Public CARDTRANS_confirmpay_log As String
    Public CARDTRANS_Sale_VOID As String
    Public Tender_Log_SAVE_Tender_Log As String
    Public CardsCL_card_pro As String
    Public Save_Config As String
    Public Sale_VOID As String


End Class


#End Region

