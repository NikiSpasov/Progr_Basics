using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        for (int firstN = a; a < b; a++)
        {
            for (int secondN = a + 1; secondN > firstN; secondN++)
            {
                for (int thirdN = a + 2; thirdN > secondN; thirdN++)
                {
                    for (int fourhtN = a + 3; fourhtN <= b; fourhtN++)
                    {
                        Console.WriteLine("{0}{1}{2}{3}", firstN, secondN, thirdN, fourhtN);
                    }
                }
            }
        }
    }
}