using Satis_Platformasi.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satis_Platformasi.Controller
{
    public class CustomerController
    {
        List<Customer> Customer;

        public CustomerController()
        {
            Customer = new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            Customer.Add(customer);
        }
    }
}
