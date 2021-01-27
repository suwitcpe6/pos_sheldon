using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Pay_True
{
    public class TrueRequestModel
    {

        public string isv_payment_ref { get; set; }
        public string merchant_id { get; set; }
        public string currency { get; set; }
        public string request_amount { get; set; }
        public string payment_method { get; set; }
        public string payment_code { get; set; }
        public string description { get; set; }
        public  MetaData  metadata { get; set; }

        public class MetaData
        {
            public string partner_shop_id { get; set; }
        }
    }
}