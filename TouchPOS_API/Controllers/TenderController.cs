using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TouchPOS_API.Service;
using TouchPOS_API.Class;
namespace TouchPOS_API.Controllers
{
    public class TenderController : ApiController
    {

        #region "Get"

        [HttpGet]
        [Route("api/Tender/SEL_TenderCL")]
        public ResponseMessage SEL_TenderCL(string Val1)
        {
            return new TenderCL().SEL_TenderCL(Val1);
        }

        #endregion
        #region "POST"


        #endregion
    }
}
