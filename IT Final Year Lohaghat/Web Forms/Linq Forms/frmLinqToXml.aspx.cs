using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITFinalYearLibrary;

namespace IT_Final_Year_Lohaghat.Web_Forms
{
    public partial class frmLinqToXml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinqToXml linqXml = new LinqToXml();
            string fileVirtualPath = Server.MapPath("XML/StockRegister.xml");
            linqXml.InsertXmlElementAtLast(fileVirtualPath, "121", "Lathe Machine", "815 RPM Heavy Duty", "1250000", "10");
            this.FillGridLinqToXml();
        }
        
        private void FillGridLinqToXml()
        {
            string fileVirtualPath = Server.MapPath("XML/StockRegister.xml");
            System.Xml.Linq.XDocument xmlDocument = System.Xml.Linq.XDocument.Load(fileVirtualPath);
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
        private void UpdateXmlDocument(string fileVirtualPath)
        {
            System.Xml.Linq.XDocument xmlDocument = System.Xml.Linq.XDocument.Load(fileVirtualPath);

            //xmlDocument.Element("Books").Elements("Book")
            //                             .Where(item => item.Attribute("ID").Value == "101").FirstOrDefault()
            //                             .SetElementValue("Publication", "Dhanpat Rai & Sons");

            (from item in xmlDocument.Element("Books").Elements("Book")
             where item.Attribute("ID").Value == "101"
             select item).FirstOrDefault().SetElementValue("Publication", "Tata MacGrow Hill Publication");

            //var book = items.FirstOrDefault();

            //book.SetElementValue("Publication","Dhanpat Rai Publication");


            xmlDocument.Save(fileVirtualPath);

            lblMessage.Text = "Elemented Updated Successfully";
        }
    }
}