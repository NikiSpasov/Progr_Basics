using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        // This is the half circle
        bool insideCircle = Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= Math.Pow(1.5, 2);
        // This is rectangle on the circle
        bool outsideRectangleInCircle = (x > -0.5 && x <= 2.5) && (y > 1 && y <= 2.5);
        // Both statements must be true to be valid
        bool insideCircleOutsideRectangle = insideCircle && outsideRectangleInCircle;

        if (insideCircle == true)
        {
            Console.Write("inside circle ");
        }
        else
        {
            Console.Write("outside circle ");
        }
        if ((x >= -1 && x <= 5) && (y >= -1 && y <= 1))
        {
            Console.WriteLine("inside rectangle");
        }
        else
        {
            Console.WriteLine("outside rectangle");
        }
    }
}
