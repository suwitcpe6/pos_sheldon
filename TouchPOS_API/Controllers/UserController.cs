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
    public class UserController : ApiController
    {
        #region "Get"
        [HttpGet]
        [Route("api/User/Test_connect")]
        public ResponseMessage Test_connect(string val)
        {
            ResponseMessage value;
            value = new ResponseMessage();


            //value.Data = "Connect successful";
            //value.Respon.Result = true;
            //value.Respon.ErrorMessage = "";

            try
            {
                string sql = "";
                sql = " SELECT getdate() as date_now ";
                var date_now = new DataContext().RunQuery<Date_now_Models>(sql);
                if (date_now != null)
                {
                    value.Data = "Connect successful";
                    value.Respon.Result = true;
                    value.Respon.ErrorMessage = "";
                }
                return value;
            }
            catch (Exception ex)
            {
                value.Data = "Connect Database False !!!";
                value.Respon.Result = false;
                value.Respon.ErrorMessage = "Connect Database False !!!";
                return value;
            }

        }
        [HttpGet]
        [Route("api/User/Login")]
        public ResponseMessage Login(string User, string pass)
        {
            return new UserCL().Login(User, pass);
        }
        #endregion
        #region "Post"
        #endregion
    }
}
