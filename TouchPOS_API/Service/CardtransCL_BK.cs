using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
using TouchPOS_API.Pay_True;
namespace TouchPOS_API.Service
{
    public class CardtransCL
    {
        #region "Select"
        public ResponseMessage Sel_Sum_Net(string Input_data)
        {
            var ret = new ResponseMessage();
            try
            {
                string sql = "";
                sql = " SELECT   isnull(sum([MRTAMOUNT]),0) as [MRTAMOUNT] FROM[CARDTRANS] where  MRTSTATUS = 'S' and SHOPID = " + Input_data + " and  cast([LUPDATE] as date) = cast(getdate() as date) ";
                var sumnet = new DataContext().RunQuery<CardtransModels2>(sql);

                ret.Data = sumnet;
                ret.Respon.Result = true;
                ret.Respon.ErrorMessage = sumnet[0].MRTAMOUNT.ToString();
                return ret;
            }
            catch (Exception e)
            {
                ret.Respon.ErrorMessage = "API : " + e.Message.ToString();
                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
                return ret;
            }

        }
        public ResponseMessage Sel_PrintSlip(string CorpBRNID, string slipno)
        {
            var ret = new ResponseMessage();
            try
            {
                string sql = "";
                if (CorpBRNID == "LJ")
                {
                    sql = " select a.BARCODE ,a.MRTAMOUNT,a.MRTSLIPNO,a.FOODNAME,a.LUPDATE";
                    sql += " ,b.CEXPIRED,isnull(b.CBALANCE,0) CBALANCE,a.SEQ,a.QTY,a.ITEMS_PRICE,a.OLD_BALANCE ,'' as CARDTENDOR";
                    sql += " from[dbo].[CARDTRANS] a";
                    sql += " left join[CARDS] b on a.BARCODE = b.BARCODE ";// and a.CUSED= b.CUSED  and a.CUSED1= b.CUSED1";
                    sql += " where a.MRTSLIPNO LIKE '" + slipno + "%' ORDER BY CTID";
                }
                else
                {
                    sql = " select a.BARCODE ,a.MRTAMOUNT,a.MRTSLIPNO,a.FOODNAME,a.LUPDATE";
                    sql += " ,b.CEXPIRED,isnull(b.CBALANCE,0) CBALANCE,a.SEQ,a.QTY,a.ITEMS_PRICE,a.OLD_BALANCE ,a.CARDTENDOR";
                    sql += " from[dbo].[CARDTRANS] a";
                    sql += " left join[CARDS] b on a.BARCODE = b.BARCODE ";// and a.CUSED= b.CUSED  and a.CUSED1= b.CUSED1";
                    sql += " where a.MRTSLIPNO LIKE '" + slipno + "%' ORDER BY CTID";
                }

                var value = new DataContext().RunQuery<CardtranModels.slipModel>(sql);

                ret.Data = value;
                ret.Respon.Result = true;
                ret.Respon.ErrorMessage = "";
                return ret;
            }
            catch (Exception e)
            {
                ret.Respon.ErrorMessage = "API : " + e.Message.ToString();
                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
                return ret;
            }

        }
        public ResponseMessage Sel_PrintSlip_INV(string slipno)
        {
            var ret = new ResponseMessage();
            try
            {
                var conn = new DataContext();
                string sql = "";
                sql = " select ";
                sql += " (select top 1 BRNNAMETHAI as COMPNAME from COMPANYPROFILE) as COMPNAME";
                sql += " ,(select top 1 BRNTAXID from COMPANYPROFILE) as COMPBRNTAXID";
                sql += " ,a.BARCODE ,a.MRTAMOUNT,a.MRTSLIPNO,a.FOODNAME,a.LUPDATE";
                sql += " ,b.CEXPIRED,isnull(b.CBALANCE,0) CBALANCE,a.SEQ,a.QTY,a.ITEMS_PRICE,a.OLD_BALANCE ,TENDER.NAME as 'CARDTENDOR',a.TAXINVOICE,a.CARDREF";
                sql += " from[dbo].[CARDTRANS] a";
                sql += " left join[CARDS] b on a.BARCODE = b.BARCODE ";// and a.CUSED= b.CUSED  and a.CUSED1= b.CUSED1";
                sql += " left join" + conn.DB_backup + "[TENDER]  on TENDER.CODE = a.CARDTENDOR ";
                sql += " where a.MRTSLIPNO LIKE '" + slipno + "%' ORDER BY CTID";
                var value = conn.RunQuery<CardtranModels.slipModel>(sql);

                ret.Data = value;
                ret.Respon.Result = true;
                ret.Respon.ErrorMessage = "";
                return ret;
            }
            catch (Exception e)
            {
                ret.Respon.ErrorMessage = "API : " + e.Message.ToString();
                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
                return ret;
            }

        }
        public ResponseMessage Sel_PrintSlip_multi(string slipno)
        {
            var ret = new ResponseMessage();
            try
            {
                string sql = "";
                sql = " select a.BARCODE ,a.MRTAMOUNT,a.MRTSLIPNO,a.FOODNAME,a.LUPDATE";
                sql += " ,b.CEXPIRED,isnull(b.CBALANCE,0) CBALANCE";
                sql += " from[dbo].[CARDTRANS] a";
                sql += " inner join[CARDS] b on a.BARCODE = b.BARCODE ";// and a.CUSED= b.CUSED  and a.CUSED1= b.CUSED1";
                sql += " where a.MRTSLIPNO LIKE '" + slipno + "%' ORDER BY CTID";
                var value = new DataContext().RunQuery<CardtranModels.slipModel>(sql);

                ret.Data = value;
                ret.Respon.Result = true;
                ret.Respon.ErrorMessage = "";
                return ret;
            }
            catch (Exception e)
            {
                ret.Respon.ErrorMessage = "API : " + e.Message.ToString();
                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
                return ret;
            }

        }
        public ResponseMessage Sel_CHKcard_Multi(CHKcard_MultiModels data)
        {
            var ret = new ResponseMessage();
            try
            {
                string BARCODE = data.BARCODE;
                int Nettotel = data.Nettotel;
                //BARCODE = BARCODE.Replace(" ", "+");
                var Ecards = new EcardsCL().CHK_Ecard(BARCODE);
                List<EcardModels> Ecards_data = new List<EcardModels>();
                if (Ecards.Respon.Result == false)
                {
                    return Ecards;
                }
                //else
                //{
                //    Ecards_data = (List<ECARDS>)(Ecards.Data);
                //}



                var card = new CHK_cardsCL().chkcard(BARCODE, Nettotel);
                //List<CardModels> card_data = new List<CardModels>();
                if (card.Respon.Result == false)
                {
                    return card;
                }
                //else
                //{
                //    card_data = (List<CardModels>)(card.Data);
                //}


                ret.Respon.ErrorMessage = "";
                ret.Respon.Result_value = "";
                ret.Respon.SystemErrorMessage = "";
                ret.Respon.Result = true;
                ret.Data = card.Data;
                return ret;
            }
            catch (Exception e)
            {
                ret.Respon.SystemErrorMessage = "API : " + e.Message.ToString();
                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
            }
            return ret;
            //END  chkeck-----------------------------------------------------
        }
        public ResponseMessage Sel_Rpt_dayend(string shopid, string MRTLUPDATE)
        {
            var ret = new ResponseMessage();
            try
            {

                DateTime DOCDATE = Convert.ToDateTime(MRTLUPDATE);

                string dddd = new Center().Condate(DOCDATE, "ymd2");
                string sql = "";
                //sql = " SELECT  [FOODNAME],sum(MRTAMOUNT) as MRTAMOUNT, ";
                sql = " SELECT  sum(MRTAMOUNT) as MRTAMOUNT, ";
                sql += " 'TOTALCARD' = (select isnull(sum(TOTALCARD),0)as TOTALCARD from [SHOPCARDEND] where cast([CARDENDDATE]as date) = '" + dddd + "' and SHOPID = '" + shopid + "' ) ";
                sql += " FROM[CARDTRANS] ";
                sql += " where MRTSTATUS = 'S' and SHOPID = '" + shopid + "'   and cast(MRTLUPDATE as date) = '" + dddd + "'";
                //sql += " group by[FOODNAME] ";


                var value = new DataContext().RunQuery<CardtranModels.DayendModel>(sql);

                ret.Data = value;
                ret.Respon.Result = true;
                ret.Respon.ErrorMessage = "";
                return ret;
            }
            catch (Exception e)
            {
                ret.Respon.ErrorMessage = "API : " + e.Message.ToString();
                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
                return ret;
            }

        }

        #endregion
        #region "Save"

        public ResponseMessage Save_CARDTRANS(CardtranModels.SALE_INT Input_data)
        {
            var con = new DataContext();
            var ret = new ResponseMessage();
            var BARCODE = Input_data.Cardtran[0].BARCODE;
            char[] MultiRun = new char[23];
            var Sql_check = new Sql_check();
            string ISNOR = "";// "NOR";
            ResponseMessage card;
            List<CHK_cardsModels> card_data = new List<CHK_cardsModels>();
            ResponseMessage Ecards;
            //Input_data.BARCODE = "N0601110953";
            Int16 shopEnd = 0;
            if (Input_data.PAYTYPE != "")
            {

                con.Excute_Open();
                try
                {
                    
                    string test_docno_INV = new Doccument().Gendocno_INV(con, Input_data.SHOPID.ToString());
                    if (test_docno_INV == "")
                    {
                        ret.Respon.ErrorMessage = "ไม่พบเลขที่เอกสาร INV";
                        //ret.SystemErrorMessage = e.StackTrace;
                        ret.Respon.Result = false;
                        return ret;
                    }
                }
                finally
                {
                    con.Excute_Rollback();
                    con.Excute_close();
                }
            }
            try
            {

                if (Input_data.PAYTYPE == ISNOR)
                {
                    for (int id = 0; id < 23; id++)
                    {
                        MultiRun[id] = (char)(65 + id);
                    }
                    //chkeck----------------------------------------------------


                    card = new CHK_cardsCL().chkcard(BARCODE, Input_data.NETAMOUNT, Input_data.Multicard);


                    if (card.Respon.Result == false)
                    {
                        return card;
                    }
                    else
                    {
                        card_data = (List<CHK_cardsModels>)(card.Data);
                    }

                    Ecards = new EcardsCL().CHK_Ecard(BARCODE);
                    List<EcardModels> Ecards_data = new List<EcardModels>();
                    if (Ecards.Respon.Result == false)
                    {
                        return Ecards;
                    }
                    else
                    {
                        Ecards_data = (List<EcardModels>)(Ecards.Data);
                    }


                    //END  chkeck-----------------------------------------------------



                    //บัตรหมดมูลค่าที่ร้านค้า ของการ์ดปัจจุบันเท่านั้น

                    if (card_data[0].CBALANCE <= Input_data.NETAMOUNT)
                    {
                        shopEnd = 1;
                    }
                    else
                    {
                        shopEnd = 0;
                    }

                    //log nomal
                    //log nomal
                    //log nomal
                    //log nomal
                    //log nomal
                    //log nomal
                    //log nomal
                    //log nomal

                }
                var workingdate = new WorkingdateCL().chk_Workingdate("");
                if (workingdate.Count <= 0)
                {
                    throw new Exception("มีการปิดสิ้นวันแล้ว กรุณาแจ้งผู้ดูแลระบบ");
                }
                string wordate_ = new Center().Condate(workingdate[0].DATEWORKING, "ymd hh:mm:ss");
                string DOCDATE = new Center().Condate(Input_data.DOCDATE, "ymd hh:mm:ss");

                con.Excute_Open();
                // Gendocno
                string docno = new Doccument().Gendocno(con, Input_data.SHOPID.ToString());
                if (docno == "")
                {
                    throw new Exception("ไม่พบเลขที่เอกสาร");
                }


                string query = "";
                int i = 0;
                query += " INSERT INTO " + con.DB_backup + "[SALE] ";
                query += "(MRTSLIPNO, SHOPID, POSID,DOCDATE,DOCYEAR,DOCMONT, BACKUPFLG, VOIDNO, SHOPENDFLG, TAXINVOICE, CREDITNOTES, CARDTENDOR, CARDREF, CARDPURSE, taxPrint, CUS_ID, PAYTYPE, PAYAMOUNT, AMOUNT, DISTP, DISVALUE, AFTERDIS, VATTP, VATVALUE, AFTERVAT, NETAMOUNT, QTY_TOTAL, STATUS, CRDATE, CBY, MODATE, MBY ,DC_STATE) ";
                query += " \n VALUES( ";
                query += "'" + docno + "'";
                query += ",'" + Input_data.SHOPID + "' ";
                query += ",'" + Input_data.POSID + "' ";
                query += ",'" + DOCDATE + "' ";
                query += ",'" + Input_data.DOCYEAR + "' ";
                query += ",'" + Input_data.DOCMONT + "' ";
                query += ",0";
                query += ",'' ";
                query += ",0";
                query += ",'" + Input_data.TAXINVOICE + "' ";
                query += ",'" + Input_data.CREDITNOTES + "' ";
                query += ",'" + Input_data.CARDTENDOR + "' ";
                query += ",'" + Input_data.CARDREF + "'";
                query += ",'" + Input_data.CARDPURSE + "' ";
                query += ",'" + Input_data.taxPrint + "' ";
                query += ",'" + Input_data.CUS_ID + "'";
                query += ",'" + Input_data.PAYTYPE + "'";
                query += ",'" + Input_data.PAYAMOUNT + "' ";
                query += ",'" + Input_data.AMOUNT + "' ";
                query += ",'" + Input_data.DISTP + "' ";
                query += ",'" + Input_data.DISVALUE + "' ";
                query += ",'" + Input_data.AFTERDIS + "' ";
                query += ",'" + Input_data.VATTP + "'";
                query += ",'" + Input_data.VATVALUE + "'";
                query += ",'" + Input_data.AFTERVAT + "'";
                query += ",'" + Input_data.NETAMOUNT + "'";
                query += ",'" + Input_data.QTY_TOTAL + "'";
                query += ",'1'";
                query += ",getdate() ";
                query += ",'" + Input_data.CBY + "'";
                query += ",getdate()";
                query += ",'" + Input_data.MBY + "'";
                query += ",'" + Input_data.DC_STATE + "') ";


                query += Sql_check.ROWCOUNT(Sql_check.Insert, "SALE");


                string SALE_CARD_H = "";
                SALE_CARD_H = " \n INSERT INTO  " + con.DB_backup + "[SALE_ITEMS] (SHOPID, MRTSLIPNO, POSID, SEQ, VOIDNO, FOODID, FOODNAME, GP, GPAMOUNT,GPRULE, ITEMS_PRICE, DISTP " +
                          ", DISVALUE, AFTERDIS, VATTP, VATVALUE, AFTERVAT, NETAMOUNT " +
                          ", STATUS, QTY, CHKFLG, PRO_ID, PRO_NAME, PRO_TEXT) VALUES ";

                query += SALE_CARD_H;
                i = 0;
                foreach (CardtranModels.Saleitems val in Input_data.Saleitems)
                {
                    if (i > 0) query += ",";
                    query += "\n(";
                    query += " '" + Input_data.SHOPID + "'";
                    query += ",'" + docno + "'";
                    query += ",'" + Input_data.POSID + "'";
                    query += ",'" + val.SEQ + "'";
                    query += ",''";
                    query += ",'" + val.FOODID + "'";
                    query += ",'" + val.FOODNAME + "'";
                    query += ",'" + val.GP + "'";
                    query += ",'" + val.GPAMOUNT + "'";
                    query += ",'" + val.GPRULE + "'";
                    query += ",'" + val.ITEMS_PRICE + "'";
                    query += ",'" + val.DISTP + "'";
                    query += ",'" + val.DISVALUE + "'";
                    query += ",'" + val.AFTERDIS + "'";
                    query += ",'" + val.VATTP + "'";
                    query += ",'" + val.VATVALUE + "'";
                    query += ",'" + val.AFTERVAT + "'";
                    query += ",'" + val.NETAMOUNT + "'";
                    query += ",'1'";
                    query += ",'" + val.QTY + "'";
                    query += ",0";
                    query += ",'" + val.PRO_ID + "'";
                    query += ",'" + val.PRO_NAME + "'";
                    query += ",'" + val.PRO_TEXT + "'";
                    query += ")";

                    i++;
                }
                query += Sql_check.ROWCOUNT(Sql_check.Insert, "SALE_ITEMS");
                string sale_H = "\n   insert into  " + con.DB_backup + "[SALE_CARD]( MRTSLIPNO,  SHOPID, POSID, SEQ,BARCODE,PAYTYPE,  CUSED, CUSED1, MRTAMOUNT, CBALANCE, CBALANCEREMAIN, GP, GPAMOUNT, PRO_ID, PRO_NAME, PRO_TEXT, STATUS ) values";

                query += sale_H;
                i = 0;
                foreach (CardtranModels.Saleitems_card val in Input_data.Saleitems_card)
                {
                    if (i > 0) query += ",";
                    query += "\n(";

                    query += "'" + docno + "'";
                    query += ",'" + Input_data.SHOPID + "'";
                    query += ",'" + Input_data.POSID + "'";
                    query += ",'" + val.SEQ + "'";
                    query += ",'" + val.BARCODE + "'";
                    query += ",'" + val.PAYTYPE + "'";
                    query += ",'" + val.CUSED + "'";
                    query += ",'" + val.CUSED1 + "'";
                    query += ",'" + val.MRTAMOUNT + "'";
                    query += ",'" + val.CBALANCE + "'";
                    query += ",'" + val.CBALANCEREMAIN + "'";
                    query += ",'" + val.GP + "'";
                    query += ",'" + val.GPAMOUNT + "'";
                    query += ",'" + val.PRO_ID + "'";
                    query += ",'" + val.PRO_NAME + "'";
                    query += ",'" + val.PRO_TEXT + "'";
                    query += ",'1'";
                    query += ")";

                    i++;
                }
                query += Sql_check.ROWCOUNT(Sql_check.Insert, "SALE_CARD");
                //insert cars//insert cars//insert cars//insert cars//insert cars



                string query_H = "";
                if (Input_data.CorpBRNID == "LJ")
                {
                    query_H = "\n  INSERT INTO CARDTRANS (CUSED, CUSED1, BARCODE, SHOPID, POSID, MRTAMOUNT, " +
                                        "MRTSTATUS, MRTSLIPNO, MRTLUPDATE, TID, UID, LUPDATE, BACKUPFLG,FOODID, FOODNAME," +
                                        "SHOPENDFLG,GP,GPAMOUNT,seq,ITEMS_PRICE,QTY,OLD_BALANCE) VALUES ";
                }
                else
                {
                    query_H = "\n  INSERT INTO CARDTRANS (CUSED, CUSED1, BARCODE, SHOPID, POSID, MRTAMOUNT, " +
                                         "MRTSTATUS, MRTSLIPNO, MRTLUPDATE, TID, UID, LUPDATE, BACKUPFLG,FOODID, FOODNAME," +
                                         "SHOPENDFLG,GP,GPAMOUNT,GPRULE,seq,ITEMS_PRICE,QTY,OLD_BALANCE,CARDTENDOR,CARDREF,CARDPURSE) VALUES ";
                }

                query += query_H;
                i = 0;
                int CBALANCE = 0;
                if (Input_data.PAYTYPE == ISNOR)
                {
                    CBALANCE = int.Parse(card_data[0].CBALANCE.ToString());
                }

                int useAMOUNT = 0;
                foreach (CardtranModels.Cardtran val in Input_data.Cardtran)
                {
                    if (i > 0) query += ",";
                    query += "\n(";
                    if (Input_data.PAYTYPE == ISNOR)
                    {
                        query += "'" + card_data[0].CUSED + "'";
                        query += ",'" + card_data[0].CUSED1 + "'";
                    }
                    else
                    {
                        query += "'1'";
                        query += ",'1'";
                    }
                    query += ",'" + BARCODE + "'";
                    query += ",'" + Input_data.SHOPID + "'";
                    query += ",'" + Input_data.POSID + "'";
                    if (Input_data.Multicard == true)
                    {
                        int MRTAMOUNT_remain = val.MRTAMOUNT;
                        int MRTAMOUNT = call_cbalance(ref CBALANCE, ref MRTAMOUNT_remain);
                        val.MRTAMOUNT = MRTAMOUNT_remain;
                        useAMOUNT += MRTAMOUNT;
                        query += ",'" + MRTAMOUNT + "'";
                    }
                    else
                    {
                        query += ",'" + val.MRTAMOUNT + "'";
                        useAMOUNT += val.MRTAMOUNT;
                    }

                    query += ",'" + val.MRTSTATUS + "'";
                    if (Input_data.Multicard == true)
                    {
                        query += ",'" + docno + "-" + val.SEQ + "X'"; //MRTSLIPNO
                    }
                    else
                    {
                        query += ",'" + docno + "-" + val.SEQ + "'"; //MRTSLIPNO
                    }
                    query += ",'" + wordate_ + "'"; //MRTLUPDATE
                    query += ",'" + val.TID + "'";
                    query += ",'" + val.UID + "'";
                    query += ",getdate()"; //LUPDATE
                    query += ",0"; //BACKUPFLG
                    query += ",'" + val.FOODID + "'";
                    query += ",'" + val.FOODNAME + "'";
                    query += ",'" + shopEnd.ToString() + "'";
                    query += ",'" + val.GP + "'";
                    query += ",'" + val.GPAMOUNT + "'";
                    query += ",'" + val.GPRULE + "'";
                    query += ",'" + val.SEQ + "'";
                    query += ",'" + val.ITEMS_PRICE + "'";
                    query += ",'" + val.QTY + "'";

                    if (Input_data.PAYTYPE == ISNOR)
                    {
                        query += ",'" + card_data[0].CBALANCE + "'";//OLD_BALANCE
                    }
                    else
                    {
                        query += ",'0'";//OLD_BALANCE
                    }


                    if (Input_data.CorpBRNID == "LJ")
                    {
                    }
                    else
                    {
                        query += ",'" + val.CARDTENDOR + "'";
                        query += ",'" + val.CARDREF + "'";
                    }
                    query += ",'" + val.CARDPURSE + "'";
                    query += ")";

                    i++;
                }

                query += Sql_check.ROWCOUNT(Sql_check.Insert, "CARDTRANS");
                if (Input_data.PAYTYPE == ISNOR)
                {
                    if (Input_data.Cardtran.Count > 0)
                    {
                        if (shopEnd == 1)
                        {
                            query += Query_shopend_1(Input_data.SHOPID.ToString(), Input_data.POSID, BARCODE, card_data[0].CUSED.ToString());
                            ret.Respon.ErrorMessage = "NOBALANCE";
                            ret.Respon.Result_value = BARCODE;
                        }
                        else
                        {
                            query += Query_shopend_0(useAMOUNT, BARCODE, card_data[0].CUSED.ToString());
                        }
                    }
                }



                if (Input_data.Multicard == true)
                {

                    //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
                    //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
                    //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
                    //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
                    int MRTAMOUNT_Remain = Input_data.Cardtran.Sum(s => s.MRTAMOUNT);
                    //CardtranModels.Model Items_multi = new   CardtranModels.Model();
                    //var Items_multi = Input_data.Items.Select.(c => ).ToList();
                    int MultiRun_IDX = 0;
                    foreach (CardtranModels.Saleitems_card val in Input_data.Saleitems_card)
                    {
                        if (BARCODE == val.BARCODE) { continue; }
                        //chkeck-----MulticardMulticardMulticardMulticardMulticard-----------------------------------------------

                        var card_multi = new CHK_cardsCL().chkcard(val.BARCODE, MRTAMOUNT_Remain, Input_data.Multicard);
                        List<CHK_cardsModels> card_data_multi = new List<CHK_cardsModels>();
                        if (card_multi.Respon.Result == false)
                        {
                            return card_multi;
                        }
                        else
                        {
                            card_data_multi = (List<CHK_cardsModels>)(card_multi.Data);
                        }

                        var Ecards_multi = new EcardsCL().CHK_Ecard(val.BARCODE);
                        List<EcardModels> Ecards_data_multi = new List<EcardModels>();
                        if (Ecards_multi.Respon.Result == false)
                        {
                            return Ecards_multi;
                        }
                        else
                        {
                            Ecards_data_multi = (List<EcardModels>)(Ecards_multi.Data);
                        }

                        //END  chkeck------MulticardMulticardMulticardMulticardMulticard-----------------------------------------------





                        query += "\n" + query_H;
                        i = 0;
                        useAMOUNT = 0;
                        int CBALANCE_multi = int.Parse(card_data_multi[0].CBALANCE.ToString());
                        foreach (CardtranModels.Cardtran val_multi in Input_data.Cardtran)
                        {

                            if (val_multi.MRTAMOUNT <= 0) { continue; }

                            if (i > 0) query += ",";
                            query += "\n(";
                            if (Input_data.PAYTYPE == ISNOR)
                            {
                                query += "'" + card_data_multi[0].CUSED + "'";
                                query += ",'" + card_data_multi[0].CUSED1 + "'";
                            }
                            else
                            {
                                query += ",'1'";
                                query += ",'1'";
                            }
                            query += ",'" + val.BARCODE + "'";
                            query += ",'" + Input_data.SHOPID + "'";
                            query += ",'" + Input_data.POSID + "'";
                            //if (Input_data.Multicard == true)
                            //{
                            int MRTAMOUNT_remain = val_multi.MRTAMOUNT;
                            int MRTAMOUNT = call_cbalance(ref CBALANCE_multi, ref MRTAMOUNT_remain);
                            val_multi.MRTAMOUNT = MRTAMOUNT_remain;
                            query += ",'" + MRTAMOUNT + "'";
                            useAMOUNT += MRTAMOUNT;
                            //}
                            //else
                            //{
                            //    query += "'" + val.MRTAMOUNT + "',";
                            //}

                            query += ",'" + val_multi.MRTSTATUS + "'";
                            query += ",'" + docno + "-" + MultiRun[MultiRun_IDX] + "X'"; //MRTSLIPNO
                            query += ",'" + wordate_ + "'"; //MRTLUPDATE
                            query += ",'" + val_multi.TID + "'";
                            query += ",'" + val_multi.UID + "'";
                            query += ",getdate()"; //LUPDATE
                            query += ",0"; //BACKUPFLG
                            query += ",'" + val_multi.FOODID + "'";
                            query += ",'" + val_multi.FOODNAME + "'";
                            query += ",'" + shopEnd.ToString() + "'";
                            query += ",'" + val_multi.GP + "'";
                            query += ",'" + val_multi.GPAMOUNT + "'";
                            query += ",'" + val_multi.GPRULE + "'";
                            query += ",'" + val_multi.SEQ + "'";
                            query += ",0";//เคสต่อบัตรลงเป้น 0
                            query += ",0"; //เคสต่อบัตรลงเป้น 0
                            query += ",'" + card_data_multi[0].CBALANCE + "'";
                            if (Input_data.CorpBRNID == "LJ")
                            {
                            }
                            else
                            {
                                query += ",'" + val_multi.CARDTENDOR + "'";
                                query += ",'" + val_multi.CARDREF + "'";
                            }
                            query += ",'" + Input_data.CARDPURSE + "'";
                            query += ")";
                            MultiRun_IDX++;

                            //บัตรหมดมูลค่าที่ร้านค้า
                            shopEnd = 0;
                            if (CBALANCE_multi <= 0)
                            {
                                shopEnd = 1;
                                break;
                            }
                            else
                            {
                                shopEnd = 0;
                            }
                            i++;

                        }
                        query += Sql_check.ROWCOUNT(Sql_check.Insert, "CARDTRANS");
                        if (Input_data.Cardtran.Count > 0)
                        {
                            if (shopEnd == 1)
                            {
                                query += Query_shopend_1(Input_data.SHOPID.ToString(), Input_data.POSID, val.BARCODE, val.CUSED.ToString());
                                ret.Respon.ErrorMessage = "NOBALANCE";
                                ret.Respon.Result_value += ", " + val.BARCODE;
                            }
                            else
                            {
                                query += Query_shopend_0(useAMOUNT, val.BARCODE, val.CUSED.ToString());

                            }
                        }
                    }

                    //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
                    //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
                    //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
                    //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------

                }
                else//inseret CARDTRANS_CARDUSE
                {

                }




                //log query
                //log query
                //log query
                //log query
                //log query
                //log query
                //log query

                var a = con.Excute(query);

                con.Excute_Commit();
                ret.Respon.Result_value2 = docno;
                //ret.Respon.SystemErrorMessage = "NOBALANCE";
                ret.Respon.Result = true;
            }
            catch (Exception e)
            {

                ///log error
                ///log error
                //////log error
                //////log error
                //////log error
                //////log error
                //////log error
                //////log error
                //////log error
                //////log error
                if (con.connection != null)
                { con.Excute_Rollback(); }

                ret.Respon.SystemErrorMessage = "API : " + e.Message.ToString();
                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
            }
            finally
            {
                con.Excute_close();
            }
            return ret;
        }

        public int call_cbalance(ref int CBALANCE, ref int MRTAMOUNT)
        {
            if (CBALANCE >= MRTAMOUNT)
            {
                CBALANCE -= MRTAMOUNT;
                int MRTAMOUNT_remain = MRTAMOUNT;
                MRTAMOUNT = 0;
                return MRTAMOUNT_remain;
            }
            else
            {
                int remain = CBALANCE;
                int MRTAMOUNT_remain = CBALANCE - MRTAMOUNT;
                if (MRTAMOUNT_remain < 0)
                {
                    MRTAMOUNT_remain = MRTAMOUNT_remain * (-1);
                }
                MRTAMOUNT = MRTAMOUNT_remain;
                CBALANCE = 0;
                return remain;
            }
        }
        public ResponseMessage Pay_tender(string docno, CardtranModels.SALE_INT val)
        {
            try
            {


                var ret = new ResponseMessage();
                switch (val.PAYTYPE)
                {
                    case "ThaiQR":

                        break;
                    case "TRUEWALLET":
                        var model = new TrueRequestModel();
                        model.isv_payment_ref = docno;
                        model.merchant_id = val.merchant_id;
                        model.currency = "THB";
                        model.request_amount = ((int)val.NETAMOUNT * 100).ToString();
                        model.payment_method = "BALANCE";
                        model.payment_code = val.Saleitems_card[0].BARCODE;
                        model.description = val.Remark1;
                        model.metadata = new TrueRequestModel.MetaData();
                        model.metadata.partner_shop_id = val.SHOPID.ToString();


                        ret = new PayTrueCL().TruePaymentRequest(model);
                        break;
                }
                if (ret.Respon.Result == false)
                {
                    throw new Exception(ret.Respon.SystemErrorMessage);
                }
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string Query_shopend_1(
            string SHOPID,
            string POSID,
            string BARCODE,
            string CUSED
            )
        {
            var Sql_check = new Sql_check();
            string query = "";
            query += "\n if not exists ( select [POSID] from [SHOPCARDEND] where cast([CARDENDDATE]as date) = cast(getdate() as date) and SHOPID = '" + SHOPID + "'  )   ";
            query += " begin ";
            query += "\n INSERT INTO [SHOPCARDEND] ([POSID],[TOTALCARD],[CARDENDDATE],[RETURNCARD],[LUPDATE],[UID],[RETURNFLG],[SHOPID])";
            query += "\n VALUES (";
            query += "'" + POSID + "'";
            query += ",'1'";
            query += ",getdate()";
            query += ",0";
            query += ",getdate()";
            query += ",'" + POSID + "'";
            query += ",0";
            query += ",'" + SHOPID + "'";
            query += "\n )";
            query += Sql_check.ROWCOUNT(Sql_check.Insert, "SHOPCARDEND");
            query += "\n end";

            query += " else begin ";
            query += "\n update SHOPCARDEND set  TOTALCARD = TOTALCARD+1 ,LUPDATE = getdate() where cast([CARDENDDATE]as date) = cast(getdate() as date) and SHOPID = '" + SHOPID + "'  ";
            query += Sql_check.ROWCOUNT(Sql_check.update, "SHOPCARDEND");
            query += "\n  end  ";
            query += "\n update [CARDS] set CBALANCE = 0 , CSTATUS = 'E' ,CLUPDATE = GETDATE() WHERE BARCODE = '" + BARCODE + "' AND CUSED = " + CUSED;
            query += Sql_check.ROWCOUNT(Sql_check.update, "CARDS");
            return query;
        }
        public string Query_shopend_0(
            int Nettotel,
            string BARCODE,
            string CUSED
            )
        {
            var Sql_check = new Sql_check();
            string query = "";
            query += "\n update [CARDS] set CBALANCE = CBALANCE-" + Nettotel + " ,CLUPDATE = GETDATE() WHERE BARCODE = '" + BARCODE + "' AND CUSED = " + CUSED;
            query += Sql_check.ROWCOUNT(Sql_check.update, "CARDS");
            return query;
        }
        public ResponseMessage confirmpay(ConfirmpayModels data)
        {
            var con = new DataContext();
            var ret = new ResponseMessage();
            var Sql_check = new Sql_check();
            try
            {
                con.Excute_Open();
                string docno = new Doccument().Gendocno_INV(con, data.SHOPID.ToString());
                if (docno == "")
                {
                    throw new Exception("ไม่พบเลขที่เอกสาร INV :\n หมายเหุ อาจกำหนด IP Terminal ไม่ถูกต้อง");
                }


                string strPay = "";

                strPay = "\n update " + con.DB_backup + "[SALE]  set CARDREF = '" + data.payment_id + "' ,DC_STATE ='S',TAXINVOICE = '" + docno + "' where [MRTSLIPNO] = '" + data.mrt_slip + "' and  [SHOPID] = '" + data.SHOPID + "'";
                strPay += "\n update " + con.DB_backup + "[SALE_CARD]  set BARCODE = '" + data.barcode + "'  where [MRTSLIPNO] = '" + data.mrt_slip + "' and  [SHOPID] = '" + data.SHOPID + "'";

                strPay += Sql_check.ROWCOUNT(Sql_check.update, "SALE");
                strPay += "\n update CARDTRANS  set BARCODE ='" + data.barcode + "', CARDREF = '" + data.payment_id + "',MRTSTATUS = 'S' ,TAXINVOICE = '" + docno + "' where [MRTSLIPNO] like '" + data.mrt_slip + "%' and  [SHOPID] = '" + data.SHOPID + "'";
                strPay += Sql_check.ROWCOUNT(Sql_check.update, "CARDTRANS");

                strPay += "\n  INSERT INTO [PAYMENT] ";
                strPay += " (typeid, cused, barcode, cused1, clstatus, clamount, clreceive, cpromotion, tid, uid, tendor, clupdate, processdate, remark) ";
                strPay += " VALUES ";
                strPay += " ('" + data.typeid + "' ";
                strPay += " , '" + data.cused + "' ";
                strPay += " , '" + data.barcode + "' ";
                strPay += " , '" + data.cused1 + "' ";
                strPay += " , '" + data.clstatus + "' ";
                strPay += " , '" + data.clamount + "' ";
                strPay += " , '" + data.clreceive + "' ";
                strPay += " , '" + data.cpromotion + "' ";
                strPay += " , '" + data.tid + "' ";
                strPay += " , '" + data.uid + "' ";
                strPay += " , '" + data.tendor + "' ";
                strPay += " , getdate() ";
                strPay += " , getdate() ";
                strPay += " , '" + data.remark + "') ";
                strPay += Sql_check.ROWCOUNT(Sql_check.Insert, "PAYMENT");


                con.Excute(strPay);
                con.Excute_Commit();
                ret.Respon.Result = true;
                ret.Respon.ErrorMessage = "success";
            }
            catch (Exception e)
            {
                con.Excute_Rollback();
                ret.Respon.SystemErrorMessage = "API : " + e.ToString();
                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
            }
            return ret;

        }
        public ResponseMessage confirm_Sale_cancel(ConfirmpayModels data)
        {
            var con = new DataContext();
            var ret = new ResponseMessage();
            var Sql_check = new Sql_check();
            try
            {
                con.Excute_Open();

                string strPay = "";


                //strPay = "\n delete " + con.DB_backup + "[SALE] where [MRTSLIPNO] = '" + data.mrt_slip + "' and  [SHOPID] = '" + data.SHOPID + "'";
                //strPay += Sql_check.ROWCOUNT(Sql_check.update, "SALE");
                //strPay += "\n delete " + con.DB_backup + "[SALE_CARD]  where [MRTSLIPNO] = '" + data.mrt_slip + "' and  [SHOPID] = '" + data.SHOPID + "'";
                //strPay += Sql_check.ROWCOUNT(Sql_check.update, "SALE_CARD");
                //strPay += "\n delete " + con.DB_backup + "[SALE_ITEMS]  where [MRTSLIPNO] = '" + data.mrt_slip + "' and  [SHOPID] = '" + data.SHOPID + "'";
                //strPay += Sql_check.ROWCOUNT(Sql_check.update, "SALE_ITEMS");

                //strPay += "\n delete CARDTRANS   where [MRTSLIPNO] like '" + data.mrt_slip + "%' and  [SHOPID] = '" + data.SHOPID + "'";
                //strPay += Sql_check.ROWCOUNT(Sql_check.update, "CARDTRANS");


                strPay = "\n update " + con.DB_backup + "[SALE] set DC_STATE = 'C' where [MRTSLIPNO] = '" + data.mrt_slip + "' and  [SHOPID] = '" + data.SHOPID + "'";
                strPay += Sql_check.ROWCOUNT(Sql_check.update, "SALE");

                //strPay += "\n update CARDTRANS set MRTSTATUS = 'C'  where [MRTSLIPNO] like '" + data.mrt_slip + "%' and  [SHOPID] = '" + data.SHOPID + "'";
                //strPay += Sql_check.ROWCOUNT(Sql_check.update, "CARDTRANS");


                con.Excute(strPay);
                con.Excute_Commit();
                ret.Respon.Result = true;
                ret.Respon.ErrorMessage = "success";
            }
            catch (Exception e)
            {
                con.Excute_Rollback();
                ret.Respon.SystemErrorMessage = "API : " + e.ToString();
                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
            }
            return ret;

        }
        public ResponseMessage confirmpay_log(ConfirmpayModels_log data)
        {
            var con = new DataContext();
            var ret = new ResponseMessage();
            var Sql_check = new Sql_check();
            try
            {

                string strPay = "";

                strPay += " INSERT INTO " + con.DB_backup + "[PAYMENT_LOG] ";
                strPay += " (  typeid, barcode, clstatus, clamount, clreceive, cpromotion, tid, uid, tendor, clupdate, processdate, Remark, LOG_TYPE, MRTSLIPNO, SHOPID, POSID, MERCHAND_ID, APP_ID, PAYMENT_CODE, PAY_AMOUNT, PAY_STATE, PAY_DESCRIPTION, PAY_Remark) ";
                strPay += " VALUES (";
                strPay += " '" + data.typeid + "' ,";
                strPay += " '" + data.barcode + "' ,";
                strPay += " '" + data.clstatus + "' ,";
                strPay += " '" + data.clamount + "' ,";
                strPay += " '" + data.clreceive + "' ,";
                strPay += " '" + data.cpromotion + "' ,";
                strPay += " '" + data.tid + "' ,";
                strPay += " '" + data.uid + "' ,";
                strPay += " '" + data.tendor + "' ,";
                strPay += " GETDATE() ,";
                strPay += " GETDATE() ,";
                strPay += " '" + data.Remark + "' ,";
                strPay += " '" + data.LOG_TYPE + "' ,";
                strPay += " '" + data.MRTSLIPNO + "' ,";
                strPay += " '" + data.SHOPID + "' ,";
                strPay += " '" + data.POSID + "' ,";
                strPay += " '" + data.MERCHAND_ID + "' ,";
                strPay += " '" + data.APP_ID + "' ,";
                strPay += " '" + data.PAYMENT_CODE + "' ,";
                strPay += " '" + data.PAY_AMOUNT + "' ,";
                strPay += " '" + data.PAY_STATE + "' ,";
                strPay += " '" + data.PAY_DESCRIPTION + "' ,";
                strPay += " '" + data.PAY_Remark + "' ";
                strPay += ")";

                strPay += Sql_check.ROWCOUNT(Sql_check.Insert, "PAYMENT_LOG");

                con.Excute_Open();
                con.Excute(strPay);
                con.Excute_Commit();
                ret.Respon.Result = true;
                ret.Respon.ErrorMessage = "success";
            }
            catch (Exception e)
            {
                con.Excute_Rollback();
                ret.Respon.SystemErrorMessage = "API : " + e.ToString();
                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
            }
            return ret;

        }
        #endregion
    }


}