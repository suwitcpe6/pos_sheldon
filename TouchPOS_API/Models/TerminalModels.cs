using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class TerminalModels
    {
        public int TERMINALID { get; set; }
        public string TID { get; set; }
        public string DESCRIPTION { get; set; }
        public string TTAXID { get; set; }
        public string TSTATUS { get; set; }
        public string UID { get; set; }
        public DateTime SLIPDATE { get; set; }
        public string INVOICE { get; set; }
        public string CREDITNOTE { get; set; }
        public DateTime LUPDATE { get; set; }
        public string TUID { get; set; }
        public string TIP { get; set; }
        public string TTYPE { get; set; }
    }
}