using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;

namespace TouchPOS_API.Service.MASTER
{
    public class USERPROFILE
    {

        #region "select"

        public ResponseMessage USERPROFILE_Select(string UID)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                DataContext conn = new DataContext(DataContext.conselect.con1);
                string sql = "";
                sql = " select [UPROFILEID], [UID], [UFULLNAME], [UPASSWORD], [ULEVEL], [USTATUS], [UCDATE], [UUID],getdate() as date_now from USERPROFILE  where USTATUS = 'E' ";
                if (UID != null && UID != "")
                {
                    sql += " and UID = '" + UID + "'";
                }

                    var data = conn.RunQuery<USERPROFILE_Mmodels.USERPROFILE_Data>(sql);

                if (data != null)
                {
                    if (data.Count > 0)
                    {
                        ret.Data = data;
                        ret.Respon.ErrorMessage = "";
                        ret.Respon.Result = true;
                        ret.Respon.SystemErrorMessage = "";


                    }
                    else
                    {
                        return new Center().Error_Return("User not found !", "");
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