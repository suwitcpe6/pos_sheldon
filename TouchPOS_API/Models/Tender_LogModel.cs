using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class Tender_LogModel
    {

        public int TID { get; set; }
        public string TENDERCODE { get; set; }
        public string DOCNO { get; set; }
        public string TENDERDOCNO { get; set; }
        public string TERMINALID { get; set; }
        public string POSID { get; set; }
        public string MERCHAND_ID { get; set; }
        public string LOG_TYPE { get; set; }
        public string DATA_TYPE { get; set; }
        public string DATA1 { get; set; }
        public string DATA2 { get; set; }
        public string REMARK1 { get; set; }
        public string REMARK2 { get; set; }
        public string REMARK3 { get; set; }
        public string STATUS { get; set; }
        public string CBY { get; set; }
        public DateTime CDATE { get; set; }
        public string MBY { get; set; }
        public DateTime MODATE { get; set; }
    }
}