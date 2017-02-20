using System;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int bitOfNum = int.Parse(Console.ReadLine());
        int mask = 1 << bitOfNum;
        int nAndMask = num & mask;
        int bit = nAndMask >> bitOfNum;
        Console.WriteLine(bit);
    }
}