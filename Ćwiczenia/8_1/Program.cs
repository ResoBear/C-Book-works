using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 3;

            if (a % b == 0)
            {
                Console.WriteLine("Dzielenie modulo wynosi 0.");
            }
            else
            {
                Console.WriteLine("Dzielenie modulo nie wynosi 0.");
            }
        }
    }
}
