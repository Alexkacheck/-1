using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace функция_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = 7 * x * x - 3 * x + 6;

            Console.WriteLine($"Значение функции y = 7x^2 - 3x + 6 при x = {x} равно {y}");
        }
    }
}
