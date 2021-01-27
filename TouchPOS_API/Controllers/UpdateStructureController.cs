using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http;
using TouchPOS_API.Class;
using TouchPOS_API.Service.structure;
using TouchPOS_API.Service;
using TouchPOS_API.Models;
namespace TouchPOS_API.Controllers
{
    public class UpdateStructureController : ApiController
    {


        [HttpGet]
        [Route("api/UpdateStructure/Update")]
        public ResponseMessage Update()
        {
            ResponseMessage ret = new ResponseMessage();
            try
            {
                ResponseMessage value = new ResponseMessage();
                var Table = new Table();


                var ret_config = new System_POS().Config_Load("");
                List<SysConfigModels> data_config = new List<SysConfigModels>();
                data_config = (List<SysConfigModels>)ret_config.Data;


                value = Table.Table_Create(data_config);
                if (value.Respon.Result == false)
                {
                    ret = value;
                    return ret;
                }


                value = Table.Table_Alter_Addcol(data_config);
                if (value.Respon.Result == false)
                {
                    ret = value;
                    return ret;
                }
                value = Table.Table_Alter_Altercol(data_config);
                if (value.Respon.Result == false)
                {
                    ret = value;
                    return ret;
                }
                var Table_Addconfig = new Table_Addconfig();
                value = Table_Addconfig.Addconfig(data_config);
                if (value.Respon.Result == false)
                {
                    ret = value;
                    return ret;
                }

                var Default_Config = new Default_Config();
                value = Default_Config.Default(data_config[0]);
                if (value.Respon.Result == false)
                {
                    ret = value;
                    return ret;
                }

                ret.Data = "Update successful";
                ret.Respon.Result = true;
                ret.Respon.ErrorMessage = "";
                return ret;
            }
            catch (Exception ex)
            {
                ret.Respon.Result = false;
                ret.Respon.SystemErrorMessage = ex.Message;
                return ret;
            }
        }
    }
}
