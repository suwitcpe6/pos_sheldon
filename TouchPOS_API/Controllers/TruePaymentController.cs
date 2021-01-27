using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



using TouchPOS_API.Class;
using TouchPOS_API.Service;
using TouchPOS_API.Pay_True;
using TouchPOS_API.Models;

namespace TouchPOS_API.Controllers
{
    public class TruePaymentController : ApiController
    {
        [HttpGet]
        [Route("trueapi/test")]
        //ใช้รีเช็ค กรณีที่ not restpont
        public ResponseMessage test(string val1, string val2)
        {
            return new PayTrueCL().test(val1, val2);
        }
        [HttpPost]
        [Route("trueapi/request")]
        //ใช้ส่งตัดยอดเงิน
        public ResponseMessage TruePaymentRequest(TrueRequestModel model)
        {    
           return new PayTrueCL().TruePaymentRequest(model);
        }
      
        [HttpPost]
        [Route("trueapi/queryisr")]
        //ใช้รีเช็ค ข้อมุล
        public ResponseMessage QueryIsr(TrueQueryRequestModel model)
        {
            //return new PayTrueCL().TrueQueryIsrRequest(model);
            return new PayTrueCL().TrueQueryIsrRequest(model);
        }
        [HttpPost]
        [Route("trueapi/querypaymentid")]
        //ใช้รีเช็ค กรณีที่ not restpont
        public ResponseMessage QueryPaymentId(TrueQueryPaymentRequestModel model)
        {
            return new PayTrueCL().TrueQueryPaymentRequest(model);
        }

      


    }
}
