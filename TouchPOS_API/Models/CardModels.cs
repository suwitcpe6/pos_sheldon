using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    using System;
    using System.Collections.Generic;
    public class CardModels
    {
        //public int CID { get; set; }
        //public int CUSED { get; set; }
        //public short CUSED1 { get; set; }
        //public string BARCODE { get; set; }
        //public int TYPEID { get; set; }
        //public int CBALANCE { get; set; }

        public int CID { get; set; }
        public int CUSED { get; set; }
        public string BARCODE { get; set; }
        public  int  TYPEID { get; set; }
        public string CADDITEM { get; set; }
        public  System.DateTime  CDATE { get; set; }
        public  System.DateTime  CEXPIRED { get; set; }
        public string CSTATUS { get; set; }
        public  int  CBALANCE { get; set; }
        public  System.DateTime  CLUPDATE { get; set; }
        public  bool  BACKUPFLG { get; set; }
        public short CUSED1 { get; set; }
        public  System.DateTime  PROCESSDATE { get; set; }


    }
}