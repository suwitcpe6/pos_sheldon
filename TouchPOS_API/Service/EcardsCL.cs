using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
namespace TouchPOS_API.Service
{
    public class EcardsCL
    {

        #region"select"
       public  List<EcardModels> Ecard_Load(string val)
        {
            //ConString1 db = new ConString1();
            

            try
            {

                //var ECARDS_val = (from c in db.ECARDS
                //            where c.BARCODE == val
                //            orderby c.CDATE descending
                //            select c 
                //            ).Take(1).ToList();


                string sql_card = "";
                sql_card = " SELECT top 1 *  from ECARDS  where BARCODE = '" + val + "' ";
                var ECARDS_val = new DataContext().RunQuery<EcardModels>(sql_card);

                return ECARDS_val;



                //return new POS_API.DataContext().RunQuery<> ;
            }
            catch (Exception e)
            {
                //ret.Respon.ErrorMessage = "API : " + e.Message.ToString();

                ////ret.SystemErrorMessage = e.StackTrace;
                //ret.Respon.Result = false;
                return null;
            }
          
        }
        public ResponseMessage CHK_Ecard(string val)
        {
            //ConString1 db = new ConString1();
            var ret = new ResponseMessage();
            try
            {

                //var ECARDS_val = (from c in db.ECARDS
                //                  where c.BARCODE == val
                //                  orderby c.CDATE descending
                //                  select c
                //            ).Take(1).ToList();

                string sql_card = "";
                sql_card = " SELECT top 1 *  from ECARDS  where BARCODE = '" + val + "' ";
                var ECARDS_val = new DataContext().RunQuery<EcardModels>(sql_card);







                if (ECARDS_val != null && ECARDS_val.Count > 0)
                {
                    ret.Respon.ErrorMessage = "บัตร "+ val + " หมดอายุตั้งแต่วันที่ " + ECARDS_val[0].CEXPIRED.Value.Date.ToString("dd/MM/yyyy");
                    ret.Respon.SystemErrorMessage = "";
                    ret.Respon.Result = false;
                    return ret;
                }
                ret.Respon.ErrorMessage = "";
                ret.Respon.SystemErrorMessage = "";
                ret.Respon.Result = true;
                ret.Data = ECARDS_val;
                return ret;
                //return new POS_API.DataContext().RunQuery<> ;
            }
            catch (Exception e)
            {
                ret.Respon.ErrorMessage = "";
                ret.Respon.Result_value = "";
                ret.Respon.SystemErrorMessage = e.Message;
                ret.Respon.Result = false;
                return ret;
            }
        }
        #endregion
        #region"save"
        #endregion
    }
}