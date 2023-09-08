using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ложь_или_правда
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X = Ложь, Y = Истина, Z = Ложь:"); 
            bool X = false;  // Ложь
            bool Y = true;   // Истина
            bool Z = false;  // Ложь

            // a. X или Z
            bool resultA = X || Z;
            Console.WriteLine(t/,"X или Z: " + resultA);

            // b. X и Y
            bool resultB = X && Y;
            Console.WriteLine("X и Y: " + resultB);

            // c. X и Z
            bool resultC = X && Z;
            Console.WriteLine("X и Z: " + resultC);
        }
    }
}
