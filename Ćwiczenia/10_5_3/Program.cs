using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Liczba {0} jest parzysta", i);
                }
                else
                {
                    Console.WriteLine("Liczba {0} jest nieparzysta", i);
                }
            }
            while (i++ < 20);
        }
    }
}
