using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        int evenNumber = 0;
        int oddNumber = 0;
        int numAll = 0;
        int maxEven = 0;
        int maxOdd = 0;
        int oddTotal = 0;
        int evenTotal = 0;
        int minEven = 0;
        int minOdd = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > max)
            {
                max = num;
                if (max % 2 == 0)
                {
                    maxEven = max;
                }
                else
                {
                    maxOdd = max;
                }
            }
            numAll = num + numAll;
            if (num < min)
            {
                min = num;
                if (min % 2 == 0)
                {
                    minEven = min;
                }
                else
                {
                    minOdd = min;
                }
            }
            if (i % 2 == 0)
            {
                evenNumber = num;
                evenTotal = +num;
            }
            else
            {
                oddNumber = num;
                oddTotal = +num;
            }

            //минимума и максимума на числата на четни и нечетни позиции:
            Console.WriteLine("OddSum = {0}", oddTotal); //OddSum
            Console.WriteLine("OddMin = {0}", minOdd); //OddMin
            Console.WriteLine("OddMax = {0}", maxOdd); //OddMax
            Console.WriteLine("EvenSum = {0}", evenTotal); //EvenSum
            Console.WriteLine("EvenMin = {0}", minOdd);  //EvenMin
            Console.WriteLine("EvenMax = {0}", maxEven); //EvenMax

        }
    }
}

//Напишете програма, която чете n числа и
//пресмята сумата, минимума и максимума на числата на четни и нечетни позиции(броим от 1). 
//Когато няма минимален / максимален елемент, отпечатайте “No”. 