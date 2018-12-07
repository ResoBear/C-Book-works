using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Podaj liczbę całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a >=0)
            {
                Console.WriteLine("Liczba bezwzględna {0}", a);
            }
            else
            {
                a = -a;
                Console.WriteLine("Liczba bezwzględna {0}", a);
            }
        }
    }
}
