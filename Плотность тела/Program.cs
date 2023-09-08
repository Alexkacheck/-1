using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Плотность_тела
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите массу тела в кг: ");
            double mass = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите объем тела в куб метрах: ");
            double volume = Convert.ToDouble(Console.ReadLine());

            double plot = mass / volume;

            Console.WriteLine($"Плотность материала тела: {plot} кг/куб метрах");
        }
    }
}
