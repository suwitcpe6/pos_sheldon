using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class USERPROFILE_Mmodels
    {

        public class USERPROFILE_Data
        {
            public string UID { get; set; }
            public string UFULLNAME { get; set; }
            public string UPASSWORD { get; set; }
            public string ULEVEL { get; set; }
            public string USTATUS { get; set; }
            public string UREMARK { get; set; }
            public string UUID { get; set; }
            public DateTime date_now { get; set; }
        }

    }
}