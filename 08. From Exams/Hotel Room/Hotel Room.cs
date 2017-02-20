using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string month = Console.ReadLine();
        double nightStay = double.Parse(Console.ReadLine());
        double priceApp = 0;
        double priceStd = 0;

        if (month == "May" || month == "October")
        {
            if (nightStay < 15)
            {
                priceApp = nightStay * 65;
                if (nightStay > 7)
                {
                    priceStd = nightStay * 50 - (nightStay * 50) * 0.05;
                }
                else
                {
                    priceStd = nightStay * 50;
                }
            }
            else
            {
                priceStd = nightStay * 50 - (nightStay * 50) * 0.3;  
                priceApp = (nightStay * 65) - (nightStay * 65 * 0.1);
            }

        }
        else if (month == "June" || month == "September")
        {
            if (nightStay < 15)
            {
                priceApp = nightStay * 68.70;
                priceStd = nightStay * 75.20;
            }
            else
            {
                priceApp = (nightStay * 68.70) - (nightStay * 68.70 * 0.1);
                priceStd = (nightStay * 75.20) - (nightStay * 75.20) * 20 / 100;
            }
        }
        else
        {
            if (nightStay < 15)
            {
                priceApp = nightStay * 77;
            }
            else
            {
                priceApp = (nightStay * 77) - (nightStay * 77 * 0.1);
            }
            priceStd = nightStay * 76;
        }

        Console.WriteLine("Apartment: {0:f2} lv.", priceApp);
        Console.WriteLine("Studio: {0:f2} lv.", priceStd);
    }
}
