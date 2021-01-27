using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class shop_selectModels
    {

        public int SHOPID { get; set; }
        public string MRIP { get; set; }
        public string MRID { get; set; }
        public string POSID { get; set; }
        public string SHOPNAME { get; set; }
        public float SHAREPERCENT { get; set; }
        public float SHAREPERCENTFLAG { get; set; }
        public int TERMINAL_ID { get; set; }
        public string TERMINAL_TID { get; set; }
        public string TERMINAL_DESCRIPTION { get; set; }
        public string TERMINAL_TTAXID { get; set; }


        public string BRNID { get; set; }
        public string BRNNAMETHAI { get; set; }
        public string BRNNAMEENG { get; set; }
        public string BRNTAXID { get; set; }
        public double BRNVAT { get; set; }
        public string COMPNAME { get; set; }
        public string BRNCODE { get; set; }
        public string EDC_IP { get; set; }
        public string STCODE { get; set; }

        public string Merchant_ID { get; set; }
        public string Profit_N { get; set; }
        public string RONAME { get; set; }

        
        public shop_selectModels()
        {
            STCODE = "";
            Merchant_ID = "";
            Profit_N = "";
            RONAME = "";
        }

    }
}