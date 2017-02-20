using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lady
{
    using System;

    class Lady
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of a cock that you want:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n * 2; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string(' ', n));
                    Console.Write("||");
                    Console.Write(new string('-', (n / 2) - 2));
                    if ((n & 1) == 0)
                    {
                        Console.Write("||");
                    }
                    else
                    {
                        Console.Write("|-|");
                    }
                    Console.Write(new string('-', (n / 2) - 2));
                    Console.WriteLine("||");
                }
                else if (i == n / 2)
                {
                    Console.Write(new string(' ', n));
                    Console.Write("||");
                    Console.Write(new string('-', n - 2));
                    Console.WriteLine("||");
                }

                else if (i > (n / 2) && i < (n * 2) - 2)
                {
                    Console.Write(new string(' ', n));
                    Console.Write("||");
                    Console.Write(new string(' ', n - 2));
                    Console.WriteLine("||");
                }

                else if (i == (n * 2) - 2)
                { 
                    Console.Write(" ");
                    Console.Write(new string('@', n - 1));
                    Console.Write(new string('-', n + 2));
                    Console.WriteLine(new string('@', n - 1));
                }
                else if (i >= (n * 2) - 3)
                {
                    Console.Write(" ");
                    Console.Write("@");
                    Console.Write(new string('-', (3 * n) - 2));
                    Console.WriteLine("@");
                }
              
            }
            Console.WriteLine("This is a nice dick for YOU! Smileee :)))");
            Console.ReadLine();
        }
    }
}
