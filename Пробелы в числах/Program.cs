using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пробелы_в_числах
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{number1}  {number2}  {number3}");
        }
    }
}
