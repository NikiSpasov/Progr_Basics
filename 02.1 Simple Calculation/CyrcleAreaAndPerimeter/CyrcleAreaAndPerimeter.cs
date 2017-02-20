using System;


class CyrcleAreaAndPerimeter
{
    static void Main()
    {
        var r = double.Parse(Console.ReadLine());
        double area = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;
        Console.WriteLine(area);
        Console.WriteLine(perimeter);
    }
}