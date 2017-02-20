using System;

class Comparing_floats
{
    static void Main(string[] args)
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double a = Math.Abs(firstNum - secondNum);

        if (a == 0 || a < 0.000001)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

