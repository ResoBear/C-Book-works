using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;

            while(i >= 1)
            {
                if(i % 3 == 0 && i % 2 != 0)
                {
                    Console.WriteLine("Liczba podzielna przez 3, nie podzielna przez 2 to: {0}", i);   
                }
                i--;
            }
        }
    }
}
