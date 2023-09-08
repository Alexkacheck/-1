using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Трамвай_3_задача
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер трамвайного билета 6-ое число: ");
            string ticket = Console.ReadLine();

            if (ticket.Length != 6)
            {
                Console.WriteLine("Номер билета состоит из 6 цифр.");
            }
            else
            {
                int sum1 = 0;
                int sum2 = 0;

                for (int i = 0; i < 6; i++)
                {
                    int d = Convert.ToInt32(ticket[i].ToString());

                    if (i < 3)
                    {
                        sum1 += d;
                    }
                    else
                    {
                        sum2 += d;
                    }
                }

                if (sum1 == sum2)
                {
                    Console.WriteLine("Этот билет счастливый)");
                }
                else
                {
                    Console.WriteLine("Этот билет не счастливый(");
                }
            }
        }
    }
}
