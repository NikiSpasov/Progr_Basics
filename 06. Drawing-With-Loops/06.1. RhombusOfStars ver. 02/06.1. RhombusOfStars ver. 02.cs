using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n - r; c++)
            {
                Console.Write(" ");
            }
            for (int s = 0; s <= r; s++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        for (int r = 1; r <= n - 1; r++)
        {
            for (int i = 0; i <= r; i++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < n - r; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}