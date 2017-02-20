using System;

class EvenOrOdd
{
    static void Main()
    {
        var num = double.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    } 
}

