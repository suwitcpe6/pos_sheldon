using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
using TouchPOS_API.Helpers;
using System.Data;

//using TouchPOS_API.Service.Systems;
using System.Diagnostics;
using System.Web.Script.Serialization;
namespace TouchPOS_API.Service.Transaction
{

    public class TR_Movment
    {

        #region "Search"
        public ResponseMessage SCR_PRODUCT_chk_stock(Mas_Product_Model.Product_SCR value, string Limit)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {

                DataContext conn = new DataContext(DataContext.conselect.con2);
                string sql = "";
                sql = "SELECT TOP " + Limit + " p.[PCODE],p.[PNAME],p.PGCODE,pg.PGNAME,p.PTCODE,pt.PTNAME,P.COST_STD,p.UNITCODE,pu.UNITNAME";
                sql += " , (case when p.ACTIVEFLAG ='A' then 'Active' when p.ACTIVEFLAG ='C' then 'Not Active' end) as ACTIVEFLAG";
                sql += " FROM[dbo].[MAS_PRODUCT] p";
                sql += " left join MAS_PRODUCT_TYPE pt on pt.PTCODE = p.PTCODE ";
                sql += " left join MAS_PRODUCT_GROUP pg on pg.PGCODE = p.PGCODE ";
                sql += " left join MAS_PRODUCT_UNIT pu on pu.UNITCODE = p.UNITCODE ";
                sql += " where p.istat = '1' and pt.CHKSTOCK = '1'";

                if (value.PCODE != null && value.PCODE != "")
                {
                    sql += " and  p.PCODE like '%" + value.PCODE + "%' ";
                }
                if (value.PNAME != null && value.PNAME != "")
                {
                    sql += " and (  p.PNAME like '%" + value.PNAME + "%' ) ";
                }
                if (value.PGNAME != null && value.PGNAME != "")
                {
                    sql += " and (  pg.PGNAME like '%" + value.PGNAME + "%' ) ";
                }
                if (value.PTNAME != null && value.PTNAME != "")
                {
                    sql += " and (  pt.PTNAME like '%" + value.PTNAME + "%' ) ";
                }

                sql += " order by PCODE  ";


                var data = conn.RunQuery<Mas_Product_Model.Product_SCR>(sql);

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





        #region "select" 
        /// <summary>
        /// ใช้แสดงรายการข้อมูล ในหน้าลิส
        /// </summary>
        /// <param name="DOCTYPE"></param>
        /// <param name="DOCNO"></param>
        /// <param name="DOCDATE"></param>
        /// <param name="LOCID"></param>
        /// <param name="Limit"></param>
        /// <returns></returns>
        public ResponseMessage List_Data(string DOCTYPE, string DOCNO, string DOCDATE, string PERNAME, string STNAME, string Limit = Center.Limit)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                DataContext conn = new DataContext(DataContext.conselect.con2);
                string sql = " select top " + Limit + " h.TR_ID ,doc.DOCTYPENAME as DOCTYPE,h.DOCNO,h.DOCDATE,dcs.DOS_NAME as DCSTAT,h.REF_DOCNO,s.STNAME,h.TOTAL_QTY,h.PERNAME,h.MDATE " +
                            " from[MOVT]h left join MAS_DOC_STATUS dcs on dcs.DOS_ID = h.DCSTAT and h.DOCTYPE = dcs.DOS_GROUP " +
                            " left join MAS_STOCK s on s.STCODE = h.stcode " +
                            " left join MAS_DOCTYPE doc on doc.DOCTYPECODE = h.DOCTYPE " +
                            " where h.ISTAT = '1'  and h.[DOCTYPE]='" + DOCTYPE + "' and h.DAY_END = 'N'";
                if (DOCNO != null && DOCNO != "")
                {
                    sql += " and  h.DOCNO like '%" + DOCNO + "%' ";
                }

                if (DOCDATE != null && DOCDATE != "")
                {

                    DateTime d1;
                    try
                    {
                        d1 = Convert.ToDateTime(DOCDATE);
                    }
                    catch (Exception e)
                    {
                        return new Center().Error_Return("", "Incorrect date format");
                    }

                    sql += " and (  cast(h.DOCDATE as date) = '" + new Center().Condate(d1, "ymd2") + "' ) ";

                }
                if (PERNAME != null && PERNAME != "")
                {
                    sql += " and (  h.PERNAME like'%" + PERNAME + "%' ) ";
                }
                if (PERNAME != null && PERNAME != "")
                {
                    sql += " and (  s.STNAME like'%" + STNAME + "%' ) ";
                }

                sql += " order by h.TR_ID desc ";

                var data = conn.RunQuery<TR_Movment_Models.Data_List>(sql);

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
        /// <summary>
        /// แสดงผล UI
        /// </summary>
        /// <param name="TR_ID"></param>
        /// <returns></returns>
        public ResponseMessage Select_Data(string TR_ID)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                DataContext conn = new DataContext(DataContext.conselect.con2);
                string sql = "";
                sql = " select [ID], [TR_ID], [DOCTYPE], [DOCNO], [DOCDATE], [DOCYEAR], [DOCMONTH], [CORP_CODE], [Branch_CODE], [MOV_TYPE], [TOTAL_QTY], [TOTAL_AMOUNT], [REF_DOCNO], [REF_DOCTYPE], [LOT_ID], [STCODE], [REMARK1], [REMARK2], [REMARK3], [REMARK4], [REMARK5], [DESCRIPTION], [DCSTAT], [CDATE], [CUSE], [MDATE], [MUSE], [ISTAT], [PERCODE], [PERNAME], [DAY_END],YEAR ";
                sql += " from MOVT h ";
                sql += " where  h.TR_ID = '" + TR_ID + "' ";

                var data_H = conn.RunQuery<TR_Movment_Models.Data_MOVT>(sql);

                if (data_H != null)
                {
                    if (data_H.Count > 0)
                    {
                        sql = " select [TR_ID], [DOCTYPE], [DOCNO], d.[SEQ], d.[PCODE],  [PNAME], [QTY], [IDC], [UNIT_COST], d.[UNITCODE], [UNITNAME], [ST_QTY],ST_QTY2, [ST_COST], [ST_UNITCODE], [ST_UNITNAME], [TOTAL_COST], [REMARK1], [REMARK2], [REMARK3], [REMARK4], [REMARK5]";
                        sql += " from MOVT_D d left join MAS_PRODUCT_SED_UNIT u on d.pcode =u.pcode and d.UNITCODE =u.UNITCODE ";
                        sql += " where TR_ID = '" + TR_ID + "'";

                        var data_D = conn.RunQuery<TR_Movment_Models.Data_MOVT_D>(sql);
                        TR_Movment_Models.MOV_Save MOVdata = new TR_Movment_Models.MOV_Save();

                        MOVdata.Data_H = data_H[0];
                        MOVdata.Data_ITEMS = data_D;

                        ret.Data = MOVdata;
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

        /// <summary>
        /// ตรวจสอบ TagID ที่อยู่ LOCID ตามค่าที่ส่งมา
        /// </summary>
        /// <param name="LOCID"></param>
        /// <param name="TAGID"></param>
        /// <returns></returns>
        public ResponseMessage Check_Balance(string STCODE, string PCODE)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                //string sql = "";
                //sql = " select st.BD_ID, st.BDCODE, st.FL_ID, st.FLCODE, st.FR_ID, st.FRCODE, st.LOCID, st.LOT_ID, st.TAGID, st.PID, st.PCODE,p.PNAME, st.QTY,COST, st.UNITID, st.UNITCODE, st.UNITNAME, st.ISTAT ";
                //sql += " from[dbo].[V_MOV_BALANCE]st left join MAS_PRODUCT p on st.PID = p.tr_id ";
                //sql += " where  st.LOCID = '" + LOCID + "' ";
                //sql += " and  st.TAGID = '" + TAGID + "' ";
                //var data = new DataContext().RunQuery<TR_Movment_Models.MOV_BALANCE>(sql);
                //if (data != null)
                //{
                //    if (data.Count > 0)
                //    {
                //        ret.Data = data;
                //        ret.Respon.ErrorMessage = "";
                //        ret.Respon.Result = true;
                //        ret.Respon.SystemErrorMessage = "";
                //    }
                //    else
                //    {
                //        return new Center().Error_Return("Data not found !", "");
                //    }

                //}
                //else
                //{
                //    return new Center().Error_Return("Data not found !", "");
                //}


            }
            catch (Exception e)
            {
                return new Center().Error_Return("", e.Message.ToString());
            }
            return ret;
        }
        /// <summary>
        /// ตรวจสอบ TagID ที่อยู่ในรายการโอนออก
        /// </summary>
        /// <param name="TAGID"></param>
        /// <returns></returns>
        public ResponseMessage Check_WAIT_TI(string TAGID)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                string sql = "";
                sql = " select * from [V_SCR_TO] where 1=1";
                sql += " and  TAGID = '" + TAGID + "' ";

                var data = new DataContext().RunQuery<TR_Movment_Models.MOV_SCR_TO>(sql);
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
        /// <summary>
        /// List รายการที่อยู่ระหว่างรอรับโอน
        /// </summary>
        /// <param name="TAGID"></param>
        /// <returns></returns>
        public ResponseMessage Inquiry_WAIT_Tranfer(string TAGID, string DOCNO, string PCODE, String Limit)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                string sql = "";
                sql = " select top " + Limit + " * from [V_Inquiry_WAIT_Tranfer] where 1=1";

                if (TAGID != null && TAGID != "")
                {
                    sql += " and  TAGID like '%" + TAGID + "%' ";
                }
                if (DOCNO != null && DOCNO != "")
                {
                    sql += " and  DOCNO like '%" + DOCNO + "%' ";
                }
                if (PCODE != null && PCODE != "")
                {
                    sql += " and  PCODE like '%" + PCODE + "%' ";
                }

                var data = new DataContext().RunQuery<TR_Movment_Models.MOV_Inquiry_WAIT_Tranfer>(sql);
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
        /// <summary>
        /// ตรวจสอบ TagID ที่อยู่ในรายการโอนออก เพื่อซ่อม
        /// </summary>
        /// <param name="TAGID"></param>
        /// <returns></returns>



        #region "carry"

        public ResponseMessage Load_Data_YearEnd(string year)
        {
            //ConString1 db = new ConString1();FR_ID
            ResponseMessage ret = new ResponseMessage();
            var con = new DataContext();
            try
            {
                DataContext conn = new DataContext();

                string sql_check = " select TR_ID from MOVT where DOCTYPE  = 'MOV.YEND' and DCSTAT in( 'SUBMIT','DRAFT') and ISTAT ='1' and DOCYEAR = '" + year + "' ";
                DataTable dt = conn.ReadData_Table(sql_check);
                if (dt.Rows.Count > 0)
                {
                    return new Center().Error_Return("Documents have been completed in " + year + ". ! Doccument ID " + dt.Rows[0]["TR_ID"], "");
                }

                string sql = "";
                sql = " select  bl.PCODE,p.PNAME,bl.STCODE " +
                 "\n  ,sum(bl.ST_QTY * bl.IDC) as ST_QTY " +
                 "\n  ,1 as ST_QTY2 " +
                 "\n  ,cast(sum(bl.ST_COST) / (count(*)) as decimal(18,2)) ST_COST " +
                 "\n  ,bl.ST_UNITCODE " +
                 "\n  ,st_u.UNITNAME as ST_UNITNAME " +
                 "\n  ,cast((sum(bl.ST_COST) / (count(*))) * sum(bl.ST_QTY * bl.IDC)as decimal(18,2)) as TOTAL_COST " +
                 "\n  from[dbo].[MOV_BALANCE] bl " +
                 "\n  inner join MOVT m on m.TR_ID = bl.MOV_ID " +
                 "\n  left join MAS_PRODUCT p on  bl.PCODE = p.PCODE " +
                 "\n  left join MAS_PRODUCT_UNIT st_u on st_u.UNITCODE = bl.ST_UNITCODE " +
                 "\n  where m.DOCYEAR ='"+ year + "' and bl.ISTAT = '1' and bl.DCSTAT = 'SUBMIT' and bl.DAY_END = 'N' " +
                 "\n  group by   bl.PCODE,bl.ISTAT ,p.PNAME,bl.STCODE " +
                 "\n  ,st_u.UNITNAME " +
                 "\n  ,bl.ST_UNITCODE";


                var data = conn.RunQuery<TR_Movment_Models.Data_MOVT_D>(sql);
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
                        return new Center().Error_Return("Data not found!", "");
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
        #endregion


        #region "SAVE"
        public bool Save_Data_ADJ(DataContext conn, TR_Movment_Models.MOV_Save Input_data, string UI_STATE)
        {
            //var ret = new ResponseMessage();
            //BaseManagement Base = new BaseManagement();
            //try
            //{
            //    if (Input_data.Data_H.TR_ID == "")
            //    {
            //        Input_data.Data_H.TR_ID = new Doccument().Gendocno(conn, "MOV.TRID", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());

            //        if (Input_data.Data_H.TR_ID == "")
            //        {
            //            throw new Exception("Document cannot be created  Transaction ID  ! document configuration not found");
            //        }
            //    }


            //    if (Input_data.Data_H.DOCNO == "")
            //    {
            //        Input_data.Data_H.DOCNO = new Doccument().Gendocno(conn, Input_data.Data_H.DOCTYPE, DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());

            //        if (Input_data.Data_H.DOCNO == "")
            //        {
            //            throw new Exception("Document cannot be created  Document No  ! document configuration not found");
            //        }
            //    }

            //    List<TR_Movment_Models.Data_BALANCE> data = new List<TR_Movment_Models.Data_BALANCE>();

            //    if (Input_data.Data_H.DCSTAT == "SUBMIT")
            //    {
            //        data = Gent_Balance(conn, Input_data, UI_STATE);
            //        if (data.Count == 0)
            //        {
            //            throw new Exception(" Save Balance Not Found !");
            //        }
            //    }



            //    Input_data.Data_H.LOCID = Input_data.Data_ITEMS[0].LOCID;
            //    Input_data.Data_H.BD_ID = Input_data.Data_ITEMS[0].BD_ID;
            //    Input_data.Data_H.BDCODE = Input_data.Data_ITEMS[0].BDCODE;
            //    Input_data.Data_H.FL_ID = Input_data.Data_ITEMS[0].FL_ID;
            //    Input_data.Data_H.FLCODE = Input_data.Data_ITEMS[0].FLCODE;
            //    Input_data.Data_H.FR_ID = Input_data.Data_ITEMS[0].FR_ID;
            //    Input_data.Data_H.FRCODE = Input_data.Data_ITEMS[0].FRCODE;


            //    Save_H(conn, Input_data.Data_H, UI_STATE);
            //    Save_Items(conn, Input_data, UI_STATE);
            //    if (Input_data.Data_H.DCSTAT == "SUBMIT")
            //    {
            //        Save_Balance(conn, data, UI_STATE);
            //    }

            //    //return new Center().Error_Return("Data not found !", "");
            //}
            //catch (Exception e)
            //{
            //    throw e;
            //}
            return true;
        }
        public ResponseMessage check_data(TR_Movment_Models.MOV_Save Input_data)
        {
            var ret = new ResponseMessage();
            try
            {
                //string tagid = "";
                //string query = "";
                //var conn = new DataContext();
                //DataTable dt;
                //foreach (TR_Movment_Models.Data_MOVT_D val in Input_data.Data_ITEMS)
                //{
                //    tagid += val.TAGID + ",";
                //}


                //switch (Input_data.Data_H.DOCTYPE)
                //{
                //    case "MOV.REC":
                //        query = " SELECT[TAGID]  FROM [V_MOV_BALANCE] where TAGID in(SELECT * FROM[dbo].[SplitValueToTable]('" + tagid + "', ','))";
                //        dt = conn.ReadData_Table(query);
                //        if (dt.Rows.Count > 0)
                //        {
                //            ret.Respon.ErrorMessage = "Duplicate Tagid  ";
                //            foreach (DataRow drow in dt.Rows)
                //            {
                //                ret.Respon.ErrorMessage += drow["TAGID"] + " , ";
                //            }


                //            ret.Respon.Result = false;
                //            return ret;
                //        }
                //        break;
                //    case "MOV.TO":

                //        query = " SELECT[TAGID]  FROM [V_MOV_BALANCE] where TAGID in(SELECT * FROM[dbo].[SplitValueToTable]('" + tagid + "', ',')) and LOCID = '" + Input_data.Data_H.LOCID + "'";
                //        dt = conn.ReadData_Table(query);
                //        if (dt.Rows.Count <= 0)
                //        {
                //            ret.Respon.ErrorMessage = "Tagid not found !!   ";
                //            foreach (DataRow drow in dt.Rows)
                //            {
                //                ret.Respon.ErrorMessage += drow["TAGID"] + " , ";
                //            }


                //            ret.Respon.Result = false;
                //            return ret;
                //        }


                //        query = " select TAGID from [V_Inquiry_WAIT_Tranfer] where   TAGID in(SELECT * FROM[dbo].[SplitValueToTable]('" + tagid + "', ',')) and LOCID = '"+ Input_data.Data_H .LOCID  + "'";
                //        dt = conn.ReadData_Table(query);
                //        if (dt.Rows.Count > 0)
                //        {
                //            ret.Respon.ErrorMessage = "Tagid  is being transferred out. ";
                //            foreach (DataRow drow in dt.Rows)
                //            {
                //                ret.Respon.ErrorMessage += drow["TAGID"] + " , ";
                //            }

                //            ret.Respon.Result = false;
                //            return ret;
                //        }
                //        break;
                //    case "MOV.TI":
                //        query = " select TAGID from [V_Inquiry_WAIT_Tranfer] where   TAGID in(SELECT * FROM[dbo].[SplitValueToTable]('" + tagid + "', ',')) ";
                //        dt = conn.ReadData_Table(query);
                //        if (dt.Rows.Count != Input_data.Data_ITEMS.Count )
                //        {
                //            ret.Respon.ErrorMessage = "Data Receive incorrect !!!,Please check data ";
                //            //foreach (DataRow drow in dt.Rows)
                //            //{
                //            //    ret.Respon.ErrorMessage += drow["TAGID"] + " , ";
                //            //}

                //            ret.Respon.Result = false;
                //            return ret;
                //        }
                //        break;

                //    case "MOV.SALE":
                //        query = " SELECT[TAGID]  FROM [V_MOV_BALANCE] where TAGID in(SELECT * FROM[dbo].[SplitValueToTable]('" + tagid + "', ',')) and LOCID = '" + Input_data.Data_H.LOCID + "'";
                //        dt = conn.ReadData_Table(query);
                //        if (dt.Rows.Count <= 0)
                //        {
                //            ret.Respon.ErrorMessage = " Tagid not found !! ";
                //            //foreach (DataRow drow in dt.Rows)
                //            //{
                //            //    ret.Respon.ErrorMessage += drow["TAGID"] + " , ";
                //            //}
                //            ret.Respon.Result = false;
                //            return ret;
                //        }
                //        break;
                //    case "MOV.WD":
                //    default:
                //        throw new Exception("Doctype not found");
                //}

                ret.Respon.Result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }
        public ResponseMessage Save_Data_byPOS(DataContext conn, CardtranModels.SALE_INT Input_data, string UI_STATE)
        {

            var ret = new ResponseMessage();
            BaseManagement Base = new BaseManagement();
            try
            {


                //เช็ค stock   พี่สารัชบอกยังไม่ต้องเช็ค
                //เช็ค stock   พี่สารัชบอกยังไม่ต้องเช็ค
                //เช็ค stock   พี่สารัชบอกยังไม่ต้องเช็ค
                //เช็ค stock   พี่สารัชบอกยังไม่ต้องเช็ค
                //string pcode = "";
                //foreach (CardtranModels.Saleitems val in Input_data.Saleitems)
                //{
                //    if (pcode == "")
                //    {
                //        pcode = "'" + val.PCODE +"'";
                //    }
                //    else
                //    {
                //        pcode += ",'"+ val.PCODE + "'";
                //    }
                //}
                //DataTable dt = conn.ReadData_Table("  select ");


               string sql_chk = "  select docno from [dbo].[MOVT] where DOCNO = '" + Input_data.MRTSLIPNO  + "' and DOCTYPE =  'MOV.SALE'  and ISTAT = '1'  and DCSTAT = 'SUBMIT' ";

               DataTable  dt = conn.ReadData_Table(sql_chk);
                if (dt.Rows.Count > 0)
                {
                    throw new Exception("Duplicate sale docno");
                }





                if (conn.isopenconn == DataContext.conselect.con1) { conn.Excute("  USE [" + conn.DB_backup_name + "]  "); }

                TR_Movment_Models.MOV_Save MOV_data = new TR_Movment_Models.MOV_Save();
                string TR_ID = "";
                if (UI_STATE == Center.UI_STATE.UINew)
                {
                    Doccument docno = new Doccument();
                    if (TR_ID == "")
                    {
                        TR_ID = docno.Gendocno(conn, "MOV.TRID", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());

                        if (TR_ID == "")
                        {
                            throw new Exception("Document cannot be created  Transaction ID  ! document configuration not found");
                        }
                    }
                    //if (MOV_data.Data_H.DOCNO == "")
                    //{
                    //    MOV_data.Data_H.DOCNO = docno.Gendocno(conn, MOV_data.Data_H.DOCTYPE, DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());

                    //    if (MOV_data.Data_H.DOCNO == "")
                    //    {
                    //        throw new Exception("Document cannot be created  Document No  ! document configuration not found");
                    //    }
                    //}
                }


                MOV_data.Data_H = Gent_MOVT(Input_data, TR_ID);



                MOV_data.Data_ITEMS = Gent_Items(Input_data, TR_ID);
                if (MOV_data.Data_ITEMS.Count == 0)
                {
                    throw new Exception(" Save Items false !!");
                }
                MOV_data.Data_BALANCE = Gent_Balance(MOV_data, TR_ID);
                if (MOV_data.Data_BALANCE.Count == 0)
                {
                    throw new Exception(" Save Balance false !!");
                }



                Save_H(conn, MOV_data.Data_H, UI_STATE);
                Save_Items(conn, MOV_data, UI_STATE);
                Save_Balance(conn, MOV_data.Data_BALANCE, UI_STATE);
                ret.Respon.Result = true;
                return ret;



                //return new Center().Error_Return("Data not found !", "");
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {

            }
        }
        public ResponseMessage Save_Data_byPOS_Void(TR_Movment_Models.SALE_VOID value)
        {
            var ret = new ResponseMessage();
            BaseManagement Base = new BaseManagement();
            var conn = new DataContext(DataContext.conselect.con2);
            try
            {
                string saletype = "MOV.SALE";
                string voidtype = "MOV.VOID";

                string TR_ID = "";
                string saledocno = value.MRTSLIPNO;
                string docno = value.CREDITNOTE;
                string CUSE = value.UID;
                
                conn.Open(System.Data.IsolationLevel.ReadCommitted);


                string sql_chk = "  select REF_DOCNO from [dbo].[MOVT] where REF_DOCNO = '"+ saledocno + "' and REF_DOCTYPE =  '" + saletype + "'  and ISTAT = '1'  and DCSTAT = 'SUBMIT' ";

                DataTable dt = conn.ReadData_Table(sql_chk);
                if(dt.Rows.Count  > 0)
                {
                    return new Center().Error_Return("Cannot Void , Duplicate sale docno", "");
                    return ret;
                }

                 sql_chk = "  select docno from [dbo].[MOVT] where DOCNO = '" + saledocno + "' and DOCTYPE =  '" + saledocno + "'  and ISTAT = '1'  and DCSTAT = 'SUBMIT' ";

                 dt = conn.ReadData_Table(sql_chk);
                if (dt.Rows.Count > 0)
                {
                    return new Center().Error_Return("Cannot Void , Duplicate void docno", "");
                    return ret;
                }


                //ถ้าไม่พบ stock ให้ดีดออก  แต่ถ้ามีเอาข้อมูลไปใช้ได้
                sql_chk = "  select h.TR_ID from [MOVT]h  inner join MOVT_D d on h.TR_ID = d.TR_ID where h.DOCNO = '" + saledocno + "' and h.DOCTYPE =  '" + saletype + "'  and h.ISTAT = '1'  and h.DCSTAT = 'SUBMIT' ";
                dt = conn.ReadData_Table(sql_chk);
                if (dt.Rows.Count <= 0)
                {
                    ret.Respon.Result = true;
                    ret.Respon.ErrorMessage= "No stock";
                    return ret;
                }



                Doccument gendocno = new Doccument();
                if (TR_ID == "")
                {
                    TR_ID = gendocno.Gendocno(conn, "MOV.TRID", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());

                    if (TR_ID == "")
                    {
                        throw new Exception("Document cannot be created  Transaction ID  ! document configuration not found");
                    }
                }

               

                string sql_v = "";
                sql_v = " insert into MOVT ( [TR_ID], [DOCTYPE], [DOCNO], [DOCDATE], [DOCYEAR], [DOCMONTH], [CORP_CODE], [Branch_CODE], [MOV_TYPE], [TOTAL_QTY], [TOTAL_AMOUNT], [REF_DOCNO], [REF_DOCTYPE], [LOT_ID], [STCODE], [REMARK1], [REMARK2], [REMARK3], [REMARK4], [REMARK5], [DESCRIPTION], [DCSTAT], [CDATE], [CUSE], [MDATE], [MUSE], [ISTAT], [PERCODE], [PERNAME], [DAY_END]) " +
                "\n SELECT " +
                "'" + TR_ID + "'[TR_ID] " +
                ",'" + voidtype + "'[DOCTYPE] " +
                ",'" + docno + "'[DOCNO] " +
                ",getdate()[DOCDATE] " +
                ",YEAR(getdate())[DOCYEAR] " +
                ",MONTH(getdate())[DOCMONTH] " +
                ", [CORP_CODE], [Branch_CODE] " +
                ",'IN' [MOV_TYPE]" +
                ", [TOTAL_QTY], [TOTAL_AMOUNT]"+
                ",'"+ saledocno + "' [REF_DOCNO]"+
                ",'" + saletype + "' [REF_DOCTYPE]" +
                ", [LOT_ID], [STCODE], [REMARK1], [REMARK2], [REMARK3], [REMARK4], [REMARK5], [DESCRIPTION]" +
                ",'SUBMIT' [DCSTAT] " +
                ",getdate()[CDATE] " +
                ",'" + CUSE + "'[CUSE] " +
                ",getdate()[MDATE] " +
                ",'" + CUSE + "'[MUSE] " +
                ",'1' [ISTAT] " +
                ",'" + CUSE + "'[PERCODE] " +
                ",'" + CUSE + "'[PERNAME] " +
                ",'N'[DAY_END] " +
                "  FROM[MOVT] " +
                "  where TR_ID = '"+ dt.Rows[0]["TR_ID"] + "' ";


                sql_v += "\n insert into MOVT_D( [TR_ID], [DOCTYPE], [DOCNO], [SEQ], [PCODE], [PNAME], [QTY], [IDC], [UNIT_COST], [UNITCODE], [UNITNAME], [ST_QTY], [ST_QTY2], [ST_COST], [ST_UNITCODE], [ST_UNITNAME], [TOTAL_COST], [REMARK1], [REMARK2], [REMARK3], [REMARK4], [REMARK5] ) " +
                "\n select " +
                "'" + TR_ID + "'[TR_ID] " +
                ",'" + voidtype + "'[DOCTYPE] " +
                ",'" + docno + "'[DOCNO] " +
                ", [SEQ], [PCODE], [PNAME], [QTY],  " +
                "1[IDC] " +
                ", [UNIT_COST], [UNITCODE], [UNITNAME], [ST_QTY], [ST_QTY2], [ST_COST], [ST_UNITCODE], [ST_UNITNAME], [TOTAL_COST], [REMARK1], [REMARK2], [REMARK3], [REMARK4], [REMARK5] " +
                "  from[MOVT_D] " +
                "  where TR_ID = '" + dt.Rows[0]["TR_ID"] + "' ";

                sql_v += "\n insert into MOV_BALANCE ( [MOV_ID], [MOV_DOCNO], [MOV_DOCTYPE], [CORP_CODE], [Branch_CODE], [STCODE], [LOT_ID], [PCODE], [QTY], [IDC], [COST], [UNITCODE], [ST_QTY], [ST_COST], [ST_UNITCODE], [REMARK], [CDATE], [CUSE], [MDATE], [MUSE], [DCSTAT], [ISTAT], [DAY_END] ) " +
                "\n select " +
                "'" + TR_ID + "'[MOV_ID] " +
                ",'" + docno + "'[MOV_DOCNO] " +
                ",'" + voidtype + "'[MOV_DOCTYPE] " +
                ", [CORP_CODE], [Branch_CODE], [STCODE], [LOT_ID], [PCODE], [QTY],  " +
                " 1[IDC] " +
                ", [COST], [UNITCODE], [ST_QTY], [ST_COST], [ST_UNITCODE], [REMARK], " +
                "getdate()[CDATE]," +
                "'" + CUSE + "'[CUSE]" +
                ",getdate() [MDATE]," +
                "'" + CUSE + "'[MUSE]" +
                ",'SUBMIT' [DCSTAT]" +
                ",'1' [ISTAT],  " +
                "'N'[DAY_END] " +
                "from[MOV_BALANCE] " +
                 "  where MOV_ID = '" + dt.Rows[0]["TR_ID"] + "' ";


                sql_v += "\n update MOVT set [REF_DOCNO] ='" + docno + "', [REF_DOCTYPE]='" + voidtype + "'  " +
                      "  where TR_ID = '" + dt.Rows[0]["TR_ID"] + "' ";
                conn.Excute(sql_v);




                conn.Commit();

                ret.Respon.Result = true;
                ret.Respon.Result_value = "";
                ret.Respon.Result_value2 = "";
                ret.Respon.ErrorMessage = "sucess";
                return ret;



                //return new Center().Error_Return("Data not found !", "");
            }

            catch (Exception e)
            {
                conn.Rollback();
                if (e.Message.ToString().Contains("PRIMARY KEY constraint"))
                {
                    return new Center().Error_Return(" Duplicate docno", "");
                }
                else
                {
                    return new Center().Error_Return("", e.Message.ToString());
                }

            }
            finally
            {
                //try
                //{
                //    SYS_APILOG_Models.SYS_APILOG data_log = new SYS_APILOG_Models.SYS_APILOG();
                //    var st = new StackTrace();
                //    var sf = st.GetFrame(1);
                //    data_log.FUNC_NAME = sf.GetMethod().Name;
                //    data_log.ACTION = UI_STATE;
                //    data_log.TR_ID = Input_data.Data_H.TR_ID;
                //    data_log.DOCNO = Input_data.Data_H.DOCNO;
                //    data_log.DOCTYPE = Input_data.Data_H.DOCTYPE;
                //    data_log.DATA1 = new JavaScriptSerializer().Serialize(Input_data);
                //    data_log.DATA2 = new JavaScriptSerializer().Serialize(ret);
                //    data_log.CUSE = Input_data.Data_H.CUSE;
                //    data_log.MUSE = Input_data.Data_H.MUSE;
                //    var a = new API_Log().SAVE_Log(data_log);
                //}
                //catch (Exception ex)
                //{
                //}
            }

        }
        public ResponseMessage Save_Data(TR_Movment_Models.MOV_Save Input_data, string UI_STATE)
        {

            var ret = new ResponseMessage();
            BaseManagement Base = new BaseManagement();
            var conn = new DataContext(DataContext.conselect.con2);
            try
            {


                var ret_checkdata = new ResponseMessage();
                ret_checkdata = check_data(Input_data);
                if (ret_checkdata.Respon.Result == false)
                {
                    return ret_checkdata;
                }


                conn.Open(System.Data.IsolationLevel.ReadCommitted);
                if (UI_STATE == Center.UI_STATE.UINew)
                {
                    Doccument docno = new Doccument();
                    if (Input_data.Data_H.TR_ID == "")
                    {
                        Input_data.Data_H.TR_ID = docno.Gendocno(conn, "MOV.TRID", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());

                        if (Input_data.Data_H.TR_ID == "")
                        {
                            throw new Exception("Document cannot be created  Transaction ID  ! document configuration not found");
                        }
                    }

                    if (Input_data.Data_H.DCSTAT == "SUBMIT")
                    {
                        if (Input_data.Data_H.DOCNO == "")
                        {
                            Input_data.Data_H.DOCNO = docno.Gendocno(conn, Input_data.Data_H.DOCTYPE, DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());

                            if (Input_data.Data_H.DOCNO == "")
                            {
                                throw new Exception("Document cannot be created  Document No  ! document configuration not found");
                            }
                        }
                    }

                }
                else if (UI_STATE == Center.UI_STATE.UIEdit)
                {
                    if (Input_data.Data_H.DCSTAT == "SUBMIT")
                    {
                        if (Input_data.Data_H.DOCNO == "")
                        {
                            Input_data.Data_H.DOCNO = new Doccument().Gendocno(conn, Input_data.Data_H.DOCTYPE, DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());

                            if (Input_data.Data_H.DOCNO == "")
                            {
                                throw new Exception("Document cannot be created  Document No  ! document configuration not found");
                            }
                        }
                    }
                }
                List<TR_Movment_Models.Data_BALANCE> data = new List<TR_Movment_Models.Data_BALANCE>();

                if (Input_data.Data_H.DCSTAT == "SUBMIT")
                {
                    data = Gent_Balance(Input_data, UI_STATE);
                    if (data.Count == 0)
                    {
                        throw new Exception(" Save Balance Not Found !");
                    }
                }






                Save_H(conn, Input_data.Data_H, UI_STATE);
                Save_Items(conn, Input_data, UI_STATE);
                if (Input_data.Data_H.DCSTAT == "SUBMIT")
                {
                    Save_Balance(conn, data, UI_STATE);
                }
                conn.Commit();

                ret.Respon.Result = true;
                ret.Respon.Result_value = Input_data.Data_H.DOCNO;
                ret.Respon.Result_value2 = Input_data.Data_H.TR_ID;
                return ret;



                //return new Center().Error_Return("Data not found !", "");
            }

            catch (Exception e)
            {
                conn.Rollback();
                if (e.Message.ToString().Contains("PRIMARY KEY constraint"))
                {
                    return new Center().Error_Return("Duplicate Data", "");
                }
                else
                {
                    return new Center().Error_Return("", e.Message.ToString());
                }

            }
            finally
            {
                //try
                //{
                //    SYS_APILOG_Models.SYS_APILOG data_log = new SYS_APILOG_Models.SYS_APILOG();
                //    var st = new StackTrace();
                //    var sf = st.GetFrame(1);
                //    data_log.FUNC_NAME = sf.GetMethod().Name;
                //    data_log.ACTION = UI_STATE;
                //    data_log.TR_ID = Input_data.Data_H.TR_ID;
                //    data_log.DOCNO = Input_data.Data_H.DOCNO;
                //    data_log.DOCTYPE = Input_data.Data_H.DOCTYPE;
                //    data_log.DATA1 = new JavaScriptSerializer().Serialize(Input_data);
                //    data_log.DATA2 = new JavaScriptSerializer().Serialize(ret);
                //    data_log.CUSE = Input_data.Data_H.CUSE;
                //    data_log.MUSE = Input_data.Data_H.MUSE;
                //    var a = new API_Log().SAVE_Log(data_log);
                //}
                //catch (Exception ex)
                //{
                //}
            }
        }
        public ResponseMessage Save_Data_YearEnd(TR_Movment_Models.MOV_Save Input_data, string UI_STATE)
        {
            var ret = new ResponseMessage();
            BaseManagement Base = new BaseManagement();
            var conn = new DataContext();
            try
            {
                conn.Open();
                if (UI_STATE == Center.UI_STATE.UINew)
                {
                    //ถ้ามีอยู่แล้วปิดซ้ำไม่ได้
                    string sql_check = " select TR_ID from MOVT where DOCTYPE  = 'MOV.YEND' and DCSTAT in( 'SUBMIT','DRAFT') and ISTAT ='1' and DOCYEAR = '" + Input_data.Data_H.DOCYEAR + "' ";
                    DataTable dt = conn.ReadData_Table(sql_check);
                    if (dt.Rows.Count > 0)
                    {
                        return new Center().Error_Return("Documents have been completed in " + Input_data.Data_H.DAY_END + ". ! Doccument ID " + dt.Rows[0]["TR_ID"], "");
                    }


                    if (Input_data.Data_H.TR_ID == "")
                    {
                        Input_data.Data_H.TR_ID = new Doccument().Gendocno(conn, "MOV.TRID", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());

                        if (Input_data.Data_H.TR_ID == "")
                        {
                            throw new Exception("Document cannot be created  Transaction ID  ! document configuration not found");
                        }
                    }

                    if (Input_data.Data_H.DCSTAT == "SUBMIT")
                    {
                        if (Input_data.Data_H.DOCNO == "")
                        {
                            Input_data.Data_H.DOCNO = new Doccument().Gendocno(conn, Input_data.Data_H.DOCTYPE, DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());

                            if (Input_data.Data_H.DOCNO == "")
                            {
                                throw new Exception("Document cannot be created  Document No  ! document configuration not found");
                            }
                        }
                    }

                }
                else if (UI_STATE == Center.UI_STATE.UIEdit)
                {
                    if (Input_data.Data_H.DCSTAT == "SUBMIT")
                    {
                        if (Input_data.Data_H.DOCNO == "")
                        {
                            Input_data.Data_H.DOCNO = new Doccument().Gendocno(conn, Input_data.Data_H.DOCTYPE, DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());

                            if (Input_data.Data_H.DOCNO == "")
                            {
                                throw new Exception("Document cannot be created  Document No  ! document configuration not found");
                            }
                        }
                    }
                }
                List<TR_Movment_Models.Data_BALANCE> data = new List<TR_Movment_Models.Data_BALANCE>();

                if (Input_data.Data_H.DCSTAT == "SUBMIT")
                {
                    data = Gent_Balance( Input_data, UI_STATE);
                    if (data.Count == 0)
                    {
                        throw new Exception(" Save Balance Not Found !");
                    }
                }

                Save_H(conn, Input_data.Data_H, UI_STATE);
                Save_Items(conn, Input_data, UI_STATE);
                if (Input_data.Data_H.DCSTAT == "SUBMIT")
                {
                    Save_Balance(conn, data, UI_STATE);
                    Clear_year_end(conn, Input_data.Data_H.TR_ID, Input_data.Data_H.YEAR , UI_STATE);

                }
                conn.Commit();

                ret.Respon.Result = true;
                ret.Respon.Result_value = Input_data.Data_H.DOCNO;
                ret.Respon.Result_value2 = Input_data.Data_H.TR_ID;
                return ret;



                //return new Center().Error_Return("Data not found !", "");
            }
            catch (Exception e)
            {
                conn.Rollback();
                if (e.Message.ToString().Contains("PRIMARY KEY constraint"))
                {
                    return new Center().Error_Return("Duplicate Data", "");
                }
                else
                {
                    return new Center().Error_Return("", e.Message.ToString());
                }

            }
            finally
            {
                //try
                //{
                //    SYS_APILOG_Models.SYS_APILOG data_log = new SYS_APILOG_Models.SYS_APILOG();
                //    var st = new StackTrace();
                //    var sf = st.GetFrame(1);
                //    data_log.FUNC_NAME = sf.GetMethod().Name;
                //    data_log.ACTION = UI_STATE;
                //    data_log.TR_ID = Input_data.Data_H.TR_ID;
                //    data_log.DOCNO = Input_data.Data_H.DOCNO;
                //    data_log.DOCTYPE = Input_data.Data_H.DOCTYPE;
                //    data_log.DATA1 = new JavaScriptSerializer().Serialize(Input_data);
                //    data_log.DATA2 = new JavaScriptSerializer().Serialize(ret);
                //    data_log.CUSE = Input_data.Data_H.CUSE;
                //    data_log.MUSE = Input_data.Data_H.MUSE;
                //    var a = new API_Log().SAVE_Log(data_log);
                //}
                //catch (Exception ex)
                //{
                //}
            }
        }

        public bool Save_H(DataContext conn, dynamic Input_data, string UI_STATE)
        {
            // ถ้าเป็นเคสซิงค์ cdDATE ต้องส่งมา ไม่อย่างนั้นรายงาน movment ผิด
            // ถ้าเป็นเคสซิงค์ cdDATE ต้องส่งมา ไม่อย่างนั้นรายงาน movment ผิด
            // ถ้าเป็นเคสซิงค์ cdDATE ต้องส่งมา ไม่อย่างนั้นรายงาน movment ผิด
            // ถ้าเป็นเคสซิงค์ cdDATE ต้องส่งมา ไม่อย่างนั้นรายงาน movment ผิด
            // ถ้าเป็นเคสซิงค์ cdDATE ต้องส่งมา ไม่อย่างนั้นรายงาน movment ผิด
            // ถ้าเป็นเคสซิงค์ cdDATE ต้องส่งมา ไม่อย่างนั้นรายงาน movment ผิด
            // ถ้าเป็นเคสซิงค์ cdDATE ต้องส่งมา ไม่อย่างนั้นรายงาน movment ผิด
            // ถ้าเป็นเคสซิงค์ cdDATE ต้องส่งมา ไม่อย่างนั้นรายงาน movment ผิด
            // ถ้าเป็นเคสซิงค์ cdDATE ต้องส่งมา ไม่อย่างนั้นรายงาน movment ผิด
            // ถ้าเป็นเคสซิงค์ cdDATE ต้องส่งมา ไม่อย่างนั้นรายงาน movment ผิด
            // ถ้าเป็นเคสซิงค์ cdDATE ต้องส่งมา ไม่อย่างนั้นรายงาน movment ผิด
            string query = "";
            if (UI_STATE == Center.UI_STATE.UINew)
            {
                string Listcol = " [TR_ID], [DOCTYPE], [DOCNO], [DOCDATE], [DOCYEAR], [DOCMONTH], [CORP_CODE], [Branch_CODE], [MOV_TYPE], [TOTAL_QTY], [TOTAL_AMOUNT], [REF_DOCNO], [REF_DOCTYPE], [LOT_ID], [STCODE], [REMARK1], [REMARK2], [REMARK3], [REMARK4], [REMARK5], [DESCRIPTION], [DCSTAT], [CDATE], [CUSE], [MDATE], [MUSE], [ISTAT], [PERCODE], [PERNAME], [DAY_END],YEAR";
                //if (conn.isopenconn == DataContext.conselect.con1) { query = "  USE [" + conn.DB_backup_name + "]  "; }
                query = new Mybase().Insert(Input_data, Listcol);
            }
            else if (UI_STATE == Center.UI_STATE.UIEdit)
            {
                string Listcol = "   [DOCNO],[CORP_CODE], [Branch_CODE], [MOV_TYPE], [TOTAL_QTY], [TOTAL_AMOUNT], [REF_DOCNO], [REF_DOCTYPE], [LOT_ID], [STCODE], [REMARK1], [REMARK2], [REMARK3], [REMARK4], [REMARK5], [DESCRIPTION], [DCSTAT], [CDATE], [CUSE], [MDATE], [MUSE], [ISTAT], [PERCODE], [PERNAME], [DAY_END],YEAR";
                //if (conn.isopenconn == DataContext.conselect.con1) { query = "  USE [" + conn.DB_backup_name + "]  "; }
                query = new Mybase().Update(Input_data, Listcol);
                query += " where TR_ID = '" + Input_data.TR_ID + "'";
            }
            var a = conn.Excute(query);
            return true;
        }
        public bool Save_Items(DataContext conn, TR_Movment_Models.MOV_Save Input_data, string UI_STATE)
        {
            string query = "";

            if (UI_STATE == Center.UI_STATE.UIEdit)
            {
                query = new Mybase().Delete(Input_data.Data_ITEMS[0]);
                query += " where TR_ID = '" + Input_data.Data_H.TR_ID + "'";
                conn.Excute(query);

            }
            foreach (TR_Movment_Models.Data_MOVT_D val in Input_data.Data_ITEMS)
            {
                val.TR_ID = Input_data.Data_H.TR_ID;
                val.DOCNO = Input_data.Data_H.DOCNO;
            }

            List<string> Listquery = new List<string>();
            string Listcol = " [TR_ID], [DOCTYPE], [DOCNO], [SEQ], [PCODE], [PNAME], [QTY], [IDC], [UNIT_COST], [UNITCODE], [UNITNAME], [ST_QTY],[ST_QTY2], [ST_COST], [ST_UNITCODE],[ST_UNITNAME], [TOTAL_COST], [REMARK1], [REMARK2], [REMARK3], [REMARK4], [REMARK5]";
            Listquery = new Mybase().Insert_Multivalue(Input_data.Data_ITEMS, Listcol);
            foreach (string val in Listquery)
            {
                //string Itemsquery = "";
                //if (conn.isopenconn == DataContext.conselect.con1) { Itemsquery = "  USE [" + conn.DB_backup_name + "]  "; }
                //Itemsquery += val ;
                conn.Excute(val);
            }

            //foreach (TR_Movment_Models.Data_MOVT_D val in Input_data.Data_ITEMS)
            //{
            //    val.TR_ID = Input_data.Data_H.TR_ID;
            //    val.DOCNO = Input_data.Data_H.DOCNO;
            //    string Listcol = " [TR_ID], [DOCTYPE], [DOCNO], [SEQ], [PCODE], [PNAME], [QTY], [IDC], [UNIT_COST], [UNITCODE], [ST_QTY], [ST_COST], [ST_UNITCODE], [TOTAL_COST], [REMARK1], [REMARK2], [REMARK3], [REMARK4], [REMARK5]";
            //    query = new Mybase().Insert(val, Listcol);
            //    var a = conn.Excute(query);
            //}


            return true;
        }
        public bool Save_Balance(DataContext conn, List<TR_Movment_Models.Data_BALANCE> data, string UI_STATE)
        {
            string query = "";

            if (UI_STATE == Center.UI_STATE.UIEdit)
            {
                query = new Mybase().Delete(data[0]);
                query += " where MOV_ID = '" + data[0].MOV_ID + "'";
                conn.Excute(query);
            }
            List<string> Listquery = new List<string>();
            string Listcol = " [MOV_ID], [MOV_DOCNO], [MOV_DOCTYPE], [CORP_CODE], [Branch_CODE], [STCODE], [LOT_ID], [PCODE], [QTY], [IDC], [COST], [UNITCODE], [ST_QTY], [ST_IDC], [ST_COST], [ST_UNITCODE], [REMARK], [CDATE], [CUSE], [MDATE], [MUSE], [DCSTAT], [ISTAT],DAY_END";
            Listquery = new Mybase().Insert_Multivalue(data, Listcol);
            foreach (string val in Listquery)
            {
                //string Itemsquery = "";
                ////if (conn.isopenconn == DataContext.conselect.con1) { Itemsquery = "  USE [" + conn.DB_backup_name + "]  "; }
                //Itemsquery += val;
                conn.Excute(val);
            }


            //foreach (TR_Movment_Models.Data_BALANCE val in data)
            //{
            //    string Listcol = "TID, MOV_ID, MOV_DOCNO, MOV_DOCTYPE, CORP_ID, CORP_CODE, Branch_ID, Branch_CODE, BD_ID, BDCODE, FL_ID, FLCODE, FR_ID, FRCODE, LOCID, LOT_ID, TAGID, PID, PCODE, QTY, IDC, COST, UNITID, UNITCODE, UNITNAME, REMARK, CDATE, CUSE, MDATE, MUSE, ISTAT,PER_ID,PERCODE,PERNAME";
            //    query = new Mybase().Insert(val, Listcol);
            //    var a = conn.Excute(query);
            //}

            return true;
        }


        public TR_Movment_Models.Data_MOVT Gent_MOVT(CardtranModels.SALE_INT Input_data, string TR_ID)
        {
            TR_Movment_Models.Data_MOVT data = new TR_Movment_Models.Data_MOVT();


            data.ID = 0;
            data.TR_ID = TR_ID;
            data.DOCTYPE = "MOV.SALE";
            data.DOCNO = Input_data.MRTSLIPNO;
            data.DOCDATE = new WorkingdateCL().Getdate().Date_now ;// Input_data.DOCDATE;
            data.DOCYEAR = Input_data.DOCDATE.Year.ToString();
            data.DOCMONTH = Input_data.DOCDATE.Month.ToString();
            data.CORP_CODE = Input_data.CorpBRNID;
            data.Branch_CODE = Input_data.CorpBRNID;
            data.MOV_TYPE = "OUT";
            data.TOTAL_QTY = Input_data.QTY_TOTAL;
            data.TOTAL_AMOUNT = Input_data.NETAMOUNT;
            data.REF_DOCNO = Input_data.TAXINVOICE;
            if (Input_data.TAXINVOICE == "")
            {
                data.REF_DOCTYPE = "";
            }
            else
            {
                data.REF_DOCTYPE = "TENDER";
            }


            data.LOT_ID = "";
            data.STCODE = Input_data.STCODE;
            data.REMARK1 = "";
            data.REMARK2 = "";
            data.REMARK3 = "";
            data.REMARK4 = "";
            data.REMARK5 = "";
            data.DESCRIPTION = "";
            data.DCSTAT = "SUBMIT";
            data.CDATE = DateTime.Now;
            data.CUSE = Input_data.CBY;
            data.MDATE = DateTime.Now;
            data.MUSE = Input_data.MBY;
            data.ISTAT = "1";
            data.PERCODE = Input_data.CBY;
            data.PERNAME = Input_data.CBY;
            data.DAY_END = "N";


            return data;
        }
        public List<TR_Movment_Models.Data_MOVT_D> Gent_Items(CardtranModels.SALE_INT Input_data, string TR_ID)
        {
            List<TR_Movment_Models.Data_MOVT_D> data = new List<TR_Movment_Models.Data_MOVT_D>();
            TR_Movment_Models.Data_MOVT_D val_items = new TR_Movment_Models.Data_MOVT_D();


            foreach (CardtranModels.Saleitems val in Input_data.Saleitems)
            {
                val_items = new TR_Movment_Models.Data_MOVT_D();

                val_items.TR_ID = TR_ID;
                val_items.DOCTYPE = "MOV.SALE";
                val_items.DOCNO = Input_data.MRTSLIPNO;
                val_items.SEQ = val.SEQ;
                val_items.PCODE = val.PCODE;
                val_items.PNAME = val.PNAME;
                val_items.QTY = val.QTY;
                val_items.IDC = -1;

                val_items.UNIT_COST = 0;// val.ITEMS_PRICE; เอาออก ทำให้ต้นทุนเฉลี่ยผิด ถ้าอยากดูต้องตูที่รายงานขาย

                val_items.UNITCODE = val.UNITCODE;
                val_items.UNITNAME = val.UNITNAME;

                val_items.ST_QTY = val.QTY;
                val_items.ST_QTY2 = 1;
                val_items.ST_COST = val.ITEMS_PRICE;

                val_items.ST_UNITCODE = val.UNITCODE;
                val_items.ST_UNITNAME = val.UNITNAME;

                val_items.TOTAL_COST = val.ITEMS_PRICE;
                val_items.REMARK1 = "";
                val_items.REMARK2 = "";
                val_items.REMARK3 = "";
                val_items.REMARK4 = "";
                val_items.REMARK5 = "";



                data.Add(val_items);
            }
            return data;
        }
        public List<TR_Movment_Models.Data_BALANCE> Gent_Balance(TR_Movment_Models.MOV_Save Input_data, string TR_ID)
        {
            List<TR_Movment_Models.Data_BALANCE> data = new List<TR_Movment_Models.Data_BALANCE>();
            TR_Movment_Models.Data_BALANCE val_items = new TR_Movment_Models.Data_BALANCE();


            foreach (TR_Movment_Models.Data_MOVT_D val in Input_data.Data_ITEMS)
            {
                val_items = new TR_Movment_Models.Data_BALANCE();



                val_items.ID = 0;
                val_items.MOV_ID = Input_data.Data_H.TR_ID;
                val_items.MOV_DOCNO = Input_data.Data_H.DOCNO;
                val_items.MOV_DOCTYPE = val.DOCTYPE;
                val_items.CORP_CODE = Input_data.Data_H.CORP_CODE;
                val_items.Branch_CODE = Input_data.Data_H.Branch_CODE;

                val_items.LOT_ID = Input_data.Data_H.LOT_ID;
                val_items.STCODE = Input_data.Data_H.STCODE;
                val_items.PCODE = val.PCODE;
                val_items.QTY = val.QTY;
                val_items.ST_QTY = val.ST_QTY;
                val_items.IDC = val.IDC;
                val_items.COST = val.UNIT_COST;
                val_items.ST_COST = val.ST_COST;
                val_items.UNITCODE = val.UNITCODE;
                val_items.ST_UNITCODE = val.ST_UNITCODE;
                val_items.REMARK = val.REMARK1;
                val_items.CDATE = DateTime.Now;
                val_items.CUSE = Input_data.Data_H.CUSE;
                val_items.MDATE = DateTime.Now;
                val_items.MUSE = Input_data.Data_H.MUSE;



                val_items.DCSTAT = Input_data.Data_H.DCSTAT;
                val_items.ISTAT = Input_data.Data_H.ISTAT;

                val_items.DAY_END = Input_data.Data_H.DAY_END;

                data.Add(val_items);
            }
            return data;
        }


        public bool Clear_year_end(DataContext conn, string TR_ID , string DOCYEAR, string UI_STATE)
        {
            Sql_check check = new Sql_check();
            string query = "";


            query = " update MOV_BALANCE set DAY_END = 'Y' where  MOV_ID in( select TR_ID from MOVT where  DOCYEAR ='" + DOCYEAR + "' and TR_ID <> '"+ TR_ID + "')  ";
            query += check.ROWCOUNT(check.update, "MOV_BALANCE");
            query += " update MOVT set  DAY_END = 'Y' where  DOCYEAR ='" + DOCYEAR + "'  and TR_ID <> '" + TR_ID + "'";
            query += check.ROWCOUNT(check.update, "MOVT");

            //query += " update ADJ set  ISTAT = 'YE' where  DOCYEAR ='" + YEAR_END + "' ";
            //query += check.ROWCOUNT(check.update, "ADJ");

            //query += " update SC set  ISTAT = 'YE' where  DOCYEAR ='" + YEAR_END + "' ";
            //query += check.ROWCOUNT(check.update, "SC");

            var a = conn.Excute(query);
            return true;
        }


        public ResponseMessage Delete(string TR_ID)
        {
            var ret = new ResponseMessage();
            var con = new DataContext();

            try
            {
                string str = " Update MOVT set ISTAT = '0' where  TR_ID = '" + TR_ID + "' ";
                con.Excute2(str);

                ret.Respon.Result = true;
                ret.Respon.Result_value = TR_ID;
                return ret;
            }
            catch (Exception e)
            {

                if (e.Message.ToString().Contains("PRIMARY KEY constraint"))
                {
                    return new Center().Error_Return("Duplicate Data", "");
                }
                else
                {
                    return new Center().Error_Return("", e.Message.ToString());
                }
            }
        }
        public ResponseMessage Cancel(TR_Movment_Models.Data_List data)
        {
            Sql_check check = new Sql_check();
            var ret = new ResponseMessage();
            var con = new DataContext(DataContext.conselect.con2);
            try
            {
                if (data.DCSTAT != "DRAFT")
                {
                    switch (data.DOCTYPE)
                    {
                        case "MOV.REC":
                            ret = Chk_MOV_REC(data.TR_ID, data.DOCTYPE);
                            if (ret.Respon.Result == false)
                            {
                                return ret;
                            }
                            break;
                        case "MOV.TO":
                            ret = Chk_MOV_TO(data.TR_ID, data.DOCTYPE);
                            if (ret.Respon.Result == false)
                            {
                                return ret;
                            }
                            break;
                        case "MOV.TI":
                            ret = Chk_MOV_REC(data.TR_ID, data.DOCTYPE);
                            if (ret.Respon.Result == false)
                            {
                                return ret;
                            }
                            break;

                        case "MOV.SALE":
                            ret = Chk_MOV_Day(data.TR_ID, data.DOCTYPE);
                            if (ret.Respon.Result == false)
                            {
                                return ret;
                            }
                            break;
                        case "MOV.ISSUE":
                            ret = Chk_MOV_Day(data.TR_ID, data.DOCTYPE);
                            if (ret.Respon.Result == false)
                            {
                                return ret;
                            }
                            break;
                        case "MOV.YEB":
                            //ret = Chk_MOV_Day(TR_ID, DOCTYPE);
                            //if (ret.Respon.Result == false)
                            //{
                            //    return ret;
                            //}
                            break;
                        default:
                            throw new Exception("Doctype not found");
                    }
                }
                string str = "";
                //if (DOCTYPE == "MOV.YEB")
                //{
                //    str = " Update MOVT set DCSTAT = 'CANCEL' where  TR_ID = '" + TR_ID + "' ";
                //    str += " Update MOV_BALANCE set ISTAT = 'C' where  MOV_ID = '" + TR_ID + "' ";


                //    str += " update MOV_BALANCE set ISTAT = '1' where  MOV_ID in( select TR_ID from MOVT where  DOCYEAR =(select top 1 YEAR_END from MOVT where TR_ID = '" + TR_ID + "') and MOV_DOCTYPE <> 'MOV.YEB')";
                //    str += check.ROWCOUNT(check.update, "MOV_BALANCE");
                //    str += " update MOVT set  ISTAT = '1' where  DOCYEAR =(select top 1 YEAR_END from MOVT where TR_ID = '" + TR_ID + "') and DOCTYPE <> 'MOV.YEB' ";
                //    str += check.ROWCOUNT(check.update, "MOVT");

                //    str += " update ADJ set  ISTAT = '1' where  DOCYEAR =(select top 1 YEAR_END from MOVT where TR_ID = '" + TR_ID + "') ";
                //    str += check.ROWCOUNT(check.update, "ADJ");

                //    str += " update SC set  ISTAT = '1' where  DOCYEAR =(select top 1 YEAR_END from MOVT where TR_ID = '" + TR_ID + "') ";
                //    str += check.ROWCOUNT(check.update, "SC");


                //    con.Excute2(str);
                //}
                //else
                //{




                //ถ้าปิดสิ้นวันแล้วจะแก้ไขไม่ได้ได้ ต้องทำเอกสารใหม่อย่างเดียว
                str = " Update MOVT set DCSTAT = 'CANCEL' where  TR_ID = '" + data.TR_ID + "' and DAY_END = 'N' ";
                str += " Update MOV_BALANCE set DCSTAT = 'CANCEL' where  MOV_ID = '" + data.TR_ID + "' and DAY_END = 'N'  ";
                con.Excute2(str);
                //}


                ret.Respon.Result = true;
                ret.Respon.Result_value = data.TR_ID;
                ret.Respon.ErrorMessage = "SUCCESS";
                ret.Data = "SUCCESS";

                return ret;
            }
            catch (Exception e)
            {
                return new Center().Error_Return("", e.Message.ToString());
            }
            finally
            {
                //try
                //{
                //    SYS_APILOG_Models.SYS_APILOG data_log = new SYS_APILOG_Models.SYS_APILOG();
                //    var st = new StackTrace();
                //    var sf = st.GetFrame(1);
                //    data_log.FUNC_NAME = sf.GetMethod().Name;
                //    data_log.ACTION = Center.UI_STATE.UIEdit;
                //    data_log.TR_ID = TR_ID;
                //    data_log.DOCNO = "";
                //    data_log.DOCTYPE = DOCTYPE;
                //    data_log.DATA1 = "";
                //    data_log.DATA2 = new JavaScriptSerializer().Serialize(ret);
                //    data_log.CUSE = "";
                //    data_log.MUSE = "";
                //    var a = new API_Log().SAVE_Log(data_log);
                //}
                //catch (Exception ex)
                //{
                //}
            }
        }
        #endregion


        #region "method"
        public ResponseMessage Chk_MOV_REC(string TR_ID, string DOCTYPE)
        {
            var ret = new ResponseMessage();
            var con = new DataContext(DataContext.conselect.con2);
            try
            {
                string str_chk = " ";
                str_chk = "  select m.TR_ID,md.PCODE,md.ST_QTY ,bl.ST_QTY " +
                            " from[MOVT] m inner join[MOVT_D] md on m.TR_ID = md.TR_ID " +
                            " left join V_MOV_BALANCE bl on bl.STCODE = m.STCODE and bl.PCODE = md.PCODE " +
                            " where m.TR_ID = '" + TR_ID + "'  and md.ST_QTY < bl.ST_QTY";

                DataTable dt = con.ReadData_Table(str_chk);
                if (dt.Rows.Count <= 0)
                {
                    ret.Respon.Result = true;
                    ret.Respon.Result_value = TR_ID;
                }
                else
                {
                    ret.Respon.Result = false;
                    ret.Respon.Result_value = TR_ID;

                    ret.Respon.ErrorMessage = "สินค้าไม่พอยกเลิก  ";//+ " The document cannot be canceled.  " + mg;      
                    foreach (DataRow drow in dt.Rows)
                    {
                        ret.Respon.ErrorMessage += "\n " + drow["STCODE"];//+ " The document cannot be canceled.  " + mg;      
                    }
                }
            }

            catch (Exception e)
            {
                throw e;
            }
            return ret;
        }
        public ResponseMessage Chk_MOV_TO(string TR_ID, string DOCTYPE)
        {
            var ret = new ResponseMessage();
            var con = new DataContext();
            try
            {
                string str_chk = " ";
                str_chk = " select TIh.DOCNO,TIh.DOCTYPE,TId.REF_DOCNO,TId.REF_DOCTYPE ,TId.SEQ,TId.PID,TId.PCODE,TId.TAGID ";
                str_chk += " from MOVT TIh inner ";
                str_chk += " join MOVT_D TId on TIh.TR_ID = TId.TR_ID ";
                str_chk += " where TIh.ISTAT = '1' and TIh.DCSTAT = 'SUBMIT' and TIh.DOCTYPE = 'MOV.TI' ";
                str_chk += " and TId.REF_DOCNO in(select top 1 DOCNO from MOVT where TR_ID = '" + TR_ID + "' and DCSTAT = 'SUBMIT' and ISTAT = '1') ";
                str_chk += " and TId.REF_DOCTYPE = 'MOV.TO'";

                DataTable dt = con.ReadData_Table(str_chk);
                if (dt.Rows.Count <= 0)
                {
                    ret.Respon.Result = true;
                    ret.Respon.Result_value = TR_ID;
                }
                else
                {
                    //string mg = "";
                    //foreach (DataRow drow in dt.Rows)
                    //{
                    //    mg += drow["TAGID"] + ", ";
                    //}
                    ret.Respon.Result = false;
                    ret.Respon.Result_value = TR_ID;
                    ret.Respon.ErrorMessage = " The document cannot be canceled. Reference document";
                }
            }

            catch (Exception e)
            {
                throw e;
            }
            return ret;
        }
        public ResponseMessage Chk_MOV_RPI(string TR_ID, string DOCTYPE)
        {
            var ret = new ResponseMessage();
            var con = new DataContext();
            try
            {
                string str_chk = " ";
                str_chk = " select TIh.DOCNO,TIh.DOCTYPE,TId.REF_DOCNO,TId.REF_DOCTYPE ,TId.SEQ,TId.PID,TId.PCODE,TId.TAGID ";
                str_chk += " from MOVT TIh inner ";
                str_chk += " join MOVT_D TId on TIh.TR_ID = TId.TR_ID ";
                str_chk += " where TIh.ISTAT = '1' and TIh.DCSTAT = 'SUBMIT' and TIh.DOCTYPE = 'MOV.RPR' ";
                str_chk += " and TId.REF_DOCNO in(select top 1 DOCNO from MOVT where TR_ID = '" + TR_ID + "' and DCSTAT = 'SUBMIT' and ISTAT = '1') ";
                str_chk += " and TId.REF_DOCTYPE = 'MOV.RPI'";

                DataTable dt = con.ReadData_Table(str_chk);
                if (dt.Rows.Count <= 0)
                {
                    ret.Respon.Result = true;
                    ret.Respon.Result_value = TR_ID;
                }
                else
                {
                    //string mg = "";
                    //foreach (DataRow drow in dt.Rows)
                    //{
                    //    mg += drow["TAGID"] + ", ";
                    //}
                    ret.Respon.Result = false;
                    ret.Respon.Result_value = TR_ID;
                    ret.Respon.ErrorMessage = " The document cannot be canceled. Reference document";
                }
            }

            catch (Exception e)
            {
                throw e;
            }
            return ret;
        }

        public ResponseMessage Chk_MOV_Day(string TR_ID, string DOCTYPE)
        {
            var ret = new ResponseMessage();
            var con = new DataContext();
            try
            {
                string str_chk = " ";
                str_chk = " select  DOCTYPE,DOCNO,cast(DOCDATE as date)DOCDATE,cast (getdate()as date) as date_now   ";
                str_chk += " from MOVT  ";
                str_chk += "where TR_ID= '" + TR_ID + "' and DOCTYPE ='" + DOCTYPE + "'";
                DataTable dt = con.ReadData_Table(str_chk);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["DOCDATE"].ToString() == dt.Rows[0]["date_now"].ToString())
                    {
                        ret.Respon.Result = true;
                        ret.Respon.Result_value = dt.Rows[0]["DOCNO"].ToString();
                    }
                    else
                    {
                        ret.Respon.Result = false;
                        ret.Respon.Result_value = TR_ID;
                        ret.Respon.ErrorMessage = "Cannot cancel documents across the day. Cancel documents false !";//+ " The document cannot be canceled.  " + mg;        
                    }
                }
                else
                {
                    ret.Respon.Result = false;
                    ret.Respon.Result_value = TR_ID;
                    ret.Respon.ErrorMessage = "Cancel data false !";//+ " The document cannot be canceled.  " + mg;                    
                }
            }

            catch (Exception e)
            {
                throw e;
            }
            return ret;
        }

        #endregion
    }
}