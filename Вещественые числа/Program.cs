using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вещественые_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое вещественное число: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе вещественное число: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine($"{n1} больше, чем {n2}");
            }
            else if (n1 < n2)
            {
                Console.WriteLine($"{n1} меньше, чем {n2}");
            }
            else
            {
                Console.WriteLine("Числа равны.");
            }
        }
    }
}
