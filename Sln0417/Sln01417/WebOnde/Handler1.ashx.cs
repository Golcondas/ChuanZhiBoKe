using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebOnde
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {
        private string modelPath = "model.html";
        public void ProcessRequest(HttpContext context)
        {
            string a = context.Request.Form["isPostBack"];
            if (!string.IsNullOrEmpty(a))//上传提交
            {
                if (context.Request.Files.Count>0)
                {
                     HttpPostedFile files = context.Request.Files[0];
                     files.SaveAs(context.Server.MapPath("UpLoadFile\\2.jpg"));
                    context.Response.Write("上传成功！");
                }
               

            }
            else//url访问
            {
                modelPath = context.Server.MapPath(modelPath);
                string strHTML = System.IO.File.ReadAllText(modelPath);
                context.Response.Write(strHTML);
            }

           
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            //var a = context.Request.Form["ck"];
            //context.Response.Write(a);

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