using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Pay_True
{
    public class TrueQueryResponseModel
    {
        public Status status { get; set; }
        public Data data { get; set; }

        public class Status
        {
            public string code { get; set; }
            public string message { get; set; }
        }

        public class Data
        {
            public string payment_id { get; set; }
            public string isv_payment_ref { get; set; }
            public string isv { get; set; }
            public string merchant { get; set; }
            public string amount { get; set; }
            public string currency { get; set; }
            public string customer { get; set; }
            public string status { get; set; }
            public string response_code { get; set; }
            public string response_message { get; set; }
            public string refunded { get; set; }
            public string created { get; set; }
            public string updated { get; set; }
            public MetaData metadata { get; set; }
            public List<Refunds> refunds { get; set; }

            public class Refunds
            {
                public string refund_id { get; set; }
                public string isv_refund_ref { get; set; }
                public string amount { get; set; }
                public string created { get; set; }
                public string status { get; set; }
                public string response_code { get; set; }
                public string response_message { get; set; }
            }

            public class MetaData
            {
                public string description { get; set; }
                public string user_mobile { get; set; }
                public string shop_id { get; set; }
                public string client_id { get; set; }
                public string partner_shop_id { get; set; }
                public string orion_channel { get; set; }
                public string terminal_id { get; set; }
                public string payment_code { get; set; }
            }
        }
    }
}