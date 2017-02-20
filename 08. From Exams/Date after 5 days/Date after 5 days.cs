using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        day += 5;


        if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            
            if (day>30)
            {
                day = day - 30;
                month++;
            }
        }
        else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10)
        {
            if (day > 31)
            {
                day = day - 31;
                month++;
            }
        }
        else if (month == 12)
        {

            if (day > 31)
            {
                day = day - 31;
                month = 1;
            }
        }
        else
        {
            if (day > 28)
            {
                day = day - 28;
                month++;
            }
        }
        Console.WriteLine("{0}.{1:00}", (day), month); 
    }
}
