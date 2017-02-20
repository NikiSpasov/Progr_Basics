using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int x = 0;
        int y = 0;
        if (n % 2 == 0)
        {
            for (int i = 0; i < n / 2; i++)
            {              
                Console.Write(new string('-', (n - 2) / 2 - x));
                Console.Write(new string('*', 2 + y));
                Console.WriteLine(new string('-', (n - 2) / 2 - x));
                x += 1;
                y += 2;
                if (i == (n / 2) - 1)
                {
                    for (int j = 0; j < n / 2; j++)
                    {
                        Console.Write("|");
                        Console.Write(new string('*', n - 2));
                        Console.WriteLine("|");
                    }
                }
               
            }
        }
        else
        {
            for (int i = 0; i < (n / 2) + 1; i++)
            {
                Console.Write(new string('-', (n - 1) / 2 - x));
                Console.Write(new string('*', 1 + y));
                Console.WriteLine(new string('-', (n - 1) / 2 - x));
                x += 1;
                y += 2;
                if (i == (n / 2))
                {
                    for (int j = 0; j < n / 2; j++)
                    {
                        Console.Write("|");
                        Console.Write(new string('*', n - 2));
                        Console.WriteLine("|");
                    }
                }
            }
        }
    }
}