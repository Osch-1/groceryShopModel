using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShop.Products
{
    class Drink: Product
    {
        public string Syroup;

        public Drink(string name, double price, string manufacturer, string syroup, int index)
        {
            this.Name = name;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Syroup= syroup;
            this.Index = index;
        }

        public override void ToConsole()
        {
            base.ToConsole();
            Console.WriteLine($"Сироп: {this.Syroup}");
            Console.WriteLine(new String('-', 25));
        }
    }
}
