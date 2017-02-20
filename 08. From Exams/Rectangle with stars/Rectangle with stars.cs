using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('%', 2 * n));

        if ((n & 1) == 0)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (i == (n / 2) - 1 )
                {
                    Console.Write("%");
                    Console.Write(new string(' ', (n - 2)));
                    Console.Write("**");
                    Console.Write(new string(' ', (n - 2)));
                    Console.WriteLine("%");
                }
                else
                {
                    Console.Write("%");
                    Console.Write(new string(' ', (n * 2) - 2));
                    Console.WriteLine("%");
                }
            }
        }
        else
            for (int i = 0; i < n; i++)
            {
                if (i == (n / 2))
                {
                    Console.Write("%");
                    Console.Write(new string(' ', (n - 2)));
                    Console.Write("**");
                    Console.Write(new string(' ', (n - 2)));
                    Console.WriteLine("%");
                }
                else
                {
                    Console.Write("%");
                    Console.Write(new string(' ', (n * 2) - 2));
                    Console.WriteLine("%");
                }
            }

        Console.WriteLine(new string('%', 2 * n));
    }
}
