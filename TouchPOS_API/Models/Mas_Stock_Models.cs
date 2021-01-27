﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseRepository.Helpers;
using TouchPOS_API.Helpers;
using System.Configuration;


namespace TouchPOS_API.Models
{
    public class Mas_Stock_Models
    {

        public class MAS_STOCK_List
        {
            [Column]
            public string ID { get; set; }
            [Column]
            public string STCODE { get; set; }
            [Column]
            public string STNAME { get; set; }
            [Column]
            [Date(Now = true)]
            public DateTime MDATE { get; set; }
            [Column]
            public string ACTIVEFLAG { get; set; }
        }
        [Table("MAS_STOCK")]
        public class MAS_STOCK_Data
        {
            [Column]
            public int ID { get; set; }
            [Column]
            public string STCODE { get; set; }
            [Column]
            public string STNAME { get; set; }
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
        }
    }
}