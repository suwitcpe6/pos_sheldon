using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Pay_True
{
    public class TrueResponseModel
    {
        public Status status { get; set; }
        public Data data { get; set; }




        public class Status
        {
            public string code { get; set; }
            public string messasge { get; set; }
        }

        public class Data
        {
            public string payment_id { get; set; }
        }
    }
}