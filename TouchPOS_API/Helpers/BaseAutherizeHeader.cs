using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Helpers
{
    public class BaseAutherizeHeader
    {
        public static string USER_NAME { get; set; }
        public static int USER_ID { get; set; }
        public static string LANG { get; set; }
    }
    public class _BaseAutherizeHeader
    {
        public string USER_NAME { get; set; }
        public int USER_ID { get; set; }
        public string LANG { get; set; }
    }
}