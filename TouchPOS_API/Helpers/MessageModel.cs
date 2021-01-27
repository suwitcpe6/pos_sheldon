using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Helpers
{
    public class MessageModel
    {
        public object Data { get; set; }
        public string ErrorMessage { get; set; }

        public bool Ok
        {
            get
            {
                return (string.IsNullOrEmpty(this.ErrorMessage)) ? true : false;
            }
        }
    }
}