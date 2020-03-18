using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShop
{
    class Informator
    {
        public void Buy(User user, Product product)
        {
            double price = product.GetDiscountPrice(user);
            user.reduceBalance(price);
            Console.WriteLine(new String('-', 25));
            Console.WriteLine($"{user.Name} купил {product.Name} за {price}. Заказ отправлен в распределительный отдел магазина");
            Console.WriteLine(new String('-', 25));
        }
    }
}
