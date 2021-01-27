using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class RPT_BalanceModels
    {
        public class Balance_data
        {
            public string STCODE { get; set; }    
            public string STNAME { get; set; }
            public string PCODE { get; set; }
            public string PNAME { get; set; }
            public string PGCODE { get; set; }
            public string PGNAME { get; set; }
            public Double ST_QTY { get; set; }
            public string ST_UNITCODE { get; set; }
            public string ST_UNITNAME { get; set; }
            public Double ST_COST { get; set; }
        }

        public class Fillter_Balance
        {
            public string STCODE { get; set; }
            public string PCODE1 { get; set; }
            public string PCODE2 { get; set; }
        }
    }
}