using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] myarr = new int[n];
        for (int i = 0; i < n; i++)
        {
            myarr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(myarr);
        string[] strings = myarr.Select(x=>x.ToString()).ToArray();

        Console.WriteLine(string.Join("\n", strings));
  
    }
}