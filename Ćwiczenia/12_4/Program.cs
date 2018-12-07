using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[100];
            

            for(int i = 0; i < tablica.Length; i++)
            {
                if(i % 10 == 0)
                {
                    
                    tablica[i] = 0;
                    tablica[i + 1] = 1;
                    tablica[i + 2] = 2;
                    tablica[i + 3] = 3;
                    tablica[i + 4] = 4;
                    tablica[i + 5] = 5;
                    tablica[i + 6] = 6;
                    tablica[i + 7] = 7;
                    tablica[i + 8] = 8;
                    tablica[i + 9] = 9;


                }
                Console.WriteLine("Tablica {0}, liczba {1}", tablica[i], i);
                
            }
        }
    }
}
