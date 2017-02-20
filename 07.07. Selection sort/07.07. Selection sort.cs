using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static object SwapInts { get; private set; }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minNum = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minNum])
                {
                    minNum = j;
                }
            }
            if (minNum != i)
            {
                int temp = arr[i]; // Copy the first position's element
                arr[i] = arr[minNum]; // Assign to the second element
                arr[minNum] = temp; // Assign to the first element
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
