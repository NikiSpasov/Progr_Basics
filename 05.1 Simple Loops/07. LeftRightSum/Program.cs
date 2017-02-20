
//Да се напише програма, която въвежда 2* n цели числа и проверява дали сумата на първите
// n числа(лява сума) е равна на сумата на вторите n числа(дясна сума).
//При равенство печата "Yes" + сумата; иначе печата "No" + разликата.
// Разликата се изчислява като положително число(по абсолютна стойност).

using System;
class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var leftSum = 0;
        var rightSum = 0;

        for (int i = 0; i < n; i++)
        {
            var firstNum = int.Parse(Console.ReadLine());
            leftSum += firstNum;
        }
        for (int i = 0; i < n; i++)
        {
            var secondNum = int.Parse(Console.ReadLine());
            rightSum += secondNum;
        }

        if (leftSum == rightSum)
        {
            Console.WriteLine("yes sum {0}", leftSum);
        }
        else
        {
            var result = Math.Abs(leftSum - rightSum);
            Console.WriteLine("no diff {0}", result);

            //TO-DO: Why "("no diff " + result)" working and "no diff {1}", result doesn't?
        }
    }
}

