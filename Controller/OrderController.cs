using Satis_Platformasi.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satis_Platformasi.Controller
{
    public class OrderController
    {
        List<Order> orders = new List<Order>();


        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
    }
}
