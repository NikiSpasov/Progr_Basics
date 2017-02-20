using System;

class QuadraticEquation
{
    static void Main()
    {

        double a = double.Parse(Console.ReadLine()); //2
        double b = double.Parse(Console.ReadLine()); //5
        double c = double.Parse(Console.ReadLine());//-3
                                                    //5*5      4 * 2 * -3
        double discriminant = (b * b) - (4 * a * c);
        if (discriminant > 0)
        {
            double x2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            double x1 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("{0:f2}", x1);
            Console.WriteLine("{0:f2}", x2);
        }
        else if (discriminant == 0)
        {
            double x1Andx2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("{0:f2}", x1Andx2);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
    }
}

