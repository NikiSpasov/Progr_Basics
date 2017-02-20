using System;

class Program
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());     
        double area = Math.PI * Math.Pow(radius, 2);
        double perimeter = Math.PI * 2 * radius;

        Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
    }
}

