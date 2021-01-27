using System;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
using TouchPOS_API.Helpers;
using TouchPOS_API;

namespace TouchPOS_API.Service.MASTER
{
    public class MAS_REASON
    {
        #region "select"
        public ResponseMessage REASON_List(string RSCODE, string RSNAME, string Limit)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                string sql = "";
                sql = " select TOP " + Limit  + " RS.ID,  RS.RSCODE, RS.RSNAME,MDATE, dc.DOS_NAME as ACTIVEFLAG";
                sql += " from  [dbo].[MAS_REASON] RS " +
                    "left join MAS_DOC_STATUS dc on dc.DOS_ID = RS.ACTIVEFLAG and DOS_GROUP ='MASTER'";
                sql += " where RS.ISTAT = '1'";
                if (RSCODE != null)
                {
                    sql += " and  RS.RSCODE like '%" + RSCODE + "%' ";
                }
                if (RSNAME != null)
                {
                    sql += " and (  RS.RSNAME like '%" + RSNAME + "%' ) ";
                }

                sql += " order by RS.RSCODE desc ";

                var data = new DataContext().RunQuery<MAS_REASON_Models.REASO_List>(sql);

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
        public ResponseMessage REASON_List_CBO(string val )
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                string sql = "";
                sql = " select  RS.RSCODE, RS.RSNAME";
                sql += " from  [MAS_REASON] RS ";
                  
                sql += " where RS.ISTAT = '1'";
                
                sql += " order by RS.RSCODE desc ";

                var data = new DataContext().RunQuery<MAS_REASON_Models.REASO_List>(sql);

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
        public ResponseMessage REASON_Select(string ID)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                string sql = "";
                sql = " select ID, RSCODE, RSNAME, DESCRIPTION, REMARK, ACTIVEFLAG, CDATE, CUSE, MDATE, MUSE, ISTAT ";
                sql += " from [MAS_REASON] ";
                sql += " where ISTAT = '1'";
                if (ID != null)
                {
                    sql += " and  ID = '" + ID + "' ";
                }

                var data = new DataContext().RunQuery<MAS_REASON_Models.REASO_Data>(sql);

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

        public ResponseMessage Save_Data(MAS_REASON_Models.REASO_Data Input_data, string UI_STATE)
        {
            var ret = new ResponseMessage();
            BaseManagement Base = new BaseManagement();
            var conn = new DataContext();
            try
            {
                conn.Open();
                if (UI_STATE == Center.UI_STATE.UINew)
                {
                    //Input_data.TR_ID = new Doccument().Gendocno(conn, "PROD.TYPE.TRID", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());
                    
                    //if (Input_data.TR_ID == "")
                    //{
                    //    throw new Exception("Document cannot be created  Transaction ID  ! document configuration not found");
                    //}
                    //ถ้าไม่ใส่โค๊ดมาจะเข้าเคสนี้
                    if (Input_data.RSCODE == "")
                    {
                        Input_data.RSCODE = new Doccument().Gendocno(conn, "REASON", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());

                        if (Input_data.RSCODE == "")
                        {
                            throw new Exception("Document cannot be created  Product Type Code  ! document configuration not found");
                        }
                    }

                }
                else if (UI_STATE == Center.UI_STATE.UIEdit)
                {
                    
                }

                Save_H(conn, Input_data, UI_STATE);
                //Base._base.Commit();


                conn.Commit();

                ret.Respon.Result = true;
                ret.Respon.Result_value = Input_data.RSCODE;
                return ret;



                //return new Center().Error_Return("Data not found !", "");
            }
            catch (Exception e)
            {
                conn.Rollback();
                if (e.Message.ToString().Contains("PRIMARY KEY constraint"))
                {
                    return new Center().Error_Return("Duplicate Reason code", "");
                }
                else
                {
                    return new Center().Error_Return("", e.Message.ToString());
                }
            }
        }

        public bool Save_H(DataContext conn, MAS_REASON_Models.REASO_Data Input_data, string UI_STATE)
        {
            string query = "";
            if (UI_STATE == Center.UI_STATE.UINew)
            {
                string Listcol = "   RSCODE, RSNAME, DESCRIPTION, REMARK, ACTIVEFLAG, CDATE, CUSE, MDATE, MUSE, ISTAT";
                query = new Mybase().Insert(Input_data, Listcol);
            }
            else if (UI_STATE == Center.UI_STATE.UIEdit)
            {
                string Listcol = " RSNAME, DESCRIPTION, REMARK, ACTIVEFLAG, MDATE, MUSE, ISTAT";
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
                string str = " Update [MAS_REASON] set ISTAT = '0' where  ID = '" + ID + "' ";
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