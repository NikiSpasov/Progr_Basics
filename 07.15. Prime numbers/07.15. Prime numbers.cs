using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] arr = new bool[n];
        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            if (arr[i] == true)

            {
                int j = 0;
                for (j = (i * i) + (i * j); j < n; j++)
                {
                    arr[j] = false;
                }
            }
            Console.WriteLine(arr[i]);
        }
    }
}