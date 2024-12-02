using Satis_Platformasi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satis_Platformasi.Model
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int SellQuantity{ get; set; }
        public ProductCategory Category { get; set; }

        public Product(int id, string name, int price, int quantity, int sellquantity, ProductCategory category)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.SellQuantity = sellquantity;
            this.Category = category;
        }
    }
}
