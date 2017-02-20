using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(((n / 100) % 10 == 7) ? "true" : "false " + ((n / 100) % 10));
    }
}