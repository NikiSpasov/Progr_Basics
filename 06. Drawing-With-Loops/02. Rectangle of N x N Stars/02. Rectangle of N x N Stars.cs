﻿using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < a; i++)
        {
            Console.WriteLine(new string('*', a));
        }
    }
}
