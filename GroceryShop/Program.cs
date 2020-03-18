using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryShop.Products;

namespace GroceryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(
                "Dan",
                "Йошкар-Ола, Сыктывкар",
                10000,
                0
                );

            Fruit apple = new Fruit(
                "Яблоко садовое, спелое, да короче",
                12.90,
                "Сосед",
                "C, B",
                1
                );

            Cigarettes bond = new Cigarettes(
                "Сигареты Бонд (с кнопкой)",
                228.0,
                "Philip Morris International",
                "10 мг в пачке",
                2
                );

            Drink pepsi = new Drink(
                "Pepsi кола",
                45,
                "PepsiCo",
                "С говном",
                3
                );

            Product[] products = new Product[]
            {
                apple,
                bond,
                pepsi
            };

            Informator informer = new Informator();

            while (true)
            {
                Console.WriteLine($"Здравствуйте, {user.Name}, ваш баланс - {user.Balance}, добро пожаловать в наш магазин \"Большой Эсс\"!");
                Console.WriteLine($"\nНе забудьте сигареты!\n");

                Console.WriteLine("Чтобы увидеть ассоритмент нажмите Enter");
                Console.WriteLine("Чтобы выйти нажмите Esc");
                ConsoleKeyInfo readedKeyInfo = Console.ReadKey();
                ConsoleKey readedKey = readedKeyInfo.Key;

                if (readedKey == ConsoleKey.Escape)
                {
                    break;
                }
                else if (readedKey == ConsoleKey.Enter)
                {
                    Console.Clear();

                    Console.WriteLine($"Количество кэша: {user.Balance}, потрачено: {user.Spent}");
                    Console.WriteLine("Наш ассортимент:\n");
                    foreach (Product product in products)
                    {
                        product.ToConsole();
                    }

                    Console.WriteLine("Введите номер товара и нажмите Enter: ");

                    string readedProductIndex = Console.ReadLine();
                    int productIndex = Convert.ToInt32(readedProductIndex);

                    informer.Buy(user, products[productIndex - 1]);
                }                                    
            }
        }
    }
}
