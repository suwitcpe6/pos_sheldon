using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseRepository.Helpers;
using TouchPOS_API.Helpers;
using System.Configuration;


namespace TouchPOS_API.Models
{
    public class MAS_Menu_Permis_Models
    {
        public class PER_MIS_Save
        {
            public Data_PER_MIS Data_H = new Data_PER_MIS();
            public List<Data_PER_MIS_D> Data_ITEMS = new List<Data_PER_MIS_D>();


        }
        public class Data_Menu
        {

            [Column]
            public int ID { get; set; }
            [Column]
            public string MNU_CODE { get; set; }
            [Column]
            public int MNU_HSEQ { get; set; }
            [Column]
            public string MNU_HNAME_1 { get; set; }
            [Column]
            public string MNU_HNAME_2 { get; set; }
            [Column]
            public int MNU_SSEQ { get; set; }
            [Column]
            public string MNU_SNAME_1 { get; set; }
            [Column]
            public string MNU_SNAME_2 { get; set; }
            [Column]
            public string MNU_TAG { get; set; }
            [Column]
            public string MNU_OBJ1 { get; set; }
            [Column]
            public string MNU_OBJ2 { get; set; }
            [Column]
            public string MNU_ICO { get; set; }
            [Column]
            public string MNU_DEFAULT_DOCTYPE { get; set; }
            [Column]
            public DateTime U_DATE { get; set; }
            [Column]
            public string U_ID { get; set; }
            [Column]
            public string ISTAT { get; set; }

          
            
        }
        public class Data_List_CBO
        {
            public string TR_ID { get; set; }
            [Column]
            public string PERMIS_CODE { get; set; }
            [Column]
            public string PERMIS_NAME { get; set; }

        }
        public class Data_List
        {
            public string TR_ID { get; set; }
            [Column]
            public string PERMIS_CODE { get; set; }
            [Column]
            public string PERMIS_NAME { get; set; }
            [Column]
            public string UID { get; set; }
            [Column]
            public string ACTIVEFLAG { get; set; }       
            [Column]
            public DateTime MDATE { get; set; }
            [Column]
            public string MUSE { get; set; }


        }
        [Table("PER_MIS")]
        public class Data_PER_MIS
        {


            [Column]
            public int ID { get; set; }
            [Column]
            public string TR_ID { get; set; }
            [Column]
            public string PERMIS_CODE { get; set; }
            [Column]
            public string PERMIS_NAME { get; set; }
            [Column]
            public string UID { get; set; }
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
           [ Column]
            [Date(Now = true)]
            public DateTime MDATE { get; set; }
            [Column]
            public string MUSE { get; set; }
            [Column]
            public string ISTAT { get; set; }

        }
        [Table("PER_MIS_D")]
        public class Data_PER_MIS_D
        {
            [Column]
            public string TR_ID { get; set; }
            [Column]
            public string PERMIS_CODE { get; set; }
            [Column]
            public int SEQ { get; set; }
            [Column]
            public string MNU_CODE { get; set; }
             [Column]
            public string MNU_HNAME_1 { get; set; }
            [Column]
            public string MNU_SNAME_1 { get; set; }

            [Column]
            public bool M_AT { get; set; }
            [Column]
            public bool BTN_ADD { get; set; }
            [Column]
            public bool BTN_EDIT { get; set; }
            [Column]
            public bool BTN_VIEW { get; set; }
            [Column]
            public bool BTN_DEL { get; set; }
            [Column]
            public string REMARK { get; set; }

        }
    }
}