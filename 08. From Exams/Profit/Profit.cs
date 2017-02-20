using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int workindDays = int.Parse(Console.ReadLine());
        double moneyPerDay = double.Parse(Console.ReadLine());
        double levaForDolar = double.Parse(Console.ReadLine());
        double moneyPerMonth = moneyPerDay * workindDays;
        double bonusMoney = 2.5 * moneyPerMonth;
        double totalMoney = 
            (bonusMoney + moneyPerMonth * 12) - 
            (bonusMoney + moneyPerMonth * 12) * 25/100;
        double averageMoney = (totalMoney / 365) * levaForDolar;

        Console.WriteLine("{0:f2}", averageMoney);   

    }
}

