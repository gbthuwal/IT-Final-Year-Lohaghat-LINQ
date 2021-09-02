using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace IT_Final_Year_Lohaghat
{
    /// <summary>
    /// Summary description for ITFinalLohaghat
    /// </summary>
    [WebService(Namespace = "https://gplohagat.org.in/ITFinal", 
                Description = "This Service Provides Institute Detail of Polytechnic in Uttarakhand")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ITFinalLohaghat : System.Web.Services.WebService
    {

        [WebMethod(Description ="This Methods Returns a string literal")]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(Description = "This Methods Returns a Institute Information by Code")]
        public string GetInstituteInformation(int instCode)
        {
            return "Name of Institute is GP Lohaghat with Code" + instCode;
        }
    }
}
