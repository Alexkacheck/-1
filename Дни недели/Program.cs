using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дни_недели
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер дня недели (1-7): ");
            int day = Convert.ToInt32(Console.ReadLine());

            string[] days7 = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

            if (day >= 1 && day <= 7)
            {
                string dayName = days7[day - 1];
                Console.WriteLine($"День недели с порядковым номером {day} - это {dayName}");
            }
            else
            {
                Console.WriteLine("Нет такого дня недели. Введите число от 1 до 7.");
            }
        }
    }
}
