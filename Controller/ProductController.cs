using Satis_Platformasi.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satis_Platformasi.Controller
{
    public class ProductController
    {
        List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}
