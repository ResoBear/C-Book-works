using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 10;
            int wynikBit;
            wynikBit = a | b; 
            Console.WriteLine("Suma bitowa a = {0},  b = {1} wynosi {2}", a, b, wynikBit);


            wynikBit = a & b;
            Console.WriteLine("Iloczyn bitowy a = {0} , b = {1} wynosi {2}", a, b, wynikBit);
        }
    }
}
