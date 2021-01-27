using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Service;
using TouchPOS_API.Models;
namespace TouchPOS_API.Class
{
    public class Center
    {
        public const string Limit = "  200";
        public class UI_STATE
        {
            public const string UINew = "UINew";
            public const string UIEdit = "UIEdit";
            public const string UIVIEW = "UIVIEW";


        }
        public string Condate(DateTime val, string ff)
        {
            //System.Globalization ThaiCulture;
            //Dim ThaiCulture As New System.Globalization.CultureInfo("en-US")

            var dd = val.Date.ToString("dd"); // Strings.Format((DateTime)val, "dd");
            var MM = val.Date.ToString("MM");//Strings.Format((DateTime)val, "MM");
            var yyyy = val.Date.ToString("yyyy"); //Strings.Format((DateTime)val, "yyyy");


            //var dd = val.Day.ToString(); // Strings.Format((DateTime)val, "dd");
            //var MM = val.Month.ToString();//Strings.Format((DateTime)val, "MM");
            //var yyyy = val.Year.ToString(); //Strings.Format((DateTime)val, "yyyy");



            string time = val.ToLongTimeString();//Strings.Format((DateTime)val, "T");

            string ymd = "";
            if (int.Parse(yyyy) > 2500) yyyy = (int.Parse(yyyy) - 543).ToString();

            if (ff == "ymd") {
                ymd = (yyyy + "/" + MM + "/" + dd + " " + time).ToString();
            }
            if (ff == "ymd hh:mm:ss")
            {
                //if (time == "0:00:00" || time == "")
                //{
                    var date_now = new WorkingdateCL().Getdate();
                    time = date_now.Date_now.ToLongTimeString();
                //}

                 ymd = (yyyy + "/" + MM + "/" + dd + " " + time).ToString();
            }

            if (ff == "ymd2")
            {
                ymd = (yyyy + "/" + MM + "/" + dd ).ToString();
            }
            else if (ff == "yyyy"){
                ymd = yyyy.ToString();
            }
            else if (ff == "show") {
                ymd = (dd + "/" + MM + "/" + yyyy + 543 + " ").ToString();
            } else if (ff == "save") {
                ymd = (dd + "/" + MM + "/" + yyyy + " ").ToString();
            }
            return ymd;
        }


        public string Condate_TH(DateTime val, string ff)
        {
            var dd = val.Date.ToString("dd"); // Strings.Format((DateTime)val, "dd");
            var MM = val.Date.ToString("MM");//Strings.Format((DateTime)val, "MM");
            var yyyy = val.Date.ToString("yyyy"); //Strings.Format((DateTime)val, "yyyy");

            string time = val.ToLongTimeString();//Strings.Format((DateTime)val, "T");

            string ymd = "";
            if (int.Parse(yyyy) < 2500) yyyy = (int.Parse(yyyy) + 543).ToString();

            if (ff == "ymd")
            {
                ymd = (yyyy + "/" + MM + "/" + dd + " " + time).ToString();
            }
            
            else if (ff == "yyyy")
            {
                ymd = yyyy.ToString();
            }
            
            return ymd;
        }

        public ResponseMessage Error_Return(string ErrorMessage, string SystemErrorMessage)
        {
            var value = new ResponseMessage();
            value.Data = null;
            value.Respon.ErrorMessage = ErrorMessage == "" ? "" : "API : " + ErrorMessage;
            value.Respon.Result = false;
            value.Respon.SystemErrorMessage = SystemErrorMessage == "" ? "" : "API : " + SystemErrorMessage;
            return value;

        }

    }
}