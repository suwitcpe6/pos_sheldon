using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using TouchPOS_API.Class;
using TouchPOS_API.Models;

using System.Web.UI.WebControls;
using System.Data;
using TouchPOS_API.Service.Transaction;
namespace TouchPOS_API.Service
{
    public class CardtransCL
    {
        //#region "Select"
        //public ResponseMessage Sel_Sum_Net(string Input_data)
        //{
        //    var ret = new ResponseMessage();
        //    try
        //    {
        //        string sql = "";
        //        sql = " SELECT   isnull(sum([MRTAMOUNT]),0) as [MRTAMOUNT] FROM[CARDTRANS] where  MRTSTATUS = 'S' and SHOPID = " + Input_data + " and  cast([LUPDATE] as date) = cast(getdate() as date) ";
        //        var sumnet = new DataContext().RunQuery<CardtransModels2>(sql);

        //        ret.Data = sumnet;
        //        ret.Respon.Result = true;
        //        ret.Respon.ErrorMessage = sumnet[0].MRTAMOUNT.ToString();
        //        return ret;
        //    }
        //    catch (Exception e)
        //    {
        //        ret.Respon.ErrorMessage = "API : " + e.Message.ToString();
        //        //ret.SystemErrorMessage = e.StackTrace;
        //        ret.Respon.Result = false;
        //        return ret;
        //    }

        //}
        //public ResponseMessage Sel_PrintSlip(string CorpBRNID, string slipno)
        //{
        //    var ret = new ResponseMessage();
        //    try
        //    {
        //        string sql = "";
        //        if (CorpBRNID == "LJ")
        //        {
        //            sql = " select a.BARCODE ,a.MRTAMOUNT,a.MRTSLIPNO,a.FOODNAME,a.LUPDATE";
        //            sql += " ,b.CEXPIRED,isnull(b.CBALANCE,0) CBALANCE,a.SEQ,a.QTY,a.ITEMS_PRICE,a.OLD_BALANCE ,'' as CARDTENDOR";
        //            sql += " from[dbo].[CARDTRANS] a";
        //            sql += " left join[CARDS] b on a.BARCODE = b.BARCODE ";// and a.CUSED= b.CUSED  and a.CUSED1= b.CUSED1";
        //            sql += " where a.MRTSLIPNO LIKE '" + slipno + "%' ORDER BY CTID";
        //        }
        //        else if (CorpBRNID == "AT")
        //        {
        //            sql = " select a.BARCODE ,a.MRTAMOUNT,a.MRTSLIPNO,a.FOODNAME,a.LUPDATE";
        //            sql += " ,b.CEXPIRED,isnull(b.CBALANCE,0) CBALANCE,a.SEQ,a.QTY,a.ITEMS_PRICE,a.OLD_BALANCE ,'' as CARDTENDOR";
        //            sql += " from[dbo].[CARDTRANS] a";
        //            sql += " left join[CARDS] b on a.BARCODE = b.BARCODE ";// and a.CUSED= b.CUSED  and a.CUSED1= b.CUSED1";
        //            sql += " where a.MRTSLIPNO LIKE '" + slipno + "%' ORDER BY CTID";
        //        }
        //        else
        //        {
        //            sql = " select a.BARCODE ,a.MRTAMOUNT,a.MRTSLIPNO,a.FOODNAME,a.LUPDATE";
        //            sql += " ,b.CEXPIRED,isnull(b.CBALANCE,0) CBALANCE,a.SEQ,a.QTY,a.ITEMS_PRICE,a.OLD_BALANCE ,a.CARDTENDOR";
        //            sql += " from[dbo].[CARDTRANS] a";
        //            sql += " left join[CARDS] b on a.BARCODE = b.BARCODE ";// and a.CUSED= b.CUSED  and a.CUSED1= b.CUSED1";
        //            sql += " where a.MRTSLIPNO LIKE '" + slipno + "%' ORDER BY CTID";
        //        }

        //        var value = new DataContext().RunQuery<CardtranModels.slipModel>(sql);

        //        ret.Data = value;
        //        ret.Respon.Result = true;
        //        ret.Respon.ErrorMessage = "";
        //        return ret;
        //    }
        //    catch (Exception e)
        //    {
        //        ret.Respon.ErrorMessage = "API : " + e.Message.ToString();
        //        //ret.SystemErrorMessage = e.StackTrace;
        //        ret.Respon.Result = false;
        //        return ret;
        //    }

        //}
        //public ResponseMessage Sel_PrintSlip_INV(string slipno)
        //{
        //    var ret = new ResponseMessage();
        //    try
        //    {
        //        var conn = new DataContext();
        //        string sql = "";

        //        var ret_config = new System_POS().Config_Load("");
        //        List<SysConfigModels> data_config = new List<SysConfigModels>();
        //        data_config = (List<SysConfigModels>)ret_config.Data;

        //        if (data_config[0].WALLET_TYPE == cl_const.WALLET_TYPE.APIHUBCPN)
        //        {
        //            sql = " select ";
        //            sql += " (select top 1 BRNNAMETHAI as COMPNAME from COMPANYPROFILE) as COMPNAME";
        //            sql += " ,(select top 1 BRNTAXID from COMPANYPROFILE) as COMPBRNTAXID";
        //            sql += " ,(select top 1 REMARK from COMPANYPROFILE) as COMPNAME_remark";
        //            sql += " ,a.BARCODE ,a.MRTAMOUNT,a.MRTSLIPNO,a.FOODNAME,a.LUPDATE";
        //            sql += " ,b.CEXPIRED,isnull(b.CBALANCE,0) CBALANCE,a.SEQ,a.QTY,a.ITEMS_PRICE,a.OLD_BALANCE ,tendername.tname as 'CARDTENDOR',a.TAXINVOICE,a.CARDREF";
        //            sql += " from[dbo].[CARDTRANS] a";
        //            sql += " left join[CARDS] b on a.BARCODE = b.BARCODE ";// and a.CUSED= b.CUSED  and a.CUSED1= b.CUSED1";
        //            sql += " left join [tendername]  on tendername.tcode = a.CARDTENDOR ";
        //            sql += " where a.MRTSLIPNO LIKE '" + slipno + "%' ORDER BY CTID";
        //        }
        //        else
        //        {
        //            sql = " select ";
        //            sql += " (select top 1 BRNNAMETHAI as COMPNAME from COMPANYPROFILE) as COMPNAME";
        //            sql += " ,(select top 1 BRNTAXID from COMPANYPROFILE) as COMPBRNTAXID";
        //            sql += " ,a.BARCODE ,a.MRTAMOUNT,a.MRTSLIPNO,a.FOODNAME,a.LUPDATE";
        //            sql += " ,b.CEXPIRED,isnull(b.CBALANCE,0) CBALANCE,a.SEQ,a.QTY,a.ITEMS_PRICE,a.OLD_BALANCE ,TENDER.NAME as 'CARDTENDOR',a.TAXINVOICE,a.CARDREF";
        //            sql += " from[dbo].[CARDTRANS] a";
        //            sql += " left join[CARDS] b on a.BARCODE = b.BARCODE ";// and a.CUSED= b.CUSED  and a.CUSED1= b.CUSED1";
        //            sql += " left join" + conn.DB_backup + "[TENDER]  on TENDER.CODE = a.CARDTENDOR ";
        //            sql += " where a.MRTSLIPNO LIKE '" + slipno + "%' ORDER BY CTID";
        //        }


        //        var value = conn.RunQuery<CardtranModels.slipModel>(sql);

        //        ret.Data = value;
        //        ret.Respon.Result = true;
        //        ret.Respon.ErrorMessage = "";
        //        return ret;
        //    }
        //    catch (Exception e)
        //    {
        //        ret.Respon.ErrorMessage = "API : " + e.Message.ToString();
        //        //ret.SystemErrorMessage = e.StackTrace;
        //        ret.Respon.Result = false;
        //        return ret;
        //    }

        //}
        //public ResponseMessage Sel_PrintSlip_CN(string VOIDNO)
        //{
        //    var ret = new ResponseMessage();
        //    try
        //    {
        //        var conn = new DataContext();
        //        string sql = "";

        //        var ret_config = new System_POS().Config_Load("");
        //        List<SysConfigModels> data_config = new List<SysConfigModels>();
        //        data_config = (List<SysConfigModels>)ret_config.Data;

        //        if (data_config[0].WALLET_TYPE == cl_const.WALLET_TYPE.APIHUBCPN)
        //        {
        //            //มีการยืม ฟิว
        //            sql = " select ";
        //            sql += " (select top 1 BRNNAMETHAI as COMPNAME from COMPANYPROFILE) as COMPNAME";
        //            sql += " ,(select top 1 BRNTAXID from COMPANYPROFILE) as COMPBRNTAXID";
        //            sql += " ,(select top 1 REMARK from COMPANYPROFILE) as COMPNAME_remark";
        //            sql += " ,a.BARCODE ,a.MRTAMOUNT,a.MRTSLIPNO,a.FOODNAME,a.LUPDATE";
        //            sql += " ,b.CEXPIRED,isnull(b.CBALANCE,0) CBALANCE,a.SEQ,a.QTY,a.ITEMS_PRICE,a.OLD_BALANCE ,tendername.tname as 'CARDTENDOR',a.TAXINVOICE,a.CREDITNOTES ,a.CARDREF_CN";
        //            sql += " from[dbo].[CARDTRANS] a";
        //            sql += " left join[CARDS] b on a.BARCODE = b.BARCODE ";// and a.CUSED= b.CUSED  and a.CUSED1= b.CUSED1";
        //            sql += " left join [tendername]  on tendername.tcode = a.CARDTENDOR ";
        //            sql += " where a.VOIDNO = '" + VOIDNO + "' and a.MRTSTATUS = 'V' ORDER BY CTID";
        //        }
        //        else
        //        {
           
        //        }


        //        var value = conn.RunQuery<CardtranModels.slipModel>(sql);

        //        ret.Data = value;
        //        ret.Respon.Result = true;
        //        ret.Respon.ErrorMessage = "";
        //        return ret;
        //    }
        //    catch (Exception e)
        //    {
        //        ret.Respon.ErrorMessage = "API : " + e.Message.ToString();
        //        //ret.SystemErrorMessage = e.StackTrace;
        //        ret.Respon.Result = false;
        //        return ret;
        //    }

        //}
        //public ResponseMessage Sel_PrintSlip_multi(string slipno)
        //{
        //    var ret = new ResponseMessage();
        //    try
        //    {
        //        string sql = "";
        //        sql = " select a.BARCODE ,a.MRTAMOUNT,a.MRTSLIPNO,a.FOODNAME,a.LUPDATE";
        //        sql += " ,b.CEXPIRED,isnull(b.CBALANCE,0) CBALANCE";
        //        sql += " from[dbo].[CARDTRANS] a";
        //        sql += " inner join[CARDS] b on a.BARCODE = b.BARCODE ";// and a.CUSED= b.CUSED  and a.CUSED1= b.CUSED1";
        //        sql += " where a.MRTSLIPNO LIKE '" + slipno + "%' ORDER BY CTID";
        //        var value = new DataContext().RunQuery<CardtranModels.slipModel>(sql);

        //        ret.Data = value;
        //        ret.Respon.Result = true;
        //        ret.Respon.ErrorMessage = "";
        //        return ret;
        //    }
        //    catch (Exception e)
        //    {
        //        ret.Respon.ErrorMessage = "API : " + e.Message.ToString();
        //        //ret.SystemErrorMessage = e.StackTrace;
        //        ret.Respon.Result = false;
        //        return ret;
        //    }

        //}
        //public ResponseMessage Sel_CHKcard_Multi(CHKcard_MultiModels data)
        //{
        //    var ret = new ResponseMessage();
        //    try
        //    {


        //        string BARCODE = data.BARCODE;
        //        int Nettotel = data.Nettotel;
        //        //BARCODE = BARCODE.Replace(" ", "+");
        //        var Ecards = new EcardsCL().CHK_Ecard(BARCODE);
        //        List<EcardModels> Ecards_data = new List<EcardModels>();
        //        if (Ecards.Respon.Result == false)
        //        {
        //            return Ecards;
        //        }
        //        //else
        //        //{
        //        //    Ecards_data = (List<ECARDS>)(Ecards.Data);
        //        //}

        //        var Card_ret = new ResponseMessage();

        //        Card_ret = new CHK_cardsCL().chkcard(BARCODE, Nettotel);
        //        //List<CardModels> card_data = new List<CardModels>();
        //        if (Card_ret.Respon.Result == false)
        //        {
        //            return Card_ret;
        //        }

        //        //else
        //        //{
        //        //    card_data = (List<CardModels>)(card.Data);
        //        //}


        //        ret.Respon.ErrorMessage = "";
        //        ret.Respon.Result_value = "";
        //        ret.Respon.SystemErrorMessage = "";
        //        ret.Respon.Result = true;
        //        ret.Data = Card_ret.Data;
        //        return ret;
        //    }
        //    catch (Exception e)
        //    {
        //        ret.Respon.SystemErrorMessage = "API : " + e.Message.ToString();
        //        //ret.SystemErrorMessage = e.StackTrace;
        //        ret.Respon.Result = false;
        //    }
        //    return ret;
        //    //END  chkeck-----------------------------------------------------
        //}
        //public ResponseMessage Sel_CHKcard_Postpaid(CHKcard_MultiModels data)
        //{
        //    var ret = new ResponseMessage();
        //    try
        //    {

        //        var ret_config = new System_POS().Config_Load("");
        //        List<SysConfigModels> data_config = new List<SysConfigModels>();
        //        data_config = (List<SysConfigModels>)ret_config.Data;


        //        string BARCODE = data.BARCODE;
        //        int Nettotel = data.Nettotel;
        //        //BARCODE = BARCODE.Replace(" ", "+");
        //        var Ecards = new EcardsCL().CHK_Ecard(BARCODE);
        //        List<EcardModels> Ecards_data = new List<EcardModels>();
        //        if (Ecards.Respon.Result == false)
        //        {
        //            return Ecards;
        //        }
        //        //else
        //        //{
        //        //    Ecards_data = (List<ECARDS>)(Ecards.Data);
        //        //}

        //        var Card_ret = new ResponseMessage();

        //        if (data_config[0].CUSGROUP == cl_const.CUSGROUP.ATR)
        //        {
        //            Card_ret = new CHK_cardsCL().chkcard_Save(data_config[0], data);
        //            if (Card_ret.Respon.Result == false)
        //            {
        //                return Card_ret;
        //            }
        //            Card_ret = new CHK_cardsCL().chkcard_Potpaid(data_config[0], data);
        //            //List<CardModels> card_data = new List<CardModels>();
        //            if (Card_ret.Respon.Result == false)
        //            {
        //                return Card_ret;
        //            }
        //        }
        //        else
        //        {
        //            Card_ret = new CHK_cardsCL().chkcard(BARCODE, Nettotel);
        //            //List<CardModels> card_data = new List<CardModels>();
        //            if (Card_ret.Respon.Result == false)
        //            {
        //                return Card_ret;
        //            }
        //        }



        //        //else
        //        //{
        //        //    card_data = (List<CardModels>)(card.Data);
        //        //}


        //        ret.Respon.ErrorMessage = "";
        //        ret.Respon.Result_value = "";
        //        ret.Respon.SystemErrorMessage = "";
        //        ret.Respon.Result = true;
        //        ret.Data = Card_ret.Data;
        //        return ret;
        //    }
        //    catch (Exception e)
        //    {
        //        ret.Respon.SystemErrorMessage = "API : " + e.Message.ToString();
        //        //ret.SystemErrorMessage = e.StackTrace;
        //        ret.Respon.Result = false;
        //    }
        //    return ret;
        //    //END  chkeck-----------------------------------------------------
        //}
        //public ResponseMessage Sel_Rpt_dayend(string CorpBRNID, string shopid, string MRTLUPDATE)
        //{
        //    var ret = new ResponseMessage();
        //    try
        //    {

        //        DateTime DOCDATE = Convert.ToDateTime(MRTLUPDATE);
        //        DataContext conn = new DataContext();
        //        string dddd = new Center().Condate(DOCDATE, "ymd2");
        //        string sql = "";
        //        ////sql = " SELECT  [FOODNAME],sum(MRTAMOUNT) as MRTAMOUNT, ";
        //        //sql = " SELECT  sum(MRTAMOUNT) as MRTAMOUNT, ";
        //        //sql += " 'TOTALCARD' = (select isnull(sum(TOTALCARD),0)as TOTALCARD from [SHOPCARDEND] where cast([CARDENDDATE]as date) = '" + dddd + "' and SHOPID = '" + shopid + "' ) ";
        //        //sql += " FROM[CARDTRANS] ";
        //        //sql += " where MRTSTATUS = 'S' and SHOPID = '" + shopid + "'   and cast(MRTLUPDATE as date) = '" + dddd + "'";
        //        ////sql += " group by[FOODNAME] ";
        //        ///

        //        var ret_config = new System_POS().Config_Load("");
        //        List<SysConfigModels> data_config = new List<SysConfigModels>();
        //        data_config = (List<SysConfigModels>)ret_config.Data;

        //        if (data_config[0].CUSGROUP == cl_const.CUSGROUP.CPN)
        //        {
        //            //sql = " select CARDTENDOR,sum(MRTAMOUNT) as MRTAMOUNT,sum(TOTALCARD) as TOTALCARD,  count(BARCODE) as TOTALCARD_QTY from(";
        //            //sql += "\n SELECT distinct td.tname ,'CARDTENDOR' =(case when  isnull(td.tname,'')  ='' then 'ยอดขาย Cashcard' else 'ยอดขาย E-Wallet' end) ";
        //            //sql += "\n  ,BARCODE ,sum(MRTAMOUNT) as MRTAMOUNT, ";
        //            //sql += "\n 'TOTALCARD' = case when CARDTENDOR ='' then (select isnull(sum(TOTALCARD),0)as TOTALCARD from [SHOPCARDEND] where cast([CARDENDDATE]as date) = '" + dddd + "' and SHOPID = '" + shopid + "' )   else 0 end";
        //            //sql += "\n FROM[CARDTRANS]   left join  tendername td on CARDTENDOR =td.tcode ";
        //            //sql += "\n where MRTSTATUS = 'S' and SHOPID = '" + shopid + "' ";//  and cast(MRTLUPDATE as date) = '" + dddd + "'";
        //            //sql += "\n  GROUP BY CARDTENDOR,td.tname ,BARCODE";
        //            //sql += "\n ) as sss group by CARDTENDOR ";


        //            sql = " select  CARDTENDOR,sum(MRTAMOUNT) as MRTAMOUNT,(select isnull(sum(TOTALCARD), 0) as TOTALCARD from[SHOPCARDEND] where cast([CARDENDDATE] as date) = '" + dddd + "' and SHOPID = '" + shopid + "' ) as TOTALCARD,  count(MRTSLIPNO) as TOTALCARD_QTY from( " +
        //                "\n  SELECT 1 as seq ,'CARDTENDOR' = 'ยอดขาย Cashcard' " +
        //                "\n  ,td.tname " +
        //                "\n  ,SUBSTRING(MRTSLIPNO, 0, charindex('-', MRTSLIPNO, 0)) MRTSLIPNO ,sum(MRTAMOUNT) as MRTAMOUNT,  " +
        //                "\n  'TOTALCARD' = 0" +
        //                "\n  FROM[CARDTRANS]   left join  tendername td on CARDTENDOR = td.tcode " +
        //                "\n  where MRTSTATUS in('S') and isnull(td.tname,'')= '' and SHOPID = '" + shopid + "'  and cast(MRTLUPDATE as date) = '" + dddd + "'" +
        //                "\n  GROUP BY CARDTENDOR,td.tname ,MRTSTATUS,SUBSTRING(MRTSLIPNO, 0, charindex('-', MRTSLIPNO, 0)) " +
        //                "\n  union " +
        //                "\n  SELECT 2 as seq ,'CARDTENDOR' = 'ยอดขาย E-Wallet' " +
        //                "\n  ,td.tname " +
        //                "\n  ,SUBSTRING(MRTSLIPNO, 0, charindex('-', MRTSLIPNO, 0)) MRTSLIPNO ,sum(MRTAMOUNT) as MRTAMOUNT,  " +
        //                "\n  'TOTALCARD' = 0 " +
        //                "\n  FROM[CARDTRANS]   left join  tendername td on CARDTENDOR = td.tcode " +
        //                "\n  where MRTSTATUS in('S') and isnull(td.tname,'')<> '' and SHOPID = '" + shopid + "'  and cast(MRTLUPDATE as date) = '" + dddd + "'" +
        //                "\n  GROUP BY CARDTENDOR,td.tname ,MRTSTATUS,SUBSTRING(MRTSLIPNO, 0, charindex('-', MRTSLIPNO, 0)) " +
        //                "\n  union " +
        //                "\n  SELECT 3 as seq ,'CARDTENDOR' = 'ยกเลิกการขาย' " +
        //                "\n  ,td.tname " +
        //                "\n  ,VOIDNO as MRTSLIPNO ,sum(MRTAMOUNT) as MRTAMOUNT,  " +
        //                "\n  'TOTALCARD' = 0 " +
        //                "\n  FROM[CARDTRANS]   left join  tendername td on CARDTENDOR = td.tcode " +
        //                "\n  where MRTSTATUS in('V')  and SHOPID = '" + shopid + "'   and cast(MRTLUPDATE as date) = '" + dddd + "'" +
        //                "\n  GROUP BY CARDTENDOR,td.tname ,MRTSTATUS,VOIDNO " +
        //                "\n  ) as sss group by CARDTENDOR ,seq order by seq ";

        //        }
        //        else if (data_config[0].CUSGROUP == cl_const.CUSGROUP.ATR)
        //        {
        //            //sql = " SELECT  [FOODNAME],sum(MRTAMOUNT) as MRTAMOUNT, ";
        //            sql = " SELECT  sum(MRTAMOUNT) as MRTAMOUNT, 'CARDTENDOR' = 'ยอดขาย Cashcard' ,";
        //            sql += " 'TOTALCARD' = (select isnull(sum(TOTALCARD),0)as TOTALCARD from [SHOPCARDEND] where cast([CARDENDDATE]as date) = '" + dddd + "' and SHOPID = '" + shopid + "' ) ";
        //            sql += " FROM[CARDTRANS] ";
        //            sql += " where MRTSTATUS = 'S' and SHOPID = '" + shopid + "'   and cast(MRTLUPDATE as date) = '" + dddd + "'";
        //            //sql += " group by[FOODNAME] ";
        //        }
        //        else
        //        {
        //            sql = " select CARDTENDOR,sum(MRTAMOUNT) as MRTAMOUNT,sum(TOTALCARD) as TOTALCARD from(";
        //            sql += " SELECT 'CARDTENDOR' =(case when  isnull(td.name,'')  ='' then 'ยอดขาย Cashcard' else 'ยอดขาย E-Wallet' end) ";
        //            sql += " ,sum(MRTAMOUNT) as MRTAMOUNT, ";
        //            sql += " 'TOTALCARD' = (select isnull(sum(TOTALCARD),0)as TOTALCARD from [SHOPCARDEND] where cast([CARDENDDATE]as date) = '" + dddd + "' and SHOPID = '" + shopid + "' )   else 0 end";
        //            sql += " FROM[CARDTRANS] left join " + conn.DB_backup + "tender td on CARDTENDOR =td.code";
        //            sql += " where MRTSTATUS = 'S' and SHOPID = '" + shopid + "'   and cast(MRTLUPDATE as date) = '" + dddd + "'";
        //            sql += "  GROUP BY CARDTENDOR,td.name ";
        //            sql += " ) as sss group by CARDTENDOR ";
        //        }



        //        var value = conn.RunQuery<CardtranModels.DayendModel>(sql);

        //        ret.Data = value;
        //        ret.Respon.Result = true;
        //        ret.Respon.ErrorMessage = "";
        //        return ret;
        //    }
        //    catch (Exception e)
        //    {
        //        ret.Respon.ErrorMessage = "API : " + e.Message.ToString();
        //        //ret.SystemErrorMessage = e.StackTrace;
        //        ret.Respon.Result = false;
        //        return ret;
        //    }

        //}
        //public ResponseMessage Sel_Repay(string POSID)
        //{
        //    var ret = new ResponseMessage();
        //    try
        //    {
        //        //string DOCDATE = new Center().Condate(workdate, "ymd hh:mm:ss");
        //        DataContext conn = new DataContext();
        //        //DateTime DOCDATE = Convert.ToDateTime(workdate);
        //        //string dddd = new Center().Condate(DOCDATE, "ymd2");
        //        string sql = "";

        //        sql = " SELECT ";
        //        sql += " sc.CUSED,sc.BARCODE,s.SHOPID,s.POSID ";
        //        sql += " ,'MRTAMOUNT' = sd.NETAMOUNT ";
        //        sql += " ,s.MRTSLIPNO ";
        //        sql += " ,'MRTLUPDATE' = s.DOCDATE ";
        //        sql += " ,'FOODNAME' = sd.FOODNAME ";
        //        sql += " ,'GP' = sd.GP ";
        //        sql += " ,'GPAMOUNT' = sd.GPAMOUNT ";
        //        sql += " ,'GPRULE' = sd.GPRULE ";
        //        sql += " ,'CARDTENDOR' = s.PAYTYPE ";
        //        sql += " ,'CARDTENDOR_Name'= ( select top 1 tname from tendername where tcode = s.PAYTYPE ) ";
        //        sql += " ,'CARDPURSE' = s.CARDPURSE ";
        //        sql += " ,'foodid' = sd.FOODID ";
        //        sql += " ,'seq' = sd.SEQ ";
        //        sql += " ,'items_price' = sd.items_price ";
        //        sql += " ,'qty' = sd.qty ";
        //        sql += " FROM " + conn.DB_backup + "[SALE]s ";
        //        sql += " inner join " + conn.DB_backup + "SALE_ITEMS sd on s.MRTSLIPNO = sd.MRTSLIPNO ";
        //        sql += " inner join " + conn.DB_backup + "SALE_CARD sc on s.MRTSLIPNO = sc.MRTSLIPNO ";
        //        sql += " where DC_STATE = 'W' ";
        //        sql += " and s.POSID = '" + POSID + "' ";
        //        sql += " and s.PAYTYPE <> '' ";
        //        sql += " and cast(s.DOCDATE as date)= cast(getdate() as date)";
        //        sql += " order by s.MRTSLIPNO,sd.SEQ ";



        //        var value = conn.RunQuery<CardtranModels.RepayModel>(sql);

        //        ret.Data = value;
        //        ret.Respon.Result = true;
        //        ret.Respon.ErrorMessage = "";
        //        return ret;
        //    }
        //    catch (Exception e)
        //    {
        //        ret.Respon.ErrorMessage = "API : " + e.Message.ToString();
        //        //ret.SystemErrorMessage = e.StackTrace;
        //        ret.Respon.Result = false;
        //        return ret;
        //    }

        //}
        //public ResponseMessage Sel_Void_EWALLET(string Vtype, string shopid, string barcode)
        //{
        //    var ret = new ResponseMessage();
        //    try
        //    {
        //        //string DOCDATE = new Center().Condate(workdate, "ymd hh:mm:ss");
        //        DataContext conn = new DataContext();
        //        //DateTime DOCDATE = Convert.ToDateTime(workdate);
        //        //string dddd = new Center().Condate(DOCDATE, "ymd2");
        //        string sql = "";
        //        switch (Vtype)
        //        {
        //            case cl_const.Void_TYPE.CANCEL:
        //                sql = " select BARCODE ,MRTSLIPNO,SEQ,sum(MRTAMOUNT) as MRTAMOUNT ,CARDTENDOR,CARDTENDOR_NAME from(" +
        //                    " select BARCODE " +
        //                    ",  SUBSTRING(MRTSLIPNO, 0, charindex('-', MRTSLIPNO, 0)) as MRTSLIPNO" +
        //                    ", 0 as SEQ,MRTAMOUNT,CARDTENDOR ,tname as CARDTENDOR_NAME from[CARDTRANS] left join tendername on CARDTRANS.CARDTENDOR= tendername.tcode" +
        //                    " where shopid = '" + shopid + "' and barcode = '" + barcode + "' and isnull(VOIDNO,'')  ='' and CARDTENDOR <>''" +
        //                    " ) as ss group by BARCODE,MRTSLIPNO,SEQ,CARDTENDOR,CARDTENDOR_NAME";
        //                break;
        //            case cl_const.Void_TYPE.REFUND:
        //                sql = " select BARCODE " +
        //                    " ,  SUBSTRING(MRTSLIPNO, 0, charindex('-', MRTSLIPNO, 0)) as MRTSLIPNO " +
        //                    " , SUBSTRING(MRTSLIPNO, charindex('-', MRTSLIPNO, 0) + 1, LEN(MRTSLIPNO)) as SEQ " +
        //                    " ,FOODNAME,MRTAMOUNT,CARDTENDOR ,tname as CARDTENDOR_NAME from[CARDTRANS] left join tendername on CARDTRANS.CARDTENDOR= tendername.tcode" +
        //                     " where shopid = '" + shopid + "' and barcode = '" + barcode + "' and isnull(VOIDNO,'')  =''  and CARDTENDOR <>'' ";
        //                break;
        //            case cl_const.Void_TYPE.Verify_slip:
        //                sql = " select BARCODE ,MRTSLIPNO,SEQ,sum(MRTAMOUNT) as MRTAMOUNT ,CARDTENDOR,CARDTENDOR_NAME from(" +
        //                    " select BARCODE " +
        //                    ",  SUBSTRING(MRTSLIPNO, 0, charindex('-', MRTSLIPNO, 0)) as MRTSLIPNO" +
        //                    ", 0 as SEQ,MRTAMOUNT,CARDTENDOR ,tname as CARDTENDOR_NAME from[CARDTRANS] left join tendername on CARDTRANS.CARDTENDOR= tendername.tcode" +
        //                    " where shopid = '" + shopid + "' and barcode = '" + barcode + "' and isnull(VOIDNO,'')  =''  and CARDTENDOR <>''" +
        //                    " ) as ss group by BARCODE,MRTSLIPNO,SEQ,CARDTENDOR,CARDTENDOR_NAME";
        //                break;
        //            default:
        //                ret.Respon.Result = false;
        //                ret.Respon.ErrorMessage = " ประเภทการ Void ไม่ถูกต้อง";
        //                return ret;
        //                break;

        //        }
        //        var value = conn.RunQuery<VoidModels.Void_EWALLET_List>(sql);

        //        ret.Data = value;
        //        ret.Respon.Result = true;
        //        ret.Respon.ErrorMessage = "";
        //        return ret;
        //    }
        //    catch (Exception e)
        //    {
        //        ret.Respon.ErrorMessage = "API : " + e.Message.ToString();
        //        //ret.SystemErrorMessage = e.StackTrace;
        //        ret.Respon.Result = false;
        //        return ret;
        //    }

        //}
        //#endregion
        #region "Save"

        public ResponseMessage Save(CardtranModels.SALE_INT Input_data)
        {
            var con = new DataContext();
            var ret = new ResponseMessage();
            //var BARCODE = Input_data.Cardtran[0].BARCODE;

            //var Sql_check = new Sql_check();
            string ISNOR = "";// "NOR";

            //Input_data.BARCODE = "N0601110953";

            var ret_config = new System_POS().Config_Load("");
            List<SysConfigModels> data_config = new List<SysConfigModels>();
            data_config = (List<SysConfigModels>)ret_config.Data;
            var ret_save = new ResponseMessage();
            
            try
            {

                con.Open();
                // Gendocno
                //string docno = new Doccument().Gendocno(con, Input_data.SHOPID.ToString());
                //Input_data.MRTSLIPNO = new Doccument().Gensoslip(con, Input_data.SHOPID.ToString());
                if (Input_data.MRTSLIPNO == "")
                {
                    throw new Exception("ไม่พบเลขที่บิลขาย");
                }
                string query = "";

                //if (data_config[0].POSTYPE == cl_const.POSTYPE.postpaid)
                //{

                //    ret_save = Save_Cardtran_Postpaid(con, data_config[0], Input_data, ISNOR);
                //    if (ret_save.Respon.Result == true)
                //    {
                //        query += ret_save.Data;
                //        ret.Respon = ret_save.Respon;
                //        ret.Data = "";
                //    }
                //    else
                //    {
                //        return ret_save;
                //    }


                //}
                //else
                //{
                //    //ถ้า wallet ข้อมูลจะลงตอน จ่ายเงินสำเร็จเท่านั้น
                //    if (Input_data.PAYTYPE == "" || Input_data.PAYTYPE == "TRUEEDC")
                //    {
                //        ret_save = Save_Cardtran(con, Input_data, ISNOR);
                //        if (ret_save.Respon.Result == true)
                //        {
                //            query += ret_save.Data;
                //            ret.Respon = ret_save.Respon;
                //            ret.Data = "";
                //        }
                //        else
                //        {
                //            return ret_save;
                //        }
                //    }
                //}



                //if (data_config[0].USESTOCK)
                //{
                    //query += Save_Sale_ST(con, data_config[0], Input_data);
                    TR_Movment MOV = new TR_Movment();
                    var save_stock = new ResponseMessage();
                    save_stock = MOV.Save_Data_byPOS(con, Input_data, Center.UI_STATE.UINew);
                    con.Excute("  USE [" + con.DB_LOcal_name + "]  ");
                    if (save_stock.Respon.Result == false)
                    {
                        throw new Exception("Save Balance false");
                    }
                //}
                //else
                //{
                //    query += Save_Sale(con, data_config[0], Input_data);
                //}


                //log query
                //log query
                //log query
                //log query
                //log query
                //log query
                //log query

                //var a = con.Excute(query);

                con.Commit();
                ret.Respon.Result_value2 = Input_data.MRTSLIPNO;
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

                con.Rollback();

                ret.Respon.SystemErrorMessage = "API : " + e.Message.ToString();
                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
            }
            finally
            {
                con.close();
            }
            return ret;
        }
        //public string Save_Sale(DataContext con, SysConfigModels data_config, CardtranModels.SALE_INT Input_data)
        //{
        //    string DOCDATE = new Center().Condate(Input_data.DOCDATE, "ymd hh:mm:ss");
        //    var Sql_check = new Sql_check();

        //    string query = "";
        //    int i = 0;
        //    query += " INSERT INTO " + con.DB_backup + "[SALE] ";
        //    query += "(MRTSLIPNO, SHOPID, POSID,DOCDATE,DOCYEAR,DOCMONT, BACKUPFLG, VOIDNO, SHOPENDFLG, TAXINVOICE, CREDITNOTES, CARDTENDOR, CARDREF, CARDPURSE, taxPrint, CUS_ID, PAYTYPE, PAYAMOUNT, AMOUNT, DISTP, DISVALUE, AFTERDIS, VATTP, VATVALUE, AFTERVAT, NETAMOUNT, QTY_TOTAL, STATUS, CRDATE, CBY, MODATE, MBY ,DC_STATE) ";
        //    query += " \n VALUES( ";
        //    query += "'" + Input_data.MRTSLIPNO + "'";
        //    query += ",'" + Input_data.SHOPID + "' ";
        //    query += ",'" + Input_data.POSID + "' ";
        //    query += ",'" + DOCDATE + "' ";
        //    query += ",'" + Input_data.DOCYEAR + "' ";
        //    query += ",'" + Input_data.DOCMONT + "' ";
        //    query += ",0";
        //    query += ",'' ";
        //    query += ",0";
        //    query += ",'" + Input_data.TAXINVOICE + "' ";
        //    query += ",'" + Input_data.CREDITNOTES + "' ";
        //    query += ",'" + Input_data.CARDTENDOR + "' ";
        //    query += ",'" + Input_data.CARDREF + "'";
        //    query += ",'" + Input_data.CARDPURSE + "' ";
        //    query += ",'" + Input_data.taxPrint + "' ";
        //    query += ",'" + Input_data.CUS_ID + "'";
        //    query += ",'" + Input_data.PAYTYPE + "'";
        //    query += ",'" + Input_data.PAYAMOUNT + "' ";
        //    query += ",'" + Input_data.AMOUNT + "' ";
        //    query += ",'" + Input_data.DISTP + "' ";
        //    query += ",'" + Input_data.DISVALUE + "' ";
        //    query += ",'" + Input_data.AFTERDIS + "' ";
        //    query += ",'" + Input_data.VATTP + "'";
        //    query += ",'" + Input_data.VATVALUE + "'";
        //    query += ",'" + Input_data.AFTERVAT + "'";
        //    query += ",'" + Input_data.NETAMOUNT + "'";
        //    query += ",'" + Input_data.QTY_TOTAL + "'";
        //    query += ",'1'";
        //    query += ",getdate() ";
        //    query += ",'" + Input_data.CBY + "'";
        //    query += ",getdate()";
        //    query += ",'" + Input_data.MBY + "'";
        //    query += ",'" + Input_data.DC_STATE + "') ";


        //    query += Sql_check.ROWCOUNT(Sql_check.Insert, "SALE");


        //    string SALE_CARD_H = "";
        //    SALE_CARD_H = " \n INSERT INTO  " + con.DB_backup + "[SALE_ITEMS] (SHOPID, MRTSLIPNO, POSID, SEQ, VOIDNO, FOODID, FOODNAME, GP, GPAMOUNT,GPRULE, ITEMS_PRICE, DISTP " +
        //              ", DISVALUE, AFTERDIS, VATTP, VATVALUE, AFTERVAT, NETAMOUNT " +
        //              ", STATUS, QTY, CHKFLG, PRO_ID, PRO_NAME, PRO_TEXT,MRTSTATUS) VALUES ";

        //    query += SALE_CARD_H;
        //    i = 0;
        //    foreach (CardtranModels.Saleitems val in Input_data.Saleitems)
        //    {
        //        if (i > 0) query += ",";
        //        query += "\n(";
        //        query += " '" + Input_data.SHOPID + "'";
        //        query += ",'" + Input_data.MRTSLIPNO + "'";
        //        query += ",'" + Input_data.POSID + "'";
        //        query += ",'" + val.SEQ + "'";
        //        query += ",''";
        //        query += ",'" + val.FOODID + "'";
        //        query += ",'" + val.FOODNAME + "'";

        //        query += ",'" + val.GP + "'";
        //        query += ",'" + val.GPAMOUNT + "'";
        //        query += ",'" + val.GPRULE + "'";
        //        query += ",'" + val.ITEMS_PRICE + "'";
        //        query += ",'" + val.DISTP + "'";
        //        query += ",'" + val.DISVALUE + "'";
        //        query += ",'" + val.AFTERDIS + "'";
        //        query += ",'" + val.VATTP + "'";
        //        query += ",'" + val.VATVALUE + "'";
        //        query += ",'" + val.AFTERVAT + "'";
        //        query += ",'" + val.NETAMOUNT + "'";
        //        query += ",'1'";
        //        query += ",'" + val.QTY + "'";
        //        query += ",0";
        //        query += ",'" + val.PRO_ID + "'";
        //        query += ",'" + val.PRO_NAME + "'";
        //        query += ",'" + val.PRO_TEXT + "'";
        //        query += ",'S'";//MRTSTATUS
        //        query += ")";
                
        //        i++;
        //    }
        //    query += Sql_check.ROWCOUNT(Sql_check.Insert, "SALE_ITEMS");
        //    string sale_H = "\n   insert into  " + con.DB_backup + "[SALE_CARD]( MRTSLIPNO,  SHOPID, POSID, SEQ,BARCODE,PAYTYPE,  CUSED, CUSED1, MRTAMOUNT, CBALANCE, CBALANCEREMAIN, GP, GPAMOUNT, PRO_ID, PRO_NAME, PRO_TEXT, STATUS ) values";

        //    query += sale_H;
        //    i = 0;
        //    foreach (CardtranModels.Saleitems_card val in Input_data.Saleitems_card)
        //    {
        //        if (i > 0) query += ",";
        //        query += "\n(";

        //        query += "'" + Input_data.MRTSLIPNO + "'";
        //        query += ",'" + Input_data.SHOPID + "'";
        //        query += ",'" + Input_data.POSID + "'";
        //        query += ",'" + val.SEQ + "'";
        //        query += ",'" + val.BARCODE + "'";
        //        query += ",'" + val.PAYTYPE + "'";
        //        query += ",'" + val.CUSED + "'";
        //        query += ",'" + val.CUSED1 + "'";
        //        query += ",'" + val.MRTAMOUNT + "'";
        //        query += ",'" + val.CBALANCE + "'";
        //        query += ",'" + val.CBALANCEREMAIN + "'";
        //        query += ",'" + val.GP + "'";
        //        query += ",'" + val.GPAMOUNT + "'";
        //        query += ",'" + val.PRO_ID + "'";
        //        query += ",'" + val.PRO_NAME + "'";
        //        query += ",'" + val.PRO_TEXT + "'";
        //        query += ",'1'";
        //        query += ")";

        //        i++;
        //    }
        //    query += Sql_check.ROWCOUNT(Sql_check.Insert, "SALE_CARD");
        //    return query;
        //}
        /// <summary>
        /// ใช้ร่วมกัน stock
        /// </summary>
        /// <param name="con"></param>
        /// <param name="data_config"></param>
        /// <param name="Input_data"></param>
        /// <returns></returns>
        //public string Save_Sale_ST(DataContext con, SysConfigModels data_config, CardtranModels.SALE_INT Input_data)
        //{
        //    string DOCDATE = new Center().Condate(Input_data.DOCDATE, "ymd hh:mm:ss");
        //    var Sql_check = new Sql_check();

        //    string query = "";
        //    int i = 0;
        //    query += " INSERT INTO " + con.DB_backup + "[SALE] ";
        //    query += "(MRTSLIPNO, SHOPID, POSID,DOCDATE,DOCYEAR,DOCMONT, BACKUPFLG, VOIDNO, SHOPENDFLG, TAXINVOICE, CREDITNOTES, CARDTENDOR, CARDREF, CARDPURSE, taxPrint, CUS_ID, PAYTYPE, PAYAMOUNT, AMOUNT, DISTP, DISVALUE, AFTERDIS, VATTP, VATVALUE, AFTERVAT, NETAMOUNT, QTY_TOTAL, STATUS, CRDATE, CBY, MODATE, MBY ,DC_STATE,STCODE) ";
        //    query += " \n VALUES( ";
        //    query += "'" + Input_data.MRTSLIPNO + "'";
        //    query += ",'" + Input_data.SHOPID + "' ";
        //    query += ",'" + Input_data.POSID + "' ";
        //    query += ",'" + DOCDATE + "' ";
        //    query += ",'" + Input_data.DOCYEAR + "' ";
        //    query += ",'" + Input_data.DOCMONT + "' ";
        //    query += ",0";
        //    query += ",'' ";
        //    query += ",0";
        //    query += ",'" + Input_data.TAXINVOICE + "' ";
        //    query += ",'" + Input_data.CREDITNOTES + "' ";
        //    query += ",'" + Input_data.CARDTENDOR + "' ";
        //    query += ",'" + Input_data.CARDREF + "'";
        //    query += ",'" + Input_data.CARDPURSE + "' ";
        //    query += ",'" + Input_data.taxPrint + "' ";
        //    query += ",'" + Input_data.CUS_ID + "'";
        //    query += ",'" + Input_data.PAYTYPE + "'";
        //    query += ",'" + Input_data.PAYAMOUNT + "' ";
        //    query += ",'" + Input_data.AMOUNT + "' ";
        //    query += ",'" + Input_data.DISTP + "' ";
        //    query += ",'" + Input_data.DISVALUE + "' ";
        //    query += ",'" + Input_data.AFTERDIS + "' ";
        //    query += ",'" + Input_data.VATTP + "'";
        //    query += ",'" + Input_data.VATVALUE + "'";
        //    query += ",'" + Input_data.AFTERVAT + "'";
        //    query += ",'" + Input_data.NETAMOUNT + "'";
        //    query += ",'" + Input_data.QTY_TOTAL + "'";
        //    query += ",'1'";
        //    query += ",getdate() ";
        //    query += ",'" + Input_data.CBY + "'";
        //    query += ",getdate()";
        //    query += ",'" + Input_data.MBY + "'";
        //    query += ",'" + Input_data.DC_STATE + "' ";
        //    query += ",'" + Input_data.STCODE + "') ";


        //    query += Sql_check.ROWCOUNT(Sql_check.Insert, "SALE");


        //    string SALE_CARD_H = "";
        //    SALE_CARD_H = " \n INSERT INTO  " + con.DB_backup + "[SALE_ITEMS] (SHOPID, MRTSLIPNO, POSID, SEQ, VOIDNO, FOODID, FOODNAME,PCODE,PNAME,UNITCODE,UNITNAME, GP, GPAMOUNT,GPRULE, ITEMS_PRICE, DISTP " +
        //              ", DISVALUE, AFTERDIS, VATTP, VATVALUE, AFTERVAT, NETAMOUNT " +
        //              ", STATUS, QTY, CHKFLG, PRO_ID, PRO_NAME, PRO_TEXT) VALUES ";

        //    query += SALE_CARD_H;
        //    i = 0;
        //    foreach (CardtranModels.Saleitems val in Input_data.Saleitems)
        //    {
        //        if (i > 0) query += ",";
        //        query += "\n(";
        //        query += " '" + Input_data.SHOPID + "'";
        //        query += ",'" + Input_data.MRTSLIPNO + "'";
        //        query += ",'" + Input_data.POSID + "'";
        //        query += ",'" + val.SEQ + "'";
        //        query += ",''";
        //        query += ",'" + val.FOODID + "'";
        //        query += ",'" + val.FOODNAME + "'";

        //        query += ",'" + val.PCODE + "'";
        //        query += ",'" + val.PNAME + "'";

        //        query += ",'" + val.UNITCODE + "'";
        //        query += ",'" + val.UNITNAME + "'";

        //        query += ",'" + val.GP + "'";
        //        query += ",'" + val.GPAMOUNT + "'";
        //        query += ",'" + val.GPRULE + "'";
        //        query += ",'" + val.ITEMS_PRICE + "'";
        //        query += ",'" + val.DISTP + "'";
        //        query += ",'" + val.DISVALUE + "'";
        //        query += ",'" + val.AFTERDIS + "'";
        //        query += ",'" + val.VATTP + "'";
        //        query += ",'" + val.VATVALUE + "'";
        //        query += ",'" + val.AFTERVAT + "'";
        //        query += ",'" + val.NETAMOUNT + "'";
        //        query += ",'1'";
        //        query += ",'" + val.QTY + "'";
        //        query += ",0";
        //        query += ",'" + val.PRO_ID + "'";
        //        query += ",'" + val.PRO_NAME + "'";
        //        query += ",'" + val.PRO_TEXT + "'";
        //        query += ")";

        //        i++;
        //    }
        //    query += Sql_check.ROWCOUNT(Sql_check.Insert, "SALE_ITEMS");
        //    string sale_H = "\n   insert into  " + con.DB_backup + "[SALE_CARD]( MRTSLIPNO,  SHOPID, POSID, SEQ,BARCODE,PAYTYPE,  CUSED, CUSED1, MRTAMOUNT, CBALANCE, CBALANCEREMAIN, GP, GPAMOUNT, PRO_ID, PRO_NAME, PRO_TEXT, STATUS ) values";

        //    query += sale_H;
        //    i = 0;
        //    foreach (CardtranModels.Saleitems_card val in Input_data.Saleitems_card)
        //    {
        //        if (i > 0) query += ",";
        //        query += "\n(";

        //        query += "'" + Input_data.MRTSLIPNO + "'";
        //        query += ",'" + Input_data.SHOPID + "'";
        //        query += ",'" + Input_data.POSID + "'";
        //        query += ",'" + val.SEQ + "'";
        //        query += ",'" + val.BARCODE + "'";
        //        query += ",'" + val.PAYTYPE + "'";
        //        query += ",'" + val.CUSED + "'";
        //        query += ",'" + val.CUSED1 + "'";
        //        query += ",'" + val.MRTAMOUNT + "'";
        //        query += ",'" + val.CBALANCE + "'";
        //        query += ",'" + val.CBALANCEREMAIN + "'";
        //        query += ",'" + val.GP + "'";
        //        query += ",'" + val.GPAMOUNT + "'";
        //        query += ",'" + val.PRO_ID + "'";
        //        query += ",'" + val.PRO_NAME + "'";
        //        query += ",'" + val.PRO_TEXT + "'";
        //        query += ",'1'";
        //        query += ")";

        //        i++;
        //    }
        //    query += Sql_check.ROWCOUNT(Sql_check.Insert, "SALE_CARD");







        //    return query;
        //}
        //public ResponseMessage Save_Cardtran(DataContext con, CardtranModels.SALE_INT Input_data, string ISNOR)
        //{
        //    var ret = new ResponseMessage();
        //    var Sql_check = new Sql_check();
        //    int i = 0;
        //    string query = "";
        //    string query_H = "";
        //    Int16 shopEnd = 0;
        //    char[] MultiRun = new char[23];
        //    ResponseMessage card;
        //    List<CHK_cardsModels> card_data = new List<CHK_cardsModels>();
        //    ResponseMessage Ecards;

        //    if (Input_data.PAYTYPE == ISNOR)
        //    {
        //        for (int id = 0; id < 23; id++)
        //        {
        //            MultiRun[id] = (char)(65 + id);
        //        }
        //        //chkeck----------------------------------------------------

        //        card = new CHK_cardsCL().chkcard(Input_data.Cardtran[0].BARCODE, Input_data.NETAMOUNT, Input_data.Multicard);
        //        if (card.Respon.Result == false)
        //        {
        //            return card;
        //        }
        //        else
        //        {
        //            card_data = (List<CHK_cardsModels>)(card.Data);
        //        }

        //        Ecards = new EcardsCL().CHK_Ecard(Input_data.Cardtran[0].BARCODE);
        //        List<EcardModels> Ecards_data = new List<EcardModels>();
        //        if (Ecards.Respon.Result == false)
        //        {
        //            return Ecards;
        //        }
        //        else
        //        {
        //            Ecards_data = (List<EcardModels>)(Ecards.Data);
        //        }


        //        //บัตรหมดมูลค่าที่ร้านค้า ของการ์ดปัจจุบันเท่านั้น

        //        if (card_data[0].CBALANCE <= Input_data.NETAMOUNT)
        //        {
        //            shopEnd = 1;
        //        }
        //        else
        //        {
        //            shopEnd = 0;
        //        }

        //        //END  chkeck-----------------------------------------------------





        //        //log nomal
        //        //log nomal
        //        //log nomal
        //        //log nomal
        //        //log nomal
        //        //log nomal
        //        //log nomal
        //        //log nomal

        //    }

        //    var workingdate = new WorkingdateCL().chk_Workingdate("");
        //    if (workingdate.Count <= 0)
        //    {
        //        throw new Exception("มีการปิดสิ้นวันแล้ว กรุณาแจ้งผู้ดูแลระบบ");
        //    }
        //    string wordate_ = new Center().Condate(workingdate[0].DATEWORKING, "ymd hh:mm:ss");





        //    if (Input_data.CorpBRNID == "LJ")
        //    {
        //        query_H = "\n  INSERT INTO CARDTRANS (CUSED, CUSED1, BARCODE, SHOPID, POSID, MRTAMOUNT, " +
        //                            "MRTSTATUS, MRTSLIPNO, MRTLUPDATE, TID, UID, LUPDATE, BACKUPFLG,FOODID, FOODNAME," +
        //                            "SHOPENDFLG,GP,GPAMOUNT,seq,ITEMS_PRICE,QTY,OLD_BALANCE) VALUES ";
        //    }
        //    else
        //    {
        //        query_H = "\n  INSERT INTO CARDTRANS (CUSED, CUSED1, BARCODE, SHOPID, POSID, MRTAMOUNT, " +
        //                             "MRTSTATUS, MRTSLIPNO, MRTLUPDATE, TID, UID, LUPDATE, BACKUPFLG,FOODID, FOODNAME," +
        //                             "SHOPENDFLG,GP,GPAMOUNT,GPRULE,seq,ITEMS_PRICE,QTY,OLD_BALANCE,CARDTENDOR,CARDREF,CARDPURSE,TAXINVOICE) VALUES ";
        //    }

        //    query += query_H;
        //    i = 0;
        //    int CBALANCE = 0;
        //    if (Input_data.PAYTYPE == ISNOR)
        //    {
        //        CBALANCE = int.Parse(card_data[0].CBALANCE.ToString());
        //    }

        //    int useAMOUNT = 0;
        //    foreach (CardtranModels.Cardtran val in Input_data.Cardtran)
        //    {
        //        if (i > 0) query += ",";
        //        query += "\n(";
        //        if (Input_data.PAYTYPE == ISNOR)
        //        {
        //            query += "'" + card_data[0].CUSED + "'";
        //            query += ",'" + card_data[0].CUSED1 + "'";
        //        }
        //        else
        //        {
        //            query += "'1'";
        //            query += ",'1'";
        //        }
        //        query += ",'" + Input_data.Cardtran[0].BARCODE + "'";
        //        query += ",'" + Input_data.SHOPID + "'";
        //        query += ",'" + Input_data.POSID + "'";
        //        if (Input_data.Multicard == true)
        //        {
        //            int MRTAMOUNT_remain = val.MRTAMOUNT;
        //            int MRTAMOUNT = call_cbalance(ref CBALANCE, ref MRTAMOUNT_remain);
        //            val.MRTAMOUNT = MRTAMOUNT_remain;
        //            useAMOUNT += MRTAMOUNT;
        //            query += ",'" + MRTAMOUNT + "'";
        //        }
        //        else
        //        {
        //            query += ",'" + val.MRTAMOUNT + "'";
        //            useAMOUNT += val.MRTAMOUNT;
        //        }

        //        query += ",'" + val.MRTSTATUS + "'";
        //        if (Input_data.Multicard == true)
        //        {
        //            query += ",'" + Input_data.MRTSLIPNO + "-" + val.SEQ + "X'"; //MRTSLIPNO
        //        }
        //        else
        //        {
        //            query += ",'" + Input_data.MRTSLIPNO + "-" + val.SEQ + "'"; //MRTSLIPNO
        //        }
        //        query += ",'" + wordate_ + "'"; //MRTLUPDATE
        //        query += ",'" + val.TID + "'";
        //        query += ",'" + val.UID + "'";
        //        query += ",getdate()"; //LUPDATE
        //        query += ",0"; //BACKUPFLG
        //        query += ",'" + val.FOODID + "'";
        //        query += ",'" + val.FOODNAME + "'";
        //        query += ",'" + shopEnd.ToString() + "'";
        //        query += ",'" + val.GP + "'";
        //        query += ",'" + val.GPAMOUNT + "'";
        //        query += ",'" + val.GPRULE + "'";
        //        query += ",'" + val.SEQ + "'";
        //        query += ",'" + val.ITEMS_PRICE + "'";
        //        query += ",'" + val.QTY + "'";

        //        if (Input_data.PAYTYPE == ISNOR)
        //        {
        //            query += ",'" + card_data[0].CBALANCE + "'";//OLD_BALANCE
        //        }
        //        else
        //        {
        //            query += ",'0'";//OLD_BALANCE
        //        }


        //        if (Input_data.CorpBRNID == "LJ")
        //        {
        //        }
        //        else
        //        {
        //            query += ",'" + val.CARDTENDOR + "'";
        //            query += ",'" + val.CARDREF + "'";
        //        }
        //        query += ",'" + val.CARDPURSE + "'";
        //        query += ",'" + val.TAXINVOICE + "'";
        //        query += ")";

        //        i++;
        //    }

        //    query += Sql_check.ROWCOUNT(Sql_check.Insert, "CARDTRANS");
        //    if (Input_data.PAYTYPE == ISNOR)
        //    {
        //        if (Input_data.Cardtran.Count > 0)
        //        {
        //            if (shopEnd == 1)
        //            {
        //                query += Query_shopend_1(Input_data.SHOPID.ToString(), Input_data.POSID, Input_data.Cardtran[0].BARCODE, card_data[0].CUSED.ToString());
        //                //ret.Respon.Result = false;
        //                ret.Respon.ErrorMessage = "NOBALANCE";
        //                ret.Respon.Result_value = Input_data.Cardtran[0].BARCODE;
        //            }
        //            else
        //            {
        //                query += Query_shopend_0(useAMOUNT, Input_data.Cardtran[0].BARCODE, card_data[0].CUSED.ToString());
        //            }
        //        }
        //    }



        //    if (Input_data.Multicard == true)
        //    {

        //        //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
        //        //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
        //        //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
        //        //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
        //        int MRTAMOUNT_Remain = Input_data.Cardtran.Sum(s => s.MRTAMOUNT);
        //        //CardtranModels.Model Items_multi = new   CardtranModels.Model();
        //        //var Items_multi = Input_data.Items.Select.(c => ).ToList();
        //        int MultiRun_IDX = 0;
        //        foreach (CardtranModels.Saleitems_card val in Input_data.Saleitems_card)
        //        {
        //            if (Input_data.Cardtran[0].BARCODE == val.BARCODE) { continue; }
        //            //chkeck-----MulticardMulticardMulticardMulticardMulticard-----------------------------------------------

        //            var card_multi = new CHK_cardsCL().chkcard(val.BARCODE, MRTAMOUNT_Remain, Input_data.Multicard);
        //            List<CHK_cardsModels> card_data_multi = new List<CHK_cardsModels>();
        //            if (card_multi.Respon.Result == false)
        //            {
        //                return card_multi;
        //            }
        //            else
        //            {
        //                card_data_multi = (List<CHK_cardsModels>)(card_multi.Data);
        //            }

        //            var Ecards_multi = new EcardsCL().CHK_Ecard(val.BARCODE);
        //            List<EcardModels> Ecards_data_multi = new List<EcardModels>();
        //            if (Ecards_multi.Respon.Result == false)
        //            {
        //                return Ecards_multi;
        //            }
        //            else
        //            {
        //                Ecards_data_multi = (List<EcardModels>)(Ecards_multi.Data);
        //            }

        //            //END  chkeck------MulticardMulticardMulticardMulticardMulticard-----------------------------------------------





        //            query += "\n" + query_H;
        //            i = 0;
        //            useAMOUNT = 0;
        //            int CBALANCE_multi = int.Parse(card_data_multi[0].CBALANCE.ToString());
        //            foreach (CardtranModels.Cardtran val_multi in Input_data.Cardtran)
        //            {

        //                if (val_multi.MRTAMOUNT <= 0) { continue; }

        //                if (i > 0) query += ",";
        //                query += "\n(";
        //                if (Input_data.PAYTYPE == ISNOR)
        //                {
        //                    query += "'" + card_data_multi[0].CUSED + "'";
        //                    query += ",'" + card_data_multi[0].CUSED1 + "'";
        //                }
        //                else
        //                {
        //                    query += ",'1'";
        //                    query += ",'1'";
        //                }
        //                query += ",'" + val.BARCODE + "'";
        //                query += ",'" + Input_data.SHOPID + "'";
        //                query += ",'" + Input_data.POSID + "'";
        //                //if (Input_data.Multicard == true)
        //                //{
        //                int MRTAMOUNT_remain = val_multi.MRTAMOUNT;
        //                int MRTAMOUNT = call_cbalance(ref CBALANCE_multi, ref MRTAMOUNT_remain);
        //                val_multi.MRTAMOUNT = MRTAMOUNT_remain;
        //                query += ",'" + MRTAMOUNT + "'";
        //                useAMOUNT += MRTAMOUNT;
        //                //}
        //                //else
        //                //{
        //                //    query += "'" + val.MRTAMOUNT + "',";
        //                //}

        //                query += ",'" + val_multi.MRTSTATUS + "'";
        //                query += ",'" + Input_data.MRTSLIPNO + "-" + MultiRun[MultiRun_IDX] + "X'"; //MRTSLIPNO
        //                query += ",'" + wordate_ + "'"; //MRTLUPDATE
        //                query += ",'" + val_multi.TID + "'";
        //                query += ",'" + val_multi.UID + "'";
        //                query += ",getdate()"; //LUPDATE
        //                query += ",0"; //BACKUPFLG
        //                query += ",'" + val_multi.FOODID + "'";
        //                query += ",'" + val_multi.FOODNAME + "'";
        //                query += ",'" + shopEnd.ToString() + "'";
        //                query += ",'" + val_multi.GP + "'";
        //                query += ",'" + val_multi.GPAMOUNT + "'";
        //                query += ",'" + val_multi.GPRULE + "'";
        //                query += ",'" + val_multi.SEQ + "'";
        //                query += ",0";//เคสต่อบัตรลงเป้น 0
        //                query += ",0"; //เคสต่อบัตรลงเป้น 0
        //                query += ",'" + card_data_multi[0].CBALANCE + "'";
        //                if (Input_data.CorpBRNID == "LJ")
        //                {
        //                }
        //                else
        //                {
        //                    query += ",'" + val_multi.CARDTENDOR + "'";
        //                    query += ",'" + val_multi.CARDREF + "'";

        //                }
        //                query += ",'" + Input_data.CARDPURSE + "'";
        //                query += ",'" + val_multi.TAXINVOICE + "'";
        //                query += ")";
        //                MultiRun_IDX++;

        //                //บัตรหมดมูลค่าที่ร้านค้า
        //                shopEnd = 0;
        //                if (CBALANCE_multi <= 0)
        //                {
        //                    shopEnd = 1;
        //                    break;
        //                }
        //                else
        //                {
        //                    shopEnd = 0;
        //                }
        //                i++;

        //            }
        //            query += Sql_check.ROWCOUNT(Sql_check.Insert, "CARDTRANS");
        //            if (Input_data.Cardtran.Count > 0)
        //            {
        //                if (shopEnd == 1)
        //                {
        //                    query += Query_shopend_1(Input_data.SHOPID.ToString(), Input_data.POSID, val.BARCODE, val.CUSED.ToString());
        //                    //ret.Respon.Result = false;
        //                    ret.Respon.ErrorMessage = "NOBALANCE";
        //                    ret.Respon.Result_value += ", " + val.BARCODE;
        //                }
        //                else
        //                {
        //                    query += Query_shopend_0(useAMOUNT, val.BARCODE, val.CUSED.ToString());

        //                }
        //            }
        //        }

        //        //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
        //        //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
        //        //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
        //        //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------

        //    }
        //    else//inseret CARDTRANS_CARDUSE
        //    {

        //    }
        //    ret.Respon.Result = true;
        //    ret.Data = query;
        //    return ret;
        //}
        //public ResponseMessage Save_Cardtran_Postpaid(DataContext con, SysConfigModels data_config, CardtranModels.SALE_INT Input_data, string ISNOR)
        //{
        //    var ret = new ResponseMessage();
        //    var Sql_check = new Sql_check();
        //    int i = 0;
        //    string query = "";
        //    string query_H = "";
        //    Int16 shopEnd = 0;
        //    char[] MultiRun = new char[23];
        //    ResponseMessage card;
        //    List<CHK_cardsModels> card_data = new List<CHK_cardsModels>();
        //    ResponseMessage Ecards;

        //    if (Input_data.PAYTYPE == ISNOR)
        //    {
        //        for (int id = 0; id < 23; id++)
        //        {
        //            MultiRun[id] = (char)(65 + id);
        //        }
        //        //chkeck----------------------------------------------------


        //        CHKcard_MultiModels card_val = new CHKcard_MultiModels();
        //        card_val.BARCODE = Input_data.Cardtran[0].BARCODE;
        //        card_val.Nettotel = (int)Input_data.NETAMOUNT;
        //        card = new CHK_cardsCL().chkcard_Potpaid(data_config, card_val);
        //        if (card.Respon.Result == false)
        //        {
        //            return card;
        //        }
        //        else
        //        {
        //            card_data = (List<CHK_cardsModels>)(card.Data);
        //        }


        //        Ecards = new EcardsCL().CHK_Ecard(Input_data.Cardtran[0].BARCODE);
        //        List<EcardModels> Ecards_data = new List<EcardModels>();
        //        if (Ecards.Respon.Result == false)
        //        {
        //            return Ecards;
        //        }
        //        else
        //        {
        //            Ecards_data = (List<EcardModels>)(Ecards.Data);
        //        }


        //        //บัตรหมดมูลค่าที่ร้านค้า ของการ์ดปัจจุบันเท่านั้น

        //        if (card_data[0].CBALANCE <= Input_data.NETAMOUNT)
        //        {
        //            shopEnd = 1;
        //        }
        //        else
        //        {
        //            shopEnd = 0;
        //        }

        //        //END  chkeck-----------------------------------------------------





        //        //log nomal
        //        //log nomal
        //        //log nomal
        //        //log nomal
        //        //log nomal
        //        //log nomal
        //        //log nomal
        //        //log nomal

        //    }

        //    var workingdate = new WorkingdateCL().chk_Workingdate("");
        //    if (workingdate.Count <= 0)
        //    {
        //        throw new Exception("มีการปิดสิ้นวันแล้ว กรุณาแจ้งผู้ดูแลระบบ");
        //    }
        //    string wordate_ = new Center().Condate(workingdate[0].DATEWORKING, "ymd hh:mm:ss");

        //    query_H = "\n  INSERT INTO CARDTRANS (CUSED, BARCODE, SHOPID, POSID, MRTAMOUNT, " +
        //                             "MRTSTATUS, MRTSLIPNO, MRTLUPDATE, TID, UID, LUPDATE, BACKUPFLG,FOODID, FOODNAME,PCODE,PNAME,UNITCODE,UNITNAME," +
        //                             "SHOPENDFLG,seq,ITEMS_PRICE,QTY,OLD_BALANCE) VALUES ";

        //    query += query_H;
        //    i = 0;
        //    int CBALANCE = 0;
        //    if (Input_data.PAYTYPE == ISNOR)
        //    {
        //        CBALANCE = int.Parse(card_data[0].CBALANCE.ToString());
        //    }

        //    int useAMOUNT = 0;
        //    foreach (CardtranModels.Cardtran val in Input_data.Cardtran)
        //    {
        //        if (i > 0) query += ",";
        //        query += "\n(";
        //        if (Input_data.PAYTYPE == ISNOR)
        //        {
        //            query += "'" + card_data[0].CUSED + "'";
        //        }
        //        else
        //        {
        //            query += "'1'";
        //        }
        //        query += ",'" + Input_data.Cardtran[0].BARCODE + "'";
        //        query += ",'" + Input_data.SHOPID + "'";
        //        query += ",'" + Input_data.POSID + "'";
        //        query += ",'" + val.MRTAMOUNT + "'";
        //        useAMOUNT += val.MRTAMOUNT;
        //        query += ",'" + val.MRTSTATUS + "'";
        //        query += ",'" + Input_data.MRTSLIPNO + "-" + val.SEQ + "'"; //MRTSLIPNO
        //        query += ",'" + wordate_ + "'"; //MRTLUPDATE
        //        query += ",'" + val.TID + "'";
        //        query += ",'" + val.UID + "'";
        //        query += ",getdate()"; //LUPDATE
        //        query += ",0"; //BACKUPFLG
        //        query += ",'" + val.FOODID + "'";
        //        query += ",'" + val.FOODNAME + "'";
        //        query += ",'" + val.PCODE + "'";
        //        query += ",'" + val.PNAME + "'";
        //        query += ",'" + val.UNITCODE + "'";
        //        query += ",'" + val.UNITNAME + "'";
        //        query += ",'" + shopEnd.ToString() + "'";
        //        query += ",'" + val.SEQ + "'";
        //        query += ",'" + val.ITEMS_PRICE + "'";
        //        query += ",'" + val.QTY + "'";

        //        if (Input_data.PAYTYPE == ISNOR)
        //        {
        //            query += ",'" + card_data[0].CBALANCE + "'";//OLD_BALANCE
        //        }
        //        else
        //        {
        //            query += ",'0'";//OLD_BALANCE
        //        }
        //        query += ")";

        //        i++;
        //    }

        //    query += Sql_check.ROWCOUNT(Sql_check.Insert, "CARDTRANS");
        //    if (Input_data.PAYTYPE == ISNOR)
        //    {
        //        if (Input_data.Cardtran.Count > 0)
        //        {
        //            //if (shopEnd == 1)
        //            //{
        //            //    query += Query_shopend_1(Input_data.SHOPID.ToString(), Input_data.POSID, Input_data.Cardtran[0].BARCODE, card_data[0].CUSED.ToString());
        //            //    //ret.Respon.Result = false;
        //            //    ret.Respon.ErrorMessage = "NOBALANCE";
        //            //    ret.Respon.Result_value = Input_data.Cardtran[0].BARCODE;
        //            //}
        //            //else
        //            //{
        //            query += Query_shopend_0(useAMOUNT, Input_data.Cardtran[0].BARCODE, card_data[0].CUSED.ToString());
        //            //}
        //        }
        //    }



        //    //if (Input_data.Multicard == true)
        //    //{

        //    //    //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
        //    //    //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
        //    //    //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
        //    //    //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
        //    //    int MRTAMOUNT_Remain = Input_data.Cardtran.Sum(s => s.MRTAMOUNT);
        //    //    //CardtranModels.Model Items_multi = new   CardtranModels.Model();
        //    //    //var Items_multi = Input_data.Items.Select.(c => ).ToList();
        //    //    int MultiRun_IDX = 0;
        //    //    foreach (CardtranModels.Saleitems_card val in Input_data.Saleitems_card)
        //    //    {
        //    //        if (Input_data.Cardtran[0].BARCODE == val.BARCODE) { continue; }
        //    //        //chkeck-----MulticardMulticardMulticardMulticardMulticard-----------------------------------------------

        //    //        var card_multi = new CHK_cardsCL().chkcard(val.BARCODE, MRTAMOUNT_Remain, Input_data.Multicard);
        //    //        List<CHK_cardsModels> card_data_multi = new List<CHK_cardsModels>();
        //    //        if (card_multi.Respon.Result == false)
        //    //        {
        //    //            return card_multi;
        //    //        }
        //    //        else
        //    //        {
        //    //            card_data_multi = (List<CHK_cardsModels>)(card_multi.Data);
        //    //        }

        //    //        var Ecards_multi = new EcardsCL().CHK_Ecard(val.BARCODE);
        //    //        List<EcardModels> Ecards_data_multi = new List<EcardModels>();
        //    //        if (Ecards_multi.Respon.Result == false)
        //    //        {
        //    //            return Ecards_multi;
        //    //        }
        //    //        else
        //    //        {
        //    //            Ecards_data_multi = (List<EcardModels>)(Ecards_multi.Data);
        //    //        }

        //    //        //END  chkeck------MulticardMulticardMulticardMulticardMulticard-----------------------------------------------





        //    //        query += "\n" + query_H;
        //    //        i = 0;
        //    //        useAMOUNT = 0;
        //    //        int CBALANCE_multi = int.Parse(card_data_multi[0].CBALANCE.ToString());
        //    //        foreach (CardtranModels.Cardtran val_multi in Input_data.Cardtran)
        //    //        {

        //    //            if (val_multi.MRTAMOUNT <= 0) { continue; }

        //    //            if (i > 0) query += ",";
        //    //            query += "\n(";
        //    //            if (Input_data.PAYTYPE == ISNOR)
        //    //            {
        //    //                query += "'" + card_data_multi[0].CUSED + "'";
        //    //                query += ",'" + card_data_multi[0].CUSED1 + "'";
        //    //            }
        //    //            else
        //    //            {
        //    //                query += ",'1'";
        //    //                query += ",'1'";
        //    //            }
        //    //            query += ",'" + val.BARCODE + "'";
        //    //            query += ",'" + Input_data.SHOPID + "'";
        //    //            query += ",'" + Input_data.POSID + "'";
        //    //            //if (Input_data.Multicard == true)
        //    //            //{
        //    //            int MRTAMOUNT_remain = val_multi.MRTAMOUNT;
        //    //            int MRTAMOUNT = call_cbalance(ref CBALANCE_multi, ref MRTAMOUNT_remain);
        //    //            val_multi.MRTAMOUNT = MRTAMOUNT_remain;
        //    //            query += ",'" + MRTAMOUNT + "'";
        //    //            useAMOUNT += MRTAMOUNT;
        //    //            //}
        //    //            //else
        //    //            //{
        //    //            //    query += "'" + val.MRTAMOUNT + "',";
        //    //            //}

        //    //            query += ",'" + val_multi.MRTSTATUS + "'";
        //    //            query += ",'" + Input_data.MRTSLIPNO + "-" + MultiRun[MultiRun_IDX] + "X'"; //MRTSLIPNO
        //    //            query += ",'" + wordate_ + "'"; //MRTLUPDATE
        //    //            query += ",'" + val_multi.TID + "'";
        //    //            query += ",'" + val_multi.UID + "'";
        //    //            query += ",getdate()"; //LUPDATE
        //    //            query += ",0"; //BACKUPFLG
        //    //            query += ",'" + val_multi.FOODID + "'";
        //    //            query += ",'" + val_multi.FOODNAME + "'";
        //    //            query += ",'" + shopEnd.ToString() + "'";
        //    //            query += ",'" + val_multi.GP + "'";
        //    //            query += ",'" + val_multi.GPAMOUNT + "'";
        //    //            query += ",'" + val_multi.GPRULE + "'";
        //    //            query += ",'" + val_multi.SEQ + "'";
        //    //            query += ",0";//เคสต่อบัตรลงเป้น 0
        //    //            query += ",0"; //เคสต่อบัตรลงเป้น 0
        //    //            query += ",'" + card_data_multi[0].CBALANCE + "'";
        //    //            if (Input_data.CorpBRNID == "LJ")
        //    //            {
        //    //            }
        //    //            else
        //    //            {
        //    //                query += ",'" + val_multi.CARDTENDOR + "'";
        //    //                query += ",'" + val_multi.CARDREF + "'";

        //    //            }
        //    //            query += ",'" + Input_data.CARDPURSE + "'";
        //    //            query += ",'" + val_multi.TAXINVOICE + "'";
        //    //            query += ")";
        //    //            MultiRun_IDX++;

        //    //            //บัตรหมดมูลค่าที่ร้านค้า
        //    //            shopEnd = 0;
        //    //            if (CBALANCE_multi <= 0)
        //    //            {
        //    //                shopEnd = 1;
        //    //                break;
        //    //            }
        //    //            else
        //    //            {
        //    //                shopEnd = 0;
        //    //            }
        //    //            i++;

        //    //        }
        //    //        query += Sql_check.ROWCOUNT(Sql_check.Insert, "CARDTRANS");
        //    //        if (Input_data.Cardtran.Count > 0)
        //    //        {
        //    //            if (shopEnd == 1)
        //    //            {
        //    //                query += Query_shopend_1(Input_data.SHOPID.ToString(), Input_data.POSID, val.BARCODE, val.CUSED.ToString());
        //    //                //ret.Respon.Result = false;
        //    //                ret.Respon.ErrorMessage = "NOBALANCE";
        //    //                ret.Respon.Result_value += ", " + val.BARCODE;
        //    //            }
        //    //            else
        //    //            {
        //    //                query += Query_shopend_0(useAMOUNT, val.BARCODE, val.CUSED.ToString());

        //    //            }
        //    //        }
        //    //    }

        //    //    //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
        //    //    //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
        //    //    //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------
        //    //    //------MulticardMulticardMulticardMulticardMulticard----------------------------------------------

        //    //}
        //    //else//inseret CARDTRANS_CARDUSE
        //    //{

        //    //}
        //    ret.Respon.Result = true;
        //    ret.Data = query;
        //    return ret;
        //}

        //public int call_cbalance(ref int CBALANCE, ref int MRTAMOUNT)
        //{
        //    if (CBALANCE >= MRTAMOUNT)
        //    {
        //        CBALANCE -= MRTAMOUNT;
        //        int MRTAMOUNT_remain = MRTAMOUNT;
        //        MRTAMOUNT = 0;
        //        return MRTAMOUNT_remain;
        //    }
        //    else
        //    {
        //        int remain = CBALANCE;
        //        int MRTAMOUNT_remain = CBALANCE - MRTAMOUNT;
        //        if (MRTAMOUNT_remain < 0)
        //        {
        //            MRTAMOUNT_remain = MRTAMOUNT_remain * (-1);
        //        }
        //        MRTAMOUNT = MRTAMOUNT_remain;
        //        CBALANCE = 0;
        //        return remain;
        //    }
        //}
        //public ResponseMessage Pay_tender(string docno, CardtranModels.SALE_INT val)
        //{
        //    try
        //    {


        //        var ret = new ResponseMessage();
        //        switch (val.PAYTYPE)
        //        {
        //            case "ThaiQR":

        //                break;
        //            case "TRUEWALLET":
        //                var model = new TrueRequestModel();
        //                model.isv_payment_ref = docno;
        //                model.merchant_id = val.merchant_id;
        //                model.currency = "THB";
        //                model.request_amount = ((int)val.NETAMOUNT * 100).ToString();
        //                model.payment_method = "BALANCE";
        //                model.payment_code = val.Saleitems_card[0].BARCODE;
        //                model.description = val.Remark1;
        //                model.metadata = new TrueRequestModel.MetaData();
        //                model.metadata.partner_shop_id = val.SHOPID.ToString();


        //                ret = new PayTrueCL().TruePaymentRequest(model);
        //                break;
        //        }
        //        if (ret.Respon.Result == false)
        //        {
        //            throw new Exception(ret.Respon.SystemErrorMessage);
        //        }
        //        return ret;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        //public string Query_shopend_1(
        //    string SHOPID,
        //    string POSID,
        //    string BARCODE,
        //    string CUSED
        //    )
        //{
        //    var Sql_check = new Sql_check();
        //    string query = "";
        //    query += "\n if not exists ( select [POSID] from [SHOPCARDEND] where cast([CARDENDDATE]as date) = cast(getdate() as date) and SHOPID = '" + SHOPID + "'  )   ";
        //    query += " begin ";
        //    query += "\n INSERT INTO [SHOPCARDEND] ([POSID],[TOTALCARD],[CARDENDDATE],[RETURNCARD],[LUPDATE],[UID],[RETURNFLG],[SHOPID])";
        //    query += "\n VALUES (";
        //    query += "'" + POSID + "'";
        //    query += ",'1'";
        //    query += ",getdate()";
        //    query += ",0";
        //    query += ",getdate()";
        //    query += ",'" + POSID + "'";
        //    query += ",0";
        //    query += ",'" + SHOPID + "'";
        //    query += "\n )";
        //    query += Sql_check.ROWCOUNT(Sql_check.Insert, "SHOPCARDEND");
        //    query += "\n end";

        //    query += " else begin ";
        //    query += "\n update SHOPCARDEND set  TOTALCARD = TOTALCARD+1 ,LUPDATE = getdate() where cast([CARDENDDATE]as date) = cast(getdate() as date) and SHOPID = '" + SHOPID + "'  ";
        //    query += Sql_check.ROWCOUNT(Sql_check.update, "SHOPCARDEND");
        //    query += "\n  end  ";
        //    query += "\n update [CARDS] set CBALANCE = 0 , CSTATUS = 'E' ,CLUPDATE = GETDATE() WHERE BARCODE = '" + BARCODE + "' AND CUSED = " + CUSED;
        //    query += Sql_check.ROWCOUNT(Sql_check.update, "CARDS");
        //    return query;
        //}
        //public string Query_shopend_0(
        //    int Nettotel,
        //    string BARCODE,
        //    string CUSED
        //    )
        //{
        //    var Sql_check = new Sql_check();
        //    string query = "";
        //    query += "\n update [CARDS] set CBALANCE = CBALANCE-" + Nettotel + " ,CLUPDATE = GETDATE() WHERE BARCODE = '" + BARCODE + "' AND CUSED = " + CUSED;
        //    query += Sql_check.ROWCOUNT(Sql_check.update, "CARDS");
        //    return query;
        //}
        //public ResponseMessage confirmpay(confirmpay data)
        //{
        //    var con = new DataContext();
        //    var ret = new ResponseMessage();
        //    var Sql_check = new Sql_check();
        //    try
        //    {

        //        con.Open();
        //        string docno = new Doccument().Gendocno_INV(con, data.payment.SHOPID.ToString());
        //        if (docno == "")
        //        {
        //            throw new Exception("ไม่พบเลขที่เอกสาร INV :\n หมายเหุ อาจกำหนด IP Terminal ไม่ถูกต้อง");
        //        }
        //        string check_data = "";
        //        check_data = " select MRTSLIPNO from  CARDTRANS where [MRTSLIPNO] like '" + data.payment.mrt_slip + "%' and  [SHOPID] = '" + data.payment.SHOPID + "'";
        //        DataTable dt = con.ReadData_Table(check_data);
        //        if (dt.Rows.Count > 0)
        //        {
        //            ret.Respon.Result = true;
        //            ret.Respon.ErrorMessage = "success";
        //            return ret;
        //        }


        //        string strPay = "";

        //        strPay = "\n update " + con.DB_backup + "[SALE]  set CARDREF = '" + data.payment.payment_id + "' ,DC_STATE ='S',TAXINVOICE = '" + docno + "' where [MRTSLIPNO] = '" + data.payment.mrt_slip + "' and  [SHOPID] = '" + data.payment.SHOPID + "'";
        //        strPay += "\n update " + con.DB_backup + "[SALE_CARD]  set BARCODE = '" + data.payment.barcode + "'  where [MRTSLIPNO] = '" + data.payment.mrt_slip + "' and  [SHOPID] = '" + data.payment.SHOPID + "'";

        //        strPay += Sql_check.ROWCOUNT(Sql_check.update, "SALE");


        //        //strPay += "\n update CARDTRANS  set BARCODE ='" + data.barcode + "', CARDREF = '" + data.payment_id + "',MRTSTATUS = 'S' ,TAXINVOICE = '" + docno + "' where [MRTSLIPNO] like '" + data.mrt_slip + "%' and  [SHOPID] = '" + data.SHOPID + "'";
        //        //strPay += Sql_check.ROWCOUNT(Sql_check.update, "CARDTRANS");



        //        data.SALE_INT.MRTSLIPNO = data.payment.mrt_slip;
        //        foreach (CardtranModels.Cardtran val in data.SALE_INT.Cardtran)
        //        {
        //            val.BARCODE = data.payment.barcode;
        //            val.CARDREF = data.payment.payment_id;
        //            val.TAXINVOICE = docno;
        //        }




        //        var ret_save = Save_Cardtran(con, data.SALE_INT, "");
        //        if (ret_save.Respon.Result == true)
        //        {
        //            strPay += ret_save.Data;
        //        }
        //        else
        //        {
        //            con.Rollback();
        //            return ret_save;

        //        }



        //        strPay += "\n  INSERT INTO [PAYMENT] ";
        //        strPay += " (typeid, cused, barcode, cused1, clstatus, clamount, clreceive, cpromotion, tid, uid, tendor, clupdate, processdate, remark) ";
        //        strPay += " VALUES ";
        //        strPay += " ('" + data.payment.typeid + "' ";
        //        strPay += " , '" + data.payment.cused + "' ";
        //        strPay += " , '" + data.payment.barcode + "' ";
        //        strPay += " , '" + data.payment.cused1 + "' ";
        //        strPay += " , '" + data.payment.clstatus + "' ";
        //        strPay += " , '" + data.payment.clamount + "' ";
        //        strPay += " , '" + data.payment.clreceive + "' ";
        //        strPay += " , '" + data.payment.cpromotion + "' ";
        //        strPay += " , '" + data.payment.tid + "' ";
        //        strPay += " , '" + data.payment.uid + "' ";
        //        strPay += " , '" + data.payment.tendor + "' ";
        //        strPay += " , getdate() ";
        //        strPay += " , getdate() ";
        //        strPay += " , '" + data.payment.remark + "') ";
        //        strPay += Sql_check.ROWCOUNT(Sql_check.Insert, "PAYMENT");


        //        con.Excute(strPay);
        //        con.Commit();
        //        ret.Respon.Result = true;
        //        ret.Respon.ErrorMessage = "success";
        //    }
        //    catch (Exception e)
        //    {
        //        con.Rollback();
        //        ret.Respon.SystemErrorMessage = "API : " + e.ToString();
        //        //ret.SystemErrorMessage = e.StackTrace;
        //        ret.Respon.Result = false;
        //    }
        //    finally
        //    {

        //    }

        //    return ret;

        //}
        //public ResponseMessage confirm_Sale_cancel(ConfirmpayModels data)
        //{
        //    var con = new DataContext();
        //    var ret = new ResponseMessage();
        //    var Sql_check = new Sql_check();
        //    try
        //    {
        //        con.Open();

        //        string strPay = "";
        //        // ตอนนี้ใช้ยกเลิก Log ที่ค้างจ่าย แต่ใน wellet ไม่ได้จ่ายจริง อย่างดเดียว
        //        // ตอนนี้ใช้ยกเลิก Log ที่ค้างจ่าย แต่ใน wellet ไม่ได้จ่ายจริง อย่างดเดียว
        //        // ตอนนี้ใช้ยกเลิก Log ที่ค้างจ่าย แต่ใน wellet ไม่ได้จ่ายจริง อย่างดเดียว
        //        // ตอนนี้ใช้ยกเลิก Log ที่ค้างจ่าย แต่ใน wellet ไม่ได้จ่ายจริง อย่างดเดียว
        //        // ตอนนี้ใช้ยกเลิก Log ที่ค้างจ่าย แต่ใน wellet ไม่ได้จ่ายจริง อย่างดเดียว

        //        //strPay = "\n delete " + con.DB_backup + "[SALE] where [MRTSLIPNO] = '" + data.mrt_slip + "' and  [SHOPID] = '" + data.SHOPID + "'";
        //        //strPay += Sql_check.ROWCOUNT(Sql_check.update, "SALE");
        //        //strPay += "\n delete " + con.DB_backup + "[SALE_CARD]  where [MRTSLIPNO] = '" + data.mrt_slip + "' and  [SHOPID] = '" + data.SHOPID + "'";
        //        //strPay += Sql_check.ROWCOUNT(Sql_check.update, "SALE_CARD");
        //        //strPay += "\n delete " + con.DB_backup + "[SALE_ITEMS]  where [MRTSLIPNO] = '" + data.mrt_slip + "' and  [SHOPID] = '" + data.SHOPID + "'";
        //        //strPay += Sql_check.ROWCOUNT(Sql_check.update, "SALE_ITEMS");

        //        //strPay += "\n delete CARDTRANS   where [MRTSLIPNO] like '" + data.mrt_slip + "%' and  [SHOPID] = '" + data.SHOPID + "'";
        //        //strPay += Sql_check.ROWCOUNT(Sql_check.update, "CARDTRANS");


        //        strPay = "\n update " + con.DB_backup + "[SALE] set DC_STATE = 'C' ,MODATE =getdate() where [MRTSLIPNO] = '" + data.mrt_slip + "' and  [SHOPID] = '" + data.SHOPID + "'";
        //        strPay += Sql_check.ROWCOUNT(Sql_check.update, "SALE");

        //        //strPay += "\n update CARDTRANS set MRTSTATUS = 'C'  where [MRTSLIPNO] like '" + data.mrt_slip + "%' and  [SHOPID] = '" + data.SHOPID + "'";
        //        //strPay += Sql_check.ROWCOUNT(Sql_check.update, "CARDTRANS");


        //        con.Excute(strPay);
        //        con.Commit();
        //        ret.Respon.Result = true;
        //        ret.Respon.ErrorMessage = "success";
        //    }
        //    catch (Exception e)
        //    {
        //        con.Rollback();
        //        ret.Respon.SystemErrorMessage = "API : " + e.ToString();
        //        //ret.SystemErrorMessage = e.StackTrace;
        //        ret.Respon.Result = false;
        //    }
        //    return ret;

        //}
        //public ResponseMessage Sale_VOID(List<VoidModels.SALE_void> data)
        //{
        //    var con = new DataContext();
        //    var ret = new ResponseMessage();
        //    var Sql_check = new Sql_check();
        //    try
        //    {
        //        con.Open();

        //        string docno = new Doccument().Gendocno_CN(con, data[0].SHOPID.ToString());
        //        if (docno == "")
        //        {
        //            throw new Exception("ไม่พบเลขที่เอกสาร VOID :\n หมายเหุ อาจกำหนด IP Terminal ไม่ถูกต้อง");
        //        }

        //        string seq = "";
        //        string strPay = "";
        //        if (data[0].Voidtype == cl_const.Void_TYPE.REFUND)
        //        {
        //            foreach (VoidModels.SALE_void val in data)
        //            {
        //                if (seq == "")
        //                {
        //                    seq = val.SEQ.ToString();
        //                }
        //                else
        //                {
        //                    seq += "," + val.SEQ;
        //                }
        //            }

        //            //สามารถ void แบบรายการได้
                 

        //            strPay = "\n update " + con.DB_backup + "[SALE_ITEMS] set VOIDNO = '" + data[0].VOIDNO + "' ,MODATE =getdate(),CREDITNOTES ='" + docno + "' ,CARDREF_CN='" + data[0].CN_DOCNO + "'  where [MRTSLIPNO] = '" + data[0].MRTSLIPNO + "' and  [SHOPID] = '" + data[0].SHOPID + "' and SEQ in (" + seq + ")";
        //            strPay += Sql_check.ROWCOUNT(Sql_check.update, "SALE");

        //            strPay += "\n update CARDTRANS set VOIDNO = '" + data[0].VOIDNO + "',MRTSTATUS = 'V',MRTLUPDATE =getdate() ,CREDITNOTES ='" + docno + "' ,CARDREF_CN='" + data[0].CN_DOCNO + "'       where [MRTSLIPNO] like '" + data[0].MRTSLIPNO + "%' and  [SHOPID] = '" + data[0].SHOPID + "' and SEQ in (" + seq + ")";
        //            strPay += Sql_check.ROWCOUNT(Sql_check.update, "CARDTRANS");

        //        }
        //        else
        //        {
        //            strPay = "\n update " + con.DB_backup + "[SALE_ITEMS] set VOIDNO = '" + data[0].VOIDNO + "' ,MODATE =getdate(),CREDITNOTES ='" + docno + "',CARDREF_CN='" + data[0].CN_DOCNO + "'     where [MRTSLIPNO] = '" + data[0].MRTSLIPNO + "' and  [SHOPID] = '" + data[0].SHOPID + "' ";
        //            strPay += Sql_check.ROWCOUNT(Sql_check.update, "SALE");

        //            strPay += "\n update CARDTRANS set VOIDNO = '" + data[0].VOIDNO + "' ,MRTSTATUS = 'V',MRTLUPDATE =getdate(),CREDITNOTES ='" + docno + "',CARDREF_CN='" + data[0].CN_DOCNO + "'        where [MRTSLIPNO] like '" + data[0].MRTSLIPNO + "%' and  [SHOPID] = '" + data[0].SHOPID + "' ";
        //            strPay += Sql_check.ROWCOUNT(Sql_check.update, "CARDTRANS");
        //        }
        //        con.Excute(strPay);
        //        con.Commit();
        //        ret.Respon.Result = true;
        //        ret.Respon.Result_value = docno ;
        //        ret.Respon.ErrorMessage = "success";
        //    }
        //    catch (Exception e)
        //    {
        //        con.Rollback();
        //        ret.Respon.SystemErrorMessage = "API : " + e.ToString();
        //        //ret.SystemErrorMessage = e.StackTrace;
        //        ret.Respon.Result = false;
        //    }
        //    return ret;

        //}
        //public ResponseMessage Get_VOID(string SHOP_ID)
        //{
        //    var con = new DataContext();
        //    var ret = new ResponseMessage();
        //    var Sql_check = new Sql_check();
        //    try
        //    {
        //        con.Open();
        //        string docno = new Doccument().Gendocno_VOID(con, SHOP_ID);
        //        if (docno == "")
        //        {
        //            throw new Exception("ไม่พบเลขที่เอกสาร VOID :\n หมายเหุ อาจกำหนด IP Terminal ไม่ถูกต้อง");
        //        }
        //        con.Commit();
        //        ret.Respon.Result = true;
        //        ret.Respon.Result_value = docno;
        //        ret.Respon.ErrorMessage = "success";
        //    }
        //    catch (Exception e)
        //    {
        //        con.Rollback();
        //        ret.Respon.SystemErrorMessage = "API : " + e.ToString();
        //        //ret.SystemErrorMessage = e.StackTrace;
        //        ret.Respon.Result = false;
        //    }
        //    return ret;

        //}
        //public ResponseMessage confirmpay_log(ConfirmpayModels_log data)
        //{
        //    var con = new DataContext();
        //    var ret = new ResponseMessage();
        //    var Sql_check = new Sql_check();
        //    try
        //    {

        //        string strPay = "";

        //        strPay += " INSERT INTO " + con.DB_backup + "[PAYMENT_LOG] ";
        //        strPay += " (  typeid, barcode, clstatus, clamount, clreceive, cpromotion, tid, uid, tendor, clupdate, processdate, Remark, LOG_TYPE, MRTSLIPNO, SHOPID, POSID, MERCHAND_ID, APP_ID, PAYMENT_CODE, PAY_AMOUNT, PAY_STATE, PAY_DESCRIPTION, PAY_Remark) ";
        //        strPay += " VALUES (";
        //        strPay += " '" + data.typeid + "' ,";
        //        strPay += " '" + data.barcode + "' ,";
        //        strPay += " '" + data.clstatus + "' ,";
        //        strPay += " '" + data.clamount + "' ,";
        //        strPay += " '" + data.clreceive + "' ,";
        //        strPay += " '" + data.cpromotion + "' ,";
        //        strPay += " '" + data.tid + "' ,";
        //        strPay += " '" + data.uid + "' ,";
        //        strPay += " '" + data.tendor + "' ,";
        //        strPay += " GETDATE() ,";
        //        strPay += " GETDATE() ,";
        //        strPay += " '" + data.Remark + "' ,";
        //        strPay += " '" + data.LOG_TYPE + "' ,";
        //        strPay += " '" + data.MRTSLIPNO + "' ,";
        //        strPay += " '" + data.SHOPID + "' ,";
        //        strPay += " '" + data.POSID + "' ,";
        //        strPay += " '" + data.MERCHAND_ID + "' ,";
        //        strPay += " '" + data.APP_ID + "' ,";
        //        strPay += " '" + data.PAYMENT_CODE + "' ,";
        //        strPay += " '" + data.PAY_AMOUNT + "' ,";
        //        strPay += " '" + data.PAY_STATE + "' ,";
        //        strPay += " '" + data.PAY_DESCRIPTION + "' ,";
        //        strPay += " '" + data.PAY_Remark + "' ";
        //        strPay += ")";

        //        strPay += Sql_check.ROWCOUNT(Sql_check.Insert, "PAYMENT_LOG");

        //        con.Open();
        //        con.Excute(strPay);
        //        con.Commit();
        //        ret.Respon.Result = true;
        //        ret.Respon.ErrorMessage = "success";
        //    }
        //    catch (Exception e)
        //    {
        //        con.Rollback();
        //        ret.Respon.SystemErrorMessage = "API : " + e.ToString();
        //        //ret.SystemErrorMessage = e.StackTrace;
        //        ret.Respon.Result = false;
        //    }
        //    return ret;

        //}
        #endregion
    }


}