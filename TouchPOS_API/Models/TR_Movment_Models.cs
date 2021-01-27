using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseRepository.Helpers;
using TouchPOS_API.Helpers;
using System.Configuration;




namespace TouchPOS_API.Models
{
    public class TR_Movment_Models
    {
        public class Data_Year_end
        {
            public string DOCYEAR { get; set; }
        }
        //public class Data_Carry
        //{
        //    public string BD_ID { get; set; }
        //    public string BDCODE { get; set; }
        //    public string FL_ID { get; set; }
        //    public string FLCODE { get; set; }
        //    public string FR_ID { get; set; }
        //    public string FRCODE { get; set; }
        //    public string LOCID { get; set; }
        //    public string LOT_ID { get; set; }
        //    public string TAGID { get; set; }
        //    public string PID { get; set; }
        //    public string PCODE { get; set; }
        //    public string PNAME { get; set; }
        //    public double QTY { get; set; }
        //    public int IDC { get; set; }
        //    public double COST { get; set; }
        //    public string UNITID { get; set; }
        //    public string UNITCODE { get; set; }
        //    public string UNITNAME { get; set; }
        //}
        public class MOV_Save
        {
            public Data_MOVT Data_H = new Data_MOVT();
            public List<Data_MOVT_D> Data_ITEMS = new List<Data_MOVT_D>();
            public List<Data_BALANCE> Data_BALANCE = new List<Data_BALANCE>();

        }


        public class Data_List
        {
            [Column]
            public string TR_ID { get; set; }

            [Column]
            public string DOCTYPE { get; set; }
            [Column]
            public string DOCNO { get; set; }
            [Column]
            public DateTime DOCDATE { get; set; }
            [Column]
            public string DCSTAT { get; set; }
            [Column]
            public string REF_DOCNO { get; set; }

            [Column]
            public string STNAME { get; set; }

            [Column]
            public Decimal TOTAL_QTY { get; set; }

            [Column]
            public string pername { get; set; }
            [Column]
            public DateTime MDATE { get; set; }

        }
        [Table("MOVT")]
        public class Data_MOVT
        {

            [Column]
            public int ID { get; set; }
            [Column]
            public string TR_ID { get; set; }
            [Column]
            public string DOCTYPE { get; set; }
            [Column]
            public string DOCNO { get; set; }
            [Column]
            [Date(Format = "yyyy-MM-dd")]
            public DateTime DOCDATE { get; set; }
            [Column]
            public string DOCYEAR { get; set; }
            [Column]
            public string DOCMONTH { get; set; }
            [Column]
            public string CORP_CODE { get; set; }
            [Column]
            public string Branch_CODE { get; set; }
            [Column]
            public string MOV_TYPE { get; set; }
            [Column]
            public Decimal TOTAL_QTY { get; set; }
            [Column]
            public Decimal TOTAL_AMOUNT { get; set; }
            [Column]
            public string REF_DOCNO { get; set; }
            [Column]
            public string REF_DOCTYPE { get; set; }
            [Column]
            public string LOT_ID { get; set; }
            [Column]
            public string STCODE { get; set; }
            [Column]
            public string REMARK1 { get; set; }
            [Column]
            public string REMARK2 { get; set; }
            [Column]
            public string REMARK3 { get; set; }
            [Column]
            public string REMARK4 { get; set; }
            [Column]
            public string REMARK5 { get; set; }
            [Column]
            public string DESCRIPTION { get; set; }
            [Column]
            public string DCSTAT { get; set; }
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
            public string PERCODE { get; set; }
            [Column]
            public string PERNAME { get; set; }
            [Column]
            public string DAY_END { get; set; }
            public string YEAR { get; set; }
            
            public Data_MOVT()
            {
                this.DAY_END = "";
                this.YEAR = "";
            }


        }
        [Table("MOVT_D")]
        public class Data_MOVT_D
        {
            [Column]
            public string TR_ID { get; set; }
            [Column]
            public string DOCTYPE { get; set; }
            [Column]
            public string DOCNO { get; set; }
            [Column]
            public int SEQ { get; set; }
            [Column]
            public string PCODE { get; set; }
           
            [Column]
            public string PNAME { get; set; }
            [Column]
            public Decimal QTY { get; set; }
            [Column]
            public int IDC { get; set; }
            [Column]
            public Decimal UNIT_COST { get; set; }
            [Column]
            public string UNITCODE { get; set; }
            [Column]
            public string UNITNAME { get; set; }
            [Column]
            public Decimal ST_QTY { get; set; }
            [Column]
            public Decimal ST_QTY2 { get; set; }
            [Column]
            public Decimal ST_COST { get; set; }
            [Column]
            public string ST_UNITCODE { get; set; }
            [Column]
            public string ST_UNITNAME { get; set; }
            [Column]
            public Decimal TOTAL_COST { get; set; }
            [Column]
            public string REMARK1 { get; set; }
            [Column]
            public string REMARK2 { get; set; }
            [Column]
            public string REMARK3 { get; set; }
            [Column]
            public string REMARK4 { get; set; }
            [Column]
            public string REMARK5 { get; set; }

        }
        [Table("MOV_BALANCE")]
        public class Data_BALANCE
        {
            [Column]
            public int ID { get; set; }
            [Column]
            public string MOV_ID { get; set; }
            [Column]
            public string MOV_DOCNO { get; set; }
            [Column]
            public string MOV_DOCTYPE { get; set; }
            [Column]
            public string CORP_CODE { get; set; }
            [Column]
            public string Branch_CODE { get; set; }
            [Column]
            public string STCODE { get; set; }
            [Column]
            public string LOT_ID { get; set; }
            [Column]
            public string PCODE { get; set; }
            [Column]
            public Decimal QTY { get; set; }
            [Column]
            public int IDC { get; set; }
            [Column]
            public Decimal COST { get; set; }
            [Column]
            public string UNITCODE { get; set; }
            [Column]
            public Decimal ST_QTY { get; set; }
            [Column]
            public Decimal ST_COST { get; set; }
            [Column]
            public string ST_UNITCODE { get; set; }
            [Column]
            public string REMARK { get; set; }
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
            public string DCSTAT { get; set; }
            [Column]
            public string ISTAT { get; set; }
            public string DAY_END { get; set; }
            public Data_BALANCE()
            {
                this.DAY_END = "N";
            }

        }

        public class PRODUCT_TAGID
        {

            [Column]
            public string TR_ID { get; set; }
            [Column]
            public string TAGID { get; set; }
            [Column]
            public string PCODE { get; set; }
            [Column]
            public string PNAME { get; set; }
            [Column]
            public string BARCODE { get; set; }
            [Column]
            public string TYPEID { get; set; }
            [Column]
            public string PTCODE { get; set; }
            [Column]
            public string PTNAME { get; set; }
            [Column]
            public string GROUPID { get; set; }
            [Column]
            public string PGCODE { get; set; }
            [Column]
            public string PGNAME { get; set; }
            [Column]
            public string SUBGROUPID { get; set; }
            [Column]
            public string PGSCODE { get; set; }
            [Column]
            public string PGSNAME { get; set; }
            [Column]
            public string BRANDCODE { get; set; }
            [Column]
            public string BRANDNAME { get; set; }
            [Column]
            public string MODELCODE { get; set; }
            [Column]
            public string COLORCODE { get; set; }
            [Column]
            public string COLORNAME { get; set; }
            [Column]
            public string UNITCODE { get; set; }
            [Column]
            public string UNIT_ID { get; set; }
            [Column]
            public string UNITNAME { get; set; }
            [Column]
            public string PACKCODE { get; set; }
            [Column]
            public string PACKNAME { get; set; }
            [Column]
            public int PRICESTD { get; set; }
            [Column]
            public string ACTIVEFLAG { get; set; }
        }
        public class PERSON_DATA
        {
            public string PER_ID { get; set; }
            public string PERCODE { get; set; }
            public string PERNAME { get; set; }
        }
        public class Inquiry_TagID
        {

            [Column]
            public DateTime DOCDATE { get; set; }
            [Column]
            public string DOCNO { get; set; }
            [Column]
            public string DOCTYPE { get; set; }
            [Column]
            public string MOV_TYPE { get; set; }
            [Column]
            public string TAGID { get; set; }
            [Column]
            public string PCODE { get; set; }
            [Column]
            public string PNAME { get; set; }
            [Column]
            public string LOCID { get; set; }
            [Column]
            public string IMGNAME1 { get; set; }
            [Column]
            public string IMGPATH1 { get; set; }


        }
        public class Location_DATA
        {


            [Column]
            public string TR_ID { get; set; }
            [Column]
            public string BUILD_TRID { get; set; }
            [Column]
            public string BDCODE { get; set; }
            [Column]
            public string BDNAME { get; set; }
            [Column]
            public string FCODE { get; set; }
            [Column]
            public string FNAME { get; set; }
            [Column]
            public string RCODE { get; set; }
            [Column]
            public string RNAME { get; set; }
            [Column]
            public string LOCID { get; set; }

        }
        public class MOV_BALANCE
        {

            [Column]
            public string BD_ID { get; set; }
            [Column]
            public string BDCODE { get; set; }
            [Column]
            public string FL_ID { get; set; }
            [Column]
            public string FLCODE { get; set; }
            [Column]
            public string FR_ID { get; set; }
            [Column]
            public string FRCODE { get; set; }
            [Column]
            public string LOCID { get; set; }
            [Column]
            public string LOT_ID { get; set; }
            [Column]
            public string TAGID { get; set; }
            [Column]
            public string PID { get; set; }
            [Column]
            public string PCODE { get; set; }
            [Column]
            public string PNAME { get; set; }
            [Column]
            public Decimal QTY { get; set; }
            [Column]
            public Decimal COST { get; set; }
            [Column]
            public string UNITID { get; set; }
            [Column]
            public string UNITCODE { get; set; }
            [Column]
            public string UNITNAME { get; set; }
            [Column]
            public string ISTAT { get; set; }

        }
        public class MOV_SCR_TO
        {

            [Column]
            public string TR_ID { get; set; }
            [Column]
            public string DOCNO { get; set; }
            [Column]
            public string DOCTYPE { get; set; }
            [Column]
            public int SEQ { get; set; }
            [Column]
            public string PID { get; set; }
            [Column]
            public string PCODE { get; set; }
            [Column]
            public string PNAME { get; set; }
            [Column]
            public string TAGID { get; set; }
            [Column]
            public string LOCID { get; set; }
            [Column]
            public Decimal UNIT_PRICE { get; set; }
            [Column]
            public string UNIT_ID { get; set; }
            [Column]
            public string UNITCODE { get; set; }
            [Column]
            public string UNITNAME { get; set; }

            [Column]
            public string PER_ID { get; set; }
            [Column]
            public string PERCODE { get; set; }
            [Column]
            public string PERNAME { get; set; }

        }
        public class MOV_Inquiry_WAIT_Tranfer
        {

            [Column]
            public string TR_ID { get; set; }
            [Column]
            public string DOCNO { get; set; }
            [Column]
            public string DOCTYPE { get; set; }
            [Column]
            public int SEQ { get; set; }
            [Column]
            public string PID { get; set; }
            [Column]
            public string PCODE { get; set; }
            [Column]
            public string PNAME { get; set; }
            [Column]
            public string TAGID { get; set; }
            [Column]
            public string LOCID { get; set; }
            [Column]
            public Decimal UNIT_PRICE { get; set; }
            [Column]
            public string UNIT_ID { get; set; }
            [Column]
            public string UNITCODE { get; set; }
            [Column]
            public string UNITNAME { get; set; }

        }
        public class MOV_SCR_RP
        {

            [Column]
            public string TR_ID { get; set; }
            [Column]
            public string DOCNO { get; set; }
            [Column]
            public string DOCTYPE { get; set; }
            [Column]
            public int SEQ { get; set; }
            [Column]
            public string PID { get; set; }
            [Column]
            public string PCODE { get; set; }
            [Column]
            public string PNAME { get; set; }
            [Column]
            public string TAGID { get; set; }
            [Column]
            public string LOCID { get; set; }
            [Column]
            public Decimal UNIT_PRICE { get; set; }
            [Column]
            public string UNIT_ID { get; set; }
            [Column]
            public string UNITCODE { get; set; }
            [Column]
            public string UNITNAME { get; set; }
            [Column]
            public string LOC_OUTSIDE { get; set; }

        }
        public class V_MOV_BALANCE
        {

            [Column]
            public string STCODE { get; set; }
            [Column]
            public string PCODE { get; set; }
            [Column]
            public string ST_QTY { get; set; }
            [Column]
            public string ST_UNITCODE { get; set; }
            [Column]
            public string ISTAT { get; set; }


        }


        public class SALE_VOID
        {
            public string MRTSLIPNO { get; set; }
            public string CREDITNOTE { get; set; }
            public string UID { get; set; }
        }
    }
}