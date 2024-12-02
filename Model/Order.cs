using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satis_Platformasi.Model
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public int Quantity { get; set; }

        public Order(int id, DateTime time, Product product, Customer customer, int quantity)
        {
            this.ID = id;
            this.Date = time;
            this.Product = product;
            this.Customer = customer;

        }
    }
}
