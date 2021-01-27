using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
using TouchPOS_API.Helpers;
using TouchPOS_API.Service;
using System.Data;
namespace TouchPOS_API.Class
{
    public class Doccument
    {
        public class Format
        {
            public const string Run = "RUN";
            public const string YMR = "YYYY-MM-RUN";
        }
        //DataContext conn = new DataContext;
        //public string Gensoslip(DataContext con, string shopID)
        //{
        //    //var con = new DataContext();
        //    //ResponseMessage ret = new ResponseMessage();
        //    string Retdocno = "";
        //    try
        //    {
        //        string sql = " SELECT  SHOPID,POSID,isnull(SLIPNO,0)as SLIPNO,cast( cast( getdate() as date) as varchar(10)) as TRANSDATE  FROM SHOPS  WHERE [SHOPID] = '" + shopID + "'  ";

        //        var result = con.RunQuery<Gendocument_Model.GensoSlip>(sql);
        //        Int32 Curdocno = 0;
        //        Int32 lent = 0;
        //        Int32 max = 0;
        //        string formatdocno = "";
        //        if (result != null && result.Count > 0)
        //        {

        //            lent = result[0].SLIPNO.Length;
        //            string lent2 = "";
        //            for (int i = 0; i < lent; i++)
        //            {
        //                lent2 += "9";
        //                formatdocno += "0";
        //            }
        //            max = Int32.Parse(lent2);
        //            Curdocno = Int32.Parse(result[0].SLIPNO);
        //            if (Curdocno >= max)
        //            {
        //                Curdocno = 1;
        //            }
        //            else
        //            {
        //                Curdocno += 1;
        //            }
        //            string docno = Curdocno.ToString(formatdocno);
        //            string TRANSDATE = new Center().Condate_TH(Convert.ToDateTime(result[0].TRANSDATE), "ymd");
        //            string YY = TRANSDATE.Substring(2, 2);
        //            string MM = TRANSDATE.Substring(5, 2);
        //            string DD = TRANSDATE.Substring(8, 2);


        //            Retdocno = result[0].POSID + YY + MM + DD + docno;

        //            string chk_docno = " select MRTSLIPNO from " + con.DB_backup + "[SALE] where SHOPID ='" + shopID + "' and MRTSLIPNO = '" + Retdocno + "' ";
        //            var chk_doc = con.RunQuery<SaleMmodels>(chk_docno);
        //            if (chk_doc.Count > 0)
        //            {
        //                string lastdocno = " select top 1 right([MRTSLIPNO]," + lent.ToString() + ") as MRTSLIPNO from " + con.DB_backup + "[SALE] where SHOPID ='" + shopID + "' order by SID desc ";
        //                var newdoc = con.RunQuery<SaleMmodels>(lastdocno);
        //                if (newdoc.Count > 0)
        //                {

        //                    double doc_now = Convert.ToDouble(newdoc[0].MRTSLIPNO) + 1;
        //                    docno = doc_now.ToString(formatdocno);
        //                    Retdocno = result[0].POSID + YY + MM + DD + docno;

        //                }
        //                else
        //                {
        //                    Retdocno = "";
        //                }
        //            }
        //            string sqlup = " update  SHOPS set  SLIPNO  ='" + docno + "'   WHERE [SHOPID] = '" + shopID + "'  ";
        //            var a = con.Excute(sqlup);
        //        }
        //        return Retdocno;
        //    }
        //    catch (Exception c)
        //    {
        //        throw c;
        //    }
        //}
        //public string Gendocno_VOID(DataContext con, string shopID)
        //{
        //    //var con = new DataContext();
        //    //ResponseMessage ret = new ResponseMessage();
        //    string Retdocno = "";
        //    try
        //    {
        //        string sql = " SELECT  SHOPID,POSID,isnull(VOIDNO,0)as VOIDNO,cast( cast( getdate() as date) as varchar(10)) as TRANSDATE  FROM SHOPS  WHERE [SHOPID] = '" + shopID + "'  ";


        //        var result = con.RunQuery<Gendocument_Model.GensoSlip>(sql);
        //        Int32 Curdocno = 0;
        //        Int32 lent = 0;
        //        Int32 max = 0;
        //        string formatdocno = "";
        //        if (result != null && result.Count > 0)
        //        {

        //            lent = result[0].VOIDNO.Length;
        //            string lent2 = "";
        //            for (int i = 0; i < lent; i++)
        //            {
        //                lent2 += "9";
        //                formatdocno += "0";
        //            }
        //            max = Int32.Parse(lent2);
        //            Curdocno = Int32.Parse(result[0].VOIDNO);
        //            if (Curdocno >= max)
        //            {
        //                Curdocno = 1;
        //            }
        //            else
        //            {
        //                Curdocno += 1;
        //            }
        //            string docno = Curdocno.ToString(formatdocno);
        //            string TRANSDATE = new Center().Condate_TH(Convert.ToDateTime(result[0].TRANSDATE), "ymd");
        //            string YY = TRANSDATE.Substring(2, 2);
        //            string MM = TRANSDATE.Substring(5, 2);
        //            string DD = TRANSDATE.Substring(8, 2);


        //            Retdocno = result[0].POSID + YY + MM + DD + docno;

        //            //ทำไม่ทัน
        //            //ทำไม่ทัน
        //            //ทำไม่ทัน
        //            //ทำไม่ทัน
        //            //ทำไม่ทัน

        //            //string chk_docno = " select MRTSLIPNO from " + con.DB_backup + "[SALE] where SHOPID ='" + shopID + "' and MRTSLIPNO = '" + Retdocno + "' ";
        //            //var chk_doc = con.RunQuery<SaleMmodels>(chk_docno);
        //            //if (chk_doc.Count > 0)
        //            //{
        //            //    string lastdocno = " select top 1 right([MRTSLIPNO]," + lent.ToString() + ") as MRTSLIPNO from " + con.DB_backup + "[SALE] where SHOPID ='" + shopID + "' order by SID desc ";
        //            //    var newdoc = con.RunQuery<SaleMmodels>(lastdocno);
        //            //    if (newdoc.Count > 0)
        //            //    {

        //            //        double doc_now = Convert.ToDouble(newdoc[0].MRTSLIPNO) + 1;
        //            //        docno = doc_now.ToString(formatdocno);
        //            //        Retdocno = result[0].POSID + YY + MM + DD + docno;

        //            //    }
        //            //    else
        //            //    {
        //            //        Retdocno = "";
        //            //    }
        //            //}
        //            string sqlup = " update  SHOPS set  VOIDNO  ='" + docno + "'   WHERE [SHOPID] = '" + shopID + "'  ";
        //            var a = con.Excute(sqlup);
        //        }
        //        return Retdocno;
        //    }
        //    catch (Exception c)
        //    {
        //        throw c;
        //    }
        //}
        //public string Gendocno_INV(DataContext con, string shopID)
        //{
        //    //var con = new DataContext();
        //    //ResponseMessage ret = new ResponseMessage();
        //    string Retdocno = "";
        //    try
        //    {
        //        string sql = " select SHOPS.MRIP, SHOPS.SHOPID,SHOPS.POSID,TERMINAL.TID,isnull(TERMINAL.INVOICE,0)as SLIPNO,cast( cast( getdate() as date) as varchar(10)) as TRANSDATE ";
        //        sql += " from SHOPS inner join TERMINAL on SHOPS.MRIP = TERMINAL.TIP ";
        //        sql += " where SHOPS.SHOPID = '" + shopID + "' ";

        //        var result = con.RunQuery<Gendocument_Model.GensoSlip>(sql);
        //        Int32 Curdocno = 0;
        //        Int32 lent = 0;
        //        Int32 max = 0;
        //        string formatdocno = "";
        //        if (result != null && result.Count > 0)
        //        {

        //            lent = result[0].SLIPNO.Length;
        //            string lent2 = "";
        //            for (int i = 0; i < lent; i++)
        //            {
        //                lent2 += "9";
        //                formatdocno += "0";
        //            }
        //            max = Int32.Parse(lent2);
        //            Curdocno = Int32.Parse(result[0].SLIPNO);
        //            if (Curdocno >= max)
        //            {
        //                Curdocno = 1;
        //            }
        //            else
        //            {
        //                Curdocno += 1;
        //            }

        //            string docno = Curdocno.ToString(formatdocno);

        //            string TRANSDATE = new Center().Condate_TH(Convert.ToDateTime(result[0].TRANSDATE), "ymd");
        //            string YY = TRANSDATE.Substring(2, 2);
        //            string MM = TRANSDATE.Substring(5, 2);
        //            string DD = TRANSDATE.Substring(8, 2);
        //            Retdocno = result[0].TID + YY + MM + DD + docno;

        //            string chk_docno = " select TAXINVOICE from " + con.DB_backup + "[SALE] where SHOPID ='" + shopID + "' and TAXINVOICE = '" + Retdocno + "' ";
        //            var chk_doc = con.RunQuery<SaleMmodels>(chk_docno);
        //            if (chk_doc.Count > 0)
        //            {
        //                string lastdocno = " select top 1 right([TAXINVOICE]," + lent.ToString() + ") as MRTSLIPNO from " + con.DB_backup + "[SALE] where SHOPID ='" + shopID + "' and TAXINVOICE <> '' order by SID desc ";
        //                var newdoc = con.RunQuery<SaleMmodels>(lastdocno);
        //                if (newdoc.Count > 0)
        //                {

        //                    double doc_now = Convert.ToDouble(newdoc[0].MRTSLIPNO) + 1;
        //                    docno = doc_now.ToString(formatdocno);
        //                    Retdocno = result[0].TID + YY + MM + DD + docno;

        //                }
        //                else
        //                {
        //                    Retdocno = "";
        //                }
        //            }
        //            string sqlup = " update  TERMINAL set  INVOICE  ='" + docno + "'   WHERE [TIP] = '" + result[0].MRIP + "'  ";
        //            var a = con.Excute(sqlup);
        //        }
        //        return Retdocno;
        //    }
        //    catch (Exception c)
        //    {
        //        throw c;
        //    }
        //}
        //public string Gendocno_CN(DataContext con, string shopID)
        //{
        //    //var con = new DataContext();
        //    //ResponseMessage ret = new ResponseMessage();
        //    string Retdocno = "";
        //    try
        //    {
        //        string sql = " select SHOPS.MRIP, SHOPS.SHOPID,SHOPS.POSID,TERMINAL.TID,isnull(TERMINAL.CREDITNOTE,0)as SLIPNO,cast( cast( getdate() as date) as varchar(10)) as TRANSDATE ";
        //        sql += " from SHOPS inner join TERMINAL on SHOPS.MRIP = TERMINAL.TIP ";
        //        sql += " where SHOPS.SHOPID = '" + shopID + "' ";

        //        var result = con.RunQuery<Gendocument_Model.GensoSlip>(sql);
        //        Int32 Curdocno = 0;
        //        Int32 lent = 0;
        //        Int32 max = 0;
        //        string formatdocno = "";
        //        if (result != null && result.Count > 0)
        //        {

        //            lent = result[0].SLIPNO.Length;
        //            string lent2 = "";
        //            for (int i = 0; i < lent; i++)
        //            {
        //                lent2 += "9";
        //                formatdocno += "0";
        //            }
        //            max = Int32.Parse(lent2);
        //            Curdocno = Int32.Parse(result[0].SLIPNO);
        //            if (Curdocno >= max)
        //            {
        //                Curdocno = 1;
        //            }
        //            else
        //            {
        //                Curdocno += 1;
        //            }

        //            string docno = Curdocno.ToString(formatdocno);

        //            string TRANSDATE = new Center().Condate_TH(Convert.ToDateTime(result[0].TRANSDATE), "ymd");
        //            string YY = TRANSDATE.Substring(2, 2);
        //            string MM = TRANSDATE.Substring(5, 2);
        //            string DD = TRANSDATE.Substring(8, 2);
        //            Retdocno = result[0].TID + YY + MM + DD + docno;

        //            //string chk_docno = " select TAXINVOICE from " + con.DB_backup + "[SALE] where SHOPID ='" + shopID + "' and TAXINVOICE = '" + Retdocno + "' ";
        //            //var chk_doc = con.RunQuery<SaleMmodels>(chk_docno);
        //            //if (chk_doc.Count > 0)
        //            //{
        //            //    string lastdocno = " select top 1 right([TAXINVOICE]," + lent.ToString() + ") as MRTSLIPNO from " + con.DB_backup + "[SALE] where SHOPID ='" + shopID + "' and TAXINVOICE <> '' order by SID desc ";
        //            //    var newdoc = con.RunQuery<SaleMmodels>(lastdocno);
        //            //    if (newdoc.Count > 0)
        //            //    {

        //            //        double doc_now = Convert.ToDouble(newdoc[0].MRTSLIPNO) + 1;
        //            //        docno = doc_now.ToString(formatdocno);
        //            //        Retdocno = result[0].TID + YY + MM + DD + docno;

        //            //    }
        //            //    else
        //            //    {
        //            //        Retdocno = "";
        //            //    }
        //            //}
        //            string sqlup = " update  TERMINAL set  CREDITNOTE  ='" + docno + "'   WHERE [TIP] = '" + result[0].MRIP + "'  ";
        //            var a = con.Excute(sqlup);
        //        }
        //        return Retdocno;
        //    }
        //    catch (Exception c)
        //    {
        //        throw c;
        //    }
        //}
      
        public string Gendocno(DataContext con, string doctype, string docyear, string docmonth)
        {
            String docno_new = "";
            String LastDateUsed;
            string set_format = "";
            try
            {
                //A:
                Date_now_Models srvdat = new WorkingdateCL().Getdate();
                String year = srvdat.Date_now.Year.ToString();
                String mmont = srvdat.Date_now.Month.ToString();
                LastDateUsed = srvdat.Date_now.ToString();

                String sql="";

                String txtCurrentDocumentNo = "";
                int txtLastDocumentNo = 0;
                String LengthDocumentNo = "";
                sql = "";
                if (con.isopenconn ==DataContext .conselect .con1 ){ sql = "  USE [" + con.DB_backup_name + "]  "; }
                sql += " SELECT top 1 [Format] FROM [MAS_DOCTYPE] where DOCTYPECODE = '" + doctype + "' order by ID desc ";
                var data_Format = con.ReadData_Table(sql);
                if (data_Format.Rows.Count <= 0)
                {
                    return "";
                }
                else
                {
                    set_format = data_Format.Rows[0]["Format"].ToString();
                }
                sql = "";
                if (con.isopenconn == DataContext.conselect.con1) { sql = "  USE [" + con.DB_backup_name + "]  "; }
                sql += " ";
                sql += " Select dc.ID,dc.DocNoPrefix, ";
                sql += " dc.[DocTypeGroupCode]";
                sql += " ,dc.[DocTypeCode]";
                sql += " ,DocNoStart,DocNoEnd,[DocLastNo]";
                sql += " ,dc.Format";
                sql += " ,[LastDateUsed] ,DocTypeYear,DocTypeMonth";
                sql += " FROM [MAS_RUNDOCNO] dc inner join MAS_DOCTYPE dt  on dt.DOCTYPECODE  = dc.DOCTYPECODE and dt.DOCTYPEGROUPCODE  = dc.DocTypeGroupCode  ";
                sql += " where dc.ACTIVEFLAG='A' and dc.ISTAT = '1' ";
                //sql += " and [Branch_CODE] = '" + MDC_Data.loc_Structure.BRANCH_CODE + "'";
                //sql += " and [Fac_CODE] =  '" + MDC_Data.loc_Structure.FAC_CODE + "'";
                //sql += " And [WH_CODE] = '" + MDC_Data.loc_Structure.WH_CODE + "'";
                sql += " and dt.[DocTypeCode] = '" + doctype + "'";

                if (set_format == Format.YMR)
                {
                    sql += " and [DocTypeYear] = '" + docyear + "'";
                    sql += " and [DocTypeMonth] = '" + docmonth + "'";
                }


                //ค้นหาเลขที่เอกสาร

                var result = con.RunQuery<Gendocument_Model.Gendocument>(sql);


                if (result != null && result.Count > 0)
                {


                    LengthDocumentNo = "";
                    for (int i = 0; i < result[0].DocNoStart.Length; i++)
                    {
                        LengthDocumentNo += "0";
                    }

                    txtLastDocumentNo = Int32.Parse(result[0].DocLastNo) + 1;
                    txtCurrentDocumentNo = txtLastDocumentNo.ToString(LengthDocumentNo);


                    if (txtLastDocumentNo > Int32.Parse(result[0].DocNoEnd))
                    {
                        throw new Exception("การรันเลขที่เอกสารสิ้นสุด");
                    }




                    if (result[0].Format == Format.Run)
                    {
                        docno_new = result[0].DocNoPrefix;
                        //docno_new += result[0].DocTypeYear.Substring(2, 4);
                        //docno_new += result[0].DocTypeMonth;
                        docno_new += txtCurrentDocumentNo;
                    }
                    else if (result[0].Format == Format.YMR)
                    {
                        docno_new = result[0].DocNoPrefix;
                        docno_new += result[0].DocTypeYear.Substring(2, 2);
                        int month_ = Int16.Parse(result[0].DocTypeMonth);
                        docno_new += month_.ToString("00");
                        docno_new += txtCurrentDocumentNo;

                    }
                    else
                    {
                        throw new Exception("Document cannot be created  ! Format Document Not found");
                    }


                    // 'Update เลขที่เอกสารล่าสุด

                    string sqlupdate = "";
                    if (con.isopenconn == DataContext.conselect.con1) { sqlupdate = "  USE [" + con.DB_backup_name + "]  "; }
                    sqlupdate += " Update [MAS_RUNDOCNO]";
                    sqlupdate += " Set [DocLastNo] = '" + txtCurrentDocumentNo + "' ,   ";
                    sqlupdate += " [LastDateUsed] = getdate()   ";
                    sqlupdate += " where  [ID] = '" + result[0].ID + "'";

                    con.Excute(sqlupdate);


                }
                else
                {

                    String dcstart = "";
                    String dcend = "";
                    String str = "";

                    //if (doctype != "MOV.YEND")
                    //{
                    //    //ตรวจสอบการปิดสิ้นปี
                    //    if (con.isopenconn == DataContext.conselect.con1) { str = "  USE [" + con.DB_backup_name + "]  "; }
                    //    str = " select top 1 DOCTYPE from [dbo].[MOVT]";
                    //    str += " select top 1 DOCTYPE from [dbo].[MOVT] where DOCTYPE = 'MOV.YEND' and DOCYEAR = year(getdate()) ";
                    //    DataSet ds = con.ReadDataSet(str);
                    //    if (ds.Tables[0].Rows.Count > 0)
                    //    {
                    //        if (ds.Tables[1].Rows.Count <= 0)
                    //        {
                    //            throw new Exception("กรุณาทำการปิดสิ้นปี");
                    //        }
                    //    }
                           
                    //}


                    str = "";
                    if (con.isopenconn == DataContext.conselect.con1) { str = "  USE [" + con.DB_backup_name + "]  "; }
                    str += " SELECT top 1 T.[DOCTYPECODE],T.[DOCTYPENAME],T.[DOCTYPEGROUPCODE],T.DocNoPrefix,T.DocStart,T.DocEND ,T.Format";
                    str += " FROM[MAS_DOCTYPE] T inner join [MAS_DOCTYPEGROUP]TG on T.DOCTYPEGROUPCODE = TG.DOCTYPEGROUPCODE  where T.[ACTIVEFLAG] = 'A' and T.ISTAT = '1' and DOCTYPECODE = '" + doctype + "' ";
                    var result_new = con.RunQuery<Gendocument_Model.Gendocument>(str);

                    if (result_new == null || result_new.Count == 0)
                    {
                        return "";
                    }


                    dcstart = result_new[0].DocStart;
                    dcend = result_new[0].DocEND;
                    if (result_new[0].Format == Format.Run)
                    {
                        docno_new = result_new[0].DocNoPrefix;
                        //docno_new += year.Substring(2, 2);
                        //docno_new += mmont;
                        docno_new += dcstart;

                    }
                    else if (result_new[0].Format == Format.YMR)
                    {
                        docno_new = result_new[0].DocNoPrefix;
                        docno_new += year.Substring(2, 2);
                        int month_ = Int16.Parse(mmont);
                        docno_new += month_.ToString("00");
                        docno_new += dcstart;

                    }
                    else
                    {
                        throw new Exception("Document cannot be created  ! Format Document Not found");
                    }



                    Gendocument_Model.MAS_RUNDOCNO data = new Gendocument_Model.MAS_RUNDOCNO();

                    data.ID = 0;
                    data.DocTypeGroupCode = result_new[0].DocTypeGroupCode;
                    data.BOOK = "";
                    data.DocTypeCode = doctype;
                    data.DocTypeYear = docyear;
                    data.DocTypeMonth = docmonth;
                    data.DocNoPrefix = result_new[0].DocNoPrefix;
                    data.Format = result_new[0].Format;
                    data.DocNoStart = dcstart;
                    data.DocNoEnd = dcend;
                    data.DocLastNo = result_new[0].DocStart;
                    data.LastDateUsed = DateTime.Now;
                    data.ACTIVEFLAG = "A";
                    data.CDATE = DateTime.Now;
                    data.ISTAT = "1";

                    string query = "";
                    string Listcol = "  DocTypeGroupCode, BOOK, DocTypeCode, DocTypeYear, DocTypeMonth, DocNoPrefix, Format, DocNoStart, DocNoEnd, DocLastNo, LastDateUsed, ACTIVEFLAG, CDATE, ISTAT";
                    query = "";
                    if (con.isopenconn == DataContext.conselect.con1) { query = "  USE [" + con.DB_backup_name + "]  "; }
                    query += new Mybase().Insert(data, Listcol);


                    var a = con.Excute(query);


                }
                return docno_new;
            }
            catch (Exception c)
            {
                throw c;
            }


        }

        //public string GenProdcode(DataContext con, string TYPECODE, string GROUPCODE, string SUBGROUPCODE)
        //{
        //    int loop = 0;
        //    string Retdocno = "";
        //    try
        //    {

        //        string sql = " select top 1 PCODE,right(PCODE,4) as RUNID from MAS_PRODUCT where TYPECODE = '" + TYPECODE + "' and GROUPCODE ='" + GROUPCODE + "' and SUBGROUPCODE = '" + SUBGROUPCODE + "' order by id desc ";

        //        var result = con.RunQuery<Gendocument_Model.GenProdcode>(sql);
        //        Int32 Curdocno = 0;
        //        Int32 lent = 0;
        //        Int32 max = 0;
        //        string formatdocno = "";
        //        if (result != null && result.Count > 0)
        //        {

        //            lent = result[0].RUNID.Length;
        //            string lent2 = "";
        //            for (int i = 0; i < lent; i++)
        //            {
        //                lent2 += "9";
        //                formatdocno += "0";
        //            }
        //            max = Int32.Parse(lent2);
        //            Curdocno = Int32.Parse(result[0].RUNID);
        //            Found:
        //            if (Curdocno >= max)
        //            {
        //                throw new Exception("Unable to continue running numbers");
        //            }
        //            else
        //            {
        //                Curdocno += 1;
        //            }
        //            string docno = Curdocno.ToString(formatdocno);


        //            Retdocno = TYPECODE + GROUPCODE + SUBGROUPCODE + docno;

        //            string chk_docno = " select top 1 PCODE  RUNID from MAS_PRODUCT where pcode = '" + Retdocno + "' ";
        //            var chk_doc = con.RunQuery<SaleMmodels>(chk_docno);
        //            if (chk_doc.Count > 0)
        //            {
        //                if (loop <= 10)
        //                {
        //                    loop += 1;
        //                    goto Found;

        //                }
        //            }
        //        }
        //        else
        //        {
        //            Retdocno = TYPECODE + GROUPCODE + SUBGROUPCODE + "0001";
        //        }
        //        return Retdocno;
        //    }
        //    catch (Exception c)
        //    {
        //        throw c;
        //    }
        //}

    }

}