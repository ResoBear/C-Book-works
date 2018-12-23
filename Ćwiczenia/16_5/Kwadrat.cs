using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_5
{
    class Kwadrat
    {
        int x,y;
        int wys, szer;

        public Kwadrat(int LewyGornyX, int LewyGornyY, int wysokosc, int szerokosc) // pobieranie danych
        {
            x = LewyGornyX;
            y = LewyGornyY;

            wys = wysokosc;
            szer = szerokosc;

        }

        int LewyY(int y, int wys) //Obliczenie Lewego Y
        {
            int Ly = y - wys;
            return Ly;
        }

        int PrawyX(int x, int szer) //Obliczenie Prawego X
        {
            int Px = x + szer;
            return Px;
        }

        void PrawyDolny() // Prawy dolny bok
        {

            Console.WriteLine("Prawy Dolny: \nx = {0}\ny = {1}\n", PrawyX(x , szer) ,LewyY(y,wys));
        }

        void LewyDolny() // Lewy dolny bok
        {

            Console.WriteLine("Lewy Dolny: \nx = {0}\ny = {1}\n", x, LewyY(y,wys));
        }

        void PrawyGórny() // Prawy Górny bok
        {

            Console.WriteLine("Prawy Górny: \nx = {0}\ny = {1}\n", PrawyX(x, szer), y);
        }

        void LewyGorny()
        {
            Console.WriteLine("Lewy Górny: \nx = {0}\ny = {1}\n", x, y);
        }
        public void Wypisz() // Wypisanie wszystkiego
        {
            LewyGorny();
            LewyDolny();
            PrawyGórny();
            PrawyDolny();


        }
    }
}
