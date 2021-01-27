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
    public class WorkingdateController : ApiController
    {

        #region "Get"

        [HttpGet]
        [Route("api/Workingdate/Workingdate_Load")]
        public ResponseMessage Workingdate_Load(string Val)
        {
            return new WorkingdateCL().Workingdate_load(Val);
        }

        
        [HttpGet]
        [Route("api/Workingdate/Getdate")]
        public Date_now_Models Getdate()
        {
            return new WorkingdateCL().Getdate();
        }


        #endregion
        #region "POST"


        #endregion
    }
}
