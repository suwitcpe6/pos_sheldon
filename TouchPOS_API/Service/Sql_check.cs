using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Service
{
   
    public class Sql_check
    {
        public string Insert = "Insert";
        public string update = "update";
        public string ROWCOUNT(string cmd, string Table)
        {
            //return "\n if @@ROWCOUNT  = 0 THROW 99001, 'Warning: No rows were "+ cmd +"  "+ Table + " ', 1; ";
            return "";
        }
    }
}
