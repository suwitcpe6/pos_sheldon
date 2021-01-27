using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class MAS_DOC_STATUS_MODELS
    {
        
        public class DOC_STATUS_SEL
        {

            public int ID { get; set; }
            public string DOS_ID { get; set; }
            public string DOS_NAME { get; set; }
            public string DOS_DESC { get; set; }
            public string DOS_GROUP { get; set; }
            public DateTime CDATE { get; set; }
            public string ISTAT { get; set; }
        }
    }
}