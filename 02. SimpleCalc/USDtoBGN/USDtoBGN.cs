using System;

class USDtoBGN
{
    static void Main()
    {
        decimal USD = decimal.Parse(Console.ReadLine());
        decimal BGN = USD * 1.79549m;
        Console.WriteLine(Math.Round(BGN, 2));
    }
}