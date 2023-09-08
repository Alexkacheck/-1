using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Времена_года
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите месяца 1-12: ");
            int month = Convert.ToInt32(Console.ReadLine());

            string season = "";

            if (month >= 1 && month <= 12)
            {
                if (month >= 3 && month <= 5)
                {
                    season = "Весна";
                }
                else if (month >= 6 && month <= 8)
                {
                    season = "Лето";
                }
                else if (month >= 9 && month <= 11)
                {
                    season = "Осень";
                }
                else
                {
                    season = "Зима";
                }

                Console.WriteLine($"Месяц {month}  времени года: {season}");
            }
            else
            {
                Console.WriteLine("Неправильно введите  от 1 до 12.");
            }
        }
    }
}
