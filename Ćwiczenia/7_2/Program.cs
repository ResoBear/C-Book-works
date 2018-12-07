using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 256;
            int bit1, bit2;

            Console.WriteLine($"Number = {number}");

            bit1 = number << 2;
            Console.WriteLine($"Przesuniecie bitowe w lewo {bit1}");

            bit2 = number >> 2;
            Console.WriteLine($"Przesuniecie bitowe w prawo {bit2}");

            int a = number << 2;
            a = a >> 2;
            Console.WriteLine($"Alternatywa {a}");
            
        }
    }
}
