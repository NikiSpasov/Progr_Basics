using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        var n = int.Parse(Console.ReadLine());
        var max = int.MinValue;
        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > max)
            {
                max = num;
            }     
        }
        Console.WriteLine("max = " + max);
    }
}