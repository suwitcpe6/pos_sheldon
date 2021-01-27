using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class RPT_ReceiveModels
    {
        public class Rceive_data
        {
            public string TR_ID { get; set; }
            public string DOCTYPE { get; set; }
            public string DOCNO { get; set; }
            public string DOCDATE { get; set; }
            public string STCODE { get; set; }
            public string PERCODE { get; set; }
            public string PERNAME { get; set; }
            public string REF_DOCNO { get; set; }
            public Double SEQ { get; set; }
            public string PCODE { get; set; }
            public string PNAME { get; set; }
            public Double qty { get; set; }
            public int IDC { get; set; }
            public string UNITCODE { get; set; }
            public string UNITNAME { get; set; }
            public Double UNIT_COST { get; set; }
            public Double ST_QTY { get; set; }
            public string ST_UNITCODE { get; set; }
            public string ST_UNITNAME { get; set; }
            public Double ST_COST { get; set; }
            public Double TOTAL_COST { get; set; }
            
            public string PGCODE { get; set; }
            public string PGNAME { get; set; }
           
        }

        public class Fillter_Receive
        {
            public string DOCTYPE { get; set; }
            public string DCDATE { get; set; }
            public string DOCNO { get; set; }
            public string REFDOCNO { get; set; }
            public string PERCODE { get; set; }
        }

    }
}