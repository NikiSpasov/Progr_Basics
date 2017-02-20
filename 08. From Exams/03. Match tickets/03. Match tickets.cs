using System;

class Program
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        string NVip = Console.ReadLine();
        int men = int.Parse(Console.ReadLine());

        double transportValue = 0;
        double moneyForTickets = 0;
        double restMoney;

        if (men > 0 && men < 5)
        {
            transportValue = (money * 75) / 100;
        }
        else if (men > 4 && men < 10)
        {
            transportValue = (money * 60) / 100;
        }
        else if (men > 9 && men < 25)
        {
            transportValue = (money * 50) / 100;
        }
        else if (men > 24 && men < 50)
        {
            transportValue = (money * 40) / 100;
        }
        else
        { 
            transportValue = (money * 25) / 100;
        }

        moneyForTickets = (NVip == "VIP") ? men * 499.99 : men * 249.99;
        if (money - transportValue >= moneyForTickets)
        {
            Console.WriteLine("Yes! You have {0:0.00} leva left.", (money - moneyForTickets - transportValue));
        }
        else
        {
            Console.WriteLine("Not enough money! You need {0:0.00} leva.", (moneyForTickets + transportValue - money));
        }

    }
}
