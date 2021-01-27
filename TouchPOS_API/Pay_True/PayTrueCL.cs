using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
using TouchPOS_API.Pay_True;
using Newtonsoft.Json;
using System.Web;
using System.Net;
using System.IO;
using System.Text;
using System.Diagnostics;
using TouchPOS_API.Service;
namespace TouchPOS_API.Pay_True
{
    public class PayTrueCL
    {
        public string API_SRV_True = System.Configuration.ConfigurationSettings.AppSettings.Get("API_true") + "/";
        public API_link API_Url = (new API_link());
        public string stringformat = "yyyy-MM-ddTHH:mm:ss+07:00";
        public class API_link
        {
            public string PaymentRequest = "trueapi/request";
            public string QueryIsrRequest = "trueapi/queryisr";
            public string querypaymentid = "trueapi/querypaymentid";
            public string test = "trueapi/test?val1={0}&val2={1}";
        }
     
        public ResponseMessage test(string val1, string val2)
        {
            var ret = new ResponseMessage();
            try
            {
                string link = API_SRV_True + (string.Format(API_Url.test, val1, val2));
                string jsonresponse = new Connect_API().GET(link);


                ret.Data = jsonresponse;
                return ret;
            }
            catch (WebException wex)
            {
                StreamReader sr = new StreamReader(wex.Response.GetResponseStream());
                ret.Respon.SystemErrorMessage = sr.ReadToEnd();
                ret.Respon.Result = false;
                Debug.WriteLine(ret.Respon.SystemErrorMessage);
                //throw wex;
                return ret;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                ret.Respon.SystemErrorMessage = "API : " + ex.Message.ToString();
                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
                return ret;
                //throw ex;
            }
        }


        public ResponseMessage TruePaymentRequest(TrueRequestModel model)
        {
            var ret = new ResponseMessage();
            try
            {
                var jsonstring = JsonConvert.SerializeObject(model);
                string tr_resposs = new Connect_API().Post(API_SRV_True + API_Url.PaymentRequest, jsonstring);

                var value = JsonConvert.DeserializeObject<TrueResponseModel>(tr_resposs);
                if (value.data != null)
                {
                    ret.Respon.Result = true;
                    ret.Respon.Result_value = value.data.payment_id;
                    ret.Data = value.data.payment_id;
                }
                else
                {
                    throw new Exception("True : " + value.status.code + " : ไม่พบข้อมูลบัตร กรุณาลองอีกครั้ง");
                }
                return ret;
            }


            catch (WebException wex)
            {
                //for (int i = 1; i < 3; i++)
                //{
                //    var model_isr = new TrueQueryRequestModel();
                //    model_isr.isv_payment_ref = model.isv_payment_ref;
                //    model_isr.transaction_date =( new WorkingdateCL().Getdate()).ToString(stringformat);
                //    var jsonstring = JsonConvert.SerializeObject(model_isr);
                //    var valu = TrueQueryIsrRequest(model_isr);

                //    if (valu.Respon.Result == true)
                //    {
                //       var  rest = new TrueQueryResponseModel();
                //         rest = ( TrueQueryResponseModel)(valu.Data) ;
                //        ret.Respon.Result = true;
                //        ret.Respon.Result_value = rest.data.payment_id;
                //        ret.Data = rest.data.payment_id;
                //    }
                //    else
                //    {
                //        System.Threading.Thread.Sleep(3000);
                //    }
                //}

                StreamReader sr = new StreamReader(wex.Response.GetResponseStream());
                //Console.WriteLine(sr.ReadToEnd());
                Debug.WriteLine(sr.ReadToEnd());

                ret.Respon.SystemErrorMessage = sr.ReadToEnd();
                ret.Respon.Result = false;
                //throw wex;
                return ret;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                ret.Respon.SystemErrorMessage = ex.Message.ToString();
                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
                return ret;
                //throw ex;
            }
        }

        public ResponseMessage TrueQueryIsrRequest(TrueQueryRequestModel model)
        {
            var ret = new ResponseMessage();
            try
            {
                var jsonstring = JsonConvert.SerializeObject(model);
                ret.Data = new Connect_API().Post(API_SRV_True + API_Url.QueryIsrRequest, jsonstring);
                return ret;

            }
            catch (WebException wex)
            {
                StreamReader sr = new StreamReader(wex.Response.GetResponseStream());
                ret.Respon.SystemErrorMessage = sr.ReadToEnd();
                ret.Respon.Result = false;
                Debug.WriteLine(ret.Respon.SystemErrorMessage);
                //throw wex;
                return ret;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                ret.Respon.SystemErrorMessage = "API : " + ex.Message.ToString();
                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
                return ret;
                //throw ex;
            }
        }
        public ResponseMessage TrueQueryPaymentRequest(TrueQueryPaymentRequestModel model)
        {
            var ret = new ResponseMessage();
            try
            {
                var jsonstring = JsonConvert.SerializeObject(model);
                ret.Data = new Connect_API().Post(API_SRV_True + API_Url.querypaymentid, jsonstring);
                return ret;
            }
            catch (WebException wex)
            {
                StreamReader sr = new StreamReader(wex.Response.GetResponseStream());
                ret.Respon.SystemErrorMessage = sr.ReadToEnd();
                ret.Respon.Result = false;
                Debug.WriteLine(ret.Respon.SystemErrorMessage);
                //throw wex;
                return ret;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                ret.Respon.SystemErrorMessage = "API : " + ex.Message.ToString();
                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
                return ret;
                //throw ex;
            }
        }


    }
}