using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satis_Platformasi.Model
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Customer(int id, string name, string surname, string email, string password)
        {
            this.ID = id;
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
        }
    }
}
