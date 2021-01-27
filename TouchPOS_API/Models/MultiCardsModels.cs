using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class MultiCardsModels
    {
        public string SHOPID { get; set; }
        public string POSID { get; set; }
        public string BARCODE { get; set; }
        public int CUSED { get; set; }
        public int CUSED1 { get; set; }
        public Nullable<int> MRTAMOUNT { get; set; }
        public Nullable<bool> STATUS { get; set; }
    }
}