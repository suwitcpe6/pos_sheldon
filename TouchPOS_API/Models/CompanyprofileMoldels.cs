using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class CompanyprofileMoldels
    {
        public int COMID { get; set; }
        public string BRNID { get; set; }
        public string BRNNAMETHAI { get; set; }
        public string BRNNAMEENG { get; set; }
        public string BRNTAXID { get; set; }
        public double BRNVAT { get; set; }
        public string COMPNAME { get; set; }
        public string BRNCODE { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public string REMARK { get; set; }
        public bool GATEWAY { get; set; }
        public string STCODE { get; set; }

        public string Merchant_ID { get; set; }
        public string Profit_N { get; set; }
        public CompanyprofileMoldels()
        {
            STCODE = "";
            Merchant_ID = "";
            Profit_N = "";
        }
    }


}