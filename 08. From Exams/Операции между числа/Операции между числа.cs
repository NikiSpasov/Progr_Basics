using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        string opp = Console.ReadLine();
        double result = 0;
        if (opp == "+")
        {
            result = a + b;
            Console.Write("{0} + {1} = {2}", a, b, result);
        }
        else if (opp == "-")
        {
            result = a - b;
            Console.Write("{0} - {1} = {2}", a, b, result);
        }
        else if (opp == "*")
        {
            result = a * b;
            Console.Write("{0} * {1} = {2}", a, b, result);
        }
        if (result % 2 == 0 && result != 0)
        {
            Console.WriteLine(" - even");
        }
        else if (result % 2 != 0 || result != 0)
        {
            Console.WriteLine(" - odd");
        }

        if (b == 0 && (opp == "/" || opp == "%"))
        {
            Console.WriteLine($"Cannot divide {a} by zero");
            return;
        }

        if (opp == "/")
        {
            result = a / b;
            Console.WriteLine("{0} / {1} = {2:f2}", a, b, result);
        }
        else if (opp == "%")
        {    
            result = a % b;
            Console.WriteLine("{0} % {1} = {2}", a, b, result);
        }
    }

}
