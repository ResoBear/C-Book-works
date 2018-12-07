using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Podaj liczbe a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj liczbe b:");
            b = Convert.ToInt32(Console.ReadLine());
            bool x;
            int y = a % b;
            switch (y)
            {
                case 0:
                    x = true;
                    break;

                default:
                    x = false;
                    break;
            }

            Console.WriteLine("Wynik: {0}", x);
        }
    }
}
