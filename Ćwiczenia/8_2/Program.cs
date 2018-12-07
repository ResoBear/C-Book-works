using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdza ile równanie kwadratowe ma rozwiązań.");

            int a, b, c;

            Console.WriteLine("Podaj a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj c:");
            c = Convert.ToInt32(Console.ReadLine());

            int delta = (b * b) - 4 * a * c;

            if (delta > 0)
            {
                Console.WriteLine("Równanie kadratowe ma dwa rozwiązania x");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Równanie kadratowe ma jedno rozwiązanie x");
            }
            else
            {
                Console.WriteLine("Równanie kadratowe nie ma rozwiązań");
            }
            
        }
    }
}
