using System;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
using TouchPOS_API.Helpers;

namespace TouchPOS_API.Service.MASTER
{
    public class MAS_Menu_Permis
    {
        #region "select"
        /// <summary>
        /// ใช้อ่านสิทธิ์ login
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public ResponseMessage Load_Menus_permis(string UID)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                string sql = "";
                sql = " SELECT ID, MNU_CODE, MNU_HSEQ, MNU_HNAME_1, MNU_HNAME_2, MNU_SSEQ, MNU_SNAME_1, MNU_SNAME_2, MNU_TAG, MNU_OBJ1, MNU_OBJ2, MNU_ICO, MNU_DEFAULT_DOCTYPE, U_DATE, U_ID, ISTAT FROM [MENU] " +
                    " where ISTAT = '1' " +
                    " and MNU_CODE in(select pd.MNU_CODE from PER_MIS p inner join PER_MIS_D pd on p.TR_ID = pd.TR_ID where p.[uid] = '"+ UID + "' and ISTAT ='1' and ACTIVEFLAG = 'A' and pd.M_AT = 1) " +
                    " order by [MNU_HSEQ],[MNU_SSEQ] ";
                var data = new DataContext().RunQuery<MAS_Menu_Permis_Models.Data_Menu>(sql);

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
                        return new Center().Error_Return("ไม่พบสิทธิ์ใช้งาน !", "");
                    }

                }
                else
                {
                    return new Center().Error_Return("ไม่พบสิทธิ์ใช้งาน !", "");
                }


            }
            catch (Exception e)
            {
                return new Center().Error_Return("", e.Message.ToString());
            }
            return ret;
        }
        public ResponseMessage Load_Menus(string val)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                string sql = "";
                sql = " SELECT ID, MNU_CODE, MNU_HSEQ, MNU_HNAME_1, MNU_HNAME_2, MNU_SSEQ, MNU_SNAME_1, MNU_SNAME_2, MNU_TAG, MNU_OBJ1, MNU_OBJ2, MNU_ICO, MNU_DEFAULT_DOCTYPE, U_DATE, U_ID, ISTAT FROM [MENU] where ISTAT = '1' order by [MNU_HSEQ],[MNU_SSEQ] ";
                var data = new DataContext().RunQuery<MAS_Menu_Permis_Models.Data_Menu>(sql);

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
        public ResponseMessage List_Data_CBO(string val)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                string sql = "";
                sql = " select TR_ID, PERMIS_CODE, PERMIS_NAME";
                sql += " from [PER_MIS] ";
                sql += " where ISTAT = '1' and ACTIVEFLAG = 'A'";
                sql += " order by PERMIS_CODE desc ";

                var data = new DataContext().RunQuery<MAS_Menu_Permis_Models.Data_List_CBO>(sql);

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
        public ResponseMessage List_Data(string CODE, string NAME, string UID, string Limit)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                string sql = "";
                sql = " select TOP " + Limit + " TR_ID, PERMIS_CODE,UID, PERMIS_NAME,UID,MDATE ";
                sql += " , (case when ACTIVEFLAG ='A' then 'Active' when ACTIVEFLAG ='C' then 'Not Active' end) as ACTIVEFLAG";
                sql += " from [PER_MIS] ";
                sql += " where ISTAT = '1'";
                if (CODE != null)
                {
                    sql += " and  PERMIS_CODE like '%" + CODE + "%' ";
                }
                if (NAME != null)
                {
                    sql += " and (  PERMIS_NAME like '%" + NAME + "%' ) ";
                }
                if (UID != null)
                {
                    sql += " and (  UID like '%" + UID + "%' ) ";
                }

                sql += " order by PERMIS_CODE desc ";

                var data = new DataContext().RunQuery<MAS_Menu_Permis_Models.Data_List>(sql);

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
        public ResponseMessage Select_Data(string TR_ID)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                string sql = "";
                sql = " select  ID, TR_ID, PERMIS_CODE, PERMIS_NAME,UID, DESCRIPTION, REMARK, ACTIVEFLAG, CDATE, CUSE, MDATE, MUSE, ISTAT ";
                sql += " from PER_MIS ";
                sql += " where ISTAT = '1'";
                sql += " and  TR_ID = '" + TR_ID + "' ";
                var data1 = new DataContext().RunQuery<MAS_Menu_Permis_Models.Data_PER_MIS>(sql);

                if (data1 != null)
                {
                    if (data1.Count > 0)
                    {

                        sql = " select TR_ID, PERMIS_CODE, SEQ, MNU_CODE, M_AT, BTN_ADD, BTN_EDIT, BTN_VIEW, BTN_DEL, REMARK  ";
                        sql += " from PER_MIS_D ";
                        sql += " where  TR_ID = '" + TR_ID + "' ";

                        var data2 = new DataContext().RunQuery<MAS_Menu_Permis_Models.Data_PER_MIS_D>(sql);

                        MAS_Menu_Permis_Models.PER_MIS_Save data_load = new MAS_Menu_Permis_Models.PER_MIS_Save();
                        data_load.Data_H = data1[0];
                        data_load.Data_ITEMS = data2;

                        ret.Data = data_load;
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

        public ResponseMessage Save_Data(MAS_Menu_Permis_Models.PER_MIS_Save Input_data, string UI_STATE)
        {
            var ret = new ResponseMessage();
            BaseManagement Base = new BaseManagement();
            var conn = new DataContext();
            try
            {
                conn.Open();
                if (UI_STATE == Center.UI_STATE.UINew)
                {
                    Input_data.Data_H.TR_ID = new Doccument().Gendocno(conn, "PERMIS.TRID", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());

                    if (Input_data.Data_H.TR_ID == "")
                    {
                        throw new Exception("Document cannot be created  Transaction ID  ! document configuration not found");
                    }
                    //ถ้าไม่ใส่โค๊ดมาจะเข้าเคสนี้
                    if (Input_data.Data_H.PERMIS_CODE == "")
                    {
                        Input_data.Data_H.PERMIS_CODE = new Doccument().Gendocno(conn, "PERMIS", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());
                        if (Input_data.Data_H.PERMIS_CODE == "")
                        {
                            throw new Exception("Document cannot be created  Permission Code  ! document configuration not found");
                        }
                    }

                }
                else if (UI_STATE == Center.UI_STATE.UIEdit)
                {

                }

                Save_H(conn, Input_data.Data_H, UI_STATE);
                Save_Items(conn, Input_data, UI_STATE);
                //Base._base.Commit();


                conn.Commit();

                ret.Respon.Result = true;
                ret.Respon.Result_value = Input_data.Data_H.PERMIS_CODE;
                return ret;



                //return new Center().Error_Return("Data not found !", "");
            }
            catch (Exception e)
            {
                conn.Rollback();
                if (e.Message.ToString().Contains("PRIMARY KEY constraint"))
                {
                    return new Center().Error_Return("Duplicate Permission code", "");
                }
                else
                {
                    return new Center().Error_Return("", e.Message.ToString());
                }
            }
        }

        public bool Save_H(DataContext conn, dynamic Input_data, string UI_STATE)
        {
            string query = "";
            if (UI_STATE == Center.UI_STATE.UINew)
            {
                string Listcol = "TR_ID, PERMIS_CODE, PERMIS_NAME,UID, DESCRIPTION, REMARK, ACTIVEFLAG, CDATE, CUSE, MDATE, MUSE, ISTAT";
                query = new Mybase().Insert(Input_data, Listcol);
            }
            else if (UI_STATE == Center.UI_STATE.UIEdit)
            {
                string Listcol = " PERMIS_CODE, PERMIS_NAME,UID, DESCRIPTION, REMARK, ACTIVEFLAG, MDATE, MUSE, ISTAT";
                query = new Mybase().Update(Input_data, Listcol);
                query += " where TR_ID = '" + Input_data.TR_ID + "'";
            }
            var a = conn.Excute(query);
            return true;
        }

        public bool Save_Items(DataContext conn, MAS_Menu_Permis_Models.PER_MIS_Save Input_data, string UI_STATE)
        {
            string query = "";

            if (UI_STATE == Center.UI_STATE.UIEdit)
            {
                query = new Mybase().Delete(Input_data.Data_ITEMS[0]);
                query += " where TR_ID = '" + Input_data.Data_H.TR_ID + "'";
                var a = conn.Excute(query);
            }
            foreach (MAS_Menu_Permis_Models.Data_PER_MIS_D val in Input_data.Data_ITEMS)
            {
                val.TR_ID = Input_data.Data_H.TR_ID;
                val.PERMIS_CODE = Input_data.Data_H.PERMIS_CODE;
                string Listcol = " TR_ID,PERMIS_CODE, SEQ, MNU_CODE, M_AT, BTN_ADD, BTN_EDIT, BTN_VIEW, BTN_DEL, REMARK ";
                query = new Mybase().Insert(val, Listcol);
                var a = conn.Excute(query);
            }


            return true;
        }


        public ResponseMessage Delete(string TR_ID)
        {
            var ret = new ResponseMessage();
            var con = new DataContext();

            try
            {
                string str = " Update PER_MIS set ISTAT = '0' where  TR_ID = '" + TR_ID + "' ";
                con.Excute2(str);

                ret.Respon.Result = true;
                ret.Respon.Result_value = TR_ID;
                return ret;
            }
            catch (Exception e)
            {

                if (e.Message.ToString().Contains("PRIMARY KEY constraint"))
                {
                    return new Center().Error_Return("Duplicate Product Color code", "");
                }
                else
                {
                    return new Center().Error_Return("", e.Message.ToString());
                }
            }
        }
        #endregion
    }
}