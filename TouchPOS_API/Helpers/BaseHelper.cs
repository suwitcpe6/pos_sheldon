using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Web;
using TouchPOS_API.Helpers;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
using BaseRepository.Helpers;
namespace BaseRepository.Helpers
{
    public class BaseHelper
    {
        public string GetTable(dynamic model)
        {
            var type = model.GetType();
            return type.CustomAttributes[0].ConstructorArguments[0].Value;
        }

        public CRUDModel GetColumn(dynamic model)
        {
            var column_select = string.Empty;
            var count = 0;
            PropertyInfo[] props = model.GetType().GetProperties();
            foreach (PropertyInfo prop in props)
            {
                object[] attrs = prop.GetCustomAttributes(true);

                var select_column = prop.Name;

                var date = attrs.Where(x => x.GetType() == typeof(Date)).FirstOrDefault();

                if (date != null)
                {
                    Date date_config = date as Date;
                    if (!string.IsNullOrEmpty(date_config.Format))
                    {
                        select_column = "FORMAT(" + date_config.Column + ",'" + date_config.Format + "') AS " + prop.Name;

                        if (count > 0) column_select += "," + select_column;
                        else column_select += select_column;

                        count++;
                    }
                }
                else
                {
                    var col = attrs.Where(x => x.GetType() == typeof(Column)).FirstOrDefault();

                    if (col != null)
                    {


                        Column col_config = col as Column;
                        if (count > 0) column_select += "," + select_column;
                        else column_select += select_column;

                        count++;
                    }
                }
            }
            return new CRUDModel
            {
                select = column_select.ToString()
            };
        }


        public CRUDModel GetInsertColumn(dynamic model)
        {
            StringBuilder column_insert = new StringBuilder();
            StringBuilder value_insert = new StringBuilder();
            var data = new Dictionary<string, object>();
            var foreign_key = "";
            var foreign_table = "";

            var count = 0;
            PropertyInfo[] props = model.GetType().GetProperties();
            foreach (PropertyInfo prop in props)
            {
                object[] attrs = prop.GetCustomAttributes(true);

                var ignore = attrs.Where(x => x.GetType() == typeof(Ignore)).FirstOrDefault();
                if (ignore != null)
                    continue;

                var col = attrs.Where(x => x.GetType() == typeof(Column)).FirstOrDefault();

                if (col != null)
                {
                    var value_parameter = "@" + prop.Name;

                    var date = attrs.Where(x => x.GetType() == typeof(Date)).FirstOrDefault();

                    if (date != null)
                    {
                        Date date_config = date as Date;
                        if (date_config.Now)
                        {
                            value_parameter = "GETDATE()";
                        }
                    }

                    Column col_config = col as Column;
                    if (!col_config.Identity)
                    {
                        if (count > 0)
                        {
                            column_insert.Append("," + prop.Name);
                            value_insert.Append("," + value_parameter);
                        }
                        else
                        {
                            column_insert.Append(prop.Name);
                            value_insert.Append(value_parameter);
                        }

                        if (col_config.RefferentKey)
                        {
                            foreign_key = prop.Name;
                            foreign_table = col_config.Table;
                        }

                        if (date == null)
                            data[prop.Name] = prop.GetValue(model, null);

                        count++;
                    }
                }
            }
            return new CRUDModel
            {
                insert = column_insert.ToString(),
                insert_value = value_insert.ToString(),
                foreign_key = foreign_key,
                foreign_table = foreign_table,
                data = data
            };
        }

        public CRUDModel GetUpdateColumn(dynamic model)
        {
            StringBuilder column_update = new StringBuilder();

            var where = string.Empty;
            var data = new Dictionary<string, object>();
            var count = 0;
            PropertyInfo[] props = model.GetType().GetProperties();
            foreach (PropertyInfo prop in props)
            {
                object[] attrs = prop.GetCustomAttributes(true);

                var col = attrs.Where(x => x.GetType() == typeof(Column)).FirstOrDefault();

                if (col != null)
                {

                    var value_parameter = "@" + prop.Name;

                    Column col_config = col as Column;

                    if (col_config.SaveOneTime)
                    {
                        continue;
                    }



                    var date = attrs.Where(x => x.GetType() == typeof(Date)).FirstOrDefault();

                    if (date != null)
                    {
                        Date date_config = date as Date;
                        if (date_config.Now)
                        {
                            value_parameter = "GETDATE()";
                        }
                    }

                    if (!col_config.Identity)
                    {
                        if (count > 0)
                            column_update.Append(string.Format(",{0}={1}", prop.Name, value_parameter));
                        else
                            column_update.Append(string.Format("{0}={1}", prop.Name, value_parameter));

                        if (date == null)
                            data[prop.Name] = prop.GetValue(model, null);

                        count++;
                    }
                    else if (col_config.Identity)
                    {
                        data[prop.Name] = prop.GetValue(model, null);
                        where = string.Format("{0}={1}", prop.Name, value_parameter);
                    }
                }
            }
            return new CRUDModel
            {
                update = column_update.ToString(),
                where = where,
                data = data
            };
        }


        public CRUDModel GetDeleteColumn(dynamic model)
        {
            var data = new Dictionary<string, object>();
            var where = string.Empty;
            PropertyInfo[] props = model.GetType().GetProperties();
            foreach (PropertyInfo prop in props)
            {
                object[] attrs = prop.GetCustomAttributes(true);

                var col = attrs.Where(x => x.GetType() == typeof(Column)).FirstOrDefault();

                if (col != null)
                {
                    Column col_config = col as Column;

                    if (col_config.Identity)
                    {
                        where = string.Format("{0}=@{1}", prop.Name, prop.Name);
                        data.Add(prop.Name, prop.GetValue(model, null));
                        break;
                    }
                }
            }

            return new CRUDModel
            {
                where = where,
                data = data
            };
        }


        public string SelectHelper(dynamic model)
        {
            StringBuilder select = new StringBuilder();
            var data = GetColumn(model);

            select.Append(string.Format("SELECT {0} FROM [{1}]", data.select, GetTable(model)));

            return select.ToString();
        }

        public CommandModel InsertHelper(dynamic model)
        {
            StringBuilder insert = new StringBuilder();
            var data = 
                
                
            GetInsertColumn(model);
            var table = GetTable(model);
            insert.Append(string.Format("INSERT INTO [{0}] ({1}) VALUES ({2})", table, data.insert, data.insert_value));

            return new CommandModel
            {
                table = table,
                refferent_key = data.foreign_key,
                refferent_table = data.foreign_table,
                command = insert.ToString(),
                parameter_list = data.data
            };
        }

        public CommandModel UpdateHelper(dynamic model)
        {
            StringBuilder update = new StringBuilder();
            var data = GetUpdateColumn(model);

            update.Append(string.Format("UPDATE [{0}] SET {1} WHERE {2}", GetTable(model), data.update, data.where));

            return new CommandModel
            {
                command = update.ToString(),
                parameter_list = data.data
            };
        }


        public CommandModel DeleteHelper(dynamic model)
        {
            StringBuilder delete = new StringBuilder();
            var data = GetUpdateColumn(model);

            delete.Append(string.Format("DELETE FROM [{0}] WHERE {1}", GetTable(model), data.where));

            return new CommandModel
            {
                command = delete.ToString(),
                parameter_list = data.data
            };
        }
    }
}