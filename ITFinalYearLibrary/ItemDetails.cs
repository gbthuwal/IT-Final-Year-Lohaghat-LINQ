using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITFinalYearLibrary
{
    public class ItemDetails
    {
        private int _ItemId;
        public int ItemId 
        {
            get 
            { 
                return _ItemId; 
            }
            set 
            {
                _ItemId=value;
            }
        }

        public string ItemName { get; set; }
        public string ItemSpecification { get; set; }
        public string ItemMake { get; set; }
        public short ItemMFDYear { get; set; }
        public DateTime ItemPurchasedOn { get; set; }
        public int ItemUnitPrice { get; set; }

        public static List<ItemDetails> GetDetailsAllItems()
        {
            List<ItemDetails> itemList = new List<ItemDetails>();

            itemList.Add(new ItemDetails
            {
                ItemId = 1,
                ItemName = "Network Switch",
                ItemSpecification = "24 Port Managable",
                ItemMake = "DLink",
                ItemMFDYear = 2018,
                ItemPurchasedOn = DateTime.Now,
                ItemUnitPrice = 23490
            });

            itemList.Add(new ItemDetails
            {
                ItemId = 1,
                ItemName = "Network Router",
                ItemSpecification = "8 Port Support IPV6",
                ItemMake = "CISCO",
                ItemMFDYear = 2019,
                ItemPurchasedOn = DateTime.Now,
                ItemUnitPrice = 143400
            });
            itemList.Add(new ItemDetails
            {
                ItemId = 2,
                ItemName = "Computer Desktop",
                ItemSpecification = "Intel Core i5 11th Gen, 500GB SSD, 16GB RAM",
                ItemMake = "HP India Ltd",
                ItemMFDYear = 2018,
                ItemPurchasedOn = DateTime.Now,
                ItemUnitPrice = 55600
            });

            itemList.Add(new ItemDetails
            {
                ItemId = 3,
                ItemName = "Printer Heavy Duty",
                ItemSpecification = "Colored Laserjet, 1800 dpp, 20PPM",
                ItemMake = "Canon India Ltd",
                ItemMFDYear = 2020,
                ItemPurchasedOn = DateTime.Now,
                ItemUnitPrice = 23490
            });

            itemList.Add(new ItemDetails
            {
                ItemId = 4,
                ItemName = "Computer Desktop",
                ItemSpecification = "Intel Core i7 11th Gen, 500GB SSD, 16GB RAM",
                ItemMake = "Dell India Ltd",
                ItemMFDYear = 2020,
                ItemPurchasedOn = DateTime.Now,
                ItemUnitPrice = 63490
            });

            itemList.Add(new ItemDetails
            {
                ItemId = 5,
                ItemName = "Digital Camera",
                ItemSpecification = "DSLR, 50MP, 25X Zoom, 30 FPS Video",
                ItemMake = "Canon",
                ItemMFDYear = 2019,
                ItemPurchasedOn = DateTime.Now,
                ItemUnitPrice = 23490
            });

            itemList.Add(new ItemDetails
            {
                ItemId = 6,
                ItemName = "Blade Server",
                ItemSpecification = "64GB RAM, 15TB HDD, 10GB SSD, Intel Core i7 11th Gen, Linux Red Hat",
                ItemMake = "IBM India Ltd",
                ItemMFDYear = 2018,
                ItemPurchasedOn = DateTime.Now,
                ItemUnitPrice = 23490
            });

            itemList.Add(new ItemDetails
            {
                ItemId = 7,
                ItemName = "Proxy Server",
                ItemSpecification = "32GB RAM, 5TB HDD, 5GB SSD, Intel Core i7 11th Gen, Linux Red Hat",
                ItemMake = "IBM India Ltd",
                ItemMFDYear = 2017,
                ItemPurchasedOn = DateTime.Now,
                ItemUnitPrice = 23490
            });

            itemList.Add(new ItemDetails
            {
                ItemId = 8,
                ItemName = "Mail Server",
                ItemSpecification = "24GB RAM, 5TB HDD, 6GB SSD, Intel Core i7 11th Gen, Linux Red Hat",
                ItemMake = "IBM India Ltd",
                ItemMFDYear = 2017,
                ItemPurchasedOn = DateTime.Now,
                ItemUnitPrice = 23490
            });

            return itemList;
        }
    }
}
