using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Service;
using TouchPOS_API.Models;
namespace TouchPOS_API.Service.MASTER
{
    public class MAS_DOCTYPE
    {
        #region "select"

        public ResponseMessage DOCTYPE_Select(string val)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {

                string[] doctype = val.Split(',');
                string doctype2 = "";
                foreach (string s in doctype ){
                    if (doctype2 == "")
                    {
                        doctype2 = "'" + s + "'";
                    }
                    else {
                        doctype2 = ",'" + s + "'";
                    }
                }

                DataContext conn = new DataContext(DataContext.conselect.con2);
                string sql = "";
                sql = " select DocTypeGroupCode,DOCTYPECODE,DOCTYPENAME from [MAS_DOCTYPE] where ISTAT = '1' and (DOCTYPECODE in( "+ doctype2 + "))";
                
       
                    var data = conn.RunQuery<MAS_DOCTYPE_Models.DOCTYPE_Models>(sql);

                if (data != null)
                {
                    if (data.Count > 0)
                    {
                        ret.Data = data;
                        ret.Respon.ErrorMessage = "";
                        ret.Respon.Result = true;
                        ret.Respon.SystemErrorMessage = "";


                    }
                }
                else
                {
                    return new Center().Error_Return("Data not found !", "");
                }


            }
            catch (Exception e)
            {
                return new Center().Error_Return("", e.Message.ToString());
            }
            return ret;
        }


        #endregion

    }
}