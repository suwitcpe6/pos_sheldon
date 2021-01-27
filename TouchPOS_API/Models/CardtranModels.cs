using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class CardtranModels
    {
        public partial class SALE_INT
        {
            public string CorpBRNID { get; set; }
            public bool Multicard { get; set; }
            //public int Nettotel { get; set; }
            //public SALE Sale_val { get; set; }
            public string MRTSLIPNO { get; set; }
            public int SHOPID { get; set; }
            public string POSID { get; set; }
            public DateTime DOCDATE { get; set; }
            public int DOCYEAR { get; set; }
            public int DOCMONT { get; set; }
            public string TAXINVOICE { get; set; }
            public string CREDITNOTES { get; set; }
            public string CARDTENDOR { get; set; }
            public string CARDREF { get; set; }
            public decimal CARDPURSE { get; set; }
            public string taxPrint { get; set; }
            public string CUS_ID { get; set; }
            public string PAYTYPE { get; set; }
            public decimal PAYAMOUNT { get; set; }
            public decimal AMOUNT { get; set; }
            public string DISTP { get; set; }
            public decimal DISVALUE { get; set; }
            public decimal AFTERDIS { get; set; }
            public string VATTP { get; set; }
            public decimal VATVALUE { get; set; }
            public decimal AFTERVAT { get; set; }
            public decimal NETAMOUNT { get; set; }
            public int QTY_TOTAL { get; set; }
            public string CBY { get; set; }
            public string MBY { get; set; }
            public decimal VALUE_CONVERT { get; set; }
            public string Remark1 { get; set; }
            public string Remark2 { get; set; }
            public string Remark3 { get; set; }
            public string merchant_id { get; set; }
            public string DC_STATE { get; set; }
            public string STCODE { get; set; }

            

            public List<Saleitems> Saleitems { get; set; }
            //public List<MultiCard> Items_MultiCard { get; set; }
            public List<Saleitems_card> Saleitems_card { get; set; }
            public List<Cardtran> Cardtran { get; set; }
        }

        public partial class Cardtran
        {
            //public int CTID { get; set; }
            public int CUSED { get; set; }
            public string BARCODE { get; set; }
            //public Nullable<int> SHOPID { get; set; }
            //public string POSID { get; set; }
            public int MRTAMOUNT { get; set; }
            public string MRTSTATUS { get; set; }
            public string MRTSLIPNO { get; set; }
            public Nullable<System.DateTime> MRTLUPDATE { get; set; }
            public string TID { get; set; }
            public string UID { get; set; }
            public Nullable<System.DateTime> LUPDATE { get; set; }
            public Nullable<bool> BACKUPFLG { get; set; }
            public Nullable<bool> CHKFLG { get; set; }
            public string VOIDNO { get; set; }
            public short CUSED1 { get; set; }
            public int FOODID { get; set; }
            public string FOODNAME { get; set; }
            public string PCODE { get; set; }
            public string PNAME { get; set; }
            public string UNITCODE { get; set; }
            public string UNITNAME { get; set; }
            public bool SHOPENDFLG { get; set; }
            public Nullable<float> GP { get; set; }
            public Nullable<float> GPAMOUNT { get; set; }
            public string GPRULE { get; set; }
            public string STOCKID { get; set; }
            public string TAXINVOICE { get; set; }
            public string CREDITNOTES { get; set; }
            public string CARDTENDOR { get; set; }
            public string CARDREF { get; set; }
            public Nullable<decimal> CARDPURSE { get; set; }
            public string taxPrint { get; set; }
            public Nullable<int> SEQ { get; set; }
            public Nullable<double> ITEMS_PRICE { get; set; }
            public Nullable<int> QTY { get; set; }


        }


        /// <summary>
        /// items
        /// </summary>
        /// 
        public class Saleitems
        {

            public int SEQ { get; set; }
            public int FOODID { get; set; }
            public string FOODNAME { get; set; }
            public string PCODE { get; set; }
            public string PNAME { get; set; }
            public string UNITCODE { get; set; }
            public string UNITNAME { get; set; }
            public float GP { get; set; }
            public float GPAMOUNT { get; set; }
            public float GPRULE { get; set; }
            public decimal ITEMS_PRICE { get; set; }
            public string DISTP { get; set; }
            public decimal DISVALUE { get; set; }
            public decimal AFTERDIS { get; set; }
            public string VATTP { get; set; }
            public decimal VATVALUE { get; set; }
            public decimal AFTERVAT { get; set; }
            public decimal NETAMOUNT { get; set; }
            public int QTY { get; set; }
            public int PRO_ID { get; set; }
            public string PRO_NAME { get; set; }
            public string PRO_TEXT { get; set; }
        }
        public partial class Saleitems_card
        {
            public int SEQ { get; set; }
            public string BARCODE { get; set; }
            public string PAYTYPE { get; set; }


            public int CUSED { get; set; }
            public int CUSED1 { get; set; }
            public int MRTAMOUNT { get; set; }
            public int CBALANCE { get; set; }
            public int CBALANCEREMAIN { get; set; }
            public decimal GP { get; set; }
            public decimal GPAMOUNT { get; set; }
            public string GPRULE { get; set; }
            public int PRO_ID { get; set; }
            public string PRO_NAME { get; set; }
            public string PRO_TEXT { get; set; }

        }
        //public class MultiCard
        //    {
        //        public string SHOPID { get; set; }
        //        public string POSID { get; set; }
        //        public string BARCODE { get; set; }
        //        public int CUSED { get; set; }
        //        public int CUSED1 { get; set; }
        //        public Nullable<int> MRTAMOUNT { get; set; }
        //        public Nullable<bool> STATUS { get; set; }
        //        public Nullable<int> CBALANCE { get; set; }

        //        public Nullable<int> SEQ { get; set; }
        //        public Nullable<int> QTY { get; set; }
        //        public Nullable<int> ITEMS_PRICE { get; set; }
        //        public Nullable<int> OLD_BALANCE { get; set; }
        //    }
        /// <summary>
        /// Print slip
        /// </summary>

        public partial class slipModel
        {
            public string BARCODE { get; set; }
            public decimal MRTAMOUNT { get; set; }
            public string MRTSLIPNO { get; set; }
            public string FOODNAME { get; set; }
            public DateTime LUPDATE { get; set; }
            //public string CDATE { get; set; }
            public DateTime CEXPIRED { get; set; }
            public string CBALANCE { get; set; }
            public int SEQ { get; set; }
            public int QTY { get; set; }
            public int ITEMS_PRICE { get; set; }
            public int OLD_BALANCE { get; set; }
            public string CARDTENDOR { get; set; }
            public string CARDREF { get; set; }
            public string CARDREF_CN { get; set; }
            public string TAXINVOICE { get; set; }

            public string CREDITNOTES { get; set; }
            
            public string COMPNAME { get; set; }
            public string COMPNAME_remark { get; set; }
            public string COMPBRNTAXID { get; set; }

        }
       
        public partial class DayendModel
        {

            public string CARDTENDOR { get; set; }
            public decimal MRTAMOUNT { get; set; }
            public decimal TOTALCARD { get; set; }
            public decimal TOTALCARD_QTY { get; set; }

            
        }
        public partial class RepayModel
        {

            public int CUSED { get; set; }
            public string BARCODE { get; set; }
            public int SHOPID { get; set; }
            public string POSID { get; set; }
            public int MRTAMOUNT { get; set; }
            public string MRTSLIPNO { get; set; }
            public Nullable<System.DateTime> MRTLUPDATE { get; set; }
            public int FOODID { get; set; }
            public string FOODNAME { get; set; }
            public Nullable<float> GP { get; set; }
            public Nullable<float> GPAMOUNT { get; set; }
            public string GPRULE { get; set; }
            public string CARDTENDOR { get; set; }
            public string CARDTENDOR_Name { get; set; }
            public Nullable<decimal> CARDPURSE { get; set; }
            public Nullable<int> SEQ { get; set; }
            public Nullable<double> ITEMS_PRICE { get; set; }
            public Nullable<int> QTY { get; set; }

        }
    }

}