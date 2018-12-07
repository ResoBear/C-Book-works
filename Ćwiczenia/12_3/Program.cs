using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = false;
            bool[] tablica = new bool[20];

            for(int i = 0; i < tablica.Length; i++)
            {
                if(i % 2 == 0)
                {
                    x = true;
                    tablica[i] = x;
                }
                else
                {
                    x = false;
                    tablica[i] = x;
                }

                Console.WriteLine("Tablica {0}, liczba {1}",tablica[i],i+1);
            }
        }
    }
}
