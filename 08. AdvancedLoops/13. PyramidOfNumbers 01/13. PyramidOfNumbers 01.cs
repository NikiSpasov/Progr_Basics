using System;

class testLoops
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(x + " ");
                x++;

                if (x > n)
                {
                    return;
                }
            }
            Console.WriteLine();
        }
    }
}


