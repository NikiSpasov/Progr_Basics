using System;

class testDraw
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.Write("+");
        for (int i = 0; i < (n * 2) - 3; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write("-");
            }
        }
        Console.WriteLine("+");

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("|");
            for (int j = 0; j < (n * 2) - 3; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine("|");
        }

        Console.Write("+");
        for (int i = 0; i < (n * 2) - 3; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write("-");
            }
        }
        Console.WriteLine("+");
    }
}