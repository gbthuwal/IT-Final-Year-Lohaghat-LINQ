using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace IT_Final_Year_Lohaghat.Web_Forms.IT_Final
{
    public partial class frmConsumeWebService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connString = @"Data Source=.\SQLEXPRESS; Initial Catalog=ITFinalYear; Integrated Security=True";
            string queryString = "Select * From ItemDetail";

            //ITFinalWebService service = new ITFinalWebService();

            ITFinalYearWebServices.TFinalWebServiceSoapClient client =
                new ITFinalYearWebServices.TFinalWebServiceSoapClient();

            GVDetail.DataSource = client.GetDataSet(connString, queryString); // service.GetDataSet(connString, queryString);
            GVDetail.DataBind();
        }
    }
}