using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseRepository.Helpers;
using System.Configuration;
namespace TouchPOS_API.Helpers
{
    public class BaseManagement
    {
        public MessageModel _message;
        public Repository _base;
        public _BaseAutherizeHeader _header;


        public BaseManagement()
        {
            _base = new Repository();
            _message = new MessageModel();
            _header = new _BaseAutherizeHeader
            {
                USER_NAME = BaseAutherizeHeader.USER_NAME,
                USER_ID = BaseAutherizeHeader.USER_ID,
                LANG = BaseAutherizeHeader.LANG
            };
        }

        public string FileUrl(string file)
        {
            return string.Format("{0}/{1}", ConfigurationManager.AppSettings["UrlFrontFile"], file);
        }

        public string PictureThumbUrl(string file)
        {
            var thumb_file = new BaseImageHelper().thumb_file(file);
            return string.Format("{0}/{1}", ConfigurationManager.AppSettings["UrlFrontFile"], thumb_file);
        }

        public string PictureRecruitUrl(string file)
        {
            file = file.Replace("~/App_Data/Upload/", string.Empty);
            return string.Format("{0}/{1}", ConfigurationManager.AppSettings["UrlFrontRecruit"], file);
        }
    }
}