using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShop
{
    class User
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public double Balance { get; set; }

        public double Spent { get; set; }

        public User(string name, string adress, int balance, int spent)
        {
            this.Name = name;
            this.Adress = adress;
            this.Balance = balance;
            this.Spent = spent;
        }

        public void reduceBalance(double price)
        {
            this.Balance -= price;
            this.Spent += price;
        }
        

    }
}
