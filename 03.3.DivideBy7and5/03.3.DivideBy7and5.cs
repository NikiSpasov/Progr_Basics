using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine((n % 5 == 0 && n % 7 == 0) ? "true " + n : "false " + n);
    }
}
