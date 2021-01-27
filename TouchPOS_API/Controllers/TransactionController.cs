using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TouchPOS_API.Class;
using TouchPOS_API.Service;
using TouchPOS_API.Service.Transaction;
using TouchPOS_API.Models;
namespace TouchPOS_API.Controllers
{
    public class TransactionController : ApiController
    {


        #region "Get"




        //[HttpGet]
        //[Route("AMS_API/TR/Get_Location")]
        //public IHttpActionResult Get_Location(string LOCID)
        //{
        //    return Json(new TR_Movment().Get_Location( LOCID));
        //}
        //[HttpGet]
        //[Route("AMS_API/TR/Search_Location")]
        //public IHttpActionResult Search_Location(string BDNAME, string RNAME, string LOCID, string Limit = Center.Limt)
        //{
        //    return Json(new TR_Movment().Search_Location(BDNAME, RNAME, LOCID, Limit));
        //}
        //[HttpGet]
        //[Route("AMS_API/TR/Check_TagID")]
        //public IHttpActionResult Check_TagID(string PCODE="", string TAGI="")
        //{
        //    return Json(new TR_Movment().Check_TagID(PCODE, TAGI));
        //}
        //[HttpGet]
        //[Route("AMS_API/TR/Check_Person")]
        //public IHttpActionResult Check_Person(string PERCODE )
        //{
        //    return Json(new TR_Movment().Check_Person(PERCODE));
        //}

        //[HttpGet]
        //[Route("AMS_API/TR/Inquiry_TagID")]
        //public IHttpActionResult Inquiry_TagID(string PCODE = "", string TAGI = "")
        //{
        //    return Json(new TR_Movment().Inquiry_TagID(PCODE, TAGI));
        //}
        //[HttpGet]
        //[Route("AMS_API/TR/Check_Balance_TagID")]
        //public IHttpActionResult Check_Balance_TagID(string LOCID , string TAGID )
        //{
        //    return Json(new TR_Movment().Check_Balance_TagID(LOCID, TAGID));
        //}
        //[HttpGet]
        //[Route("AMS_API/TR/Check_WAIT_TI_TagID")]
        //public IHttpActionResult Check_WAIT_TI_TagID(string TAGID)
        //{
        //    return Json(new TR_Movment().Check_WAIT_TI_TagID( TAGID));
        //}
        //[HttpGet]
        //[Route("AMS_API/TR/Inquiry_WAIT_Tranfer")]
        //public IHttpActionResult Inquiry_WAIT_Tranfer(string TAGID="", string DOCNO="", string PCODE="", String Limit=Center.Limt)
        //{
        //    return Json(new TR_Movment().Inquiry_WAIT_Tranfer(TAGID,DOCNO, PCODE, Limit ));
        //}
        //[HttpGet]
        //[Route("AMS_API/TR/Check_WAIT_RPI_TagID")]
        //public IHttpActionResult Check_WAIT_RPI_TagID(string TAGID, string LOCID,string LOC_OUTSIDE)
        //{
        //    return Json(new TR_Movment().Check_WAIT_RPI_TagID(TAGID, LOCID, LOC_OUTSIDE));
        //}
        //[HttpGet]
        //[Route("AMS_API/TR/Load_Year_End")]
        //public IHttpActionResult Load_Year_End(string val = "")
        //{
        //    return Json(new TR_Movment().Load_Year_End(val));
        //}
        [HttpGet]
        [Route("api/TR/Load_Data_YearEnd")]
        public IHttpActionResult Load_Data_YearEnd(string YEAR)
        {
            return Json(new TR_Movment().Load_Data_YearEnd(YEAR));
        }
        [HttpGet]
        [Route("api/TR/TR_MOV_List_Data")]
        public IHttpActionResult TR_MOV_List_Data(string DOCTYPE, string DOCNO = "", string DOCDATE = "", string PERNAME = "", string STNAME = "", string Limit = Center.Limit)
        {
            return Json(new TR_Movment().List_Data(DOCTYPE, DOCNO, DOCDATE, PERNAME, STNAME, Limit));
        }
        [HttpGet]
        [Route("api/TR/TR_MOV_Select_Data")]
        public IHttpActionResult TR_MOV_Select_Data(string TR_ID)
        {
            return Json(new TR_Movment().Select_Data(TR_ID));
        }

        //[HttpGet]
        //[Route("AMS_API/TR/TR_SC_List_Data")]
        //public IHttpActionResult TR_SC_List_Data( string DOCNO = "", string DOCDATE = "", string LOCID = "", string Limit = Center.Limit)
        //{
        //    return Json(new TR_SC().List_Data( DOCNO, DOCDATE, LOCID, Limit));
        //}
        //[HttpGet]
        //[Route("AMS_API/TR/TR_SC_List_Data_Count")]
        //public IHttpActionResult TR_SC_List_Data_Count(string LOCID)
        //{
        //    return Json(new TR_SC().List_Data_Count(LOCID));
        //}
        //[HttpGet]
        //[Route("AMS_API/TR/TR_SC_Select_Data")]
        //public IHttpActionResult TR_SC_Select_Data(string TR_ID)
        //{
        //    return Json(new TR_SC().Select_Data(TR_ID));
        //}

        //[HttpGet]
        //[Route("AMS_API/TR/TR_SCR_SC")]
        //public IHttpActionResult TR_SCR_SC(string DOCNO, string DOCDATE, string LOCID, string Limit)
        //{
        //    return Json(new TR_ADJ().SCR_SC(DOCNO, DOCDATE, LOCID, Limit));
        //}
        //[HttpGet]
        //[Route("AMS_API/TR/TR_LOAD_SC")]
        //public IHttpActionResult TR_LOAD_SC(string TR_ID)
        //{
        //    return Json(new TR_ADJ().LOAD_SC(TR_ID));
        //}
        //[HttpGet]
        //[Route("AMS_API/TR/TR_ADJ_List_Data")]
        //public IHttpActionResult TR_LOAD_ADJ(string DOCNO, string DOCDATE, string LOCID, string Limit= Center.Limt)
        //{
        //    return Json(new TR_ADJ().List_Data( DOCNO,  DOCDATE,  LOCID,  Limit));
        //}
        //[HttpGet]
        //[Route("AMS_API/TR/TR_ADJ_Select_Data")]
        //public IHttpActionResult Select_ADJ(string TR_ID)
        //{
        //    return Json(new TR_ADJ().Select_Data(TR_ID));
        //}




        #endregion





        #region "POST"




        [HttpPost]
        [Route("api/TR/SCR_PRODUCT_chk_stock")]
        public IHttpActionResult SCR_PRODUCT_chk_stock([FromBody] Mas_Product_Model.Product_SCR value, [FromUri()] string Limit = Center.Limit)
        {

            return Json(new TR_Movment().SCR_PRODUCT_chk_stock(value, Limit));

        }

















        [HttpPost]
        [Route("api/TR/TR_Movment_Save")]
        public IHttpActionResult TR_Movment_Save([FromBody] TR_Movment_Models.MOV_Save Input_data, [FromUri()] string UI_STATE)
        {
            //if (Input_data.Data_H.DOCTYPE == "MOV.YEB")
            //{
            //    return Json(new TR_Movment().Save_Data_Carry(Input_data, UI_STATE));
            //}
            //else
            //{
            return Json(new TR_Movment().Save_Data(Input_data, UI_STATE));
            //}

            //return null;
        }

        [HttpPost]
        [Route("api/TR/TR_Save_Data_byPOS_Void")]
        public IHttpActionResult TR_Save_Data_byPOS_Void([FromBody] TR_Movment_Models.SALE_VOID value)
        {
          
            return Json(new TR_Movment().Save_Data_byPOS_Void( value));
          
        }
       
        [HttpPost]
        [Route("api/TR/TR_Movment_Cancel")]
        public IHttpActionResult TR_Movment_Cancel([FromBody()] TR_Movment_Models.Data_List data, [FromUri()] string UI_STATE)
        {
            return Json(new TR_Movment().Cancel(data));
        }

        [HttpPost]
        [Route("api/TR/Save_Data_YearEnd")]
        public IHttpActionResult Save_Data_YearEnd([FromBody] TR_Movment_Models.MOV_Save Input_data, [FromUri()] string UI_STATE)
        {        
               return Json(new TR_Movment().Save_Data_YearEnd(Input_data, UI_STATE));
          
        }

        //[HttpPost]
        //[Route("AMS_API/TR/TR_SC_Save")]
        //public IHttpActionResult TR_SC_Save([FromBody] TR_SC_Modesl.SC_Save Input_data, [FromUri()] string UI_STATE)
        //{
        //    return Json(new TR_SC().Save_Data(Input_data, UI_STATE));
        //    //return null;
        //}
        //[HttpPost]
        //[Route("AMS_API/TR/TR_SC_Cancel")]
        //public IHttpActionResult TR_SC_Cancel([FromUri()] string TR_ID, string DOCTYPE)
        //{
        //    return Json(new TR_SC().Cancel(TR_ID, DOCTYPE));
        //}



        //[HttpPost]
        //[Route("AMS_API/TR/TR_ADJ_Save")]
        //public IHttpActionResult TR_ADJ_Save([FromBody] TR_ADJ_Models.ADJ_Save Input_data, [FromUri()] string UI_STATE)
        //{
        //    return Json(new TR_ADJ().Save_Data(Input_data, UI_STATE));
        //    //return null;
        //}
        //[HttpPost]
        //[Route("AMS_API/TR/TR_ADJ_Cancel")]
        //public IHttpActionResult TR_ADJ_Cancel([FromUri()] string TR_ID, string DOCTYPE)
        //{
        //    return Json(new TR_ADJ().Cancel(TR_ID, DOCTYPE));
        //}





        #endregion
        #region "DELETE"


        //[HttpDelete]
        //[Route("AMS_API/TR/TR_Movment_Cancel")]
        //public IHttpActionResult TR_Movment_Cancel(string TR_ID)
        //{
        //    return Json(new TR_Movment().Cancel(TR_ID));
        //}


        #endregion
    }
}
