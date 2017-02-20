using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int plusNum = 1;
        for (int row = 0; row < n; row++)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(plusNum + i + " ");
            }
            Console.WriteLine();
            plusNum++;
        }
    }
}
