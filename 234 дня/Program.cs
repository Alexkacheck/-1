using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _234_дня
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = 234; 

            int weeks = days / 7; 

            Console.WriteLine($"За {days} дней прошло {weeks} полных недель.");
        }
    }
}
