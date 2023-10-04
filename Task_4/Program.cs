using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 4
//Створити абстрактний базовий клас Worker (працівник) 
//з методом Print(). Створіть чотири похідні класи: President,
//Security, Manager, Engineer. Перевизначте метод.
//Print() для виведення інформації, яка відповідає кожному типу працівника.
namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker[] worker = { new President("Aleks Ysik",35,10000,true,"Ukraine"),
                                new Security("Ivan Ivanov", 30, 500, false, "Pantera"),
                                new Manager("Vasiliy Proday",33, 700, false,"Kupi-Proday", 5),
                                new Engineer("Petr Konovalov", 45, 1000, true, "Building truth", 20)};
            foreach (var d in worker)
            {
                d.Print();
                Console.WriteLine("\n\n");
            }
        }
    }
}
