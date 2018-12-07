using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 20; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine("Liczba {0}, jest parzysta",i);
                }
                else
                {
                    Console.WriteLine("Liczba {0}, jest nieparzysta", i);
                }
            }
        }
    }
}
