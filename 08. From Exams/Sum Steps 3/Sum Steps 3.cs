using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;
        int addPosition = 0;
        int addPosition1 = 0;
        int addPosition2 = 0;

        for (int i = 0; i < n; i++)
        {
            int nums = int.Parse(Console.ReadLine());

            if (i ==  0 + addPosition)
            {
                sum1 += nums;
                addPosition += 3;
            }
            if (i == 1 + addPosition1)
            {
                sum2 += nums;
                addPosition1 += 3;

            }
            if (i == 2 + addPosition2)
            {
                sum3 += nums;
                addPosition2 += 3;
            }
        }
        Console.WriteLine("sum1 = {0}", sum1);
        Console.WriteLine("sum2 = {0}", sum2);
        Console.WriteLine("sum3 = {0}", sum3);
    }
}