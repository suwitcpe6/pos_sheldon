using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Reflection;
using System.Data;
using BaseRepository.Helpers;
using TouchPOS_API.Class;
namespace TouchPOS_API.Helpers
{
    public class Mybase
    {
        public string GetTable(dynamic model)
        {
            var type = model.GetType();
            return type.CustomAttributes[0].ConstructorArguments[0].Value;
        }
        public string[] Split_col(dynamic ColUpdate)
        {
            ColUpdate = ColUpdate.Replace("[", "").Replace("]", "");
            ColUpdate = ColUpdate.ToUpper().Replace(" ", "");
            string[] ColUpdate2 = ColUpdate.Split(',');
            return ColUpdate2;
        }
        public string Date_Format(DateTime dateval)
        {
            return new Center().Condate(dateval, "ymd2");
        }
        public string Update(dynamic model, string ColUpdate)
        {
          
                string[] ColUpdate2 = Split_col(ColUpdate);
                string table = GetTable(model);

                PropertyInfo[] props = model.GetType().GetProperties();

                //var cname = GETNAME(new { Input_data.CORPName_TH });

                string query = "";
                string cname = "";
                string value = "";
                string Update_data = "";
            try
            {
                foreach (PropertyInfo prop in props)
                {
                    string value_date = "";
                    string[] a = ColUpdate2.Where(x => x == prop.Name.ToUpper()).ToArray();
                    if (a.Length <= 0)
                    {
                        continue;
                    }

                    object[] attrs = prop.GetCustomAttributes(true);
                    var date = attrs.Where(x => x.GetType() == typeof(Date)).FirstOrDefault();

                    if (date != null)
                    {
                        Date date_config = date as Date;
                        if (date_config.Now)
                        {
                            value_date = "GETDATE()";
                        }
                        if (date_config.Format != "" && date_config.Format != null)
                        {
                            string dcdate = prop.GetValue(model, null).ToString();
                            DateTime dcdate2 = DateTime.Parse(dcdate);
                            dcdate = Date_Format(dcdate2);
                            value_date = "'" + dcdate + "'";
                        }
                    }
                    cname = prop.Name.ToString();

                    if (value_date == "")
                    {
                        value = "'" + prop.GetValue(model, null).ToString() + "'";
                    }
                    else
                    {
                        value = value_date;
                    }

                    if (Update_data == "")
                    {
                        Update_data = cname + " = " + value;
                    }
                    else
                    {
                        Update_data += "," + cname + " = " + value;
                    }
                }
                query += " Update " + table + " set " + Update_data;
            }
            catch (Exception e)
            {
                if (e.Message.ToString().Contains("runtime binding"))
                {
                    throw new Exception("Data Cloumn is null");
                }
                else
                {
                    throw e;
                }

            }
            return query;
        }
        public string Insert(dynamic model, string ColUpdate)
        {
            string[] ColUpdate2 = Split_col(ColUpdate);
            string table = GetTable(model);
            PropertyInfo[] props = model.GetType().GetProperties();
            //var cname = GETNAME(new { Input_data.CORPName_TH });
            string query = "";
            string cname = "";
            string value = "";
            try
            {
                foreach (PropertyInfo prop in props)
                {
                    string value_date = "";
                    string[] a = ColUpdate2.Where(x => x == prop.Name.ToUpper()).ToArray();
                    if (a.Length <= 0)
                    {
                        continue;
                    }
                    object[] attrs = prop.GetCustomAttributes(true);
                    var date = attrs.Where(x => x.GetType() == typeof(Date)).FirstOrDefault();
                    if (date != null)
                    {
                        Date date_config = date as Date;
                        if (date_config.Now)
                        {
                            value_date = "GETDATE()";
                        }
                        if (date_config.Format != "" && date_config.Format != null)
                        {
                            string dcdate = prop.GetValue(model, null).ToString();
                            DateTime dcdate2 = DateTime.Parse(dcdate);
                            dcdate = Date_Format(dcdate2);
                            value_date = "'" + dcdate + "'";
                        }
                    }
                    if (cname == "")
                    {
                        cname = prop.Name.ToString();
                        if (value_date == "")
                        {
                            value = "'" + prop.GetValue(model, null).ToString().Replace("'", "''") + "'";
                        }
                        else
                        {
                            value = value_date;
                        }
                    }
                    else
                    {
                        cname += "," + prop.Name.ToString();
                        if (value_date == "")
                        {
                            value += ",'" + prop.GetValue(model, null).ToString().Replace("'", "''") + "'";
                        }
                        else
                        {
                            value += "," + value_date;
                        }
                    }
                }
                query += " Insert into " + table + " ( " + cname + ") values ( " + value + " )";
            }
            catch (Exception e)
            {
                if (e.Message.ToString().Contains("runtime binding"))
                {
                    throw new Exception("Data Cloumn is null");
                }
                else
                {
                    throw e;
                }

            }
            return query;
        }
        public List<string> Insert_Multivalue(dynamic model, string ColUpdate)
        {

            int bath = 100;
            int bath_INC = 0;
            string[] ColUpdate2 = Split_col(ColUpdate);
            string table = GetTable(model[0]);
            string query = "";
            List<string> Listquery = new List<string>();
            string cname = "";
            string value = "";
            string value_multi = "";
            try
            {
                for (int i = 0; i < model.Count; i++)
                {
                    PropertyInfo[] props = model[i].GetType().GetProperties();
                    //var cname = GETNAME(new { Input_data.CORPName_TH });
                    foreach (PropertyInfo prop in props)
                    {



                        string value_date = "";
                        string[] a = ColUpdate2.Where(x => x == prop.Name.ToUpper()).ToArray();
                        if (a.Length <= 0)
                        {
                            continue;
                        }
                        object[] attrs = prop.GetCustomAttributes(true);
                        var date = attrs.Where(x => x.GetType() == typeof(Date)).FirstOrDefault();
                        if (date != null)
                        {
                            Date date_config = date as Date;
                            if (date_config.Now)
                            {
                                value_date = "GETDATE()";
                            }
                            if (date_config.Format != "" && date_config.Format != null)
                            {
                                string dcdate = prop.GetValue(model[i], null).ToString();
                                DateTime dcdate2 = DateTime.Parse(dcdate);
                                dcdate = Date_Format(dcdate2);
                                value_date = "'" + dcdate + "'";
                            }
                        }
                        if (value == "")
                        {
                            if (i == 0) { cname = prop.Name.ToString(); }

                            if (value_date == "")
                            {
                                value += "'" + prop.GetValue(model[i], null).ToString().Replace("'", "''") + "'";
                            }
                            else
                            {
                                value += value_date;
                            }
                        }
                        else
                        {
                            if (i == 0) { cname += "," + prop.Name.ToString(); }
                            if (value_date == "")
                            {
                                value += ",'" + prop.GetValue(model[i], null).ToString().Replace("'", "''") + "'";
                            }
                            else
                            {
                                value += "," + value_date;
                            }
                        }
                    }

                    if (value_multi == "")
                    {
                        value_multi = "\n (" + value + ")";
                    }
                    else
                    {
                        value_multi += "\n ,(" + value + ")";
                    }
                    value = "";
                    if (bath_INC >= bath - 1)
                    {
                        query = " Insert into " + table + " ( " + cname + ") values " + value_multi + " ";
                        Listquery.Add(query);
                        query = "";
                        value_multi = "";
                        bath_INC = 0;
                    }
                    bath_INC++;
                }
                //เศษ
                if (value_multi != "")
                {
                    query = " Insert into " + table + " ( " + cname + ") values " + value_multi + " ";
                    Listquery.Add(query);
                    query = "";
                }
            }
            catch (Exception e)
            {
                if (e.Message.ToString().Contains("runtime binding"))
                {
                    throw new Exception("Data Cloumn is null");
                }
                else
                {
                    throw e;
                }

            }
            return Listquery;
        }
        public List<string> Bulk_Copy(dynamic model, string ColUpdate)
        {
            int bath = 100;
            int bath_INC = 0;
            string[] ColUpdate2 = Split_col(ColUpdate);
            string table = GetTable(model[0]);
            string query = "";
            List<string> Listquery = new List<string>();
            string cname = "";
            string value = "";
            string value_multi = "";
            try
            {
                for (int i = 0; i < model.Count; i++)
                {
                    PropertyInfo[] props = model[i].GetType().GetProperties();
                    //var cname = GETNAME(new { Input_data.CORPName_TH });
                    foreach (PropertyInfo prop in props)
                    {
                        string value_date = "";
                        string[] a = ColUpdate2.Where(x => x == prop.Name.ToUpper()).ToArray();
                        if (a.Length <= 0)
                        {
                            continue;
                        }
                        object[] attrs = prop.GetCustomAttributes(true);
                        var date = attrs.Where(x => x.GetType() == typeof(Date)).FirstOrDefault();
                        if (date != null)
                        {
                            Date date_config = date as Date;
                            if (date_config.Now)
                            {
                                value_date = "GETDATE()";
                            }
                            if (date_config.Format != "" && date_config.Format != null)
                            {
                                string dcdate = prop.GetValue(model[i], null).ToString();
                                DateTime dcdate2 = DateTime.Parse(dcdate);
                                dcdate = Date_Format(dcdate2);
                                value_date = "'" + dcdate + "'";
                            }
                        }
                        if (value == "")
                        {
                            if (i == 0) { cname = prop.Name.ToString(); }

                            if (value_date == "")
                            {
                                value += "'" + prop.GetValue(model[i], null).ToString().Replace("'", "''") + "'";
                            }
                            else
                            {
                                value += value_date;
                            }
                        }
                        else
                        {
                            if (i == 0) { cname += "," + prop.Name.ToString(); }
                            if (value_date == "")
                            {
                                value += ",'" + prop.GetValue(model[i], null).ToString().Replace("'", "''") + "'";
                            }
                            else
                            {
                                value += "," + value_date;
                            }
                        }
                    }

                    if (value_multi == "")
                    {
                        value_multi = "\n (" + value + ")";
                    }
                    else
                    {
                        value_multi += "\n ,(" + value + ")";
                    }
                    value = "";
                    if (bath_INC >= bath - 1)
                    {
                        query = " Insert into " + table + " ( " + cname + ") values " + value_multi + " ";
                        Listquery.Add(query);
                        query = "";
                        value_multi = "";
                        bath_INC = 0;
                    }
                    bath_INC++;
                }
            }
            catch (Exception e)
            {
                if (e.Message.ToString().Contains("runtime binding"))
                {
                    throw new Exception("Data Cloumn is null");
                }
                else
                {
                    throw e;
                }

            }

            return Listquery;
        }


        public DataTable ListToDataTable(dynamic items)
        {
            DataTable dataTable = new DataTable(items.GetType().Name);
            PropertyInfo[] props = items[0].GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in props)
            {
                dataTable.Columns.Add(prop.Name, prop.PropertyType);
            }

            for (int a = 0; a < items.Count; a++)
            {
                DataRow drow;
                drow = dataTable.NewRow();
                for (int i = 0; i < props.Length - 1; i++)
                {
                    if (DBNull.Value.Equals(props[i].GetValue(items[a], null)))
                    {
                        drow[i] = "";
                    }
                    else
                    {
                        drow[i] = props[i].GetValue(items[a], null);
                    }
                }
                dataTable.Rows.Add(drow);
            }
            return dataTable;

        }





        public string Delete(dynamic model)
        {
            string table = GetTable(model);
            string query;
            query = " Delete  " + table;
            return query;
        }

    }
}