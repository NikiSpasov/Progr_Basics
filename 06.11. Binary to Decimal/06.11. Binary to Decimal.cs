using System;

class Program
{
    static void Main()
    {
        string binaryNum = Console.ReadLine();
        long res = 0;
        for (int i = 0; i < binaryNum.Length; i++)
        {
            if (binaryNum[binaryNum.Length - i - 1] == '0')
            {
                continue;
            }
            res += (long)Math.Pow(2, i);
        }
        Console.WriteLine(res);
    }
}