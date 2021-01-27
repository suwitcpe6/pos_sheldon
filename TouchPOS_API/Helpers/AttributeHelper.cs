using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
namespace BaseRepository.Helpers
{
    public class AttributeHelperr : Attribute
    {
    }
    public class Table : Attribute
    {
        private string _table;

        public Table(string as_table)
        {
            this._table = as_table;
        }

        public virtual string Name
        {
            get { return this._table; }
        }
    }

    public class Column : Attribute
    {
        public Column(bool _identity = false, bool _save_one_time = false, bool _foreign_key = false)
        {
            this.Identity = _identity;
            this.SaveOneTime = _save_one_time;
            this.RefferentKey = _foreign_key;
        }

        public Column(string _table, bool _refferent_key = false)
        {
            this.Table = _table;
            this.RefferentKey = _refferent_key;
        }

        public virtual bool Identity { get; set; }
        public virtual bool SaveOneTime { get; set; }
        public virtual string Table { get; set; }
        public virtual bool RefferentKey { get; set; }

    }


    public class Ignore : Attribute
    {

    }


    public class Date : Attribute
    {

        public Date(string _format)
        {
            this.Format = _format;
        }

        public Date(string _format, string _colum)
        {
            this.Format = _format;
            this.Column = _colum;
        }


        public Date(bool _now = false)
        {
            this.Now = _now;
        }

        public virtual string Column { get; set; }
        public virtual string Format { get; set; }
        public virtual bool Now { get; set; }

    }
}