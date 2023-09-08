using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_задание_сумма
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите число 1: ");
            int s = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число 2: ");
            int d = Convert.ToInt32(Console.ReadLine());

            int f = s + d;
            Console.WriteLine("Суммы чисел {0} и {1} равна {2}", s, d, f);
        }
    }
}
