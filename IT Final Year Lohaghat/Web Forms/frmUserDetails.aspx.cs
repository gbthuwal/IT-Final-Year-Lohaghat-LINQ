using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_Final_Year_Lohaghat.Web_Forms
{
    public partial class frmUserDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblUserName.Text = Request.QueryString["UserName"];
                lblUserID.Text = Request.QueryString["LoginID"];
            }
        }
    }
}