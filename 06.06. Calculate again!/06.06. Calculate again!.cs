using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger result;
        BigInteger factN = 1;
        BigInteger factk = 1;

        for (int i = 1; i <= n; i++)
        {
            factN *= i;
        }
        for (int i = 1; i <= k; i++)
        {
            factk *= i;
        }
        result = factN / factk;
        Console.WriteLine(result);
    }
}
