using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int sum = 0;
        if (n == 1)
        {
            Console.WriteLine("0");
            return;
        }
        else if (n == 2)
        {
            Console.WriteLine("0, 1");
            return;

        }
        else if (n == 3)
        {
            Console.WriteLine("0, 1, 1");
            return;
        }
        Console.Write("0, 1");
        for (int i = 0; i < n - 2; i++)
        {
            sum = a + b;
            a = b;
            b = sum;           
            Console.Write(", " + sum);
        }
        Console.WriteLine();
    }
}

