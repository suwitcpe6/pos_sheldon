using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class CHK_cardsModels
    {
       
        public int CID { get; set; }
        public int CUSED { get; set; }
        public short CUSED1 { get; set; }
        public string BARCODE { get; set; }
        public Nullable<int> TYPEID { get; set; }
        public int CBALANCE { get; set; }

        public string CSTATUS { get; set; }
        public Nullable<System.DateTime> CEXPIRED { get; set; }
        public Nullable<System.DateTime> date_Now { get; set; }


    }
}