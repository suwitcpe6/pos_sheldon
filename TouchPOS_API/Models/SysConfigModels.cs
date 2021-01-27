using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class SysConfigModels
    {
        public string ITEMSNO { get; set; }
        public string CUSGROUP { get; set; }
        public string VENDOR_GETWAY { get; set; }
        public string CONN_LINK { get; set; }
        public string WALLET_TYPE { get; set; }
        public bool USESTOCK { get; set; }

        public string POSTYPE { get; set; }
        
    }
}