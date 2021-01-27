using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class ShopModels
    {

            public int SHOPID { get; set; }
            public string MRIP { get; set; }
            public string MRID { get; set; }
            public string POSID { get; set; }
            public string SHOPNAME { get; set; }
            public string OWNER { get; set; }
            public string SLIPNO { get; set; }
            public string FOODTYPE { get; set; }
            public Decimal SHAREPERCENT { get; set; }
            public bool VAT { get; set; }
            public string CONTACT { get; set; }
            public string CONTSTATUS { get; set; }
            public DateTime STARTDATE { get; set; }
            public DateTime ENDDATE { get; set; }
            public string UID { get; set; }
            public DateTime LUPDATE { get; set; }
            public short KEY01 { get; set; }
            public short KEY02 { get; set; }
            public short KEY03 { get; set; }
            public short KEY04 { get; set; }
            public short KEY05 { get; set; }
            public short KEY06 { get; set; }
            public short KEY07 { get; set; }
            public short KEY08 { get; set; }
            public short KEY09 { get; set; }
            public bool ACTIVEFLAG { get; set; }
            public float ACCPAID { get; set; }
            public string VOIDNO { get; set; }
            public string SHOPTYPE { get; set; }
            public string SLIPTYPE { get; set; }
            public string CPNSHOPTYPE { get; set; }
            public short BUDGETPERMONTH { get; set; }
            public short MINIMUM { get; set; }
            public string SHAREPERCENTFLAG { get; set; }
            public string GPRULE { get; set; }
            public string STOCK { get; set; }
            public string MAINMENU { get; set; }
            public string RONAME { get; set; }
            public string SOURCE { get; set; }
            public string MSGLINE1 { get; set; }
            public string MSGLINE2 { get; set; }
            public string MSGLINE3 { get; set; }
  
    }
}