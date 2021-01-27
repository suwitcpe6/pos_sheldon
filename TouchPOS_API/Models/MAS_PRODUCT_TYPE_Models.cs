using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseRepository.Helpers;
using TouchPOS_API.Helpers;
using System.Configuration;

namespace TouchPOS_API.Models
{
    public class MAS_PRODUCT_TYPE_Models
    {
        public class PRODUCT_TYPE_List
        {
            [Column]
            public string ID { get; set; }
            [Column]
            public string PTCODE { get; set; }
            [Column]
            public string PTNAME { get; set; }
            [Column]
            [Date(Now = true)]
            public DateTime MDATE { get; set; }
            [Column]
            public string ACTIVEFLAG { get; set; }
            [Column]
            public string CHKSTOCK { get; set; }

            
        }
        [Table("MAS_PRODUCT_TYPE")]
        public class PRODUCT_TYPE_Data
        {
            [Column]
            public int ID { get; set; }
            [Column]
            public string TR_ID { get; set; }
            [Column]
            public string PTCODE { get; set; }
            [Column]
            public string PTNAME { get; set; }
            
            [Column]
            public string DESCRIPTION { get; set; }
            [Column]
            public string REMARK { get; set; }
            [Column]
            public string ACTIVEFLAG { get; set; }
            [Column]
            [Date(Now = true)]
            public DateTime CDATE { get; set; }
            [Column]
            public string CUSE { get; set; }
            [Column]
            [Date(Now = true)]
            public DateTime MDATE { get; set; }
            [Column]
            public string MUSE { get; set; }
            [Column]
            public string ISTAT { get; set; }
            [Column]
            public string CHKSTOCK { get; set; }
        }
    }
}