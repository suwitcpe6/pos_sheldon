using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
    public class confirmpay
    {
        public ConfirmpayModels payment = new ConfirmpayModels();
        public CardtranModels.SALE_INT SALE_INT = new CardtranModels.SALE_INT();
    }
    public class ConfirmpayModels
    {
        public String payment_id { get; set; }
        public String mrt_slip { get; set; }
        public String SHOPID { get; set; }


        public String typeid { get; set; }
        public String cused { get; set; }
        public String barcode { get; set; }
        public String cused1 { get; set; }
        public String clstatus { get; set; }
        public String clamount { get; set; }
        public String clreceive { get; set; }
        public String cpromotion { get; set; }
        public String tid { get; set; }
        public String uid { get; set; }
        public String tendor { get; set; }
        public String clupdate { get; set; }
        public String processdate { get; set; }
        public String remark { get; set; }

    }

    public class ConfirmpayModels_log
    {

        public int pid { get; set; }
        public string typeid { get; set; }
        public string barcode { get; set; }
        public string clstatus { get; set; }
        public int clamount { get; set; }
        public int clreceive { get; set; }
        public int cpromotion { get; set; }
        public string tid { get; set; }
        public string uid { get; set; }
        public string tendor { get; set; }
        public DateTime clupdate { get; set; }
        public DateTime processdate { get; set; }
        public string Remark { get; set; }
        public string LOG_TYPE { get; set; }
        public string MRTSLIPNO { get; set; }
        public string SHOPID { get; set; }
        public string POSID { get; set; }
        public string MERCHAND_ID { get; set; }
        public string APP_ID { get; set; }
        public string PAYMENT_CODE { get; set; }
        public Decimal PAY_AMOUNT { get; set; }
        public string PAY_STATE { get; set; }
        public string PAY_DESCRIPTION { get; set; }
        public string PAY_Remark { get; set; }
    }
}