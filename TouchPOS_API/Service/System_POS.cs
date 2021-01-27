using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
namespace TouchPOS_API.Service
{
    public class System_POS
    {

        #region "select" 
        public ResponseMessage SEL_SysVersion(string val)
        {
            ResponseMessage ret = new ResponseMessage();
            try
            {
                var con = new DataContext();
                string str = "";
                str = "  SELECT path  FROM  " + con.DB_backup + "[SysVersion] ";
                var SysVersion = con.RunQuery<SysVersionModel.SEL_Version>(str);

                ret.Data = SysVersion;
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
        public ResponseMessage Config_Load(string val)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                DataContext conn = new DataContext();
                string sql = " select top 1 * from " + conn.DB_backup + "SysConfig order by [ITEMSNO] desc ";
                var data = new DataContext().RunQuery<SysConfigModels>(sql);

                ret.Data = data;
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

        public ResponseMessage Select_Config(string val)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                DataContext conn = new DataContext();
                string sql = " select top 1 * from " + conn.DB_backup + "SysConfig order by [ITEMSNO] desc ";

                var data_Config = new DataContext().RunQuery<SysConfig>(sql);

                sql = "  SELECT *  FROM  " + conn.DB_backup + "[SysVersion] ";
                var data_Version = conn.RunQuery<SysVersion>(sql);

                Data_Config data = new Data_Config();

                
                if (data_Config.Count != 0)
                {
                    data.SysConfig = data_Config[0];
                }
                else
                {
                    data.SysConfig = new SysConfig();
                }

                if (data_Version.Count != 0)
                {
                    data.SysVersion = data_Version[0];
                }
                else
                {
                    data.SysVersion = new SysVersion();
                }
                

                ret.Data = data;
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


        public ResponseMessage Save_Config(Data_Config data)
        {
            var con = new DataContext();
            var ret = new ResponseMessage();
            var Sql_check = new Sql_check();
            try
            {

                string strPay = "";

                strPay = " delete " + con.DB_backup + "[SysVersion]";
                strPay += " INSERT INTO " + con.DB_backup + "[SysVersion]([sysNo],[sysName],[path]) values('"+ data.SysVersion.sysNo + "','" + data.SysVersion.sysName + "','" + data.SysVersion.path + "') ";


                strPay += " delete " + con.DB_backup + "[SysConfig]";
                strPay += " INSERT INTO " + con.DB_backup + "[SysConfig]([ITEMSNO], [CUSGROUP], [VENDOR_GETWAY], [CONN_LINK], [WALLET_TYPE],USESTOCK,POSTYPE)  ";
                strPay += "values('" + data.SysConfig.ITEMSNO + "', '" + data.SysConfig.CUSGROUP + "','" + data.SysConfig.VENDOR_GETWAY + "','" + data.SysConfig.CONN_LINK + "' ,'" + data.SysConfig.WALLET_TYPE + "'," + (data.SysConfig.USESTOCK ?  "1": "0") + ",'" + data.SysConfig.POSTYPE + "')";


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
        #endregion

    }
}