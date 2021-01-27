using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
namespace TouchPOS_API.Service.structure
{
    public class Getschemas
    {

        public List<SchemasModel> Table_Get_index(string table_name,bool base_locall)
        {
           
            try
            {
                DataContext exec = new DataContext( );
                //sale dolfin  630128
                string sql = "";
                if (base_locall= true)
                {
                    sql = " ";
                    sql += " select distinct s.name as schemas_name, t.name as table_name, i.name as index_name from sys.tables t ";
                    sql += " inner join sys.schemas s on t.schema_id = s.schema_id ";
                    sql += " inner join sys.indexes i on i.object_id = t.object_id ";
                    sql += " inner join sys.index_columns ic on ic.object_id = t.object_id ";
                    sql += " inner join sys.columns c on c.object_id = t.object_id and ";
                    sql += " ic.column_id = c.column_id ";
                    sql += " where i.index_id > 0 ";
                    sql += " and i.type in (1, 2) ";
                    sql += " and i.is_primary_key = 0 ";
                    sql += " and i.is_unique_constraint = 0 ";
                    sql += " and i.is_disabled = 0 ";
                    sql += " and i.is_hypothetical = 0 ";
                    sql += " and ic.key_ordinal > 0 ";
                    sql += " and  t.name = '" + table_name + "' ";
                }
                else
                {
                    sql = " ";
                    sql += " select distinct s.name as schemas_name, t.name as table_name, i.name as index_name from sys.tables t ";
                    sql += " inner join " + exec.DB_backup2 + "sys.schemas s on t.schema_id = s.schema_id ";
                    sql += " inner join " + exec.DB_backup2 + "sys.indexes i on i.object_id = t.object_id ";
                    sql += " inner join " + exec.DB_backup2 + "sys.index_columns ic on ic.object_id = t.object_id ";
                    sql += " inner join " + exec.DB_backup2 + "sys.columns c on c.object_id = t.object_id and ";
                    sql += " ic.column_id = c.column_id ";
                    sql += " where i.index_id > 0 ";
                    sql += " and i.type in (1, 2) ";
                    sql += " and i.is_primary_key = 0 ";
                    sql += " and i.is_unique_constraint = 0 ";
                    sql += " and i.is_disabled = 0 ";
                    sql += " and i.is_hypothetical = 0 ";
                    sql += " and ic.key_ordinal > 0 ";
                    sql += " and  t.name = '" + table_name + "' ";
                }
                
              

              return  exec.RunQuery<SchemasModel>(sql);
            }
            catch (Exception ex) {
                throw ex;
            }
        }


    }
}