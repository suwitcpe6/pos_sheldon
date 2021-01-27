using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TouchPOS_API.Class;
using TouchPOS_API.Service;
using TouchPOS_API.Models;

namespace TouchPOS_API.Controllers
{
    public class CARDTRANSController : ApiController
    {
        #region "Get"

        //[HttpGet]
        //[Route("api/CARDTRANS/Sum_Net")]
        //public ResponseMessage Sum_Net(string Val)
        //{
        //    return new CardtransCL().Sel_Sum_Net(Val);
        //}
        //[HttpGet]
        //[Route("api/CARDTRANS/PrintSlip")]
        //public ResponseMessage PrintSlip(string CorpBRNID, string slipno)
        //{
        //    return new CardtransCL().Sel_PrintSlip(CorpBRNID,slipno);
        //}
        //[HttpGet]
        //[Route("api/CARDTRANS/Sel_PrintSlip_INV")]
        //public ResponseMessage Sel_PrintSlip_INV(string slipno)
        //{
        //    return new CardtransCL().Sel_PrintSlip_INV(slipno);
        //}
        //[HttpGet]
        //[Route("api/CARDTRANS/Sel_PrintSlip_CN")]
        //public ResponseMessage Sel_PrintSlip_CN(string VOIDNO)
        //{
        //    return new CardtransCL().Sel_PrintSlip_CN(VOIDNO);
        //}
        //[HttpGet]
        //[Route("api/CARDTRANS/Get_VOID")]
        //public ResponseMessage Get_VOID(string SHOP_ID)
        //{

        //    return new CardtransCL().Get_VOID(SHOP_ID);
        //}
        //[HttpGet]
        //[Route("api/CARDTRANS/PrintSlip_multi")]
        //public ResponseMessage PrintSlip_multi(string slipno)
        //{
        //    return new CardtransCL().Sel_PrintSlip_multi(slipno);
        //}
        
        //[HttpPost]
        //[Route("api/CARDTRANS/CHKcard_Multi")]
        ////public ResponseMessage CHKcard_Multi(string BARCODE, int Nettotel)
        //     public ResponseMessage Insert_All([FromBody]CHKcard_MultiModels data)
        //{            
        //    return new CardtransCL().Sel_CHKcard_Multi(data);
        //}
        //[HttpPost]
        //[Route("api/CARDTRANS/Sel_CHKcard_Postpaid")]
        ////public ResponseMessage CHKcard_Multi(string BARCODE, int Nettotel)
        //public ResponseMessage Sel_CHKcard_Postpaid([FromBody] CHKcard_MultiModels data)
        //{
        //    return new CardtransCL().Sel_CHKcard_Postpaid(data);
        //}


        


        //[HttpGet]
        //[Route("api/CARDTRANS/Sel_Rpt_dayend")]
        //public ResponseMessage Sel_Rpt_dayend(string CorpBRNID, string shopid, string MRTLUPDATE)
        //{
        //    return new CardtransCL().Sel_Rpt_dayend(CorpBRNID,shopid, MRTLUPDATE);
        //}

        //[HttpGet]
        //[Route("api/CARDTRANS/Sel_Repay")]
        //public ResponseMessage Sel_Repay(string POSID )
        //{
        //    return new CardtransCL().Sel_Repay(POSID);
        //}
        //[HttpGet]
        //[Route("api/CARDTRANS/Sel_Void_EWALLET")]
        //public ResponseMessage Sel_Void_EWALLET(string Vtype, string shopid, string barcode)
        //{
        //    return new CardtransCL().Sel_Void_EWALLET(Vtype, shopid, barcode);
        //}

        #endregion
        #region "POST"

        readonly CardtransCL Savecardtran = new CardtransCL();
        [HttpPost]
        [Route("api/CARDTRANS/Save")]
        public IHttpActionResult Save([FromBody]CardtranModels.SALE_INT Input_data)
        {
            return Json(Savecardtran.Save(Input_data));
        }
        //[HttpPost]
        //[Route("api/CARDTRANS/confirmpay")]
        //public IHttpActionResult confirmpay([FromBody] confirmpay data)
        //{
        //    return Json(Savecardtran.confirmpay(data));
        //}
        //[HttpPost]
        //[Route("api/CARDTRANS/confirm_Sale_cancel")]
        //public IHttpActionResult Sale_cancel([FromBody]ConfirmpayModels data)
        //{
        //    return Json(Savecardtran.confirm_Sale_cancel(data));
        //}

        //[HttpPost]
        //[Route("api/CARDTRANS/Sale_VOID")]
        //public IHttpActionResult Sale_VOID([FromBody] List<VoidModels.SALE_void> data)
        //{
        //    return Json(Savecardtran.Sale_VOID(data));
        //}
        //[HttpPost]
        //[Route("api/CARDTRANS/confirmpay_log")]
        //public IHttpActionResult confirmpay([FromBody]ConfirmpayModels_log data)
        //{
        //    return Json(Savecardtran.confirmpay_log(data));
        //}

        #endregion

    }
}
