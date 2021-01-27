using System;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
using TouchPOS_API.Helpers;
using System.Collections.Generic;
using System.Data;

namespace TouchPOS_API.Service.MASTER
{
    public class Mas_Product
    {
        #region "Search Popup"

       
        #endregion
        #region "select"
        public ResponseMessage PRODUCT_List(string PCODE, string PNAME, string PGNAME, string PTNAME, string Limit)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {

                DataContext conn = new DataContext(DataContext.conselect.con2);
                string sql = "";
                sql = "SELECT TOP " + Limit + " p.[ID],p.[PCODE],p.[PNAME],p.PGCODE,pg.PGNAME,p.PTCODE,pT.PTNAME,P.MDATE";
                sql += " , (case when p.ACTIVEFLAG ='A' then 'Active' when p.ACTIVEFLAG ='C' then 'Not Active' end) as ACTIVEFLAG";
                sql += " FROM[dbo].[MAS_PRODUCT] p";
                sql += " left join MAS_PRODUCT_TYPE pt on pt.PTCODE = p.PTCODE ";
                sql += " left join MAS_PRODUCT_GROUP pg on pg.PGCODE = p.PGCODE ";
                sql += " where p.istat = '1'";

                if (PCODE != null)
                {
                    sql += " and  p.PCODE like '%" + PCODE + "%' ";
                }
                if (PNAME != null)
                {
                    sql += " and (  p.PNAME like '%" + PNAME + "%' ) ";
                }
                if (PGNAME != null)
                {
                    sql += " and (  pg.PGNAME like '%" + PGNAME + "%' ) ";
                }
                if (PTNAME != null)
                {
                    sql += " and (  pt.PTNAME like '%" + PTNAME + "%' ) ";
                }

                sql += " order by id desc ";


                var data = conn.RunQuery<Mas_Product_Model.Product_List>(sql);

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
        public ResponseMessage PRODUCT_Select(string ID)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                DataContext conn = new DataContext(DataContext.conselect.con2);
                string sql = "";
                sql = "SELECT [ID], [PCODE], [PNAME], [PGCODE], [UNITCODE],COST_STD, [ACTIVEFLAG], [DESCRIPTION], [REMARK], [CDATE], [CUSE], [MDATE], [MUSE], [ISTAT], PRICE_STD,PTCODE";
                sql += " FROM[dbo].[MAS_PRODUCT] p";
                sql += " where p.istat = '1' and id = '" + ID + "'";

                var data = conn.RunQuery<Mas_Product_Model.Product>(sql);

                if (data != null)
                {
                    if (data.Count > 0)
                    {

                        sql = "  select [SEQ], [PCODE], su.[UNITCODE],u.UNITNAME, [QTY_MAIN], [QTY_SED] from MAS_PRODUCT_SED_UNIT su left join MAS_PRODUCT_UNIT u on u.UNITCODE =su.UNITCODE  where PCODE = '" + data[0].PCODE + "' order by SEQ";
                        var data2 = conn.RunQuery<Mas_Product_Model.MAS_PRODUCT_SED_UNIT>(sql);

                        Mas_Product_Model.Product_data ret_data = new Mas_Product_Model.Product_data();
                        ret_data.Product = data[0];
                        ret_data.PRODUCT_SED_UNIT = data2;

                        ret.Data = ret_data;
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

        #region "import excells"
        public ResponseMessage Save_Data_Excell(List<Mas_Product_Model.TMP_IMP_PRODUCT> Input_data, string UI_STATE)
        {
            var ret = new ResponseMessage();
            BaseManagement Base = new BaseManagement();
            var conn = new DataContext(DataContext.conselect.con2);
            try
            {
                var ret_tmp = Save_TMP(Input_data);
                if (ret_tmp.Respon.Result == false)
                {
                    return ret_tmp;
                }
                var chk_data = Excell_Check_Data(Input_data);
                if (chk_data.Respon.Result == false)
                {
                    return chk_data;
                }

                conn.Open();
                object obj = conn.Excute_Scalar("[Import_Product] '" + Input_data[0].CUSE + "'");
                switch (obj.ToString())
                {
                    case "-1":
                        conn.Rollback();
                        ret.Respon.Result = false;
                        ret.Respon.ErrorMessage = "Import Not Success, Error stored procedure Import_Product. !!!";
                        return ret;
                    case "-2":
                        conn.Rollback();
                        ret.Respon.Result = false;
                        ret.Respon.ErrorMessage = "RunID Not Found !!!";
                        return ret;
                    default:
                        break;
                }

                conn.Commit();

                ret.Respon.Result = true;
                ret.Respon.Result_value = obj.ToString();
                return ret;



                //return new Center().Error_Return("Data not found !", "");
            }
            catch (Exception e)
            {

                conn.Rollback();

                //if (e.Message.ToString().Contains("PRIMARY KEY constraint"))
                //{
                //    return new Center().Error_Return("Duplicate Asset code", "");
                //}
                //else
                //{
                return new Center().Error_Return("", e.Message.ToString());
                //}
            }
        }
        public ResponseMessage Save_TMP(dynamic Input_data)
        {
            var conn = new DataContext();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                string Delete = "";
                List<string> Listquery = new List<string>();
                Delete = new Mybase().Delete(Input_data[0]);

                string Listcol = "SEQ, RUN_ID, PCODE, PNAME, DESCRIPTION, IMG_NAME, PTCODE, PTNAME, PGCODE, PGNAME, PGSCODE, PGSNAME, BRANDCODE, BRANDNAME, MODEL, COLORCODE, COLORNAME, UNITCODE, UNITNAME, PACKCODE, PACKNAME, AGE, NUM_OWD, DEPCT, PRICESTD, WEIGHT, Remark, CUSE, CDATE ";
                Listquery = new Mybase().Insert_Multivalue(Input_data, Listcol);
                conn.Open();
                conn.Excute(Delete);
                foreach (string val in Listquery)
                {
                    conn.Excute(val);
                }
                conn.Commit();

                ret.Respon.Result = true;
            }
            catch (Exception e)
            {
                conn.Rollback();
                ret = new Center().Error_Return("", e.Message.ToString());
            }
            return ret;
        }
        public ResponseMessage Excell_Check_Data(List<Mas_Product_Model.TMP_IMP_PRODUCT> Input_data)
        {
            ResponseMessage ret = new ResponseMessage();
            try
            {
                var conn = new DataContext();
                string query = "";
                DataTable dt;



                query = " select pcode from TMP_IMP_PRODUCT where pcode in(select pcode from MAS_PRODUCT) ";//ถ้ามีต้องฟ้องรหัสซ้ำ
                dt = conn.ReadData_Table(query);
                if (dt.Rows.Count > 0)
                {
                    ret.Respon.Result = false;
                    ret.Respon.ErrorMessage = "Duplicate Asset code, please check below. ";
                    foreach (DataRow drow in dt.Rows)
                    {
                        ret.Respon.ErrorMessage += "#-  " + drow["pcode"].ToString();
                    }
                    return ret;
                }





                //query = "select distinct tmp.PTCODE,tmp.PTNAME from TMP_IMP_PRODUCT tmp  ";
                //query += " where not exists( ";
                //query += " select pt.PTCODE from MAS_PRODUCT_TYPE pt where pt.PTNAME = tmp.PTNAME ";
                //query += " and pt.ISTAT = '1' and pt.ACTIVEFLAG = 'A' ";
                //query += " )";

                //dt = conn.ReadData_Table(query);
                //if (dt.Rows.Count > 0)
                //{

                //    string pname_error="";

                //    MAS_PRODUCT_TYPE PT = new MAS_PRODUCT_TYPE();
                //    MAS_PRODUCT_TYPE_Models.PRODUCT_TYPE_Data  PT_DATA;

                //    foreach (DataRow drow in dt.Rows)
                //    {


                //        PT_DATA = new MAS_PRODUCT_TYPE_Models.PRODUCT_TYPE_Data();
                //        PT_DATA.ID = 0;
                //        PT_DATA.TR_ID = "";
                //        PT_DATA.PTCODE = drow["PTCODE"].ToString();


                //        PT_DATA.ID = 0;
                //        PT_DATA.TR_ID ="";
                //        PT_DATA.PTCODE = drow["PTCODE"].ToString();
                //        PT_DATA.PTNAME = drow["PTNAME"].ToString();
                //        PT_DATA.DESCRIPTION = "";
                //        PT_DATA.REMARK = "";
                //        PT_DATA.ACTIVEFLAG = "A";
                //        PT_DATA.CDATE = DateTime .Now;
                //        PT_DATA.CUSE = Input_data[0].CUSE;
                //        PT_DATA.MDATE = DateTime.Now;
                //        PT_DATA.MUSE = Input_data[0].CUSE;
                //        PT_DATA.ISTAT = "1";

                //        PT = new MAS_PRODUCT_TYPE();
                //       if ( PT.Save_Data(PT_DATA, "UINew").Respon .Result ==false)
                //        {
                //            pname_error += "#-  " + drow["PTNAME"].ToString();
                //        }
                //    }
                //    if (pname_error != "")
                //    {
                //        ret.Respon.Result = false;
                //        ret.Respon.ErrorMessage = " Asset Type Not found !!!, please check below. ";
                //        ret.Respon.ErrorMessage += pname_error;
                //    }else
                //    { ret.Respon.Result = true; }
                //    PT = null;
                //    PT_DATA = null;
                //    return ret;
                //}








                query = "select distinct tmp.PGCODE,tmp.PGNAME from TMP_IMP_PRODUCT tmp  ";
                query += " where not exists( ";
                query += " select pg.PGCODE from MAS_PRODUCT_GROUP pg where pg.PGNAME = tmp.PGNAME ";
                query += " and pg.ISTAT = '1' and pg.ACTIVEFLAG = 'A' ";
                query += " )";


                dt = conn.ReadData_Table(query);
                if (dt.Rows.Count > 0)
                {
                    ret.Respon.Result = false;
                    ret.Respon.ErrorMessage = " Asset Group Not found !!!, please check below. ";
                    foreach (DataRow drow in dt.Rows)
                    {
                        ret.Respon.ErrorMessage += "#-  " + drow["PGNAME"].ToString();
                    }
                    return ret;
                }



                //query = " select distinct tmp.PGSCODE,tmp.PGSNAME from TMP_IMP_PRODUCT tmp  ";
                //query += " where not exists( ";
                //query += " select pgs.PGSCODE from MAS_PRODUCT_GROUP_SUB pgs where pgs.PGSNAME = tmp.PGSNAME ";
                //query += " and pgs.ISTAT = '1' and pgs.ACTIVEFLAG = 'A' ";
                //query += " )";

                //dt = conn.ReadData_Table(query);
                //if (dt.Rows.Count > 0)
                //{
                //    ret.Respon.Result = false;
                //    ret.Respon.ErrorMessage = " Asset Sub Group Not found !!!, please check below. ";
                //    foreach (DataRow drow in dt.Rows)
                //    {
                //        ret.Respon.ErrorMessage += "#-  " + drow["PGSNAME"].ToString();
                //    }
                //    return ret;
                //}


                //query = "select distinct tmp.BRANDCODE,tmp.BRANDNAME from TMP_IMP_PRODUCT tmp  ";
                //query += " where not exists( ";
                //query += " select pb.BRANDCODE from MAS_PRODUCT_BRAND pb where pb.BRANDNAME = tmp.BRANDNAME ";
                //query += " and pb.ISTAT = '1' and pb.ACTIVEFLAG = 'A' ";
                //query += " )";

                //dt = conn.ReadData_Table(query);
                //if (dt.Rows.Count > 0)
                //{
                //    ret.Respon.Result = false;
                //    ret.Respon.ErrorMessage = " Brand Not found !!!, please check below. ";
                //    foreach (DataRow drow in dt.Rows)
                //    {
                //        ret.Respon.ErrorMessage += "#-  " + drow["BRANDNAME"].ToString();
                //    }
                //    return ret;
                //}



                query = "  select distinct tmp.UNITCODE,tmp.UNITNAME from TMP_IMP_PRODUCT tmp ";
                query += " where not exists( ";
                query += " select pu.UNITCODE from MAS_PRODUCT_UNIT pu where pu.UNITNAME = tmp.UNITNAME ";
                query += " and pu.ISTAT = '1' and pu.ACTIVEFLAG = 'A' ";
                query += " )";

                dt = conn.ReadData_Table(query);
                if (dt.Rows.Count > 0)
                {
                    ret.Respon.Result = false;
                    ret.Respon.ErrorMessage = " Unit Not found !!!, please check below. ";
                    foreach (DataRow drow in dt.Rows)
                    {
                        ret.Respon.ErrorMessage += "#-  " + drow["UNITNAME"].ToString();
                    }
                    return ret;
                }
                ret.Respon.Result = true;
            }
            catch (Exception e)
            {

                ret = new Center().Error_Return("", e.Message.ToString());

            }
            return ret;
        }
        #endregion 

        public ResponseMessage Save_Data(Mas_Product_Model.Product_data Input_data, string UI_STATE)
        {
            var ret = new ResponseMessage();
            BaseManagement Base = new BaseManagement();
            var conn = new DataContext(DataContext.conselect.con2);
            try
            {


                string sql_chk = "  select pcode from mas_product where pcode = '"+ Input_data.Product.PCODE + "' and istat ='0'";

                DataTable dt = conn.ReadData_Table(sql_chk);
                if (dt.Rows.Count > 0)
                {
                    return new Center().Error_Return("Duplicate Productcode", "");
                }





                conn.Open();
                if (UI_STATE == Center.UI_STATE.UINew)
                {
                    //Input_data.TR_ID = new Doccument().Gendocno(conn, "PROD.TRID", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());

                    //if (Input_data.TR_ID == "")
                    //{
                    //    throw new Exception("Document cannot be created  Transaction ID  ! document configuration not found");
                    //}
                    //ถ้าไม่ใส่โค๊ดมาจะเข้าเคสนี้
                    if (Input_data.Product.PCODE == "")
                    {

                        Input_data.Product.PCODE = new Doccument().Gendocno(conn, "PROD", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());

                        if (Input_data.Product.PCODE == "")
                        {
                            throw new Exception("Document cannot be created  Product Code  ! document configuration not found");
                        }
                    }

                }
                else if (UI_STATE == Center.UI_STATE.UIEdit)
                {

                }

                Save_H(conn, Input_data.Product, UI_STATE);
                Mas_Product_Model.SHOPBUTTONS SHOPBUTTONS_data = Gendata_Shopbutton(conn, Input_data, UI_STATE);
                Save_Shopbutton(conn, SHOPBUTTONS_data, UI_STATE);

                if (Input_data.PRODUCT_SED_UNIT.Count > 0)
                {
                    Save_Unit_Items(conn, Input_data.PRODUCT_SED_UNIT, UI_STATE);
                }
                //Base._base.Commit();


                conn.Commit();

                ret.Respon.Result = true;
                ret.Respon.Result_value = Input_data.Product.PCODE;
                return ret;



                //return new Center().Error_Return("Data not found !", "");
            }
            catch (Exception e)
            {
                conn.Rollback();
                if (e.Message.ToString().Contains("PRIMARY KEY constraint"))
                {
                    return new Center().Error_Return("Duplicate Procduct code", "");
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
                string Listcol = " PCODE,PCODE2, PNAME, PGCODE, UNITCODE,COST_STD, ACTIVEFLAG, DESCRIPTION, REMARK, CDATE, CUSE, MDATE, MUSE, ISTAT , PRICE_STD,PTCODE ";
                query = " delete " + new Mybase().GetTable(Input_data) + " where pcode = '" + Input_data.PCODE + "'  ";
                query += new Mybase().Insert(Input_data, Listcol);
            }
            else if (UI_STATE == Center.UI_STATE.UIEdit)
            {
                string Listcol = " PNAME, PGCODE, UNITCODE,COST_STD, ACTIVEFLAG, DESCRIPTION, REMARK, CDATE, CUSE, MDATE, MUSE, ISTAT, PRICE_STD,PTCODE";
                query = new Mybase().Update(Input_data, Listcol);
                query += " where ID = '" + Input_data.ID + "'";
            }
            var a = conn.Excute(query);
            return true;
        }
        public ResponseMessage Save_Unit_Items(DataContext conn, dynamic Input_data, string UI_STATE)
        {

            ResponseMessage ret = new ResponseMessage();
        
                string Delete = "";
                List<string> Listquery = new List<string>();

                string Listcol = " SEQ, PCODE, UNITCODE, QTY_MAIN, QTY_SED ";
                Listquery = new Mybase().Insert_Multivalue(Input_data, Listcol);
                //if (UI_STATE == Center.UI_STATE.UIEdit)
                //{
                    Delete = new Mybase().Delete(Input_data[0]);
                Delete += " where PCODE = '" + Input_data[0].PCODE + "'";
                    conn.Excute(Delete);
                //}

               
                foreach (string val in Listquery)
                {
                    conn.Excute(val);
                }
                
                ret.Respon.Result = true;
    
            return ret;
        }
        public Mas_Product_Model.SHOPBUTTONS Gendata_Shopbutton(DataContext conn, Mas_Product_Model.Product_data Input_data, string UI_STATE)
        {

            Mas_Product_Model.SHOPBUTTONS SHOPBUTTONS = new Mas_Product_Model.SHOPBUTTONS();
            SHOPBUTTONS.barcode = Input_data.Product.PCODE;
            DataTable dt = new DataTable();
            string query = "";
            //if (UI_STATE == Center.UI_STATE.UINew)
            //{
                query = "   select top 1 [POSID],[SHOPID] from SHOPS order by SHOPID desc ";
                dt = conn.ReadData_Table(query);
                if (dt.Rows.Count < 0) {
                    throw new Exception(" SHOPS Datanot found !!");
                }
            //}
            

           

            SHOPBUTTONS.SHOPID = (int) dt.Rows [0]["SHOPID"];
            SHOPBUTTONS.POSID = dt.Rows[0]["POSID"].ToString ();
            SHOPBUTTONS.BTNID = 0;
            SHOPBUTTONS.BTNGROUP = Input_data.Product.PGNAME;
            SHOPBUTTONS.BTNNAME = Input_data.Product.PNAME;
            SHOPBUTTONS.BTNPRICE = Input_data.Product.PRICE_STD;
            SHOPBUTTONS.LUPDATE = DateTime .Now ;
            SHOPBUTTONS.barcode = Input_data.Product.PCODE;
            SHOPBUTTONS.flagSt = "";
            //SHOPBUTTONS.pic1 = Input_data.Product.PCODE;
            //SHOPBUTTONS.pic2 = 0;
            SHOPBUTTONS.cost = 0; //Input_data.Product.COST_STD; ส่ง 0 ไปก่อน
            SHOPBUTTONS.MenuTypeID = Input_data.Product.PTCODE;
            if (Input_data.Product.ACTIVEFLAG == "A")
            {
                SHOPBUTTONS.flg = 1;
            }
            else
            {
                SHOPBUTTONS.flg = 0;
            }
          


            return SHOPBUTTONS;
        }
        public bool Save_Shopbutton(DataContext conn, dynamic Input_data, string UI_STATE)
        {

            string query = "";
            if (UI_STATE == Center.UI_STATE.UINew)
            {
                string Listcol = " [SHOPID], [POSID], [BTNGROUP], [BTNNAME], [BTNPRICE], [LUPDATE], [barcode], [flagSt],[cost], [MenuTypeID], [flg] ";
                query = " delete " + new Mybase().GetTable(Input_data) + " where barcode = '" + Input_data.barcode + "'  ";
                query += new Mybase().Insert(Input_data, Listcol);
            }
            else if (UI_STATE == Center.UI_STATE.UIEdit)
            {
                string Listcol = " [SHOPID], [POSID], [BTNGROUP], [BTNNAME], [BTNPRICE], [LUPDATE], [barcode], [flagSt], [cost], [MenuTypeID], [flg] ";
                query = new Mybase().Update(Input_data, Listcol);
                query += " where [barcode]= '" + Input_data.barcode + "'";
            }
            var a = conn.Excute(query);
            return true;
        }

        public ResponseMessage Delete(string PCODE)
        {
            var ret = new ResponseMessage();
            var con = new DataContext();

            try
            {
                string str = " Update MAS_PRODUCT set ISTAT = '0' where  PCODE = '" + PCODE + "' ";
                con.Excute2(str);

                ret.Respon.Result = true;
                ret.Respon.Result_value = PCODE;
                return ret;
            }
            catch (Exception e)
            {

                if (e.Message.ToString().Contains("PRIMARY KEY constraint"))
                {
                    return new Center().Error_Return("Duplicate Product code", "");
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