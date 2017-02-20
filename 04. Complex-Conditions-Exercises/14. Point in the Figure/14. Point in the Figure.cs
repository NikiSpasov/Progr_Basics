using System;

class Program
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

  
            int x1 = 0;
            int y1 = 0;

        int x2 = 3 * h;
        int y2 = h;

        int x3 = h;
        int y3 = h;

        int x4 = 2 * h;
        int y4 = 4 * h;


        if ((x>x1 && x < x2 && y > y1  || y > 4 * h))
        {
            Console.WriteLine("outside");
        }
        else if ((x > 0 || x < h) && (y > 0 || y < h))
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("border");
        }
           
    }
}

