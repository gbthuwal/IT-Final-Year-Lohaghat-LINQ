using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_Final_Year_Lohaghat.Web_Forms.XML
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtItemName.Text = Request.QueryString["ItemName"];
            txtDeptName.Text = Request.QueryString["DeptName"];
            txtQty.Text = Request.QueryString["Quantity"];
        }
    }
}