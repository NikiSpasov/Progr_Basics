using System;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        int sumEven = 0;
        int sumOdd = 0;
        for (int i = 0; i < n; i++)
        {
            int curNum = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                sumEven += curNum;
            }
            else
            {
                sumOdd += curNum;
            }
        }  
        if (sumOdd == sumEven)
        {
            Console.WriteLine("Yes sum = {0}", sumOdd);
        }
        else
        {
            var result = Math.Abs(sumOdd - sumEven);
            Console.WriteLine("No diff = {0}", result );
        }
    }
}
