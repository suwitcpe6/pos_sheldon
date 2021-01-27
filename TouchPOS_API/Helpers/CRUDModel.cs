using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Helpers
{
    public class CRUDModel
    {
        public string select { get; set; }
        public string insert { get; set; }
        public string insert_value { get; set; }
        public string update { get; set; }
        public string where { get; set; }
        public string foreign_key { get; set; }
        public string foreign_table { get; set; }
        public Dictionary<string, object> data { get; set; }
    }
}