using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class SaleMmodels
    {
        public int SID { get; set; }
        public string MRTSLIPNO { get; set; }
        public int SHOPID { get; set; }
        public string POSID { get; set; }
        public System.DateTime DOCDATE { get; set; }
        public int DOCYEAR { get; set; }
        public int DOCMONT { get; set; }
        public  bool  BACKUPFLG { get; set; }
        public string VOIDNO { get; set; }
        public  bool  SHOPENDFLG { get; set; }
        public string TAXINVOICE { get; set; }
        public string CREDITNOTES { get; set; }
        public string CARDTENDOR { get; set; }
        public string CARDREF { get; set; }
        public  decimal  CARDPURSE { get; set; }
        public string taxPrint { get; set; }
        public string CUS_ID { get; set; }
        public string PAYTYPE { get; set; }
        public  decimal  PAYAMOUNT { get; set; }
        public  decimal  AMOUNT { get; set; }
        public string DISTP { get; set; }
        public  decimal  DISVALUE { get; set; }
        public  decimal  AFTERDIS { get; set; }
        public string VATTP { get; set; }
        public  decimal  VATVALUE { get; set; }
        public  decimal  AFTERVAT { get; set; }
        public  decimal  NETAMOUNT { get; set; }
        public  int  QTY_TOTAL { get; set; }
        public string STATUS { get; set; }
        public  System.DateTime  CRDATE { get; set; }
        public string CBY { get; set; }
        public  System.DateTime  MODATE { get; set; }
        public string MBY { get; set; }
        public string Remark1 { get; set; }
        public string Remark2 { get; set; }
        public string Remark3 { get; set; }

    }
}