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
        double tempNextSum = 0;
        double currentMax = 0;
        nextSum = coupleSum;

        for (int i = 0; i < n - 1; i++)
        {
            double nextNum = double.Parse(Console.ReadLine());
            double nextNum1 = double.Parse(Console.ReadLine());
            tempNextSum = nextSum;
            nextSum = nextNum + nextNum1;
            if (nextSum != coupleSum)
            {
                equal = false;
            }
            if (Math.Abs(nextSum - tempNextSum) > currentMax)
            {
                currentMax = Math.Abs(nextSum - tempNextSum);
            }

        }
        if (equal)
        {
            Console.WriteLine("Yes, value={0}", coupleSum);
            return;
        }
        else
        {

            Console.WriteLine("No, maxdiff={0}", currentMax);
        }

    }
}