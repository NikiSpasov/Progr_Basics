using System;

class Program
{
    static void Main()
    {
        double inherited = double.Parse(Console.ReadLine());
        int yearToLive = int.Parse(Console.ReadLine());
        double moneyNeeded = 0.00;
        int cnt = 18;

        for (int i = 1800; i <= yearToLive; i++)
        {
            
            if ((i & 1) == 0)
            {
                moneyNeeded += 12000;
            }
            else
            {
                moneyNeeded += 12000 + (50 * cnt);
            }
            cnt++; 
        }
        if (inherited < moneyNeeded)
        {
            Console.WriteLine("He will need {0:0.00} dollars to survive.", moneyNeeded - inherited);
        }
        else
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:0.00} dollars left.", inherited - moneyNeeded);
        }
    }
}

