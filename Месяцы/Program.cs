using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Месяцы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер месяца (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            string[] months = {
            "январь", "февраль", "март", "апрель",
            "май", "июнь", "июль", "август",
            "сентябрь", "октябрь", "ноябрь", "декабрь"
        };

            if (month >= 1 && month <= 12)
            {
                string monthName = months[month - 1];
                Console.WriteLine($"Месяц с номером {month} - это {monthName}");
            }
            else
            {
                Console.WriteLine("Нет такого месяца! Введите число от 1 до 12.");
            }
        }
    }
}
