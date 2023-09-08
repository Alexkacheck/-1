using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Окружность_радиус
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус окружности ");
            double r = Convert.ToDouble(Console.ReadLine());
            double d = r * 2;
            Console.WriteLine($"Диаметр окружности с радиусом {r} равен  диаметру: {d}");
        }
    }
}
