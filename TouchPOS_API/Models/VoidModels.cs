using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Models
{
	public class VoidModels
	{
		public class Void_EWALLET_List
		{
			
			public string BARCODE { get; set; }
			public string MRTSLIPNO { get; set; }
			public int SEQ { get; set; }
			public string foodid { get; set; }
			public string FOODNAME { get; set; }
			public  double MRTAMOUNT { get; set; }
			public string CARDTENDOR { get; set; }
			public string CARDTENDOR_NAME { get; set; }
			
			public Void_EWALLET_List()
            {
				SEQ = 0;
				foodid = "";
				FOODNAME = "";
			}

		}

		public class SALE_void
        {
			public string SHOPID { get; set; }
			public string BARCODE { get; set; }
			public string MRTSLIPNO { get; set; }
			public int SEQ { get; set; }
			public string foodid { get; set; }
			public string FOODNAME { get; set; }
			public string CARDTENDOR { get; set; }
			public string Voidtype { get; set; }
			
			public string CN_DOCNO { get; set; }
			public string VOIDNO { get; set; }
		}





	}
}