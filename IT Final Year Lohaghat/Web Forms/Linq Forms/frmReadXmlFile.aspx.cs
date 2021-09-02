using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace IT_Final_Year_Lohaghat.Web_Forms
{
    public class Book
    {
        public int BookID;
        public String Title;
        public String Auther;
        public String Publication;
        public String ISBN;
    }
    public partial class ReadXmlFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ReadXmlFillGridLinqToXml();

            this.CreateXmlDocument();

            this.FillGridUsingDataTableLinq();

            this.FillGridLinqToObject((IEnumerable<Object>)this.ReadXmlDocumentLinqToXml("XML/Employee.xml"));
        }

        public void CreateXmlDocument()
        {
            string path = Server.MapPath("XML/Employee.xml");

            XDocument xmlDocument = new XDocument(new XDeclaration("1.0", "UTF-16", "yes"));

            XElement xmlEmployee = new XElement("Employees",
                                        new XElement("Employee", 
                                            new XComment("Only 3 elements for demo purposes"),
                                            new XElement("EmpId", "175"),
                                            new XElement("Name", "Govind"),
                                            new XElement("Sex", "Ballabh"),
                                                new XElement("Address",
                                                    new XComment("Address of Correspondance"),
                                                    new XElement("StreetNo", "102"),
                                                    new XElement("StreetName", "Godse Ji Marg"),
                                                    new XElement("District", "Awadh")
                                                )
                                         )
                                     );
            
            //XDocument xmlDocument = new XDocument(new XDeclaration("1.0", "UTF-16", "yes"), xmlEmployee);
            
            xmlDocument.Add(xmlEmployee);

            xmlDocument.Save(path);
            
            lblMessage.Text = "XML Document Saved";
        }

        private Object ReadXmlDocumentLinqToXml(string fileVirtualPath)
        {
            XmlReader xmlReader = XmlReader.Create(Server.MapPath(fileVirtualPath));
            XElement xmlElement = XElement.Load(xmlReader);

            var xmlEmpList = from employee in xmlElement.Elements("Employee")
                            where (string)employee.Element("Address").Element("District") == "Awadh"
                            select new
                            {
                                EmpID = employee.Element("EmpId").Value,
                                EmpName = employee.Element("Name").Value,
                                EmpStreetNo = employee.Element("Address").Element("StreetNo").Value,
                                EmpStreetName = employee.Element("Address").Element("StreetName").Value,
                                EmpDistrict = employee.Element("Address").Element("District").Value
                            };

            xmlReader.Close();
            return xmlEmpList;
        }

        private void FillGridLinqToObject(IEnumerable<Object> xmlEmpList)
        {
            if (xmlEmpList.Count() > 0)
            {
                GVStudentDetail.DataSource = xmlEmpList;
                GVStudentDetail.DataBind();
            }
        }

        private void FillGridUsingDataTableLinq()
        {
            string path = Server.MapPath("XML/Books.xml");
            System.IO.StreamReader streamReader = new System.IO.StreamReader(path);

            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<Book>));
            List<Book> bookList = (List<Book>)serializer.Deserialize(streamReader);
           
            streamReader.Close();

            var books = from book in bookList
                        where book.Auther == "Govind Ballabh" || book.Auther == "Bhashkar Bhatt"
                        select book;

            System.Data.DataTable booksTable = CreateDataTable();
            DataRow myDataRow; 
            
            foreach (Book book in books)
            {
                myDataRow = booksTable.NewRow();
                myDataRow["BookID"] = book.BookID;
                myDataRow["Title"] = book.Title;
                myDataRow["Auther"] = book.Auther;
                myDataRow["Publication"] = book.Publication;
                myDataRow["ISBN"] = book.ISBN;
                booksTable.Rows.Add(myDataRow);
            }

            GVStudentDetail.DataSource = booksTable;
            GVStudentDetail.DataBind();
        }

        private void ReadXmlFillGridLinqToXml()
        {
            string path = Server.MapPath("XML/Books.xml");
            System.IO.StreamReader streamReader = new System.IO.StreamReader(path);

            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<Book>));
            List<Book> bookList = (List<Book>)serializer.Deserialize(streamReader);

            streamReader.Close();

            var books = from book in bookList
                        where book.Auther == "Govind Ballabh" || book.Auther == "Bhashkar Bhatt"
                        select book;


            var books1 = from book in bookList
                         where book.Auther == "Govind Ballabh" || book.Auther == "Bhashkar Bhatt"
                         select new
                         {
                             BookID = book.BookID,
                             Title = book.Title,
                             Auther = book.Auther,
                             Publication = book.Publication,
                             ISBN = book.ISBN
                         };

            GVStudentDetail.DataSource = books1;
            GVStudentDetail.DataBind();
        }

        private void WriteXmlUsingSerilizer()
        {
            List<Book> listBook = new List<Book>();

            var book1 = new Book
            {
                BookID = 1001,
                Title = "Programing in C",
                Publication = "TMH New Delhi",
                Auther = "Govind Ballabh",
                ISBN = "10098345"
            };

            var book2 = new Book
            {
                BookID = 1002,
                Title = "Programing in C++",
                Publication = "TMH New Delhi",
                Auther = "Govind Ballabh",
                ISBN = "10098345"
            };

            listBook.Add(book1);
            listBook.Add(book2);

            string path = Server.MapPath("XML/Books.xml");
            var streamWriter = new System.IO.StreamWriter(path);
            
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<Book>));
            serializer.Serialize(streamWriter, listBook);
            streamWriter.Close();
        }

        private System.Data.DataTable CreateDataTable()
        {
            DataTable booksTable = new DataTable("Books");
            DataColumn dtColumn;

            // Create BookID column  
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(UInt32);
            dtColumn.ColumnName = "BookID";
            dtColumn.Caption = "BookID";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = true;

            // Add column to the DataColumnCollection.  
            booksTable.Columns.Add(dtColumn);

            // Create Title column  
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Title";
            dtColumn.Caption = "Title";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = true;

            // Add column to the DataColumnCollection.  
            booksTable.Columns.Add(dtColumn);

            // Create Auther column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Auther";
            dtColumn.Caption = "Auther Name";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            
            // Add column to the DataColumnCollection.  
            booksTable.Columns.Add(dtColumn);

            // Create Publication column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Publication";
            dtColumn.Caption = "Publication";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            // Add column to the DataColumnCollection.    
            booksTable.Columns.Add(dtColumn);

            // Create ISBN column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "ISBN";
            dtColumn.Caption = "ISBN";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            
            // Add column to the DataColumnCollection.    
            booksTable.Columns.Add(dtColumn);

            // Make id column the primary key column.    
            booksTable.PrimaryKey = new DataColumn[] { booksTable.Columns["BookID"] };

            return booksTable;
        }
    }
}