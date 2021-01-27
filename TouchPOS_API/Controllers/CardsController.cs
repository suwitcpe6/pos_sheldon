using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TouchPOS_API.Class;
using TouchPOS_API.Service;
using TouchPOS_API.Models;
namespace TouchPOS_API.Controllers
{
    public class CardsController : ApiController
    {

        [HttpPost]
        [Route("api/CardsCL/card_pro")]
        //public ResponseMessage CHKcard_Multi(string BARCODE, int Nettotel)
        public ResponseMessage Insert_All([FromBody]CHKcard_MultiModels data)
        {
            return new CardsCL().card_pro(data);
        }
    }
}
