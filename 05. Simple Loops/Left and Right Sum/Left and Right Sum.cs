////Да се напише програма, която въвежда 2* n цели числа и проверява дали 
//сумата на първите n числа(лява сума) е равна 
// на сумата на вторите n числа(дясна сума). 
//При равенство печата "Yes" + сумата; иначе печата "No" + разликата.
// Разликата се изчислява като положително число(по абсолютна стойност).

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;
        
        for (int i = 0; i < n; i++)
        {
            int currentLeftNum = int.Parse(Console.ReadLine());
            leftSum += currentLeftNum;
        }
        for (int i = 0; i < n; i++)
        {
            int currentRightNum = int.Parse(Console.ReadLine());
            rightSum += currentRightNum;
        }
        if (leftSum == rightSum)
        {
            Console.WriteLine("Yes, sum = {0}", leftSum);
        }
        else
        {
            Console.WriteLine("No, diff = {0}", Math.Abs(leftSum - rightSum));
        }
       
    }
}
