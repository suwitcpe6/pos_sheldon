using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImageResizer;
namespace TouchPOS_API.Helpers
{
    public class BaseImageHelper
    {
        public string thumb_file(string file)
        {
            var name = file.Split('.');
            return name[0] + "thumb." + name[1];
        }

        public void resize(string old_path, string new_path)
        {
            var rs = new ResizeSettings();
            rs.MaxWidth = 200;
            rs.MaxHeight = 200;

            ImageBuilder.Current.Build(old_path, new_path, rs);
        }
    }
}