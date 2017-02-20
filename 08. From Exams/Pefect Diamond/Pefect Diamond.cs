using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string(' ', n - i - 1));
            Console.Write("*");
            for (int j = 0; j < i; j++)
            {
                Console.Write("-*");
            }
            Console.WriteLine();        
        }
        for (int i = 1; i < n; i++)
        {
            Console.Write(new string(' ', i));
            Console.Write("*");
            for (int j = 1; j < n - i; j++)
            {
                Console.Write("-*");
            }
            Console.WriteLine();
        }
    }
}

