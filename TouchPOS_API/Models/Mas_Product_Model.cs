using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseRepository.Helpers;
using TouchPOS_API.Helpers;
using System.Configuration;

namespace TouchPOS_API.Models
{
    public class Mas_Product_Model
        
    {
        public class Product_data
        {
            public Product Product = new Product();
            public List<MAS_PRODUCT_SED_UNIT> PRODUCT_SED_UNIT = new List<MAS_PRODUCT_SED_UNIT>();

        }
        public class Product_SCR
        {

            [Column]
            public string PCODE { get; set; }
 
            [Column]
            public string PNAME { get; set; }
            [Column]
            public string PTNAME { get; set; }
            [Column]
            public string PGNAME { get; set; }
            [Column]
            public double  COST_STD { get; set; }
            [Column]
            public string UNITCODE { get; set; }

            [Column]
            public string UNITNAME { get; set; }
            
        }
        public class Product_List
        {
            [Column]
            public string ID { get; set; }
            [Column]
            public string PCODE { get; set; }

            [Column]
            public string PNAME { get; set; }           
            [Column]
            public string PGNAME { get; set; }
            [Column]
            public string PTNAME { get; set; }
            [Column]
            public DateTime MDATE { get; set; }
            [Column]
            public string ACTIVEFLAG { get; set; }
        }



        [Table("MAS_PRODUCT")]
        public class Product
        {
            [Column]
            public int ID { get; set; }
            [Column]
            public string PCODE { get; set; }
            [Column]
            public string PCODE2 { get; set; }
            [Column]
            public string PNAME { get; set; }
            [Column]
            public string PGCODE { get; set; }
            [Column]
            public string PGNAME { get; set; }
            [Column]
            public string UNITCODE { get; set; }
            [Column]
            public string IMGNAME1 { get; set; }
            [Column]
            public double COST_STD { get; set; }
            [Column]
            public string ACTIVEFLAG { get; set; }
            [Column]
            public string DESCRIPTION { get; set; }
            [Column]
            public string REMARK { get; set; }
            [Column]
            [Date(Now = true)]
            public DateTime CDATE { get; set; }
            [Column]
            public string CUSE { get; set; }
            [Column]
            [Date(Now =true)]
            public DateTime MDATE { get; set; }
            [Column]
            public string MUSE { get; set; }
            [Column]
            public string ISTAT { get; set; }
            [Column]
            public double PRICE_STD { get; set; }

            [Column]
            public string PTCODE { get; set; }
        }

        [Table("MAS_PRODUCT_SED_UNIT")]
        public class MAS_PRODUCT_SED_UNIT
        {
            [Column]
            public string SEQ { get; set; }
            [Column]
            public string PCODE { get; set; }
            [Column]
            public string UNITCODE { get; set; }
            [Column]
            public string UNITNAME { get; set; }
            [Column]
            public int QTY_MAIN { get; set; }
            [Column]
            public int QTY_SED { get; set; }

        }
        [Table("TMP_IMP_PRODUCT")]
        public class TMP_IMP_PRODUCT
        {
            [Column]
            public string SEQ { get; set; }
            [Column]
            public string RUN_ID { get; set; }
            [Column]
            public string PCODE { get; set; }
            [Column]
            public string PNAME { get; set; }
            [Column]
            public string DESCRIPTION { get; set; }
            [Column]
            public string IMG_NAME { get; set; }
            [Column]
            public string PTCODE { get; set; }
            [Column]
            public string PTNAME { get; set; }
            [Column]
            public string PGCODE { get; set; }
            [Column]
            public string PGNAME { get; set; }
            [Column]
            public string PGSCODE { get; set; }
            [Column]
            public string PGSNAME { get; set; }
            [Column]
            public string BRANDCODE { get; set; }
            [Column]
            public string BRANDNAME { get; set; }
            [Column]
            public string MODEL { get; set; }
            [Column]
            public string COLORCODE { get; set; }
            [Column]
            public string COLORNAME { get; set; }
            [Column]
            public string UNITCODE { get; set; }
            [Column]
            public string UNITNAME { get; set; }
            [Column]
            public string PACKCODE { get; set; }
            [Column]
            public string PACKNAME { get; set; }
            [Column]
            public string AGE { get; set; }
            [Column]
            public string NUM_OWD { get; set; }
            [Column]
            public string DEPCT { get; set; }
            [Column]
            public string PRICESTD { get; set; }
            [Column]
            public string WEIGHT { get; set; }
            [Column]
            public string Remark { get; set; }
            [Column]
            public string CUSE { get; set; }
            [Column]
            [Date(Now = true)]
            public string CDATE { get; set; }
        }
        [Table("SHOPBUTTONS")]
        public class SHOPBUTTONS
        {

            [Column]
            public int SHOPID { get; set; }
            [Column]
            public string POSID { get; set; }
            [Column]
            public int BTNID { get; set; }
            [Column]
            public string BTNGROUP { get; set; }
            [Column]
            public string BTNNAME { get; set; }
            [Column]
            public double  BTNPRICE { get; set; }
            [Column]
            [Date(Now = true)]
            public DateTime LUPDATE { get; set; }
            [Column]
            public string barcode { get; set; }
            [Column]
            public string flagSt { get; set; }
            [Column]
            public string pic1 { get; set; }
            [Column]
            public string pic2 { get; set; }
            [Column]
            public double  cost { get; set; }
            [Column]
            public string MenuTypeID { get; set; }
            [Column]
            public int flg { get; set; }

        }




    }



}