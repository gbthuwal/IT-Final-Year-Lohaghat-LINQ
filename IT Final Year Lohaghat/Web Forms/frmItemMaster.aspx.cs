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
    public partial class ItemMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "Total Sessions = " + Application["SessionsCount"] + " Total Applications = " + Application["ApplicationsCount"];
            if (!IsPostBack)
            {
                this.FillDropDownList();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Data Saved Successfully = " + ddlItemName.SelectedIndex.ToString();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "";
            lblMessage.Text = "";
            lblMessage.Visible = false;
            txtItemName.Enabled = true;
        }

        private void FillDropDownList()
        {
            using (DataSet ds = new DataSet())
            {
                string path = Server.MapPath("XML/StoreItem.xml");
                ds.ReadXml(path);
                ddlItemName.DataSource = ds.Tables["Departments"];
                ddlItemName.DataValueField = ds.Tables["Departments"].Columns["DeptID"].ToString();
                ddlItemName.DataTextField = ds.Tables["Departments"].Columns["DeptName"].ToString();
                ddlItemName.DataBind();
                ddlItemName.SelectedItem.Value = "0";
                ddlItemName.SelectedItem.Text = "Select Department";
            }
        }

        protected void ddlItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillGridView();
        }

        private void FillGridView()
        {
            gvItems.Visible = true;
            lblMessage.Text = "";
            using (DataSet ds = new DataSet())
            {
                ds.ReadXml(Server.MapPath("XML/StoreItem.xml"));

                if (ddlItemName.SelectedValue.Equals("1") || ddlItemName.SelectedValue.Equals("4"))
                    gvItems.DataSource = ds.Tables["Computer"];
                else if (ddlItemName.SelectedValue.Equals("2"))
                    gvItems.DataSource = ds.Tables["Electronics"];
                else
                {
                    gvItems.Visible = false;
                    lblMessage.Text = "No Item Found in " + ddlItemName.SelectedItem.Text;
                    return;
                }
                gvItems.DataBind();
            }
        }

        protected void btnStock_Click(object sender, EventArgs e)
        {
            if (Response.IsClientConnected)
            {
                string url = "StoreStockRegister.aspx?DeptName=" + ddlItemName.SelectedItem.Text +
                            "&ItemName=" + gvItems.Rows[1].Cells[1].Text + "&Quantity="+ gvItems.Rows[1].Cells[3].Text;
                // If still connected, redirect to another page. 
                Response.Redirect(url, false);
            }
            else
            {
                // If the browser is not connected- Stop all response processing.
                Response.End();
            }
        }
    }
}