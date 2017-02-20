using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //first row:
        Console.Write(new string('*', 2 * n));
        Console.Write(new string(' ', n));
        Console.Write(new string('*', 2 * n));
        Console.WriteLine();

        //middle:
        for (int r = 1; r <= n - 2; r++)
        {
            Console.Write("*");
            Console.Write(new string('/', (n * 2) - 2));
            Console.Write("*");
            if (n % 2 == 0 && r == n / 2 - 1)
            {
                Console.Write(new string('|', n));
            }
            else if (n % 2 != 0 && r == (n / 2))
            {
                Console.Write(new string('|', n));
            }
            else
            {
                Console.Write(new string(' ', n));
            }
            Console.Write("*");
            Console.Write(new string('/', (n * 2) - 2));
            Console.Write("*");

            Console.WriteLine();
        }


        ////last row:
        Console.Write(new string('*', 2 * n));
        Console.Write(new string(' ', n));
        Console.Write(new string('*', 2 * n));
        Console.WriteLine();

    }
}