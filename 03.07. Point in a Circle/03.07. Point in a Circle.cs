using System;

class Program
{
    static void Main(string[] args)
    {
        int r = 2;
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double distance = Math.Sqrt((x * x + y * y));

        if ((x * x) + (y * y) <= (r * r))
        {
            Console.WriteLine("yes " + "{0:0.00}", distance);
        }
        else
        {
            Console.WriteLine("no " + "{0:0.00}", distance);
        }
    }
}
