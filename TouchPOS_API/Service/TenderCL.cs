using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;

namespace TouchPOS_API.Service
{
    public class TenderCL
    {
        #region "select" 
        public ResponseMessage SEL_TenderCL(string BARCODE)
        {
           
            ResponseMessage ret = new ResponseMessage();
            try
            {
                var con = new DataContext();

                var ret_config = new System_POS().Config_Load("");
                List<SysConfigModels> data_config = new List<SysConfigModels>();
                data_config = (List<SysConfigModels>)ret_config.Data;



                string str = "";


                if (data_config[0].WALLET_TYPE == cl_const.WALLET_TYPE.APIHUBCPN)
                {
                    str = " SELECT [tgroup] as TYPE,[tcode] as CODE,[tname] as NAME ,  'B&C' as SCAN_TYPE FROM [tendername]  ";
                }
                else
                {
                    //str = "  SELECT TID,SEQ, MERCHAND_ID,[VENDERCODE],[VENDERNAME], [TYPE], [CODE], [NAME], [CERRENCY], PAYMENT_METHOD,[VALUE_CONVERT],Server FROM " + con.DB_backup+ "[TENDER] where STATUS = '1' ";

                    str = "  SELECT t1.TID, t1.CODE, t1.NAME, t1.VENDERCODE, t1.VENDERNAME, t1.[TYPE], t1.CERRENCY, t1.PAYMENT_METHOD,  t1.VALUE_CONVERT, t1.[Server] ";
                    str += " ,t2.SEQ, t2.TERMINALID, t2.POSID, t2.MERCHAND_ID, t2.APP_ID, t2.CLIENT_KEY, t2.CLIENT_SECRET ,T1.PREFIX_BARCODE,T1.REMARK1,T1.REMARK2,T1.REMARK3,T1.SCAN_TYPE ";
                    str += " ,isnull(t2.VENDER_SHOP_ID,'') as VENDER_SHOP_ID  ";
                    str += " FROM  " + con.DB_backup + "[TENDER]T1 inner join  " + con.DB_backup + "TENDER_ITEMS t2 on t1.code = t2.code ";
                    str += " where t1.[STATUS] = '1' and t2.[STATUS] = '1' ";
                }

var Tender = con.RunQuery<TenderModels.Sel_Tender>(str);

                ret.Data = Tender;
                ret.Respon.ErrorMessage = "";
                ret.Respon.Result = true;
                ret.Respon.SystemErrorMessage = "";

            }
            catch (Exception e)
            {
                ret.Respon.SystemErrorMessage = "API : " + e.Message.ToString();
                ret.Respon.Result = false;
            }
            return ret;
        }

        #endregion
    }
}