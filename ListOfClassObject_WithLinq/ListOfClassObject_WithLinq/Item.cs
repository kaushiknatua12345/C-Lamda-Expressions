using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfClassObject_WithLamda
{
    public class Item
    {
        public int ItemCode { get; set; }
        public string ItemType { get; set; }
        public double Price { get; set; }
        public string BrandName { get; set; }

        public Item()
        {

        }

        public Item(int itemCode, string itemType, double price, string brandName)
        {
            ItemCode = itemCode;
            ItemType = itemType;
            Price = price;
            BrandName = brandName;
        }

        //-20 will be used to give 20 spaces between 2 data ex: ItemCode 20spaces ItemType 20spaces....

        public override string ToString()
        {
            return string.Format("{0,-20}{1,-20}{2,-20}{3}", ItemCode, ItemType, BrandName, Price);
        }
    }  
}
