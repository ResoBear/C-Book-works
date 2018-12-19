using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_5
{
    class Prostokat
    {
        public int x;
        public int y;


        public int PobierzX(int pobrana)
        {
            int x = pobrana;
            return x;
        }
        public int PobierzY(int pobrana)
        {
            int y = pobrana;
            return y;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Współżędna x = {0}", x);
            Console.WriteLine("Współżędna y = {0}", y);
            Console.WriteLine();
        }
    }
}
