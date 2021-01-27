using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TouchPOS_API.Service.MASTER;
using TouchPOS_API.Models;
using TouchPOS_API.Class;
namespace TouchPOS_API.Controllers
{
    public class MasterController : ApiController
    {


        #region "Get"

        [HttpGet]
        [Route("api/Master/Search_MAS")]
        public IHttpActionResult Search_MAS(string SCR_TYPE, string fixvalue="", string CODE="", string NAME="", string Limit = Center.Limit)
        {
            //return Json(DOC_STATUS_CL.Select(DOS_GROUP));
            return Json(new SearchData().Search_MAS(SCR_TYPE, fixvalue, CODE, NAME, Limit));
        }

        [HttpGet]
        [Route("api/Master/COMPANYPROFILE_Select")]
        public IHttpActionResult COMPANYPROFILE_Select()
        {
            //return Json(DOC_STATUS_CL.Select(DOS_GROUP));
            return Json(new COMPANYPROFILE().COMPANYPROFILE_Select());
        }

        [HttpGet]
        [Route("api/Master/USERPROFILE_Select")]
        public IHttpActionResult USERPROFILE_Select(string UID)
        {
            //return Json(DOC_STATUS_CL.Select(DOS_GROUP));
            return Json(new USERPROFILE().USERPROFILE_Select(UID));
        }


        [HttpGet]
        [Route("api/Master/MAS_DOCTYPE_Select")]
        public IHttpActionResult MAS_DOCTYPE_Select(string VAL)
        {
            //return Json(DOC_STATUS_CL.Select(DOS_GROUP));
            return Json(new MAS_DOCTYPE().DOCTYPE_Select(VAL));
        }
        [HttpGet]
        [Route("api/Master/MAS_DOC_STATUS_Select")]
        public IHttpActionResult MAS_DOC_STATUS_Select(string DOS_GROUP, string UI_STATE)
        {
            //return Json(DOC_STATUS_CL.Select(DOS_GROUP));
            return Json(new DOC_STATUS_CL().DOC_STATUS_Select(DOS_GROUP, UI_STATE));
        }




        [HttpGet]
        [Route("api/Master/MAS_PRODUCT_Group_Select")]
        public IHttpActionResult PRODUCT_Group_Select(string ID)
        {
            return Json(new Mas_Product_Group().PRODUCT_Group_Select(ID));
        }


        [HttpGet]
        [Route("api/Master/MAS_PRODUCT_Group_List")]
        public IHttpActionResult PRODUCT_Group_List(string CODE = "", string NAME = "", string Limit = Center.Limit)
        {
            return Json(new Mas_Product_Group().Group_List(CODE, NAME, Limit));
        }

        [HttpGet]
        [Route("api/Master/MAS_PRODUCT_Group_List_CBO")]
        public IHttpActionResult PRODUCT_Group_List_CBO(string val = "")
        {
            return Json(new Mas_Product_Group().Group_List_CBO(val));
        }







        [HttpGet]
        [Route("api/Master/PRODUCT_TYPE_List")]
        public IHttpActionResult PRODUCT_TYPE_List(string PTCODE, string PTNAME, string Limit = Center .Limit )
        {
            return Json(new MAS_PRODUCT_TYPE().PRODUCT_TYPE_List( PTCODE,  PTNAME,  Limit));
        }

        [HttpGet]
        [Route("api/Master/MAS_PRODUCT_Type_List_CBO")]
        public IHttpActionResult PRODUCT_TYPE_List_CBO(string val = "")
        {
            return Json(new MAS_PRODUCT_TYPE().PRODUCT_TYPE_List_CBO(val));
        }

        [HttpGet]
        [Route("api/Master/PRODUCT_TYPE_Select")]
        public IHttpActionResult PRODUCT_TYPE_Select(string ID)
        {
            return Json(new MAS_PRODUCT_TYPE().PRODUCT_TYPE_Select(ID ));
        }











       
        [HttpGet]
        [Route("api/Master/MAS_PRODUCT_List")]
        public IHttpActionResult PRODUCT_List(string PCODE, string PNAME, string PGNAME, string PTNAME, string Limit = Center.Limit)
        {
            return Json(new Mas_Product().PRODUCT_List(PCODE, PNAME, PGNAME, PTNAME, Limit));
        }
        [HttpGet]
        [Route("api/Master/MAS_PRODUCT_Select")]
        public IHttpActionResult PRODUCT_Select(string ID)
        {
            return Json(new Mas_Product().PRODUCT_Select(ID));
        }



        [HttpGet]
        [Route("api/Master/MAS_PRODUCT_UNIT_Select")]
        public IHttpActionResult PRODUCT_UNIT_Select(string ID)
        {
            //return Json(DOC_STATUS_CL.Select(DOS_GROUP));
            return Json(new Mas_Product_UNIT().PRODUCT_UNIT_Select(ID));
        }

        [HttpGet]
        [Route("api/Master/MAS_PRODUCT_UNIT_List")]
        public IHttpActionResult PRODUCT_UNIT_List(string CODE = "", string NAME = "", string Limit = Center.Limit)
        {
            //return Json(DOC_STATUS_CL.Select(DOS_GROUP));
            return Json(new Mas_Product_UNIT().UNIT_List(CODE, NAME, Limit));
        }

        [HttpGet]
        [Route("api/Master/MAS_PRODUCT_UNIT_List_CBO")]
        public IHttpActionResult PRODUCT_UNIT_List_CBO(string val)
        {
            //return Json(DOC_STATUS_CL.Select(DOS_GROUP));
            return Json(new Mas_Product_UNIT().UNIT_List_CBO(val));
        }


        [HttpGet]
        [Route("api/Master/MAS_STOCK_Select")]
        public IHttpActionResult Stock_Select(string ID)
        {
            //return Json(DOC_STATUS_CL.Select(DOS_GROUP));
            return Json(new MAS_Stock().Stock_Select(ID));
        }
             [HttpGet]
        [Route("api/Master/MAS_STOCK_List_CBO")]
        public IHttpActionResult MAS_STOCK_List_CBO(string val)
        {
            //return Json(DOC_STATUS_CL.Select(DOS_GROUP));
            return Json(new MAS_Stock().STOCK_List_CBO(val));
        }


        [HttpGet]
        [Route("api/Master/MAS_MAS_Stock_List")]
        public IHttpActionResult Stock_List(string CODE = "", string NAME = "", string Limit = Center.Limit)
        {
            //return Json(DOC_STATUS_CL.Select(DOS_GROUP));
            return Json(new MAS_Stock().Stock_List(CODE, NAME, Limit));
        }

        [HttpGet]
        [Route("api/Master/Load_Menus_permis")]
        public IHttpActionResult Load_Menus_permis(string UID)
        {
            //return Json(DOC_STATUS_CL.Select(DOS_GROUP));
            return Json(new MAS_Menu_Permis().Load_Menus_permis(UID));
        }

        [HttpGet]
        [Route("api/Master/MAS_Load_Menus")]
        public IHttpActionResult MAS_Load_Menus(string val)
        {
            //return Json(DOC_STATUS_CL.Select(DOS_GROUP));
            return Json(new MAS_Menu_Permis().Load_Menus ( val));
        }

        

        [HttpGet]
        [Route("api/Master/MAS_Permis_List_Data")]
        public IHttpActionResult Permis_List_Data(string CODE = "", string NAME = "",string UID ="", string Limit = Center.Limit)
        {
            //return Json(DOC_STATUS_CL.Select(DOS_GROUP));
            return Json(new MAS_Menu_Permis().List_Data(CODE, NAME, UID, Limit));
        }
        [HttpGet]
        [Route("api/Master/Permis_Select_Data")]
        public IHttpActionResult Permis_Select_Data(string TR_ID)
        {
            //return Json(DOC_STATUS_CL.Select(DOS_GROUP));
            return Json(new MAS_Menu_Permis().Select_Data(TR_ID));
        }

        //[HttpGet]
        //[Route("api/Master/MAS_Select_Menu")]
        //public IHttpActionResult Select_Menu(string val = "")
        //{
        //    //return Json(DOC_STATUS_CL.Select(DOS_GROUP));
        //    return Json(new MAS_Menu_Permis().Select_Menu(val));
        //}


        [HttpGet]
        [Route("api/Master/REASON_List")]
        public IHttpActionResult REASON_List(string RSCODE, string RSNAME, string Limit = Center.Limit)
        {
            return Json(new MAS_REASON().REASON_List(RSCODE, RSNAME, Limit));
        }

        [HttpGet]
        [Route("api/Master/REASON_List_CBO")]
        public IHttpActionResult REASON_List_CBO(string val = "")
        {
            return Json(new MAS_REASON().REASON_List_CBO(val));
        }

        [HttpGet]
        [Route("api/Master/REASON_Select")]
        public IHttpActionResult REASON_Select(string ID)
        {
            return Json(new MAS_REASON().REASON_Select(ID));
        }




        #endregion










        #region "POST"


        //[HttpPost]
        //[Route("api/Master/Mas_Corp_Save")]
        //public IHttpActionResult Mas_Corp_Save([FromBody] MAS_CORP_Model.MAS_CORP_data Input_data, [FromUri()] string UI_STATE)
        //{
        //    return Json(new Mas_Corp().Save_Data(Input_data, UI_STATE));
        //}

        [HttpPost]
        [Route("api/Master/Mas_Product_Type_Save")]
        public IHttpActionResult Mas_Product_Type_Save([FromBody] MAS_PRODUCT_TYPE_Models.PRODUCT_TYPE_Data Input_data, [FromUri()] string UI_STATE)
        {
            return Json(new MAS_PRODUCT_TYPE().Save_Data(Input_data, UI_STATE));
        }


        [HttpPost]
        [Route("api/Master/Mas_Product_Group_Save")]
        public IHttpActionResult Mas_Product_Group_Save([FromBody] Mas_Product_Group_Models.PRODUCT_Group_Data Input_data, [FromUri()] string UI_STATE)
        {
            return Json(new Mas_Product_Group().Save_Data(Input_data, UI_STATE));
        }

        [HttpPost]
        [Route("api/Master/Mas_Product_Save")]
        public IHttpActionResult Mas_Product_Save([FromBody] Mas_Product_Model.Product_data Input_data, [FromUri()] string UI_STATE)
        {
            return Json(new Mas_Product().Save_Data(Input_data, UI_STATE));
        }


        [HttpPost]
        [Route("api/Master/MAS_Stock_Save")]
        public IHttpActionResult MAS_Stock_Save([FromBody] Mas_Stock_Models.MAS_STOCK_Data Input_data, [FromUri()] string UI_STATE)
        {
            return Json(new MAS_Stock().Save_Data(Input_data, UI_STATE));
        }
  
        [HttpPost]
        [Route("api/Master/Mas_Product_UNIT_Save")]
        public IHttpActionResult Mas_Product_UNIT_Save([FromBody] Mas_Product_UNIT_Models.PRODUCT_UNIT_Data Input_data, [FromUri()] string UI_STATE)
        {
            return Json(new Mas_Product_UNIT().Save_Data(Input_data, UI_STATE));
        }


        [HttpPost]
        [Route("api/Master/MAS_REASON_Save")]
        public IHttpActionResult MAS_REASON_Save([FromBody] MAS_REASON_Models.REASO_Data Input_data, [FromUri()] string UI_STATE)
        {
            return Json(new MAS_REASON().Save_Data(Input_data, UI_STATE));
        }


        [HttpPost]
        [Route("api/Master/MAS_Permis_Save")]
        public IHttpActionResult MAS_Permis_Save([FromBody] MAS_Menu_Permis_Models.PER_MIS_Save Input_data, [FromUri()] string UI_STATE)
        {
            return Json(new MAS_Menu_Permis().Save_Data(Input_data, UI_STATE));
        }




        #endregion



        #region "DELETE"

        [HttpDelete]
        [Route("api/Master/Mas_PRODUCT_TYPE_DELETE")]
        public IHttpActionResult Mas_PRODUCT_TYPE_DELETE(string ID)
        {
            return Json(new MAS_PRODUCT_TYPE().Delete(ID));
        }

        [HttpDelete]
        [Route("api/Master/Mas_PRODUCT_Group_DELETE")]
        public IHttpActionResult Mas_PRODUCT_Group_DELETE(string ID)
        {
            return Json(new Mas_Product_Group().Delete(ID));
        }



        [HttpDelete]
        [Route("api/Master/Mas_PRODUCT_DELETE")]
        public IHttpActionResult Mas_PRODUCT_DELETE(string PCODE)
        {
            return Json(new Mas_Product().Delete(PCODE));
        }

        [HttpDelete]
        [Route("api/Master/Mas_PRODUCT_UNIT_DELETE")]
        public IHttpActionResult Mas_PRODUCT_UNIT_DELETE(string ID)
        {
            return Json(new Mas_Product_UNIT().Delete(ID));
        }



        [HttpDelete]
        [Route("api/Master/MAS_REASON_DELETE")]
        public IHttpActionResult MAS_REASON_DELETE(string ID)
        {
            return Json(new MAS_REASON().Delete(ID));
        }

        [HttpDelete]
        [Route("api/Master/MAS_Stock_DELETE")]
        public IHttpActionResult MAS_Stock_DELETE(string ID)
        {
            return Json(new MAS_Stock().Delete(ID));
        }

        [HttpDelete]
        [Route("api/Master/MAS_Permis_DELETE")]
        public IHttpActionResult Permis_DELETE(string ID)
        {
            return Json(new MAS_Menu_Permis().Delete(ID));
        }

        #endregion

    }
}
