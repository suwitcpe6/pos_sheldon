using System;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
using TouchPOS_API.Helpers;
using System.Data;

namespace TouchPOS_API.Service.MASTER
{
    public class MAS_Stock
    {


        #region "select"
        public ResponseMessage STOCK_List_CBO(string val)

        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                DataContext conn = new DataContext(DataContext.conselect.con2);
                string sql = "";
                sql += " select  STCODE, STNAME ";
                sql += " from  [dbo].[MAS_STOCK] ";
                sql += " where ISTAT = '1' and ACTIVEFLAG = 'A'";
                sql += " order by ID ";

                var data = conn.RunQuery< Mas_Stock_Models.MAS_STOCK_List>(sql);

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

        public ResponseMessage Stock_List(string CODE, string NAME, string Limit)

        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                DataContext conn = new DataContext(DataContext.conselect.con2);
                string sql = "";
                sql += " select TOP " + Limit + " ID, STCODE, STNAME,MDATE, (case when ACTIVEFLAG ='A' then 'Active' when ACTIVEFLAG ='C' then 'Not Active' end) as ACTIVEFLAG";
                sql += " from  [dbo].[Mas_Stock] ";
                sql += " where ISTAT = '1'";
                if (CODE != null)
                {
                    sql += " and  STCODE like '%" + CODE + "%' ";
                }
                if (NAME != null)
                {
                    sql += " and (  STNAME like '%" + NAME + "%' ) ";
                }

                sql += " order by ID desc ";

                var data = conn.RunQuery<Mas_Stock_Models.MAS_STOCK_List>(sql);

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
        public ResponseMessage Stock_Select(string ID)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                DataContext conn = new DataContext(DataContext.conselect.con2);
                string sql = "";
                sql += " select ID,STCODE, STNAME, DESCRIPTION, REMARK, ACTIVEFLAG, CDATE, CUSE, MDATE, MUSE, ISTAT ";
                sql += " from Mas_Stock ";
                sql += " where ISTAT = '1'";
                sql += " and  ID = '" + ID + "' ";

                var data = conn.RunQuery<Mas_Stock_Models.MAS_STOCK_Data>(sql);

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


        #region "SAVE"

        public ResponseMessage Save_Data(Mas_Stock_Models.MAS_STOCK_Data Input_data, string UI_STATE)
        {
            var ret = new ResponseMessage();
            BaseManagement Base = new BaseManagement();
            var conn = new DataContext(DataContext.conselect.con2);
            try
            {

                conn.Open();
                if (UI_STATE == Center.UI_STATE.UINew)
                {
                    //Input_data.TR_ID = new Doccument().Gendocno(conn, "PROD.UNIT.TRID", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());

                    //if (Input_data.TR_ID == "")
                    //{
                    //    throw new Exception("Document cannot be created  Transaction ID  ! document configuration not found");
                    //}
                    //ถ้าไม่ใส่โค๊ดมาจะเข้าเคสนี้
                    if (Input_data.STCODE == "")
                    {
                        Input_data.STCODE = new Doccument().Gendocno(conn, "ST", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());

                        if (Input_data.STCODE == "")
                        {
                            throw new Exception("Document cannot be created  UNIT Code  ! document configuration not found");
                        }
                    }

                }
                else if (UI_STATE == Center.UI_STATE.UIEdit)
                {

                }

               if ( Save_H(conn, Input_data, UI_STATE)==false)
                {
                    ret.Respon.Result = false;
                    ret.Respon.ErrorMessage = "เพิ่มคลังใช้งานได้ 1 คลัง ";
                    conn.Rollback();
                    return ret;
                }
                //Base._base.Commit();


                conn.Commit();

                ret.Respon.Result = true;
                ret.Respon.Result_value = Input_data.STCODE;
                return ret;



                //return new Center().Error_Return("Data not found !", "");
            }
            catch (Exception e)
            {
                conn.Rollback();
                if (e.Message.ToString().Contains("PRIMARY KEY constraint"))
                {
                    return new Center().Error_Return("Duplicate Product UNIT code", "");
                }
                else
                {
                    return new Center().Error_Return("", e.Message.ToString());
                }
            }
        }

        public bool Save_H(DataContext conn, Mas_Stock_Models.MAS_STOCK_Data Input_data, string UI_STATE)
        {

            string query = "";
            if (UI_STATE == Center.UI_STATE.UINew)
            {
                string chk = "  select STCODE from MAS_STOCK where ISTAT = '1' and ACTIVEFLAG = 'A' ";
               DataTable dt  =conn.ReadData_Table(chk);
                if(dt.Rows .Count >0)
                {
                    return false;
                }



                string Listcol = "   STCODE, STNAME, DESCRIPTION, REMARK, ACTIVEFLAG, CDATE, CUSE, MDATE, MUSE, ISTAT";
                //query = " USE  " + conn.DB_backup_name;
                query = new Mybase().Insert(Input_data, Listcol);
            }
            else if (UI_STATE == Center.UI_STATE.UIEdit)
            {
                string Listcol = " STNAME, DESCRIPTION, REMARK, ACTIVEFLAG, MDATE, MUSE, ISTAT";
                //query = " USE  " + conn.DB_backup_name;
                query = new Mybase().Update(Input_data, Listcol);
                query += " where ID = '" + Input_data.ID + "'";
            }
            var a = conn.Excute(query);
            return true;
        }

        public ResponseMessage Delete(string ID)
        {
            var ret = new ResponseMessage();
            var con = new DataContext();

            try
            {
                string str = " Update Mas_Stock set ISTAT = '0' where  ID = '" + ID + "' ";
                con.Excute2(str);

                ret.Respon.Result = true;
                ret.Respon.Result_value = ID;
                return ret;
            }
            catch (Exception e)
            {
                return new Center().Error_Return("", e.Message.ToString());
            }
        }
        #endregion


    }
}