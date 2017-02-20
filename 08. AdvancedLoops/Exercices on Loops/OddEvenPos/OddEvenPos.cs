
//Напишете програма, която чете n числа и пресмята сумата, минимума и максимума на числата на четни и
//    нечетни позиции(броим от 1). Когато няма минимален / максимален елемент, отпечатайте “No”. (Odd / Even Positions)

using System;

class Program
{
    static void Main()
    {
        double oddMax = 0;
        double oddMin = 0;
        double evenMax = 0;
        double evenMin = 0;
        double sumEven = 0;
        double sumOdd = 0;
        double maxValue = double.MaxValue;
        double maxValue1 = double.MaxValue; // как да бъдат избегнати адаването на две променливи с еднаква стойност?
        double minValue = double.MinValue;//проблемът ако използваш само една е, че след като завърти през цикъла и си 
        double minValue1 = double.MinValue;// променя стойността и след това не работи коректно.

        double n = double.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            double enterNumber = double.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                double sumEvenTemp = 0; 
                sumEvenTemp = enterNumber;
                sumEven += sumEvenTemp;

                if (enterNumber > minValue1)
                {
                    minValue1 = enterNumber;
                    evenMax = minValue1;
                }
                if (enterNumber < maxValue1)
                {
                    maxValue1 = enterNumber;
                    evenMin = maxValue1;
                }
            }
            else
            {
                double sumOddTemp = 0;
                sumOddTemp = enterNumber;
                sumOdd += sumOddTemp;
                if (enterNumber > minValue)
                {
                    minValue = enterNumber;
                    oddMax = minValue;
                }
                if (enterNumber < maxValue)
                {
                    maxValue = enterNumber;
                    oddMin = maxValue;
                }
            }
        }
        if (n > 1) //тук по-долу съм обработил "No" случая. Това обаче не ми харесва, по каруцаркси начин е и по-скоро 
            //е нагласен за целите на самата задача. Има ли по-адекватен метод, когато липсва нещо на позицията odd примерно,
            //да изписва "No", както е в условието на задачата.
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                sumOdd,
                oddMin,
                oddMax,
                sumEven,
                evenMin,
                evenMax);
        }
        else if (n == 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum=0, EvenMin=No, EvenMax=No", sumOdd);
        }                
        else if (n==0)
        {

            Console.WriteLine("OddSum=0, OddMin=No, OddMax=No, EvenSum=0, EvenMin=No, EvenMax=No");
        }        
    }
}

