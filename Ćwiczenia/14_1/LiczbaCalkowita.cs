using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1
{
    class LiczbaCalkowita
    {
        int x;


        int Conv()
        {
            int y = x * x;
            return y;
        }

        public int Podaj()
        {
            Console.WriteLine("Podaj x:");
            x = Convert.ToInt32(Console.ReadLine());
            x = Conv();
            return x;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Wynik: {0}", x);
            Pisz();
        }
        void Pisz()
        {

            Console.WriteLine(Conv());
        }
    }
}
