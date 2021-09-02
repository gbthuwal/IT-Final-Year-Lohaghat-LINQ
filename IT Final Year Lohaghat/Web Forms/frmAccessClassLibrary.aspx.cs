using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITFinalYearLibrary;

namespace IT_Final_Year_Lohaghat.Web_Forms
{
    public partial class frmAccessClassLibrary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                //ITFinalYearLibrary.ITFinalLecture itFinalLect1 = new ITFinalYearLibrary.ITFinalLecture();
                ITFinalLecture itFinalLect2 = new ITFinalLecture(1, 25);
                
                lblMessage.Text = itFinalLect2.PrintMessage();

                ddlEvenNumbers.DataSource = itFinalLect2.GetEvenNumbers();
                ddlEvenNumbers.DataBind();
            }
        }
    }
}