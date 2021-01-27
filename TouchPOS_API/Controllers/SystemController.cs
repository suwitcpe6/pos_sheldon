using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TouchPOS_API.Service;
using TouchPOS_API.Class;
using TouchPOS_API.Models;
using System.Web;
using System.IO;
using System.Net.Http.Headers;

namespace TouchPOS_API.Controllers
{
    public class SystemController : ApiController
    {
        #region "Get"

        [HttpGet]
        [Route("api/System_POS/SEL_SysVersion")]
        public ResponseMessage SEL_SysVersion(string Val1)
        {
            return new System_POS().SEL_SysVersion(Val1);
        }

        [HttpGet]
        [Route("api/System_POS/Config_Load")]
        public ResponseMessage Config_Load(string Val1)
        {
            return new System_POS().Config_Load(Val1);
        }
        [HttpGet]
        [Route("api/System_POS/API_Version")]
        public string API_Version()
        {
            return "POS640121_1044";// ใช้อันนี้ไม่ได้เนื่องจากจะทำให้อัพไฟล์ AppSettings ด้วย มีปัญหากับ เบส // System.Configuration.ConfigurationSettings.AppSettings.Get("API_VERTION");//"API630529_1156";
            //return System.Configuration.ConfigurationSettings.AppSettings.Get("API_VERTION");//"API630529_1156";

        }

        [HttpGet]
        [Route("api/System_POS/Select_Config")]
        public ResponseMessage Select_Config(string Val)
        {
            return new System_POS().Select_Config(Val);
        }

        #endregion
        #region "POST"

        [HttpPost]
        [Route("api/System_POS/Save_Config")]
        //public ResponseMessage CHKcard_Multi(string BARCODE, int Nettotel)
        public ResponseMessage Save_Config([FromBody] Data_Config data)
        {
            return new System_POS().Save_Config(data);
        }
        #endregion

        #region "Update program"

        [HttpPost]
        [Route("api/System_POS/Update_exe")]
        //public ResponseMessage CHKcard_Multi(string BARCODE, int Nettotel)
        public ResponseMessage Update_exe([FromBody] Data_Config data)
        {
            return new System_POS().Save_Config(data);
        }



        [HttpGet]
        [Route("api/FileAPI/Checkfile_update")]
        public ResponseMessage Checkfile_update(string fileName)
        {
            //Create HTTP Response.
            var ret = new ResponseMessage();

            //Set the File Path.
            string filePath = HttpContext.Current.Server.MapPath("~/Files/") + fileName;

            //Check whether File exists.
            if (!File.Exists(filePath))
            {
                //Throw 404 (Not Found) exception if File not found.
                ret.Respon.Result = false;
                ret.Data = DateTime.Now;
                ret.Respon.ErrorMessage = "ไม่พบไฟล์ :" + fileName;
                return ret;
            }

            DateTime lasupdate = System.IO.File.GetLastWriteTime(filePath);
            //DateTime curdate = DateTime.Now;
            //if (curdate > lasupdate)
            //{
            //    //Throw 404 (Not Found) exception if File not found.

            //    ret.Respon.Result = false;
            //    ret.Respon.ErrorMessage = "ไม่พบรายการอัพเดทหรือไฟล์ไม่ล่าสุด :" + fileName;
            //    return ret;
            //}


            //ส่งกลับไปเปรียบเทียบ
            ret.Respon.Result = true;
            ret.Data = new Center().Condate(lasupdate, "ymd hh:mm:ss");
            ret.Respon.ErrorMessage = "";
            return ret;
        }
        [HttpGet]
        [Route("api/FileAPI/DownloadFiles")]
        public HttpResponseMessage GetFile(string fileName)
        {
            //Create HTTP Response.
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);

            //Set the File Path.
            string filePath = HttpContext.Current.Server.MapPath("~/Files/") + fileName;

            //Check whether File exists.
            if (!File.Exists(filePath))
            {
                //Throw 404 (Not Found) exception if File not found.
                response.StatusCode = HttpStatusCode.NotFound;
                response.ReasonPhrase = "Nofile";
                throw new HttpResponseException(response);
            }

            //Read the File into a Byte Array.
            byte[] bytes = File.ReadAllBytes(filePath);

            //Set the Response Content.
            response.Content = new ByteArrayContent(bytes);

            //Set the Response Content Length.
            response.Content.Headers.ContentLength = bytes.LongLength;

            //Set the Content Disposition Header Value and FileName.
            response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
            response.Content.Headers.ContentDisposition.FileName = fileName;

            //Set the File Content Type.
            response.Content.Headers.ContentType = new MediaTypeHeaderValue(MimeMapping.GetMimeMapping(fileName));

            DateTime lasupdate = System.IO.File.GetLastWriteTime(filePath);
            response.ReasonPhrase = new Center().Condate(lasupdate, "ymd hh:mm:ss");
            return response;
        }








        #endregion
    }
}
