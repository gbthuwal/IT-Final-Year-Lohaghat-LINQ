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
    public partial class frmNewUserRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.FillDropDownList();
            }
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblMessage.Text = "Password do not Match";
                return;
            }

            string connString = @"Data Source=.\SQLEXPRESS; Initial Catalog=ITFinalYear; Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SPCreateUsers", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@UserLoginID", txtLoginID.Text));
            cmd.Parameters.Add(new SqlParameter("@UserFirstName", txtFirstName.Text));
            cmd.Parameters.Add(new SqlParameter("@UserLastName", txtLastName.Text));
            cmd.Parameters.Add(new SqlParameter("@UserLoginPassword", txtPassword.Text));
            cmd.Parameters.Add(new SqlParameter("@UserSecurityQuestion", Convert.ToInt32(ddlSecurityQuestion.SelectedValue)));
            cmd.Parameters.Add(new SqlParameter("@UserSecurityAnswer", txtSecurityAnswer.Text)); 
                       
            if(cmd.ExecuteNonQuery() > 0)
            {
                Response.Redirect("frmUserLogin.aspx?Message=Your Login ID is: " + txtLoginID.Text +" You Can Login Now", true);
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void FillDropDownList()
        {
            using (DataSet ds = new DataSet())
            {
                string connString = @"Data Source=.\SQLEXPRESS; Initial Catalog=ITFinalYear; Integrated Security=True";
               
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SPSelectSecurityQuestionsAll", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                
                ddlSecurityQuestion.DataSource = ds.Tables[0];
                
                ddlSecurityQuestion.DataValueField = ds.Tables[0].Columns["ID"].ToString();
                ddlSecurityQuestion.DataTextField = ds.Tables[0].Columns["Question"].ToString();
                
                ddlSecurityQuestion.DataBind();

                if (ds.Tables[0] != null)
                {
                    ddlSecurityQuestion.SelectedItem.Value = "0";
                    ddlSecurityQuestion.SelectedItem.Text = "Select Your Security Question";
                }
            }
        }
    }
}