using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat punkt1 = new Prostokat();
            Prostokat punkt2 = new Prostokat();
            Prostokat punkt3 = new Prostokat();
            Prostokat punkt4 = new Prostokat();

            punkt1.x = 9;
            punkt1.y = 1;

            punkt2.x = 2;
            punkt2.y = 4;

            punkt3.x =  punkt3.PobierzX(punkt1.x);
            punkt3.y = punkt3.PobierzY(punkt2.y);

            punkt4.x = punkt4.PobierzX(punkt2.x);
            punkt4.y = punkt4.PobierzY(punkt1.y);

            punkt1.Wyswietl();
            punkt2.Wyswietl();
            punkt3.Wyswietl();
            punkt4.Wyswietl();
        }
    }
}
