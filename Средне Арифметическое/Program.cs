using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Средне_Арифметическое
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое целое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе целое число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            // Среднее арифметическое
            double sredArifmet = (a + b) / 2.0;

            // Среднее геометрическое 
            double sredGeomet = Math.Sqrt(a * b);

            Console.WriteLine($"Среднее арифметическое: {sredArifmet}");
            Console.WriteLine($"Среднее геометрическое: {sredGeomet}");
        }
    }
}
