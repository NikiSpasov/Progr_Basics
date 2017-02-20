using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int y = 0;
        int z = 0;
        int b = 0;
        int k = 0;

        if (n % 2 == 0)
        {
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('-', (n - 2) / 2 - i));
                Console.Write("*");
                Console.Write(new string('-', z));
                Console.Write("*");
                Console.WriteLine(new string('-', (n - 2) / 2 - i));

                z += 2;

                if (i == (n / 2) - 1)
                {
                    for (int j = 0; j < n / 2 - 1; j++)
                    {
                        Console.Write(new string('-', 1 + j));
                        Console.Write("*");
                        Console.Write(new string('-', (n - 4) - b));
                        Console.Write("*");
                        Console.WriteLine(new string('-', 1 + j));

                        b += 2;
                    }
                }

            }

        }
        else
        {
            Console.Write(new string('-', (n / 2)));
            Console.Write("*");
            Console.WriteLine(new string('-', (n / 2)));

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('-', (n / 2) - (i + 1)));
                Console.Write("*");
                Console.Write(new string('-', y + 1));
                Console.Write("*");
                Console.WriteLine(new string('-', (n / 2) - (i + 1)));
                y += 2;

                if (i == (n / 2) - 1)
                {
                    for (int j = 0; j < n / 2 - 1; j++)
                    {
                        Console.Write(new string('-', 1 + j));
                        Console.Write("*");
                        Console.Write(new string('-', (n - 4) - k));
                        Console.Write("*");
                        Console.WriteLine(new string('-', 1 + j));

                        k += 2;
                    }
                    Console.Write(new string('-', (n / 2)));
                    Console.Write("*");
                    Console.WriteLine(new string('-', (n / 2)));
                }

            }
        }
    }
}


