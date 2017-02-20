using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] myArr = new int[n];

        int maxSum = 0;
        int min = int.MinValue;
        for (int i = 0; i < myArr.Length; i++)
        {
            myArr[i] = int.Parse(Console.ReadLine());
        }
        for(int j = 0; j < myArr.Length - 1; j++)
        {
            for (int i = 0 + j; i < myArr.Length; i++)
            {
                maxSum += myArr[i];
                if (maxSum > min)
                {
                    min = maxSum;
                }
            }
        }
        Console.WriteLine(string.Join(", ", myArr));



        Console.WriteLine(min);
    }
}