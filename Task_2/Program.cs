using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//Завдання 2
//Створити базовий клас «Пристрій» і похідні класи: 
//«Чайник», «Мікрохвильовка», «Автомобіль», «Пароплав». 
//За допомогою конструктора, встановити назву до кожного 
//пристрою і його характеристики.
//Реалізуйте для кожного з класів методи:
//■ Sound — видає звук пристрою (пишемо текстом у консоль);
//■ Show — відображає назву пристрою;
//■ Desc — відображає опис пристрою.
namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device[] device = { new Cattle("Brown", "White cattle with green line", 2022, 1),
                                new Microwave("Gorenie", "Black body with gray door", 2021, 5, 3.5),
                                new Car("BMW","White car, full aplication", 2020, 3, 18, 200)};
            foreach (var d in device)
            {
                d.Sound();
                d.ShowName();
                d.ShowDescription();
                Console.WriteLine(d.ToString());
                Console.WriteLine("\n\n");
            }

        }
    }
}
