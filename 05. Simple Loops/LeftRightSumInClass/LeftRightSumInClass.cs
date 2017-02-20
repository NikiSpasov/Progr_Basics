using System;

class LeftRightSumInClass
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;
        for (int i = 0; i < n; i++)
        {  
            leftSum += int.Parse(Console.ReadLine()); 
        }
        for (int i = 0; i < n; i++)
        {
            rightSum += int.Parse(Console.ReadLine());
        }
        if (leftSum == rightSum)
        {
            Console.WriteLine("Yes, sum = {0}", (rightSum + leftSum) /2);
        }
        else
        {
            Console.WriteLine("No, diff = {0}", Math.Abs(rightSum - leftSum));
        }
    }
}
//Да се напише програма, която въвежда 2* n цели числа и проверява дали сумата 
//    на първите n числа(лява сума) е равна на сумата на вторите n числа(дясна сума).
//При равенство печата "Yes" + сумата; иначе печата "No" + разликата.Разликата се изчислява 
//    като положително число(по абсолютна стойност). Примери: