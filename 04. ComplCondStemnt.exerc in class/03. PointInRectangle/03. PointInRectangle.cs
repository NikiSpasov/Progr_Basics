using System;

namespace _03.PointInRectangle
{
    class Program
    {
        static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            if (x >= x1 && x <= x2 && y <= y2 && y >= y1)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}

//(x >= x1)
//•	Точката е наляво от дясната стена на правоъгълника(x <= x2)
//•	Точката е надолу от горната стена на правоъгълника(y >= y1)
//•	Точката е нагоре от долната стена на правоъгълника(y <= y2)
