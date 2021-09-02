using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Xml.Linq;
using System.Xml;

namespace IT_Final_Year_Lohaghat.Web_Forms
{
    public partial class frmGridViewITFinal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.FillGridView();
            this.FillDropDownList();
        }

        private void FillGridView()
        {
            string connString = @"Data Source=.\SQLEXPRESS; Initial Catalog=ITFinalYear; Integrated Security=True";

            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(connString);
            string query = "SPSelectItemDetail";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            da.Fill(ds);

            conn.Close();

            GVDetail.DataSource = ds;
            GVDetail.DataBind();
        }

        private void FillDropDownList()
        {
            string connString = @"Provider=MSOLEDBSQL.1;Data Source=.\SQLEXPRESS; Initial Catalog=ITFinalYear; Integrated Security=SSPI";

            DataSet ds = new DataSet();
            OleDbConnection conn = new OleDbConnection(connString);
            string query = "SPSelectItemDetail";
            conn.Open();

            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            conn.Close();

            da.Fill(ds);
            ddlMachines.DataValueField = ds.Tables[0].Columns["ItemId"].ToString();
            ddlMachines.DataTextField = ds.Tables[0].Columns["ItemName"].ToString();
            ddlMachines.DataSource = ds;
            ddlMachines.DataBind();

        }
    }
}