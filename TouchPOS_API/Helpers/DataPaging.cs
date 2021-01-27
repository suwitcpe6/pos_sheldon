using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchPOS_API.Helpers
{
    public class DataPaging
    {
        public string SORT_NAME { get; set; }
        public string SORT_TYPE { get; set; }
        public int DATA_TOTAL { get; set; }
        public int PAGING_ALL { get; set; }
        public int PAGING_CURRENT { get; set; }
        public int PAGING_START { get; set; }
        public int PAGING_LIMIT { get; set; }
        public string PAGING_SEARCH { get; set; }

        public object DATA { get; set; }

    }
}