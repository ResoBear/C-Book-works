using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int xa = 2, xb = 1, ya = 2, yb = 2;

            if(xa == xb & ya != yb )
            {
                Console.WriteLine("Prosta jest równoległa do osi OY");
            }
            else if(ya == yb & xa != xb)
            {
                Console.WriteLine("Prosta jest równoległa do osi OX");
            }
            else
            {
                Console.WriteLine("Błąd");
            }
        }
      
    }
}
