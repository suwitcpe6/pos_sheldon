using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TouchPOS_API.Service;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
namespace TouchPOS_API.Controllers
{
    public class Tender_LogController : ApiController
    {

        [HttpPost]
        [Route("api/Tender_Log/SAVE_Tender_Log")]
        //public ResponseMessage CHKcard_Multi(string BARCODE, int Nettotel)
        public ResponseMessage Insert_All([FromBody]Tender_LogModel data)
        {
            return new Tender_LogCL().SAVE_Tender_Log(data);
        }
    }
}
