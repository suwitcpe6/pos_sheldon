using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;

namespace TouchPOS_API.Service.structure
{
    public class Default_Config
    {
        public ResponseMessage Default(SysConfigModels data_config)
        {
            //ไม่ใช้แล้วอ่านจากเบสที่เดียว
            //var structure_CUSGROUP = System.Configuration.ConfigurationSettings.AppSettings.Get("structure_CUSGROUP");
            var ret = new ResponseMessage();

            
            try
            {
                Getschemas Gs = new Getschemas();
                List<SchemasModel> idx = new List<SchemasModel>();
                DataContext exec = new DataContext();

                if (data_config == null)
                {
                    ret.Respon.Result = false;
                    ret.Respon.SystemErrorMessage = "กรุณาตั้งค่ากลุ่มบริษัทเพื่อตั้งค่าเริ่มต้นอัติโนมัติ !!";
                    return ret;

                }
                else
                {
                    if (data_config.CUSGROUP == cl_const.CUSGROUP.CPN)
                    {

                        //string sql = "";
                        //sql = " USE [" + exec.DB_backup_name + "] ";
                        //sql += "\n";
                        //sql += " update TENDER set STATUS =1 where [CODE]in('TRUEEDC','TRUEWALLET')";
                        //sql += " update TENDER set STATUS = 0 where[CODE]not in('TRUEEDC', 'TRUEWALLET') ";
                        //sql += " update [SysConfig]set [CUSGROUP] = 'CPN' ,[VENDOR_GETWAY]='TRUE',[CONN_LINK]='API',[WALLET_TYPE]='API',USESTOCK=0,POSTYPE='" + cl_const.POSTYPE.prepaid + "' ";
                        //exec.Excute2(sql);



                    }
                    else if(data_config.CUSGROUP == cl_const.CUSGROUP.ATR)
                    {


                        //string sql = "";
                        //sql = " USE [" + exec.DB_backup_name + "] ";
                        //sql += "\n";
                        //sql += " update [SysConfig]set USESTOCK=0,POSTYPE='"+ cl_const .POSTYPE.postpaid + "' ";
                        //exec.Excute2(sql);

                    }
                    //else
                    //{

                    //    string sql = "";
                    //    sql = " USE [" + exec.DB_backup_name + "] ";
                    //    sql += "\n";
                    //    sql += " update TENDER set STATUS =1 ";// where [CODE]in('TRUEEDC','TRUEWALLET')";
                    //                                           //sql += " update TENDER set STATUS = 0 where[CODE]not in('TRUEEDC', 'TRUEWALLET') ";
                    //    sql += " update [SysConfig]set [CUSGROUP] = 'HOMEPRO' ,[VENDOR_GETWAY]='GHL',[CONN_LINK]='WIFI',[WALLET_TYPE]='API' ";
                    //    exec.Excute2(sql);
                    //}


                }

                ret.Respon.Result = true;
                ret.Respon.ErrorMessage = "Update Success";
                return ret;
            }
            catch (Exception ex)
            {
                ret.Respon.Result = false;
                ret.Respon.SystemErrorMessage = ex.Message;
                return ret;
            }
        }
    }
}