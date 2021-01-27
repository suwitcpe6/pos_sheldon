using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
namespace TouchPOS_API.Service.MASTER
{
    public class DOC_STATUS_CL
    {

        #region "select"

        public ResponseMessage DOC_STATUS_Select(string DOS_GROUP, string UI_STATE)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                DataContext conn = new DataContext(DataContext.conselect.con2);
                string sql = "";
                sql = " select ID, DOS_ID, DOS_NAME, DOS_DESC, DOS_GROUP, CDATE, ISTAT from MAS_DOC_STATUS  where [ISTAT] = '1' and DOS_GROUP = '" + DOS_GROUP + "'";
              switch (UI_STATE)
                {
                    case Center .UI_STATE .UINew :
                        sql += " and  DOS_ID <> 'CANCEL'";
                            break;
                    //case Center.UI_STATE.UIEdit:
                    //    sql += " and  DOS_ID <> 'DRAFT'";
                    //    break;
                    default :
                        break;

                }

                var data = conn.RunQuery<MAS_DOC_STATUS_MODELS.DOC_STATUS_SEL>(sql);

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
                return new Center().Error_Return( "",e.Message.ToString());
            }
            return ret;
        }


        #endregion
    }
}