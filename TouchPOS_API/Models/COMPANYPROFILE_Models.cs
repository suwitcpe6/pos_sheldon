using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class COMPANYPROFILE_Models
    {

        public class COMPANYPROFILE_data
        {

            public int COMID { get; set; }

            public string BRNID { get; set; }

            public string BRNNAMETHAI { get; set; }

            public string BRNNAMEENG { get; set; }

            public string BRNTAXID { get; set; }

            public double BRNVAT { get; set; }

            public string COMPNAME { get; set; }

            public string ADDRESS1 { get; set; }

            public string ADDRESS2 { get; set; }

            public string REMARK { get; set; }

            public bool GATEWAY { get; set; }

            public string LOCATION { get; set; }

            public string DIVISION { get; set; }

            public string COMPANYCODE { get; set; }

            public string BRNID2 { get; set; }

            public string LOCATION2 { get; set; }

            public double SERVICECHARGE { get; set; }

            public string FullTaxNo { get; set; }

            public string TCustCode { get; set; }
            public COMPANYPROFILE_data()
            {
                LOCATION = "";
                DIVISION = "";
                COMPANYCODE = "";
                BRNID2 = "";
                LOCATION2 = "";
                SERVICECHARGE = 0;
                LOCATION = "";
                TCustCode = "";

            }
        }

       
}
}