﻿using System;
class Program
{
    static void Main()
    {
        var product = Console.ReadLine().ToLower();
        var city = Console.ReadLine().ToLower();
        var quantity = double.Parse(Console.ReadLine());

        if (city == "sofia")
        {
            if (product == "beer")
            {
                Console.WriteLine(quantity * 1.2);
            }
            else if (product == "coffee")
            {
                Console.WriteLine(quantity * 0.5);
            }
            else if (product == "peanuts")
            {
                Console.WriteLine(quantity * 1.6);
            }
            else if (product == "sweets")
            {
                Console.WriteLine(quantity * 1.45);
            }
            else
            {
                Console.WriteLine(quantity * 0.8);
            }
        }

        if (city == "plovdiv")
        {
            if (product == "beer")
            {
                Console.WriteLine(quantity * 1.15);
            }
            else if (product == "coffee")
            {
                Console.WriteLine(quantity * 0.4);
            }
            else if (product == "peanuts")
            {
                Console.WriteLine(quantity * 1.5);
            }
            else if (product == "sweets")
            {
                Console.WriteLine(quantity * 1.30);
            }
            else
            {
                Console.WriteLine(quantity * 0.7);
            }
        }
        if (city == "varna")
        {
            if (product == "beer")
            {
                Console.WriteLine(quantity * 1.1);
            }
            else if (product == "coffee")
            {
                Console.WriteLine(quantity * 0.45);
            }
            else if (product == "peanuts")
            {
                Console.WriteLine(quantity * 1.55);
            }
            else if (product == "sweets")
            {
                Console.WriteLine(quantity * 1.35);
            }
            else
            {
                Console.WriteLine(quantity * 0.7);
            }
        }
    }
}
