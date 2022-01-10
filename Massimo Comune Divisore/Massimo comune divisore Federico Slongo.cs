using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massimo_Comune_Divisore
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            do
            {
                Console.WriteLine("Insert the first number");
            } while (!int.TryParse(Console.ReadLine(), out a));

            do
            {
                Console.WriteLine("Insert the second number");
            } while (!int.TryParse(Console.ReadLine(), out b));

            do
            {
                if (a == b)
                {
                }
                else
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
            } while (!(a == b));

            Console.WriteLine($"{a} is the greatest common factor");

            Console.ReadKey();
        }
    }
}
