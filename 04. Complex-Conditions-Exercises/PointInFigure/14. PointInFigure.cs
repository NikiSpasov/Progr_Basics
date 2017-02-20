using System;

class Program
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int x1 = 3 * h;
        int y1 = h;

        if (x >= 0 && x <= x1 && y == 0)
        {
            Console.WriteLine("border");
        }
        else if (y > 0 && y <= h && x == 0)
        {
            Console.WriteLine("border");
        }
        else if (y == h && x >= 0 && x >= 2 * h && x <= x1)
        {
            Console.WriteLine("border");
        }
        else if (y == h && x >= 0 && x < h)
        {
            Console.WriteLine("border");
        }
        else if (x == x1 && y >= 0 && y <= h)
        {
            Console.WriteLine("border");
        }
        else if (x == h && y >= h && y <= 4 * h)
        {
            Console.WriteLine("border");
        }
        else if (x == 2 * h && y >= h && y <= 4 * h)
        {
            Console.WriteLine("border");
        }
        else if (x >= h && x <= 2 * h && y == 4 * h)
        {
            Console.WriteLine("border");
        }

        else if (x > 0 && x < x1 && y > 0 && y < h)
        {
            Console.WriteLine("inside");
        }
        else if (x > h && x < 2 * h && y < 4 * h && y > 0)
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }    
    }
}