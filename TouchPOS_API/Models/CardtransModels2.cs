using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class CardtransModels2
    {
        public int CTID { get; set; }
        public int CUSED { get; set; }
        public string BARCODE { get; set; }
        public int SHOPID { get; set; }
        public string POSID { get; set; }
        public  int  MRTAMOUNT { get; set; }
        public string MRTSTATUS { get; set; }
        public string MRTSLIPNO { get; set; }
        public  System.DateTime  MRTLUPDATE { get; set; }
        public string TID { get; set; }
        public string UID { get; set; }
        public  System.DateTime  LUPDATE { get; set; }
        public  bool  BACKUPFLG { get; set; }
        public  bool  CHKFLG { get; set; }
        public string VOIDNO { get; set; }
        public short CUSED1 { get; set; }
        public  int  FOODID { get; set; }
        public string FOODNAME { get; set; }
        public bool SHOPENDFLG { get; set; }
        public  float  GP { get; set; }
        public  float  GPAMOUNT { get; set; }
        public string GPRULE { get; set; }
        public string STOCKID { get; set; }
        public string TAXINVOICE { get; set; }
        public string CREDITNOTES { get; set; }
        public string CARDTENDOR { get; set; }
        public string CARDREF { get; set; }
        public  decimal  CARDPURSE { get; set; }
        public string taxPrint { get; set; }
        public  int  SEQ { get; set; }
        public  decimal  ITEMS_PRICE { get; set; }
        public  int  QTY { get; set; }
        public  int  OLD_BALANCE { get; set; }

    }
}