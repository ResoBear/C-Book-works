using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] tab = new int[4][];
            tab[0] = new int[4];
            tab[1] = new int[2];
            tab[2] = new int[1];
            tab[3] = new int[3];

            int licznik = 10;

            for(int i = 0; i < tab.Length; i++)
            {
                for(int j = 0; j < tab[i].Length; j++)
                {
                    tab[i][j] = licznik--;
                }
            }

            for(int i = 0; i < tab.Length; i++)
            {
                Console.Write("Tab{0} = ", i);

                for(int j = 0; j < tab[i].Length; j++)
                {
                    Console.Write(" {0} ", tab[i][j]);
                }
                Console.WriteLine("");
            }
        }
    }
}
