using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Helpers
{
    public class SelectModel
    {
        public string select { get; set; }
        public string where { get; set; }
        public Dictionary<string, object> _parameter;

        public Dictionary<string, object> parameter
        {
            get
            {
                if (_parameter == null)
                    _parameter = new Dictionary<string, object>();
                return _parameter;
            }
        }

        public string query
        {
            get
            {
                if (!string.IsNullOrEmpty(where))
                    return select + " WHERE " + where;
                else
                    return select;
            }
        }
    }
}