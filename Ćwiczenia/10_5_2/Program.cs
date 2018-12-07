using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i++ < 20)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine("Liczba {0} jest parzysta.",i);
                }
                else
                {
                    Console.WriteLine("Liczba {0} jest nieparzysta.",i);
                }
            }
        }
    }
}
