using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System;
using System.Threading;

namespace TouchPOS_API
{
    public class DataContext
    {
        int ConnectionTimeout = 1000 * 30;
        //string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public string strcon = "";//(System.Configuration.ConfigurationManager.ConnectionStrings["ConString1"].ConnectionString);
        public conselect isopenconn ;
        public string DB_backup = "";
        public string DB_backup2 = "";
        public string DB_LOcal_name = "";
        public  string DB_backup_name = "";
        public string DB_daily = "";

        
        //metadata=res://*/Models.Model1.csdl|res://*/Models.Model1.ssdl|res://*/Models.Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;

        public DataContext(conselect val = conselect.con1 ,int Timeout = 1000 * 30)

        {

            string str = (System.Configuration.ConfigurationManager.ConnectionStrings["ConString1"].ConnectionString);
            int a = str.IndexOf("data source");
            int a2 = str.IndexOf(";MultipleActiveResultSets");
            int a3 = a2 - a;
            strcon = str.Substring(a, a3);

            //ดึงชื่อเบสแทน backup
            int b = str.IndexOf("catalog=")+ ("catalog=").Length ;
            int b2 = str.IndexOf(";persist");
            int b3 = b2 - b;
            string getdb = str.Substring(b, b3);
            //ดึงชื่อเบสแทน backup
            DB_backup = "[" + getdb + "].[dbo].";
            DB_backup2 = "[" + getdb + "].";
            DB_backup_name = getdb;
            DB_daily = "[" + getdb + "]..";


            //DB_backup = "[" + System.Configuration.ConfigurationSettings.AppSettings.Get("DB_backup") + "].[dbo].";
            //DB_backup2 = "[" + System.Configuration.ConfigurationSettings.AppSettings.Get("DB_backup") + "].";
            //DB_backup_name = System.Configuration.ConfigurationSettings.AppSettings.Get("DB_backup");
            DB_daily ="[" + System.Configuration.ConfigurationSettings.AppSettings.Get("DB_daily")+"]..";

            string[] aa = strcon.Split(';');
            DB_LOcal_name = aa[1].Replace("initial catalog=", "");
            aa[1] = "initial catalog=" + DB_backup_name;
            isopenconn = val;
            if (val == conselect.con2)
            {
               
                strcon = aa[0] + ";" + aa[1] + ";" + aa[02] + ";" + aa[3] + ";" + aa[4] + ";" + aa[5];
            }
          
            ConnectionTimeout = Timeout;
        }
        public enum  conselect
        {
            con1 = 0,
            con2=1
        }
    public void RunStoredProcedure(DataCommand command)
        {
            var connection = new SqlConnection(strcon);
            command.DynamicParameters = new DynamicParameters();

            foreach (var item in command.DataParameters)
            {
                command.DynamicParameters.Add(item.Name, item.Value, item.Type, item.Direction);
            }

            int ret = connection.Execute(command.Query, command.DynamicParameters, commandType: CommandType.StoredProcedure);

            foreach (var item in command.DataParameters.Where(x => x.Direction == ParameterDirection.Output))
            {
                try
                {
                    item.Value = command.DynamicParameters.Get<object>(item.Name);
                }
                catch { }
            }
        }

        public List<T> RunQuery<T>(string query)
        {
            //int a = strcon.IndexOf("data source");
            //int a2 = strcon.IndexOf(";MultipleActiveResultSets");
            //int a3 = a2 - a;
            //string b = strcon.Substring(a, a3);


            SqlTransaction sqltr_read;
            var connection = new SqlConnection(strcon);

            connection.Open();
            sqltr_read = connection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            var result = connection.Query<T>(query, null, sqltr_read).ToList();
            connection.Close();

            return result;
        }

        public List<T> RunQuery<T>(string query, object param)
        {
            var connection = new SqlConnection(strcon);
            SqlTransaction sqltr_read;
            try
            {
                connection.Open();
                sqltr_read = connection.BeginTransaction(System.Data.IsolationLevel.ReadUncommitted);
                var result = connection.Query<T>(query, param, sqltr_read).ToList();
                sqltr_read.Commit();

                return result;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();

            }
        }
        public DataTable ReadData_Table(String query)
        {
            var conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(query, conn);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            else
            {
                conn.ConnectionString = strcon;
                conn.Open();
            }
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            ds.Clear();

            da = new SqlDataAdapter(query, conn);
            da.SelectCommand.CommandTimeout = ConnectionTimeout;
            da.Fill(ds, "S");

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            //if (ds.Tables.Count == 1)
            //{
            return ds.Tables[0];
            //}
            //else
            //{
            //    return ds;
            //}
            //return null;
        }
        public DataSet ReadDataSet(String query)
        {
            var conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(query, conn);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            else
            {
                conn.ConnectionString = strcon;
                conn.Open();
            }
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            ds.Clear();

            da = new SqlDataAdapter(query, conn);
            da.SelectCommand.CommandTimeout = ConnectionTimeout;
            da.Fill(ds, "S");

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            return ds;
   
        }

        #region "Excute"
        public SqlConnection connection;
        SqlTransaction sqltr;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Open( System.Data.IsolationLevel trn = System.Data.IsolationLevel.ReadCommitted)

        {
            connection = new SqlConnection(strcon);

            connection.Open();
            sqltr = connection.BeginTransaction(trn);
            return true;
        }
        public bool Commit()

        {
            sqltr.Commit();
            connection.Close();
            return true;
        }
        public bool Rollback()

        {
            sqltr.Rollback();
            connection.Close();
            return true;
        }
        public bool close()

        {
            if (connection != null)
            {
                connection.Close();

            }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="sqltr"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public bool Excute(string query)
        {
            var result = connection.Query(query, null, sqltr);
            return true;
        }
        public object Excute_Scalar(string query)
        {
            var result = connection.ExecuteScalar(query, null, sqltr);
            return result;


        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection33"></param>
        /// <param name="Sqltr222"></param>
        /// <param name="query"></param>
        /// <returns></returns>

        public bool Excute2(string query)
        {
            var connection2 = new SqlConnection(strcon);
            try
            {

                //var result = connection.Query<T>(query).ToList();

                //var result = connection.Execute(query, Sqltr);

                //connection.Close();
                SqlTransaction sqltr;
                connection2.Open();
                sqltr = connection2.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);


                int ans = 0;
                SqlCommand comm;
                comm = new SqlCommand();
                comm.Connection = connection2;
                comm.CommandType = CommandType.Text;
                comm.Transaction = sqltr;
                comm.CommandText = query;
                comm.CommandTimeout = ConnectionTimeout;
                ans = comm.ExecuteNonQuery();

                sqltr.Commit();
                connection2.Close();
                return true;
            }
            catch (Exception ex)
            {
                try
                {
                    sqltr.Rollback();
                }
                catch (Exception ex2)
                {
                    connection2.Close();
                    //throw ex2;
                }
                throw ex;
                return false;
            }
        }
    }





    public class DataCommand
    {
        public string Query { get; set; }
        public DynamicParameters DynamicParameters { get; set; }
        public List<DataParameter> DataParameters { get; set; }
    }

    public class DataParameter
    {
        public DataParameter() { }

        public DataParameter(string name, ParameterDirection direction, DbType type, object value)
        {
            Name = name;
            Value = value;
            Type = type;
            Direction = direction;
        }

        public string Name { get; set; }
        public object Value { get; set; }
        public DbType Type { get; set; }
        public ParameterDirection Direction { get; set; }

    }
}