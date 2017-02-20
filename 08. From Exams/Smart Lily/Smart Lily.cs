using System;
using System.Collections.Generic;
using System.Linq;
class SmartLily
{
    static void Main()
    {
        int ageOfLily = int.Parse(Console.ReadLine());
        double costOfWashingMachine = double.Parse(Console.ReadLine());
        int sellPriceToy = int.Parse(Console.ReadLine());
        double totalMoneySaved = 0;
        int tempMoney = 0;
        int cnt = 0;
        for (int i = 1; i <= ageOfLily; i++)
        {
            if ((i & 1) == 0)
            {
                
                tempMoney += (i/2) * 10;
                tempMoney--;
            }
            else
            {
                cnt++;
            }
        }
        totalMoneySaved = tempMoney + (cnt * sellPriceToy);
        if (totalMoneySaved < costOfWashingMachine)
        {
            Console.WriteLine("No! {0:f2}", (costOfWashingMachine - totalMoneySaved));
        }
        else
        {
            Console.WriteLine("Yes! {0:f2}", (totalMoneySaved - costOfWashingMachine));
        }
    }
}
