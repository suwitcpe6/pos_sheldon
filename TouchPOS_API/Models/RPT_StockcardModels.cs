using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class RPT_StockcardModels
    {
        public class Stockcard_data
        {
            public int SEQ { get; set; }
            public string TR_ID { get; set; }
            public string DOCTYPE { get; set; }
            public string DOCNO { get; set; }
            public DateTime  DOCDATE { get; set; }
            public string MOV_TYPE { get; set; }
            public string STCODE { get; set; }
            public string STNAME { get; set; }
            public string PERCODE { get; set; }
            public string PERNAME { get; set; }

            public string PCODE { get; set; }
            public string PNAME { get; set; }
            public int BEG_ST_QTY { get; set; }
            public int  ST_QTY { get; set; }
            public int QTY_IN { get; set; }
            public int QTY_OUT { get; set; }
            public int QTY_remain { get; set; }
            public int IDC { get; set; }
            public string ST_UNITCODE { get; set; }
            public string ST_UNITNAME { get; set; }
            public Stockcard_data()
            {
                SEQ = 0;
                QTY_IN = 0;
                QTY_OUT = 0;
                QTY_remain = 0;
            }

        }

        public class Fillter_Stockcard
        {
            public string Date_Start { get; set; }
            public string Date_End { get; set; }
            public string STCODE { get; set; }
            public string PCODE1 { get; set; }
            public string PCODE2 { get; set; }
        }
    }
}