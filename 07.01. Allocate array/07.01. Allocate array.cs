using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int arrLenght = int.Parse(Console.ReadLine());
        int[] arr = new int[arrLenght];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i * 5;
            Console.WriteLine(arr[i]);
        }
    }
}

