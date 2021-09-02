using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITFinalYearLibrary;

namespace IT_Final_Year_Lohaghat.Web_Forms.Linq_Forms
{
    public partial class frmLinqToObject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var items1 = ItemDetails.GetDetailsAllItems()
                .Select(x => new { x.ItemName, x.ItemSpecification, x.ItemMake, x.ItemMFDYear })
                .GroupBy(x => x.ItemMFDYear);

            var items2 = ItemDetails.GetDetailsAllItems().OrderBy(x=>x.ItemMFDYear)
                         .GroupBy(x => x.ItemMFDYear);
            var item3 = items2.Select(item => item.Key);

            gvDetails.DataSource = items2;
            gvDetails.DataBind();
        }
    }
}