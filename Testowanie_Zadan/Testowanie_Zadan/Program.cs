using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testowanie_Zadan
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Punkt punkt1 = new Punkt();
            punkt1.x = 100;
            punkt1.y = 200;
            int wspX = punkt1.PobierzX();
            int wspY = punkt1.PobierzY();

            Console.WriteLine("Współżędna x = " + wspX);
            Console.WriteLine("Współżędna y = " + wspY);
        }
    }
}
