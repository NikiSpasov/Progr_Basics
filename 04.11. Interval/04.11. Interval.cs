﻿using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int cnt = 0;
        for (int i = n + 1; i < m; i++)
        {
            if (i % 5 ==0)
            {
                cnt++;
            }
        }
        Console.WriteLine(cnt);

    }
}
