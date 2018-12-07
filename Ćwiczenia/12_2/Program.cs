using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablicz = new int[11];
            int x = 10;

            for(int i = 1; i < tablicz.Length; i++)
            {
                int y = x * i;
                tablicz[i] = y;
                Console.WriteLine(tablicz[i]);
            }
        }
    }
}
