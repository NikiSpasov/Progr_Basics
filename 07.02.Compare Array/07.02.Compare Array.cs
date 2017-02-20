using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstArr = new int[n];
        bool equal = true;
        for (int i = 0; i < n; i++)
        {
            firstArr[i] = int.Parse(Console.ReadLine());
        }
        int[] secArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            secArr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            if (firstArr[i] == secArr[i])
            {
                equal = true;
            }
            else
            {
                equal = false;
            }
        }
        if (equal)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}