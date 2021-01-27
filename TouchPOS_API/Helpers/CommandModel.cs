using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Helpers
{
    public class CommandModel
    {
        public string table { get; set; }
        public string command { get; set; }
        public object parameter { get; set; }
        public bool is_model { get; set; }
        public bool get_last_id { get; set; }
        public string refferent_key { get; set; }
        public string refferent_table { get; set; }

        public bool is_refferent_key
        {
            get
            {
                if (!string.IsNullOrEmpty(refferent_key))
                {
                    return true;
                }

                return false;
            }
        }

        public Dictionary<string, object> parameter_list { get; set; }
    }

}