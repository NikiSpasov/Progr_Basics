using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int minNumber = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            if (currentNumber < minNumber)
            {
                minNumber = currentNumber;
            }
        }
        Console.WriteLine(minNumber);
    }
}