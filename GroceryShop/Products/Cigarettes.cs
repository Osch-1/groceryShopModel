using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShop.Products
{
    class Cigarettes: Product
    {
        public string NicotineMilligrams;
        public Cigarettes(string name, double price, string manufacturer, string nicotineMgs, int index)
        {
            this.Name = name;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.NicotineMilligrams = nicotineMgs;
            this.Index = index;
        }

        public override void ToConsole()
        {
            base.ToConsole();
            Console.WriteLine($"Количество никотина: {this.NicotineMilligrams}");
            Console.WriteLine(new String('-', 25));
        }
    }
}
