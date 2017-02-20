using System;

class Program
{
    static void Main(string[] args)
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double heightH = double.Parse(Console.ReadLine());

       double area = ((sideA + sideB) * heightH ) / 2;

        Console.WriteLine("{0:0.0000000}", area);
    }
}