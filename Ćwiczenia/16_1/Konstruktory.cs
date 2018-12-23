using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_1
{
    class Konstruktory
    {
        public int liczba;

        public Konstruktory()
        {
            liczba = -2;
         
        }

        public Konstruktory(int liczba)
        {
            this.liczba = liczba;
        }

        public Konstruktory(Konstruktory punkt)
        {
            liczba = punkt.liczba;
        }

        public void Wypisz()
        {
            Console.WriteLine("Liczba: {0}",liczba);
        }

    }
}
