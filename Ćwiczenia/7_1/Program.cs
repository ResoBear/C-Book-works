using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = 3;
            b = 8 ;
            c = 7 ;

            int wynik = a % b % c;

            Console.WriteLine("Wynik {0}", wynik);
        }
    }
}
