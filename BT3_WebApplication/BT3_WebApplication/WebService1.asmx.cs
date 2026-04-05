using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BT3_WebApplication
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(string name)
        {
            return "Hello, " + name;
        }

        [WebMethod]
        public int AddCalculator(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public int SubtractCalculator(int a, int b)
        {
            return a - b;
        }

        [WebMethod]
        public int MultiplyCalculator(int a, int b)
        {
            return a * b;
        }

        [WebMethod]
        public double DivideCalculator(int a, int b)
        {

            if (b == 0)
            {
                throw new Exception("cannot divide by zero");
            }
            else
            {
                return (double)a / b;
            }
        }
    }
}
