using System;

class Program
{
    static void Main(string[] args)
    {
        double weightOnEarth = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:0.000}", (weightOnEarth * 17 / 100));
    }
}