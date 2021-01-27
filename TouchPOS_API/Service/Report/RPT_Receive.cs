using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;

namespace TouchPOS_API.Service.Report
{
    public class RPT_Receive
    {
        #region "select"

        public ResponseMessage Receive(RPT_ReceiveModels.Fillter_Receive val, string UI_STATE)
        {
            ResponseMessage ret = new ResponseMessage();

            //ConString1 db = new ConString1();
         
            try
            {

                DataContext conn = new DataContext(DataContext.conselect.con2);
                string sql = "";


                sql = " select h.TR_ID,h.DOCTYPE,h.DOCNO,cast(h.DOCDATE as nvarchar(20)) DOCDATE,h.STCODE,h.PERCODE,h.PERNAME,h.REF_DOCNO " +
                    " ,d.SEQ,d.PCODE,d.PNAME,d.qty,d.idc,d.st_qty ,d.UNITCODE,d.UNITNAME  ,d.ST_UNITCODE,d.ST_UNITNAME " +
                    " ,pg.PGCODE,pg.PGNAME ,d.UNIT_COST,d.ST_COST,d.TOTAL_COST" +
                    " from[MOVT] h inner join MOVT_D d on h.TR_ID = d.TR_ID " +
                    " left join MAS_PRODUCT p on p.PCODE = d.PCODE " +
                    " left join MAS_PRODUCT_GROUP pg on pg.PGCODE = p.PGCODE " +
                    " where h.ISTAT = '1' and h.DCSTAT = 'SUBMIT' and h.DOCTYPE = '" + val.DOCTYPE + "' and h.DAY_END = 'N'";
                   

                if (val.DCDATE != null && val.DCDATE != "")
                {
                    DateTime d1;
                    try
                    {
                        d1 = Convert.ToDateTime(val.DCDATE);
                    }
                    catch (Exception e)
                    {
                        return new Center().Error_Return("", "Incorrect date format");
                    }

                    sql += " and (  cast(h.DOCDATE as date) = '" + new Center().Condate(d1, "ymd2") + "' ) ";

                }
                if (val.DOCNO != null && val.DOCNO != "")
                {
                    sql += " and  h.DOCNO like '%" + val.DOCNO + "%' ";
                }
                if (val.PERCODE != null && val.PERCODE != "")
                {
                    sql += " and  h.PERCODE like '%" + val.PERCODE + "%' ";
                }
                if (val.REFDOCNO != null && val.REFDOCNO != "")
                {
                    sql += " and  h.REF_DOCNO like '%" + val.REFDOCNO + "%' ";
                }
                sql += " order by h.DOCNO";

                var data = conn.RunQuery<RPT_ReceiveModels.Rceive_data>(sql);

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