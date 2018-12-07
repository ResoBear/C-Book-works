using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b;
            Console.WriteLine("a = {0}\n", a);
            b = a << 1; 
            Console.WriteLine("a = {0}\n", a);
            a = b | a;
            Console.WriteLine("a = {0}\n", a);
            //a <<= a;
           // Console.WriteLine("a = {0}\n", a);
        }
    }
}
