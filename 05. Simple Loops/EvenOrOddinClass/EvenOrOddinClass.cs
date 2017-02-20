using System;

class EvenOrOddinClass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int OddPositions = 0;
        int EvenPositions = 0;

        for (int i = 0; i < n ; i++)
        {
            if (i % 2 == 0)
            {
                EvenPositions = int.Parse(Console.ReadLine());
                EvenPositions += EvenPositions;
            }
            else
            {
                OddPositions = int.Parse(Console.ReadLine());
                OddPositions += OddPositions;
            }
        }
        if (EvenPositions == OddPositions)
        {
            Console.WriteLine("Yes Sum = " + (EvenPositions + OddPositions));
        }
        else
        {
            Console.WriteLine("No, diff = {0}", Math.Abs(EvenPositions - OddPositions));
        }
    }
}

//Да се напише програма, която въвежда n цели числа и проверява дали сумата от числата на четни позиции е равна
//    на сумата на числата на нечетни позиции.При равенство да се отпечата "Yes" + сумата; иначе 
//    да се отпечата "No" + разликата.Разликата се изчислява по абсолютна стойност.Примери: