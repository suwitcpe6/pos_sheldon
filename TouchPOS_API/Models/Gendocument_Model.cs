using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using BaseRepository.Helpers;
namespace TouchPOS_API.Models
{
    public class Gendocument_Model
    {
        public class GenProdcode
        {
            public string PCODE { get; set; }
            public string RUNID { get; set; }


        }
        public class GensoSlip
        {
            public string MRIP { get; set; }
            public string SHOPID { get; set; }
            public string POSID { get; set; }
            public string TID { get; set; }
            public string SLIPNO { get; set; }
            public string TRANSDATE { get; set; }
            public string VOIDNO { get; set; }
        }

        public class Gendocument
        {
            public string ID { get; set; }
            public string DocNoPrefix { get; set; }
            public string DocTypeGroupCode { get; set; }
            public string DOCTYPENAME { get; set; }
            public string DocTypeCode { get; set; }
            public string DocNoStart { get; set; }

            public string DocNoEnd { get; set; }
            public string DocLastNo { get; set; }
            public string LastDateUsed { get; set; }

            public string DocTypeYear { get; set; }
            public string DocTypeMonth { get; set; }

            public string DocStart { get; set; }
            public string DocEND { get; set; }
            public string Format { get; set; }


        }
        [Table("MAS_RUNDOCNO ")]
        public class MAS_RUNDOCNO
        {
            [Column(Identity = true)]
            public int ID { get; set; }
            [Column]
            public string DocTypeGroupCode { get; set; }
            [Column]
            public string BOOK { get; set; }
            [Column]
            public string DocTypeCode { get; set; }
            [Column]
            public string DocTypeYear { get; set; }
            [Column]
            public string DocTypeMonth { get; set; }
            [Column]
            public string DocNoPrefix { get; set; }
            [Column]
            public string Format { get; set; }
            [Column]
            public string DocNoStart { get; set; }
            [Column]
            public string DocNoEnd { get; set; }
            [Column]
            public string DocLastNo { get; set; }
            [Column]
            [Date(Now = true)]
            public DateTime LastDateUsed { get; set; }
            [Column]
            public string ACTIVEFLAG { get; set; }
            [Column]
            [Date(Now = true)]
            public DateTime CDATE { get; set; }
            [Column]
            public string ISTAT { get; set; }
        }

        [Table("MAS_DOCTYPE ")]
        public class MAS_DOCTYPE
        {

            [Column]
            public int ID { get; set; }

            [Column]
            public string DOCTYPECODE { get; set; }
            [Column]
            public string DOCTYPENAME { get; set; }
            [Column]
            public string DOCTYPEGROUPCODE { get; set; }
            [Column]
            public string DocNoPrefix { get; set; }
            [Column]
            public string Format { get; set; }
            [Column]
            public string DocStart { get; set; }
            [Column]
            public string DocEND { get; set; }
            [Column]
            public string ACTIVEFLAG { get; set; }
            [Column]
            [Date(Now = true)]
            public DateTime CDATE { get; set; }
            [Column]
            public string ISTAT { get; set; }
        }

    }
}