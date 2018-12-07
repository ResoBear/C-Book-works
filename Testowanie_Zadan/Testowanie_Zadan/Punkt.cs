using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testowanie_Zadan
{
    class Punkt
    {
        public int x;
        public int y;

        public int PobierzX()
        {
            return x;
        }

        public int PobierzY()
        {
            return y;
        }

        void WyswietlWspolrzedne()
        {
            Console.WriteLine("Współżędna x = " + x);
            Console.WriteLine("Współżędna y = " + y);
        }
    }
}
