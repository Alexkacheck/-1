using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квадрат_периметр
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину стороны квадрата: ");
            double a = Convert.ToDouble(Console.ReadLine());

            double P = 4 * a;

            Console.WriteLine($"Периметр квадрата со стороной {a} равен {P}");
        }
    }
}
