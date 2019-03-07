using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    /// <summary>
    /// fileUpload 的摘要说明
    /// </summary>
    public class fileUpload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        { 
              String str = "{\"code\":";
             str = str + "200,\"meessage\":\"success\",\"src\":";

             str = str + "http://www.st-saas.com:8088/webclient/test.apk";
                    
         


           context.Response.ContentType = "text/plain";
           context.Response.Write(str);
 
          
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