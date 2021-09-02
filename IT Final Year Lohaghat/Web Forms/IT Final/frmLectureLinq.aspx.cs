using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_Final_Year_Lohaghat.Web_Forms
{
    public partial class frmLectureLinq : System.Web.UI.Page
    {
        Books book;
        Object dataSource;
        protected void Page_Load(object sender, EventArgs e)
        {
            book = new Books();
            if (!IsPostBack)   // IsPostBack = false When Page Requested First Time.
            {
                dataSource = book.GetBooksLinqToListObject();
                GVStudentDetail.DataSource = dataSource;
                GVStudentDetail.DataBind();
            }
        }

        protected void ddlOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlOptions.SelectedValue == "1")
                dataSource = book.GetBooksLinqToListObject();
            else if (ddlOptions.SelectedValue == "2")
                dataSource = book.GetBookDetainLinqToArray();
            else if (ddlOptions.SelectedValue == "3")
                dataSource = book.GetStudentDataTableLinqToObject();
                        
            GVStudentDetail.DataSource = dataSource;
            GVStudentDetail.DataBind();
        }
    }

    #region Class Book
    public class Books
    {
            public int BookID { get; set; }
            public String Title { get; set; }
            public String Auther { get; set; }
            public String Publication { get; set; }
            public String ISBN { get; set; }

            public IEnumerable<Object> GetBooksLinqToListObject()
            {
                List<Books> bookList = this.GetBookList();

                var books = from book in bookList
                            //where book.Auther == "Deepak Chandra Joshi" || book.Auther == "Sapana Joshi"
                            select new 
                                    {
                                        BookID = book.BookID,
                                        Title = book.Title,
                                        Auther = book.Auther,
                                        Publication = book.Publication,
                                        ISBN = book.ISBN
                                    };

                return books;
            }

            public Object GetBookDetainLinqToArray()
            {

                Books[] bookArray = {
                    new Books() { BookID = 1, Title = "Operating System", Auther = "Sachin Joshi", Publication="TMH Publication", ISBN = "1001001" },
                    new Books() { BookID = 2, Title = "Data Structure", Auther = "Sapana Joshi", Publication="New Age Publication", ISBN = "1001002" },
                    new Books() { BookID = 3, Title = "DBMS Concepts", Auther = "Neeraj Paridhyani", Publication="BPB Publication", ISBN = "1001003" },
                    new Books() { BookID = 4, Title = "Operating System", Auther = "Ajay Oli", Publication="TMH Publication", ISBN = "4521001" },
                    new Books() { BookID = 5, Title = "Network System", Auther = "Hritesh Manral", Publication="MacGrow Hills", ISBN = "1023401" },
                    new Books() { BookID = 6, Title = "Computer Organisation", Auther = "Sanjay Joshi", Publication="BPB Publication", ISBN = "1005611" },
                    new Books() { BookID = 7, Title = "Programming in PHP", Auther = "Ajay Oli", Publication="Dhanpat Rai and Sons", ISBN = "1036301" },
                    new Books() { BookID = 8, Title = "Data Warehousing", Auther = "Deepak Chandra Joshi", Publication="Wrox Publication", ISBN = "1032801" },
                };

                var bookDetail = from books in bookArray
                                 where books.Auther == "Sapana Joshi" || books.Auther == "Ajay Oli"
                                 select new
                                 {
                                     BookID = books.BookID,
                                     Title = books.Title,
                                     Auther = books.Auther,
                                     Publication = books.Publication,
                                     ISBN = books.ISBN
                                 };

                return bookDetail;
            }

            public IEnumerable<Object> GetStudentDataTableLinqToObject()
            {

                System.Data.DataTable dt = this.GetStudentsDataTable();

                IEnumerable<Object> students = from student in dt.AsEnumerable()
                                               where student.Field<string>("Semester") == "6" || student.Field<string>("Semester") == "5"
                                               select new
                                               {
                                                   Name = student.Field<string>("Name"),
                                                   Semester=student.Field<string>("Semester"),
                                                   Polytechnic = student.Field<string>("Polytechnic")
                                               };
                return students;
            }

            public List<Books> GetBookList()
            {
                List<Books> bookList = new List<Books>();
               
                var book1 = new Books
                {
                    BookID = 1001,
                    Title = "Programing in C",
                    Publication = "TMH New Delhi",
                    Auther = "Sapana Joshi",
                    ISBN = "10098345"
                };

                var book2 = new Books
                {
                    BookID = 1002,
                    Title = "Programing in C++",
                    Publication = "TMH New Delhi",
                    Auther = "Deepak Chandra Joshi",
                    ISBN = "100667895"
                };

                var book3 = new Books
                {
                    BookID = 1002,
                    Title = "Programing in C++",
                    Publication = "TMH New Delhi",
                    Auther = "Neeraj Paridhyani",
                    ISBN = "189338145"
                };

                bookList.Add(book1);
                bookList.Add(book2);
                bookList.Add(book3);

                return bookList;
            }

            public DataTable GetStudentsDataTable()
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.Add(new System.Data.DataColumn("Name", typeof(String)));
                dt.Columns.Add(new System.Data.DataColumn("Branch", typeof(String)));
                dt.Columns.Add(new System.Data.DataColumn("Semester", typeof(String)));
                dt.Columns.Add(new System.Data.DataColumn("Polytechnic", typeof(String)));

                System.Data.DataRow dr = dt.NewRow();
                dr[0] = "Deepak Joshi";
                dr[1] = "Information Technology";
                dr[2] = "6";
                dr[3] = "Govt Polytechnic Kashipur";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr[0] = "Suresh Kumar";
                dr[1] = "Computer Science";
                dr[2] = "6";
                dr[3] = "Govt Polytechnic Dehradun";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr[0] = "Ravi Bisht";
                dr[1] = "Information Technology";
                dr[2] = "5";
                dr[3] = "Govt Polytechnic Nainital";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr[0] = "Ravi Bhandari";
                dr[1] = "Information Technology";
                dr[2] = "4";
                dr[3] = "Govt Polytechnic Nainital";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr[0] = "Neeraj Pandey";
                dr[1] = "Information Technology";
                dr[2] = "4";
                dr[3] = "Govt Polytechnic Nainital";
                dt.Rows.Add(dr);

            return dt;
            }
    }
    #endregion
}