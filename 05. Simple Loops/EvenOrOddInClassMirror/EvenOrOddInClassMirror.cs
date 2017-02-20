using System;

class EvenOrOddinClass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int OddPositionsSum = 0;
        int EvenPositionsSum = 0;

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                int EvenPositions = int.Parse(Console.ReadLine());
                EvenPositionsSum += EvenPositions;
            }
            else
            {
                int OddPositions = int.Parse(Console.ReadLine());
                OddPositionsSum += OddPositions;
            }
        }
        if (EvenPositionsSum == OddPositionsSum)
        {
            Console.WriteLine("Yes Sum = " + EvenPositionsSum);
        }
        else
        {
            Console.WriteLine("No, diff = {0}", Math.Abs(EvenPositionsSum - OddPositionsSum));
        }
    }
}

//Да се напише програма, която въвежда n цели числа и проверява дали сумата от числата на четни позиции е равна
//    на сумата на числата на нечетни позиции.При равенство да се отпечата "Yes" + сумата; иначе 
//    да се отпечата "No" + разликата.Разликата се изчислява по абсолютна стойност.Примери: