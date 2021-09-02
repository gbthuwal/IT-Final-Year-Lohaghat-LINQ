using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace IT_Final_Year_Lohaghat.Web_Forms
{
    public partial class frmUserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
            if(Request.QueryString["Message"] != null)
            {
                lblMessage.Text = Request.QueryString["Message"];
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string strUserID, strPassword;
            strUserID = txtUserName.Text.Trim();
            strPassword = txtPassword.Text.Trim();

            string ConString = @"Data Source=.\SQLEXPRESS; Initial Catalog=ITFinalYear; Integrated Security=True";
            
            SqlConnection con = new SqlConnection(ConString);
     
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SPSelectUserByLoginID";
            cmd.Connection = con;

            //SqlCommand cmd = new SqlCommand(querystring, con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@UserLoginID", strUserID));
            cmd.Parameters.AddWithValue("@UserLoginPassword", strPassword);
            
            SqlDataReader reader = cmd.ExecuteReader();
            // Read() method advances SqlDaraReader to the next record
            // Read One Row At a Time and Returns true when there are more rows
            if (reader.Read())
            {
                string url = "frmUserDetails.aspx?LoginID=" + reader[1].ToString() + 
                                "&UserName=" + reader[2].ToString();
                Response.Redirect(url, false);
            }
            else
            {
                lblMessage.Text = "Either Incorrect LoginID OR Password";
            }
            con.Close();
        }

        protected void BtnNewUser_Click(object sender, EventArgs e)
        {
            string url = "frmNewUserRegistration.aspx";
            Response.Redirect(url, false);
        }
    }
}