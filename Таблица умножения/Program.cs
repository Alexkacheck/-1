using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Таблица_умножения
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица умножения на 9:");

            for (int i = 1; i <= 9; i++)
            {
                int result = 9 * i;
                Console.WriteLine($"9 x {i} = {result}");
            }
        }
    }
}
