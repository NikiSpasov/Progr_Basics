using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;
        for (int i = 0; i < n; i++)
        {
            int curNum = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenSum += curNum;
            }
            else
            {
                oddSum += curNum;
            }
        }
        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = {0}", oddSum);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Diff = {0}", Math.Abs(oddSum - evenSum));
        }
    }
}

