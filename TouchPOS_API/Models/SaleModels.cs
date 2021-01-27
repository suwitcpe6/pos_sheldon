using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class SaleModels
    {
        public int CTID { get; set; }
        public string MRTSLIPNO { get; set; }
        public int SHOPID { get; set; }
        public string POSID { get; set; }
        public Nullable<bool> BACKUPFLG { get; set; }
        public string VOIDNO { get; set; }
        public Nullable<bool> SHOPENDFLG { get; set; }
        public string TAXINVOICE { get; set; }
        public string CREDITNOTES { get; set; }
        public string CARDTENDOR { get; set; }
        public string CARDREF { get; set; }
        public Nullable<decimal> CARDPURSE { get; set; }
        public string taxPrint { get; set; }
        public string CUS_ID { get; set; }
        public string PAYTYPE { get; set; }
        public Nullable<decimal> PAYAMOUNT { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public string DISTP { get; set; }
        public Nullable<decimal> DISVALUE { get; set; }
        public Nullable<decimal> AFTERDIS { get; set; }
        public string VATTP { get; set; }
        public Nullable<decimal> VATVALUE { get; set; }
        public Nullable<decimal> AFTERVAT { get; set; }
        public Nullable<decimal> NETAMOUNT { get; set; }
        public Nullable<int> QTY_TOTAL { get; set; }
        public string STATUS { get; set; }
        public Nullable<System.DateTime> CRDATE { get; set; }
        public string CBY { get; set; }
        public Nullable<System.DateTime> MODATE { get; set; }
        public string MBY { get; set; }
    }
}