using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 1
//Запрограмуйте клас Money (об'єкт класу оперує однією валютою) для роботи з грошима.
//У класі мають бути передбачені: поле для зберігання цілої частини грошей (долари, євро, гривні тощо) і поле 
//для зберігання копійок (центи, євроценти, копійки тощо)
//Реалізувати методи виведення суми на екран, задання значень частин. 
//На базі класу Money створити клас Product для роботи з продуктом або товаром.
//Реалізувати метод, який дозволяє зменшити ціну на задане число.
//Для кожного з класів реалізувати необхідні методи і поля.
namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products ={ new Product ( 12.5555555, "Cleaning brush", "Cleaning tools"),
                                  new Product ( 13.5456, "Washing table", "Cleaning tools"),
                                  new Product ( 45,1080, "Handle", "Bycicle parts"),
                                  new Product ( 35.5445, "Button", "Electronics"),
                                  new Product ( 12.50, "Tire", "Avtomotion")};
            Console.WriteLine("\n\tList of the Products:\n");
            foreach (var a in products)
            {
                Console.WriteLine(a.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("\n\tReduce products price on 1.5:\n");
            foreach (var a in products)
            {
                a.ReducePrice(1.5);
                Console.WriteLine(a);
            }

            Money money = new Money(350, 45);
            Money money1 = new Money(200, 60);
            Console.WriteLine($"\nObjects Money:\n\tmoney = {money}\tmoney1 = {money1}");
            Console.WriteLine($"Their summ:\n\tmoney+money1 = {Money.Summ(money, money1)}");
        }
    }
}
