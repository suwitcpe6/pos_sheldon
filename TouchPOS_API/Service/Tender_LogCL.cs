using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
namespace TouchPOS_API.Service
{
    public class Tender_LogCL
    {
        public ResponseMessage SAVE_Tender_Log(Tender_LogModel data)
        {
            var con = new DataContext();
            var ret = new ResponseMessage();
            var Sql_check = new Sql_check();
            try
            {
                string CDATE = new Center().Condate(data.CDATE , "ymd hh:mm:ss");
                string MODATE = new Center().Condate(data.MODATE , "ymd hh:mm:ss");

                string strPay = "";

                strPay = " INSERT INTO "+ con.DB_backup + "[TENDER_LOG]([TENDERCODE],[DOCNO],[TENDERDOCNO],[TERMINALID],[POSID],[MERCHAND_ID],[LOG_TYPE],[DATA_TYPE],[DATA1],[DATA2],[REMARK1],[REMARK2],[REMARK3],[STATUS],[CBY],[CDATE],[MBY],[MODATE])";
                strPay += " VALUES(";

                strPay += "'" + data.TENDERCODE + "',";
                strPay += "'" + data.DOCNO + "',";
                strPay += "'" + data.TENDERDOCNO + "',";
                strPay += "'" + data.TERMINALID + "',";
                strPay += "'" + data.POSID + "',";
                strPay += "'" + data.MERCHAND_ID + "',";
                strPay += "'" + data.LOG_TYPE + "',";
                strPay += "'" + data.DATA_TYPE + "',";
                strPay += "'" + data.DATA1 + "',";
                strPay += "'" + data.DATA2 + "',";
                strPay += "'" + data.REMARK1 + "',";
                strPay += "'" + data.REMARK2 + "',";
                strPay += "'" + data.REMARK3 + "',";
                strPay += "'" + data.STATUS + "',";
                strPay += "'" + data.CBY + "',";
                strPay += "'" + CDATE + "',";
                strPay += "'" + data.MBY + "',";
                strPay += "'" + CDATE + "'";
                strPay +=")";


               
                con.Open();
                con.Excute(strPay);
                con.Commit();
                ret.Respon.Result = true;
                ret.Respon.ErrorMessage = "success";
            }
            catch (Exception e)
            {
                con.Rollback();
                ret.Respon.SystemErrorMessage = "API : " + e.ToString();
                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
            }
            return ret;

        }
    }
}