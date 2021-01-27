using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;

namespace TouchPOS_API.Service.MASTER
{
    public class COMPANYPROFILE
    {

        #region "select"

        public ResponseMessage COMPANYPROFILE_Select()
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                DataContext conn = new DataContext(DataContext.conselect.con1);
                string sql = "";
                sql = " select [COMID], [BRNID], [BRNNAMETHAI], [BRNNAMEENG], [BRNTAXID], [BRNVAT], [COMPNAME], [ADDRESS1], [ADDRESS2], [REMARK], [GATEWAY],[FullTaxNo] from COMPANYPROFILE";
                
                var data = conn.RunQuery<COMPANYPROFILE_Models.COMPANYPROFILE_data>(sql);

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