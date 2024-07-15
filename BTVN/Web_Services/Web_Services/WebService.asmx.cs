using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Web_Services
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod(MessageName = "Hello demo")]
        public string Hello()
        {
            return "Hello I am Jessica";
        }

        [WebMethod(MessageName = "Hien thi phep tinh")]
        public string Input(string input)
        {
            return input;
        }
        [WebMethod(MessageName = "Demo Tinh 2 so")]
        public int Plus(int a, int b)
        {
            return a + b;
        }
    }
}
