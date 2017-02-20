using System;
class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        if ((x >= a && x <= b))
        {
            Console.WriteLine("in");
            if ((x - a) <= (b - x))
            {
                Console.WriteLine(x - a);
            }
            else
            {
                Console.WriteLine(Math.Abs(x - a));
            }
        }
        else if ((x >= b && x <= a))
        {
            Console.WriteLine("in");
            if ((x - b) <= (a - x))
            {
                Console.WriteLine(x - b);
            }
            else
            {
                Console.WriteLine(a - x);
            }
        }

        else
        {
            Console.WriteLine("out");
            if ((a < b) && (x < a))
            {
                Console.WriteLine (Math.Abs(a - x));
            }
            else if ((a < b) && (x > b))
            {
                Console.WriteLine (Math.Abs(x - b));
            }
            else if ((a > b) && (x < b))
            {
                Console.WriteLine(Math.Abs(b - x));
            }
            else if ((a > b) && (x > a))
            {
                Console.WriteLine(Math.Abs(a - x));
            }     
        }
    }
}
