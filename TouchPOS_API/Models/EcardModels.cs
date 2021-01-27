using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class EcardModels
    {
        public int CID { get; set; }
        public Nullable<int> CUSED { get; set; }
        public string BARCODE { get; set; }
        public Nullable<int> TYPEID { get; set; }
        public string CADDITEM { get; set; }
        public Nullable<System.DateTime> CDATE { get; set; }
        public Nullable<System.DateTime> CEXPIRED { get; set; }
        public string CSTATUS { get; set; }
        public Nullable<int> CBALANCE { get; set; }
        public Nullable<System.DateTime> CLUPDATE { get; set; }
        public Nullable<bool> BACKUPFLG { get; set; }
        public Nullable<short> CUSED1 { get; set; }
        public Nullable<System.DateTime> PROCESSDATE { get; set; }
    }
}