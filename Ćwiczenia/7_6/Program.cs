using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 33;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("A = {0}, B = {1}\n", a, b);

            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine("A = {0}, B = {1}\n", a, b);

        }
    }
}
