using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using TouchPOS_API.Class;
using TouchPOS_API.Service;
namespace TouchPOS_API.Controllers
{
    public class SHOPSController : ApiController
    {

        #region "Get"

        [HttpGet]
        [Route("api/Shop/Shop_Lode")]
        public ResponseMessage LodeShop(string Val )
        {
            return new ShopsCL().shop_Load(Val);
        }
        [HttpGet]
        [Route("api/Shop/Shop_Lode_IP")]
        public ResponseMessage Shop_Lode_IP(string IP)
        {
            return new ShopsCL().shop_Load_IP(IP);
        }
        [HttpGet]
        [Route("api/Shop/Shop_Buttons")]
        public ResponseMessage Shop_Buttons(string Val)
        {
            return new ShopsCL().Shop_Buttons(Val);
        }

        #endregion
        #region "POST"


        #endregion



    }
}
