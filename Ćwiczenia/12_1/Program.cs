using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[10];
            int x = 100;
            int y = 0;

            for(int i = 0; i < tablica.Length; i++)
            {
                y = x + i;
                tablica[i] = y;
                Console.WriteLine(tablica[i]);
                
            }
            
        }
    }
}
