using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        double result = 0;

        double lastDigit = num % 10;
        int secondDigit = (num / 10) % 10;
        int firstDigit = (num / 100) % 10;

        if (secondDigit % 2 == 0)
        {
            result = (firstDigit + secondDigit) * lastDigit;
        }
        else
        {
            result = (firstDigit * secondDigit) / lastDigit;
        }

        Console.WriteLine("{0:f2}", result);
    }
}