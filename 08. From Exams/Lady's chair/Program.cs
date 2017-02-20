using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n * 2; i++)
        {
            if (i == (n * 2) - 1)
            {
                Console.Write(new string (' ', n / 2));
                Console.Write(new string('@', n / 2));
                Console.Write(new string('-', n/2));
                Console.Write(new string('@', n / 2));
                Console.WriteLine();
            }
            else if (i < (n * 2) - 3)
            {
                Console.Write(new string(' ', n / 2));
                Console.Write(new string('@', n / n));
                Console.Write(new string('-', n - 2));
                Console.Write(new string('@', n / n));
                Console.WriteLine();
            }
            else if (i == 0)
            {
                Console.Write(new string(' ', n * 2));
                Console.Write("|");
                Console.Write(new string ('-', n / 2));
                Console.Write("|");
            }
        }
    }
}
