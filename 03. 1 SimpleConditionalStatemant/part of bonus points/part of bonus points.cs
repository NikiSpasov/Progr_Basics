using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter score: ");
        double num = double.Parse(Console.ReadLine());

        if (num <= 100 && (num % 2) == 0)
        {
            Console.WriteLine("Bonus score: 6");
            Console.WriteLine("Total score: " + (num + 6));
        }
        else if (num <= 100 && (num % 10) == 5)
        {
                Console.WriteLine("Bonus score: 7");
                Console.WriteLine("Total score: " + (num + 7));
        }
        else if (num <= 100)
        {
                Console.WriteLine("Bonus score: 5");
                Console.WriteLine("Total score: " + (num + 5));
        }

        if (true)
        {

        }
    
    }
}