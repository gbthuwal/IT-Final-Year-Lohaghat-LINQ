using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace IT_Final_Year_Lohaghat.Web_Forms.IT_Final
{
    public partial class frmOleDB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strUserID = "govindb", strPassword = "Ram@123";

            string ConString = @"Provider=MSOLEDBSQL.1;Data Source=.\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=ITFinalYear";

            OleDbConnection con = new OleDbConnection(ConString);
            
            con.Open();

            System.Data.OleDb.OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT * FROM Users";
            cmd.Connection = con;
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new OleDbParameter("@UserLoginID", strUserID));
            cmd.Parameters.AddWithValue("@UserLoginPassword", strPassword);

            OleDbDataReader reader = cmd.ExecuteReader();
            
            // Read() method advances SqlDaraReader to the next record
            // Read One Row At a Time and Returns true when there are more rows
            if (reader.Read())
            {
                string url = "../frmUserDetails.aspx?LoginID=" + reader[1].ToString() +
                                "&UserName=" + reader[2].ToString();
                Response.Redirect(url, false);
            }
            else
            {
                lblMessage.Text = "Either Incorrect LoginID OR Password";
            }
        }
    }
}