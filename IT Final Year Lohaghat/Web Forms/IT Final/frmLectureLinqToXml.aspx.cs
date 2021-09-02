using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITFinalYearLibrary;
using System.Xml.Linq;

namespace IT_Final_Year_Lohaghat.Web_Forms
{
    public partial class frmLectureLinqToXml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.FillGridLinqToXml();
            }
        }

        protected void ddlOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlOptions.SelectedValue == "2")
            {
                btnSaveUpdate.Text = "Save";
            }
            else
            {
                btnSaveUpdate.Text = "Update";
            }
        }

        protected void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            string fileVirtualPath = Server.MapPath("XML/StockRegister.xml");

            if (ddlOptions.SelectedValue == "2")
                this.InsertXmlElementAtLast(fileVirtualPath, txtItemID.Text.Trim(), txtName.Text.Trim(), txtSpecification.Text.Trim(), txtPrice.Text.Trim(), txtMake.Text.Trim(), txtQuantity.Text.Trim());
            else
                this.UpdateXmlDocument(fileVirtualPath, txtItemID.Text.Trim(), txtName.Text.Trim(), txtSpecification.Text.Trim(), txtMake.Text.Trim(), txtPrice.Text.Trim(), txtQuantity.Text.Trim());

            this.FillGridLinqToXml();

            txtItemID.Text = string.Empty;
            txtMake.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtSpecification.Text = string.Empty;
        }

        private void FillGridLinqToXml()
        {
            string fileVirtualPath = Server.MapPath("XML/StockRegister.xml");
            
            XDocument xmlDocument = System.Xml.Linq.XDocument.Load(fileVirtualPath);
            
            IEnumerable<object> items = from item in xmlDocument.Element("StoreItems").Elements("Item")
                                        select new
                                        {
                                            ItemID = item.Attribute("ID").Value,
                                            ItemName = item.Element("Name").Value,
                                            Specification = item.Element("Specification").Value,
                                            UnitPrice = item.Element("Price").Value,
                                            Balance = item.Element("Quantity").Value
                                        };

            GVBookDetails.DataSource = items;
            GVBookDetails.DataBind();
        }

        private void UpdateXmlDocument(string fileVirtualPath, string itemID, string itemName, string specification, string make, string price, string quantity)
        {
            System.Xml.Linq.XDocument xmlDocument = System.Xml.Linq.XDocument.Load(fileVirtualPath);

            var items = (from item in xmlDocument.Element("StoreItems").Elements("Item")
                        where item.Attribute("ID").Value == itemID
                        select item).FirstOrDefault();

            items.SetElementValue("Name", itemName);
            items.SetElementValue("Specification", specification);
            items.SetElementValue("Price", price);
            items.SetElementValue("Make", make);
            items.SetElementValue("Quantity", quantity);
           
            //var item = items.FirstOrDefault();

            //item.SetElementValue("Publication","Dhanpat Rai Publication");

            xmlDocument.Save(fileVirtualPath);

            lblMessage.Text = "Element Updated Successfully";
        }

        public void InsertXmlElementAtLast(string fileVirtualPath, string itemID, string itemName, string specification, string make, string price, string quantity)
        {
            XDocument xmlDocument = XDocument.Load(fileVirtualPath);
            xmlDocument.Element("StoreItems").Add(new XElement("Item", new XAttribute("ID", itemID),
                                                new XElement("Name", itemName),
                                                new XElement("Specification", specification),
                                                new XElement("Quantity", quantity),
                                                new XElement("Make", make),
                                                new XElement("Price", price)
                                                ));

            xmlDocument.Save(fileVirtualPath, SaveOptions.None);

            lblMessage.Text = "Element Added Successfuly";
        }

        private void CreateXmlDocument(string fileVirtualPath)
        {
            XDocument xmlDocument = new XDocument();
            
            xmlDocument.Add(new XDeclaration("1.0", "utf-16", "yes"));
            
            XElement xmlElement = new XElement("Students",
                                    new XElement("Student", new XAttribute("SID", "1"),
                                    new XElement("Name", "Deepak Adhikari"),
                                    new XElement("Name", "Deepak Adhikari")
                                    ));

            xmlDocument.Add(xmlElement);

            xmlDocument.Save(fileVirtualPath, SaveOptions.None);

            lblMessage.Text = "XmlDocument Created";

        }
    }
}