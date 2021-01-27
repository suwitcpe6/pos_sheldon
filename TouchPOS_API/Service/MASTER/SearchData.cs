using System;
using System.Linq;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
using TouchPOS_API.Helpers;
using System.Collections.Generic;
using System.Data;
namespace TouchPOS_API.Service.MASTER
{
    public class SearchData
    {

        public ResponseMessage Search_MAS(string SCR_TYPE,  string fixvalue, string CODE, string NAME,  string Limit)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {

                DataContext conn = new DataContext(DataContext.conselect.con2);
                string sql = "";
                sql = " select * from (  ";
                switch (SCR_TYPE )
                {
                    case "UNIT":
                        sql += " select pu.UNITCODE as [CODE] ,u.UNITNAME as [NAME] " +
                                " ,pu.QTY_MAIN as value1" +
                                " ,'' as value2" +
                                " ,'' as value3" +
                                " ,'' as value4" +
                                " from MAS_PRODUCT_SED_UNIT pu inner " +
                                " join MAS_PRODUCT_UNIT u on pu.UNITCODE = u.UNITCODE " +
                                " where pcode = '"+ fixvalue + "'  ";
                        break;
                    case "PROD":
                        sql += " select pcode as [CODE] ,pname as [NAME] " +
                                " ,'' value1" +
                                " ,'' as value2" +
                                " ,'' as value3" +
                                " ,'' as value4" +
                                " from MAS_PRODUCT " +
                                " where [ISTAT] = '1' and [ACTIVEFLAG] = 'A'  ";
                        break;
                    case "STOCK":
                        sql += " SELECT " +
                            " bl.[STCODE]" +
                            " ,bl.[PCODE] as CODE" +
                            " ,p.PNAME as NAME" +
                            " ,sum([ST_QTY]) as value1" +
                            " ,u.UNITCODE as value2" +
                            " ,u.UNITNAME as value3" +
                            " FROM[V_MOV_BALANCE] bl" +
                            " left join MAS_PRODUCT p on p.PCODE = bl.PCODE" +
                            " left join MAS_PRODUCT_UNIT u on u.UNITCODE = bl.ST_UNITCODE  where ST_QTY >0" +
                            " group by bl.[STCODE],bl.[PCODE],p.PNAME,u.UNITCODE,u.UNITNAME";
                        break;

                    case "REASON":
                        sql += " select [RSCODE] as [CODE] ,[RSNAME] as [NAME] " +
                                " ,'' value1" +
                                " ,'' as value2" +
                                " ,'' as value3" +
                                " ,'' as value4" +
                                " from [MAS_REASON] " +
                                " where [ISTAT] = '1' and [ACTIVEFLAG] = 'A'  ";
                        break;
                    case "User":
                        sql += " select [UID] as [CODE] ,[UFULLNAME] as [NAME] " +
                                " ,ULEVEL as value1" +
                                " ,'' as value2" +
                                " ,'' as value3" +
                                " ,'' as value4" +
                                " from [USERPROFILE] " +
                                "  where USTATUS = 'E' and UID not in( select [UID] from PER_MIS where ACTIVEFLAG = 'A' and ISTAT = '1' ) ";
                        break;
                    default:
                        return new Center().Error_Return("Search data false , SCR_TYPE novalue !", "");
                        break;
                }
                sql += " ) as scr where 1=1";

                if (CODE != null)
                {
                    sql += " and  CODE like '%" + CODE + "%' ";
                }
                if (NAME != null)
                {
                    sql += " and (  NAME like '%" + NAME + "%' ) ";
                }

                sql += " order by CODE  ";


                var data = conn.RunQuery<SCR_MODELS.SeachMase>(sql);

                if (data != null)
                {
                    if (data.Count > 0)
                    {
                        ret.Data = data;
                        ret.Respon.ErrorMessage = "";
                        ret.Respon.Result = true;
                        ret.Respon.SystemErrorMessage = "";
                    }
                    else
                    {
                        return new Center().Error_Return("Data not found !", "");
                    }

                }
                else
                {
                    return new Center().Error_Return("Data not found !", "");
                }


            }
            catch (Exception e)
            {
                return new Center().Error_Return("", e.Message.ToString());
            }
            return ret;
        }

    }
}