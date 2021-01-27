using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class TenderModels
    {
        public class Sel_Tender
        {
            public int TID { get; set; }
            public string CODE { get; set; }
            public string NAME { get; set; }
            public string VENDERCODE { get; set; }
            public string VENDERNAME { get; set; }
            public string TYPE { get; set; }
            public string CERRENCY { get; set; }
            public string PAYMENT_METHOD { get; set; }
            public decimal VALUE_CONVERT { get; set; }
            public string Server { get; set; }
            public int SEQ { get; set; }
            public string TERMINALID { get; set; }
            public string POSID { get; set; }
            public string MERCHAND_ID { get; set; }
            public string APP_ID { get; set; }
            public string CLIENT_KEY { get; set; }
            public string CLIENT_SECRET { get; set; }

            public string PREFIX_BARCODE { get; set; }
            public string REMARK1 { get; set; }
            public string REMARK2 { get; set; }
            public string REMARK3 { get; set; }
            public string SCAN_TYPE { get; set; }
            public string VENDER_SHOP_ID { get; set; }

            public Sel_Tender()
            {
                TID = 0;
                CODE = "";
                NAME = "";
                VENDERCODE = "";
                VENDERNAME = "";
                TYPE = "";
                CERRENCY = "";
                PAYMENT_METHOD = "";
                VALUE_CONVERT = 0;
                Server = "";
                SEQ = 0;
                TERMINALID = "";
                POSID = "";
                MERCHAND_ID = "";
                APP_ID = "";
                CLIENT_KEY = "";
                CLIENT_SECRET = "";
                PREFIX_BARCODE = "";
                REMARK1 = "";
                REMARK2 = "";
                REMARK3 = "";
                SCAN_TYPE = "";
                VENDER_SHOP_ID = "";


            }
        }
    }
}