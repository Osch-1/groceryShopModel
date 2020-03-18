using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShop.Products
{
    class Fruit: Product
    {
        public string Vitamines;

        public Fruit(string name, double price, string manufacturer, string vitamines, int index)
        {
            this.Name = name;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Vitamines = vitamines;
            this.Index = index;
        }

        public override string ToString()
        {
            return "Фрукт";
        }

        public override void ToConsole()
        {
            base.ToConsole();
            Console.WriteLine($"Витамины: {this.Vitamines}");
            Console.WriteLine(new String('-', 25));
        }
    }
}
