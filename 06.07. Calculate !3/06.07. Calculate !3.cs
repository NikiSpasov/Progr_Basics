using System;
using System.Numerics;
//N! / (K! * (N - K)!) for given N and K.
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factN = 1;
        BigInteger factK = 1;
        BigInteger factNK = 1;

        for (int i = 1; i <= n; i++)
        {
            factN *= i;
        }
        for (int i = 1; i <= k; i++)
        {
            factK *= i;
        }
        for (int i = 1; i <= (n - k); i++)
        {
            factNK *= i;
        }
        Console.WriteLine(factN / (factK * factNK));
    }
}