using System;

class Program
{
    static void Main()
    {
        int howManyNumbersToCalc = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < howManyNumbersToCalc;)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
            i++;
        }
        Console.WriteLine(sum);
    }
}