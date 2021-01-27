using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;

namespace TouchPOS_API.Service.structure
{
    public class Table_Addconfig
    {
        public ResponseMessage Addconfig(List<SysConfigModels> data_config)
        {
            var ret = new ResponseMessage();
            try
            {
                Getschemas Gs = new Getschemas();
                List<SchemasModel> idx = new List<SchemasModel>();
                DataContext exec = new DataContext();


                //string sql = "";
                //sql = " USE [" + exec.DB_backup_name + "] ";
                //sql += " if not exists(select * from[TENDER] where[CODE] = 'TRUEEDC') ";
                //sql += " begin ";
                //sql += " INSERT[dbo].[TENDER] ([TID], [CODE], [NAME], [VENDERCODE], [VENDERNAME], [TYPE], [CERRENCY], [PAYMENT_METHOD], [VALUE_CONVERT], [Server], [SCAN_TYPE], [PREFIX_BARCODE], [REMARK1], [REMARK2], [REMARK3], [STATUS], [CBY], [CRDATE], [MBY], [MODATE], [MO]) VALUES(7, N'TRUEEDC', N'True EDC', N'TRUE', N'TRUE', N'EWALLET', N'THB', N'BALANCE', CAST(100.00 AS Decimal(18, 2)), N'', N'B&C', N'M', N'MERCHAND_ID_SINGGLE', N'', N'', N'1', N'pgm', CAST(N'2020-10-22T14:02:44.390' AS DateTime), N'pgm', CAST(N'2020-11-05T10:06:16.310' AS DateTime), 1) ";
                //sql += " end ";
                //sql += " if not exists(select* from [TENDER_ITEMS] where[CODE] = 'TRUEEDC') ";
                //sql += " begin ";
                //sql += " INSERT[dbo].[TENDER_ITEMS] ";
                //sql += " ([CODE], [SEQ], [TERMINALID], [POSID], [MERCHAND_ID], [APP_ID], [CLIENT_KEY], [CLIENT_SECRET], [STATUS], [REMARK1], [REMARK2], [REMARK3]) VALUES( N'TRUEEDC', 1, N'', N'', N'', N'', N'', N'', N'1', NULL, NULL, NULL) ";
                //sql += " end ";

                //exec.Excute2(sql);


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