using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IT_Final_Year_Lohaghat;


namespace IT_Final_Year_Lohaghat.Web_Forms.IT_Final
{
    public partial class ConsumeWebService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ITFinalGPLG.TFinalLohaghatSoapClient client = new ITFinalGPLG.TFinalLohaghatSoapClient();
            //Label1.Text = client.HelloWorld();
            Label1.Text = client.GetInstituteInformation(100);
        }
    }
}