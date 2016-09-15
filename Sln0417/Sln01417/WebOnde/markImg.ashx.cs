using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WebOnde
{
    /// <summary>
    /// markImg 的摘要说明
    /// </summary>
    public class markImg : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");

            string imgPath = "UpLoadFile\\2.jpg";
            using (Image img=Bitmap.FromFile(context.Server.MapPath(imgPath)))
            {
                using (Graphics g=Graphics.FromImage(img))
                {
                    
                }
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}