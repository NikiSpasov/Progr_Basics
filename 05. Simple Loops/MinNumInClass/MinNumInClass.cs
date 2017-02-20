using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        var n = int.Parse(Console.ReadLine());
        var min = int.MaxValue;
        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < min)
            {
                min = num;
            }
        }
        Console.WriteLine("min = " + min);
    }
}
