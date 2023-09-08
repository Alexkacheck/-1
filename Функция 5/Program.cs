using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Функция_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            double x = 12 * a * a + 7 * a - 16;

            Console.WriteLine($"Значение функции x = 12a^2 + 7a - 16 при a = {a} равно {x}");
        }
    }
}
