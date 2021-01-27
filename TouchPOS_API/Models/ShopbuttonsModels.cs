using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class ShopbuttonsValue
    {
        public List<ShopbuttonsModels> Shopbuttons = new List<ShopbuttonsModels>();
        //public List<happyhourModels> happyhour = new List<happyhourModels>();

    }

    public class ShopbuttonsModels
    {


        public int SHOPID { get; set; }
        public string POSID { get; set; }
        public string BTNID { get; set; }
        public string BTNGROUP { get; set; }
        public string BTNNAME { get; set; }
        public short BTNPRICE { get; set; }
        public DateTime LUPDATE { get; set; }
        public float BTNGP { get; set; }
        public string BTNGPRULE { get; set; }
        public short BTNPRICE2 { get; set; }
        public float BTNGP2 { get; set; }
        public string BTNGPRULE2 { get; set; }
        public string STOCK { get; set; }
        public string STOCKID { get; set; }
        public string promotion { get; set; }
        public string proid { get; set; }




        public int happyhour_id { get; set; }
        public string happyhour_desc { get; set; }
        public DateTime datestart { get; set; }
        public DateTime dateend { get; set; }
        public DateTime timestart { get; set; }
        public DateTime timeend { get; set; }

        public string btnflg { get; set; }


        public string PCODE { get; set; }
        public string PNAME { get; set; }
        public string UNITCODE { get; set; }
        public string UNITNAME { get; set; }
        public ShopbuttonsModels()
        {
            PCODE = "";
            PNAME = "";
            UNITCODE = "";
            UNITNAME = "";
        }
    }

    //public class happyhourModels
    //{
    //    public int happyhour_id { get; set; }
    //    public string happyhour_desc { get; set; }
    //    public DateTime datestart { get; set; }
    //    public DateTime dateend { get; set; }
    //    public DateTime timestart { get; set; }
    //    public DateTime timeend { get; set; }

    //    public string shopid { get; set; }
    //    public string btnid { get; set; }
    //    public string btnflg { get; set; }
    //}
}