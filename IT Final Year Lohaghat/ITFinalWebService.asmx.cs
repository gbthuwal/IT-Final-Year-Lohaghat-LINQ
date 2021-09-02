using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace IT_Final_Year_Lohaghat
{
    /// <summary>
    /// Summary description for ITFinalWebService
    /// </summary>
    [WebService(Namespace = "http://gplohaghat.org.in/ITFinalWS", 
                Description="IT Final Year Web Service")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ITFinalWebService : System.Web.Services.WebService
    {
        [WebMethod (EnableSession =true,
                    BufferResponse = true,
                    CacheDuration =120, 
                    Description ="Returns Dataset From database with Given Data Source and Connection String")]
        public DataSet GetDataSet(string connString, string queryString)
        {
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryString, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            conn.Close();
            return ds;
        }
    }
}
