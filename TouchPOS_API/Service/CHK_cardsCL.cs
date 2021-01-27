


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using TouchPOS_API.Class;
using TouchPOS_API.Models;


namespace TouchPOS_API.Service
{
    public class CHK_cardsCL
    {
        #region "select"
        public ResponseMessage chkcard(string BARCODE, decimal Nettotel, bool Muticard = false)
        {
            //ConString1 db = new ConString1();
            var ret = new ResponseMessage();
            try
            {

                string sql_card = "";
                sql_card = " SELECT top 1 cid,CUSED,CUSED1,BARCODE" +
                    //",'barcheck' = ( case right(BARCODE,1)" +
                    ",TYPEID,CBALANCE,cast(CEXPIRED as date)CEXPIRED, cast(getdate() as date) as date_Now  ,CSTATUS " +
                    "from CARDS  where BARCODE = '" + BARCODE + "' and CSTATUS IN ('A','E','R') order by [CDATE] desc ";
                var card = new DataContext().RunQuery<CHK_cardsModels>(sql_card);


                if (card != null)
                {
                    if (card.Count > 0)
                    {

                        //check expire for card
                        if (card[0].CSTATUS == "E" || card[0].CBALANCE <= 0)
                        {
                            ret.Respon.ErrorMessage = "บัตร  " + BARCODE + " หมดมูลค่าที่ร้านค้า ";
                            ret.Respon.SystemErrorMessage = "";
                            ret.Respon.Result = false;
                            return ret;
                        }
                        if (card[0].CSTATUS == "R")
                        {
                            ret.Respon.ErrorMessage = "บัตร  " + BARCODE + " ถูกคืนแล้ว ";
                            ret.Respon.SystemErrorMessage = "";
                            ret.Respon.Result = false;
                            return ret;
                        }


                        //check expire for card

                        if (card[0].CEXPIRED < card[0].date_Now)
                        {
                            ret.Respon.ErrorMessage = "บัตร " + BARCODE + " หมดอายุตั้งแต่วันที่ " + card[0].CEXPIRED.Value.Date.ToString("dd/MM/yyyy");
                            ret.Respon.SystemErrorMessage = "";
                            ret.Respon.Result = false;
                            return ret;
                        }


                        //บัตรไม่พอจ่าย

                        if (card[0].CBALANCE < Nettotel && Muticard == false)
                        {
                            var amount = Nettotel - card[0].CBALANCE;
                            ret.Respon.ErrorMessage = "ยอดเงินบัตร " + BARCODE + " คงเหลือ " + card[0].CBALANCE + " บาท ไม่พอจ่ายสินค้ามูลค่า " + Nettotel.ToString("#,##0.00") + " บาท ต้องการชำระเพิ่มด้วยบัตรอื่นหรือไม่";
                            ret.Respon.Result_value = "BROKE";
                            ret.Respon.Result_value2 = amount.ToString();
                            ret.Respon.Result_value3 = card[0].CBALANCE.ToString();
                            ret.Respon.SystemErrorMessage = "";
                            ret.Data = card;
                            ret.Respon.Result = false;
                            return ret;
                        }
                    }
                    else
                    {
                        ret.Respon.ErrorMessage = "ไม่พบข้อมูลบัตร " + BARCODE + " กรุณาอ่านบัตรอีกครั้ง";
                        ret.Respon.Result_value = "";
                        ret.Respon.SystemErrorMessage = "";
                        ret.Respon.Result = false;
                        return ret;
                    }
                }
                else
                {
                    ret.Respon.ErrorMessage = "ไม่พบข้อมูลบัตร " + BARCODE + " กรุณาอ่านบัตรอีกครั้ง";
                    ret.Respon.Result_value = "";
                    ret.Respon.SystemErrorMessage = "";
                    ret.Respon.Result = false;
                    return ret;
                }

                ret.Respon.ErrorMessage = "";
                ret.Respon.Result_value = "";
                ret.Respon.SystemErrorMessage = "";
                ret.Respon.Result = true;
                ret.Data = card;
                return ret;
            }

            catch (Exception e)
            {
                ret.Respon.ErrorMessage = "";
                ret.Respon.Result_value = "";
                ret.Respon.SystemErrorMessage = e.Message;
                ret.Respon.Result = false;
                return ret;
            }

        }
        public ResponseMessage chkcard_Potpaid(SysConfigModels data_config, CHKcard_MultiModels data)
        {
            //ConString1 db = new ConString1();
            var ret = new ResponseMessage();
            try
            {
                string sql_card = "";
                sql_card = " SELECT top 1 cid,CUSED,BARCODE" +
                    //",'barcheck' = ( case right(BARCODE,1)" +
                    ",TYPEID,CBALANCE,cast(CEXPIRED as date)CEXPIRED, cast(getdate() as date) as date_Now  ,CSTATUS " +
                    "from CARDS  where BARCODE = '" + data.BARCODE + "' order by [CDATE] desc ";
                var card = new DataContext().RunQuery<CHK_cardsModels>(sql_card);
                if (card.Count > 0)
                {
                    //check expire for card
                    if (card[0].CSTATUS == "E" || card[0].CBALANCE <= 0)
                    {
                        ret.Respon.ErrorMessage = "บัตร  " + data.BARCODE + " หมดมูลค่า กรุณาติดต่อ Cashier ";
                        ret.Respon.SystemErrorMessage = "";
                        ret.Respon.Result = false;
                        return ret;
                    }
                    if (card[0].CSTATUS == "R")
                    {
                        ret.Respon.ErrorMessage = "บัตร  " + data.BARCODE + " ถูกคืนแล้ว ";
                        ret.Respon.SystemErrorMessage = "";
                        ret.Respon.Result = false;
                        return ret;
                    }


                    //check expire for card

                    if (card[0].CEXPIRED < card[0].date_Now)
                    {
                        ret.Respon.ErrorMessage = "บัตร " + data.BARCODE + " หมดอายุตั้งแต่วันที่ " + card[0].CEXPIRED.Value.Date.ToString("dd/MM/yyyy");
                        ret.Respon.SystemErrorMessage = "";
                        ret.Respon.Result = false;
                        return ret;
                    }


                    //บัตรไม่พอจ่าย

                    if (card[0].CBALANCE < data.Nettotel)
                    {
                        var amount = data.Nettotel - card[0].CBALANCE;
                        ret.Respon.ErrorMessage = " กรุณาชำระเงินที่จุด Cashier";
                        ret.Respon.Result_value = "BROKE";
                        ret.Respon.Result_value2 = amount.ToString();
                        ret.Respon.Result_value3 = card[0].CBALANCE.ToString();
                        ret.Respon.SystemErrorMessage = "";
                        ret.Data = card;
                        ret.Respon.Result = false;
                        return ret;
                    }
                }
                else
                {
                    ret.Respon.ErrorMessage = "ไม่พบข้อมูลบัตร " + data.BARCODE + " กรุณาอ่านบัตรอีกครั้ง";
                    ret.Respon.Result_value = "";
                    ret.Respon.SystemErrorMessage = "";
                    ret.Respon.Result = false;
                    return ret;
                }


                ret.Respon.ErrorMessage = "";
                ret.Respon.Result_value = "";
                ret.Respon.SystemErrorMessage = "";
                ret.Respon.Result = true;
                ret.Data = card;
                return ret;
            }

            catch (Exception e)
            {
                ret.Respon.ErrorMessage = "";
                ret.Respon.Result_value = "";
                ret.Respon.SystemErrorMessage = e.Message;
                ret.Respon.Result = false;
                return ret;
            }

        }
        #endregion
        #region "SAVE"
        public ResponseMessage chkcard_Save(SysConfigModels data_config, CHKcard_MultiModels data)
        {
            //ConString1 db = new ConString1();
            var ret = new ResponseMessage();
            try
            {
                string sql_card = "";
                sql_card = " SELECT top 1 cid,CUSED,BARCODE,CSTATUS from CARDS  where BARCODE = '" + data.BARCODE + "'  ";
                var card = new DataContext().RunQuery<CHK_cardsModels>(sql_card);

                //ถ้าไม่มีให้เพิ่ม
                if (card.Count <= 0)
                {
                    var ret_save = new ResponseMessage();
                    ret_save = Save(data_config, data, "NEW");
                    if (ret_save.Respon.Result == false)
                    {
                        ret = ret_save;
                        return ret;
                    }
                    else
                    {
                        card = new DataContext().RunQuery<CHK_cardsModels>(sql_card);
                    }
                }
                else
                {
                    //C อย่างเดียวเท่านั้น
                    if (card[0].CSTATUS == "C")
                    {
                        var ret_save = new ResponseMessage();
                        ret_save = Save(data_config, data, "EDIT");
                        if (ret_save.Respon.Result == false)
                        {
                            ret = ret_save;
                            return ret;
                        }
                        else
                        {
                            card = new DataContext().RunQuery<CHK_cardsModels>(sql_card);
                        }
                    }

                }
                ret.Respon.ErrorMessage = "";
                ret.Respon.Result_value = "";
                ret.Respon.SystemErrorMessage = "";
                ret.Respon.Result = true;
                ret.Data = card;
                return ret;
            }

            catch (Exception e)
            {
                ret.Respon.ErrorMessage = "";
                ret.Respon.Result_value = "";
                ret.Respon.SystemErrorMessage = e.Message;
                ret.Respon.Result = false;
                return ret;
            }

        }

        public ResponseMessage Save(SysConfigModels data_config, CHKcard_MultiModels data, string uistate)
        {
            var con = new DataContext();
            var ret = new ResponseMessage();

            try
            {
                //ตรวจสอบ ประเภทบัตร 
                string sql_card = "";
                string barcode_cardtype = data.BARCODE.Substring(0, 1);
                string BRNID = data.BARCODE.Substring(1, data.BRNID.Length);
                if (BRNID != data.BRNID)
                {
                    ret.Respon.Result = false;
                    ret.Respon.ErrorMessage = "บัตรไม่ถูกต้อง";
                    return ret;
                }
                sql_card = " SELECT [TYPEID],[CARDTYPE],[TYPEDESCRIPTION],[MAXVALUE],[MINVALUE] ,[CTADDITEM]   FROM [CARDTYPE] where CARDTYPE = '" + barcode_cardtype + "' and CARDSTATUS ='A' ";

                var cardtype = new DataContext().ReadData_Table(sql_card);
                if (cardtype.Rows.Count <= 0)
                {
                    ret.Respon.Result = false;
                    ret.Respon.ErrorMessage = "ไม่พบบัตรประเภท " + barcode_cardtype;
                    return ret;
                }
                con.Open();
                string query = "";
                switch (uistate)
                {
                    case "NEW":

                        query = "\n INSERT INTO [CARDS](CUSED,[BARCODE],[TYPEID],[CADDITEM],[CDATE],[CEXPIRED],[CSTATUS],[CBALANCE],[CLUPDATE],[BACKUPFLG],[SHOPENDFLG],[SHOPENDPOS],[CAMOUNT]) ";
                        query += "\n VALUES(";
                        query += " 1";
                        query += " ,'" + data.BARCODE + "'";
                        query += " ,'" + cardtype.Rows[0]["TYPEID"] + "'";
                        query += " ,'" + cardtype.Rows[0]["CTADDITEM"] + "'";
                        query += " ,getdate() ";
                        query += " ,cast(getdate() as date) ";
                        query += " , 'A'  ";//CSTATUS, 
                        query += " ,'" + cardtype.Rows[0]["MAXVALUE"] + "'";
                        query += " ,getdate() ";
                        query += " ,NULL ";
                        query += " ,NULL ";
                        query += " ,'' ";
                        query += " ,'" + cardtype.Rows[0]["MAXVALUE"] + "')";
                        break;
                    case "EDIT":

                        query = "\n Update CARDS set CUSED = CUSED+1, CBALANCE= '" + cardtype.Rows[0]["MAXVALUE"] + "' ,CAMOUNT= '" + cardtype.Rows[0]["MAXVALUE"] + "' ,CSTATUS = 'A' ";
                        query += "\n where BARCODE ='" + data.BARCODE + "' ";
                        break;
                    default:
                        break;

                }

                query += "\n  INSERT INTO [CARDLOGS]([CUSED], [BARCODE], [CLSTATUS], [CLAMOUNT], [CLRECEIVE], [UID], [TID], [CLSLIPNO], [CLCREDITNOTE], [CLUPDATE], [BACKUPFLG], [CHKFLG], [PRINTFLG], [CLTAXINV], [NETAMOUNT], [PAYMENT], [SERVICE], [CHARGE], [CHARGE0], [DISCOUNT], [DISCOUNTAMT], [DISCOUNTAMT0], [DISCOUNT1], [DISCOUNT2], [DISCOUNT3], [DISCOUNT4], [PAYMENT1], [PAYMENT2], [PAYMENT3], [PAYMENT4], [SLIPSUBTOTAL], [SLIPSERVICE], [SLIPCHARGE], [SLIPTOTAL], [SLIPDISCOUNT], [SLIPDISCOUNTAMOUNT], [SLIPNETAMOUNT], [SLIPCHANGE], [SLIP_PAY], [SLIP_VAT], [SLIPRECEIVE], [SLIPTOTALEX], [PROID], [PAYTYPE] )";
                query += "\n VALUES( ";
                query += "\n (select top 1 CUSED from CARDS where barcode ='" + data.BARCODE + "'), ";
                query += "'" + data.BARCODE + "',";
                query += "'S',";
                query += "'" + cardtype.Rows[0]["MAXVALUE"] + "',";
                query += "'" + cardtype.Rows[0]["MAXVALUE"] + "',";
                query += "'" + data.SHOPID  + "',"; //ลงเป็น shhop id
                query += "'',"; //TID
                query += "'',";// CLSLIPNO
                query += "'',";// CLCREDITNOTE         
                query += "'" + data.workdate + "',"; //CLUPDATE   workdate + time
                query += "0,";
                query += "0,";
                query += "0,";//PRINTFLG
                query += "'',";//CLTAXINV     
                query += "0,";//NETAMOUNT
                query += "'',";//  PAYMENT, char(20),>
                query += "0,"; //SERVICE, smallmoney,>
                query += "0,"; //CHARGE, smallmoney,>
                query += "0,"; //CHARGE0, smallmoney,>
                query += "0,"; //DISCOUNT, smallmoney,>
                query += "0,"; //DISCOUNTAMT, smallmoney,>
                query += "0,"; //DISCOUNTAMT0, smallmoney,>
                query += "0,"; //DISCOUNT1, char(1),>
                query += "0,"; //DISCOUNT2, smallmoney,>
                query += "0,"; //DISCOUNT3, varchar(20),>
                query += "0,"; //DISCOUNT4, smallmoney,>
                query += "0,"; //PAYMENT1, char(1),>
                query += "0,"; //PAYMENT2, varchar(20),>
                query += "0,"; //PAYMENT3, varchar(20),>
                query += "0,"; //PAYMENT4, smallmoney,>
                query += "0,"; //SLIPSUBTOTAL, smallmoney,>
                query += "0,"; //SLIPSERVICE, smallmoney,>
                query += "0,"; //SLIPCHARGE, smallmoney,>
                query += "0,"; //SLIPTOTAL, smallmoney,>
                query += "0,"; //SLIPDISCOUNT, smallmoney,>
                query += "0,"; //SLIPDISCOUNTAMOUNT, smallmoney,>
                query += "0,"; //SLIPNETAMOUNT, smallmoney,>
                query += "0,"; //SLIPCHANGE, smallmoney,>
                query += "0,"; //SLIP_PAY, smallmoney,>
                query += "0,"; //SLIP_VAT, smallmoney,>
                query += "0,"; //SLIPRECEIVE, real,>
                query += "0,"; //SLIPTOTALEX, smallmoney,>
                query += "'',"; //PROID, nvarchar(10),>
                query += "1) ";


                con.Excute(query);





                con.Commit();
                //ret.Respon.Result_value2 = Input_data.MRTSLIPNO;
                //ret.Respon.SystemErrorMessage = "NOBALANCE";
                ret.Respon.Result = true;
            }
            catch (Exception e)
            {

                ///log error
                ///log error
                //////log error
                //////log error
                //////log error
                //////log error
                //////log error
                //////log error
                //////log error
                //////log error
                if (con.connection != null)
                { con.Rollback(); }

                ret.Respon.SystemErrorMessage = "API : " + e.Message.ToString();
                //ret.SystemErrorMessage = e.StackTrace;
                ret.Respon.Result = false;
            }
            finally
            {
                con.close();
            }
            return ret;
        }


        #endregion
    }
}