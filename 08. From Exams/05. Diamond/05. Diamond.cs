using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int cnt = 0;
        //top line:
        Console.Write(new string('.', n));
        Console.Write(new string('*', 3 * n));
        Console.WriteLine(new string('.', n));
        //to the middle:
        for (int row = 1; row <= n - 1; row++)
        {
            Console.Write(new string('.', n - row));
            Console.Write("*");
            Console.Write(new string('.', ((3 * n) + cnt)));
            Console.Write("*");
            Console.WriteLine(new string('.', n - row));
            cnt += 2;
        }

        //midle Line:
        Console.WriteLine(new string('*', 5 * n));

        ////to the bottom:
        for (int row = 1; row <= (2 * n); row++)
        {
            Console.Write(new string('.', row));
            Console.Write("*");
            Console.Write(new string('.', ((5 * n) - (2 * row) - 2)));
            Console.Write("*");
            Console.WriteLine(new string('.', row));
        }
        //last line:
        Console.Write(new string('.', (2 * n) + 1));
        Console.Write(new string('*', n - 2));
        Console.WriteLine(new string('.', (2 * n) + 1));
    }
}

