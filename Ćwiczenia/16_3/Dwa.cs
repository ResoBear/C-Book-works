using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_3
{
    class Dwa
    {
        public double numberA;
        public char charB;
        
        public Dwa(double a)
        {
            numberA = a;
            Console.WriteLine(numberA);
        }

        public Dwa(char b)
        {
            charB = b;
            Console.WriteLine(charB);
        }

        public Dwa(double a, char b)
        {
            numberA = a;
            charB = b;
            Console.WriteLine(numberA + " " + charB);
        }

        public Dwa(char b, double a)
        {
            this.charB = b;
            this.numberA = a;
            Console.WriteLine(charB + " " + numberA);
        }



    }
}
