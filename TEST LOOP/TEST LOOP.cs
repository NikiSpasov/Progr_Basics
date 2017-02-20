using System;
class DeckOfCards
{
    static void Main()
    {
        int sum = 0;
        int tempSum;
        int n = int.Parse(Console.ReadLine());
        int i = int.Parse(Console.ReadLine());
        int a = n;
        for (int j = 1; j < i; j++)
        {

            sum = a * n;
            n = sum;
            
        }
        Console.WriteLine(n);

    }
}