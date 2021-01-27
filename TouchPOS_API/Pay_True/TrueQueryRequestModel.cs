using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Pay_True
{
    public class TrueQueryRequestModel
    {
        public string isv_payment_ref { get; set; }
        public string transaction_date { get; set; }

    }
}