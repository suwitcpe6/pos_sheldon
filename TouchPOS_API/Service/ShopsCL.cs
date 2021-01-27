using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
namespace TouchPOS_API.Service
{
    public class ShopsCL
    {

        #region"select"
        public ResponseMessage shop_Load(string val)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {               
                if (val != "0")
                {
                    char[] spearator = { ',' };
                    string[] str = val.Split(spearator);
                    //Int64[] arrCountryCode = new Int64[str.Length];
                    string shop_in = "";
                    for (Int64 i = 0; i < str.Length; i++)
                    {
                        //arrCountryCode[i] = Int64.Parse(str[i]);
                        if (shop_in == "")
                        {
                            shop_in += str[i].ToString();
                        }
                        else
                        {
                            shop_in += "," + str[i].ToString();
                        }
                    }

                    string sql_corp = "";
                    string sql_config = "";
                    DataContext conn = new DataContext();
                    sql_config = " select [ITEMSNO], [CUSGROUP], [VENDOR_GETWAY], [CONN_LINK], [WALLET_TYPE] from " + conn.DB_backup + "SysConfig ";
                    var config = conn.ReadData_Table(sql_config);
                    
                    if(config.Rows[0]["CUSGROUP"].ToString() == cl_const.CUSGROUP.ATR)
                    {
                        sql_corp = " select top 1 COMID, BRNID, BRNNAMETHAI, BRNNAMEENG, BRNTAXID, BRNVAT, COMPNAME, ADDRESS1, ADDRESS2, REMARK, GATEWAY,'' as BRNCODE,( select top 1 STCODE from " + conn.DB_backup + "MAS_STOCK where ISTAT = '1' and ACTIVEFLAG ='A' order by ID desc) as STCODE " +
                            ",'' Merchant_ID" +
                            " from COMPANYPROFILE";
                    }
                    else if (config.Rows[0]["CUSGROUP"].ToString() == cl_const.CUSGROUP.CPN)
                    {
                        sql_corp = " select top 1 COMID, BRNID, BRNNAMETHAI, BRNNAMEENG, BRNTAXID, BRNVAT, COMPNAME, ADDRESS1, ADDRESS2, REMARK, GATEWAY,BRNCODE,'' as STCODE, Merchant_ID" +
                            " ,( SELECT top 1 Profit_N from " + conn.DB_daily + "SapMapping ) as Profit_N" +
                            " from COMPANYPROFILE ";
                    }
                    else
                    {
                        sql_corp = " select top 1 COMID, BRNID, BRNNAMETHAI, BRNNAMEENG, BRNTAXID, BRNVAT, COMPNAME, ADDRESS1, ADDRESS2, REMARK, GATEWAY,BRNCODE,'' as STCODE,'' Merchant_ID from COMPANYPROFILE"; 
                           
                    }

                    var corp = conn.RunQuery<CompanyprofileMoldels>(sql_corp);
                   

                    if (corp.Count <= 0)
                    {
                        ret.Respon.ErrorMessage = " ไม่พบข้อมูลบริษัท ";
                        ret.Respon.SystemErrorMessage = "";
                        ret.Respon.Result = false;
                        return ret;
                    }

                    string sql_card = "";
                    switch (config.Rows[0]["CUSGROUP"])
                    {
                        //case "LJ":
                        //    sql_card = " select ";
                        //    sql_card += " s.SHOPID, ";
                        //    sql_card += " s.MRIP, ";
                        //    sql_card += " s.MRID, ";
                        //    sql_card += " s.POSID, ";
                        //    sql_card += " s.SHOPNAME, ";
                        //    sql_card += " s.SHAREPERCENT, ";
                        //    sql_card += " s.SHAREPERCENTFLAG, ";
                        //    sql_card += " 0 as TERMINAL_ID, ";
                        //    sql_card += " '' as TERMINAL_TID, ";
                        //    sql_card += " '' as TERMINAL_DESCRIPTION,";
                        //    sql_card += " '' as TERMINAL_TTAXID, ";
                        //    sql_card += " '" + corp[0].BRNID + "' as BRNID, ";
                        //    sql_card += " '" + corp[0].BRNNAMETHAI + "' as BRNNAMETHAI, ";
                        //    sql_card += " '" + corp[0].BRNNAMEENG + "' as BRNNAMEENG, ";
                        //    sql_card += " '" + corp[0].BRNTAXID + "' as BRNTAXID, ";
                        //    sql_card += " '" + corp[0].BRNVAT + "' as BRNVAT, ";
                        //    sql_card += " '" + corp[0].COMPNAME + "' as COMPNAME ";
                        //    sql_card += " from[SHOPS]s  ";
                        //    sql_card += " where s.SHOPID in(" + shop_in + ")  ";
                        //    break;
                        case cl_const.CUSGROUP.CPN:
                            sql_card = " select ";
                            sql_card += " s.SHOPID, ";
                            sql_card += " s.MRIP, ";
                            sql_card += " s.MRID, ";
                            sql_card += " s.POSID, ";
                            sql_card += " s.SHOPNAME, ";
                            sql_card += " s.SHAREPERCENT, ";
                            sql_card += " s.SHAREPERCENTFLAG, ";
                            sql_card += " t.TERMINALID as TERMINAL_ID, ";
                            sql_card += " t.TID as TERMINAL_TID, ";
                            sql_card += " t.DESCRIPTION as TERMINAL_DESCRIPTION,";
                            sql_card += " t.TTAXID as TERMINAL_TTAXID, ";
                            sql_card += " '" + corp[0].BRNID + "' as BRNID, ";
                            sql_card += " '" + corp[0].BRNNAMETHAI + "' as BRNNAMETHAI, ";
                            sql_card += " '" + corp[0].BRNNAMEENG + "' as BRNNAMEENG, ";
                            sql_card += " '" + corp[0].BRNTAXID + "' as BRNTAXID, ";
                            sql_card += " '" + corp[0].BRNVAT + "' as BRNVAT, ";
                            sql_card += " '" + corp[0].COMPNAME + "' as COMPNAME, ";
                            sql_card += " '" + corp[0].BRNCODE + "' as BRNCODE, ";
                            sql_card += " '' as STCODE, ";
                            sql_card += " '" + corp[0].Merchant_ID + "' as Merchant_ID, ";
                            sql_card += " '" + corp[0].Profit_N + "' as Profit_N, ";
                            sql_card += " s.RONAME ";
                            sql_card += " from[SHOPS]s inner join[TERMINAL] t on s.MRIP = t.tip ";
                            sql_card += " where s.SHOPID in(" + shop_in + ") and s.[CONTSTATUS] = '1' ";
                            break;
                        case cl_const.CUSGROUP.HOMEPRO :
                            sql_card = " select ";
                            sql_card += " s.SHOPID, ";
                            sql_card += " s.MRIP, ";
                            sql_card += " s.MRID, ";
                            sql_card += " s.POSID, ";
                            sql_card += " s.SHOPNAME, ";
                            sql_card += " s.SHAREPERCENT, ";
                            sql_card += " s.SHAREPERCENTFLAG, ";
                            sql_card += " t.TERMINALID as TERMINAL_ID, ";
                            sql_card += " t.TID as TERMINAL_TID, ";
                            sql_card += " t.DESCRIPTION as TERMINAL_DESCRIPTION,";
                            sql_card += " t.TTAXID as TERMINAL_TTAXID, ";
                            sql_card += " '" + corp[0].BRNID + "' as BRNID, ";
                            sql_card += " '" + corp[0].BRNNAMETHAI + "' as BRNNAMETHAI, ";
                            sql_card += " '" + corp[0].BRNNAMEENG + "' as BRNNAMEENG, ";
                            sql_card += " '" + corp[0].BRNTAXID + "' as BRNTAXID, ";
                            sql_card += " '" + corp[0].BRNVAT + "' as BRNVAT, ";
                            sql_card += " '" + corp[0].COMPNAME + "' as COMPNAME, ";
                            sql_card += " '" + corp[0].BRNCODE + "' as BRNCODE, ";
                            sql_card += " t.EDC_IP, ";
                            sql_card += " '' as STCODE ";
                            sql_card += " from[SHOPS]s inner join[TERMINAL] t on s.MRIP = t.tip ";
                            sql_card += " where s.SHOPID in(" + shop_in + ")  and s.[CONTSTATUS] = '1'";
                            break;
                        case cl_const.CUSGROUP.ATR:
                            sql_card = " select ";
                            sql_card += " s.SHOPID, ";
                            sql_card += " s.MRIP, ";
                            sql_card += " s.MRID, ";
                            sql_card += " s.POSID, ";
                            sql_card += " s.SHOPNAME, ";
                            sql_card += " s.SHAREPERCENT, ";
                            sql_card += " '1' as SHAREPERCENTFLAG, ";
                            sql_card += " 0 as TERMINAL_ID, ";
                            sql_card += " '' as TERMINAL_TID, ";
                            sql_card += " '' as TERMINAL_DESCRIPTION,";
                            sql_card += " '' as TERMINAL_TTAXID, ";
                            sql_card += " '" + corp[0].BRNID + "' as BRNID, ";
                            sql_card += " '" + corp[0].BRNNAMETHAI + "' as BRNNAMETHAI, ";
                            sql_card += " '" + corp[0].BRNNAMEENG + "' as BRNNAMEENG, ";
                            sql_card += " '" + corp[0].BRNTAXID + "' as BRNTAXID, ";
                            sql_card += " '" + corp[0].BRNVAT + "' as BRNVAT, ";
                            sql_card += " '" + corp[0].COMPNAME + "' as COMPNAME, ";
                            sql_card += " '' as BRNCODE, ";
                            sql_card += " '" + corp[0].STCODE + "' as STCODE ";
                            sql_card += " from[SHOPS]s ";
                            sql_card += " where s.SHOPID in(" + shop_in + ") and s.[CONTSTATUS] = '1' ";
                            break;
                        default:

                            sql_card = " select ";
                            sql_card += " s.SHOPID, ";
                            sql_card += " s.MRIP, ";
                            sql_card += " s.MRID, ";
                            sql_card += " s.POSID, ";
                            sql_card += " s.SHOPNAME, ";
                            sql_card += " s.SHAREPERCENT, ";
                            sql_card += " s.SHAREPERCENTFLAG, ";
                            sql_card += " t.TERMINALID as TERMINAL_ID, ";
                            sql_card += " t.TID as TERMINAL_TID, ";
                            sql_card += " t.DESCRIPTION as TERMINAL_DESCRIPTION,";
                            sql_card += " t.TTAXID as TERMINAL_TTAXID, ";
                            sql_card += " '" + corp[0].BRNID + "' as BRNID, ";
                            sql_card += " '" + corp[0].BRNNAMETHAI + "' as BRNNAMETHAI, ";
                            sql_card += " '" + corp[0].BRNNAMEENG + "' as BRNNAMEENG, ";
                            sql_card += " '" + corp[0].BRNTAXID + "' as BRNTAXID, ";
                            sql_card += " '" + corp[0].BRNVAT + "' as BRNVAT, ";
                            sql_card += " '" + corp[0].COMPNAME + "' as COMPNAME, ";
                            sql_card += " '" + corp[0].BRNCODE + "' as BRNCODE, ";
                            sql_card += " '' as STCODE ";
                            sql_card += " from[SHOPS]s inner join[TERMINAL] t on s.MRIP = t.tip ";
                            sql_card += " where s.SHOPID in(" + shop_in + ") and s.[CONTSTATUS] = '1' ";
                            break;
                    }


                    var shop = new DataContext().RunQuery<shop_selectModels>(sql_card);
                    ret.Data = shop;
                }
                else
                {

                    string sql_card = "";

                    sql_card = " select s.SHOPID,s.MRIP,s.MRID,s.POSID,s.SHOPNAME,s.SHAREPERCENT from[SHOPS]s  ";
                    sql_card += " where CONTSTATUS = '1' ";
                    var shop = new DataContext().RunQuery<ShopModels>(sql_card);
                    ret.Data = shop;
                }

                ret.Respon.ErrorMessage = "";
                ret.Respon.Result = true;
                ret.Respon.SystemErrorMessage = "";

                //return new POS_API.DataContext().RunQuery<> ;
            }
            catch (Exception e)
            {
                ret.Respon.SystemErrorMessage = "API : " + e.Message.ToString();

                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
            }
            return ret;

        }
        public ResponseMessage shop_Load_IP(string IP)
        {
            //ConString1 db = new ConString1();
            ResponseMessage ret = new ResponseMessage();
            try
            {

                string sql_card = "";

                sql_card = " select s.SHOPID,s.MRIP,s.MRID,s.POSID,s.SHOPNAME,s.SHAREPERCENT from[SHOPS]s  ";
                sql_card += " where CONTSTATUS = '1' and s.MRIP = '" + IP + "'";
                var shop = new DataContext().RunQuery<ShopModels>(sql_card);
                ret.Data = shop;


                ret.Respon.ErrorMessage = "";
                ret.Respon.Result = true;
                ret.Respon.SystemErrorMessage = "";

                //return new POS_API.DataContext().RunQuery<> ;
            }
            catch (Exception e)
            {
                ret.Respon.SystemErrorMessage = "API : " + e.Message.ToString();

                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
            }
            return ret;

        }

        public ResponseMessage Shop_Buttons(string val)
        {
            ResponseMessage ret = new ResponseMessage();
            //ConString1 db = new ConString1();
            try
            {
                var ret_config = new System_POS().Config_Load("");
                List<SysConfigModels> data_config = new List<SysConfigModels>();
                data_config = (List<SysConfigModels>)ret_config.Data;


                char[] spearator = { ',' };
                string[] str = val.Split(spearator);
                //Int64[] arrCountryCode = new Int64[str.Length];
                string shop_in = "";
                for (Int64 i = 0; i < str.Length; i++)
                {
                    //arrCountryCode[i] = Int64.Parse(str[i]);

                    if (shop_in == "")
                    {
                        shop_in += str[i].ToString();
                    }
                    else
                    {
                        shop_in += "," + str[i].ToString();
                    }
                }


                string sql_card = "";
                DataContext conn = new DataContext();


                switch (data_config[0].CUSGROUP)
                {
                    case cl_const.CUSGROUP.ATR:// เอามาจาก secon
                        if (data_config[0].USESTOCK)
                        {
                            sql_card = "  select sb.SHOPID ,sb.POSID  ,sb.BTNID ,sb.BTNGROUP ,sb.BTNNAME ,sb.BTNPRICE " +
                                 " ,0 as BTNGP " +
                                 " ,0 as BTNGPRULE " +
                                 " ,0 as BTNPRICE2 " +
                                 " ,0 as BTNGP2 " +
                                 " ,0 as BTNGPRULE2 " +
                                 " ,0 as btnflg " +
                                 " ,p.PCODE " +
                                 " ,p.PNAME " +
                                 " ,u.UNITCODE " +
                                 " ,u.UNITNAME " +
                                 " from[SHOPBUTTON] sb " +
                                 " inner join " + conn.DB_backup + "MAS_PRODUCT p on p.PCODE = sb.PCODE" +
                                 " left join " + conn.DB_backup + "MAS_PRODUCT_UNIT U on p.UNITCODE = u.UNITCODE" +

                                 " where sb.SHOPID in(" + shop_in + ") order by sb.BTNID ";
                        }
                        else
                        {
                            sql_card = "  select sb.SHOPID ,sb.POSID  ,sb.BTNID ,sb.BTNGROUP ,sb.BTNNAME ,sb.BTNPRICE " +
                                 " ,0 as BTNGP " +
                                 " ,0 as BTNGPRULE " +
                                 " ,0 as BTNPRICE2 " +
                                 " ,0 as BTNGP2 " +
                                 " ,0 as BTNGPRULE2 " +
                                 " ,0 as btnflg " +
                                 " ,'' as PCODE " +
                                 " ,'' as PNAME " +
                                 " ,'' as UNITCODE " +
                                 " ,'' as UNITNAME " +
                                 " from[SHOPBUTTON] sb " +
                                 " where sb.SHOPID in(" + shop_in + ") order by sb.BTNID ";
                        }
                        

                        break;
                    default:
                        sql_card = " select sb.SHOPID ,sb.POSID  ,sb.BTNID ,sb.BTNGROUP ,sb.BTNNAME ,sb.BTNPRICE ,sb.BTNGP,sb.BTNGPRULE ,isnull(BTNPRICE2,0) BTNPRICE2,isnull(BTNGP2,0)BTNGP2,isnull(BTNGPRULE2,0)BTNGPRULE2   ";
                        sql_card += " ,isnull(h.happyhour_id, 0) as happyhour_id ";
                        sql_card += " ,isnull(h.[happyhour_desc], '')[happyhour_desc] ";
                        sql_card += " ,h.datestart ";
                        sql_card += " ,h.[dateend] ";
                        sql_card += " ,cast(h.[timestart] as varchar(8))[timestart]  ";
                        sql_card += " ,cast(h.[timeend] as varchar(8))[timeend]   ";
                        sql_card += " ,isnull(hd.btnflg, 0) as btnflg ";
                        sql_card += " ,'' as PCODE ";
                        sql_card += " ,'' as PNAME ";
                        sql_card += "  from[SHOPBUTTONS] sb   ";
                        sql_card += " left join " + conn.DB_backup + "happyhourdt hd on hd.shopid = sb.SHOPID and hd.btnid=sb.BTNID ";
                        sql_card += "  left join " + conn.DB_backup + "happyhour h on h.happyhour_id = hd.happyhour_id and cast(getdate() as date) >= h.datestart and cast(getdate() as date) <=  h.dateend ";
                        sql_card += "  where sb.SHOPID in(" + shop_in + ") order by sb.BTNID ";

                        break;
                }



                var SHOPBUTTONS = conn.RunQuery<ShopbuttonsModels>(sql_card);

                ShopbuttonsValue buttonsvalue = new ShopbuttonsValue();

                buttonsvalue.Shopbuttons = SHOPBUTTONS;
                //buttonsvalue.happyhour = happyhour;

                ret.Data = buttonsvalue;
                ret.Respon.ErrorMessage = "";
                ret.Respon.Result = true;
                ret.Respon.SystemErrorMessage = "";

                //return new POS_API.DataContext().RunQuery<> ;
            }
            catch (Exception e)
            {
                ret.Respon.SystemErrorMessage = "API : " + e.Message.ToString();

                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
            }
            return ret;
        }
        #endregion

        #region"save"
        #endregion

    }
}