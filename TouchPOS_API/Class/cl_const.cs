using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Class
{
    public class cl_const
    {
        public class CUSGROUP
        {
            public const String ATR = "ATR";
            public const String CPN = "CPN";
            public const String HOMEPRO = "HOMEPRO";
            public const String Top = "Top";
            public const String OTHER = "OTHER";
        }
        public class POSTYPE
        {
            public const String prepaid = "prepaid";
            public const String postpaid = "postpaid";

        }

        public class WALLET_TYPE
        {
            public const string WALLET_TYPE_EDC = "EDC";
            public const string WALLET_TYPE_API = "API";
            public const string APIHUBCPN = "APIHUBCPN";

        }
        public class Void_TYPE
        {
            public const string CANCEL = "CANCEL";
            public const string REFUND = "REFUND";
            public const string Verify_slip = "Verify_slip";
            
        }
    }
}