using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Konstruktory punkt1 = new Konstruktory(188);
            punkt1.Wypisz();

            Konstruktory punkt0 = new Konstruktory();
            punkt0.Wypisz();

            Konstruktory punkt2 = new Konstruktory(punkt1);
            punkt2.Wypisz();
        }
    }
}
