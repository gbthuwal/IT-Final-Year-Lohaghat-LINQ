using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITFinalYearLibrary;
using IT_Final_Year_Lohaghat.LinqToSQL;

namespace IT_Final_Year_Lohaghat.Web_Forms
{
    public partial class frmDisplayUsersLINQ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.FillGridViewUsersLinq();
                this.FillGridViewItemLinq();
                this.FillDropDownListLinq();
                this.FindAggregateValue();
            }
        }

        private void FillGridViewUsersLinq()
        {
            ITFinalYearClassDataContext dataContext = new ITFinalYearClassDataContext();
            gvUserDetails.DataSource = from user in dataContext.Users
                                       select user;
            gvUserDetails.DataBind();
        }

        private void FillGridViewItemLinq()
        {
            IEnumerable<ItemDetails> queryResult;
                        
            queryResult = from item in ItemDetails.GetDetailsAllItems()
                                       .Where (item => item.ItemId >= 1 && item.ItemId <= 3)
                                       select item;
            
            queryResult = from item in ItemDetails.GetDetailsAllItems()
                          where item.ItemId >= 1 && item.ItemId <= 3
                          select item;

            gvItemDetails.DataSource = queryResult;
            gvItemDetails.DataBind();
        }

        private void FindAggregateValue()
        {
            int[] Numbers = new int[] { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };
            int? result = null;

            result = Numbers.Where(x => x%2 == 0).Min();
            
            result = (from minEven in Numbers where (minEven % 2 == 0)
                        select minEven).Min();
            
            result = Numbers.Max();
            result = Numbers.Sum();
            result = Numbers.Count();

            result = (int) Numbers.Average();
            lblMessage.Text = result.ToString();
        }

        private void FillDropDownListLinq()
        {
            List<int> Numbers = new List<int> { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            IEnumerable<int> evenNumbers = from numbers in Numbers
                                           where (numbers % 2) == 0
                                           select numbers;

            ddlEvenNumbers.DataSource = evenNumbers;
            ddlEvenNumbers.DataBind();

            ddlEvenNumbers.Items[0].Text = "Here are Even Numbers";
        }
    }
}