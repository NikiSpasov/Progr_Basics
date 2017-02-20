using System;

class EqualPairs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double nextSum = 0;
        bool equal = true;
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double coupleSum = firstNum + secondNum;
        double maxDiff = 0;
        double tempNextSum = 0;



        if (firstNum == secondNum && n == 1)
        {
            Console.WriteLine("Yes, value={0}", coupleSum);
            return;
        }

        for (int i = 0; i < n - 1; i++)
        {
            double nextNum = double.Parse(Console.ReadLine());
            double nextNum1 = double.Parse(Console.ReadLine());
            tempNextSum = nextSum;
            nextSum = nextNum + nextNum1;            
            if (nextSum == coupleSum)
            {
                equal = false;
            }
        }
        if (equal)
        {
            Console.WriteLine("Yes, value={0}", coupleSum);
            return;
        }
        else
        {
            double firstDiff = Math.Abs(nextSum - coupleSum);
            double secondDiff = Math.Abs(tempNextSum - nextSum);
            if (n < 3)
            {
                Console.WriteLine("No, maxdiff={0}", firstDiff);
                return;
            }
            
            if (firstDiff >= secondDiff)
            {
                maxDiff = firstDiff;
            }
            else
            {
                maxDiff = secondDiff;
            }
        }
        Console.WriteLine("No, maxdiff={0}", maxDiff);
    }
}