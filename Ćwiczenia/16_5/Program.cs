using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y, wys, szer;
            Console.WriteLine("Program podaje współżędne kwadratu po współżędnych Lewego górnego boku," +
                "Wysokości i szerokości");

            Console.WriteLine("Podaj x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj Wysokosc: ");
            wys = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj szerokosc: ");
            szer = Convert.ToInt32(Console.ReadLine());

            Kwadrat LewyGorny = new Kwadrat(x, y, wys, szer);

            LewyGorny.Wypisz();

        }
    }
}
