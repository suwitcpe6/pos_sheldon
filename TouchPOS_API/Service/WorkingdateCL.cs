
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using TouchPOS_API.Class;
using TouchPOS_API.Models;

namespace TouchPOS_API.Service
{
    public class WorkingdateCL
    {
        #region "select"   
        public ResponseMessage Workingdate_load(string val)
        {
            ResponseMessage ret = new ResponseMessage();
            //ConString1 db = new ConString1();
            try
            {              
                      
               //var  WORKINGDATE = (from c in db.WORKINGDATE
               //             where (System.Data.Entity.DbFunctions.TruncateTime(c.DATEWORKING) == System.Data.Entity.DbFunctions.TruncateTime(DateTime.Now))
               //             select c                           
               //                 ).ToList();



                string sql_card = "";
                sql_card = " SELECT top 1 *  from WORKINGDATE where  cast(DATEWORKING as date ) = cast(getdate() as date )  ";
                var WORKINGDATE = new DataContext().RunQuery<WORKINGDATEModels>(sql_card);





                ret.Data = WORKINGDATE;


                ret.Data = WORKINGDATE;
                ret.Respon.Result = true;
                if (WORKINGDATE.Count > 0)
                {
                    ret.Respon.ErrorMessage = WORKINGDATE[0].DATEWORKING.ToString();
                }
                else
                {
                    ret.Respon.ErrorMessage = "";
                }
                
                return ret;
            }
            catch(Exception ex) {
                ret.Respon.Result = false;
                ret.Respon.SystemErrorMessage = ex.Message;
                return ret;
            }
            finally {
                //db = null;
                ret = null;
            }
        }
        public List<WORKINGDATEModels> chk_Workingdate(string val)
        {

            try
            {
                string sql = "";
                sql = " SELECT DATEWORKING FROM WORKINGDATE where cast( DATEWORKING as date) =cast(getdate()as date) ";
                var WORKINGDATE = new DataContext().RunQuery<WORKINGDATEModels>(sql);

                //List<WORKINGDATE> WORKINGDATE;
                //WORKINGDATE = new List<WORKINGDATE>();


                if (WORKINGDATE != null)
                {
                    if (WORKINGDATE.Count <= 0)
                    {
                        throw new Exception("ไม่ได้กำหนดวันทำงาน Working Date กรุณาแจ้งผู้ดูแลระบบ");
                    }
                }
                else
                {
                    throw new Exception("ไม่ได้กำหนดวันทำงาน Working Date กรุณาแจ้งผู้ดูแลระบบ");
                }
                return WORKINGDATE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public Date_now_Models Getdate()
        {

            try
            {
                string sql = "";
                sql = " SELECT getdate() as date_now ";
                var date_now = new DataContext().RunQuery<Date_now_Models>(sql);
                    return date_now[0];
            }
            catch (Exception ex)
            {
                //throw ex;
                return null;
            }
       
        }
        #endregion


    }
}