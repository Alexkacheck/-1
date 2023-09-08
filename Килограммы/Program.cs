using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Килограммы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Фунты\tКилограммы");

            for (int pounds = 1; pounds <= 10; pounds++)
            {
                double kg = pounds * 0.453; 
                Console.WriteLine($"{pounds}\t{kg:F3}");
            }
        }
    }
}
