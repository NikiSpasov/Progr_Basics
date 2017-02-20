using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            int num = row + 1;
            while (num <= n)
            {
                Console.Write(num + " ");
                num++;
            }

            for (int secCol = 1; secCol <= row; secCol++)
            {
                int secNum = n;
                Console.Write((secNum - secCol) + " ");
            }
            Console.WriteLine();
        }
    }
}

