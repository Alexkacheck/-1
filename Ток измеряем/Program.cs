using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ток_измеряем
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сопротивление участка 1 (в омах): ");
            double o1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите напряжение на участке 1 (в вольтах): ");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сопротивление участка 2 (в омах): ");
            double o2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите напряжение на участке 2 (в вольтах): ");
            double v2 = Convert.ToDouble(Console.ReadLine());

            // по закону Омa I = U / R
            double c1 = v1 / o1;
            double c2 = v2 / o2;

            if (c1 < c2)
            {
                Console.WriteLine("Ток меньший на участке 1.");
            }
            else if (c1 > c2)
            {
                Console.WriteLine("Ток меньший на участке 2.");
            }
            else
            {
                Console.WriteLine("Токи на обоих участках равны.");
            }
        }
    }
}