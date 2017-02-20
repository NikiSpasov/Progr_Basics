using System;

class Program
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());


        if ((x < 0 || x>h) && (y < 0 || y>h))
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

