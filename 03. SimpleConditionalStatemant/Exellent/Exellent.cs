﻿using System;

class Program
{
    static void Main()
    {
        var a = double.Parse(Console.ReadLine());
        if (a >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not Excellent.");
        }
    }
}