using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using TouchPOS_API.Helpers;
using System.Configuration;
using BaseRepository.Helpers;
namespace TouchPOS_API.Helpers
{
    public class Repository
    {
        public string _connection_string { get; set; }


        public Repository()
        {

            //_connection_string = ConfigurationManager.AppSettings["ConnectionString"]; //"data source=ampd.co.th;Initial Catalog=upz_pawn;uid=keng;password=AMpd2016;";
            //_connection_string = "data source=203.151.187.175;Initial Catalog=dbqr_test;uid=qrpay;password=qrpay;";
            string str = (System.Configuration.ConfigurationManager.ConnectionStrings["ConString1"].ConnectionString);           
            _connection_string = str;
        }

        public List<CommandModel> _query;
        public List<RelationModel> _relations;
        public BaseHelper _helper;
        private SelectModel _select;
        public Dictionary<string, object> _param;

        public List<CommandModel> query
        {
            get
            {
                if (_query == null)
                    _query = new List<CommandModel>();
                return _query;
            }
            set
            {
                this._query = value;
            }
        }

        public List<RelationModel> relations
        {
            get
            {
                if (_relations == null)
                    _relations = new List<RelationModel>();
                return _relations;
            }
            set
            {
                this._relations = value;
            }
        }

        public BaseHelper helper
        {
            get
            {
                if (_helper == null)
                    _helper = new BaseHelper();
                return _helper;
            }
        }


        public SelectModel select
        {
            get
            {
                if (_select == null)
                    _select = new SelectModel();
                return _select;
            }
        }

        public Dictionary<string, object> param
        {
            get
            {
                if (_param == null)
                    _param = new Dictionary<string, object>();
                return _param;
            }
            set
            {
                this._param = value;
            }
        }

        protected static void SetIdentity<T>(IDbConnection connection, Action<T> setId)
        {
            dynamic identity = connection.Query("SELECT @@IDENTITY AS Id").Single();
            T newId = (T)identity.Id;
            setId(newId);
        }

        protected static void SetIdentity<T>(IDbConnection connection, Action<T> setId, IDbTransaction transaction)
        {
            dynamic identity = connection.Query("SELECT @@IDENTITY AS Id", null, transaction).Single();
            T newId = (T)identity.Id;
            setId(newId);
        }

        protected static IDbConnection OpenConnection(string connection_string)
        {
            IDbConnection connection = new SqlConnection(connection_string);
            connection.Open();
            return connection;
        }

        public List<T> GetList<T>(CommandModel _comd)
        {
            using (IDbConnection connection = OpenConnection(_connection_string))
            {
                try
                {
                    return connection.Query<T>(_comd.command, _comd.parameter).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Query(CommandModel command)
        {
            query.Add(command);
        }

        public bool Commit()
        {
            using (IDbConnection connection = OpenConnection(_connection_string))
            {
                IDbTransaction transaction = connection.BeginTransaction();

                try
                {
                    if (this._query.Any() && this.query.Count > 0)
                    {
                        var insert_last_id = 0;

                        foreach (var item in this._query)
                        {
                            if (item.is_model)
                            {

                                if (item.is_refferent_key && relations.Any())
                                {
                                    var data_relation = relations.Where(x => x.table == item.refferent_table).FirstOrDefault();
                                    if (data_relation != null)
                                        item.parameter_list[item.refferent_key] = data_relation.insert_last_id;
                                }


                                connection.Execute(item.command, item.parameter_list, transaction);

                                if (item.get_last_id)
                                {
                                    SetIdentity<int>(connection, id => insert_last_id = id, transaction);
                                    relations.Add(new RelationModel { table = item.table, insert_last_id = insert_last_id });
                                    insert_last_id = 0;
                                }
                            }
                            else
                                connection.Execute(item.command, item.parameter, transaction);
                        }

                        relations = null;
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }

                return true;
            }
        }



        // Helper



        public Repository Select<T>() where T : new()
        {
            select.select = helper.SelectHelper(new T()).ToString();
            return this;
        }

        public Repository Where(string where)
        {
            _select.where = " " + where;
            return this;
        }

        public void AddParameter(string key, object value)
        {
            param.Add(key, value);
        }


        public int InsertCommit(dynamic model)
        {
            var insert_id = 0;

            CommandModel data = helper.InsertHelper(model);
            using (IDbConnection connection = OpenConnection(_connection_string))
            {
                IDbTransaction transaction = connection.BeginTransaction();

                try
                {
                    connection.Execute(data.command, data.parameter_list, transaction);
                    SetIdentity<int>(connection, id => insert_id = id, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }

            }
            return insert_id;
        }

        public void Insert(dynamic model, bool get_last_id = false)
        {
            CommandModel data = helper.InsertHelper(model);
            data.is_model = true;
            data.get_last_id = get_last_id;
            query.Add(data);
        }


        public int UpdateCommit(dynamic model)
        {
            var affect_row = 0;

            CommandModel data = helper.UpdateHelper(model);
            using (IDbConnection connection = OpenConnection(_connection_string))
            {
                IDbTransaction transaction = connection.BeginTransaction();

                try
                {
                    affect_row = connection.Execute(data.command, data.parameter_list, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
            return affect_row;
        }

        public void Update(dynamic model)
        {
            CommandModel data = helper.UpdateHelper(model);
            data.is_model = true;
            query.Add(data);
        }

        public int DeleteCommit(dynamic model)
        {
            var affect_row = 0;

            CommandModel data = helper.DeleteHelper(model);
            using (IDbConnection connection = OpenConnection(_connection_string))
            {
                IDbTransaction transaction = connection.BeginTransaction();
                connection.Execute(data.command, data.parameter_list, transaction);
                transaction.Commit();
            }
            return affect_row;
        }


        public void Delete(dynamic model)
        {
            CommandModel data = helper.DeleteHelper(model);
            data.is_model = true;
            query.Add(data);
        }

        public List<T> List<T>()
        {
            using (IDbConnection connection = OpenConnection(_connection_string))
            {
                try
                {
                    var list = connection.Query<T>(_select.query, this.param).ToList();
                    this.param = null;
                    return list;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public T FirstOrDefault<T>()
        {
            using (IDbConnection connection = OpenConnection(_connection_string))
            {
                try
                {
                    var data = connection.Query<T>(_select.query, this.param).FirstOrDefault();
                    this.param = null;
                    return data;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataPaging DataPaging<T>(DataPaging paging)
        {
            using (IDbConnection connection = OpenConnection(_connection_string))
            {
                try
                {
                    param.Add("start", (paging.PAGING_CURRENT - 1) * paging.PAGING_LIMIT);
                    param.Add("limit", paging.PAGING_LIMIT);

                    paging.SORT_NAME = (!string.IsNullOrEmpty(paging.SORT_NAME)) ? paging.SORT_NAME : "ID";

                    string query_pagging = _select.query + " ORDER BY " + paging.SORT_NAME + "  OFFSET @start ROWS FETCH NEXT @limit ROWS ONLY";

                    var numRow = connection.Query<int>("SELECT COUNT(1) FROM (" + _select.query + ") b", param).FirstOrDefault();
                    var result = connection.Query<T>(query_pagging, param).ToList();

                    param = null;

                    return new DataPaging()
                    {
                        DATA = result,
                        DATA_TOTAL = numRow,
                        PAGING_ALL = paging.PAGING_ALL,
                        PAGING_SEARCH = paging.PAGING_SEARCH,
                        PAGING_LIMIT = paging.PAGING_LIMIT,
                        PAGING_CURRENT = paging.PAGING_CURRENT,
                        PAGING_START = paging.PAGING_START
                    };

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        public DataPaging DataPaging<T>(DataPaging paging, CommandModel comd)
        {
            using (IDbConnection connection = OpenConnection(_connection_string))
            {
                try
                {
                    param.Add("start", paging.PAGING_START);
                    param.Add("limit", paging.PAGING_LIMIT);

                    string query_pagging = comd.command + "  OFFSET @start ROWS FETCH NEXT @limit ROWS ONLY";

                    var numRow = connection.Query<int>("SELECT COUNT(1) FROM (" + comd.command + ") b", comd.parameter).FirstOrDefault();
                    var result = connection.Query<T>(query_pagging, comd.parameter).ToList();

                    param = null;

                    return new DataPaging()
                    {
                        DATA = result,
                        DATA_TOTAL = numRow
                    };

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
    }
}