using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            int a = Convert.ToInt32(Console.ReadLine());

            switch(a)
            {
                case 1:
                    Console.WriteLine("Sytyacja A");
                    break;

                case 4:
                    Console.WriteLine("Sytyacja A");
                    break;

                case 8:
                    Console.WriteLine("Sytyacja A");
                    break;

                case 3:
                    Console.WriteLine("Sytyacja B");
                    break;

                case 2:
                    Console.WriteLine("Sytyacja B");
                    break;

                case 7:
                    Console.WriteLine("Sytyacja B");
                    break;

                default:
                    Console.WriteLine("Żadna sytuacja");
                    break;
            }
        }
    }
}
