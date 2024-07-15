using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TestWebServices
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

        [WebMethod(MessageName = "Sum of numbers")]
        public sum (int x, int y)
        {

            return x + y;
        }
        [WebMethod(MessageName = "Minus of numbers")]
        public minus(int x, int y)
        {

            return x - y;
        }
        [WebMethod(MessageName = "Product of numbers")]
        public prod(int x, int y)
        {

            return x * y;
        }
        [WebMethod(MessageName = "Division of numbers")]
        public division(int x, int y)
        {

            return x / y;
        }

        [WebMethod]
        public string HelloWorld(string myString)
        {

            return myString;
        }

    }
}
