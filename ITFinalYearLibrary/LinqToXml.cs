using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ITFinalYearLibrary
{
    public class LinqToXml
    {
        public LinqToXml() { }

        
        public string CreateXmlDocument(string fileVirtualPath, string ItemID, string ItemName, string Specification, string Price, string Quantity)
        {
            XDocument xmlDocument = new XDocument(new XDeclaration("1.0", "utf-16", "yes"));

            XElement xmlElement = new XElement("StoreItems",
                new XElement("Item", new XAttribute("ID", ItemID),
                new XElement("Name", ItemName),
                new XElement("Specification", Specification),
                new XElement("Price", Price),
                new XElement("Quantity", Quantity)
                ));
         
            xmlDocument.Add(xmlElement);
            
            xmlDocument.Save(fileVirtualPath, SaveOptions.None);
            
            return "XmlDocument Created";
        }

        public string InsertXmlElementAtLast(string fileVirtualPath, string ItemID, string ItemName, string Specification, string Price, string Quantity)
        {
            XDocument xmlDocument = XDocument.Load(fileVirtualPath);
            xmlDocument.Element("StoreItems").Add(new XElement("Item", new XAttribute("ID", ItemID),
                                                new XElement("Name", ItemName),
                                                new XElement("Specification", Specification),
                                                new XElement("Price", Price),
                                                new XElement("Quantity", Quantity)
                                                ));

            xmlDocument.Save(fileVirtualPath, SaveOptions.None);
            
            return "Element Added Successfuly";
        }

        public string InsertXmlElementAtFirst(string fileVirtualPath, string ItemID, string ItemName, string Specification, string Price, string Quantity)
        {
            XDocument xmlDocument = XDocument.Load(fileVirtualPath);
            xmlDocument.Element("StoreItems").AddFirst(new XElement("Item", new XAttribute("ID", ItemID),
                                                new XElement("Name", ItemName),
                                                new XElement("Specification", Specification),
                                                new XElement("Price", Price),
                                                new XElement("Quantity", Quantity)
                                                ));

            xmlDocument.Save(fileVirtualPath, SaveOptions.None);

            return "Element Added Successfuly";
        }

        public string InsertXmlElementBefore(string fileVirtualPath, string InsertBeforeItemID, string ItemID, string ItemName, string Specification, string Price, string Quantity)
        {
            XDocument xmlDocument = XDocument.Load(fileVirtualPath);
            xmlDocument.Element("StoreItems").Elements("Item")
                .Where(item => item.Attribute("ItemId").Value == ItemID).FirstOrDefault()
                .AddBeforeSelf(new XElement("Item", new XAttribute("ID", ItemID),
                                                new XElement("Name", ItemName),
                                                new XElement("Specification", Specification),
                                                new XElement("Price", Price),
                                                new XElement("Quantity", Quantity)
                                                ));

            xmlDocument.Save(fileVirtualPath, SaveOptions.None);

            return "Element Added Successfuly";
        }

        public string InsertXmlElementAfter(string fileVirtualPath, string InsertAfterItemID, string ItemID, string ItemName, string Specification, string Price, string Quantity)
        {
            XDocument xmlDocument = XDocument.Load(fileVirtualPath);
            xmlDocument.Element("StoreItems").Elements("Item")
                .Where(item => item.Attribute("ItemId").Value == InsertAfterItemID).FirstOrDefault()
                .AddAfterSelf(new XElement("Item", new XAttribute("ID", ItemID),
                                                new XElement("Name", ItemName),
                                                new XElement("Specification", Specification),
                                                new XElement("Price", Price),
                                                new XElement("Quantity", Quantity)
                                                ));

            xmlDocument.Save(fileVirtualPath, SaveOptions.None);

            return "Element Added Successfuly";
        }

        public IEnumerable<object> ReadXmlDocument(string fileVirtualPath)
        {
            XDocument xmlDocument = XDocument.Load(fileVirtualPath);
            IEnumerable<object> items = from item in xmlDocument.Element("Store").Elements("Item")
            select new
            {
                ItemID = item.Attribute("ItemId").Value,
                ItemName = item.Element("ItemName").Value,
                Specification = item.Element("Specification").Value,
                UnitPrice = item.Element("UnitPrice").Value,
                Balance = item.Element("QuantityBalance").Value
            };

            return items;
        }
        
        public string UpdateXmlSpecification(string fileVirtualPath, string ItemID, string Specification)
        {
            XDocument xmlDocument = XDocument.Load(fileVirtualPath);

            // Method 1
            //xmlDocument.Element("StoreItems").Elements("Item")
            //                             .Where(item => item.Attribute("ID").Value == ItemID).FirstOrDefault()
            //                             .SetAttributeValue("Specification", Specification);

            // Method 2
            //(from item in xmlDocument.Element("StoreItems").Elements("Item")
            //where item.Attribute("ID").Value == ItemID
            //select item).FirstOrDefault().SetElementValue("Specification", Specification);

            // Method 3
            var items = from item in xmlDocument.Element("StoreItems").Elements("Item")
                        where item.Attribute("ID").Value == ItemID
                        select item;

            var book = items.FirstOrDefault();
            book.SetElementValue("Specification", Specification);
            
            xmlDocument.Save(fileVirtualPath);
            
            return "Element Updated Successfully";
        }

        public string UpdateXmlElement(string fileVirtualPath, string ItemID, string ItemName, string Specification, string Price, string Quantity)
        {
            XDocument xmlDocument = XDocument.Load(fileVirtualPath);

            var items = from item in xmlDocument.Element("StoreItems").Elements("Item")
                        where item.Attribute("ID").Value == ItemID
                        select item;

            var book = items.FirstOrDefault();
            book.SetElementValue("Name", ItemName);
            book.SetElementValue("Specification", Specification);
            book.SetElementValue("Quantity", Quantity);
            book.SetElementValue("Price", Price);

            xmlDocument.Save(fileVirtualPath);

            return "Element Updated Successfully";
        }
    }
}
