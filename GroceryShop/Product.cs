using System;

namespace GroceryShop
{
    class Product
    {
        public string  Name { get; set; }
        public double Price { get; set; }
        public string Manufacturer { get; set; }

        public int Index { get; set; }

        public virtual double GetDiscountPrice(User user)
        {
            if (user.Spent < 300)
            {
                return Price;
            }

            if (user.Spent < 1000)
            {
                return Price * 0.9;
            }

            return Price * 0.85;
        }

        public virtual void ToConsole()
        {
            Console.WriteLine($"Номер товара: { this.Index}");
            Console.WriteLine($"Название: { this.Name} \n");
            Console.WriteLine($"Цена за единицу товара: { this.Price} \n");
            Console.WriteLine($"Производитель: { this.Manufacturer} \n");
        }
    }
}
