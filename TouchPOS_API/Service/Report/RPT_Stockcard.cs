using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;

namespace TouchPOS_API.Service.Report
{
    public class RPT_Stockcard
    {
        #region "select"

        public ResponseMessage Stockcard(RPT_StockcardModels.Fillter_Stockcard val, string UI_STATE)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {
                DataContext conn = new DataContext(DataContext.conselect.con2);
                string sql = "";
                string SqlBeg_balance = "";


                sql = " select h.TR_ID,doc.DOCTYPENAME as DOCTYPE,h.DOCNO,h.DOCDATE,h.MOV_TYPE,h.STCODE ,st.STNAME,h.PERCODE,h.PERNAME " +
                    " ,d.PCODE,d.PNAME,d.ST_QTY " +
                    " ,(case when d.IDC  >0 then d.ST_QTY else 0 end) as QTY_IN " +
                    " ,(case when d.IDC  <0 then d.ST_QTY else 0 end) as QTY_OUT " +
                    " ,d.ST_UNITCODE,d.ST_UNITNAME,d.IDC " +
                    " from[MOVT] h inner join MOVT_D d on h.TR_ID = d.TR_ID " +
                    " left join MAS_STOCK st on st.STCODE = h.STCODE " +
                    " left join MAS_DOCTYPE doc on doc.DOCTYPECODE = h.DOCTYPE " +
                    " where h.ISTAT = '1' and h.DCSTAT = 'SUBMIT'  and h.DAY_END = 'N'";


                if (val.Date_Start != null && val.Date_Start != "")
                {
                    DateTime d1;
                    DateTime d2;
                    try
                    {
                        d1 = Convert.ToDateTime(val.Date_Start);
                        d2 = Convert.ToDateTime(val.Date_End);
                    }
                    catch (Exception e)
                    {
                        return new Center().Error_Return("", "Incorrect date format");
                    }

                    //sql += " and  (  cast(h.DOCDATE as date) between  '" + new Center().Condate(d1, "ymd2") + "' and  '" + new Center().Condate(d2, "ymd2") + "' ) ";
                    sql += " and  (  cast(h.DOCDATE as date) >=  '" + new Center().Condate(d1, "ymd2") + "' ) ";
                    sql += " and  (  cast(h.DOCDATE as date) <=  '" + new Center().Condate(d2, "ymd2") + "' ) ";

                }
                if (val.STCODE != null && val.STCODE != "")
                {
                    sql += " and  h.stcode = '" + val.STCODE + "' ";
                }
                if ((val.PCODE1 != null && val.PCODE1 != "") && (val.PCODE2 != null && val.PCODE2 != ""))
                {
                    sql += " and d.[PCODE] between '" + val.PCODE1 + "' and '" + val.PCODE2 + "' ";
                }
                sql += " order by h.STCODE,d.PCODE, h.DOCDATE,h.TR_ID";



                // คำนวนยอดยกมา // คำนวนยอดยกมา // คำนวนยอดยกมา // คำนวนยอดยกมา // คำนวนยอดยกมา // คำนวนยอดยกมา
                // คำนวนยอดยกมา // คำนวนยอดยกมา // คำนวนยอดยกมา // คำนวนยอดยกมา // คำนวนยอดยกมา // คำนวนยอดยกมา
                SqlBeg_balance = " select h.STCODE " +
                    " ,d.PCODE,sum(d.ST_QTY*d.IDC) as BEG_ST_QTY " +
                    " from[MOVT] h inner join MOVT_D d on h.TR_ID = d.TR_ID " +
                    " where h.ISTAT = '1' and h.DCSTAT = 'SUBMIT'";


                if (val.Date_Start != null && val.Date_Start != "")
                {
                    DateTime d1;
                    try
                    {
                        d1 = Convert.ToDateTime(val.Date_Start);
                    }
                    catch (Exception e)
                    {
                        return new Center().Error_Return("", "Incorrect date format");
                    }
                    SqlBeg_balance += " and  (  cast(h.DOCDATE as date) <  '" + new Center().Condate(d1, "ymd2") + "' ) ";

                }
                if (val.STCODE != null && val.STCODE != "")
                {
                    SqlBeg_balance += " and  h.stcode = '" + val.STCODE + "' ";
                }
                if ((val.PCODE1 != null && val.PCODE1 != "") && (val.PCODE2 != null && val.PCODE2 != ""))
                {
                    SqlBeg_balance += " and d.[PCODE] between '" + val.PCODE1 + "' and '" + val.PCODE2 + "' ";
                }

                SqlBeg_balance += " group by  h.STCODE,d.PCODE";
















                var data_qurery = conn.RunQuery<RPT_StockcardModels.Stockcard_data>(sql);
                var data_Beg = conn.RunQuery<RPT_StockcardModels.Stockcard_data>(SqlBeg_balance);
                if (data_qurery != null)
                {
                    if (data_qurery.Count > 0)
                    {
                        int remain = 0;
                        int Beg_qty =0;

                        var stock = data_qurery.Select(s => new { s.STCODE, s.STNAME }).Distinct().OrderBy(s => s.STCODE);
                        var pcodedata = data_qurery.Select(s => new { s.PCODE }).Distinct().OrderBy(s => s.PCODE);


                        IEnumerable<RPT_StockcardModels.Stockcard_data> Itemsdata = new List<RPT_StockcardModels.Stockcard_data>();
                        List<RPT_StockcardModels.Stockcard_data> data = new List<RPT_StockcardModels.Stockcard_data>();
                        RPT_StockcardModels.Stockcard_data data_add;
                        int seq = 1;
                        int QTY_remain = 0;
                        foreach (var st in stock)
                        {
                            foreach (var pcode in pcodedata)
                            {
                                //Itemsdata = data_qurery.Where(items => items.STCODE == st.STCODE && items.PCODE == pcode.PCODE).OrderBy(s => s.DOCDATE , s.DOCNO); ;
                                Itemsdata = (from tmp in data_qurery where tmp.STCODE == st.STCODE && tmp.PCODE == pcode.PCODE orderby tmp.TR_ID select tmp).ToList();
                                 Beg_qty = (from tmp_beg in data_Beg where tmp_beg.STCODE == st.STCODE && tmp_beg.PCODE == pcode.PCODE select tmp_beg.BEG_ST_QTY).Sum();
                                QTY_remain = Beg_qty;
                                foreach (RPT_StockcardModels.Stockcard_data val_Itemsdata in Itemsdata)
                                {

                                    data_add = new RPT_StockcardModels.Stockcard_data();
                                    data_add.SEQ = seq;
                                    data_add.TR_ID = val_Itemsdata.TR_ID;
                                    data_add.DOCTYPE = val_Itemsdata.DOCTYPE;
                                    data_add.DOCNO = val_Itemsdata.DOCNO;
                                    data_add.DOCDATE = val_Itemsdata.DOCDATE;
                                    data_add.MOV_TYPE = val_Itemsdata.MOV_TYPE;
                                    data_add.STCODE = val_Itemsdata.STCODE;
                                    data_add.STNAME = val_Itemsdata.STNAME;
                                    data_add.PERCODE = val_Itemsdata.PERCODE;
                                    data_add.PERNAME = val_Itemsdata.PERNAME;

                                    data_add.PCODE = val_Itemsdata.PCODE;
                                    data_add.PNAME = val_Itemsdata.PNAME;
                                    data_add.ST_QTY = val_Itemsdata.ST_QTY;
                                    data_add.QTY_IN = val_Itemsdata.QTY_IN;
                                    data_add.QTY_OUT = val_Itemsdata.QTY_OUT;

                                    data_add.BEG_ST_QTY = Beg_qty;
                                    QTY_remain += (val_Itemsdata.ST_QTY * val_Itemsdata.IDC);

                                    data_add.QTY_remain = QTY_remain;


                                    data_add.IDC = val_Itemsdata.IDC;
                                    data_add.ST_UNITCODE = val_Itemsdata.ST_UNITCODE;
                                    data_add.ST_UNITNAME = val_Itemsdata.ST_UNITNAME;
                                    data.Add(data_add);

                                    seq += 1;
                                }
                                QTY_remain = 0;
                                Beg_qty = 0;
                            }
                        }

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