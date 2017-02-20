using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('-', 3 * n));
            Console.Write("*");
            Console.Write(new string('-', i));
            Console.Write("*");
            Console.WriteLine(new string('-', (2 * n) - (2 + i)));
        }
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('*', (3 * n) + 1));
            Console.Write(new string('-', n - 1));
            Console.Write("*");
            Console.WriteLine(new string('-', n - 1));
        }
        for (int i = 0; i < n / 2; i++)
        {
            if (i == (n / 2) - 1)
            {
                if (n % 2 == 0)
                {
                    Console.Write(new string('-', (4 * n - (n - 1)) - (n / 2)));
                    Console.Write(new string('*', (2 * n) - 1));
                    Console.WriteLine(new string('-', n / 2));
                }
                else
                {
                    Console.Write(new string('-', (4 * n - (n - 1)) - (n / 2)));
                    Console.Write(new string('*', (2 * n) - 2));
                    Console.WriteLine(new string('-', n / 2 + 1));
                }
            }
            else
            {
                Console.Write(new string('-', 3 * n - i));
                Console.Write("*");
                Console.Write(new string('-', (n - 1) + (2 * i)));
                Console.Write("*");
                Console.WriteLine(new string('-', n - 1 - i));
            }

        }
    }
}
