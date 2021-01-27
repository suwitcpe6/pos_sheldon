using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TouchPOS_API.Service.MASTER;
using TouchPOS_API.Service.Report;
using TouchPOS_API.Models;
using TouchPOS_API.Class;
namespace TouchPOS_API.Controllers
{
    public class ReportController : ApiController
    {
        [HttpPost]
        [Route("api/Report/Receive")]
        public IHttpActionResult Receive([FromBody] RPT_ReceiveModels.Fillter_Receive val, [FromUri()] string UI_STATE)
        {
            return Json(new RPT_Receive().Receive(val, UI_STATE));
        }
        [HttpPost]
        [Route("api/Report/Balance")]
        public IHttpActionResult Balance([FromBody] RPT_BalanceModels.Fillter_Balance val, [FromUri()] string UI_STATE)
        {
            return Json(new RPT_Balance().Balance(val, UI_STATE));
        }
        [HttpPost]
        [Route("api/Report/Stockcard")]
        public IHttpActionResult Balance([FromBody] RPT_StockcardModels.Fillter_Stockcard val, [FromUri()] string UI_STATE)
        {
            return Json(new RPT_Stockcard().Stockcard(val, UI_STATE));
        }


    }
}
