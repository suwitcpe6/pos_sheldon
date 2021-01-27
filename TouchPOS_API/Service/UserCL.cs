using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using DocumentController = TouchPOS_API.Controllers.UserController;
using TouchPOS_API.Class;

namespace TouchPOS_API.Service
{
    public class UserCL
    {
        public ResponseMessage Login(string User, string pass)
        {
            ResponseMessage ret = new ResponseMessage();
            try
            {


                //return new POS_API.DataContext().RunQuery<> ;




            }
            catch (Exception e)
            {
                ret.Respon.SystemErrorMessage = e.Message.ToString();
            }
            return ret;

        }
    }
}