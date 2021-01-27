using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
namespace TouchPOS_API.Service.Report
{
    public class RPT_Balance
    {
        #region "select"

        public ResponseMessage Balance(RPT_BalanceModels.Fillter_Balance val, string UI_STATE)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                DataContext conn = new DataContext(DataContext.conselect.con2);
                string sql = "";


                sql = " SELECT bl.stcode,st.STNAME, bl.[PCODE],p.PNAME ,pg.PGCODE,pg.PGNAME ,[ST_UNITCODE],pu.UNITNAME as ST_UNITNAME ,sum([ST_QTY]) as [ST_QTY]" +
                        ",(sum(bl.ST_COST)) / count(bl.[PCODE]) as ST_COST" +
                         " FROM[V_MOV_BALANCE]bl  left join MAS_STOCK st on st.STCODE = bl.STCODE " +
                        " left join MAS_PRODUCT p on p.pcode = bl.PCODE " +
                        " left join MAS_PRODUCT_GROUP pg on pg.PGCODE = p.PGCODE " +
                        " left join MAS_PRODUCT_UNIT pu on pu.UNITCODE = bl.ST_UNITCODE " +
                        " where 1= 1";



                if (val.STCODE != null && val.STCODE != "")
                {
                    sql += " and  bl.stcode = '" + val.STCODE + "' ";
                }
                if ((val.PCODE1 != null && val.PCODE1 != "") && (val.PCODE2 != null && val.PCODE2 != ""))
                {
                    sql += " and bl.[PCODE] between '" + val.PCODE1 + "' and '" + val.PCODE2 + "' ";
                }
                sql += "group by bl.stcode,st.STNAME, bl.[PCODE],p.PNAME ,pg.PGCODE,pg.PGNAME  ,[ST_UNITCODE],pu.UNITNAME ";


                var data = conn.RunQuery<RPT_BalanceModels.Balance_data>(sql);

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
                        return new Center().Error_Return("Data not found !", "");
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