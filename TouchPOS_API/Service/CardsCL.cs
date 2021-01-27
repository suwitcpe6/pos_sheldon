


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using TouchPOS_API.Class;
using TouchPOS_API.Models;


namespace TouchPOS_API.Service
{
    public class CardsCL
    {
        #region "select"

        public ResponseMessage card_pro(CHKcard_MultiModels data)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                string sql_card = "";
                sql_card = " select top 1 c.BARCODE,ct.[CARDTYPE],ct.[TYPEDESCRIPTION] ";
                sql_card += " from[CARDS]c inner join CARDTYPE ct on c.TYPEID = ct.TYPEID ";
                sql_card += " where c.CSTATUS = 'A' ";
                sql_card += " and c.BARCODE = '"+ data.BARCODE  + "' ";
                sql_card += " and ct.[TYPEDESCRIPTION] like '%โปร 19%'";
                var card_data = new DataContext().RunQuery<CardModels>(sql_card);

               

                if (card_data != null)
                {
                    if (card_data.Count >= 0)
                    {
                        ret.Data = card_data;
                        ret.Respon.ErrorMessage = "";
                        ret.Respon.Result = true;
                        ret.Respon.SystemErrorMessage = "";


                    }
                }
                else
                {
                    ret.Data = null;
                    ret.Respon.ErrorMessage = "";
                    ret.Respon.Result = false;
                    ret.Respon.SystemErrorMessage = "";
                }
               

            }
            catch (Exception e)
            {
                ret.Respon.SystemErrorMessage = "API : " + e.Message.ToString();
                ret.Respon.Result = false;
            }
            return ret;
        }

        public ResponseMessage card(string BARCODE)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                string sql_card = "";
                sql_card = " SELECT cid,CUSED,CUSED1,BARCODE,TYPEID,CBALANCE  from CARDS  where BARCODE = '" + BARCODE + "' and CSTATUS = 'A' ";
                var card_data = new DataContext().RunQuery<CardModels>(sql_card);

                //var card_data = (from c in db.CARDS
                //            where c.BARCODE == BARCODE || c.CSTATUS  == "A"
                //            orderby c.CDATE descending
                //           select new {
                //               cid = c.CID,
                //               CUSED = c.CUSED,
                //               CUSED1 = c.CUSED1,
                //               BARCODE = c.BARCODE,
                //               TYPEID = c.TYPEID,
                //               CBALANCE = c.CBALANCE
                //           }
                //              ).ToList();

                if (card_data != null)
                {
                    if (card_data.Count <= 0)
                    {
                        throw new Exception("ไม่พบข้อมูลบัตร " + BARCODE + " กรุณาอ่านบัตรอีกครั้ง");
                    }
                }
                else
                {
                    throw new Exception("ไม่พบข้อมูลบัตร " + BARCODE + " กรุณาอ่านบัตรอีกครั้ง");
                }
                ret.Data = card_data;
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
        #endregion
    }
}