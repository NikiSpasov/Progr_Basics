using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double a = 0;
        for (int i = 0; i < n; i++)
        {
            double number = int.Parse(Console.ReadLine());
            a += number;
        }
        Console.WriteLine(a);
    }
}