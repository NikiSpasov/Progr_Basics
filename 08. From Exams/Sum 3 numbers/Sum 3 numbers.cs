using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_3_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b == c)
            {
                if (a >= b)
                {
                    Console.WriteLine("{0} + {1} = {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2}", a, b, c);
                }
            }
            else if (c + a == b)
            {
                if (c >= a)
                {
                    Console.WriteLine("{0} + {1} = {2}", a, c, b);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2}", c, a, b);
                }
            }
            else if (c + b == a)
            {
                if (c >= b)
                {
                    Console.WriteLine("{0} + {1} = {2}", b, c, a);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2}", c, b, a);
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}